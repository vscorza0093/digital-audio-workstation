using NAudio;
using NAudio.Wave;
using System;
using System.Diagnostics;

namespace Digital_Audio_Workstation
{
    public class BaseDAWFunctionalities
    {
        WaveFileWriter writer;
        WaveInEvent wave = new WaveInEvent();
        WaveOut waveOut;

        public void Play(string filePath)
        {
            waveOut = new WaveOut();
            waveOut.DeviceNumber = 0;

            AudioFileReader audioFileReader = new AudioFileReader(filePath);

            waveOut.Init(audioFileReader);
            waveOut.Play();
        }

        public void Stop()
        {
            waveOut.Stop();
        }

        public void Resume()
        {
            waveOut.Resume();
        }

        public void Pause()
        {
            waveOut.Pause();
        }

        public void Mute()
        {
            waveOut.Volume = 0;
        }

        public void UnMute()
        {
            waveOut.Volume = 1;
        }

        public void Record(string fileName)
        {
            wave.DeviceNumber = 0;

            wave.WaveFormat = new WaveFormat(44100, 16, 1);

            wave.DataAvailable += Wave_DataAvailable;


            string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = pathToDesktop + $"/{fileName}.wav";
            writer = new WaveFileWriter(filePath, wave.WaveFormat);

            wave.RecordingStopped += Wave_RecordingStopped;
            wave.StartRecording();
        }

        public void ResumeRecord()
        {
            wave.DataAvailable += Wave_DataAvailable;
        }

        public void PauseRecording()
        {
            wave.DataAvailable -= Wave_DataAvailable;
        }


        public void StopRecording()
        {
            wave.StopRecording();
            writer.Close();
            Application.Exit();
        }

        private void Wave_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }

        private void Wave_RecordingStopped(object sender, StoppedEventArgs e)
        {
            writer.Dispose();
        }
    }
}
