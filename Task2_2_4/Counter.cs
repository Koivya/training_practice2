namespace Task2_2_4;

public class Counter
{
    private int counter;

    public Counter(int counter)
    {
        this.counter = counter;
    }
    
    public Counter() : this(0) 
    { }

    public void IncrementCounter()
    { 
        counter++;
    }
    
    public void DecrementCounter()
    {
        counter--;
    }

    public void GetStatus()
    {
        Console.WriteLine($"Состояние счётчика: {counter}");
    }

    public int GetCounter()
    {
        return counter;
    }
}