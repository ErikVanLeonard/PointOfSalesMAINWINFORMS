using PointOfSales.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.BLL
{
    public class LogAccesosBLL
    {
        private LogAccesosDAL logAccesosDAL = new LogAccesosDAL();

        // Método para validar credenciales
        public int ValidarCredenciales(string correo, string contraseña)
        {
            return logAccesosDAL.ValidarCredenciales(correo, contraseña);
        }

        // Método para registrar apertura o cierre de turno
        public void RegistrarLogAcceso(int idUsuario, string operacion)
        {
            if (operacion != "Apertura" && operacion != "Cierre")
            {
                throw new ArgumentException("La operación debe ser 'Apertura' o 'Cierre'.");
            }

            logAccesosDAL.RegistrarLogAcceso(idUsuario, operacion);
        }
    }

}
