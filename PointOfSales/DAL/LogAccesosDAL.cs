using System;
using System.Data.SqlClient;
using System.Data;

namespace PointOfSales.DAL
{
    public class LogAccesosDAL
    {
        // Obtener la conexión desde la instancia Singleton
        private SqlConnection GetConnection()
        {
            return DatabaseConnection.Instance.GetConnection();
        }


        // Método para validar credenciales
        public int ValidarCredenciales(string correo, string contraseña)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_ValidarCredenciales", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return (int)reader["Id"]; // Retorna el Id del usuario si las credenciales son válidas
                    }
                    else
                    {
                        throw new Exception("Credenciales incorrectas.");
                    }
                }
            }
        }

        // Método para registrar apertura o cierre de turno
        public void RegistrarLogAcceso(int idUsuario, string operacion)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarLogAcceso", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@Operacion", operacion);

                cmd.ExecuteNonQuery();
            }
        }
    }

}
