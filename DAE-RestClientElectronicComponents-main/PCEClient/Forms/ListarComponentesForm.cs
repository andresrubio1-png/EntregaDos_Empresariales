using System;
using System.Windows.Forms;
using PCEClient.Services;

namespace PCEClient.Forms
{
    public partial class ListarComponentesForm : Form, IComponentObserver
    {
        public ListarComponentesForm()
        {
            InitializeComponent();
            ComponentEventManager.Instance.Subscribe(this);
            LoadData();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ComponentEventManager.Instance.Unsubscribe(this);
            base.OnFormClosed(e);
        }

        public void OnComponentsChanged()
        {
            if (InvokeRequired) { Invoke(new Action(OnComponentsChanged)); return; }
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                var list = await ApiService.Instance.GetAllAsync();
                dgvComponentes.Rows.Clear();
                foreach (var c in list)
                {
                    dgvComponentes.Rows.Add(
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
                lblCount.Text = $"Total: {list.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar componentes:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e) => LoadData();

        private void dgvComponentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
