using System;
using System.Diagnostics;
using NAudio;
using NAudio.Wave;

namespace Digital_Audio_Workstation
{
    public partial class DigitalAudioWorkstation : Form
    {
        BaseDAWFunctionalities baseDAWFunctionalities = new BaseDAWFunctionalities();
        private string fileName;
        public string filePath;
        bool isFirstPlay = true;
        bool musicIsPlaying = false;

        public DigitalAudioWorkstation(string fileName)
        {
            InitializeComponent();
            this.fileName = fileName;
        }


        private void Record_btn_Click(object sender, EventArgs e)
        {
            baseDAWFunctionalities.Record(this.fileName);
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            baseDAWFunctionalities.StopRecording();
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            if (!musicIsPlaying && isFirstPlay)
            {
                baseDAWFunctionalities.Play(filePath);
                musicIsPlaying = true;
                isFirstPlay = false;
            }

            else if (!isFirstPlay && !musicIsPlaying)
            {
                baseDAWFunctionalities.Resume();
                musicIsPlaying = true;
            }
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            if (musicIsPlaying)
            {
                baseDAWFunctionalities.Pause();
                musicIsPlaying = false;
            }
        }
        private void stop_buttn_Click(object sender, EventArgs e)
        {
            if (musicIsPlaying)
            {
                baseDAWFunctionalities.Stop();
                musicIsPlaying = false;
                isFirstPlay = true;
            }
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            path_textbox.Visible = true;
            path_btn.Visible = true;
            path_cancel_btn.Visible = true;
        }

        private void path_btn_Click(object sender, EventArgs e)
        {
            filePath = path_textbox.Text;
            path_textbox.Visible = false;
            path_btn.Visible = false;
            path_cancel_btn.Visible = false;
            CurrentlyPlaying();
            path_textbox.Text = "";
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            filePath = path_textbox.Text;
            path_textbox.Visible = false;
            path_btn.Visible = false;
            path_cancel_btn.Visible = false;
            path_textbox.Text = "";
        }

        private void CurrentlyPlaying()
        {
            string songName = "Currently playing: ";
            for (int i = 41; i < filePath.Length; i++)
            {
                songName += filePath[i];
            }

            musicname_txt.Text = songName;
            musicname_txt.Visible = true;
            //C:\Users\vinic\OneDrive\Área de Trabalho\
        }

        private void mute_btn_Click(object sender, EventArgs e)
        {
            baseDAWFunctionalities.Mute();
        }

        private void unmute_btn_Click(object sender, EventArgs e)
        {
            baseDAWFunctionalities.UnMute();
        }

    }
}