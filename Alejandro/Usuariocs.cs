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
    public partial class Usuariocs : Form
    {
        public Usuariocs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { int x= 0;
            string U, C;

            U=Convert.ToString(textBox1.Text);
            C=Convert.ToString(textBox2.Text);
            
                if (U == "" && C == "")
                {
                    MessageBox.Show("No se puede acceder sin los datos");
                    textBox1.Focus();

                }
                else if (U == "")
                {
                    MessageBox.Show("Ingrese un nombre de usuario ");
                    textBox1.Focus();
                }
                else if (C == "")
                {
                    MessageBox.Show("Ingrese una contraseña");
                    textBox2.Focus();

                }
                else if (U != "AlejandroRG20" && C != "Pan con atun")
                {
                    MessageBox.Show("Usuario y contraseña incorrectos");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                }
                else if (U != "AlejandroRG20")
                {
                    MessageBox.Show("Usuariuo incorrecto");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else if (C != "Pan con atun")
                {
                    MessageBox.Show("Contraseña incorrecta ");
                    textBox2.Text = "";
                    textBox2.Focus();
                }
                else
                {
                    MDI R = new MDI();
                    R.Show();
                }
              
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuariocs_Load(object sender, EventArgs e)
        {

        }
    }
}
