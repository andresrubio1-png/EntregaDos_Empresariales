using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PCEClient.Models;
using PCEClient.Services;

namespace PCEClient.Forms
{
    public partial class ListarPorFiltroForm : Form, IComponentObserver
    {
        public ListarPorFiltroForm()
        {
            InitializeComponent();
            cboPackageType.DataSource = Enum.GetValues(typeof(PackageType));
            ComponentEventManager.Instance.Subscribe(this);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AplicarFiltro();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ComponentEventManager.Instance.Unsubscribe(this);
            base.OnFormClosed(e);
        }

        public void OnComponentsChanged()
        {
            if (InvokeRequired) { Invoke(new Action(OnComponentsChanged)); return; }
            AplicarFiltro();
        }

        private void btnFiltrar_Click(object sender, EventArgs e) => AplicarFiltro();

        private async void AplicarFiltro()
        {
            try
            {
                btnFiltrar.Enabled = false;
                List<PassiveComponent> results;

                if (rbPackageType.Checked)
                {
                    var packageType = (PackageType)cboPackageType.SelectedItem;
                    results = await ApiService.Instance.GetByPackageTypeAsync(packageType);
                }
                else
                {
                    if (!double.TryParse(txtMinVoltage.Text, out double min) ||
                        !double.TryParse(txtMaxVoltage.Text, out double max))
                    {
                        btnFiltrar.Enabled = true;
                        return;
                    }
                    results = await ApiService.Instance.GetByVoltageRangeAsync(min, max);
                }

                btnFiltrar.Enabled = true;
                LoadResults(results);
            }
            catch (Exception ex)
            {
                btnFiltrar.Enabled = true;
                MessageBox.Show($"Error al filtrar:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadResults(List<PassiveComponent> results)
        {
            dgvResultados.Rows.Clear();
            foreach (var c in results)
            {
                dgvResultados.Rows.Add(
                    c.Id, 
                    c.PinCount, 
                    c.PackageType, 
                    c.Voltage,
                    c.Tolerance,
                    $"{c.NominalValue?.Value} {c.NominalValue?.Unit}",
                    c.Manufacturer?.Name ?? "—",
                    c.Manufacturer?.Country ?? "—",
                    c.CreatedAt?.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            lblCount.Text = $"Total: {results.Count}";
        }

        private void rbPackageType_CheckedChanged(object sender, EventArgs e)
        {
            cboPackageType.Enabled = rbPackageType.Checked;
            txtMinVoltage.Enabled = rbVoltageRange.Checked;
            txtMaxVoltage.Enabled = rbVoltageRange.Checked;
        }

    }
}
