namespace Task2_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfDestination = "Томск";
            int numberOfTrain = 774;
            TimeOnly departureTime = new TimeOnly(15, 30);
            
            Train train = new Train(nameOfDestination, numberOfTrain, departureTime);

            train.GetTrainInfo();
            
            train.ChangeNameOfDesination();
            
            train.ChangeNumberOfTrain();
            
            train.ChangeDepartureTime();
            
            train.GetTrainInfo();
        }
    }
}

