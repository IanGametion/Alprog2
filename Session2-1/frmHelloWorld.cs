﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2_1
{
    public partial class frmHelloWorld: Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for clicking the button!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
