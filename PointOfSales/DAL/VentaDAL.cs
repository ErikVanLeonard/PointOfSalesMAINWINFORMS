using PointOfSales.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PointOfSales.DAL
{
    public class VentaDAL
    {
        private SqlConnection GetConnection()
        {
            return DatabaseConnection.Instance.GetConnection();
        }

        /// <summary>
        /// Registra una nueva venta y actualiza el inventario.
        /// </summary>
        /// <param name="venta">Objeto Venta con los detalles.</param>
        public void RegistrarVenta(Venta venta)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlTransaction transaction = null;

                try
                {
                    transaction = conn.BeginTransaction();

                    // Insertar la venta
                    SqlCommand cmdVenta = new SqlCommand("sp_RegistrarVenta", conn, transaction);
                    cmdVenta.CommandType = CommandType.StoredProcedure;

                    cmdVenta.Parameters.AddWithValue("@Fecha", venta.Fecha);
                    cmdVenta.Parameters.AddWithValue("@Total", venta.Total);
                    cmdVenta.Parameters.AddWithValue("@IdUsuario", venta.IdUsuario);

                    var detallesJson = JsonConvert.SerializeObject(venta.Detalles);
                    cmdVenta.Parameters.AddWithValue("@Detalles", detallesJson);

                    cmdVenta.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction?.Rollback();
                    throw; // Propagar el error al cliente
                }
            }
        }

        /// <summary>
        /// Obtiene todas las ventas registradas.
        /// </summary>
        /// <returns>Lista de objetos Venta.</returns>
        public List<Venta> ObtenerTodasLasVentas()
        {
            List<Venta> ventas = new List<Venta>();

            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerTodasLasVentas", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ventas.Add(new Venta
                        {
                            Id = (int)reader["Id"],
                            Fecha = (DateTime)reader["Fecha"],
                            Total = (decimal)reader["Total"],
                            IdUsuario = (int)reader["IdUsuario"]
                        });
                    }
                }
            }

            return ventas;
        }

        /// <summary>
        /// Obtiene la última venta registrada con sus detalles.
        /// </summary>
        /// <returns>Objeto Venta con los detalles.</returns>
        public Venta ObtenerUltimaVenta()
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerUltimaVenta", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                Venta venta = null;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Leer el primer conjunto de resultados (datos de la venta)
                    if (reader.Read())
                    {
                        venta = new Venta
                        {
                            Id = (int)reader["Id"],
                            Fecha = (DateTime)reader["Fecha"],
                            Total = (decimal)reader["Total"],
                            IdUsuario = (int)reader["IdUsuario"],
                            Detalles = new List<DetalleVenta>()
                        };
                    }

                    // Avanzar al segundo conjunto de resultados (detalles de la venta)
                    if (reader.NextResult())
                    {
                        while (reader.Read())
                        {
                            venta.Detalles.Add(new DetalleVenta
                            {
                                IdProducto = (int)reader["IdProducto"],
                                ProductoNombre = reader["ProductoNombre"].ToString(), // Nombre del producto
                                Cantidad = (int)reader["Cantidad"],
                                Subtotal = (decimal)reader["Subtotal"]
                            });
                        }
                    }
                }

                return venta;
            }
        }


    }
}
