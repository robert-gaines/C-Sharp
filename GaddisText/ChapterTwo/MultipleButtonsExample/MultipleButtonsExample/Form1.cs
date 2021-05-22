using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleButtonsExample
{
    public partial class MultipleButtonsExample : Form
    {
        public MultipleButtonsExample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the first button!");
        }

        private void SecondButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the second button!");
        }

        private void ThirdButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the third button!");
        }
    }
}
