namespace PCEClient.Forms
{
    partial class ActualizarComponenteForm
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
            // Buscar
            this.lblId    = new System.Windows.Forms.Label();
            this.txtId    = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            // Fabricante
            this.grpFabricante      = new System.Windows.Forms.GroupBox();
            this.dgvFabricantes     = new System.Windows.Forms.DataGridView();
            this.colFabId           = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFabName         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFabCountry      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFabLeadTime     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFabSeleccionado = new System.Windows.Forms.Label();
            // Componente
            this.grpDatos        = new System.Windows.Forms.GroupBox();
            this.lblPinCount     = new System.Windows.Forms.Label();
            this.txtPinCount     = new System.Windows.Forms.TextBox();
            this.lblPackageType  = new System.Windows.Forms.Label();
            this.cboPackageType  = new System.Windows.Forms.ComboBox();
            this.lblVoltage      = new System.Windows.Forms.Label();
            this.txtVoltage      = new System.Windows.Forms.TextBox();
            this.lblTolerance    = new System.Windows.Forms.Label();
            this.txtTolerance    = new System.Windows.Forms.TextBox();
            this.lblNominalValue = new System.Windows.Forms.Label();
            this.txtNominalValue = new System.Windows.Forms.TextBox();
            this.lblUnit         = new System.Windows.Forms.Label();
            this.txtUnit         = new System.Windows.Forms.TextBox();
            this.btnActualizar   = new System.Windows.Forms.Button();

            this.grpFabricante.SuspendLayout();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricantes)).BeginInit();
            this.SuspendLayout();

            // ── Buscar ────────────────────────────────────────────────────
            this.lblId.AutoSize = true; this.lblId.Location = new System.Drawing.Point(12, 18); this.lblId.Text = "ID del componente:";
            this.txtId.Location = new System.Drawing.Point(135, 15); this.txtId.Size = new System.Drawing.Size(100, 20); this.txtId.Name = "txtId";
            this.btnBuscar.Location = new System.Drawing.Point(250, 13); this.btnBuscar.Size = new System.Drawing.Size(100, 25);
            this.btnBuscar.Text = "Buscar"; this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // ── grpFabricante ────────────────────────────────────────────
            this.grpFabricante.Controls.Add(this.dgvFabricantes);
            this.grpFabricante.Controls.Add(this.lblFabSeleccionado);
            this.grpFabricante.Location = new System.Drawing.Point(12, 48);
            this.grpFabricante.Name     = "grpFabricante";
            this.grpFabricante.Size     = new System.Drawing.Size(580, 170);
            this.grpFabricante.Text     = "Seleccionar Fabricante";

            this.dgvFabricantes.AllowUserToAddRows    = false;
            this.dgvFabricantes.AllowUserToDeleteRows = false;
            this.dgvFabricantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabricantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colFabId, this.colFabName, this.colFabCountry, this.colFabLeadTime });
            this.dgvFabricantes.Location      = new System.Drawing.Point(10, 22);
            this.dgvFabricantes.Name          = "dgvFabricantes";
            this.dgvFabricantes.ReadOnly      = true;
            this.dgvFabricantes.Size          = new System.Drawing.Size(555, 110);
            this.dgvFabricantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFabricantes.MultiSelect   = false;
            this.dgvFabricantes.SelectionChanged += new System.EventHandler(this.dgvFabricantes_SelectionChanged);

            this.colFabId.HeaderText = "ID";       this.colFabId.Name   = "colFabId";   this.colFabId.Width   = 45;
            this.colFabName.HeaderText = "Nombre"; this.colFabName.Name = "colFabName"; this.colFabName.Width = 200;
            this.colFabCountry.HeaderText = "País"; this.colFabCountry.Name = "colFabCountry"; this.colFabCountry.Width = 100;
            this.colFabLeadTime.HeaderText = "T. de entrega (días)"; this.colFabLeadTime.Name = "colFabLeadTime"; this.colFabLeadTime.Width = 140;

            this.lblFabSeleccionado.AutoSize  = true;
            this.lblFabSeleccionado.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFabSeleccionado.Location  = new System.Drawing.Point(10, 144);
            this.lblFabSeleccionado.Name      = "lblFabSeleccionado";
            this.lblFabSeleccionado.Text      = "Ninguno seleccionado";

            // ── grpDatos ─────────────────────────────────────────────────
            this.grpDatos.Controls.Add(this.lblPinCount);
            this.grpDatos.Controls.Add(this.txtPinCount);
            this.grpDatos.Controls.Add(this.lblPackageType);
            this.grpDatos.Controls.Add(this.cboPackageType);
            this.grpDatos.Controls.Add(this.lblVoltage);
            this.grpDatos.Controls.Add(this.txtVoltage);
            this.grpDatos.Controls.Add(this.lblTolerance);
            this.grpDatos.Controls.Add(this.txtTolerance);
            this.grpDatos.Controls.Add(this.lblNominalValue);
            this.grpDatos.Controls.Add(this.txtNominalValue);
            this.grpDatos.Controls.Add(this.lblUnit);
            this.grpDatos.Controls.Add(this.txtUnit);
            this.grpDatos.Location = new System.Drawing.Point(12, 228);
            this.grpDatos.Name     = "grpDatos";
            this.grpDatos.Size     = new System.Drawing.Size(580, 220);
            this.grpDatos.Text     = "Datos del Componente";

            this.lblPinCount.AutoSize = true; this.lblPinCount.Location = new System.Drawing.Point(15, 25);  this.lblPinCount.Text = "Núm. de pines:";
            this.txtPinCount.Location = new System.Drawing.Point(170, 22); this.txtPinCount.Size = new System.Drawing.Size(370, 20); this.txtPinCount.Name = "txtPinCount";
            this.lblPackageType.AutoSize = true; this.lblPackageType.Location = new System.Drawing.Point(15, 60); this.lblPackageType.Text = "Encapsulado:";
            this.cboPackageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackageType.Location = new System.Drawing.Point(170, 57); this.cboPackageType.Size = new System.Drawing.Size(370, 21); this.cboPackageType.Name = "cboPackageType";
            this.lblVoltage.AutoSize = true; this.lblVoltage.Location = new System.Drawing.Point(15, 95); this.lblVoltage.Text = "Voltaje (V):";
            this.txtVoltage.Location = new System.Drawing.Point(170, 92); this.txtVoltage.Size = new System.Drawing.Size(370, 20); this.txtVoltage.Name = "txtVoltage";
            this.lblTolerance.AutoSize = true; this.lblTolerance.Location = new System.Drawing.Point(15, 130); this.lblTolerance.Text = "Tolerancia:";
            this.txtTolerance.Location = new System.Drawing.Point(170, 127); this.txtTolerance.Size = new System.Drawing.Size(370, 20); this.txtTolerance.Name = "txtTolerance";
            this.lblNominalValue.AutoSize = true; this.lblNominalValue.Location = new System.Drawing.Point(15, 165); this.lblNominalValue.Text = "Valor Nominal:";
            this.txtNominalValue.Location = new System.Drawing.Point(170, 162); this.txtNominalValue.Size = new System.Drawing.Size(200, 20); this.txtNominalValue.Name = "txtNominalValue";
            this.lblUnit.AutoSize = true; this.lblUnit.Location = new System.Drawing.Point(380, 165); this.lblUnit.Text = "Unidad:";
            this.txtUnit.Location = new System.Drawing.Point(430, 162); this.txtUnit.Size = new System.Drawing.Size(110, 20); this.txtUnit.Name = "txtUnit";

            // ── btnActualizar ─────────────────────────────────────────────
            this.btnActualizar.Location = new System.Drawing.Point(12, 460);
            this.btnActualizar.Name     = "btnActualizar";
            this.btnActualizar.Size     = new System.Drawing.Size(580, 35);
            this.btnActualizar.Text     = "Actualizar Componente";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click   += new System.EventHandler(this.btnActualizar_Click);

            // ── ActualizarComponenteForm ──────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(606, 510);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grpFabricante);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnActualizar);
            this.Name = "ActualizarComponenteForm";
            this.Text = "Actualizar Componente";

            this.grpFabricante.ResumeLayout(false);
            this.grpFabricante.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label   lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button  btnBuscar;
        private System.Windows.Forms.GroupBox grpFabricante;
        private System.Windows.Forms.DataGridView dgvFabricantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabLeadTime;
        private System.Windows.Forms.Label   lblFabSeleccionado;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label   lblPinCount;
        private System.Windows.Forms.TextBox txtPinCount;
        private System.Windows.Forms.Label   lblPackageType;
        private System.Windows.Forms.ComboBox cboPackageType;
        private System.Windows.Forms.Label   lblVoltage;
        private System.Windows.Forms.TextBox txtVoltage;
        private System.Windows.Forms.Label   lblTolerance;
        private System.Windows.Forms.TextBox txtTolerance;
        private System.Windows.Forms.Label   lblNominalValue;
        private System.Windows.Forms.TextBox txtNominalValue;
        private System.Windows.Forms.Label   lblUnit;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Button  btnActualizar;
    }
}
