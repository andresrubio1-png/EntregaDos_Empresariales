using System;
using System.Windows.Forms;
using PCEClient.Models;
using PCEClient.Services;

namespace PCEClient.Forms
{
    public partial class CrearFabricanteForm : Form
    {
        public CrearFabricanteForm()
        {
            InitializeComponent();
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            try
            {
                var request = new ManufacturerRequest
                {
                    Name            = txtName.Text.Trim(),
                    Country         = txtCountry.Text.Trim(),
                    AverageLeadTime = double.Parse(txtLeadTime.Text)
                };

                btnCrear.Enabled = false;
                var created = await ApiService.Instance.CreateManufacturerAsync(request);
                btnCrear.Enabled = true;

                MessageBox.Show(
                    $"Fabricante \"{created.Name}\" creado con ID: {created.Id}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ManufacturerEventManager.Instance.NotifyAll();
                ClearFields();
            }
            catch (Exception ex)
            {
                btnCrear.Enabled = true;
                MessageBox.Show($"Error al crear fabricante:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                MessageBox.Show("El país no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCountry.Focus();
                return false;
            }
            if (!double.TryParse(txtLeadTime.Text, out double lt) || lt < 0)
            {
                MessageBox.Show("T. de entrega debe ser un número positivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLeadTime.Focus();
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtCountry.Clear();
            txtLeadTime.Clear();
            txtName.Focus();
        }
    }
}
