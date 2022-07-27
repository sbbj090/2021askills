using Npgsql;
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
    public partial class dbauth : Form
    {

        public dbauth()
        {
            InitializeComponent();
        }
        
       

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Логин")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Логин";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Пароль")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Пароль";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void dbauth_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form Form1 = Application.OpenForms["Form1"];
            //Form1.StartPosition = FormStartPosition.Manual;
            //Form1.Left = this.Left;
            //Form1.Top = this.Top;
            Form1.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            //if (NpgsqlConnection.) {
            try
            {
                dbconnect();
                //Form1.label1.Text = "База данных подключена";
            }
            catch
            {
                MessageBox.Show("Ошибка подключения базы данных");
            }
        }
        public void dbconnect()
        {
            string conn_param = "Server=localhost;Port=5432;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";Database=rosatomlogistics;";
            NpgsqlConnection conn = new NpgsqlConnection(conn_param);
            conn.Open();
            this.Close();
            string dbstatus = "База данных подключена";
            //Form1.dbConnection = true;
        }
    }
}
//string sql = "текст запроса к базе данных"; //NpgsqlCommand comm = new NpgsqlCommand(sql, conn);