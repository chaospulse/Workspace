using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class Media_Player_Form : Form
    {
        public Media_Player_Form()
        {
            InitializeComponent();
        }

        private void Media_Player_Form_Load(object sender, EventArgs e)
        {

        }

        private void bLoadFile_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.fullScreen = false;
            axWindowsMediaPlayer1.uiMode = "none";

            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            axWindowsMediaPlayer1.URL = path;
        }

        private void bStart_Click(object sender, EventArgs e) { axWindowsMediaPlayer1.Ctlcontrols.play(); }
        private void bPause_Click(object sender, EventArgs e) { axWindowsMediaPlayer1.Ctlcontrols.pause(); }
        private void bReset_Click(object sender, EventArgs e) { axWindowsMediaPlayer1.URL = ""; }
        private void button1_Click(object sender, EventArgs e) { this.Close(); }
        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                return;
            }
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                return;
            }
                
        }
    }
}
