////////////////////
//Anvil of Dawn - Sprite Extractor. Shortbeard 01/04/2022
//Used information from: https://github.com/IceReaper/retroGDX/blob/master/core/src/retrogdx/games/warwind/nodes/D3grNode.java
////////////////////

using System;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Anvil_Of_Dawn___Sprite_Extractor
{
    public partial class MainForm : Form
    {


        public string[] inputFiles;
        private const string DEFAULT_PAL_FILE = "ANVIL0.PAL";
        private D3GR[] d3grFiles;
        private int selectedFile = 0;
        private int selectedFrame = 0;


        public MainForm() {
            InitializeComponent();
        }

        private void extractButton_Click(object sender, EventArgs e) {


            //Read the default PAL file for files that don't contain their own palettes
            byte[] palData = File.ReadAllBytes(DEFAULT_PAL_FILE);

            //Convert all files into our readable D3GR object
            d3grFiles = new D3GR[inputFiles.Length];
            byte[] previousPaletteBuffer= new byte[768];
            for (int i = 0; i < inputFiles.Length; i++) {
                d3grFiles[i] = new D3GR(inputFiles[i]);
                d3grFiles[i].ReadFrames((int)brightnessValueBox.Value, palData, previousPaletteBuffer) ;
                //d3grFiles[i].ReadFrames((int)brightnessValueBox.Value, palData, palData); //Comment this line and uncomment the above to use the most-previous palette. Only works in some files?
                if (d3grFiles[i].Flag1 == 8193) {
                    previousPaletteBuffer = d3grFiles[i].PalData;
                }
            }

            //Get image and show first frame of first file
            SelectFileFAndFrame(selectedFile, selectedFrame);
        }


        private void SelectFileFAndFrame(int fileIndex, int frameIndex) {

            //If there are no frames found, show the null placeholder pic
            if (d3grFiles[fileIndex].FileFrames.Length == 0) {
                imagePreviewBox.Image = D3grFrame.ReturnNullPic("No image data.");
            }
            else {
                palettePictureBox.Image = D3GR.GeneratePalettePreview(d3grFiles[fileIndex].PalData, (int)brightnessValueBox.Value);
                imagePreviewBox.Image = d3grFiles[fileIndex].FileFrames[frameIndex].ConvertFrameToImage(d3grFiles[fileIndex].PalData, (int)brightnessValueBox.Value);
                
                // palLabel.Text = "Pal ID: " + d3grFiles[fileIndex].FileFrames[frameIndex].palID;
                unknown_1_label.Text = "Flag1: " + d3grFiles[fileIndex].Flag1.ToString();
                unknown_2_label.Text = "Flag2: " + d3grFiles[fileIndex].Flag2.ToString();
                unknown_3_label.Text = "Flag3: " + d3grFiles[fileIndex].Flag3.ToString();
                unknown_4_label.Text = "Flag4: " + d3grFiles[fileIndex].Flag4.ToString();
                unknown_5_label.Text = "Flag5: " + d3grFiles[fileIndex].Flag5.ToString();


                frameFlag1Label.Text = "Frame Flag 1: " + d3grFiles[fileIndex].FileFrames[frameIndex].frame_flag1;
                frameFlag2Label.Text = "xPos: " + d3grFiles[fileIndex].FileFrames[frameIndex].xPosition;
                frameFlag3Label.Text = "yPos: " + d3grFiles[fileIndex].FileFrames[frameIndex].yposition;
                frameStartOffsetLabel.Text = "Frame Start Offset: " + d3grFiles[fileIndex].FileFrames[frameIndex].startOffset;
                palLengthLabel.Text = "Pal data length: " + d3grFiles[fileIndex].PaletteLength.ToString();


                frameSizeLabel.Text = "Frame Size: " + d3grFiles[fileIndex].FileFrames[frameIndex].frameSize;
                frameHeightLabel.Text = "Frame Height: " + d3grFiles[fileIndex].FileFrames[frameIndex].height;
                frameWidthLabel.Text = "Frame Width: " + d3grFiles[fileIndex].FileFrames[frameIndex].width;
                aboveMultipliedLabel.Text = "(Above Multiplied:)" + (d3grFiles[fileIndex].FileFrames[frameIndex].height * d3grFiles[fileIndex].FileFrames[frameIndex].width);
                pixelLengthLabel.Text = "Pixel Length: " + d3grFiles[fileIndex].FileFrames[frameIndex].pixels.Length;
                palSpaceLabel.Text = "PAL Space? : " + d3grFiles[fileIndex].ContainsPalette.ToString();
                marshallCaughtLabel.Text = "Marshal Error Caught: " + d3grFiles[fileIndex].FileFrames[frameIndex].marshalCaught;
            }
          

            currentFileLabel.Text = "Current File: " + Path.GetFileName(d3grFiles[fileIndex].FileName);
            currentFrameLabel.Text = "Current Frame: " + (frameIndex + 1).ToString() + "/" + (d3grFiles[fileIndex].FrameCount);
           
        }

            private void inputButton_Click(object sender, EventArgs e) {
            using (var fbd = new FolderBrowserDialog()) {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                    inputFiles = Directory.GetFiles(fbd.SelectedPath, "*.d3g");

                    if (inputFiles.Length == 0) {
                        MessageBox.Show("Warning: No .d3g files found in this directory.");
                    }
                  
                }
            }
        }

        private void previousFrameButton_Click(object sender, EventArgs e) {
            if (selectedFrame > 0) {
                selectedFrame--;
            }

            SelectFileFAndFrame(selectedFile, selectedFrame);
        }

        private void nextFrameButton_Click(object sender, EventArgs e) {
            if (selectedFrame < d3grFiles[selectedFile].FileFrames.Length - 1) {
                selectedFrame++;
            };

            SelectFileFAndFrame(selectedFile, selectedFrame);
        }

        private void previousFileButton_Click(object sender, EventArgs e) {
            if (selectedFile > 0) {
                selectedFile--;
            }

            selectedFrame = 0;
            SelectFileFAndFrame(selectedFile, selectedFrame);
        }

        private void nextFileButton_Click(object sender, EventArgs e) {
            if (selectedFile < d3grFiles.Length - 1) {
                selectedFile++;
            }

            selectedFrame = 0;
            SelectFileFAndFrame(selectedFile, selectedFrame);
        }

        private void saveFrameButton_Click(object sender, EventArgs e) {
            imagePreviewBox.Image.Save("OutputFrame.png");
        }

        private void SavePALasPNGButton_Click(object sender, EventArgs e) {
            palettePictureBox.Image.Save("Palette_Output.png", ImageFormat.Png);
        }

        private void savePALasBytesButton_Click(object sender, EventArgs e) {
            File.WriteAllBytes("Palette_Output.PAL", d3grFiles[selectedFile].PalData);
        }

        private void zoomCheckbox_CheckedChanged(object sender, EventArgs e) {
            CheckBox zoomBox = (CheckBox)sender;
            if (zoomBox.Checked) {
                imagePreviewBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else {
                imagePreviewBox.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

    }
}
