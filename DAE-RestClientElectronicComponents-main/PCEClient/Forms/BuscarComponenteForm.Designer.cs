namespace PCEClient.Forms
{
    partial class BuscarComponenteForm
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
            this.lblDetPinCount     = new System.Windows.Forms.Label();
            this.lblDetPackageType  = new System.Windows.Forms.Label();
            this.lblDetVoltage      = new System.Windows.Forms.Label();
            this.lblDetTolerance    = new System.Windows.Forms.Label();
            this.lblDetNominalValue = new System.Windows.Forms.Label();
            this.lblDetCreatedAt    = new System.Windows.Forms.Label();
            this.grpFabricante      = new System.Windows.Forms.GroupBox();
            this.lblDetManufacturer = new System.Windows.Forms.Label();
            this.lblDetCountry      = new System.Windows.Forms.Label();
            this.lblDetLeadTime     = new System.Windows.Forms.Label();
            this.grpDetalles.SuspendLayout();
            this.grpFabricante.SuspendLayout();
            this.SuspendLayout();

            // ── Buscar ────────────────────────────────────────────────────
            this.lblId.AutoSize = true; this.lblId.Location = new System.Drawing.Point(20, 20); this.lblId.Text = "ID:";
            this.txtId.Location = new System.Drawing.Point(50, 17); this.txtId.Name = "txtId"; this.txtId.Size = new System.Drawing.Size(100, 20);
            this.btnBuscar.Location = new System.Drawing.Point(165, 15); this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 25); this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // ── grpDetalles ───────────────────────────────────────────────
            this.grpDetalles.Controls.Add(this.lblDetId);
            this.grpDetalles.Controls.Add(this.lblDetPinCount);
            this.grpDetalles.Controls.Add(this.lblDetPackageType);
            this.grpDetalles.Controls.Add(this.lblDetVoltage);
            this.grpDetalles.Controls.Add(this.lblDetTolerance);
            this.grpDetalles.Controls.Add(this.lblDetNominalValue);
            this.grpDetalles.Controls.Add(this.lblDetCreatedAt);
            this.grpDetalles.Location = new System.Drawing.Point(20, 55);
            this.grpDetalles.Name     = "grpDetalles";
            this.grpDetalles.Size     = new System.Drawing.Size(370, 210);
            this.grpDetalles.Text     = "Detalles del Componente";

            this.lblDetId.AutoSize           = true; this.lblDetId.Location           = new System.Drawing.Point(15, 25);  this.lblDetId.Text           = "ID:";
            this.lblDetPinCount.AutoSize     = true; this.lblDetPinCount.Location     = new System.Drawing.Point(15, 50);  this.lblDetPinCount.Text     = "Núm. de pines:";
            this.lblDetPackageType.AutoSize  = true; this.lblDetPackageType.Location  = new System.Drawing.Point(15, 75);  this.lblDetPackageType.Text  = "Encapsulado:";
            this.lblDetVoltage.AutoSize      = true; this.lblDetVoltage.Location      = new System.Drawing.Point(15, 100); this.lblDetVoltage.Text      = "Voltaje:";
            this.lblDetTolerance.AutoSize    = true; this.lblDetTolerance.Location    = new System.Drawing.Point(15, 125); this.lblDetTolerance.Text    = "Tolerancia:";
            this.lblDetNominalValue.AutoSize = true; this.lblDetNominalValue.Location = new System.Drawing.Point(15, 150); this.lblDetNominalValue.Text = "Valor nominal:";
            this.lblDetCreatedAt.AutoSize    = true; this.lblDetCreatedAt.Location    = new System.Drawing.Point(15, 175); this.lblDetCreatedAt.Text    = "Creado:";

            // ── grpFabricante ─────────────────────────────────────────────
            this.grpFabricante.Controls.Add(this.lblDetManufacturer);
            this.grpFabricante.Controls.Add(this.lblDetCountry);
            this.grpFabricante.Controls.Add(this.lblDetLeadTime);
            this.grpFabricante.Location = new System.Drawing.Point(20, 275);
            this.grpFabricante.Name     = "grpFabricante";
            this.grpFabricante.Size     = new System.Drawing.Size(370, 105);
            this.grpFabricante.Text     = "Fabricante";

            this.lblDetManufacturer.AutoSize = true; this.lblDetManufacturer.Location = new System.Drawing.Point(15, 25); this.lblDetManufacturer.Text = "Fabricante:";
            this.lblDetCountry.AutoSize      = true; this.lblDetCountry.Location      = new System.Drawing.Point(15, 50); this.lblDetCountry.Text      = "País:";
            this.lblDetLeadTime.AutoSize     = true; this.lblDetLeadTime.Location     = new System.Drawing.Point(15, 75); this.lblDetLeadTime.Text     = "T. de entrega:";

            // ── BuscarComponenteForm ──────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(415, 400);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grpDetalles);
            this.Controls.Add(this.grpFabricante);
            this.Name = "BuscarComponenteForm";
            this.Text = "Buscar Componente por ID";
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            this.grpFabricante.ResumeLayout(false);
            this.grpFabricante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label    lblId;
        private System.Windows.Forms.TextBox  txtId;
        private System.Windows.Forms.Button   btnBuscar;
        private System.Windows.Forms.GroupBox grpDetalles;
        private System.Windows.Forms.Label    lblDetId;
        private System.Windows.Forms.Label    lblDetPinCount;
        private System.Windows.Forms.Label    lblDetPackageType;
        private System.Windows.Forms.Label    lblDetVoltage;
        private System.Windows.Forms.Label    lblDetTolerance;
        private System.Windows.Forms.Label    lblDetNominalValue;
        private System.Windows.Forms.Label    lblDetCreatedAt;
        private System.Windows.Forms.GroupBox grpFabricante;
        private System.Windows.Forms.Label    lblDetManufacturer;
        private System.Windows.Forms.Label    lblDetCountry;
        private System.Windows.Forms.Label    lblDetLeadTime;
    }
}
