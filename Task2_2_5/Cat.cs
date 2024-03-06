namespace Task2_2_5
{
    public class Cat : IDisposable
    {
        private string name;
        private int age;

        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Cat() : this("Undefined", 0) 
        { }

        public string Name { get; set; }
        
        public int Age { get; set; }
        
        public void Dispose()
        {
            Console.WriteLine($"Объект с именем {name} был удалён");
        }
    }
}