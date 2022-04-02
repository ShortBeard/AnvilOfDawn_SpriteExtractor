using System.Drawing;
using System.IO;
using System.Text;

namespace Anvil_Of_Dawn___Sprite_Extractor
{

    //This class helps handle the D3GR format for data extraction
    //D3GR files are Little Endian formatted.
    public class D3GR
    {

        public string FileName { get; private set; }
        public string Header { get; private set; } //Header of file. In this case, will alwayas be D3GR.
        public uint FrameStartOffset { get; private set; } //The start of our frame information.
        public uint FrameCount { get; private set; } //How many frames are stored in this file
        public D3grFrame[] FileFrames { get; private set; }

        public bool ContainsPalette { get; private set; } //If true, will use palette found in file rather than provided default
        //public bool IsSecondaryPalette { get; private set; }
        //public byte[] defaulttPal { get; private set; } //A default palette used when the file contains no palette data

        private byte[] palData;
        public byte[] PalData {
            get
            {
                return palData;
            }
        }

        public bool UsingPrevPalette = false;

        public uint PaletteLength { get; private set; }

        public uint Flag1;
        public uint Flag2;
        public uint Flag3;
        public uint Flag4;
        public uint Flag5;

        private FileStream stream;
        private BinaryReader reader;
        private int brightness;
        public uint PalStartOffset { get; private set; }

        public D3GR(string fileName) {
            FileName = fileName;
            stream = File.Open(fileName, FileMode.Open);
            reader = new BinaryReader(stream, Encoding.ASCII, false);

            Header = reader.ReadInt32().ToString();
            Flag1 = reader.ReadUInt32(); //If flag is 8193, this file contains a PAL? (Not sure if this what it implies...)
            FrameStartOffset = reader.ReadUInt32();

            Flag2 = reader.ReadUInt32(); //Helps find palette offset
            PalStartOffset = Flag2 + 4; //Start of palette (if there is one) is offset plus 4 (in other words, byte count from start of file not including header)

            Flag3 = reader.ReadUInt32(); // Unknown
            Flag4 = reader.ReadUInt32(); // Unknown
            FrameCount = reader.ReadUInt16(); //How many frames are in this file
            Flag5 = reader.ReadUInt16(); //Uknown           
        }


        //Brightness - found the default RGB too dark. Just multiplies the RGB value to something brighter.
        //MasterPalette - The master pal we use to help process this image if required 
        //PreviousPalette - if we choose to go the route of using the most previously-found PAL, set this. By default, it's also given the master PAL.
        public void ReadFrames(int brightness, byte[] masterPalette, byte[] previousPalette) {
            this.palData = masterPalette; //set the default "Master Palette"
            this.brightness = brightness;

            //If Flag 1 == 1, then we use the palette from the most previous found 8193 file.           
            if (Flag1 == 1) {
                UsingPrevPalette = true;
                byte[] tempBytes = new byte[768];
                for (int i = 0; i < 768; i++) {
                    tempBytes[i] = previousPalette[i];
                }
                ContainsPalette = false;
                this.palData = tempBytes;
            }
            

            //This file contains palette data.
            if (Flag1 == 8193 && Flag2 != 0 && FrameStartOffset != 0) {          
                PaletteLength = (uint)(FrameStartOffset - PalStartOffset);
                if (PaletteLength > 0) {
                    ContainsPalette = true;
                }
            }


            FileFrames = new D3grFrame[FrameCount]; //Start our array with the count of how many frames there are 

            //Start reading each frames file offset
            //Note this is the offset starting from StartFrame, not the beginning of the file.
            for (int i = 0; i < FileFrames.Length; i++) {
                uint frameOffset = reader.ReadUInt32();
                FileFrames[i] = new D3grFrame(frameOffset);
            }


            foreach (D3grFrame frame in FileFrames) {
                frame.ReadFrame(stream, reader, FrameStartOffset);
            }


            if (ContainsPalette == true) {

                stream.Position = PalStartOffset;

                
                byte[] readPalData = reader.ReadBytes((int)PaletteLength); //Read the found PAL Data


                    byte[] tempPal = new byte[768]; //Create a temp buffer to hold new pal data

                    int palWriteLocation = (int)(this.palData.Length - PaletteLength); //Calculate where to start writing relative to the master palette

                    //First just fill our temp pal buffer with master pal data until any additional palette data is found
                    for (int i = 0; i < palWriteLocation; i++) {
                        tempPal[i] = masterPalette[i];
                    }

                    //Now add any additional palette data 
                    for (int i = palWriteLocation; i < this.palData.Length; i++) {
                        tempPal[i] = readPalData[i - palWriteLocation];
                    }

                    this.palData = tempPal;
                

              

            }

        }


        public Image[] ConvertAllFramesToImage() {
            Image[] frameImages = new Image[FileFrames.Length];
            for (int i = 0; i < frameImages.Length; i++) {
                frameImages[i] = FileFrames[i].ConvertFrameToImage(PalData, brightness) ;
            }

            return frameImages;
        }

        public static Image GeneratePalettePreview(byte[] palData, int brightnessValue) {
            //StreamReader reader = new StreamReader(palFile);
            long numberOfColors = palData.Length / 3;
            Color[] paletteColors = new Color[numberOfColors];

            for (int i = 0; i < paletteColors.Length; i++) {
                paletteColors[i] = Color.FromArgb((palData[i * 3]) * brightnessValue, (palData[i * 3 + 1]) * brightnessValue, (palData[i * 3 + 2]) * brightnessValue);
            }


            //How many colors to display per row
            int maxColorsPerRow = 16;
            int maxColumnCount = 16;

            //How large a color tile should be
            int tileHeight = 32;
            int tileWidth = 32;

            int widthOfImage = tileHeight * maxColorsPerRow;
            int heightOfImage = tileWidth * maxColumnCount;

            Bitmap pic = new Bitmap(widthOfImage, heightOfImage, System.Drawing.Imaging.PixelFormat.Format32bppRgb);

            int currentRow = 0;
            int currentColumn = 0;
            foreach(Color color in paletteColors) {
                if (currentColumn == maxColumnCount) {
                    currentColumn = 0;
                    currentRow++;
                }

                for (int i = 0; i < tileHeight; i++) {
                    for (int j = 0; j < tileWidth; j++) {
                        pic.SetPixel(j + currentColumn * tileHeight, i + currentRow  * tileWidth, color);
                    }
                }


                currentColumn++;
            }


            return pic;
 

        }

    }
}
