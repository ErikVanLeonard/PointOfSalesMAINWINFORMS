using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Utilities
{
    public sealed class LoggerManager
    {
        // Propiedad estática para almacenar la única instancia del logger
        private static readonly Lazy<LoggerManager> _instance = new Lazy<LoggerManager>(() => new LoggerManager());

        // Propiedad pública para acceder a la instancia única
        public static LoggerManager Instance => _instance.Value;

        // Instancia del logger de NLog
        private readonly Logger _logger;

        // Constructor privado para evitar la creación de instancias desde fuera
        private LoggerManager()
        {
            // Configurar NLog (opcional si ya tienes un archivo NLog.config)
            //LogManager.LoadConfiguration("NLog.config"); //DEPRECATED
            LogManager.Setup().LoadConfigurationFromFile("NLog.config");

            // Obtener el logger de NLog
            _logger = LogManager.GetCurrentClassLogger();
        }

        // Métodos para escribir logs
        public void LogInfo(string message)
        {
            _logger.Info(message);
        }

        public void LogDebug(string message)
        {
            _logger.Debug(message);
        }

        public void LogWarn(string message)
        {
            _logger.Warn(message);
        }

        public void LogError(string message, Exception ex = null)
        {
            if (ex != null)
            {
                _logger.Error(ex, message);
            }
            else
            {
                _logger.Error(message);
            }
        }

        public void LogFatal(string message, Exception ex = null)
        {
            if (ex != null)
            {
                _logger.Fatal(ex, message);
            }
            else
            {
                _logger.Fatal(message);
            }
        }

    }
}
