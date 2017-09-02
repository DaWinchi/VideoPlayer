using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;

namespace VideoPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Video our_video;

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                our_video = new Video(openFileDialog1.FileName);
                our_video.Open(openFileDialog1.FileName);
                our_video.Play();
                our_video.Owner = panel1;
                
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (!our_video.Playing) our_video.Play();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (our_video.Playing) our_video.Pause();
        }

        private void Volume_Scroll(object sender, EventArgs e)
        {
            Volume.Minimum = -10000;
            Volume.Maximum = 0;
            Volume.TickFrequency = 400;
            our_video.Audio.Volume = Volume.Value;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            { if (our_video.Playing) our_video.Pause(); else our_video.Play(); }
        }
    }
}
