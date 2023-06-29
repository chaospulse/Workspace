using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class Advanced_Search : Form
    {
        public Advanced_Search()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ComboBoxChooseSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ComboBoxChooseSearch.SelectedIndex == 0 || this.ComboBoxChooseSearch.SelectedIndex == 1)
            {
                StringPanel.Visible = true;
                DatePanel.Visible = false;
            }

            if (this.ComboBoxChooseSearch.SelectedIndex == 2)
            {
                DatePanel.Visible = true;
                StringPanel.Visible = false;
            }
        }
        private void bSearch_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (comboBox2.SelectedIndex == 0)
            {
                if (this.ComboBoxChooseSearch.SelectedIndex == 0)
                    this.phone_Book_TableAdapter.Set_By_First_Name(this.dataSet1.Phone_Book_Table, this.textBox1.Text + "%");
                if (this.ComboBoxChooseSearch.SelectedIndex == 1)
                    this.phone_Book_TableAdapter.Set_By_Last_Name(this.dataSet1.Phone_Book_Table, this.textBox1.Text + "%");
            }
            if (comboBox2.SelectedIndex == 1)
            {
                if (this.ComboBoxChooseSearch.SelectedIndex == 0)
                    this.phone_Book_TableAdapter.Set_By_First_Name(this.dataSet1.Phone_Book_Table, "%" + this.textBox1.Text);
                if (this.ComboBoxChooseSearch.SelectedIndex == 1)
                    this.phone_Book_TableAdapter.Set_By_Last_Name(this.dataSet1.Phone_Book_Table, this.textBox1.Text + "%");
            }
            if (comboBox2.SelectedIndex == 2)
            {
                if (this.ComboBoxChooseSearch.SelectedIndex == 0)
                    this.phone_Book_TableAdapter.Set_By_First_Name(this.dataSet1.Phone_Book_Table, "%" + this.textBox1.Text + "%");
                if (this.ComboBoxChooseSearch.SelectedIndex == 1)
                    this.phone_Book_TableAdapter.Set_By_Last_Name(this.dataSet1.Phone_Book_Table, "%"+ this.textBox1.Text + "%");
               
            }
            if (comboBox2.SelectedIndex == 3)
            {
                if (this.ComboBoxChooseSearch.SelectedIndex == 0)
                    this.phone_Book_TableAdapter.Set_By_First_Name_Between(this.dataSet1.Phone_Book_Table,
                                                                            this.textBox1.Text,
                                                                            this.textBox2.Text);
                if (this.ComboBoxChooseSearch.SelectedIndex == 1)
                    this.phone_Book_TableAdapter.Set_By_Between_Last_Name(this.dataSet1.Phone_Book_Table,
                                                                          this.textBox1.Text,
                                                                           this.textBox2.Text);
            }
            if (comboBox2.SelectedIndex == 4)
            {
                if (this.ComboBoxChooseSearch.SelectedIndex == 0)
                    this.phone_Book_TableAdapter.Set_By_Not_Equal_First_Name(this.dataSet1.Phone_Book_Table, this.textBox1.Text);
                if (this.ComboBoxChooseSearch.SelectedIndex == 1)
                    this.phone_Book_TableAdapter.Set_By_Not_Equal_Last_Name(this.dataSet1.Phone_Book_Table, this.textBox1.Text);
            }
                
            
            if (this.ComboBoxChooseSearch.SelectedIndex == 2)
                this.phone_Book_TableAdapter.Set_By_Date_Of_Birth(this.dataSet1.Phone_Book_Table,
                    this.dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    this.dateTimePicker2.Value.ToString("yyyy-MM-dd"));
        }

        private void Advanced_Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Phone_Book_Table' table. You can move, or remove it, as needed.
            this.phone_Book_TableAdapter.SetData(this.dataSet1.Phone_Book_Table);
         
            this.ComboBoxChooseSearch.SelectedIndex = 0;
            
        }

        private void phone_Book_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phone_Book_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
        //method that check if the textbox has the same value as row in the database
        public bool CheckIfExist(string value)
        {
            bool check = false;
            for (int i = 0; i < this.dataSet1.Phone_Book_Table.Rows.Count; i++)
            {
                if (this.dataSet1.Phone_Book_Table.Rows[i][0].ToString() == value)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 3)
            {
                labelAND.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                labelAND.Visible = false;
                textBox2.Visible = false;
            }    
        }
    }
}
