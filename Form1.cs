using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NReco.VideoConverter;

namespace TwitchVideoGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
 

        private void aGenerateVideoButton_Click(object sender, EventArgs e)
        {
            var videoInput = aVideoURLs.Text.TrimEnd('\r', '\n');
            var videoURLs = videoInput.Split('\n');
            aProgressBar.Visible = true;
            aProgressBar.Style = ProgressBarStyle.Marquee;
            aProgressBar.MarqueeAnimationSpeed = 30;
            var videoNum = 1;
            Thread thread = new Thread(() =>
            {
                var videos = new string[videoURLs.Length];
                foreach (var video in videoURLs)
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(new Uri(video), Application.StartupPath + @"\video" + videoNum + ".mp4");
                        videos[videoNum - 1] = Application.StartupPath + @"\video" + videoNum + ".mp4";
                        videoNum++;
                    }
                }

                if (aCompileVideos.Checked)
                {
                    var outputLocation = Application.StartupPath + @"\compiledVideo.mp4";
                    var ffMpeg = new FFMpegConverter();

                    var set = new ConcatSettings();
                    set.ConcatVideoStream = true;
                    set.ConcatAudioStream = true;
                    set.SetVideoFrameSize(Convert.ToInt32(aXResolution.Text), Convert.ToInt32(aYResolution.Text));

                    ffMpeg.ConcatMedia(videos, outputLocation, Format.mp4, set);

                    if (aDeleteClipsAfterwards.Visible && aDeleteClipsAfterwards.Checked)
                    {
                        foreach (var videoPath in videos) 
                        {
                            if (File.Exists(videoPath)) 
                            {
                                File.Delete(videoPath);
                            }
                        }
                    }
                }

                aProgressBar.Visible = false;
            })
            {IsBackground = true};  
            thread.Start();
        }

        private void aCompileVideos_CheckedChanged(object sender, EventArgs e)
        {
            if (aCompileVideos.Checked)
            {
                aDeleteClipsAfterwards.Visible = true;
            }
            else
            {
                if (aDeleteClipsAfterwards.Visible)
                {
                    if (aDeleteClipsAfterwards.Checked)
                        aDeleteClipsAfterwards.Checked = false;
                    
                    aDeleteClipsAfterwards.Visible = false;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=u03eNwpH6uA&feature=youtu.be");
        }
    }
}
