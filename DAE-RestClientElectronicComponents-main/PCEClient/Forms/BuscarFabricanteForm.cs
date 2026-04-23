using System;
using System.Windows.Forms;
using PCEClient.Models;
using PCEClient.Services;

namespace PCEClient.Forms
{
    public partial class BuscarFabricanteForm : Form
    {
        public BuscarFabricanteForm()
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
                var m = await ApiService.Instance.GetManufacturerByIdAsync(id);
                btnBuscar.Enabled = true;

                if (m == null)
                {
                    MessageBox.Show("No se encontró un fabricante con ese ID.", "No encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDetails();
                    return;
                }

                ShowDetails(m);
            }
            catch (Exception ex)
            {
                btnBuscar.Enabled = true;
                MessageBox.Show($"Error al buscar:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowDetails(Manufacturer m)
        {
            lblDetId.Text        = $"ID: {m.Id}";
            lblDetName.Text      = $"Nombre: {m.Name}";
            lblDetCountry.Text   = $"País: {m.Country}";
            lblDetLeadTime.Text  = $"T. de entrega: {m.AverageLeadTime} días";
            lblDetCreatedAt.Text = $"Creado: {m.CreatedAt?.ToString("yyyy-MM-dd HH:mm:ss")}";
        }

        private void ClearDetails()
        {
            lblDetId.Text        = "ID:";
            lblDetName.Text      = "Nombre:";
            lblDetCountry.Text   = "País:";
            lblDetLeadTime.Text  = "T. de entrega:";
            lblDetCreatedAt.Text = "Creado:";
        }
    }
}
