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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double va, dep, a;
            if (comboBox1.Text == "")
            {
                MessageBox.Show("No se aceptan mensajes en blanco");
                comboBox1.Focus();
            }
            else if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("No se aceptan mensajes en blanco");
                maskedTextBox1.Focus();
            }
            else
            {
                if (comboBox1.Text.Equals("Vehiculo"))
                {
                    a = 5;
                    va = double.Parse(maskedTextBox1.Text);
                    if (va >= 100 && va <= 100000)
                    {
                        dep = (va / a);
                        textBox1.Text = dep.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error, Rango de bien entre 100 y 10000");
                        maskedTextBox1.Text = "";
                        maskedTextBox1.Focus();
                    }
                }
                else if (comboBox1.Text.Equals("Edificio"))
                {
                    a = 20;
                    va = double.Parse(maskedTextBox1.Text);
                    if (va >= 100 && va <= 100000)
                    {
                        dep = (va / a);
                        textBox1.Text = dep.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error, Rango de bien entre 100 y 10000");
                        maskedTextBox1.Text = "";
                        maskedTextBox1.Focus();
                    }
                }
                else if (comboBox1.Text.Equals("Equipo de Oficina"))
                {
                    a = 2;
                    va = double.Parse(maskedTextBox1.Text);
                    if (va >= 100 && va <= 100000)
                    {
                        dep = (va / a);
                        textBox1.Text = dep.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error, Rango de bien entre 100 y 10000", "Error");
                        maskedTextBox1.Text = "";
                        maskedTextBox1.Focus();
                    }
                }
            }
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            maskedTextBox1.Text = "";
        }
    }
}
