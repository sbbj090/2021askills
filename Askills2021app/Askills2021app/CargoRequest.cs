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
    public partial class CargoRequest : Form
    {
        public CargoRequest()
        {
            InitializeComponent();
            textBox1.Text = "Наименование";
            //textBox1.ForeColor = Color.LightGray;

            textBox1.GotFocus += RemoveText;
            textBox1.LostFocus += AddText;
        }

        public void RemoveText(object sender, EventArgs e) //Ваще это в метод не воид надо сунуть чтоб юзать этот плейсхолдер ко всем текстбоксам в заявке, но мне лень
        {                                                  //А так оно работает, пока на одном поле

            if (textBox1.Text == "Наименование")
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Наименование";
                textBox1.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void CargoRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form Form1 = Application.OpenForms["Form1"];
            Form1.StartPosition = FormStartPosition.Manual;
            Form1.Left = this.Left;
            Form1.Top = this.Top;
            Form1.Show();

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
