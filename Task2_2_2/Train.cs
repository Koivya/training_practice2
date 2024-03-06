namespace Task2_2_2
{
    public class Train
    {
        private string destination;
        private int trainNumber;
        private TimeOnly departureTime;

        public Train(string destination, int trainNumber, TimeOnly departureTime)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
        }

        public void ChangeNameOfDesination()  
        {
            Console.Write("Введите название пункта назначения: ");
            destination = Console.ReadLine();
        }

        public void ChangeNumberOfTrain()  
        {
            while (true)
            {
                Console.Write("Введите номер поезда: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    trainNumber = number;
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
        }

        public void ChangeDepartureTime()  
        {
            while (true)
            {
                Console.Write("Введите время отправления (формат: HH:MM): ");
                if (TimeOnly.TryParse(Console.ReadLine(), out TimeOnly time))
                {
                    departureTime = time;
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод даты");
                }
            }
        }
        
        public void GetTrainInfo()
        {
            Console.WriteLine("\nИнформация о поезде: ");
            Console.WriteLine($"Пункт назначения: {destination}");
            Console.WriteLine($"Номер поезда: {trainNumber}");
            Console.WriteLine($"Время отправления: {departureTime}");
            Console.WriteLine();
        }
    }
}