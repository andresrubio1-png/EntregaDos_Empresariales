using System;
using System.Windows.Forms;
using PCEClient.Forms;

namespace PCEClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowChildForm(Form childForm)
        {
            childForm.Show();
            childForm.Focus();
        }

        // ── Archivo ────────────────────────────────────────────────────────
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        // ── Fabricante ─────────────────────────────────────────────────────
        private void crearFabricanteToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowChildForm(new CrearFabricanteForm());

        private void buscarFabricanteToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowChildForm(new BuscarFabricanteForm());

        private void eliminarFabricanteToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowChildForm(new EliminarFabricanteForm());

        private void actualizarFabricanteToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowChildForm(new ActualizarFabricanteForm());

        private void listarFabricantesToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowChildForm(new ListarFabricantesForm());

        // ── Componente Pasivo ──────────────────────────────────────────────
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowChildForm(new CrearComponenteForm());

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowChildForm(new BuscarComponenteForm());

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowChildForm(new EliminarComponenteForm());

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowChildForm(new ActualizarComponenteForm());

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowChildForm(new ListarComponentesForm());

        private void listarPorFiltroToolStripMenuItem_Click(object sender, EventArgs e)
            => ShowChildForm(new ListarPorFiltroForm());

        // ── Ayuda ──────────────────────────────────────────────────────────
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new AcercaDeForm()) f.ShowDialog(this);
        }
    }
}
