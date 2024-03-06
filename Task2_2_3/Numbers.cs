namespace Task2_2_3;

public class Numbers
{
    private int firstNumber;
    private int secondNumber;

    public Numbers(int firstNumber, int secondNumber)
    {
        this.firstNumber = firstNumber;
        this.secondNumber = secondNumber;
    }
    
    public void PrintNumbers()
    {
        Console.WriteLine($"Первое число: {firstNumber}");
        Console.WriteLine($"Второе число: {secondNumber}");
    }

    public void ChangeNumbers()
    {
        Console.WriteLine("Введите новые числа");
        Console.Write("Первое число: ");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Второе число: ");
        secondNumber = Convert.ToInt32(Console.ReadLine());
    }

    public int SumOfNumbers()
    {
        return firstNumber + secondNumber;
    }

    public int GetHighestNumber()
    {
        return firstNumber > secondNumber ? firstNumber : secondNumber;
    }
}