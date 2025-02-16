using PointOfSales.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.DAL
{
    public class ProductoDAL
    {
        private SqlConnection GetConnection()
        {
            return DatabaseConnection.Instance.GetConnection();
        }

        /// <summary>
        /// Obtiene un producto por su código de barras.
        /// </summary>
        /// <param name="codigoBarras">Código de barras del producto.</param>
        /// <returns>Objeto Producto si existe, null si no existe.</returns>
        public Producto ObtenerProductoPorCodigoBarras(string codigoBarras)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerProductoPorCodigoBarras", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoBarras", codigoBarras);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Producto
                        {
                            Id = (int)reader["Id"],
                            Nombre = reader["Nombre"].ToString(),
                            Descripcion = reader["Descripcion"]?.ToString(),
                            Precio = (decimal)reader["Precio"],
                            Stock = (int)reader["Stock"],
                            Categoria = reader["Categoria"]?.ToString(),
                            FechaCreacion = reader["FechaCreacion"] as DateTime?,
                            CodigoBarras = reader["CodigoBarras"]?.ToString()
                        };
                    }
                }
            }

            return null; // Retorna null si el producto no existe
        }
    }
}
