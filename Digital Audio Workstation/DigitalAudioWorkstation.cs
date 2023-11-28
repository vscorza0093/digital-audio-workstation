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
        const string waitingToRec = "Waiting...";
        const string recording = "Recording";
        const string paused = "Paused";
        const string pauseRecording = "Pause Recording";
        const string resumeRecording = "Resume Recording";

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
            volume_bar.Value = 100;
            this.fileName = fileName;
        }

        private void start_record_btn_Click(object sender, EventArgs e)
        {
            if (IsNotRecording())
                StartRecording();

            else if (IsPaused())
                ResumeRecording();
        }
        private void pause_record_btn_Click(object sender, EventArgs e)
        {
            if (IsRecordingAndNotPaused())
                PauseRecord();

            else if (IsPaused())
                ResumeRecording();
        }

        private void stop_record_btn_Click(object sender, EventArgs e)
        {
            if (IsRecordingAndNotPaused())
                StopRecord();
        }

        private void StartRecording()
        {
            rec_text.Text = recording;
            start_record_btn.Text = recording;
            isRecordPaused = false;
            isRecording = true;
            baseDAWFunctionalities.Record(this.fileName);
        }

        private void ResumeRecording()
        {
            start_record_btn.Text = recording;
            pause_record_btn.Text = pauseRecording;
            rec_text.Text = recording.ToString();
            isRecordPaused = false;
            baseDAWFunctionalities.ResumeRecord();
        }

        private void PauseRecord()
        {
            pause_record_btn.Text = resumeRecording;
            start_record_btn.Text = resumeRecording;
            rec_text.Text = paused;
            isRecordPaused = true;
            baseDAWFunctionalities.PauseRecording();
        }

        private void StopRecord()
        {
            baseDAWFunctionalities.StopRecording();
        }

        private bool IsNotRecording()
        {
            return !isRecording && !isRecordPaused;
        }

        private bool IsPaused()
        {
            return isRecording && isRecordPaused;
        }

        private bool IsRecordingAndNotPaused()
        {
            return isRecording && !isRecordPaused;
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
            MutePlayingAudio();
        }

        private void unmute_btn_Click(object sender, EventArgs e)
        {
            UnMutePlayingAudio();
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            var settingsForm = new IOSettings();
            settingsForm.Show();
        }

        private void MutePlayingAudio()
        {
            baseDAWFunctionalities.Mute();
        }

        private void UnMutePlayingAudio()
        {
            baseDAWFunctionalities.UnMute();
        }

        private void volume_bar_Scroll(object sender, EventArgs e)
        {
            var wo = new WaveOutEvent();
            volume_bar.Scroll += (s, a) => wo.Volume = volume_bar.Value / 100f;
        }
    }
}