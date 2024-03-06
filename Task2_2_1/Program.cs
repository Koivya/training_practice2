namespace Task2_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string secondName = "Петров";
            
            DateOnly birthdate = new DateOnly(2004,05,17);
            
            int groupNumber = 931;
            
            int[] grades = { 3, 4, 5, 4, 4 };

            Student student = new Student(secondName, birthdate, groupNumber, grades);

            student.GetAllProperties();

            student.ChangeSecondName();
            
            student.ChangeBirthDate();
            
            student.ChangeGroupNumber();
            
            student.ChangeAcademicPerformance();

            student.GetAllProperties();

        }
    }
}
