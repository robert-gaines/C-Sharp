using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateStringApplication
{
    public partial class DateStringApplication : Form
    {
        public DateStringApplication()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            string OutputData = "";
            OutputData += dayOfWeekTextBox.Text;
            OutputData += " ";
            OutputData += nameOfMonth.Text;
            OutputData += " ";
            OutputData += numericDayOfMonth.Text;
            OutputData += " ";
            OutputData += yearTextBox.Text;

            dateOutputLabel.Text = OutputData ; 
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Text      = " ";
            nameOfMonth.Text           = " ";
            numericDayOfMonth.Text     = " ";
            yearTextBox.Text           = " ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
