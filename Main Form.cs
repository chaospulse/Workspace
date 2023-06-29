using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }
        private void bRegisterData_Click(object sender, EventArgs e)
        {
            Registration_Form rf = new Registration_Form();
            rf.ShowDialog();
            rf.Dispose();
        }
        private void bSearch_Click(object sender, EventArgs e)
        {
            Advanced_Search advanced_Search = new Advanced_Search();
            advanced_Search.MdiParent = this;
            advanced_Search.Show();
        }
        private void bCalculator_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "calc.exe";
            process1.Start();
        }
        private void bExit_Click(object sender, EventArgs e) { Close(); }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                bRegisterData_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                bSearch_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                bCalculator_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                bUsers_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void bMediaPlayer_Click(object sender, EventArgs e)
        {
            Media_Player_Form mpf = new Media_Player_Form();
            mpf.Show();
        }
        private void bDeviceInfo_Click(object sender, EventArgs e)
        {
            Device_Info_Form dif = new Device_Info_Form();
            dif.MdiParent = this;
            dif.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.ShowDialog();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = lf.pictureBox1.Image;
            labelUserName.Text = Phone_Book.Properties.Settings.Default.login_first_name;
        }

        private void bCalendar_Click(object sender, EventArgs e)
        {
            Calendar_Form cf = new Calendar_Form();
            cf.MdiParent = this;
            cf.Show();
        }

        private void timer1_Tick(object sender, EventArgs e) { }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            BackColor = colorDialog1.Color;
        }

        private void selectImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            BackgroundImage = Image.FromFile(openFileDialog1.FileName);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 0, 128, 128);
            BackgroundImage = null;
        }

        private void bUsers_Click(object sender, EventArgs e)
        {
            Users_List ul = new Users_List();
            ul.MdiParent = this;
            ul.Show();
        }

     

        private void b_Logout_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.ShowDialog();
            Close();
        }
    }
}
