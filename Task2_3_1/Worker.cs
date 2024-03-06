namespace Task2_3_1
{
    internal class Worker
    {
        public string name;
        public string surname;
        public int rate;
        public int days;

        public Worker(string name, string surname, int rate, int days)
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }

        public int GetSalary()
        {
            return rate * days;
        }
    }
}
