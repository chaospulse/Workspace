using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class Registration_Form : Form
    {
        public Registration_Form() { InitializeComponent(); }

        private void bNewData_Click(object sender, EventArgs e)
        {
            bSaveChanges.Enabled = true;
            bNewData.Enabled = false;
            bNewData2.Enabled = false;
            groupBoxInformation.Enabled = true;
        }
        private void bSaveChanges_Click(object sender, EventArgs e)
        {
            if (first_NameTextBox.Text == "" || last_NameTextBox.Text == "" || passwordTextBox.Text == "" || telephoneTextBox.Text == "" || emailTextBox.Text == "" || addressTextBox.Text == "" || commentTextBox.Text == "")
            {
                MessageBox.Show("Fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (passwordTextBox.Text != RepeatPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords are not the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Int32.Parse(indexTextBox.Text) < 0)
            {
                MessageBox.Show("Index is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (date_Of_BirthDateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Date of birth is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //saving using ado.net
            string connection = "Data Source = LAPTOP-54DEQRCD; Initial Catalog = Phone_Book; Integrated Security = true;  TrustServerCertificate=True;";
            SqlConnection sql = new SqlConnection(connection);
            sql.Open();

            string querry = "INSERT INTO Phone_Book_Table([First Name],[Index],[Last Name],Password, Telephone,Email,Address,Comment,Date_Of_Birth) VALUES ('" +
                first_NameTextBox.Text + "'," +
                Int32.Parse(indexTextBox.Text) + ",'" +
                last_NameTextBox.Text  + "','" +
                passwordTextBox.Text   + "','" +
                telephoneTextBox.Text  + "','" +
                emailTextBox.Text      + "','" +
                addressTextBox.Text    + "','" +
                commentTextBox.Text    + "','" +
                date_Of_BirthDateTimePicker.Value.ToString("yyyy-MM-dd") + "')";
            
            SqlCommand sqlcmd = new SqlCommand(querry, sql);
            int check = sqlcmd.ExecuteNonQuery();
            
            if (check > 0) 
                MessageBox.Show("Succses!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else 
                MessageBox.Show("Error!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            sql.Close();
            Dispose();
        }
        
        private void bNewData2_Click(object sender, EventArgs e)
        {
            this.phone_Book_TableBindingSource.AddNew();
            bSave2.Enabled = true;
            bNewData2.Enabled = false;
            bNewData.Enabled = false;
            groupBoxInformation.Enabled = true;
        }
        private void bSave2_Click(object sender, EventArgs e)
        {
            if (first_NameTextBox.Text == "" || last_NameTextBox.Text == "" || passwordTextBox.Text == "" || telephoneTextBox.Text == "" || emailTextBox.Text == "" || addressTextBox.Text == "" || commentTextBox.Text == "")
            {
                MessageBox.Show("Fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (passwordTextBox.Text != RepeatPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords are not the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Int32.Parse(indexTextBox.Text) < 0)
            {
                MessageBox.Show("Index is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (date_Of_BirthDateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Date of birth is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            phone_Book_TableBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataSet1);
            bSave2.Enabled = false;
            bNewData.Enabled = true;
            bNewData2.Enabled = true;
            groupBoxInformation.Enabled = false;
            MessageBox.Show("Succses!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void phone_Book_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phone_Book_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }
        private void Registration_Form_Load(object sender, EventArgs e)
        {
            this.phone_Book_TableAdapter.SetData(this.dataSet1.Phone_Book_Table);
            foreach (Control c in groupBoxInformation.Controls)
            {
                if (c is TextBox)
                    c.ResetText();
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void bBrowse_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}
