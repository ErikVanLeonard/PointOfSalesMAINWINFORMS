using System.Data.SqlClient;
using System.Configuration;


namespace PointOfSales.DAL
{
    public sealed class DatabaseConnection
    {
        // Variable estática para almacenar la única instancia de la clase
        private static DatabaseConnection _instance;
        // Cadena de conexión
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        // Propiedad pública para acceder a la instancia única
        public static DatabaseConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseConnection();
                }
                return _instance;
            }
        }

        // Cadena de conexión a la base de datos
        private readonly string _connectionString;

        // Constructor privado para evitar la creación de instancias desde fuera
        private DatabaseConnection()
        {
            // Configura la cadena de conexión (puedes usar App.config o hardcodearla aquí)
            _connectionString = connectionString;
        }

        // Método para obtener una conexión abierta
        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}
