using System;
using System.Windows.Forms;
using PCEClient.Models;
using PCEClient.Services;

namespace PCEClient.Forms
{
    public partial class EliminarFabricanteForm : Form
    {
        private Manufacturer _fabricanteEncontrado;

        public EliminarFabricanteForm()
        {
            InitializeComponent();
            btnEliminar.Visible = false;
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
                    ClearDetails();
                    btnEliminar.Visible = false;
                    return;
                }

                ShowDetails(_fabricanteEncontrado);
                btnEliminar.Visible = true;
            }
            catch (Exception ex)
            {
                btnBuscar.Enabled = true;
                MessageBox.Show($"Error al buscar:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_fabricanteEncontrado == null) return;

            var result = MessageBox.Show(
                $"¿Está seguro que desea eliminar el fabricante \"{_fabricanteEncontrado.Name}\" (ID {_fabricanteEncontrado.Id})?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                btnEliminar.Enabled = false;
                bool deleted = await ApiService.Instance.DeleteManufacturerAsync(_fabricanteEncontrado.Id.Value);
                btnEliminar.Enabled = true;

                if (deleted)
                {
                    MessageBox.Show("Fabricante eliminado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ManufacturerEventManager.Instance.NotifyAll();
                    ClearDetails();
                    btnEliminar.Visible = false;
                    txtId.Clear();
                    _fabricanteEncontrado = null;
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el fabricante.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                btnEliminar.Enabled = true;
                MessageBox.Show($"Error al eliminar:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
