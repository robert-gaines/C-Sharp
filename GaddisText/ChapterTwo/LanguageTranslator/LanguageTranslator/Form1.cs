﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void translateItalian_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "Buongiorno";
        }

        private void translateSpanish_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "Buenos Dias";
        }

        private void translateGerman_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "Guten Morgen";
        }
    }
}
