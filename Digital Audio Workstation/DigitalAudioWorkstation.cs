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
        const string waitingToRec = "Aguardando...";
        const string recording = "Gravando";
        const string pausedRec = "Pausado";

        BaseDAWFunctionalities baseDAWFunctionalities = new BaseDAWFunctionalities();
        private string fileName;
        public string filePath;
        bool isFirstPlay = true;
        bool musicIsPlaying = false;
        bool isRecording = false;
        bool isRecordPaused = false;

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public DigitalAudioWorkstation(string fileName)
        {
            InitializeComponent();
            rec_text.Text = waitingToRec.ToString();
            this.fileName = fileName;
        }

        private void start_record_btn_Click(object sender, EventArgs e)
        {
            if (!isRecording && !isRecordPaused)
            {
                StartRecording();
            }
            else if (isRecording && isRecordPaused)
            {
                ResumeRecording();
            }
        }

        private void StartRecording()
        {
            rec_text.Text = recording.ToString();
            start_record_btn.Text = "Recording";
            isRecordPaused = false;
            isRecording = true;
            baseDAWFunctionalities.Record(this.fileName);
        }

        private void ResumeRecording()
        {
            start_record_btn.Text = "Recording";
            pause_record_btn.Text = "Pause Recording";
            rec_text.Text = recording.ToString();
            isRecordPaused = false;
            baseDAWFunctionalities.ResumeRecord();
        }

        private void PauseRecord()
        {
            pause_record_btn.Text = "Resume Recording";
            start_record_btn.Text = "Resume Recording";
            rec_text.Text = pausedRec.ToString();
            isRecordPaused = true;
            baseDAWFunctionalities.PauseRecording();
        }

        private bool IsPaused()
        {
            return isRecording && isRecordPaused;
        }

        private bool IsRecording()
        {
            return isRecording && !isRecordPaused;
        }
        private void pause_record_btn_Click(object sender, EventArgs e)
        {
            if (IsRecording())
            {
                PauseRecord();
            }
            else if (IsPaused())
            {
                ResumeRecording();
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