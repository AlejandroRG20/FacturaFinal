namespace Alejandro
{
    partial class MDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mMMMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDeDepreciacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depreciacion2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMMMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mMMMToolStripMenuItem
            // 
            this.mMMMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamoBancoToolStripMenuItem,
            this.calculoDeDepreciacionToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.ventaToolStripMenuItem,
            this.facturaProductoToolStripMenuItem,
            this.depreciacion2ToolStripMenuItem});
            this.mMMMToolStripMenuItem.Name = "mMMMToolStripMenuItem";
            this.mMMMToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.mMMMToolStripMenuItem.Text = "CALCULOS";
            // 
            // prestamoBancoToolStripMenuItem
            // 
            this.prestamoBancoToolStripMenuItem.Name = "prestamoBancoToolStripMenuItem";
            this.prestamoBancoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.prestamoBancoToolStripMenuItem.Text = "Prestamo Banco";
            this.prestamoBancoToolStripMenuItem.Click += new System.EventHandler(this.prestamoBancoToolStripMenuItem_Click);
            // 
            // calculoDeDepreciacionToolStripMenuItem
            // 
            this.calculoDeDepreciacionToolStripMenuItem.Name = "calculoDeDepreciacionToolStripMenuItem";
            this.calculoDeDepreciacionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.calculoDeDepreciacionToolStripMenuItem.Text = "Calculo de Depreciacion";
            this.calculoDeDepreciacionToolStripMenuItem.Click += new System.EventHandler(this.calculoDeDepreciacionToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ventaToolStripMenuItem.Text = "Venta";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // facturaProductoToolStripMenuItem
            // 
            this.facturaProductoToolStripMenuItem.Name = "facturaProductoToolStripMenuItem";
            this.facturaProductoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.facturaProductoToolStripMenuItem.Text = "Factura Producto";
            this.facturaProductoToolStripMenuItem.Click += new System.EventHandler(this.facturaProductoToolStripMenuItem_Click);
            // 
            // depreciacion2ToolStripMenuItem
            // 
            this.depreciacion2ToolStripMenuItem.Name = "depreciacion2ToolStripMenuItem";
            this.depreciacion2ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.depreciacion2ToolStripMenuItem.Text = "Depreciacion 2";
            this.depreciacion2ToolStripMenuItem.Click += new System.EventHandler(this.depreciacion2ToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mMMMToolStripMenuItem;
        private ToolStripMenuItem prestamoBancoToolStripMenuItem;
        private ToolStripMenuItem calculoDeDepreciacionToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem ventaToolStripMenuItem;
        private ToolStripMenuItem facturaProductoToolStripMenuItem;
        private ToolStripMenuItem depreciacion2ToolStripMenuItem;
    }
}