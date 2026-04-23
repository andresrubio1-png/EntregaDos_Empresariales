namespace PCEClient.Forms
{
    partial class CrearComponenteForm
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
            // Fabricante
            this.grpFabricante      = new System.Windows.Forms.GroupBox();
            this.dgvFabricantes     = new System.Windows.Forms.DataGridView();
            this.colFabId           = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFabName         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFabCountry      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFabLeadTime     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFabSeleccionado = new System.Windows.Forms.Label();
            this.btnRefrescarFab    = new System.Windows.Forms.Button();
            // Componente
            this.grpComponente  = new System.Windows.Forms.GroupBox();
            this.lblPinCount    = new System.Windows.Forms.Label();
            this.txtPinCount    = new System.Windows.Forms.TextBox();
            this.lblPackageType = new System.Windows.Forms.Label();
            this.cboPackageType = new System.Windows.Forms.ComboBox();
            this.lblVoltage     = new System.Windows.Forms.Label();
            this.txtVoltage     = new System.Windows.Forms.TextBox();
            this.lblTolerance   = new System.Windows.Forms.Label();
            this.txtTolerance   = new System.Windows.Forms.TextBox();
            this.lblNominalValue = new System.Windows.Forms.Label();
            this.txtNominalValue = new System.Windows.Forms.TextBox();
            this.lblUnit        = new System.Windows.Forms.Label();
            this.txtUnit        = new System.Windows.Forms.TextBox();
            this.btnCrear       = new System.Windows.Forms.Button();

            this.grpFabricante.SuspendLayout();
            this.grpComponente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricantes)).BeginInit();
            this.SuspendLayout();

            // ── grpFabricante ──────────────────────────────────────────────
            this.grpFabricante.Controls.Add(this.dgvFabricantes);
            this.grpFabricante.Controls.Add(this.lblFabSeleccionado);
            this.grpFabricante.Controls.Add(this.btnRefrescarFab);
            this.grpFabricante.Location = new System.Drawing.Point(12, 12);
            this.grpFabricante.Name     = "grpFabricante";
            this.grpFabricante.Size     = new System.Drawing.Size(580, 210);
            this.grpFabricante.Text     = "Seleccionar Fabricante  (obligatorio)";

            // dgvFabricantes
            this.dgvFabricantes.AllowUserToAddRows    = false;
            this.dgvFabricantes.AllowUserToDeleteRows = false;
            this.dgvFabricantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabricantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colFabId, this.colFabName, this.colFabCountry, this.colFabLeadTime });
            this.dgvFabricantes.Location      = new System.Drawing.Point(10, 22);
            this.dgvFabricantes.Name          = "dgvFabricantes";
            this.dgvFabricantes.ReadOnly      = true;
            this.dgvFabricantes.Size          = new System.Drawing.Size(555, 130);
            this.dgvFabricantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFabricantes.MultiSelect   = false;
            this.dgvFabricantes.SelectionChanged += new System.EventHandler(this.dgvFabricantes_SelectionChanged);

            this.colFabId.HeaderText = "ID";       this.colFabId.Name   = "colFabId";   this.colFabId.Width   = 45;
            this.colFabName.HeaderText = "Nombre"; this.colFabName.Name = "colFabName"; this.colFabName.Width = 200;
            this.colFabCountry.HeaderText = "País"; this.colFabCountry.Name = "colFabCountry"; this.colFabCountry.Width = 100;
            this.colFabLeadTime.HeaderText = "T. de entrega (días)"; this.colFabLeadTime.Name = "colFabLeadTime"; this.colFabLeadTime.Width = 140;

            // lblFabSeleccionado
            this.lblFabSeleccionado.AutoSize  = true;
            this.lblFabSeleccionado.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFabSeleccionado.Location  = new System.Drawing.Point(10, 162);
            this.lblFabSeleccionado.Name      = "lblFabSeleccionado";
            this.lblFabSeleccionado.Text      = "Ninguno seleccionado";

            // btnRefrescarFab
            this.btnRefrescarFab.Location = new System.Drawing.Point(450, 158);
            this.btnRefrescarFab.Name     = "btnRefrescarFab";
            this.btnRefrescarFab.Size     = new System.Drawing.Size(115, 25);
            this.btnRefrescarFab.Text     = "↻ Refrescar";
            this.btnRefrescarFab.UseVisualStyleBackColor = true;
            this.btnRefrescarFab.Click   += new System.EventHandler(this.btnRefrescarFab_Click);

            // ── grpComponente ───────────────────────────────────────────────
            this.grpComponente.Controls.Add(this.lblPinCount);
            this.grpComponente.Controls.Add(this.txtPinCount);
            this.grpComponente.Controls.Add(this.lblPackageType);
            this.grpComponente.Controls.Add(this.cboPackageType);
            this.grpComponente.Controls.Add(this.lblVoltage);
            this.grpComponente.Controls.Add(this.txtVoltage);
            this.grpComponente.Controls.Add(this.lblTolerance);
            this.grpComponente.Controls.Add(this.txtTolerance);
            this.grpComponente.Controls.Add(this.lblNominalValue);
            this.grpComponente.Controls.Add(this.txtNominalValue);
            this.grpComponente.Controls.Add(this.lblUnit);
            this.grpComponente.Controls.Add(this.txtUnit);
            this.grpComponente.Location = new System.Drawing.Point(12, 232);
            this.grpComponente.Name     = "grpComponente";
            this.grpComponente.Size     = new System.Drawing.Size(580, 220);
            this.grpComponente.Text     = "Datos del Componente";

            // PinCount
            this.lblPinCount.AutoSize = true; this.lblPinCount.Location = new System.Drawing.Point(15, 25);  this.lblPinCount.Text = "Núm. de pines:";
            this.txtPinCount.Location = new System.Drawing.Point(170, 22); this.txtPinCount.Size = new System.Drawing.Size(370, 20); this.txtPinCount.Name = "txtPinCount";
            // PackageType
            this.lblPackageType.AutoSize = true; this.lblPackageType.Location = new System.Drawing.Point(15, 60); this.lblPackageType.Text = "Encapsulado:";
            this.cboPackageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackageType.Location = new System.Drawing.Point(170, 57); this.cboPackageType.Size = new System.Drawing.Size(370, 21); this.cboPackageType.Name = "cboPackageType";
            // Voltage
            this.lblVoltage.AutoSize = true; this.lblVoltage.Location = new System.Drawing.Point(15, 95); this.lblVoltage.Text = "Voltaje (V):";
            this.txtVoltage.Location = new System.Drawing.Point(170, 92); this.txtVoltage.Size = new System.Drawing.Size(370, 20); this.txtVoltage.Name = "txtVoltage";
            // Tolerance
            this.lblTolerance.AutoSize = true; this.lblTolerance.Location = new System.Drawing.Point(15, 130); this.lblTolerance.Text = "Tolerancia:";
            this.txtTolerance.Location = new System.Drawing.Point(170, 127); this.txtTolerance.Size = new System.Drawing.Size(370, 20); this.txtTolerance.Name = "txtTolerance";
            // NominalValue
            this.lblNominalValue.AutoSize = true; this.lblNominalValue.Location = new System.Drawing.Point(15, 165); this.lblNominalValue.Text = "Valor Nominal:";
            this.txtNominalValue.Location = new System.Drawing.Point(170, 162); this.txtNominalValue.Size = new System.Drawing.Size(200, 20); this.txtNominalValue.Name = "txtNominalValue";
            // Unit
            this.lblUnit.AutoSize = true; this.lblUnit.Location = new System.Drawing.Point(380, 165); this.lblUnit.Text = "Unidad:";
            this.txtUnit.Location = new System.Drawing.Point(430, 162); this.txtUnit.Size = new System.Drawing.Size(110, 20); this.txtUnit.Name = "txtUnit";

            // ── btnCrear ───────────────────────────────────────────────────
            this.btnCrear.Enabled  = false;
            this.btnCrear.Location = new System.Drawing.Point(12, 465);
            this.btnCrear.Name     = "btnCrear";
            this.btnCrear.Size     = new System.Drawing.Size(580, 35);
            this.btnCrear.Text     = "Crear Componente";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click   += new System.EventHandler(this.btnCrear_Click);

            // ── CrearComponenteForm ────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(606, 515);
            this.Controls.Add(this.grpFabricante);
            this.Controls.Add(this.grpComponente);
            this.Controls.Add(this.btnCrear);
            this.Name = "CrearComponenteForm";
            this.Text = "Crear Componente Pasivo";

            this.grpFabricante.ResumeLayout(false);
            this.grpFabricante.PerformLayout();
            this.grpComponente.ResumeLayout(false);
            this.grpComponente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricantes)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox              grpFabricante;
        private System.Windows.Forms.DataGridView          dgvFabricantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabLeadTime;
        private System.Windows.Forms.Label                 lblFabSeleccionado;
        private System.Windows.Forms.Button                btnRefrescarFab;
        private System.Windows.Forms.GroupBox              grpComponente;
        private System.Windows.Forms.Label                 lblPinCount;
        private System.Windows.Forms.TextBox               txtPinCount;
        private System.Windows.Forms.Label                 lblPackageType;
        private System.Windows.Forms.ComboBox              cboPackageType;
        private System.Windows.Forms.Label                 lblVoltage;
        private System.Windows.Forms.TextBox               txtVoltage;
        private System.Windows.Forms.Label                 lblTolerance;
        private System.Windows.Forms.TextBox               txtTolerance;
        private System.Windows.Forms.Label                 lblNominalValue;
        private System.Windows.Forms.TextBox               txtNominalValue;
        private System.Windows.Forms.Label                 lblUnit;
        private System.Windows.Forms.TextBox               txtUnit;
        private System.Windows.Forms.Button                btnCrear;
    }
}
