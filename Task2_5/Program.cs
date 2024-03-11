namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // получение данных о водителях
            DatabaseRequests.GetDriverQuery();
            Console.WriteLine();
            // добавляем нового водителя в БД
            DatabaseRequests.AddDriverQuery("Денис", "Иванов", DateOnly.Parse("1997.01.12"));
            // получение данных о водителях
            DatabaseRequests.GetDriverQuery();

            // получение данных о типах автомобилей
            DatabaseRequests.GetTypeCarQuery();
            Console.WriteLine();
            // добавляем новый тип автомобиля в БД
            DatabaseRequests.AddTypeCarQuery("Воздушный");
            // получение данных о типах автомобилей
            DatabaseRequests.GetTypeCarQuery();

            // вывод всех категорий прав водителей
            DatabaseRequests.GetRightsCategoryQuery();

            // вывод всех машин
            DatabaseRequests.GetCarQuery();
            // добавление новой машины в БД
            DatabaseRequests.AddCarQuery(3, "KIA Rio", "К710ИМ", 3);
            // вывод всех машин
            DatabaseRequests.GetCarQuery();

            // вывод всех маршрутов
            DatabaseRequests.GetItineraryQuery();
            // добавление нового маршрута в БД
            DatabaseRequests.AddItineraryQuery("Томск-Асино");
            // вывод всех маршрутов
            DatabaseRequests.GetItineraryQuery();

            // вывод всех рейсов
            DatabaseRequests.GetRouteQuery();
            // добавление нового рейса в БД
            DatabaseRequests.AddRouteQuery(4, 1, 6, 26);
            // вывод всех рейсов
            DatabaseRequests.GetRouteQuery();
        }
    }
}
