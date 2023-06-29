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
    public partial class Calendar_Form : Form
    {
        public Calendar_Form()
        {
            InitializeComponent();
            timer1.Start();
            //
            System.Globalization.GregorianCalendar gc = new System.Globalization.GregorianCalendar();
            label_year.Text = gc.GetYear(DateTime.Now).ToString();
            //
            label_month.Text = CalculateMonth(gc.GetMonth(DateTime.Now).ToString());
            //
            label_date.Text = gc.GetDayOfMonth(DateTime.Now).ToString() + ", " + gc.GetDayOfWeek(DateTime.Now).ToString();
        }
        private string CalculateMonth(string date)
        {
            if (date == "1")  { return Months.January.ToString(); }
            if (date == "2")  { return Months.February.ToString(); }
            if (date == "3")  { return Months.March.ToString(); }
            if (date == "4")  { return Months.April.ToString(); }
            if (date == "5")  { return Months.May.ToString(); }
            if (date == "6")  { return Months.June.ToString(); }
            if (date == "7")  { return Months.July.ToString(); }
            if (date == "8")  { return Months.August.ToString(); }
            if (date == "9")  { return Months.September.ToString(); }
            if (date == "10") { return Months.October.ToString(); }
            if (date == "11") { return Months.November.ToString(); }
            if (date == "12") { return Months.December.ToString(); }
            return "Error";
        }
        enum Months { January = 1, February, March, April, May, June, July, August, September, October, November, December };
        private void timer1_Tick(object sender, EventArgs e) { label_time.Text = DateTime.Now.ToString("HH:mm:ss"); }
        private void Calendar_Form_FormClosed(object sender, FormClosedEventArgs e) { timer1.Stop(); }
        private void Calendar_Form_Load(object sender, EventArgs e)
        {

        }

        private void label_month_Click(object sender, EventArgs e)
        {

        }
    }
}
