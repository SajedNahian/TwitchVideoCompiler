namespace TwitchVideoGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aVideoURLs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aGenerateVideoButton = new System.Windows.Forms.Button();
            this.aProgressBar = new System.Windows.Forms.ProgressBar();
            this.aCompileVideos = new System.Windows.Forms.CheckBox();
            this.aDeleteClipsAfterwards = new System.Windows.Forms.CheckBox();
            this.aResolutionLabel = new System.Windows.Forms.Label();
            this.aXResolution = new System.Windows.Forms.TextBox();
            this.aByLabel = new System.Windows.Forms.Label();
            this.aYResolution = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.aFileName = new System.Windows.Forms.TextBox();
            this.aSaveAsLabel = new System.Windows.Forms.Label();
            this.aMP4 = new System.Windows.Forms.Label();
            this.aErrorText = new System.Windows.Forms.Label();
            this.aAddIntro = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.aAddOutro = new System.Windows.Forms.CheckBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // aVideoURLs
            // 
            this.aVideoURLs.Location = new System.Drawing.Point(16, 29);
            this.aVideoURLs.Multiline = true;
            this.aVideoURLs.Name = "aVideoURLs";
            this.aVideoURLs.Size = new System.Drawing.Size(349, 218);
            this.aVideoURLs.TabIndex = 0;
            this.aVideoURLs.Text = "https://clips-media-assets2.twitch.tv/29518193424-offset-10398.mp4\r\nhttps://clips" +
    "-media-assets2.twitch.tv/29562500464-offset-42718.mp4\r\nhttps://clips-media-asset" +
    "s2.twitch.tv/AT-cm%7C272565837.mp4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Twitch Clips (One per line):";
            // 
            // aGenerateVideoButton
            // 
            this.aGenerateVideoButton.Location = new System.Drawing.Point(16, 282);
            this.aGenerateVideoButton.Name = "aGenerateVideoButton";
            this.aGenerateVideoButton.Size = new System.Drawing.Size(119, 23);
            this.aGenerateVideoButton.TabIndex = 2;
            this.aGenerateVideoButton.Text = "Generate Video";
            this.aGenerateVideoButton.UseVisualStyleBackColor = true;
            this.aGenerateVideoButton.Click += new System.EventHandler(this.aGenerateVideoButton_Click);
            // 
            // aProgressBar
            // 
            this.aProgressBar.Location = new System.Drawing.Point(16, 253);
            this.aProgressBar.MarqueeAnimationSpeed = 0;
            this.aProgressBar.Name = "aProgressBar";
            this.aProgressBar.Size = new System.Drawing.Size(349, 23);
            this.aProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.aProgressBar.TabIndex = 3;
            this.aProgressBar.Visible = false;
            // 
            // aCompileVideos
            // 
            this.aCompileVideos.AutoSize = true;
            this.aCompileVideos.Location = new System.Drawing.Point(379, 29);
            this.aCompileVideos.Name = "aCompileVideos";
            this.aCompileVideos.Size = new System.Drawing.Size(142, 17);
            this.aCompileVideos.TabIndex = 4;
            this.aCompileVideos.Text = "Compile Videos Into One";
            this.aCompileVideos.UseVisualStyleBackColor = true;
            this.aCompileVideos.CheckedChanged += new System.EventHandler(this.aCompileVideos_CheckedChanged);
            // 
            // aDeleteClipsAfterwards
            // 
            this.aDeleteClipsAfterwards.AutoSize = true;
            this.aDeleteClipsAfterwards.Location = new System.Drawing.Point(379, 99);
            this.aDeleteClipsAfterwards.Name = "aDeleteClipsAfterwards";
            this.aDeleteClipsAfterwards.Size = new System.Drawing.Size(135, 17);
            this.aDeleteClipsAfterwards.TabIndex = 5;
            this.aDeleteClipsAfterwards.Text = "Delete Clips Afterwards";
            this.aDeleteClipsAfterwards.UseVisualStyleBackColor = true;
            this.aDeleteClipsAfterwards.Visible = false;
            // 
            // aResolutionLabel
            // 
            this.aResolutionLabel.AutoSize = true;
            this.aResolutionLabel.Location = new System.Drawing.Point(379, 137);
            this.aResolutionLabel.Name = "aResolutionLabel";
            this.aResolutionLabel.Size = new System.Drawing.Size(60, 13);
            this.aResolutionLabel.TabIndex = 6;
            this.aResolutionLabel.Text = "Resolution:";
            this.aResolutionLabel.Visible = false;
            // 
            // aXResolution
            // 
            this.aXResolution.Location = new System.Drawing.Point(379, 156);
            this.aXResolution.Name = "aXResolution";
            this.aXResolution.Size = new System.Drawing.Size(57, 20);
            this.aXResolution.TabIndex = 7;
            this.aXResolution.Text = "1920";
            this.aXResolution.Visible = false;
            // 
            // aByLabel
            // 
            this.aByLabel.AutoSize = true;
            this.aByLabel.Location = new System.Drawing.Point(442, 159);
            this.aByLabel.Name = "aByLabel";
            this.aByLabel.Size = new System.Drawing.Size(12, 13);
            this.aByLabel.TabIndex = 8;
            this.aByLabel.Text = "x";
            this.aByLabel.Visible = false;
            // 
            // aYResolution
            // 
            this.aYResolution.Location = new System.Drawing.Point(457, 156);
            this.aYResolution.Name = "aYResolution";
            this.aYResolution.Size = new System.Drawing.Size(57, 20);
            this.aYResolution.TabIndex = 9;
            this.aYResolution.Text = "1080";
            this.aYResolution.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(162, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "How?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // aFileName
            // 
            this.aFileName.Location = new System.Drawing.Point(379, 73);
            this.aFileName.Name = "aFileName";
            this.aFileName.Size = new System.Drawing.Size(117, 20);
            this.aFileName.TabIndex = 11;
            this.aFileName.Visible = false;
            // 
            // aSaveAsLabel
            // 
            this.aSaveAsLabel.AutoSize = true;
            this.aSaveAsLabel.Location = new System.Drawing.Point(379, 53);
            this.aSaveAsLabel.Name = "aSaveAsLabel";
            this.aSaveAsLabel.Size = new System.Drawing.Size(49, 13);
            this.aSaveAsLabel.TabIndex = 12;
            this.aSaveAsLabel.Text = "Save as:";
            this.aSaveAsLabel.Visible = false;
            // 
            // aMP4
            // 
            this.aMP4.AutoSize = true;
            this.aMP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aMP4.Location = new System.Drawing.Point(502, 76);
            this.aMP4.Name = "aMP4";
            this.aMP4.Size = new System.Drawing.Size(30, 13);
            this.aMP4.TabIndex = 13;
            this.aMP4.Text = ".mp4";
            this.aMP4.Visible = false;
            // 
            // aErrorText
            // 
            this.aErrorText.AutoSize = true;
            this.aErrorText.ForeColor = System.Drawing.Color.Red;
            this.aErrorText.Location = new System.Drawing.Point(141, 287);
            this.aErrorText.Name = "aErrorText";
            this.aErrorText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aErrorText.Size = new System.Drawing.Size(0, 13);
            this.aErrorText.TabIndex = 14;
            // 
            // aAddIntro
            // 
            this.aAddIntro.AutoSize = true;
            this.aAddIntro.Location = new System.Drawing.Point(379, 196);
            this.aAddIntro.Name = "aAddIntro";
            this.aAddIntro.Size = new System.Drawing.Size(69, 17);
            this.aAddIntro.TabIndex = 15;
            this.aAddIntro.Text = "Add Intro";
            this.aAddIntro.UseVisualStyleBackColor = true;
            this.aAddIntro.Visible = false;
            this.aAddIntro.CheckedChanged += new System.EventHandler(this.aAddIntro_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // aAddOutro
            // 
            this.aAddOutro.AutoSize = true;
            this.aAddOutro.Location = new System.Drawing.Point(379, 219);
            this.aAddOutro.Name = "aAddOutro";
            this.aAddOutro.Size = new System.Drawing.Size(74, 17);
            this.aAddOutro.TabIndex = 16;
            this.aAddOutro.Text = "Add Outro";
            this.aAddOutro.UseVisualStyleBackColor = true;
            this.aAddOutro.Visible = false;
            this.aAddOutro.CheckedChanged += new System.EventHandler(this.aAddOutro_CheckedChanged);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 322);
            this.Controls.Add(this.aAddOutro);
            this.Controls.Add(this.aAddIntro);
            this.Controls.Add(this.aErrorText);
            this.Controls.Add(this.aMP4);
            this.Controls.Add(this.aSaveAsLabel);
            this.Controls.Add(this.aFileName);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.aYResolution);
            this.Controls.Add(this.aByLabel);
            this.Controls.Add(this.aXResolution);
            this.Controls.Add(this.aResolutionLabel);
            this.Controls.Add(this.aDeleteClipsAfterwards);
            this.Controls.Add(this.aCompileVideos);
            this.Controls.Add(this.aProgressBar);
            this.Controls.Add(this.aGenerateVideoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aVideoURLs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TwitchVideoGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aVideoURLs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aGenerateVideoButton;
        private System.Windows.Forms.ProgressBar aProgressBar;
        private System.Windows.Forms.CheckBox aCompileVideos;
        private System.Windows.Forms.CheckBox aDeleteClipsAfterwards;
        private System.Windows.Forms.Label aResolutionLabel;
        private System.Windows.Forms.TextBox aXResolution;
        private System.Windows.Forms.Label aByLabel;
        private System.Windows.Forms.TextBox aYResolution;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox aFileName;
        private System.Windows.Forms.Label aSaveAsLabel;
        private System.Windows.Forms.Label aMP4;
        private System.Windows.Forms.Label aErrorText;
        private System.Windows.Forms.CheckBox aAddIntro;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox aAddOutro;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

