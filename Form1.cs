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

        private void aGenerateVideoButton_Click(object sender, EventArgs e)
        {
            aErrorText.Text = "";
            var videoInput = aVideoURLs.Text.TrimEnd('\r', '\n');
            var videoURLs = videoInput.Split('\n');
            aProgressBar.Visible = true;
            aProgressBar.Style = ProgressBarStyle.Marquee;
            aProgressBar.MarqueeAnimationSpeed = 30;
            var videoNum = 1;
            var videosFolderPath = Application.StartupPath + @"\Videos";


            if (!Directory.Exists(videosFolderPath))
            {
                Directory.CreateDirectory(videosFolderPath);
            }

            Thread thread = new Thread(() =>
            {
                var videos = new string[videoURLs.Length];
                foreach (var video in videoURLs)
                {
                    using (WebClient client = new WebClient())
                    {
                        try
                        {
                            client.DownloadFile(new Uri(video), videosFolderPath + @"\video" + videoNum + ".mp4");
                        }
                        catch
                        {
                            aProgressBar.Visible = false;
                            aErrorText.Text = "Error: Invalid Twitch Clip Links";
                            return;
                        }

                        videos[videoNum - 1] = videosFolderPath + @"\video" + videoNum + ".mp4";
                        videoNum++;
                    }
                }

                if (aCompileVideos.Checked)
                {
                    var validFileName = !string.IsNullOrEmpty(aFileName.Text) &&
                                        aFileName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) < 0;

                    if (!validFileName)
                    {
                        aProgressBar.Visible = false;
                        aErrorText.Text = "Error: Invalid File Name";
                        return;
                    }

                    var outputLocation = videosFolderPath + @"\" + aFileName.Text + ".mp4";

                    var ffMpeg = new FFMpegConverter();

                    var set = new ConcatSettings();
                    set.ConcatVideoStream = true;
                    set.ConcatAudioStream = true;
                    set.SetVideoFrameSize(Convert.ToInt32(aXResolution.Text), Convert.ToInt32(aYResolution.Text));

                    var videosDuplicate = videos;
                    if (aAddIntro.Checked)
                    {
                        var temp = new string[videos.Length + 1];
                        temp[0] = openFileDialog1.FileName;
                        for (int i = 0; i < videos.Length; i++)
                        {
                            temp[i + 1] = videos[i];
                        }

                        videos = temp;
                    }

                    if (aAddOutro.Checked)
                    {
                        var temp = new string[videos.Length + 1];
                        temp[videos.Length] = openFileDialog2.FileName;
                        for (int i = 0; i < videos.Length; i++)
                        {
                            temp[i] = videos[i];
                        }

                        videos = temp;
                    }


                    try
                    {
                        ffMpeg.ConcatMedia(videos, outputLocation, Format.mp4, set);
                    }
                    catch (Exception)
                    {
                        aProgressBar.Visible = false;
                        if (aAddIntro.Checked)
                        {
                            aErrorText.Text = "Error: Invalid Resolution or Invalid Twitch Clip URLs or Invalid Intro/Outro Resolution";
                        }
                        else
                        {
                            aErrorText.Text = "Error: Invalid Resolution or Invalid Twitch Clip URLs";
                        }

                        return;
                    }

                    if (aDeleteClipsAfterwards.Visible && aDeleteClipsAfterwards.Checked)
                    {
                        var listToUse = aAddIntro.Checked || aAddOutro.Checked ? videosDuplicate : videos;
                        foreach (var videoPath in listToUse) 
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
                ShowCompileVideoOptions(true);
            }
            else
            {   
                ShowCompileVideoOptions(false);
            }
        }

        private void ShowCompileVideoOptions(bool show)
        {
            aDeleteClipsAfterwards.Visible = show;
            aFileName.Visible = show;
            aSaveAsLabel.Visible = show;
            aMP4.Visible = show;
            aResolutionLabel.Visible = show;
            aByLabel.Visible = show;
            aXResolution.Visible = show;
            aYResolution.Visible = show;
            aAddIntro.Visible = show;
            aAddOutro.Visible = show;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=u03eNwpH6uA&feature=youtu.be");
        }

        private void aAddIntro_CheckedChanged(object sender, EventArgs e)
        {
            if (aAddIntro.Checked)
            {
                var result = openFileDialog1.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    aAddIntro.Checked = false;
                } else if (!openFileDialog1.FileName.EndsWith(".mp4"))
                {
                    aErrorText.Text = "Error: Intro File must be in mp4 format";
                    aAddIntro.Checked = false;
                }
            }
        }

        private void aAddOutro_CheckedChanged(object sender, EventArgs e)
        {
            if (aAddOutro.Checked)
            {
                var result = openFileDialog2.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    aAddOutro.Checked = false;
                } else if (!openFileDialog2.FileName.EndsWith(".mp4"))
                {
                    aErrorText.Text = "Error: Outro File must be in mp4 format";
                    aAddOutro.Checked = false;
                }
            }
        }
    }
}
