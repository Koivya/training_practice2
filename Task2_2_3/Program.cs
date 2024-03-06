namespace Task2_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 31;

            Numbers numbers = new Numbers(firstNumber, secondNumber);
            
            numbers.PrintNumbers();
            
            numbers.ChangeNumbers();

            Console.WriteLine($"Сумма чисел: {numbers.SumOfNumbers()}");

            Console.WriteLine($"Наибольшее число: {numbers.GetHighestNumber()}");
        }
    }
}

