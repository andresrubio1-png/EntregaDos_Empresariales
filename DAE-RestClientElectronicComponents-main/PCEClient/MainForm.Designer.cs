namespace PCEClient
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            // Archivo
            this.archivoToolStripMenuItem  = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem   = new System.Windows.Forms.ToolStripMenuItem();
            // Fabricante
            this.fabricanteToolStripMenuItem          = new System.Windows.Forms.ToolStripMenuItem();
            this.crearFabricanteToolStripMenuItem     = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFabricanteToolStripMenuItem    = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarFabricanteToolStripMenuItem  = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarFabricanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFabricantesToolStripMenuItem   = new System.Windows.Forms.ToolStripMenuItem();
            // Componente Pasivo
            this.componentePasivoToolStripMenuItem  = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem             = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem            = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem          = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem        = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem            = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPorFiltroToolStripMenuItem   = new System.Windows.Forms.ToolStripMenuItem();
            // Ayuda
            this.ayudaToolStripMenuItem    = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.menuStrip.SuspendLayout();
            this.SuspendLayout();

            // menuStrip
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.archivoToolStripMenuItem,
                this.fabricanteToolStripMenuItem,
                this.componentePasivoToolStripMenuItem,
                this.ayudaToolStripMenuItem });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name     = "menuStrip";
            this.menuStrip.Size     = new System.Drawing.Size(1100, 24);
            this.menuStrip.Text     = "menuStrip";

            // Archivo
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.cerrarToolStripMenuItem });
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.cerrarToolStripMenuItem.Name  = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Text  = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);

            // Fabricante
            this.fabricanteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.crearFabricanteToolStripMenuItem,
                this.buscarFabricanteToolStripMenuItem,
                this.eliminarFabricanteToolStripMenuItem,
                this.actualizarFabricanteToolStripMenuItem,
                this.listarFabricantesToolStripMenuItem });
            this.fabricanteToolStripMenuItem.Name = "fabricanteToolStripMenuItem";
            this.fabricanteToolStripMenuItem.Text = "Fabricante";
            this.crearFabricanteToolStripMenuItem.Name   = "crearFabricanteToolStripMenuItem";
            this.crearFabricanteToolStripMenuItem.Text   = "Crear";
            this.crearFabricanteToolStripMenuItem.Click += new System.EventHandler(this.crearFabricanteToolStripMenuItem_Click);
            this.buscarFabricanteToolStripMenuItem.Name   = "buscarFabricanteToolStripMenuItem";
            this.buscarFabricanteToolStripMenuItem.Text   = "Buscar";
            this.buscarFabricanteToolStripMenuItem.Click += new System.EventHandler(this.buscarFabricanteToolStripMenuItem_Click);
            this.eliminarFabricanteToolStripMenuItem.Name   = "eliminarFabricanteToolStripMenuItem";
            this.eliminarFabricanteToolStripMenuItem.Text   = "Eliminar";
            this.eliminarFabricanteToolStripMenuItem.Click += new System.EventHandler(this.eliminarFabricanteToolStripMenuItem_Click);
            this.actualizarFabricanteToolStripMenuItem.Name   = "actualizarFabricanteToolStripMenuItem";
            this.actualizarFabricanteToolStripMenuItem.Text   = "Actualizar";
            this.actualizarFabricanteToolStripMenuItem.Click += new System.EventHandler(this.actualizarFabricanteToolStripMenuItem_Click);
            this.listarFabricantesToolStripMenuItem.Name   = "listarFabricantesToolStripMenuItem";
            this.listarFabricantesToolStripMenuItem.Text   = "Listar";
            this.listarFabricantesToolStripMenuItem.Click += new System.EventHandler(this.listarFabricantesToolStripMenuItem_Click);

            // Componente Pasivo
            this.componentePasivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.crearToolStripMenuItem,
                this.buscarToolStripMenuItem,
                this.eliminarToolStripMenuItem,
                this.actualizarToolStripMenuItem,
                this.listarToolStripMenuItem,
                this.listarPorFiltroToolStripMenuItem });
            this.componentePasivoToolStripMenuItem.Name = "componentePasivoToolStripMenuItem";
            this.componentePasivoToolStripMenuItem.Text = "Componente Pasivo";
            this.crearToolStripMenuItem.Name   = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Text   = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            this.buscarToolStripMenuItem.Name   = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Text   = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            this.eliminarToolStripMenuItem.Name   = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Text   = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            this.actualizarToolStripMenuItem.Name   = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Text   = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            this.listarToolStripMenuItem.Name   = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Text   = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            this.listarPorFiltroToolStripMenuItem.Name   = "listarPorFiltroToolStripMenuItem";
            this.listarPorFiltroToolStripMenuItem.Text   = "Listar (por filtro)";
            this.listarPorFiltroToolStripMenuItem.Click += new System.EventHandler(this.listarPorFiltroToolStripMenuItem_Click);

            // Ayuda
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.acercaDeToolStripMenuItem });
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.acercaDeToolStripMenuItem.Name   = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Text   = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip       = this.menuStrip;
            this.Name                = "MainForm";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "PCE Client - Componentes Electrónicos";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip        menuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearFabricanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarFabricanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarFabricanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarFabricanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarFabricantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentePasivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPorFiltroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}
