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
    public partial class Depreciacion : Form
    {
        public Depreciacion()
        {
            InitializeComponent();
        }

        private void Depreciacion_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vidaU, dep, valor;

            




            if (listBox1.Text == "Linea Recta")
                {
                
                if (checkedListBox1.Text == "Vehiculos")
                    {
                    valor = double.Parse(maskedTextBox1.Text);
                    if (valor > 0 && valor <= 500000)
                    {

                        dep = (valor * (valor + 1)) / 2;
                        textBox1.Text = dep.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Rango del valor entre 1 a 500000");
                        maskedTextBox1.Text = "";
                        maskedTextBox1.Focus();
                    }
                    }
                    else if (checkedListBox1.Text == "Edificios")
                    {
                    valor = double.Parse(maskedTextBox1.Text);
                    if (valor > 0 && valor <= 500000)
                    {
                        dep = (valor * (valor + 1)) / 2;
                        textBox1.Text = dep.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Rango del valor entre 1 a 500000");
                        maskedTextBox1.Text = "";
                        maskedTextBox1.Focus();
                    }
                }
                    else if (checkedListBox1.Text == "Equipo de Oficina")
                    {
                    valor = double.Parse(maskedTextBox1.Text);
                    if (valor > 0 && valor <= 500000)
                    {
                        dep = (valor * (valor + 1)) / 2;
                        textBox1.Text = dep.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Rango del valor entre 1 a 500000");
                        maskedTextBox1.Text = "";
                        maskedTextBox1.Focus();
                    }
                }
                    else if (checkedListBox1.Text == "")
                    {
                        MessageBox.Show("Seleccione un tipo de bien");
                    }

                }
                else if (listBox1.Text == "Suma de Digitos")
                {
                    if (checkedListBox1.Text == "Vehiculos")
                    {

                    }
                    else if (checkedListBox1.Text == "Edificios")
                    {

                    }
                    else if (checkedListBox1.Text == "Equipo de Oficina")
                    {

                    }
                    else if (checkedListBox1.Text == "")
                    {
                        MessageBox.Show("Seleccione un tipo de bien");
                    }
                }
                else if (listBox1.Text == "")
                {
                    MessageBox.Show("Seleccione un Metodo");
                }


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            checkedListBox1.ClearSelected();
            listBox1.ClearSelected();



        }
    }
}
