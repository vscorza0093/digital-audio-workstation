using System;
using NAudio;
using NAudio.Wave;

namespace Digital_Audio_Workstation
{
    public partial class IOSettings : Form
    {
        public static int InputDeviceInt;
        public static int OutputDeviceInt;
        public IOSettings()
        {
            InitializeComponent();
            LoadDevices();
            InputDeviceInt = 0;
            OutputDeviceInt = 0;
            input_cbox.SelectedIndex = 0;
            output_cbox.SelectedIndex = 0;  
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadDevices()
        {
            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(i);
                input_cbox.Items.Add(deviceInfo.ProductName);
            }

            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                WaveOutCapabilities deviceInfo = WaveOut.GetCapabilities(i);
                output_cbox.Items.Add(deviceInfo.ProductName);
            }
        }

        private void input_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputDeviceInt = input_cbox.SelectedIndex;
        }

        private void output_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutputDeviceInt = output_cbox.SelectedIndex;
        }
    }
}
