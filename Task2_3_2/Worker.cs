namespace Task2_3_2
{
    internal class Worker
    {
        private string name;
        private string surname;
        private int rate;
        private int days;

        public Worker(string name, string surname, int rate, int days) 
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }

        public string Name
        { 
            get { return name; } 
        }

        public string Surname
        {
            get { return surname; } 
        }
        public int Rate 
        { 
            get { return rate; } 
        }
        public int Days 
        { 
            get { return days; } 
        }

        public int GetSalary()
        {
            return Rate * Days;
        }
    }
}
