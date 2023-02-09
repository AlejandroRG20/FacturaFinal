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
    public partial class MDI : Form
    {
        Form1 a=new Form1();
        Form2 b=new Form2();
        Form3 c=new Form3();
        Venta d = new Venta();
        Factura ee =new Factura();
        Depreciacion f=new Depreciacion();

        public MDI()
        {

            InitializeComponent();
            IsMdiContainer = true;
        }

        private void prestamoBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a.MdiParent = this;
            a.Show();
        }

        private void calculoDeDepreciacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b.MdiParent = this;
            b.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.MdiParent = this;
            c.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d.MdiParent = this;
            d.Show();
        }

        private void facturaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ee.MdiParent = this;
            ee.Show();
        }

        private void depreciacion2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.MdiParent = this;
            f.Show();
        }
    }
}
