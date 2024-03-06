namespace Task2_1_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string strJ = "драгоценности";
            string strS = "камни";

            int count = 0;
            for (int i = 0; i < strJ.Length; i++)
            {
                for (int j = 0; j < strS.Length; j++)
                {
                    if (strS[j] == strJ[i])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}