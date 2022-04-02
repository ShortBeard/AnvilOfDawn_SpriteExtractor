
namespace Anvil_Of_Dawn___Sprite_Extractor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.extractButton = new System.Windows.Forms.Button();
            this.inputButton = new System.Windows.Forms.Button();
            this.outputButton = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.imagePreviewBox = new System.Windows.Forms.PictureBox();
            this.nextFileButton = new System.Windows.Forms.Button();
            this.previousFileButton = new System.Windows.Forms.Button();
            this.previousFrameButton = new System.Windows.Forms.Button();
            this.nextFrameButton = new System.Windows.Forms.Button();
            this.currentFileLabel = new System.Windows.Forms.Label();
            this.currentFrameLabel = new System.Windows.Forms.Label();
            this.unknown_1_label = new System.Windows.Forms.Label();
            this.unknown_2_label = new System.Windows.Forms.Label();
            this.unknown_3_label = new System.Windows.Forms.Label();
            this.unknown_4_label = new System.Windows.Forms.Label();
            this.unknown_5_label = new System.Windows.Forms.Label();
            this.saveFrameButton = new System.Windows.Forms.Button();
            this.palSpaceLabel = new System.Windows.Forms.Label();
            this.marshallCaughtLabel = new System.Windows.Forms.Label();
            this.palettePictureBox = new System.Windows.Forms.PictureBox();
            this.brightnessValueBox = new System.Windows.Forms.NumericUpDown();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.palLengthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SavePALasPNGButton = new System.Windows.Forms.Button();
            this.savePALasBytesButton = new System.Windows.Forms.Button();
            this.prevPalLabel = new System.Windows.Forms.Label();
            this.frameFlag1Label = new System.Windows.Forms.Label();
            this.frameFlag3Label = new System.Windows.Forms.Label();
            this.frameFlag2Label = new System.Windows.Forms.Label();
            this.frameWidthLabel = new System.Windows.Forms.Label();
            this.frameHeightLabel = new System.Windows.Forms.Label();
            this.frameSizeLabel = new System.Windows.Forms.Label();
            this.aboveMultipliedLabel = new System.Windows.Forms.Label();
            this.pixelLengthLabel = new System.Windows.Forms.Label();
            this.zoomCheckbox = new System.Windows.Forms.CheckBox();
            this.frameStartOffsetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreviewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palettePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessValueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // extractButton
            // 
            this.extractButton.Location = new System.Drawing.Point(30, 75);
            this.extractButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(118, 22);
            this.extractButton.TabIndex = 0;
            this.extractButton.Text = "Extract Sprites";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(11, 10);
            this.inputButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(136, 26);
            this.inputButton.TabIndex = 1;
            this.inputButton.Text = "Select Input Folder";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(11, 42);
            this.outputButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(136, 22);
            this.outputButton.TabIndex = 2;
            this.outputButton.Text = "Select Output Folder";
            this.outputButton.UseVisualStyleBackColor = true;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(163, 10);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(38, 15);
            this.inputLabel.TabIndex = 3;
            this.inputLabel.Text = "label1";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(163, 42);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(38, 15);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "label1";
            // 
            // imagePreviewBox
            // 
            this.imagePreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePreviewBox.Location = new System.Drawing.Point(350, 51);
            this.imagePreviewBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagePreviewBox.Name = "imagePreviewBox";
            this.imagePreviewBox.Size = new System.Drawing.Size(280, 150);
            this.imagePreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagePreviewBox.TabIndex = 6;
            this.imagePreviewBox.TabStop = false;
            // 
            // nextFileButton
            // 
            this.nextFileButton.Location = new System.Drawing.Point(515, 206);
            this.nextFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextFileButton.Name = "nextFileButton";
            this.nextFileButton.Size = new System.Drawing.Size(96, 22);
            this.nextFileButton.TabIndex = 7;
            this.nextFileButton.Text = "Next File ->";
            this.nextFileButton.UseVisualStyleBackColor = true;
            this.nextFileButton.Click += new System.EventHandler(this.nextFileButton_Click);
            // 
            // previousFileButton
            // 
            this.previousFileButton.Location = new System.Drawing.Point(374, 206);
            this.previousFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previousFileButton.Name = "previousFileButton";
            this.previousFileButton.Size = new System.Drawing.Size(89, 22);
            this.previousFileButton.TabIndex = 8;
            this.previousFileButton.Text = "<- Prev File";
            this.previousFileButton.UseVisualStyleBackColor = true;
            this.previousFileButton.Click += new System.EventHandler(this.previousFileButton_Click);
            // 
            // previousFrameButton
            // 
            this.previousFrameButton.Location = new System.Drawing.Point(262, 87);
            this.previousFrameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previousFrameButton.Name = "previousFrameButton";
            this.previousFrameButton.Size = new System.Drawing.Size(82, 68);
            this.previousFrameButton.TabIndex = 9;
            this.previousFrameButton.Text = "<<";
            this.previousFrameButton.UseVisualStyleBackColor = true;
            this.previousFrameButton.Click += new System.EventHandler(this.previousFrameButton_Click);
            // 
            // nextFrameButton
            // 
            this.nextFrameButton.Location = new System.Drawing.Point(635, 87);
            this.nextFrameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextFrameButton.Name = "nextFrameButton";
            this.nextFrameButton.Size = new System.Drawing.Size(82, 68);
            this.nextFrameButton.TabIndex = 10;
            this.nextFrameButton.Text = ">>";
            this.nextFrameButton.UseVisualStyleBackColor = true;
            this.nextFrameButton.Click += new System.EventHandler(this.nextFrameButton_Click);
            // 
            // currentFileLabel
            // 
            this.currentFileLabel.AutoSize = true;
            this.currentFileLabel.Location = new System.Drawing.Point(374, 255);
            this.currentFileLabel.Name = "currentFileLabel";
            this.currentFileLabel.Size = new System.Drawing.Size(71, 15);
            this.currentFileLabel.TabIndex = 11;
            this.currentFileLabel.Text = "Current File:";
            // 
            // currentFrameLabel
            // 
            this.currentFrameLabel.AutoSize = true;
            this.currentFrameLabel.Location = new System.Drawing.Point(374, 278);
            this.currentFrameLabel.Name = "currentFrameLabel";
            this.currentFrameLabel.Size = new System.Drawing.Size(86, 15);
            this.currentFrameLabel.TabIndex = 12;
            this.currentFrameLabel.Text = "Current Frame:";
            // 
            // unknown_1_label
            // 
            this.unknown_1_label.AutoSize = true;
            this.unknown_1_label.Location = new System.Drawing.Point(30, 302);
            this.unknown_1_label.Name = "unknown_1_label";
            this.unknown_1_label.Size = new System.Drawing.Size(41, 15);
            this.unknown_1_label.TabIndex = 14;
            this.unknown_1_label.Text = "Flag1: ";
            // 
            // unknown_2_label
            // 
            this.unknown_2_label.AutoSize = true;
            this.unknown_2_label.Location = new System.Drawing.Point(30, 317);
            this.unknown_2_label.Name = "unknown_2_label";
            this.unknown_2_label.Size = new System.Drawing.Size(41, 15);
            this.unknown_2_label.TabIndex = 15;
            this.unknown_2_label.Text = "Flag2: ";
            // 
            // unknown_3_label
            // 
            this.unknown_3_label.AutoSize = true;
            this.unknown_3_label.Location = new System.Drawing.Point(30, 332);
            this.unknown_3_label.Name = "unknown_3_label";
            this.unknown_3_label.Size = new System.Drawing.Size(41, 15);
            this.unknown_3_label.TabIndex = 16;
            this.unknown_3_label.Text = "Flag3: ";
            // 
            // unknown_4_label
            // 
            this.unknown_4_label.AutoSize = true;
            this.unknown_4_label.Location = new System.Drawing.Point(30, 347);
            this.unknown_4_label.Name = "unknown_4_label";
            this.unknown_4_label.Size = new System.Drawing.Size(41, 15);
            this.unknown_4_label.TabIndex = 17;
            this.unknown_4_label.Text = "Flag4: ";
            // 
            // unknown_5_label
            // 
            this.unknown_5_label.AutoSize = true;
            this.unknown_5_label.Location = new System.Drawing.Point(30, 362);
            this.unknown_5_label.Name = "unknown_5_label";
            this.unknown_5_label.Size = new System.Drawing.Size(41, 15);
            this.unknown_5_label.TabIndex = 18;
            this.unknown_5_label.Text = "Flag5: ";
            // 
            // saveFrameButton
            // 
            this.saveFrameButton.Location = new System.Drawing.Point(421, 314);
            this.saveFrameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveFrameButton.Name = "saveFrameButton";
            this.saveFrameButton.Size = new System.Drawing.Size(145, 22);
            this.saveFrameButton.TabIndex = 19;
            this.saveFrameButton.Text = "Save Frame as PNG";
            this.saveFrameButton.UseVisualStyleBackColor = true;
            this.saveFrameButton.Click += new System.EventHandler(this.saveFrameButton_Click);
            // 
            // palSpaceLabel
            // 
            this.palSpaceLabel.AutoSize = true;
            this.palSpaceLabel.Location = new System.Drawing.Point(30, 237);
            this.palSpaceLabel.Name = "palSpaceLabel";
            this.palSpaceLabel.Size = new System.Drawing.Size(109, 15);
            this.palSpaceLabel.TabIndex = 20;
            this.palSpaceLabel.Text = "Enough PAL space?";
            // 
            // marshallCaughtLabel
            // 
            this.marshallCaughtLabel.AutoSize = true;
            this.marshallCaughtLabel.Location = new System.Drawing.Point(30, 172);
            this.marshallCaughtLabel.Name = "marshallCaughtLabel";
            this.marshallCaughtLabel.Size = new System.Drawing.Size(122, 15);
            this.marshallCaughtLabel.TabIndex = 21;
            this.marshallCaughtLabel.Text = "Marshal Error Caught:";
            // 
            // palettePictureBox
            // 
            this.palettePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palettePictureBox.Location = new System.Drawing.Point(764, 44);
            this.palettePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palettePictureBox.Name = "palettePictureBox";
            this.palettePictureBox.Size = new System.Drawing.Size(448, 384);
            this.palettePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.palettePictureBox.TabIndex = 22;
            this.palettePictureBox.TabStop = false;
            // 
            // brightnessValueBox
            // 
            this.brightnessValueBox.Location = new System.Drawing.Point(421, 26);
            this.brightnessValueBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brightnessValueBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.brightnessValueBox.Name = "brightnessValueBox";
            this.brightnessValueBox.Size = new System.Drawing.Size(131, 23);
            this.brightnessValueBox.TabIndex = 23;
            this.brightnessValueBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(346, 27);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(65, 15);
            this.brightnessLabel.TabIndex = 24;
            this.brightnessLabel.Text = "Brightness:";
            // 
            // palLengthLabel
            // 
            this.palLengthLabel.AutoSize = true;
            this.palLengthLabel.Location = new System.Drawing.Point(30, 222);
            this.palLengthLabel.Name = "palLengthLabel";
            this.palLengthLabel.Size = new System.Drawing.Size(66, 15);
            this.palLengthLabel.TabIndex = 25;
            this.palLengthLabel.Text = "Pal Length:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Palette Preview:";
            // 
            // SavePALasPNGButton
            // 
            this.SavePALasPNGButton.Location = new System.Drawing.Point(886, 14);
            this.SavePALasPNGButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SavePALasPNGButton.Name = "SavePALasPNGButton";
            this.SavePALasPNGButton.Size = new System.Drawing.Size(134, 22);
            this.SavePALasPNGButton.TabIndex = 27;
            this.SavePALasPNGButton.Text = "Save PAL as PNG";
            this.SavePALasPNGButton.UseVisualStyleBackColor = true;
            this.SavePALasPNGButton.Click += new System.EventHandler(this.SavePALasPNGButton_Click);
            // 
            // savePALasBytesButton
            // 
            this.savePALasBytesButton.Location = new System.Drawing.Point(1035, 14);
            this.savePALasBytesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savePALasBytesButton.Name = "savePALasBytesButton";
            this.savePALasBytesButton.Size = new System.Drawing.Size(126, 22);
            this.savePALasBytesButton.TabIndex = 28;
            this.savePALasBytesButton.Text = "Save PAL as bytes";
            this.savePALasBytesButton.UseVisualStyleBackColor = true;
            this.savePALasBytesButton.Click += new System.EventHandler(this.savePALasBytesButton_Click);
            // 
            // prevPalLabel
            // 
            this.prevPalLabel.AutoSize = true;
            this.prevPalLabel.Location = new System.Drawing.Point(30, 255);
            this.prevPalLabel.Name = "prevPalLabel";
            this.prevPalLabel.Size = new System.Drawing.Size(93, 15);
            this.prevPalLabel.TabIndex = 29;
            this.prevPalLabel.Text = "Using Prev Pal?: ";
            // 
            // frameFlag1Label
            // 
            this.frameFlag1Label.AutoSize = true;
            this.frameFlag1Label.Location = new System.Drawing.Point(222, 278);
            this.frameFlag1Label.Name = "frameFlag1Label";
            this.frameFlag1Label.Size = new System.Drawing.Size(77, 15);
            this.frameFlag1Label.TabIndex = 30;
            this.frameFlag1Label.Text = "Frame Flag 1:";
            // 
            // frameFlag3Label
            // 
            this.frameFlag3Label.AutoSize = true;
            this.frameFlag3Label.Location = new System.Drawing.Point(222, 308);
            this.frameFlag3Label.Name = "frameFlag3Label";
            this.frameFlag3Label.Size = new System.Drawing.Size(35, 15);
            this.frameFlag3Label.TabIndex = 31;
            this.frameFlag3Label.Text = "yPos:";
            // 
            // frameFlag2Label
            // 
            this.frameFlag2Label.AutoSize = true;
            this.frameFlag2Label.Location = new System.Drawing.Point(222, 292);
            this.frameFlag2Label.Name = "frameFlag2Label";
            this.frameFlag2Label.Size = new System.Drawing.Size(35, 15);
            this.frameFlag2Label.TabIndex = 32;
            this.frameFlag2Label.Text = "xPos:";
            // 
            // frameWidthLabel
            // 
            this.frameWidthLabel.AutoSize = true;
            this.frameWidthLabel.Location = new System.Drawing.Point(222, 358);
            this.frameWidthLabel.Name = "frameWidthLabel";
            this.frameWidthLabel.Size = new System.Drawing.Size(78, 15);
            this.frameWidthLabel.TabIndex = 33;
            this.frameWidthLabel.Text = "Frame Width:";
            // 
            // frameHeightLabel
            // 
            this.frameHeightLabel.AutoSize = true;
            this.frameHeightLabel.Location = new System.Drawing.Point(222, 376);
            this.frameHeightLabel.Name = "frameHeightLabel";
            this.frameHeightLabel.Size = new System.Drawing.Size(82, 15);
            this.frameHeightLabel.TabIndex = 34;
            this.frameHeightLabel.Text = "Frame Height:";
            // 
            // frameSizeLabel
            // 
            this.frameSizeLabel.AutoSize = true;
            this.frameSizeLabel.Location = new System.Drawing.Point(222, 337);
            this.frameSizeLabel.Name = "frameSizeLabel";
            this.frameSizeLabel.Size = new System.Drawing.Size(66, 15);
            this.frameSizeLabel.TabIndex = 35;
            this.frameSizeLabel.Text = "Frame Size:";
            // 
            // aboveMultipliedLabel
            // 
            this.aboveMultipliedLabel.AutoSize = true;
            this.aboveMultipliedLabel.Location = new System.Drawing.Point(222, 394);
            this.aboveMultipliedLabel.Name = "aboveMultipliedLabel";
            this.aboveMultipliedLabel.Size = new System.Drawing.Size(109, 15);
            this.aboveMultipliedLabel.TabIndex = 36;
            this.aboveMultipliedLabel.Text = "(Above Multiplied):";
            // 
            // pixelLengthLabel
            // 
            this.pixelLengthLabel.AutoSize = true;
            this.pixelLengthLabel.Location = new System.Drawing.Point(222, 415);
            this.pixelLengthLabel.Name = "pixelLengthLabel";
            this.pixelLengthLabel.Size = new System.Drawing.Size(75, 15);
            this.pixelLengthLabel.TabIndex = 37;
            this.pixelLengthLabel.Text = "Pixel Length:";
            // 
            // zoomCheckbox
            // 
            this.zoomCheckbox.AutoSize = true;
            this.zoomCheckbox.Location = new System.Drawing.Point(557, 27);
            this.zoomCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zoomCheckbox.Name = "zoomCheckbox";
            this.zoomCheckbox.Size = new System.Drawing.Size(71, 19);
            this.zoomCheckbox.TabIndex = 38;
            this.zoomCheckbox.Text = "Zoomed";
            this.zoomCheckbox.UseVisualStyleBackColor = true;
            this.zoomCheckbox.CheckedChanged += new System.EventHandler(this.zoomCheckbox_CheckedChanged);
            // 
            // frameStartOffsetLabel
            // 
            this.frameStartOffsetLabel.AutoSize = true;
            this.frameStartOffsetLabel.Location = new System.Drawing.Point(411, 376);
            this.frameStartOffsetLabel.Name = "frameStartOffsetLabel";
            this.frameStartOffsetLabel.Size = new System.Drawing.Size(105, 15);
            this.frameStartOffsetLabel.TabIndex = 43;
            this.frameStartOffsetLabel.Text = "Frame Start Offset:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 436);
            this.Controls.Add(this.frameStartOffsetLabel);
            this.Controls.Add(this.zoomCheckbox);
            this.Controls.Add(this.pixelLengthLabel);
            this.Controls.Add(this.aboveMultipliedLabel);
            this.Controls.Add(this.frameSizeLabel);
            this.Controls.Add(this.frameHeightLabel);
            this.Controls.Add(this.frameWidthLabel);
            this.Controls.Add(this.frameFlag2Label);
            this.Controls.Add(this.frameFlag3Label);
            this.Controls.Add(this.frameFlag1Label);
            this.Controls.Add(this.prevPalLabel);
            this.Controls.Add(this.savePALasBytesButton);
            this.Controls.Add(this.SavePALasPNGButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.palLengthLabel);
            this.Controls.Add(this.brightnessLabel);
            this.Controls.Add(this.brightnessValueBox);
            this.Controls.Add(this.palettePictureBox);
            this.Controls.Add(this.marshallCaughtLabel);
            this.Controls.Add(this.palSpaceLabel);
            this.Controls.Add(this.saveFrameButton);
            this.Controls.Add(this.unknown_5_label);
            this.Controls.Add(this.unknown_4_label);
            this.Controls.Add(this.unknown_3_label);
            this.Controls.Add(this.unknown_2_label);
            this.Controls.Add(this.unknown_1_label);
            this.Controls.Add(this.currentFrameLabel);
            this.Controls.Add(this.currentFileLabel);
            this.Controls.Add(this.nextFrameButton);
            this.Controls.Add(this.previousFrameButton);
            this.Controls.Add(this.previousFileButton);
            this.Controls.Add(this.nextFileButton);
            this.Controls.Add(this.imagePreviewBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.extractButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Anvil Of Dawn - Sprite Extractor (In Development)";
            ((System.ComponentModel.ISupportInitialize)(this.imagePreviewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palettePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessValueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox imagePreviewBox;
        private System.Windows.Forms.Button nextFileButton;
        private System.Windows.Forms.Button previousFileButton;
        private System.Windows.Forms.Button previousFrameButton;
        private System.Windows.Forms.Button nextFrameButton;
        private System.Windows.Forms.Label currentFileLabel;
        private System.Windows.Forms.Label currentFrameLabel;
        private System.Windows.Forms.Label unknown_1_label;
        private System.Windows.Forms.Label unknown_2_label;
        private System.Windows.Forms.Label unknown_3_label;
        private System.Windows.Forms.Label unknown_4_label;
        private System.Windows.Forms.Label unknown_5_label;
        private System.Windows.Forms.Button saveFrameButton;
        private System.Windows.Forms.Label palSpaceLabel;
        private System.Windows.Forms.Label marshallCaughtLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox palettePictureBox;
        private System.Windows.Forms.NumericUpDown brightnessValueBox;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Label palLengthLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SavePALasPNGButton;
        private System.Windows.Forms.Button savePALasBytesButton;
        private System.Windows.Forms.Label prevPalLabel;
        private System.Windows.Forms.Label frameFlag1Label;
        private System.Windows.Forms.Label frameFlag3Label;
        private System.Windows.Forms.Label frameFlag2Label;
        private System.Windows.Forms.Label frameWidthLabel;
        private System.Windows.Forms.Label frameHeightLabel;
        private System.Windows.Forms.Label frameSizeLabel;
        private System.Windows.Forms.Label aboveMultipliedLabel;
        private System.Windows.Forms.Label pixelLengthLabel;
        private System.Windows.Forms.CheckBox zoomCheckbox;
        private System.Windows.Forms.Label frameStartOffsetLabel;
    }
}

