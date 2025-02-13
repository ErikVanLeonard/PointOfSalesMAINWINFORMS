using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSales.Entities;

namespace PointOfSales.Utilities
{
    public class TicketPrinter
    {
        private PrintDocument printDocument;
        private PrintPreviewDialog previewDialog;
        private DataGridView dataGridView;
        private decimal totalVenta;
        private Venta venta;

        // Constructor que recibe el DataGridView y el total de la venta
        public TicketPrinter(DataGridView dataGridView, decimal totalVenta)
        {

            this.dataGridView = dataGridView ?? throw new ArgumentNullException(nameof(dataGridView));
            this.totalVenta = totalVenta;

            InitializeComponents();



        }

        // Constructor para la nueva funcionalidad (Venta)
        public TicketPrinter(Venta venta)
        {
            this.venta = venta ?? throw new ArgumentNullException(nameof(venta));

            InitializeComponents();
        }

        public void ImprimirTicket()
        {
            try
            {
                ConfigurarTamanoTicket();
                printDocument.Print(); // Imprime directamente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir: " + ex.Message);
            }
        }

        public void MostrarVistaPrevia()
        {
            try
            {
                ConfigurarTamanoTicket();
                previewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar vista previa: " + ex.Message);
            }
        }

        private void InitializeComponents()
        {
            printDocument = new PrintDocument();
            previewDialog = new PrintPreviewDialog();

            // Configurar el evento PrintPage
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Configurar el PrintPreviewDialog
            previewDialog.Document = printDocument;
            previewDialog.Width = 315;
            previewDialog.Height = 800;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font tituloFont = new Font("Arial", 14, FontStyle.Bold);
            Font detalleFont = new Font("Arial", 10, FontStyle.Regular);
            Font totalFont = new Font("Arial", 12, FontStyle.Bold);

            float posY = 20; // Posición inicial en el eje Y

            // Imprimir título del ticket
            g.DrawString("TICKET DE COMPRA", tituloFont, Brushes.Black, new PointF(10, posY));
            posY += 30;

            if (dataGridView != null && dataGridView.Rows.Count > 0)
            {
                // Funcionalidad anterior: Imprimir desde DataGridView
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    string nombre = row.Cells["Nombre"]?.Value?.ToString() ?? "Sin nombre";
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"]?.Value ?? 0);
                    decimal precioUnitario = Convert.ToDecimal(row.Cells["Precio"]?.Value ?? 0);
                    decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"]?.Value ?? 0);

                    string lineaProducto = $"{nombre} ({cantidad}) - {precioUnitario:C2} = {subtotal:C2}";
                    g.DrawString(lineaProducto, detalleFont, Brushes.Black, new PointF(10, posY));
                    posY += 20;
                }
            }
            else if (venta != null && venta.Detalles.Count > 0)
            {
                // Nueva funcionalidad: Imprimir desde Venta
                foreach (var detalle in venta.Detalles)
                {
                    string lineaProducto = $"{detalle.ProductoNombre} ({detalle.Cantidad}) - {detalle.Subtotal:C2}";
                    g.DrawString(lineaProducto, detalleFont, Brushes.Black, new PointF(10, posY));
                    posY += 20;
                }
            }
            else
            {
                // Si no hay datos disponibles
                g.DrawString("No hay productos en la venta.", detalleFont, Brushes.Black, new PointF(10, posY));
                return;
            }

            // Imprimir línea separadora
            g.DrawLine(new Pen(Brushes.Black), 10, posY, 300, posY);
            posY += 20;

            // Imprimir el total de la venta
            decimal total = dataGridView != null ? totalVenta : venta.Total;
            g.DrawString($"TOTAL: {total:C2}", totalFont, Brushes.Black, new PointF(10, posY));
        }


        private void ConfigurarTamanoTicket()
        {
            PaperSize tamañoTicket = new PaperSize("TicketPersonalizado", 315, 800); // 80mm de ancho
            printDocument.DefaultPageSettings.PaperSize = tamañoTicket;
            Margins margenes = new Margins(0, 0, 0, 0); // Sin márgenes
            printDocument.DefaultPageSettings.Margins = margenes;

        }

    }
}
