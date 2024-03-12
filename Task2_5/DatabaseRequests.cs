using Npgsql;

namespace Task2_5
{
    // содержит методы для отправки запросов
    public static class DatabaseRequests
    {
        // получение списка типов машин, выводит в консоль список типов машин
        public static void GetTypeCarQuery()
        {
            var querySql = "SELECT * FROM type_car";

            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Id: {reader[0]} Название: {reader[1]}");
            }
        }

        // отправляет запрос на добавление типа машины
        public static void AddTypeCarQuery(string name)
        {
            var querySql = $"INSERT INTO type_car(name) VALUES ('{name}')";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            cmd.ExecuteNonQuery();
        }

        // отправляет запрос на добавление водителей
        public static void AddDriverQuery(string firstName, string lastName, DateOnly birthdate)
        {
            var querySql =
                $"INSERT INTO driver(first_name, last_name, birthdate) VALUES ('{firstName}', '{lastName}', '{birthdate}')";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            cmd.ExecuteNonQuery();
        }

        // отправляет запрос на получение списка водителей
        public static void GetDriverQuery()
        {
            var querySql = "SELECT * FROM driver";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Id{reader[0]} Имя: {reader[1]} Фамилия: {reader[2]} Дата рождения: {reader[3]}");
            }
        }

        // отправляет запрос на добавление категорий прав
        public static void AddRightsCategoryQuery(string name)
        {
            var querySql = $"INSERT INTO rights_category(name) VALUES ('{name}')";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            cmd.ExecuteNonQuery();
        }

        // отправляет запрос на получение категории прав водителя
        public static void GetRightsCategoryQuery(int driver)
        {
            var querySql = $"SELECT driver.first_name, driver.last_name, rights_category.name " +
                           "FROM driver_rights_category " +
                           "INNER JOIN driver ON driver_rights_category.id_driver = driver.id " +
                           "INNER JOIN rights_category ON rights_category.id = driver_rights_category.id_rights_category " +
                           $"WHERE dr.id = {driver};";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Имя: {reader[0]} Фамилия: {reader[1]} Категория прав: {reader[2]}");
            }
        }

        // отправляет запрос на получение всех прав водителей
        public static void GetRightsCategoryQuery()
        {
            var querySql = $"SELECT driver.first_name, driver.last_name, rights_category.name " +
                           "FROM driver_rights_category " +
                           "INNER JOIN driver ON driver_rights_category.id_driver = driver.id " +
                           "INNER JOIN rights_category ON rights_category.id = driver_rights_category.id_rights_category;";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Имя: {reader[0]} Фамилия: {reader[1]} Категория прав: {reader[2]}");
            }
        }

        // отправляет запрос на добавление машин
        public static void AddCarQuery(int idTypeCar, string name, string stateNumber, int numberPassengers)
        {
            var querySql =
                $"INSERT INTO car(id_type_car, name, state_number, number_passengers) VALUES ({idTypeCar}, '{name}', '{stateNumber}', {numberPassengers});";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            cmd.ExecuteNonQuery();
        }

        // отправляет запрос на получение всех машин
        public static void GetCarQuery()
        {
            var querySql =
                $"SELECT car.id, type_car.name AS type_car, car.name, car.state_number, car.number_passengers " +
                "FROM car " +
                "INNER JOIN type_car ON car.id_type_car = type_car.id;";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(
                    $"Id: {reader[0]} Тип машины: {reader[1]} Название: {reader[2]} Гос. номер: {reader[3]} Кол-во пассажиров: {reader[4]};");
            }
        }

        // отправляет запрос на добавление маршрута
        public static void AddItineraryQuery(string name)
        {
            var querySql = $"INSERT INTO itinerary(name) VALUES ('{name}');";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            cmd.ExecuteNonQuery();
        }

        // отправляет запрос на получение маршрутов
        public static void GetItineraryQuery()
        {
            var querySql = $"SELECT * FROM itinerary;";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"Id: {reader[0]} Название: {reader[1]};");
            }
        }

        // отправляет запрос на добавление рейса
        public static void AddRouteQuery(int IdDriver, int IdCar, int IdItinerary, int NumberPassengers)
        {
            var querySql =
                $"INSERT INTO route(id_driver, id_car, id_itinerary, number_passengers) VALUES ({IdDriver}, {IdCar}, {IdItinerary}, {NumberPassengers});";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            cmd.ExecuteNonQuery();
        }

        // отправляет запрос на получение всех рейсов
        public static void GetRouteQuery()
        {
            var querySql =
                $"SELECT route.id, driver.first_name, driver.last_name, type_car.name AS type_car, car.name, car.state_number, itinerary.name, route.number_passengers " +
                "FROM route " +
                "INNER JOIN driver ON route.id_driver = driver.id " +
                "INNER JOIN car ON route.id_car = car.id " +
                "INNER JOIN type_car ON car.id_type_car = type_car.id " +
                "INNER JOIN itinerary ON route.id_itinerary = itinerary.id;";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(
                    $"Id: {reader[0]} Фамилия: {reader[1]} Имя: {reader[2]} Тип машины: {reader[3]} Название: {reader[4]} Гос. номер: {reader[5]} Маршрут: {reader[6]} Кол-во пассажиров: {reader[7]}");
            }
        }

        // отправляет запрос на получение определённого рейса
        public static void GetRouteQuery(int idRoute)
        {
            var querySql =
                $"SELECT route.id, driver.first_name, driver.last_name, type_car.name AS type_car, car.name, car.state_number, itinerary.name, route.number_passengers " +
                "FROM route " +
                "INNER JOIN driver ON route.id_driver = driver.id " +
                "INNER JOIN car ON route.id_car = car.id " +
                "INNER JOIN type_car ON car.id_type_car = type_car.id " +
                "INNER JOIN itinerary ON route.id_itinerary = itinerary.id " +
                $"WHERE route.id = {idRoute};";
            using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(
                    $"Id: {reader[0]} Фамилия: {reader[1]} Имя: {reader[2]} Тип машины: {reader[3]} Название: {reader[4]} Гос. номер: {reader[5]} Маршрут: {reader[6]} Кол-во пассажиров: {reader[7]}");
            }
        }
    }
}
