namespace Task2_2_1
{
    internal class Student
    {
        private string secondName;
        private DateOnly birthdate;
        private int groupNumber;
        private int[] grades;
        
        public Student(string secondName, DateOnly birthdate, int groupNumber, int[] grades)
        {
            this.secondName = secondName;
            this.birthdate = birthdate;
            this.groupNumber = groupNumber;
            this.grades = grades;
        }

        public void ChangeSecondName()  
        {
            Console.Write("Введите фамилию студента: ");
            secondName = Console.ReadLine();
        }

        public void ChangeBirthDate()  
        {
            while (true)
            {
                Console.Write("Введите дату рождения студента (формат: YYYY.MM.DD): ");
                if (DateOnly.TryParse(Console.ReadLine(), out DateOnly bdate))
                {
                    birthdate = bdate;
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод даты");
                }
            }
        }

        public void ChangeGroupNumber()  
        {
            while (true)
            {
                Console.Write("Введите номер группы студента: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    groupNumber = number;
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
        }

        public void ChangeAcademicPerformance()  
        {
            int count = 0;
            Console.WriteLine("Введите успеваемость студента");
            while (count != grades.Length)
            {
                Console.Write($"{count + 1} оценка: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    grades[count] = number;
                    count++;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
        }
        
        public void GetAllProperties()  
        {
            Console.WriteLine("\nИнформация о студенте: ");
            Console.WriteLine($"Фамилия: {secondName}");
            Console.WriteLine($"Дата рождения: {birthdate}");
            Console.WriteLine($"Номер группы: {groupNumber}");
            Console.WriteLine("Успеваемость студента: ");
            foreach (int n in grades)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
