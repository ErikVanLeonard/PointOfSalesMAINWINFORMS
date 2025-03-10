using PointOfSales.BLL;
using PointOfSales.Entities.Reportes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using iText.IO.Image;
using PointOfSales.Utilities;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Drawing;

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
                // Actualizar el total de ventas en la etiqueta
                ActualizarTotalVentas();

                //Agregamos la imagen al picture box
                //pictureBox1.Image = new Bitmap(CrearGrafica());
                // Ajustar el tamaño del PictureBox para mostrar la imagen correctamente
                //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar el cuadro de diálogo para seleccionar la carpeta
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Selecciona la carpeta donde deseas guardar el archivo PDF";
                    folderDialog.RootFolder = Environment.SpecialFolder.Desktop; // Carpeta inicial

                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Obtener la ruta seleccionada por el usuario
                        string carpetaSeleccionada = folderDialog.SelectedPath;

                        // Generar un nombre único para el archivo
                        string nombreArchivo = $"ReporteVentas_{DateTime.Now:yyyyMMddHHmmss}.pdf";
                        string rutaArchivo = Path.Combine(carpetaSeleccionada, nombreArchivo);

                        // Crear el archivo PDF
                        using (PdfWriter writer = new PdfWriter(rutaArchivo))
                        {
                            using (PdfDocument pdf = new PdfDocument(writer))
                            {
                                Document document = new Document(pdf);

                                // Encabezado
                                Paragraph encabezado = new Paragraph("REPORTE DE VENTAS")
                                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                                    .SetFontSize(20);
                                document.Add(encabezado);

                                // Agregar el logotipo en la esquina superior izquierda
                                string rutaLogo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "logo.png"); // Ruta de la imagen
                                if (File.Exists(rutaLogo))
                                {
                                    ImageData logoData = ImageDataFactory.Create(rutaLogo);
                                    iText.Layout.Element.Image logo = new iText.Layout.Element.Image(logoData)
                                        .SetWidth(250) // Ancho de la imagen
                                        .SetHeight(50) // Alto de la imagen
                                        .SetFixedPosition(10, pdf.GetDefaultPageSize().GetHeight() - 120); // Posición (x, y)

                                    document.Add(logo);
                                }

                                // Información en la parte superior derecha
                                string fechaImpresion = FechaHelper.FormatearFechaLarga(DateTime.Now.ToString("dd/MM/yyyy"));
                                string usuario = "Usuario: Administrador" ; // Reemplaza con tu lógica
                                string rangoFechas = $"Reporte del: {FechaHelper.FormatearFechaLarga(dtpFechaInicial.Value.ToShortDateString())} al { FechaHelper.FormatearFechaLarga(dtpFechaFinal.Value.ToShortDateString())}";

                                // Crear la gráfica
                                string rutaImagenGrafica = CrearGrafica();

                                Paragraph infoSuperiorDerecha = new Paragraph($"Fecha de impresion:{fechaImpresion} {DateTime.Now.ToString("HH:mm:ss")}\n{usuario}\n{rangoFechas}")
                                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT)
                                    .SetFontSize(10);
                                document.Add(infoSuperiorDerecha);

                                // Agregar un título al PDF
                                Paragraph titulo = new Paragraph("Reporte de Ventas")
                                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                                    .SetFontSize(18);
                                document.Add(titulo);

                                // Crear una tabla con el mismo número de columnas que el DataGridView
                                int columnCount = dgvReporteVentas.Columns.Count;
                                Table table = new Table(columnCount).UseAllAvailableWidth();

                                // Agregar encabezados de columna
                                foreach (DataGridViewColumn column in dgvReporteVentas.Columns)
                                {
                                    table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)));
                                }

                                // Agregar filas de datos
                                foreach (DataGridViewRow row in dgvReporteVentas.Rows)
                                {
                                    if (!row.IsNewRow) // Ignorar la fila vacía al final
                                    {
                                        for (int i = 0; i < columnCount; i++)
                                        {
                                            string cellValue = row.Cells[i].Value?.ToString() ?? string.Empty;
                                            table.AddCell(new Cell().Add(new Paragraph(cellValue)));
                                        }
                                    }
                                }

                                // Agregar la tabla al documento
                                document.Add(table);

                                // Agregar el total de ventas al final del PDF
                                Paragraph totalVentas = new Paragraph($"Total Ventas: {lblTotalVentas.Text}")
                                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT)
                                    .SetFontSize(14);
                                document.Add(totalVentas);

                                // Forzar el renderizado del documento para calcular correctamente las áreas ocupadas
                                document.Flush();

                                var occupiedArea = totalVentas.GetRenderer().GetOccupiedArea();
                                if (occupiedArea != null)
                                {
                                    // Obtener las coordenadas X e Y desde el área ocupada
                                    float x = occupiedArea.GetBBox().GetX();
                                    float y = occupiedArea.GetBBox().GetY();

                                    // Ajustar la posición para colocar la imagen debajo de totalVentas
                                    float margenInferior = 20; // Margen entre totalVentas y la imagen
                                    float posicionYImagen = y - margenInferior - 300; // Altura de la imagen (300)

                                    // Agregar la gráfica al PDF
                                    if (File.Exists(rutaImagenGrafica))
                                    {
                                        ImageData graficaData = ImageDataFactory.Create(rutaImagenGrafica);
                                        iText.Layout.Element.Image grafica = new iText.Layout.Element.Image(graficaData)
                                            .SetWidth(400)
                                            .SetHeight(300)
                                            .SetFixedPosition(x, posicionYImagen); // Posición calculada relativa a totalVentas
                                        document.Add(grafica);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo calcular el área ocupada por 'totalVentas'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                // Pie de página
                                Paragraph piePagina = new Paragraph("---LANSKAPE PUNTO DE VENTA | ESTA USANDO UNA VERSIÓN GRATUITA. | LANSKAPE.COM---")
                                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                                    .SetFontSize(10)
                                    ;
                                document.Add(piePagina);
                            }
                        }

                        // Mostrar mensaje de éxito
                        MessageBox.Show($"El reporte ha sido exportado exitosamente.\nRuta: {rutaArchivo}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTotalVentas_Click(object sender, EventArgs e)
        {

        }

        private string CrearGrafica()
        {
            // Crear un modelo de gráfica
            var plotModel = new PlotModel { Title = "Ventas por Fecha" };

            // Crear una serie de datos
            var series = new BarSeries
            {
                Title = "Total Ventas",
                StrokeColor = OxyColors.Black,
                FillColor = OxyColors.Blue
            };

            // Obtener datos del DataGridView
            foreach (DataGridViewRow row in dgvReporteVentas.Rows)
            {
                if (!row.IsNewRow && row.Cells["Fecha"].Value != null && row.Cells["Total"].Value != null)
                {
                    DateTime fecha = Convert.ToDateTime(row.Cells["Fecha"].Value);
                    decimal total = Convert.ToDecimal(row.Cells["Total"].Value);
                    series.Items.Add(new BarItem { Value = (double)total });
                }
            }

            // Agregar la serie al modelo
            plotModel.Series.Add(series);

            // Guardar la gráfica como una imagen temporal
            string rutaImagen = Path.Combine(Path.GetTempPath(), "grafica_ventas.png");

            // Verificar si la imagen ya existe y eliminarla si es necesario
            if (File.Exists(rutaImagen))
            {
                File.Delete(rutaImagen); // Eliminar la imagen existente
            }

            // Exportar la nueva gráfica
            var exporter = new OxyPlot.WindowsForms.PngExporter { Width = 800, Height = 600 };
            using (var stream = File.Create(rutaImagen))
            {
                exporter.Export(plotModel, stream);
            }

            return rutaImagen;
        }


    }
}
