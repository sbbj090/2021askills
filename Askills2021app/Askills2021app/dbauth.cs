﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Askills2021app
{
    public partial class dbauth : Form
    {
        public dbauth()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }

        private void dbauth_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form Form1 = Application.OpenForms["Form1"];
            Form1.StartPosition = FormStartPosition.Manual;
            Form1.Left = this.Left;
            Form1.Top = this.Top;
            Form1.Show();
        }
    }
}
