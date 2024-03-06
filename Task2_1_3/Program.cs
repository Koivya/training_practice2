namespace Task2_1_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };

            bool found = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (nums[i] == nums[j])
                    {
                        found = true;
                    }
                }
            }
            Console.WriteLine(found);
        }
    }
}