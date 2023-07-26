using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Audio_Workstation
{
    public partial class InitialForm : Form
    {
        public string fileName;

        public InitialForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            fileName = fileName_textBox.Text;
            var myForm = new DigitalAudioWorkstation(fileName);
            this.Hide();
            myForm.Show();
        }
    }
}
