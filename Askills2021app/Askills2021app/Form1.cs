using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form CargoRequest = new CargoRequest();
            CargoRequest.StartPosition = FormStartPosition.Manual;
            CargoRequest.Left = this.Left;
            CargoRequest.Top = this.Top;
            CargoRequest.Show();
        }
    }
}
