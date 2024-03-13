﻿using Npgsql;

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
            return @"Host=10.30.0.137;Port=5432;Database=gr631_koivya;Username=gr631_koivya;Password=742516809213@cJ";
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
