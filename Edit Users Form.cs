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
    public partial class Edit_Users_Form : Form
    {
        public Edit_Users_Form() { InitializeComponent(); }
       
        private void About_Us_Form_Load(object sender, EventArgs e)
        {
            try
            {
                this.phone_Book_TableAdapter.SetData(this.pb_dataset.Phone_Book_Table);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //
                this.phone_Book_TableDataGridView.EnableHeadersVisualStyles = false;
                //
                // background
                this.phone_Book_TableDataGridView.BackgroundColor = Color.LightCyan;
                //
                // background for header
                this.phone_Book_TableDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple;
                this.phone_Book_TableDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                //this.phone_Book_TableDataGridView.Columns[0].HeaderCell.Style.BackColor = Color.Magenta;
                //
                // background for left border 
                this.phone_Book_TableDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Red;
                //
                info_refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void phone_Book_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phone_Book_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pb_dataset);
        }

        private void bAddNewData_Click(object sender, EventArgs e)
        {
            bSave.Enabled = true;
            bEnd.Enabled = true;
            bCancel.Enabled = true;
            //
            bEdit.Enabled = false;
            bEdit.Enabled = false;
            bDelete.Enabled = false;
            //
            groupBox1.Enabled = true;
            this.phone_Book_TableBindingSource.AddNew();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            bSave.Enabled = true;
            bEnd.Enabled = true;
            bDelete.Enabled = true;
            groupBox1.Enabled = true;
            bCancel.Enabled = true;
            //
            bAddNewData.Enabled = false;
            bEdit.Enabled = false;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            bSave.Enabled = false;
            bEnd.Enabled = false;
            groupBox1.Enabled = false;
            //
            bAddNewData.Enabled = true;
            bEdit.Enabled = true;
            bDelete.Enabled = true;
            //
            this.phone_Book_TableBindingSource.EndEdit();
            int n = this.phone_Book_TableAdapter.Update(this.pb_dataset.Phone_Book_Table);
            MessageBox.Show("Updated " + n + " rows", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void bDelete_Click(object sender, EventArgs e)
        {
            //checking for existing rows in table
            if (this.phone_Book_TableBindingSource.Count == 0)
            {
                MessageBox.Show("No data to edit", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
                this.phone_Book_TableBindingSource.RemoveCurrent();
            
           
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.pb_dataset.RejectChanges();
            this.phone_Book_TableBindingSource.CancelEdit();
        }
        //
        private void bSort_Click(object sender, EventArgs e) {// this.phone_Book_TableAdapter.Set_By_Triple(this.pb_dataset.Phone_Book_Table);
                                                              }
        //
        //
        //
        private void bFirst_Click(object sender, EventArgs e)
        {
            this.phone_Book_TableBindingSource.MoveFirst();
            info_refresh();
        }
        private void bPrev_Click(object sender, EventArgs e)
        {
            this.phone_Book_TableBindingSource.MovePrevious();
            info_refresh();
        }
        private void bNext_Click(object sender, EventArgs e)
        {
            this.phone_Book_TableBindingSource.MoveNext();
            info_refresh();
        }
        private void bLast_Click(object sender, EventArgs e)
        {
            this.phone_Book_TableBindingSource.MoveLast();
            info_refresh();
        }
        private void bExit_Click(object sender, EventArgs e) { Close(); }
        private void bBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            //resize
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //load image
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

        }
        //
        //
        //
        private void info_refresh()
        {
            int position = this.phone_Book_TableBindingSource.Position;
            this.label1.Text = (position+1).ToString();
            this.label2.Text = "of " + this.phone_Book_TableBindingSource.Count.ToString();
        }
        private void phone_Book_TableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)  { }
        //
        // backgroundcolor
        private void phone_Book_TableDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewRow row in phone_Book_TableDataGridView.Rows)
            {
                if (row.Cells[1].Value == null)
                    return;
                if (row.Cells[1].Value.ToString().Length >= 5)
                    row.DefaultCellStyle.BackColor = Color.LightPink;
               else
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
            }
            if (e.ColumnIndex == 3 & e.Value != null)
            {
                if (e.Value.ToString().Replace(" ", "").Length < 5)
                    e.CellStyle.BackColor = Color.Red;
                else
                    e.CellStyle.BackColor = Color.Lime;
            }
            //
            else if (e.Value.ToString() == "Dima")
                e.CellStyle.BackColor = Color.Lime;
            //
            else if (e.Value.ToString() == "")
                e.CellStyle.BackColor = Color.Cornsilk;
        }
        //
        //
        //
        private void bSearch_Click(object sender, EventArgs e)
        {
            this.phone_Book_TableAdapter.Set_By_Last_Name(this.pb_dataset.Phone_Book_Table, textBoxSearch.Text + "%");
        }

        private void bAdvancedSearch_Click(object sender, EventArgs e)
        {
            Advanced_Search advanced_Search = new Advanced_Search();
            advanced_Search.ShowDialog();
            advanced_Search.Dispose();
        }
    }
}
