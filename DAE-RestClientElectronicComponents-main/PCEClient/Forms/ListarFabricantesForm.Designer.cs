namespace PCEClient.Forms
{
    partial class ListarFabricantesForm
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
            this.btnRefrescar   = new System.Windows.Forms.Button();
            this.lblCount       = new System.Windows.Forms.Label();
            this.dgvFabricantes = new System.Windows.Forms.DataGridView();
            this.colId          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeadTime    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricantes)).BeginInit();
            this.SuspendLayout();
            //
            // btnRefrescar
            //
            this.btnRefrescar.Location = new System.Drawing.Point(20, 15);
            this.btnRefrescar.Name     = "btnRefrescar";
            this.btnRefrescar.Size     = new System.Drawing.Size(100, 25);
            this.btnRefrescar.Text     = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click   += new System.EventHandler(this.btnRefrescar_Click);
            //
            // lblCount
            //
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(135, 20);
            this.lblCount.Name     = "lblCount";
            this.lblCount.Text     = "Total: 0";
            //
            // dgvFabricantes
            //
            this.dgvFabricantes.AllowUserToAddRows    = false;
            this.dgvFabricantes.AllowUserToDeleteRows = false;
            this.dgvFabricantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFabricantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabricantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId, this.colName, this.colCountry, this.colLeadTime, this.colCreatedAt });
            this.dgvFabricantes.Location  = new System.Drawing.Point(20, 50);
            this.dgvFabricantes.Name      = "dgvFabricantes";
            this.dgvFabricantes.ReadOnly  = true;
            this.dgvFabricantes.Size      = new System.Drawing.Size(640, 260);
            this.dgvFabricantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            //
            // Columns
            //
            this.colId.HeaderText = "ID";        this.colId.Name       = "colId";        this.colId.Width       = 50;
            this.colName.HeaderText = "Nombre";  this.colName.Name     = "colName";      this.colName.Width     = 180;
            this.colCountry.HeaderText = "País"; this.colCountry.Name  = "colCountry";   this.colCountry.Width  = 100;
            this.colLeadTime.HeaderText = "T. de entrega (días)"; this.colLeadTime.Name = "colLeadTime"; this.colLeadTime.Width = 140;
            this.colCreatedAt.HeaderText = "Creado"; this.colCreatedAt.Name = "colCreatedAt"; this.colCreatedAt.Width = 160;
            //
            // ListarFabricantesForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(680, 330);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvFabricantes);
            this.Name = "ListarFabricantesForm";
            this.Text = "Listar Fabricantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button                  btnRefrescar;
        private System.Windows.Forms.Label                   lblCount;
        private System.Windows.Forms.DataGridView            dgvFabricantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeadTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
    }
}
