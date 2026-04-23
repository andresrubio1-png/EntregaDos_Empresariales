namespace PCEClient.Forms
{
    partial class ActualizarFabricanteForm
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
            this.lblId     = new System.Windows.Forms.Label();
            this.txtId     = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            // Datos
            this.grpDatos    = new System.Windows.Forms.GroupBox();
            this.lblName     = new System.Windows.Forms.Label();
            this.txtName     = new System.Windows.Forms.TextBox();
            this.lblCountry  = new System.Windows.Forms.Label();
            this.txtCountry  = new System.Windows.Forms.TextBox();
            this.lblLeadTime = new System.Windows.Forms.Label();
            this.txtLeadTime = new System.Windows.Forms.TextBox();
            this.lblLeadHint = new System.Windows.Forms.Label();
            // Actualizar
            this.btnActualizar = new System.Windows.Forms.Button();

            this.grpDatos.SuspendLayout();
            this.SuspendLayout();

            // ── Buscar ────────────────────────────────────────────────────
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 20);
            this.lblId.Text     = "ID del fabricante:";
            this.txtId.Location = new System.Drawing.Point(140, 17);
            this.txtId.Name     = "txtId";
            this.txtId.Size     = new System.Drawing.Size(100, 20);
            this.btnBuscar.Location = new System.Drawing.Point(255, 15);
            this.btnBuscar.Name     = "btnBuscar";
            this.btnBuscar.Size     = new System.Drawing.Size(100, 25);
            this.btnBuscar.Text     = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // ── grpDatos ─────────────────────────────────────────────────
            this.grpDatos.Controls.Add(this.lblName);
            this.grpDatos.Controls.Add(this.txtName);
            this.grpDatos.Controls.Add(this.lblCountry);
            this.grpDatos.Controls.Add(this.txtCountry);
            this.grpDatos.Controls.Add(this.lblLeadTime);
            this.grpDatos.Controls.Add(this.txtLeadTime);
            this.grpDatos.Controls.Add(this.lblLeadHint);
            this.grpDatos.Location = new System.Drawing.Point(20, 55);
            this.grpDatos.Name     = "grpDatos";
            this.grpDatos.Size     = new System.Drawing.Size(370, 155);
            this.grpDatos.Text     = "Datos del Fabricante";

            this.lblName.AutoSize    = true;
            this.lblName.Location    = new System.Drawing.Point(15, 30);
            this.lblName.Text        = "Nombre:";
            this.txtName.Location    = new System.Drawing.Point(130, 27);
            this.txtName.Name        = "txtName";
            this.txtName.Size        = new System.Drawing.Size(220, 20);
            this.lblCountry.AutoSize  = true;
            this.lblCountry.Location  = new System.Drawing.Point(15, 68);
            this.lblCountry.Text      = "País:";
            this.txtCountry.Location  = new System.Drawing.Point(130, 65);
            this.txtCountry.Name      = "txtCountry";
            this.txtCountry.Size      = new System.Drawing.Size(220, 20);
            this.lblLeadTime.AutoSize  = true;
            this.lblLeadTime.Location  = new System.Drawing.Point(15, 106);
            this.lblLeadTime.Text      = "T. de entrega:";
            this.txtLeadTime.Location  = new System.Drawing.Point(130, 103);
            this.txtLeadTime.Name      = "txtLeadTime";
            this.txtLeadTime.Size      = new System.Drawing.Size(110, 20);
            this.lblLeadHint.AutoSize  = true;
            this.lblLeadHint.ForeColor = System.Drawing.Color.Gray;
            this.lblLeadHint.Location  = new System.Drawing.Point(248, 106);
            this.lblLeadHint.Text      = "días promedio";

            // ── btnActualizar ─────────────────────────────────────────────
            this.btnActualizar.Location = new System.Drawing.Point(20, 225);
            this.btnActualizar.Name     = "btnActualizar";
            this.btnActualizar.Size     = new System.Drawing.Size(370, 35);
            this.btnActualizar.Text     = "Actualizar Fabricante";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // ── ActualizarFabricanteForm ──────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(415, 280);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnActualizar);
            this.Name = "ActualizarFabricanteForm";
            this.Text = "Actualizar Fabricante";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label    lblId;
        private System.Windows.Forms.TextBox  txtId;
        private System.Windows.Forms.Button   btnBuscar;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label    lblName;
        private System.Windows.Forms.TextBox  txtName;
        private System.Windows.Forms.Label    lblCountry;
        private System.Windows.Forms.TextBox  txtCountry;
        private System.Windows.Forms.Label    lblLeadTime;
        private System.Windows.Forms.TextBox  txtLeadTime;
        private System.Windows.Forms.Label    lblLeadHint;
        private System.Windows.Forms.Button   btnActualizar;
    }
}
