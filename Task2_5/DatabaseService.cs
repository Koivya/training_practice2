using Npgsql;

namespace Task2_5
{
    // подключение и соединение с БД
    public static class DatabaseService
    {
        // хранит открытое соединение с БД
        private static NpgsqlConnection? _connection;

        // возвращает строку подключения к БД
        private static string GetConnectionString()  
        {
            return @"Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=qwerty";
        }
        
        // проверяет, есть ли уже открытое соединение с БД, если нет, то открывает соединение с БД
        public static NpgsqlConnection GetSqlConnection() 
        {
            if(_connection == null)
            {
                _connection = new NpgsqlConnection(GetConnectionString());
                _connection.Open();
            }

            return _connection;
        }
    }
}
