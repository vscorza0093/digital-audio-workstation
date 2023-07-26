using System;
using NAudio;
using NAudio.Wave;

namespace Digital_Audio_Workstation
{
    public class Example
    {
        WaveFileWriter writer;
        public WaveInEvent wave = new WaveInEvent();

        public void Record()
        {
            wave.DeviceNumber = 0;

            wave.WaveFormat = new WaveFormat(44100, 16, 1);

            wave.DataAvailable += Wave_DataAvailable;

            wave.RecordingStopped += Wave_RecordingStopped;

            string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = pathToDesktop + "/ExampleRecording";
            writer = new WaveFileWriter(filePath, wave.WaveFormat);

            wave.StartRecording();
        }

        public void StopRecording()
        {
            wave.StopRecording();
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
