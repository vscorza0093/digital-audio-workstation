using System;
using System.Collections;
using System.Diagnostics;
using System.DirectoryServices;
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
        bool isRecording = false;
        bool isRecordPaused = false;

        private int counter = 0;

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public DigitalAudioWorkstation(string fileName)
        {
            InitializeComponent();
            rec_text.Text = "Aguardando";
            this.fileName = fileName;
        }

        private void start_record_btn_Click(object sender, EventArgs e)
        {
            if (!isRecording && !isRecordPaused)
            {
                isRecordPaused = false;
                isRecording = true;
                baseDAWFunctionalities.Record(this.fileName);
                rec_text.Text = "Gravando";
                start_record_btn.Text = "Recording";
            }
            else if (isRecording && isRecordPaused)
            {
                start_record_btn.Text = "Recording";
                pause_record_btn.Text = "Pause Recording";
                isRecordPaused = false;
                rec_text.Text = "Gravando";
                baseDAWFunctionalities.ResumeRecord();
            }
            else
            {

            }
        }
        private void pause_record_btn_Click(object sender, EventArgs e)
        {
            if (isRecording && !isRecordPaused)
            {
                pause_record_btn.Text = "Resume Recording";
                start_record_btn.Text = "Resume Recording";
                isRecordPaused = true;
                rec_text.Text = "Pausado";
                baseDAWFunctionalities.PauseRecording();
            }
            else if (isRecording && isRecordPaused)
            {
                start_record_btn.Text = "Recording";
                pause_record_btn.Text = "Pause Recording";
                isRecordPaused = false;
                rec_text.Text = "Gravando";
                baseDAWFunctionalities.ResumeRecord();
            }
            else
            {
            }
        }

        private void stop_record_btn_Click(object sender, EventArgs e)
        {
            if (isRecording)
            {
                baseDAWFunctionalities.StopRecording();
            }
        }

        private void play_audio_btn_Click(object sender, EventArgs e)
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

        private void pause_audio_btn_Click(object sender, EventArgs e)
        {
            if (musicIsPlaying)
            {
                baseDAWFunctionalities.Pause();
                musicIsPlaying = false;
            }
        }
        private void stop_audio_btn_Click(object sender, EventArgs e)
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

        private void settings_btn_Click(object sender, EventArgs e)
        {
            var settingsForm = new IOSettings();
            settingsForm.Show();
        }

    }
}