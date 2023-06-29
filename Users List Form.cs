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
    public partial class Users_List : Form
    {
        public Users_List()
        {
            InitializeComponent();
        }

        private void phone_Book_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phone_Book_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }
        private void bEdit_Click(object sender, EventArgs e)
        {
            Edit_Users_Form euf = new Edit_Users_Form();
            euf.ShowDialog();
            euf.Dispose();
        }

        private void Users_List_Load(object sender, EventArgs e)
        {
            //fill table

            this.phone_Book_TableAdapter.SetData(this.dataSet1.Phone_Book_Table);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
