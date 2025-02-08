using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSales.BLL;
using PointOfSales.DAL;

namespace PointOfSales.UI
{
    public partial class FormLogin : Form
    {
        //instacia de clase
        private LogAccesosBLL logAccessosBLL;
        // Propiedad para almacenar el resultado del inicio de sesión
        public bool LoginExitoso { get; private set; } = false;

        // Constructor que acepta una instancia de LogAccesosBLL
        public FormLogin(LogAccesosBLL logAccesosBLL)
        {
            InitializeComponent();
            // inicializamos la instancia de clase
            logAccessosBLL = new LogAccesosBLL();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener credenciales del usuario
                string correo = txtUsuario.Text.Trim();
                string contraseña = txtContraseña.Text.Trim();

                // Validar credenciales
                int idUsuario = logAccessosBLL.ValidarCredenciales(correo, contraseña);

                // Registrar apertura de turno
                logAccessosBLL.RegistrarLogAcceso(idUsuario, "Apertura");

                MessageBox.Show("Turno abierto correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Indicar que el inicio de sesión fue exitoso
                LoginExitoso = true;

                // Cerrar el formulario de inicio de sesión
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            Close();
        }
    }

}
    

