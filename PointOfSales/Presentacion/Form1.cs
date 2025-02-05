using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using PointOfSales.Datos;
using PointOfSales.Negocio;

namespace PointOfSales
{
    public partial class FormMain : Form
    {

        // timer que controla el reloj principal
        private Timer timer;

        // instancia de impresión de ticket principal de venta
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog previewDialog = new PrintPreviewDialog();

        public FormMain()
        {
            InitializeComponent();

            // Configurar el evento PrintPage para definir el contenido del ticket.
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            // Configurar el PrintPreviewDialog
            previewDialog.Document = printDocument;
            previewDialog.Width = 315;
            previewDialog.Height = 800;

            // Configurar el temporizador
            timer = new Timer();
            timer.Interval = 1000; // 1000 ms = 1 segundo
            timer.Tick += new EventHandler(UpdateClock); // Asigna el evento Tick del temporizador
            timer.Start();

            this.KeyPreview = true; // Permite al formulario capturar eventos de teclado
            this.KeyDown += new KeyEventHandler(FormMain_KeyDown); // Asignar el evento KeyDown


            

        }



        // Método para configurar y enviar el ticket a la impresora predeterminada.
        private void ImprimirTicket()
        {
            try
            {
                // Configurar el tamaño del ticket para impresoras térmicas
                ConfigurarTamanoTicket();

                // Imprimir el ticket
                //printDocument.PrinterSettings.PrinterName = "Nombre de la Impresora"; // O usar la predeterminada
                printDocument.Print(); // Llamar a imprimir directamente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir: " + ex.Message);
            }
        }

        // Método que define cómo se dibuja el ticket en la página.
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            ConfigurarTamanoTicket();

            Graphics g = e.Graphics;

            // Configurar el contenido del ticket (texto y formato).
            Font font = new Font("Arial", 10, FontStyle.Regular);
            float posY = 20;

            // Imprimir título del ticket
            g.DrawString("TICKET DE COMPRA", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(10, posY));
            posY += 30;

            // Imprimir detalles de compra
            g.DrawString("Producto A - $50.00", font, Brushes.Black, new PointF(10, posY));
            posY += 20;
            g.DrawString("Producto B - $30.00", font, Brushes.Black, new PointF(10, posY));
            posY += 20;

            // Imprimir totales
            g.DrawString("Total: $80.00", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(10, posY));
        }

        //configuración del ticket de impresion tamaño
        private void ConfigurarTamanoTicket()
        {
            // Crear un tamaño de papel personalizado para el ticket (por ejemplo, 80 mm de ancho por 200 mm de largo)
            PaperSize tamañoTicket = new PaperSize("TicketPersonalizado", 315, 800); // 80mm de ancho (315/100 pulgadas)

            // Asignar el tamaño personalizado a las configuraciones de página
            printDocument.DefaultPageSettings.PaperSize = tamañoTicket;

            // Si es necesario ajustar los márgenes (opcional)
            Margins margenes = new Margins(0, 0, 0, 0); // Sin márgenes
            printDocument.DefaultPageSettings.Margins = margenes;
        }


        // Evento que actualiza la hora en el Label
        private void UpdateClock(object sender, EventArgs e)
        {
            labelReloj.Text = DateTime.Now.ToString("hh:mm:ss tt"); // Mostrar la hora en formato de 24 horas
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateClock(sender, e);

            // Establecer el texto inicial de la barra de estado
            toolStripStatusLabel1.Text = "CONECTADO";
            toolStripProgressBar1.Value = 100;
            toolStripProgressBar1.Visible = false;

            
        }

       




        private void labelReloj_Click(object sender, EventArgs e)
        {

        }


        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {

            // Verifica si el TabControl tiene pestañas
            if (tabControl1.TabPages.Count == 0) return;

            // Cambiar de pestaña según la tecla presionada
            switch (e.KeyCode)
            {
                case Keys.F1: // Si presiona F2, cambiar a la primera pestaña (índice 0)
                    tabControl1.SelectedIndex = 0;
                    break;
                case Keys.F2: // Si presiona F3, cambiar a la segunda pestaña (índice 1)
                    if (tabControl1.TabPages.Count > 1)
                        tabControl1.SelectedIndex = 1;
                    break;
                case Keys.F3: // Si presiona F4, cambiar a la tercera pestaña (índice 2)
                    if (tabControl1.TabPages.Count > 2)
                        tabControl1.SelectedIndex = 2;
                    break;
                case Keys.F4: // Si presiona F4, cambiar a la tercera pestaña (índice 2)
                    if (tabControl1.TabPages.Count > 3)
                        tabControl1.SelectedIndex = 3;
                    break;
                case Keys.F5: // Si presiona F5, cambiar a la tercera pestaña (índice 2)
                    if (tabControl1.TabPages.Count > 4)
                        tabControl1.SelectedIndex = 4;
                    break;
                // Puedes agregar más teclas según la cantidad de pestañas
                default:
                    break;
            }
        }

        // Abrir turno
        private void abrirTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {


            facturaciónToolStripMenuItem.Visible = true;
            archivoToolStripMenuItem.Visible = true;
            reportesToolStripMenuItem.Visible = true;
            corteDeCajaToolStripMenuItem.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            abrirTurnoToolStripMenuItem.Visible = false;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnImprimirTicket_Click(object sender, EventArgs e)
        {
            
            //Mostrar la vista previa del ticket antes de imprimir
            previewDialog.ShowDialog();
        }

        private void btnCobrarVenta_Click(object sender, EventArgs e)
        {
            ImprimirTicket();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
