﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static login.Form1;
using static System.Windows.Forms.DataFormats;

namespace login
{
    public partial class Form2 : Form
    {
        private Form1 form1Instance;
        public Form2()
        {
            InitializeComponent();
            Form1 form1 = new Form1(); // Create an instance of Form2
            string textBoxValue = SharedData.TextBoxValue;
            string textEmailValue = SharedData.TextEmailValue;
            label2.Text = textBoxValue;
            label3.Text = textEmailValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
