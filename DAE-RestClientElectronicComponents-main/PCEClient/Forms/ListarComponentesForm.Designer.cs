namespace PCEClient.Forms
{
    partial class ListarComponentesForm
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
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvComponentes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPinCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoltage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTolerance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNominalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(20, 15);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(100, 25);
            this.btnRefrescar.TabIndex = 0;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(135, 20);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(43, 13);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "Total: 0";
            // 
            // dgvComponentes
            // 
            this.dgvComponentes.AllowUserToAddRows = false;
            this.dgvComponentes.AllowUserToDeleteRows = false;
            this.dgvComponentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colPinCount,
            this.colPackageType,
            this.colVoltage,
            this.colTolerance,
            this.colNominalValue,
            this.colManufacturer,
            this.colCountry,
            this.colCreatedAt});
            this.dgvComponentes.Location = new System.Drawing.Point(20, 50);
            this.dgvComponentes.Name = "dgvComponentes";
            this.dgvComponentes.ReadOnly = true;
            this.dgvComponentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComponentes.Size = new System.Drawing.Size(920, 320);
            this.dgvComponentes.TabIndex = 2;
            this.dgvComponentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComponentes_CellContentClick);
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
            this.colNominalValue.Width = 110;
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
            // ListarComponentesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 390);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvComponentes);
            this.Name = "ListarComponentesForm";
            this.Text = "Listar Componentes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button  btnRefrescar;
        private System.Windows.Forms.Label   lblCount;
        private System.Windows.Forms.DataGridView dgvComponentes;
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
