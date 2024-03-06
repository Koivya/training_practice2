namespace Task2_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();

            Cat cat2 = new Cat("Барсик", 3);

            Console.WriteLine($"Объект 1: {cat1.Name}, {cat1.Age}");
            Console.WriteLine($"Объект 2: {cat2.Name}, {cat2.Age}");
            
            cat1.Dispose();
            cat2.Dispose();
        }
    }
}