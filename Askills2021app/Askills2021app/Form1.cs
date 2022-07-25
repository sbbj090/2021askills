using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dbauth = new dbauth();
            dbauth.StartPosition = FormStartPosition.Manual;
            dbauth.Left = this.Left;
            dbauth.Top = this.Top;
            dbauth.Show();

            /*
            string connectionString;
            SqlConnection sqlcn;
            connectionString = @"Data Source=;Initial Catalog=;User ID=user1; Password=sa";
            sqlcn = new SqlConnection(connectionString);
            sqlcn.Open();*/
        }
    }
}
