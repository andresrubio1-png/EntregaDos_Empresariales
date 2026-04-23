using System;
using System.Windows.Forms;
using PCEClient.Services;

namespace PCEClient.Forms
{
    public partial class ListarFabricantesForm : Form, IManufacturerObserver
    {
        public ListarFabricantesForm()
        {
            InitializeComponent();
            ManufacturerEventManager.Instance.Subscribe(this);
            LoadData();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ManufacturerEventManager.Instance.Unsubscribe(this);
            base.OnFormClosed(e);
        }

        public void OnManufacturersChanged()
        {
            if (InvokeRequired) { Invoke(new Action(OnManufacturersChanged)); return; }
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                var list = await ApiService.Instance.GetAllManufacturersAsync();
                dgvFabricantes.Rows.Clear();
                foreach (var m in list)
                    dgvFabricantes.Rows.Add(m.Id, m.Name, m.Country, m.AverageLeadTime,
                        m.CreatedAt?.ToString("yyyy-MM-dd HH:mm:ss"));
                lblCount.Text = $"Total: {list.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar fabricantes:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e) => LoadData();
    }
}
