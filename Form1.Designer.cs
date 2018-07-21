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
            this.label2 = new System.Windows.Forms.Label();
            this.aXResolution = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aYResolution = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
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
            this.aCompileVideos.Location = new System.Drawing.Point(382, 29);
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
            this.aDeleteClipsAfterwards.Location = new System.Drawing.Point(382, 53);
            this.aDeleteClipsAfterwards.Name = "aDeleteClipsAfterwards";
            this.aDeleteClipsAfterwards.Size = new System.Drawing.Size(135, 17);
            this.aDeleteClipsAfterwards.TabIndex = 5;
            this.aDeleteClipsAfterwards.Text = "Delete Clips Afterwards";
            this.aDeleteClipsAfterwards.UseVisualStyleBackColor = true;
            this.aDeleteClipsAfterwards.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resolution:";
            // 
            // aXResolution
            // 
            this.aXResolution.Location = new System.Drawing.Point(382, 96);
            this.aXResolution.Name = "aXResolution";
            this.aXResolution.Size = new System.Drawing.Size(57, 20);
            this.aXResolution.TabIndex = 7;
            this.aXResolution.Text = "1920";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "x";
            // 
            // aYResolution
            // 
            this.aYResolution.Location = new System.Drawing.Point(460, 96);
            this.aYResolution.Name = "aYResolution";
            this.aYResolution.Size = new System.Drawing.Size(57, 20);
            this.aYResolution.TabIndex = 9;
            this.aYResolution.Text = "1080";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 322);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.aYResolution);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aXResolution);
            this.Controls.Add(this.label2);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aXResolution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aYResolution;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

