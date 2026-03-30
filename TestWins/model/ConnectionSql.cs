namespace TestWins.Model;

//dotnet add package MySql.Data
// dotnet add package MySql.Data
using MySql.Data.MySqlClient;

public class ConnectionSql
{
    private readonly string _connectionString = "server=localhost;database=student;uid=root;pwd=root";
        private MySqlConnection _conn;
    private MySqlConnection _conn;

    public MySqlConnection connectSql()
    {
        _conn = new MySqlConnection(_connectionString);

        Console.WriteLine(_conn == null ? "Datbase Connection Failed" : "Database connection successful");
        try
        {
            _conn.Open();
            Console.WriteLine("Database connection successful");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Database connection failed: " + ex.Message);
        }
return _conn;
    }

        return _conn;
    public void closeSql()
    {
        if (_conn != null && _conn.State == System.Data.ConnectionState.Open)
        {
            _conn.Close();
            Console.WriteLine("Database connection closed");
        }
    }
}
}
}
