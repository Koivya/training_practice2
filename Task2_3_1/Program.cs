namespace Task2_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker programmer = new Worker("Алексей", "Петров", 2500, 19);

            Worker electrician = new Worker("Владислав", "Ельцин", 3000, 20);

            Console.WriteLine("\nИнформация о программисте:");
            Console.WriteLine($"Имя: {programmer.name}");
            Console.WriteLine($"Фамилия: {programmer.surname}");
            Console.WriteLine($"Ставка: {programmer.rate}");
            Console.WriteLine($"Количество отработанных дней: {programmer.days}");
            Console.WriteLine($"Зарплата программиста = {programmer.GetSalary()}\n");

            Console.WriteLine("\nИнформация о электрике:");
            Console.WriteLine($"Имя: {electrician.name}");
            Console.WriteLine($"Фамилия: {electrician.surname}");
            Console.WriteLine($"Ставка: {electrician.rate}");
            Console.WriteLine($"Количество отработанных дней: {electrician.days}");
            Console.WriteLine($"Зарплата электрика = {electrician.GetSalary()}\n");
        }
    }
}
