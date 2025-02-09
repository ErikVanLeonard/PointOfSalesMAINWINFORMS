using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSales.BLL;
using PointOfSales.Entities;

namespace PointOfSales.DAL
{
    public class UsuarioDAL
    {
        // Obtener la conexión desde la instancia Singleton
        private SqlConnection GetConnection()
        {
            return DatabaseConnection.Instance.GetConnection();
        }

        /// <summary>
        /// Registra un nuevo usuario en la base de datos.
        /// </summary>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="correo">Correo electrónico del usuario (debe ser único).</param>
        /// <param name="contraseñaCifrada">Contraseña cifrada del usuario.</param>
        /// <param name="rol">Rol del usuario (Administrador o Cajero).</param>
        public void RegistrarUsuario(string nombre, string correo, string contraseñaCifrada, string rol)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contraseña", contraseñaCifrada);
                cmd.Parameters.AddWithValue("@Rol", rol);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        /// <summary>
        /// Obtiene un usuario por su correo electrónico.
        /// </summary>
        /// <param name="correo">Correo electrónico del usuario.</param>
        /// <returns>Un objeto Usuario si existe, o null si no existe.</returns>
        public Usuario ObtenerUsuarioPorCorreo(string correo)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerUsuarioPorCorreo", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Correo", correo);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        conn.Close();

                        return new Usuario
                        {
                            Id = (int)reader["Id"],
                            Nombre = reader["Nombre"].ToString(),
                            Correo = reader["Correo"].ToString(),
                            Contraseña = reader["Contraseña"].ToString(),
                            Rol = reader["Rol"].ToString()
                        };
                    }
                }
            }

            return null; // Retorna null si el usuario no existe
        }

        /// <summary>
        /// Actualiza la contraseña de un usuario existente.
        /// </summary>
        /// <param name="idUsuario">Id del usuario.</param>
        /// <param name="nuevaContraseñaCifrada">Nueva contraseña cifrada.</param>
        public void ActualizarContraseña(int idUsuario, string nuevaContraseñaCifrada)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarContraseña", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", idUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", nuevaContraseñaCifrada);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        /// <summary>
        /// Elimina un usuario por su Id.
        /// </summary>
        /// <param name="idUsuario">Id del usuario a eliminar.</param>
        public void EliminarUsuario(int idUsuario)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarUsuario", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", idUsuario);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
