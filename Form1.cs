﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Caldemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            double c = a + b;
            label1.Text = c.ToString();
        }
    }
}
