namespace PCEClient.Forms
{
    partial class BuscarFabricanteForm
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
            this.lblId              = new System.Windows.Forms.Label();
            this.txtId              = new System.Windows.Forms.TextBox();
            this.btnBuscar          = new System.Windows.Forms.Button();
            this.grpDetalles        = new System.Windows.Forms.GroupBox();
            this.lblDetId           = new System.Windows.Forms.Label();
            this.lblDetName         = new System.Windows.Forms.Label();
            this.lblDetCountry      = new System.Windows.Forms.Label();
            this.lblDetLeadTime     = new System.Windows.Forms.Label();
            this.lblDetCreatedAt    = new System.Windows.Forms.Label();
            this.grpDetalles.SuspendLayout();
            this.SuspendLayout();

            // ── Buscar ────────────────────────────────────────────────────
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 20);
            this.lblId.Text     = "ID:";
            this.txtId.Location = new System.Drawing.Point(50, 17);
            this.txtId.Name     = "txtId";
            this.txtId.Size     = new System.Drawing.Size(100, 20);
            this.btnBuscar.Location = new System.Drawing.Point(165, 15);
            this.btnBuscar.Name     = "btnBuscar";
            this.btnBuscar.Size     = new System.Drawing.Size(100, 25);
            this.btnBuscar.Text     = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // ── grpDetalles ───────────────────────────────────────────────
            this.grpDetalles.Controls.Add(this.lblDetId);
            this.grpDetalles.Controls.Add(this.lblDetName);
            this.grpDetalles.Controls.Add(this.lblDetCountry);
            this.grpDetalles.Controls.Add(this.lblDetLeadTime);
            this.grpDetalles.Controls.Add(this.lblDetCreatedAt);
            this.grpDetalles.Location = new System.Drawing.Point(20, 55);
            this.grpDetalles.Name     = "grpDetalles";
            this.grpDetalles.Size     = new System.Drawing.Size(370, 165);
            this.grpDetalles.Text     = "Detalles del Fabricante";

            this.lblDetId.AutoSize        = true; this.lblDetId.Location        = new System.Drawing.Point(15, 25);  this.lblDetId.Text        = "ID:";
            this.lblDetName.AutoSize      = true; this.lblDetName.Location      = new System.Drawing.Point(15, 53);  this.lblDetName.Text      = "Nombre:";
            this.lblDetCountry.AutoSize   = true; this.lblDetCountry.Location   = new System.Drawing.Point(15, 81);  this.lblDetCountry.Text   = "País:";
            this.lblDetLeadTime.AutoSize  = true; this.lblDetLeadTime.Location  = new System.Drawing.Point(15, 109); this.lblDetLeadTime.Text  = "T. de entrega:";
            this.lblDetCreatedAt.AutoSize = true; this.lblDetCreatedAt.Location = new System.Drawing.Point(15, 137); this.lblDetCreatedAt.Text = "Creado:";

            // ── BuscarFabricanteForm ──────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(415, 240);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grpDetalles);
            this.Name = "BuscarFabricanteForm";
            this.Text = "Buscar Fabricante por ID";
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label    lblId;
        private System.Windows.Forms.TextBox  txtId;
        private System.Windows.Forms.Button   btnBuscar;
        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.Label    lblDetId;
        private System.Windows.Forms.Label    lblDetName;
        private System.Windows.Forms.Label    lblDetCountry;
        private System.Windows.Forms.Label    lblDetLeadTime;
        private System.Windows.Forms.Label    lblDetCreatedAt;
    }
}
