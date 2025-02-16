using PointOfSales.DAL;
using PointOfSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.BLL
{
    public class ProductoBLL
    {
        private ProductoDAL productoDAL = new ProductoDAL();

        /// <summary>
        /// Obtiene un producto por su código de barras.
        /// </summary>
        /// <param name="codigoBarras">Código de barras del producto.</param>
        /// <returns>Objeto Producto si existe,  null si no existe.</returns>
        public Producto ObtenerProductoPorCodigoBarras(string codigoBarras)
        {
            var producto = productoDAL.ObtenerProductoPorCodigoBarras(codigoBarras);

            if (producto == null)
            {
                throw new Exception("El producto no existe.");
            }

            if (producto.Stock <= 0)
            {
                throw new Exception("No hay suficiente stock disponible.");
            }

            return producto;
        }

    }
}
