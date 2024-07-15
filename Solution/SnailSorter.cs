
namespace Solution;

public static class SnailSorter
{
    public static int[] GetSnail(int[][] input)
    {
        if (input == null || input.Length == 0 || input[0].Length == 0) return new int[0];

        int[] result = new int[input.Length * input.Length];
        int index = 0;
        while (input.Length > 0)
        {
            foreach (var item in input.First())
            {
                result[index++] = item;
            }
            input = input.Skip(1).ToArray();

            if (input.Length == 0) break;

            foreach (var row in input)
            {
                result[index++] = row.Last();
            }
            input = input.Select(row => row.SkipLast(1).ToArray()).ToArray();

            if (input.Length == 0) break;

            foreach (var item in input.Last().Reverse())
            {
                result[index++] = item;
            }
            input = input.SkipLast(1).ToArray();

            if (input.Length == 0) break;

            foreach (var row in input.Reverse())
            {
                result[index++] = row.First();
            }
            input = input.Select(row => row.Skip(1).ToArray()).ToArray();
        }

        return result;
    }
}
