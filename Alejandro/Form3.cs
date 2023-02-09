using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Alejandro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox1.Focus();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double iva, Stotal,total;
            if(maskedTextBox1.Text == "") {
                MessageBox.Show("Error, No se aceptan espacios");
                maskedTextBox1.Focus();

            }
            else
            {
                Stotal = double.Parse(maskedTextBox1.Text);
                if (Stotal >= 100 || Stotal <= 500000)
                {
                    iva = (Stotal * 0.15);
                    total = Stotal + iva;
                    textBox1.Text = iva.ToString();
                    textBox2.Text = total.ToString();
                }
            }

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            double mp, vuel, des,total,iva,Stotal,tf;

            if(maskedTextBox2.Text == ""){
                MessageBox.Show("Error, No se aceptan espacios Blancos");
                maskedTextBox2.Focus();
            }
            else
            {
                mp = double.Parse(maskedTextBox2.Text);
                Stotal = double.Parse(maskedTextBox1.Text);
                iva = (Stotal * 0.15);
                total = Stotal + iva;
                if (mp >= total)
                {
                    if (radioButton1.Checked==true&& radioButton2.Checked == false)
                    {
                   
                        if (mp >= 100 || mp <= 25)
                        {
                            Stotal = double.Parse(maskedTextBox1.Text);
                            iva = (Stotal * 0.15);
                            total = Stotal + iva;
                            des = total * 0.02;
                            tf = total - des;
                            vuel = mp - tf;
                            textBox3.Text = des.ToString();
                            textBox4.Text = vuel.ToString();
                        }
                        else if (mp >= 26 || mp <= 60)
                        {
                            Stotal = double.Parse(maskedTextBox1.Text);
                            iva = (Stotal * 0.15);
                            total = Stotal + iva;
                            des = total * 0.04;
                            tf = total - des;
                            vuel = mp - tf;
                            textBox3.Text = des.ToString();
                            textBox4.Text = vuel.ToString();
                        }
                        else if (mp > 60)
                        {
                            Stotal = double.Parse(maskedTextBox1.Text);
                            iva = (Stotal * 0.15);
                            total = Stotal + iva;
                            des = total * 0.07;
                            tf = total - des;
                            vuel = mp - tf;
                            textBox3.Text = des.ToString();
                            textBox4.Text = vuel.ToString();
                        }

                    }else if (radioButton1.Checked == false && radioButton2.Checked == true)
                        {
                            Stotal = double.Parse(maskedTextBox1.Text);
                            iva = (Stotal * 0.15);
                            total = Stotal + iva;
                            des = total * 0.05;
                            tf = total - des;
                            vuel = mp - tf;
                            textBox3.Text = des.ToString();
                            textBox4.Text = vuel.ToString();
                        } else if (radioButton1.Checked == false && radioButton2.Checked == false)
                        {
                            MessageBox.Show("Error, Seleccione una opcion Buttons");
                    }
                    else if (radioButton1.Checked == true && radioButton2.Checked == true)
                    {
                        MessageBox.Show("Error, no se pudo seleccionar una opcion valida");
                    }
                }
                else if(mp<total)
                {

                    MessageBox.Show("Error, el monto  no puede ser menor al  total a pagar");
                    maskedTextBox2.Text = "";
                    maskedTextBox2.Focus();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
