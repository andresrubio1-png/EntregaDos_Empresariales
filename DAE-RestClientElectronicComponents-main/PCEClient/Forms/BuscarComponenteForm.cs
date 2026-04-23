using System;
using System.Windows.Forms;
using PCEClient.Models;
using PCEClient.Services;

namespace PCEClient.Forms
{
    public partial class BuscarComponenteForm : Form
    {
        public BuscarComponenteForm()
        {
            InitializeComponent();
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
                var c = await ApiService.Instance.GetByIdAsync(id);
                btnBuscar.Enabled = true;

                if (c == null)
                {
                    MessageBox.Show("No se encontró un componente con ese ID.", "No encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDetails();
                    return;
                }

                ShowDetails(c);
            }
            catch (Exception ex)
            {
                btnBuscar.Enabled = true;
                MessageBox.Show($"Error al buscar:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowDetails(PassiveComponent c)
        {
            lblDetId.Text           = $"ID: {c.Id}";
            lblDetPinCount.Text     = $"Núm. de pines: {c.PinCount}";
            lblDetPackageType.Text  = $"Encapsulado: {c.PackageType}";
            lblDetVoltage.Text      = $"Voltaje: {c.Voltage} V";
            lblDetTolerance.Text    = $"Tolerancia: {c.Tolerance}";
            lblDetNominalValue.Text = $"Valor nominal: {c.NominalValue?.Value} {c.NominalValue?.Unit}";
            lblDetCreatedAt.Text    = $"Creado: {c.CreatedAt?.ToString("yyyy-MM-dd HH:mm:ss")}";
            // Fabricante
            lblDetManufacturer.Text = $"Fabricante: {c.Manufacturer?.Name ?? "—"}";
            lblDetCountry.Text      = $"País: {c.Manufacturer?.Country ?? "—"}";
            lblDetLeadTime.Text     = $"T. de entrega: {c.Manufacturer?.AverageLeadTime} días";
        }

        private void ClearDetails()
        {
            lblDetId.Text           = "ID:";
            lblDetPinCount.Text     = "Núm. de pines:";
            lblDetPackageType.Text  = "Encapsulado:";
            lblDetVoltage.Text      = "Voltaje:";
            lblDetTolerance.Text    = "Tolerancia:";
            lblDetNominalValue.Text = "Valor nominal:";
            lblDetCreatedAt.Text    = "Creado:";
            lblDetManufacturer.Text = "Fabricante:";
            lblDetCountry.Text      = "País:";
            lblDetLeadTime.Text     = "T. de entrega:";
        }
    }
}
