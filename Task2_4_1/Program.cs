namespace Task2_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] romanNumerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            int[] decimalNumbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string target = "MCMXCIV";

            int result = 0;
            
            for (int i = 0; i < romanNumerals.Length; i++)
            {
                while (target.StartsWith(romanNumerals[i]))
                {
                    result += decimalNumbers[i];
                    target = target.Substring(romanNumerals[i].Length);
                }
            }

            Console.WriteLine(result);
        }
    }
}
