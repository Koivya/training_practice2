namespace Task2_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();
            Calculation calculation = new Calculation(line);

            Console.Write("\nВведите символ: ");
            string symbol = Console.ReadLine();
            calculation.SetLastSymbolCalculationLine(symbol);
            Console.WriteLine($"В строке произошли изменения: {calculation.GetCalculationLine()}\n");

            Console.WriteLine($"Последний добавленный символ в строке: {calculation.GetLastSymbol()}\n");

            Console.WriteLine("Последний символ был удалён");
            calculation.DeleteLastSymbol();
            Console.WriteLine($"В строке произошли изменения: {calculation.GetCalculationLine()}\n");
        }
    }
}
