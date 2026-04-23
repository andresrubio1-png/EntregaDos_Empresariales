using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PCEClient.Models;
using PCEClient.Services;

namespace PCEClient.Forms
{
    public partial class ActualizarComponenteForm : Form, IManufacturerObserver
    {
        private PassiveComponent _componenteEncontrado;
        private int? _selectedManufacturerId = null;

        public ActualizarComponenteForm()
        {
            InitializeComponent();
            cboPackageType.DataSource = Enum.GetValues(typeof(PackageType));
            SetFieldsEnabled(false);
            btnActualizar.Visible = false;
            ManufacturerEventManager.Instance.Subscribe(this);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ManufacturerEventManager.Instance.Unsubscribe(this);
            base.OnFormClosed(e);
        }

        public void OnManufacturersChanged()
        {
            if (InvokeRequired) { Invoke(new Action(OnManufacturersChanged)); return; }
            LoadManufacturers();
        }

        private async void LoadManufacturers(int? preSelectId = null)
        {
            try
            {
                List<Manufacturer> list = await ApiService.Instance.GetAllManufacturersAsync();
                dgvFabricantes.Rows.Clear();
                _selectedManufacturerId = null;
                lblFabSeleccionado.Text = "Ninguno seleccionado";

                foreach (var m in list)
                {
                    int rowIdx = dgvFabricantes.Rows.Add(m.Id, m.Name, m.Country, m.AverageLeadTime);
                    // Pre-seleccionar el fabricante actual del componente
                    if (preSelectId.HasValue && m.Id == preSelectId.Value)
                    {
                        dgvFabricantes.Rows[rowIdx].Selected = true;
                        _selectedManufacturerId = m.Id;
                        lblFabSeleccionado.Text = $"✔ {m.Name} ({m.Country})";
                    }
                }
            }
            catch (Exception ex)
            {
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
        }

        private void SetFieldsEnabled(bool enabled)
        {
            txtPinCount.Enabled    = enabled;
            cboPackageType.Enabled = enabled;
            txtVoltage.Enabled     = enabled;
            txtTolerance.Enabled   = enabled;
            txtNominalValue.Enabled = enabled;
            txtUnit.Enabled        = enabled;
            dgvFabricantes.Enabled = enabled;
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
                _componenteEncontrado = await ApiService.Instance.GetByIdAsync(id);
                btnBuscar.Enabled = true;

                if (_componenteEncontrado == null)
                {
                    MessageBox.Show("No se encontró un componente con ese ID.", "No encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetFieldsEnabled(false);
                    btnActualizar.Visible = false;
                    return;
                }

                LoadFields(_componenteEncontrado);
                // Cargar fabricantes y pre-seleccionar el actual
                await System.Threading.Tasks.Task.Run(() => { });
                LoadManufacturers(_componenteEncontrado.Manufacturer?.Id);
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
            if (_componenteEncontrado == null) return;

            if (!ValidateFields()) return;

            var confirm = MessageBox.Show(
                $"¿Confirma actualizar el componente con ID {_componenteEncontrado.Id}?",
                "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var request = new PassiveComponentRequest
                {
                    PinCount       = int.Parse(txtPinCount.Text),
                    PackageType    = (PackageType)cboPackageType.SelectedItem,
                    Voltage        = double.Parse(txtVoltage.Text),
                    ManufacturerId = _selectedManufacturerId.Value,
                    Tolerance      = double.Parse(txtTolerance.Text),
                    NominalValue   = new UnitMeasurement
                    {
                        Value = double.Parse(txtNominalValue.Text),
                        Unit  = txtUnit.Text.Trim()
                    }
                };

                btnActualizar.Enabled = false;
                var updated = await ApiService.Instance.UpdateAsync(_componenteEncontrado.Id.Value, request);
                btnActualizar.Enabled = true;

                if (updated != null)
                {
                    MessageBox.Show("Componente actualizado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ComponentEventManager.Instance.NotifyAll();
                    _componenteEncontrado = updated;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el componente.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                btnActualizar.Enabled = true;
                MessageBox.Show($"Error al actualizar:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFields(PassiveComponent c)
        {
            txtPinCount.Text     = c.PinCount.ToString();
            cboPackageType.SelectedItem = c.PackageType;
            txtVoltage.Text      = c.Voltage.ToString();
            txtTolerance.Text    = c.Tolerance.ToString();
            txtNominalValue.Text = c.NominalValue?.Value.ToString() ?? "";
            txtUnit.Text         = c.NominalValue?.Unit ?? "";
        }

        private bool ValidateFields()
        {
            if (!_selectedManufacturerId.HasValue)
            {
                MessageBox.Show("Debe seleccionar un fabricante.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtPinCount.Text, out _))
            { MessageBox.Show("Núm. de pines debe ser un número entero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (!double.TryParse(txtVoltage.Text, out _))
            { MessageBox.Show("Voltaje debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (!double.TryParse(txtTolerance.Text, out _))
            { MessageBox.Show("Tolerancia debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (!double.TryParse(txtNominalValue.Text, out _))
            { MessageBox.Show("Valor nominal debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (string.IsNullOrWhiteSpace(txtUnit.Text))
            { MessageBox.Show("Unidad no puede estar vacía.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }
    }
}
