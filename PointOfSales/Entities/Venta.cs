using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Entities
{

    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int IdUsuario { get; set; } // Usuario que realizó la venta
        public long IdCliente { get; set; } = 0; // Cliente (por defecto 0)
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();
    }

    public class DetalleVenta
    {
        public int Id { get; set; }
        public int IdVenta { get; set; } // ID de la venta asociada
        public int IdProducto { get; set; } // ID del producto
        public string ProductoNombre { get; set; } // Nombre del producto (opcional para reportes)
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }

}
