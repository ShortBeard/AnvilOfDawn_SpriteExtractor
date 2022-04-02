using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
namespace Anvil_Of_Dawn___Sprite_Extractor
{
    public class D3grFrame
    {
        public uint startOffset;
        public byte[] pixels;
        public ushort width;
        public ushort height;
        public uint frame_flag1; //Unknown
        public uint xPosition;
        public uint yposition;
        public uint frameSize;

        public bool marshalCaught = false;

        public D3grFrame(uint startOffset) {
            this.startOffset = startOffset;
        }

        public void ReadFrame(FileStream stream, BinaryReader reader, uint frameStartPoint) {
            stream.Position = frameStartPoint + startOffset;
            frameSize = reader.ReadUInt32(); // frameSize
            frame_flag1 = reader.ReadUInt32(); // Unknown
            xPosition = reader.ReadUInt16();
            yposition = reader.ReadUInt16();
            height = reader.ReadUInt16();
            width = reader.ReadUInt16();       
            pixels = reader.ReadBytes(height * width);

        }


        //Set the PAL for the read image
        private void SetImagePalette(ref Bitmap bmp, byte[] paletteData, int brightness)
        {
            ColorPalette palette = bmp.Palette;
            int rgbTracker = 0;
            for (int i = 0; i < paletteData.Length / 3; i++)
            {

                Color palColor;
                palColor = Color.FromArgb((paletteData[rgbTracker]) * brightness, (paletteData[rgbTracker + 1]) * brightness, (paletteData[rgbTracker + 2]) * brightness);
                rgbTracker += 3;
                palette.Entries[i] = palColor;
            }

            bmp.Palette = palette;
        }

        //Convert the raw bytes into an Image
        private Image ImageFromRawBgraArray(byte[] arr, byte[] paletteData, int width, int height, PixelFormat pixelFormat, int brightness)
        {
            var output = new Bitmap(width, height, pixelFormat);
            var rect = new Rectangle(0, 0, width, height);
            var bmpData = output.LockBits(rect, ImageLockMode.ReadWrite, output.PixelFormat);
            SetImagePalette(ref output, paletteData, brightness);

            // Row-by-row copy
            var arrRowLength = width * Image.GetPixelFormatSize(output.PixelFormat) / 8;
            var ptr = bmpData.Scan0;
            for (var i = 0; i < height; i++)
            {
                try
                {
                    Marshal.Copy(arr, i * arrRowLength, ptr, arrRowLength);
                    ptr += bmpData.Stride;
                }
                catch
                {
                    ReturnNullPic("Invalid data/or is being read incorrectly.");
                    marshalCaught = true;
                    // Marshal.Copy(arr, i * arrRowLength, ptr, arr.Length);
                    // ptr += bmpData.Stride;
                    // 
                }
              
            }

            output.UnlockBits(bmpData);
            return output;
        }

        public Image ConvertFrameToImage(byte[] paletteData, int brightness) {


            if (width > 0 && height > 0) {

                return ImageFromRawBgraArray(pixels, paletteData, width, height, PixelFormat.Format8bppIndexed, brightness);
            }

            return ReturnNullPic("No image data");

        }


        public static Image ReturnNullPic(string message) {
            Bitmap bmp = new Bitmap(320, 200);

            RectangleF rectf = new RectangleF(120, 90, 90, 50);

            Graphics g = Graphics.FromImage(bmp);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawString(message, new Font("Tahoma", 8), Brushes.Black, rectf);

            g.Flush();

            return bmp;
        }
    }

}
