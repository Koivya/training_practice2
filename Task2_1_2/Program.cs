namespace Task2_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] candidates = { 2, 5, 2, 1, 2 };
            int target = 5;
            
            List<List<int>> result = new List<List<int>>();

            Array.Sort(candidates);
            FindCombinations(candidates, target, 0, new List<int>(), result);
            
            foreach (var combination in result)
            {
                Console.WriteLine(string.Join(" ", combination));
            }
        }

        static void FindCombinations(int[] candidates, int target, int start, List<int> current, List<List<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (target - candidates[i] < 0)
                {
                    break;
                }

                if (i > start && candidates[i] == candidates[i - 1])
                {
                    continue;
                }

                current.Add(candidates[i]);
                FindCombinations(candidates, target - candidates[i], i + 1, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
