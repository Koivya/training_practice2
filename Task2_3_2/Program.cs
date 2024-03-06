namespace Task2_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker programmer = new Worker("Алексей", "Петров", 2500, 19);

            Console.WriteLine("\nИнформация о рабочем:");
            Console.WriteLine($"Имя: {programmer.Name}");
            Console.WriteLine($"Фамилия: {programmer.Surname}");
            Console.WriteLine($"Ставка: {programmer.Rate}");
            Console.WriteLine($"Количество отработанных дней: {programmer.Days}\n");
        }
    }
}
