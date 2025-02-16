using System;
using System.Windows.Forms;

namespace PointOfSales.UI
{
    public partial class FormPago : Form
    {
        public FormPago()
        {
            InitializeComponent();
        }

        public decimal Total { get; private set; }
        public decimal CantidadPagada { get; private set; }
        public decimal Cambio { get; private set; }

        public FormPago(decimal total)
        {
            InitializeComponent();
            Total = total;
            lblTotal.Text = $"{total}";
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormPago_Load(object sender, EventArgs e)
        {
            txtCantidadPagada.Text = Total.ToString();
            decimal.TryParse(txtCantidadPagada.Text, out decimal cantidadPagada);
            CantidadPagada = cantidadPagada;
            Cambio = cantidadPagada - Total;
            lblCambio.Text = $"{Cambio}";
            btnAceptar.Enabled = true;
        }

        private void txtCantidadPagada_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es "Enter"
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Evitar que el sonido de "beep" se reproduzca
                e.Handled = true;

                // Validar la cantidad ingresada
                if (decimal.TryParse(txtCantidadPagada.Text, out decimal cantidadPagada) && cantidadPagada >= Total)
                {
                    CantidadPagada = cantidadPagada;
                    Cambio = cantidadPagada - Total;
                    lblCambio.Text = $"{Cambio}";
                    btnAceptar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada no es válida o insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
