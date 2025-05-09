﻿using PointOfSales.BLL;
using PointOfSales.DAL;
using PointOfSales.Entities;
using PointOfSales.UI;
using PointOfSales.UI.Reportes;
using PointOfSales.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSales
{
    public partial class FormMain : Form
    {
        private LogAccesosBLL logAccesosBLL;
        private TicketPrinter ticketPrinter;
        private ClockManager clockManager;
        private TabManager tabManager;
        private VentaBLL ventaBLL = new VentaBLL();
        private decimal totalVenta = 0;
        

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            InitializeComponents();
        }

        /// <summary>
        /// Inicializa los componentes necesarios para el formulario
        /// </summary>
        private void InitializeComponents()
        {
            this.TopMost = false;
            this.SendToBack();
            logAccesosBLL = new LogAccesosBLL();
            clockManager = new ClockManager(labelReloj);
            tabManager = new TabManager(tabControl1);
            this.KeyPreview = true;
            this.KeyDown += FormMain_KeyDown;
        }

        /// <summary>
        /// Evento que se ejecuta al presionar una tecla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            tabManager.CambiarPestana(e.KeyCode);
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Agregar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimirTicket_Click(object sender, EventArgs e)
        {
            try
            {
                var ultimaVenta = ventaBLL.ObtenerUltimaVenta();
                if (ultimaVenta == null || ultimaVenta.Detalles.Count == 0)
                {
                    MessageBox.Show("No hay ventas registradas en el corte actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ticketPrinter = new TicketPrinter(ultimaVenta);
                ticketPrinter.MostrarVistaPrevia();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Cobrar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCobrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                // Calcular el total de la venta
                decimal totalVenta = CalcularTotal();

                // Mostrar el formulario de pago
                using (FormPago formPago = new FormPago(totalVenta))
                {
                    var resultado = formPago.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        // Obtener el cambio calculado
                        decimal cambio = formPago.Cambio;

                        // Crear y registrar la venta
                        Venta venta = CrearVenta();
                        ventaBLL.RegistrarVenta(venta);

                        // Imprimir el ticket
                        ticketPrinter = new TicketPrinter(dgvProductosVenta, venta.Total);
                        ticketPrinter.ImprimirTicket();

                        // Mostrar mensaje de éxito con el cambio
                        MessageBox.Show($"Venta registrada exitosamente.\nCambio: ${cambio:F2}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar el formulario
                        LimpiarFormulario();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Crea una nueva venta con los datos ingresados en el formulario
        /// </summary>
        /// <returns></returns>
        private Venta CrearVenta()
        {
            return new Venta
            {
                Fecha = DateTime.Now,
                Total = CalcularTotal(),
                IdUsuario = ObtenerIdUsuarioActual(),
                Detalles = ObtenerDetallesVenta()
            };
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Cancelar"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void abrirTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            using (FormLogin formLogin = new FormLogin())
            {
                var resultado = formLogin.ShowDialog();
                if (formLogin.LoginExitoso)
                {
                    Show();
                    HabilitarInterfaz();
                    LoggerManager.Instance.LogInfo("Aplicación iniciada - Usuario Accedió: " + formLogin.idUsuarioActual);
                }
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Salir"
        /// </summary>
        private void HabilitarInterfaz()
        {
            facturaciónToolStripMenuItem.Visible = true;
            archivoToolStripMenuItem.Visible = true;
            reportesToolStripMenuItem.Visible = true;
            corteDeCajaToolStripMenuItem.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            abrirTurnoToolStripMenuItem.Visible = false;
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Salir"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            //lblEstatus.Text = "CONECTADO";
            //toolStripProgressBar1.Value = 100;
            //toolStripProgressBar1.Visible = false;
            //tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
        }


        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Salir"
        /// </summary>
        /// <param name="producto"></param>
        private void AgregarProductoAlDataGridView(Producto producto)
        {

            DataGridView dgv = tabControlVentas.SelectedTab.Controls[0] as DataGridView;

            if (producto == null)
            {
                MessageBox.Show("El articulo buscado no fue encontrado. Verifique e intente nuevamente", "Producto no en<contrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                // Verificar si el producto ya existe en el DataGridView
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if ((int)row.Cells["IdProducto"].Value == producto.Id)
                    {
                        int cantidadActual = (int)row.Cells["Cantidad"].Value;
                        row.Cells["Cantidad"].Value = cantidadActual + 1;
                        row.Cells["Subtotal"].Value = (cantidadActual + 1) * producto.Precio;
                        ActualizarTotalVenta();
                        ActualizarCantidadArticulos();

                        return;
                    }
                }

                // Si el producto no existe, agregarlo como una nueva fila
                dgv.Rows.Add(producto.Id, producto.CodigoBarras, producto.Descripcion, producto.Precio, 1, producto.Precio, producto.Stock);
                ActualizarTotalVenta();
                ActualizarCantidadArticulos();
            }
            
        }

        /// <summary>
        /// Actualiza el total de la venta en el formulario
        /// </summary>
        private void ActualizarTotalVenta()
        {
            if (tabControlVentas.SelectedTab == null || tabControlVentas.SelectedTab.Controls.Count == 0)
                return;

            DataGridView dgv = tabControlVentas.SelectedTab.Controls[0] as DataGridView;
            if (dgv == null)
                return;

            decimal total = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Importe"].Value);
            }

            // Actualizar el total en algún control (por ejemplo, un Label)
            lblTotal.Text = $"Total: {total:C}";
        }

        /// <summary>
        /// Obtiene los detalles de la venta a partir de los datos ingresados en el formulario
        /// </summary>
        /// <returns></returns>
        private List<DetalleVenta> ObtenerDetallesVenta()
        {
            List<DetalleVenta> detalles = new List<DetalleVenta>();
            foreach (DataGridViewRow row in dgvProductosVenta.Rows)
            {
                detalles.Add(new DetalleVenta
                {
                    IdProducto = Convert.ToInt32(row.Cells["IdProducto"].Value),
                    Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                    Subtotal = Convert.ToDecimal(row.Cells["Importe"].Value)
                });
            }
            return detalles;
        }

        /// <summary>
        /// Calcula el total de la venta a partir de los datos ingresados en el formulario
        /// </summary>
        /// <returns></returns>
        private decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvProductosVenta.Rows)
            {
                if (row.Cells["Importe"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Importe"].Value);
                }
            }
            return total;
        }

        /// <summary>
        /// Obtiene el ID del usuario actual
        /// </summary>
        /// <returns></returns>
        private int ObtenerIdUsuarioActual()
        {
            // Lógica para obtener el ID del usuario actual
            return 1; // Reemplaza con tu lógica
        }

        /// <summary>
        /// Limpia el formulario de ventas
        /// </summary>
        private void LimpiarFormulario()
        {
            dgvProductosVenta.Rows.Clear();
            lblTotal.Text = "$0.00";
            totalVenta = 0;
        }

        /// <summary>
        /// Evento que se ejecuta al presionar una tecla en el cuadro de búsqueda de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBuscarProducto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    string codigoBarras = txtBuscarProducto.Text.Trim();
                    if (string.IsNullOrWhiteSpace(codigoBarras))
                    {
                        MessageBox.Show("Por favor, ingresa un código de barras válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Producto producto = new ProductoDAL().ObtenerProductoPorCodigoBarras(codigoBarras);
                    if (producto == null)
                    {
                        MessageBox.Show("El producto no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    AgregarProductoAlDataGridView(producto);
                    txtBuscarProducto.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProductosVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadArticulos_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Actualiza la cantidad total de artículos en la venta
        /// </summary>
        private void ActualizarCantidadArticulos()
        {
            if (tabControlVentas.SelectedTab == null || tabControlVentas.SelectedTab.Controls.Count == 0)
                return;

            DataGridView dgv = tabControlVentas.SelectedTab.Controls[0] as DataGridView;
            if (dgv == null)
                return;

            int cantidadArticulos = dgv.Rows.Cast<DataGridViewRow>().Sum(row => Convert.ToInt32(row.Cells["Cantidad"].Value));

            // Actualizar la cantidad de artículos en algún control (por ejemplo, un Label)
            lblCantidadArticulos.Text = $"Artículos: {cantidadArticulos}";
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormReporteVentas formReporteVentas = new FormReporteVentas();
            formReporteVentas.Owner = this;
            formReporteVentas.Show();
        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            // Crear una nueva pestaña
            TabPage nuevaTab = new TabPage("Venta " + (tabControlVentas.TabCount + 1));

            // Crear un nuevo DataGridView
            DataGridView dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false,
                RowHeadersVisible = false
            };

            // Definir las columnas del DataGridView
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "IdProducto", HeaderText = "IdProducto", DataPropertyName = "IdProducto", Visible = false });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Producto", HeaderText = "Descripción", DataPropertyName = "Descripcion" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Precio", HeaderText = "Precio", DataPropertyName = "PrecioVenta" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cantidad", HeaderText = "Cantidad", DataPropertyName = "Cantidad" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "importe", HeaderText = "Subtotal", DataPropertyName = "Subtotal" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Existencia", HeaderText = "Existencias", DataPropertyName = "Existencias" });

            // Agregar el DataGridView a la pestaña
            nuevaTab.Controls.Add(dgv);

            // Agregar la pestaña al TabControl
            tabControlVentas.TabPages.Add(nuevaTab);

            // Seleccionar la nueva pestaña
            tabControlVentas.SelectedTab = nuevaTab;

        }
    }
}
