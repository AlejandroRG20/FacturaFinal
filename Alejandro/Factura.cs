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
    public partial class Factura : Form
    {
        
        public Factura()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Nombre;
            double precio, cantidad, subtp;
            if (textBox4.Text == "")
            {
                MessageBox.Show("No se aceptan espacios, digite un Nombre");
                textBox4.Focus();
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("No se aceptan espacios, digite un producto");
                comboBox1.Focus();
            }
            else  if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("No se aceptan espacios, digite el precio");
                maskedTextBox1.Focus();
            }
            else if (maskedTextBox2.Text == "")
            {
                MessageBox.Show("No se aceptan espacios, digite la cantidad");
                maskedTextBox2.Focus();
            }
            else if((maskedTextBox1.Text == ""&& maskedTextBox2.Text == "")&& comboBox1.Text == "")
            {
                MessageBox.Show("No se aceptan espacios, digite los datos");
                comboBox1.Focus();
            }
            else
            {
                Nombre = Convert.ToString(textBox4.Text);
                precio = Convert.ToDouble(maskedTextBox1.Text);
                cantidad = Convert.ToDouble(maskedTextBox2.Text);
                subtp = precio * cantidad;
                textBox1.Text = subtp.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("No se puede agregar sin antes cacular el sub total");
            }
            else
            {
                double stf = 0;
                int i = 0;
                double tf, n = 0;
                for(n=0; n< dataGridView1.Rows.Count-1; n++)
                {
                    
                }
             
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = n+1;
                row.Cells[1].Value = textBox4.Text;
                row.Cells[2].Value = comboBox1.Text;
                row.Cells[3].Value = maskedTextBox1.Text;
                row.Cells[4].Value = maskedTextBox2.Text;
                row.Cells[5].Value = textBox1.Text;

                dataGridView1.Rows.Add(row);

                

                for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    stf = stf + Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                   
                }
                tf = stf * 1.15;
                textBox2.Text = stf.ToString();
                textBox3.Text = tf.ToString();
                
                comboBox1.Text = "";
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
                textBox4.Text = "";
                textBox1.Text = "";
                textBox4.Focus();
            }

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            comboBox1.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox4.Focus();



        }
    }
}
