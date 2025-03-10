using NodaTime.Text;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Utilities
{
    public class FechaHelper
    {
        /// <summary>
        /// Convierte una fecha en formato dd/MM/yyyy a una fecha larga en español de México (es-MX).
        /// </summary>
        /// <param name="fechaEntrada">Fecha en formato dd/MM/yyyy.</param>
        /// <returns>Fecha larga en formato "es-MX" (ejemplo: "lunes, 15 de febrero de 2025").</returns>
        public static string FormatearFechaLarga(string fechaEntrada)
        {
            try
            {
                // Definir el patrón de entrada (dd/MM/yyyy)
                LocalDatePattern patronEntrada = LocalDatePattern.CreateWithInvariantCulture("dd/MM/yyyy");

                // Parsear la fecha de entrada
                ParseResult<LocalDate> resultadoParseo = patronEntrada.Parse(fechaEntrada);

                if (!resultadoParseo.Success)
                {
                    throw new FormatException("La fecha no tiene el formato correcto (dd/MM/yyyy).");
                }

                // Obtener la fecha parseada
                LocalDate fecha = resultadoParseo.Value;

                // Convertir la fecha a formato largo (es-MX)
                string fechaLarga = fecha.ToString("D", CultureInfo.GetCultureInfo("es-MX"));

                return fechaLarga;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al formatear la fecha: {ex.Message}");
            }
        }
    }
}
