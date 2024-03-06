namespace Task2_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            
            counter.GetStatus();

            for (; counter.GetCounter() <= 10; counter.IncrementCounter())
            {
                Console.Write(counter.GetCounter() + " ");
            }
            Console.WriteLine();
            
            counter.GetStatus();
            
            counter.DecrementCounter();
            counter.DecrementCounter();
            
            counter.GetStatus();
        }
    }
}