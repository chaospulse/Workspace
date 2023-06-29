using System;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class Device_Info_Form : Form
    {
        public Device_Info_Form()
        {
            InitializeComponent();
        }

        private void bDeviceInfo_Click(object sender, EventArgs e)
        {
            textBox_DeviceName.Text = Environment.MachineName;
        }

        private void bLoginUser_Click(object sender, EventArgs e)
        {
            textBox_LoginUser.Text = Environment.UserName;
        }

        private void bCPU_Click(object sender, EventArgs e)
        {
            textBox_CPU.Text = Environment.ProcessorCount.ToString();
        }

        private void bResolution_Click(object sender, EventArgs e)
        {
            textBox_Resolution.Text = Screen.PrimaryScreen.Bounds.Width.ToString() + " ✕ " + Screen.PrimaryScreen.Bounds.Height.ToString();
        }
    }
}