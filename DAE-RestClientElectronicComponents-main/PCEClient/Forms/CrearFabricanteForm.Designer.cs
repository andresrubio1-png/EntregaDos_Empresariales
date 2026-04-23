namespace PCEClient.Forms
{
    partial class CrearFabricanteForm
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
            this.lblName     = new System.Windows.Forms.Label();
            this.txtName     = new System.Windows.Forms.TextBox();
            this.lblCountry  = new System.Windows.Forms.Label();
            this.txtCountry  = new System.Windows.Forms.TextBox();
            this.lblLeadTime = new System.Windows.Forms.Label();
            this.txtLeadTime = new System.Windows.Forms.TextBox();
            this.lblLeadHint = new System.Windows.Forms.Label();
            this.btnCrear    = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Name     = "lblName";
            this.lblName.Text     = "Nombre:";
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(160, 27);
            this.txtName.Name     = "txtName";
            this.txtName.Size     = new System.Drawing.Size(220, 20);
            //
            // lblCountry
            //
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(30, 65);
            this.lblCountry.Name     = "lblCountry";
            this.lblCountry.Text     = "País:";
            //
            // txtCountry
            //
            this.txtCountry.Location = new System.Drawing.Point(160, 62);
            this.txtCountry.Name     = "txtCountry";
            this.txtCountry.Size     = new System.Drawing.Size(220, 20);
            //
            // lblLeadTime
            //
            this.lblLeadTime.AutoSize = true;
            this.lblLeadTime.Location = new System.Drawing.Point(30, 100);
            this.lblLeadTime.Name     = "lblLeadTime";
            this.lblLeadTime.Text     = "T. de entrega:";
            //
            // txtLeadTime
            //
            this.txtLeadTime.Location = new System.Drawing.Point(160, 97);
            this.txtLeadTime.Name     = "txtLeadTime";
            this.txtLeadTime.Size     = new System.Drawing.Size(120, 20);
            //
            // lblLeadHint
            //
            this.lblLeadHint.AutoSize  = true;
            this.lblLeadHint.ForeColor = System.Drawing.Color.Gray;
            this.lblLeadHint.Location  = new System.Drawing.Point(285, 100);
            this.lblLeadHint.Name      = "lblLeadHint";
            this.lblLeadHint.Text      = "días promedio";
            //
            // btnCrear
            //
            this.btnCrear.Location         = new System.Drawing.Point(160, 140);
            this.btnCrear.Name             = "btnCrear";
            this.btnCrear.Size             = new System.Drawing.Size(220, 35);
            this.btnCrear.Text             = "Crear Fabricante";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click           += new System.EventHandler(this.btnCrear_Click);
            //
            // CrearFabricanteForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(420, 200);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblLeadTime);
            this.Controls.Add(this.txtLeadTime);
            this.Controls.Add(this.lblLeadHint);
            this.Controls.Add(this.btnCrear);
            this.Name = "CrearFabricanteForm";
            this.Text = "Crear Fabricante";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label   lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label   lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label   lblLeadTime;
        private System.Windows.Forms.TextBox txtLeadTime;
        private System.Windows.Forms.Label   lblLeadHint;
        private System.Windows.Forms.Button  btnCrear;
    }
}
