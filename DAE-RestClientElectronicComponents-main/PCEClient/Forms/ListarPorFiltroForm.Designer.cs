namespace PCEClient.Forms
{
    partial class ListarPorFiltroForm
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
            this.rbPackageType = new System.Windows.Forms.RadioButton();
            this.rbVoltageRange = new System.Windows.Forms.RadioButton();
            this.cboPackageType = new System.Windows.Forms.ComboBox();
            this.lblMinVoltage = new System.Windows.Forms.Label();
            this.txtMinVoltage = new System.Windows.Forms.TextBox();
            this.lblMaxVoltage = new System.Windows.Forms.Label();
            this.txtMaxVoltage = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPinCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoltage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTolerance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNominalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // rbPackageType
            // 
            this.rbPackageType.AutoSize = true;
            this.rbPackageType.Checked = true;
            this.rbPackageType.Location = new System.Drawing.Point(20, 15);
            this.rbPackageType.Name = "rbPackageType";
            this.rbPackageType.Size = new System.Drawing.Size(114, 17);
            this.rbPackageType.TabIndex = 0;
            this.rbPackageType.TabStop = true;
            this.rbPackageType.Text = "Por Package Type";
            this.rbPackageType.CheckedChanged += new System.EventHandler(this.rbPackageType_CheckedChanged);
            // 
            // rbVoltageRange
            // 
            this.rbVoltageRange.AutoSize = true;
            this.rbVoltageRange.Location = new System.Drawing.Point(20, 45);
            this.rbVoltageRange.Name = "rbVoltageRange";
            this.rbVoltageRange.Size = new System.Drawing.Size(120, 17);
            this.rbVoltageRange.TabIndex = 2;
            this.rbVoltageRange.Text = "Por rango de voltaje";
            // 
            // cboPackageType
            // 
            this.cboPackageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackageType.Location = new System.Drawing.Point(150, 13);
            this.cboPackageType.Name = "cboPackageType";
            this.cboPackageType.Size = new System.Drawing.Size(120, 21);
            this.cboPackageType.TabIndex = 1;
            // 
            // lblMinVoltage
            // 
            this.lblMinVoltage.AutoSize = true;
            this.lblMinVoltage.Location = new System.Drawing.Point(150, 47);
            this.lblMinVoltage.Name = "lblMinVoltage";
            this.lblMinVoltage.Size = new System.Drawing.Size(27, 13);
            this.lblMinVoltage.TabIndex = 3;
            this.lblMinVoltage.Text = "Min:";
            // 
            // txtMinVoltage
            // 
            this.txtMinVoltage.Enabled = false;
            this.txtMinVoltage.Location = new System.Drawing.Point(185, 44);
            this.txtMinVoltage.Name = "txtMinVoltage";
            this.txtMinVoltage.Size = new System.Drawing.Size(70, 20);
            this.txtMinVoltage.TabIndex = 4;
            // 
            // lblMaxVoltage
            // 
            this.lblMaxVoltage.AutoSize = true;
            this.lblMaxVoltage.Location = new System.Drawing.Point(270, 47);
            this.lblMaxVoltage.Name = "lblMaxVoltage";
            this.lblMaxVoltage.Size = new System.Drawing.Size(30, 13);
            this.lblMaxVoltage.TabIndex = 5;
            this.lblMaxVoltage.Text = "Max:";
            // 
            // txtMaxVoltage
            // 
            this.txtMaxVoltage.Enabled = false;
            this.txtMaxVoltage.Location = new System.Drawing.Point(305, 44);
            this.txtMaxVoltage.Name = "txtMaxVoltage";
            this.txtMaxVoltage.Size = new System.Drawing.Size(70, 20);
            this.txtMaxVoltage.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(400, 13);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 50);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colPinCount,
            this.colPackageType,
            this.colVoltage,
            this.colTolerance,
            this.colNominalValue,
            this.colManufacturer,
            this.colCountry,
            this.colCreatedAt});
            this.dgvResultados.Location = new System.Drawing.Point(20, 95);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.Size = new System.Drawing.Size(857, 271);
            this.dgvResultados.TabIndex = 9;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(20, 75);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(72, 13);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "Resultados: 0";
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 45;
            // 
            // colPinCount
            // 
            this.colPinCount.HeaderText = "Núm. pines";
            this.colPinCount.Name = "colPinCount";
            this.colPinCount.ReadOnly = true;
            this.colPinCount.Width = 80;
            // 
            // colPackageType
            // 
            this.colPackageType.HeaderText = "Encapsulado";
            this.colPackageType.Name = "colPackageType";
            this.colPackageType.ReadOnly = true;
            this.colPackageType.Width = 85;
            // 
            // colVoltage
            // 
            this.colVoltage.HeaderText = "Voltaje";
            this.colVoltage.Name = "colVoltage";
            this.colVoltage.ReadOnly = true;
            this.colVoltage.Width = 65;
            // 
            // colTolerance
            // 
            this.colTolerance.HeaderText = "Tolerancia";
            this.colTolerance.Name = "colTolerance";
            this.colTolerance.ReadOnly = true;
            this.colTolerance.Width = 75;
            // 
            // colNominalValue
            // 
            this.colNominalValue.HeaderText = "Valor nominal";
            this.colNominalValue.Name = "colNominalValue";
            this.colNominalValue.ReadOnly = true;
            // 
            // colManufacturer
            // 
            this.colManufacturer.HeaderText = "Fabricante";
            this.colManufacturer.Name = "colManufacturer";
            this.colManufacturer.ReadOnly = true;
            this.colManufacturer.Width = 160;
            // 
            // colCountry
            // 
            this.colCountry.HeaderText = "País";
            this.colCountry.Name = "colCountry";
            this.colCountry.ReadOnly = true;
            this.colCountry.Width = 90;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.HeaderText = "Fecha creación";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.ReadOnly = true;
            this.colCreatedAt.Width = 140;
            // 
            // ListarPorFiltroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 386);
            this.Controls.Add(this.rbPackageType);
            this.Controls.Add(this.cboPackageType);
            this.Controls.Add(this.rbVoltageRange);
            this.Controls.Add(this.lblMinVoltage);
            this.Controls.Add(this.txtMinVoltage);
            this.Controls.Add(this.lblMaxVoltage);
            this.Controls.Add(this.txtMaxVoltage);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvResultados);
            this.Name = "ListarPorFiltroForm";
            this.Text = "Listar por Filtro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPackageType;
        private System.Windows.Forms.RadioButton rbVoltageRange;
        private System.Windows.Forms.ComboBox cboPackageType;
        private System.Windows.Forms.Label lblMinVoltage;
        private System.Windows.Forms.TextBox txtMinVoltage;
        private System.Windows.Forms.Label lblMaxVoltage;
        private System.Windows.Forms.TextBox txtMaxVoltage;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPinCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackageType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoltage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTolerance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNominalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
    }
}
