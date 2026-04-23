using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PCEClient.Models;
using PCEClient.Services;

namespace PCEClient.Forms
{
    public partial class CrearComponenteForm : Form, IManufacturerObserver
    {
        private int? _selectedManufacturerId = null;

        public CrearComponenteForm()
        {
            InitializeComponent();
            cboPackageType.DataSource = Enum.GetValues(typeof(PackageType));
            ManufacturerEventManager.Instance.Subscribe(this);
            LoadManufacturers();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ManufacturerEventManager.Instance.Unsubscribe(this);
            base.OnFormClosed(e);
        }

        // IManufacturerObserver: se actualiza si alguien crea un fabricante mientras este form está abierto
        public void OnManufacturersChanged()
        {
            if (InvokeRequired) { Invoke(new Action(OnManufacturersChanged)); return; }
            LoadManufacturers();
        }

        private async void LoadManufacturers()
        {
            try
            {
                btnRefrescarFab.Enabled = false;
                List<Manufacturer> list = await ApiService.Instance.GetAllManufacturersAsync();
                btnRefrescarFab.Enabled = true;

                dgvFabricantes.Rows.Clear();
                _selectedManufacturerId = null;
                lblFabSeleccionado.Text = "Ninguno seleccionado";
                UpdateCrearButton();

                foreach (var m in list)
                    dgvFabricantes.Rows.Add(m.Id, m.Name, m.Country, m.AverageLeadTime);
            }
            catch (Exception ex)
            {
                btnRefrescarFab.Enabled = true;
                MessageBox.Show($"Error al cargar fabricantes:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFabricantes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFabricantes.SelectedRows.Count == 0)
            {
                _selectedManufacturerId = null;
                lblFabSeleccionado.Text = "Ninguno seleccionado";
            }
            else
            {
                var row = dgvFabricantes.SelectedRows[0];
                _selectedManufacturerId = (int)row.Cells["colFabId"].Value;
                lblFabSeleccionado.Text = $"✔ {row.Cells["colFabName"].Value} ({row.Cells["colFabCountry"].Value})";
            }
            UpdateCrearButton();
        }

        private void btnRefrescarFab_Click(object sender, EventArgs e) => LoadManufacturers();

        private void UpdateCrearButton()
        {
            btnCrear.Enabled = _selectedManufacturerId.HasValue;
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            try
            {
                var request = new PassiveComponentRequest
                {
                    PinCount        = int.Parse(txtPinCount.Text),
                    PackageType     = (PackageType)cboPackageType.SelectedItem,
                    Voltage         = double.Parse(txtVoltage.Text),
                    ManufacturerId  = _selectedManufacturerId.Value,
                    Tolerance       = double.Parse(txtTolerance.Text),
                    NominalValue    = new UnitMeasurement
                    {
                        Value = double.Parse(txtNominalValue.Text),
                        Unit  = txtUnit.Text.Trim()
                    }
                };

                btnCrear.Enabled = false;
                var created = await ApiService.Instance.CreateAsync(request);
                btnCrear.Enabled = _selectedManufacturerId.HasValue;

                MessageBox.Show($"Componente creado con ID: {created.Id}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ComponentEventManager.Instance.NotifyAll();
                ClearComponentFields();
            }
            catch (Exception ex)
            {
                btnCrear.Enabled = _selectedManufacturerId.HasValue;
                MessageBox.Show($"Error al crear componente:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFields()
        {
            if (!_selectedManufacturerId.HasValue)
            {
                MessageBox.Show("Debe seleccionar un fabricante.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtPinCount.Text, out _))
            {
                MessageBox.Show("Pin Count debe ser un número entero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!double.TryParse(txtVoltage.Text, out _))
            {
                MessageBox.Show("Voltaje debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!double.TryParse(txtTolerance.Text, out _))
            {
                MessageBox.Show("Tolerancia debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!double.TryParse(txtNominalValue.Text, out _))
            {
                MessageBox.Show("Valor nominal debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("Unidad no puede estar vacía.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearComponentFields()
        {
            txtPinCount.Clear();
            txtVoltage.Clear();
            txtTolerance.Clear();
            txtNominalValue.Clear();
            txtUnit.Clear();
            cboPackageType.SelectedIndex = 0;
        }
    }
}
