namespace Task2_1_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
            int target = 8;

            List<List<int>> result = CombinationSum(candidates, target);
            foreach (var i in result)
            {
                foreach (var j in i)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }

        public static List<List<int>> CombinationSum(int[] candidates, int target)
        {
            var result = new List<List<int>>();
            Array.Sort(candidates);

            for (int i = 0; i < candidates.Length; i++)
            {
                if (i > 0 && candidates[i] == candidates[i - 1])
                    continue;

                var combination = new List<int> { candidates[i] };

                Backtrack(candidates, i + 1, target - candidates[i], combination, result);
            }

            return result;
        }

        public static void Backtrack(int[] candidates, int start, int target, List<int> combination,
            List<List<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(combination));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1])
                    continue;

                combination.Add(candidates[i]);

                Backtrack(candidates, i + 1, target - candidates[i], combination, result);

                combination.RemoveAt(combination.Count - 1);
            }
        }
    }
}
