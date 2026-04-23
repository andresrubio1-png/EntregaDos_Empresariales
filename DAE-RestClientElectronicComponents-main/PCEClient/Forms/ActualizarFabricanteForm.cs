using System;
using System.Windows.Forms;
using PCEClient.Models;
using PCEClient.Services;

namespace PCEClient.Forms
{
    public partial class ActualizarFabricanteForm : Form
    {
        private Manufacturer _fabricanteEncontrado;

        public ActualizarFabricanteForm()
        {
            InitializeComponent();
            SetFieldsEnabled(false);
            btnActualizar.Visible = false;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtId.Text, out int id))
                {
                    MessageBox.Show("Ingrese un ID válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                btnBuscar.Enabled = false;
                _fabricanteEncontrado = await ApiService.Instance.GetManufacturerByIdAsync(id);
                btnBuscar.Enabled = true;

                if (_fabricanteEncontrado == null)
                {
                    MessageBox.Show("No se encontró un fabricante con ese ID.", "No encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetFieldsEnabled(false);
                    btnActualizar.Visible = false;
                    return;
                }

                LoadFields(_fabricanteEncontrado);
                SetFieldsEnabled(true);
                btnActualizar.Visible = true;
            }
            catch (Exception ex)
            {
                btnBuscar.Enabled = true;
                MessageBox.Show($"Error al buscar:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (_fabricanteEncontrado == null) return;
            if (!ValidateFields()) return;

            var confirm = MessageBox.Show(
                $"¿Confirma actualizar el fabricante con ID {_fabricanteEncontrado.Id}?",
                "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var request = new ManufacturerRequest
                {
                    Name            = txtName.Text.Trim(),
                    Country         = txtCountry.Text.Trim(),
                    AverageLeadTime = double.Parse(txtLeadTime.Text)
                };

                btnActualizar.Enabled = false;
                var updated = await ApiService.Instance.UpdateManufacturerAsync(_fabricanteEncontrado.Id.Value, request);
                btnActualizar.Enabled = true;

                if (updated != null)
                {
                    MessageBox.Show("Fabricante actualizado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ManufacturerEventManager.Instance.NotifyAll();
                    ComponentEventManager.Instance.NotifyAll();
                    _fabricanteEncontrado = updated;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el fabricante.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                btnActualizar.Enabled = true;
                MessageBox.Show($"Error al actualizar:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFields(Manufacturer m)
        {
            txtName.Text     = m.Name;
            txtCountry.Text  = m.Country;
            txtLeadTime.Text = m.AverageLeadTime.ToString();
        }

        private void SetFieldsEnabled(bool enabled)
        {
            txtName.Enabled     = enabled;
            txtCountry.Enabled  = enabled;
            txtLeadTime.Enabled = enabled;
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
    }
}
