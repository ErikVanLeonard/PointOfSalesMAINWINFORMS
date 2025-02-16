using PointOfSales.DAL;
using PointOfSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.BLL
{
    public class VentaBLL
    {
        private VentaDAL ventaDAL = new VentaDAL();

        /// <summary>
        /// Registra una nueva venta.
        /// </summary>
        /// <param name="venta">Objeto Venta con los detalles.</param>
        public void RegistrarVenta(Venta venta)
        {
            if (venta.Detalles == null || venta.Detalles.Count == 0)
            {
                throw new ArgumentException("Debe proporcionar al menos un detalle de venta.");
            }

            foreach (var detalle in venta.Detalles)
            {
                if (detalle.Cantidad <= 0)
                {
                    throw new ArgumentException("La cantidad debe ser mayor que cero.");
                }
            }

            ventaDAL.RegistrarVenta(venta);
        }

        /// <summary>
        /// Obtiene todas las ventas registradas.
        /// </summary>
        /// <returns>Lista de objetos Venta.</returns>
        public List<Venta> ObtenerTodasLasVentas()
        {
            return ventaDAL.ObtenerTodasLasVentas();
        }

        /// <summary>
        /// Obtiene la última venta registrada con sus detalles.
        /// </summary>
        /// <returns>Objeto Venta con los detalles.</returns>
        public Venta ObtenerUltimaVenta()
        {
            return ventaDAL.ObtenerUltimaVenta();
        }

        public List<Venta> ObtenerVentasFiltradas(DateTime fechaInicial, DateTime fechaFinal, int? idUsuario, int? idCliente)
        {
            return ventaDAL.ObtenerVentasFiltradas(fechaInicial, fechaFinal, idUsuario, idCliente);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return ventaDAL.ObtenerUsuarios();
        }

        public List<Cliente> ObtenerClientes()
        {
            return ventaDAL.ObtenerClientes();
        }

    }
}
