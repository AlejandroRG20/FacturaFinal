using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alejandro
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sub, des, total;
            

            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Nose permiten espacios");
                maskedTextBox1.Text = "";
                maskedTextBox1.Focus();
            }
            else
            {

                sub = double.Parse(maskedTextBox1.Text);

                if (checkBox1.Checked == true)
            {
                    
                    if (sub < 500000)
                {


                    if (sub >= 1 && sub <= 59)
                    {
                            
                            des = 0.00;
                        total = sub;
                            textBox2.Text = des.ToString();
                            textBox1.Text = total.ToString();

                    }
                    else if (sub >= 60 && sub <= 99)
                    {
                            
                            des = sub * 0.05;
                        total = sub - des;
                        textBox2.Text = des.ToString();
                        textBox1.Text = total.ToString();
                    }
                    else if (sub >= 100 && sub <= 500)
                    {
                        des = sub*0.10;
                        total = sub - des;
                            textBox2.Text = des.ToString();
                            textBox1.Text = total.ToString();
                    }else if (sub > 500)
                        {
                            des = sub * 0.10;
                            total = sub - des;
                            textBox2.Text = des.ToString();
                            textBox1.Text = total.ToString();
                        }
                }
                else
                {
                    MessageBox.Show("Rango de 100 a 500000");
                    maskedTextBox1.Text = "";
                    maskedTextBox1.Focus();
                }

            }else if(checkBox1.Checked == false)
            {
                if (sub<500000)
                {
                        des = 0.00;
                        total = sub;
                        textBox2.Text = des.ToString();
                        textBox1.Text = total.ToString();
 
                }
                else
                {
                    MessageBox.Show("Rango de 100 a 500000");
                    maskedTextBox1.Text = "";
                    maskedTextBox1.Focus();
                }
                }
                

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;

        }
    }
}
