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
    public partial class Login_Form : Form
    {
        public Login_Form()  { InitializeComponent(); }

        private int TryEnterPassword = 0;
        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        { 
            if (ShowPasswordCheckBox.Checked)
                PasswordTextBox.UseSystemPasswordChar = false;
            else
                PasswordTextBox.UseSystemPasswordChar = true;
        }
        private void bExit_Click(object sender, EventArgs e)  { Application.Exit(); }
        
        private void bLogin_Click(object sender, EventArgs e)
        {
            if (CheckPassword())
            {
                Phone_Book.Properties.Settings.Default.login_first_name = this.first_NameLabel1.Text;
                this.Dispose();
                return;
            }
            if(TryEnterPassword <= 2)
                MessageBox.Show("The password you entered is incorrect. Please try again.", "INCORRECT PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(TryEnterPassword > 2)
            {
                DialogResult dr = MessageBox.Show("You entered wrong password for one user more than 3 times, register New User?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                    bRegistrate_Click(sender, e);
            }
        }
        
        private void Login_Form_Load(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
            //
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //
            this.phone_Book_TableAdapter.SetData(this.dataSet1.Phone_Book_Table);
        }
        private bool CheckPassword()
        {
            TryEnterPassword++;
            foreach (DataRow row in dataSet1.Phone_Book_Table.Rows)
            {
                if (row["Password"].ToString() == PasswordTextBox.Text)
                    return true;
            }
            PasswordTextBox.Text = "";
            return false;
        }

        private void bRegistrate_Click(object sender, EventArgs e)
        {
            Registration_Form rf = new Registration_Form();
            rf.ShowDialog();
            rf.Dispose();

            //update data
            this.phone_Book_TableAdapter.SetData(this.dataSet1.Phone_Book_Table);
        }
    }
}
