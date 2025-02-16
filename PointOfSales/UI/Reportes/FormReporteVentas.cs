using PointOfSales.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSales.Entities;

namespace PointOfSales.UI.Reportes
{
    public partial class FormReporteVentas : Form
    {
        public FormReporteVentas()
        {
            InitializeComponent();
            CargarUsuarios();
            CargarClientes();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private VentaBLL ventaBLL = new VentaBLL();

        private void ActualizarTotalVentas()
        {
            decimal totalVentas = 0;

            // Recorrer todas las filas del DataGridView
            foreach (DataGridViewRow row in dgvReporteVentas.Rows)
            {
                if (row.Cells["Total"].Value != null && decimal.TryParse(row.Cells["Total"].Value.ToString(), out decimal totalFila))
                {
                    totalVentas += totalFila;
                }
            }

            // Actualizar el texto del label con el total calculado
            lblTotalVentas.Text = $"${totalVentas:F2}";
        }

        private void CargarUsuarios()
        {
            // Obtener la lista de usuarios desde la base de datos
            var usuarios = ventaBLL.ObtenerUsuarios();
            cbUsuario.DataSource = usuarios;
            cbUsuario.DisplayMember = "Nombre";
            cbUsuario.ValueMember = "Id";
            cbUsuario.SelectedIndex = -1; // Sin selección inicial
        }

        private void CargarClientes()
        {
            // Obtener la lista de clientes desde la base de datos
            var clientes = ventaBLL.ObtenerClientes();
            cbCliente.DataSource = clientes;
            cbCliente.DisplayMember = "Nombre";
            cbCliente.ValueMember = "Id";
            cbCliente.SelectedIndex = -1; // Sin selección inicial
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los filtros
                DateTime fechaInicial = dtpFechaInicial.Value.Date;
                DateTime fechaFinal = dtpFechaFinal.Value.Date.AddDays(1).AddSeconds(-1); // Hasta el final del día
                int? idUsuario = cbUsuario.SelectedIndex >= 0 ? (int?)cbUsuario.SelectedValue : null;
                int? idCliente = cbCliente.SelectedIndex >= 0 ? (int?)cbCliente.SelectedValue : null;

                // Obtener las ventas filtradas
                var ventas = ventaBLL.ObtenerVentasFiltradas(fechaInicial, fechaFinal, idUsuario, idCliente);

                // Mostrar los resultados en el DataGridView
                dgvReporteVentas.DataSource = ventas;
                ActualizarTotalVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Obtener los valores de los filtros
                DateTime fechaInicial = dtpFechaInicial.Value.Date;
                DateTime fechaFinal = dtpFechaFinal.Value.Date.AddDays(1).AddSeconds(-1); // Hasta el final del día
                int? idUsuario = cbUsuario.SelectedIndex >= 0 ? (int?)cbUsuario.SelectedValue : null;
                int? idCliente = cbCliente.SelectedIndex >= 0 ? (int?)cbCliente.SelectedValue : null;

                // Obtener las ventas filtradas
                var ventas = ventaBLL.ObtenerVentasFiltradas(fechaInicial, fechaFinal, idUsuario, idCliente);

                // Mostrar los resultados en el DataGridView
                dgvReporteVentas.DataSource = ventas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
