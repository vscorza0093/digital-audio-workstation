using System;
using NAudio;
using NAudio.Wave;

namespace Digital_Audio_Workstation
{
    public partial class Form1 : Form
    {
        Example example = new Example();


        public Form1()
        {
            InitializeComponent();
        }

        private void Record_btn_Click(object sender, EventArgs e)
        {
            example.Record();
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            example.StopRecording();
        }
    }
}