﻿using System;
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
using PointOfSales.Entities;

namespace PointOfSales.UI
{
    public partial class FormLogin : Form
    {
        public static Usuario UsuarioActual { get; private set; } // Propiedad estática para almacenar el usuario actual
        private UsuarioBLL usuarioBLL = new UsuarioBLL();

        // Propiedad para almacenar el resultado del inicio de sesión
        public bool LoginExitoso { get; private set; } = false;
        public int idUsuarioActual { get; private set; } = 0;

        // Constructor que acepta una instancia de LogAccesosBLL
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores ingresados por el usuario
                string correo = txtUsuario.Text.Trim();
                string contraseña = txtContraseña.Text.Trim();

                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
                {
                    MessageBox.Show("Por favor, ingrese su correo y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar las credenciales del usuario
                int idUsuario = usuarioBLL.ValidarCredenciales(correo, contraseña);

                // Si las credenciales son válidas, marcar el inicio de sesión como exitoso
                LoginExitoso = true;
                idUsuarioActual = idUsuario;



                MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el formulario de inicio de sesión
                this.Close();
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si las credenciales son incorrectas
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            Close();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores ingresados por el usuario
                string nombre = "DEMO INSERTADO2";
                string correo = "demo@insertado2.com";
                string contraseña = "Pass151297";
                string confirmarContraseña = "Pass151297";
                string rol = "Administrador";

                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("Por favor, ingresa un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(correo))
                {
                    MessageBox.Show("Por favor, ingresa un correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(contraseña))
                {
                    MessageBox.Show("Por favor, ingresa una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (contraseña != confirmarContraseña)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Registrar el usuario usando la capa BLL
                usuarioBLL.RegistrarUsuario(nombre, correo, contraseña, rol);

                // Mostrar mensaje de éxito
                MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre algún problema
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
    

