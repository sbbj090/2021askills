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
            
            
            textBox6.Text = "Количество";
            
            
            
            
            
            
            

            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;

            textBox4.ForeColor = Color.Gray;
            textBox5.ForeColor = Color.Gray;
            textBox6.ForeColor = Color.Gray;
            textBox7.ForeColor = Color.Gray; 
            textBox8.ForeColor = Color.Gray;
            textBox9.ForeColor = Color.Gray;
            textBox11.ForeColor = Color.Gray;
         
            textBox15.ForeColor = Color.Gray;
            textBox16.ForeColor = Color.Gray;



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
        //
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Наименование")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Наименование";
                textBox1.ForeColor = Color.Gray;
            }
        }
        //
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "ИНН")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "ИНН";
                textBox2.ForeColor = Color.Gray;
            }
        }
        //
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "ФИО ответственного")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "ФИО ответственного";
                textBox3.ForeColor = Color.Gray;
            }
        }
        //
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Контактный телефон или Email")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black; 
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Контактный телефон или Email";
                textBox4.ForeColor = Color.Gray;
            }
        }
        //
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Наименование")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Наименование";
                textBox5.ForeColor = Color.Gray;
            }
        }
        //
        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Количество")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Количество";
                textBox6.ForeColor = Color.Gray;
            }
        }
        //
        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Общий вес")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }
        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Общий вес";
                textBox7.ForeColor = Color.Gray;
            }
        }
        //
        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Объем занимаемый грузом")
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.Black;
            }
        }
        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Объем занимаемый грузом";
                textBox8.ForeColor = Color.Gray;
            }
        }
        //
        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Особые требования")
            {
                textBox9.Text = "";
                textBox9.ForeColor = Color.Black;
            }
        }
        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Особые требования";
                textBox9.ForeColor = Color.Gray;
            }
        }
        //
        private void textBox11_Enter(object sender, EventArgs e)
        {
            if (textBox11.Text == "Наименование организации")
            {
                textBox11.Text = "";
                textBox11.ForeColor = Color.Black;
            }
        }
        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                textBox11.Text = "Наименование организации";
                textBox11.ForeColor = Color.Gray;
            }
        }
        //
        private void textBox12_Enter(object sender, EventArgs e)
        {
            if (textBox12.Text == "Адрес точки получения")
            {
                textBox12.Text = "";
                textBox12.ForeColor = Color.Black;
            }
        }
        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
                textBox12.Text = "Адрес точки получения";
                textBox12.ForeColor = Color.Gray;
            }
        }
        //
        private void textBox15_Enter(object sender, EventArgs e)
        {
            if (textBox15.Text == "ФИО ответственного")
            {
                textBox15.Text = "";
                textBox15.ForeColor = Color.Gray;
            }
        }
        private void textBox15_Leave(object sender, EventArgs e)
        {
            if (textBox15.Text == "")
            {
                textBox15.Text = "ФИО ответственного";
                textBox15.ForeColor = Color.Black;
            }
        }
        //
        private void textBox16_Enter(object sender, EventArgs e)
        {
            if (textBox16.Text == "Контактный телефон")
            {
                textBox16.Text = "";
                textBox16.ForeColor = Color.Black;
            }
        }
        private void textBox16_Leave(object sender, EventArgs e)
        {
            if (textBox16.Text == "")
            {
                textBox16.Text = "Контактный телефон";
                textBox16.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var helper = new WordHelper("Zayavka.doc");
            var items = new Dictionary<string, string>
            {
                {"<ORGZ>", textBox1.Text },
                {"<INN>", textBox2.Text },
                {"<OTVZ>", textBox3.Text },
                {"<EMAILZ>", textBox4.Text },
                {"<CNAME>", textBox5.Text },
                {"<QTY>", textBox6.Text },
                {"<WGT>", textBox7.Text },
                {"<VOL>", textBox8.Text },
                {"<REQ>", textBox9.Text },
                {"<ORGP>", textBox11.Text },
                {"<>", textBox12.Text },
                {"<ORG>", textBox15.Text },
                {"<ORG>", textBox16.Text }
            };
            helper.Process(items);
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "Адрес точки отправления")
            {
                textBox10.Text = "";
                textBox10.ForeColor = Color.Black;
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textBox10.Text = "Адрес точки отправления";
                textBox10.ForeColor = Color.Gray;
            }
        }
    }
}
