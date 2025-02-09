// BLL/UsuarioBLL.cs
using System;
using BCrypt.Net;
using PointOfSales.DAL;

namespace PointOfSales.BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();

        /// <summary>
        /// Registra un nuevo usuario en el sistema.
        /// </summary>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="correo">Correo electrónico del usuario (debe ser único).</param>
        /// <param name="contraseña">Contraseña del usuario (se cifrará antes de almacenarla).</param>
        /// <param name="rol">Rol del usuario (Administrador o Cajero).</param>
        public void RegistrarUsuario(string nombre, string correo, string contraseña, string rol)
        {
            // Validar que el correo no esté vacío
            if (string.IsNullOrWhiteSpace(correo))
            {
                throw new ArgumentException("El correo no puede estar vacío.");
            }

            // Validar que la contraseña no esté vacía
            if (string.IsNullOrWhiteSpace(contraseña))
            {
                throw new ArgumentException("La contraseña no puede estar vacía.");
            }

            // Cifrar la contraseña usando BCrypt
            string contraseñaCifrada = BCrypt.Net.BCrypt.HashPassword(contraseña);

            // Llamar al método DAL para insertar el usuario
            usuarioDAL.RegistrarUsuario(nombre, correo, contraseñaCifrada, rol);
        }

        /// <summary>
        /// Valida las credenciales de un usuario durante el inicio de sesión.
        /// </summary>
        /// <param name="correo">Correo electrónico del usuario.</param>
        /// <param name="contraseña">Contraseña proporcionada por el usuario.</param>
        /// <returns>El Id del usuario si las credenciales son válidas.</returns>
        public int ValidarCredenciales(string correo, string contraseña)
        {
            // Obtener el usuario desde la base de datos
            var usuario = usuarioDAL.ObtenerUsuarioPorCorreo(correo);

            if (usuario == null)
            {
                throw new Exception("El correo no está registrado.");
            }

            // Verificar la contraseña usando BCrypt
            if (!BCrypt.Net.BCrypt.Verify(contraseña, usuario.Contraseña))
            {
                throw new Exception("Contraseña incorrecta.");
            }

            return usuario.Id; // Retorna el Id del usuario si las credenciales son válidas
        }
    }
}
