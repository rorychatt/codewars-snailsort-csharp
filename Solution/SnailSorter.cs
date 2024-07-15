namespace Solution;

public static class SnailSorter
{
    public static int[] GetSnailNonLinq(int[][] input)
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

    public static int[] GetSnailLinq(int[][] input)
    {
        if (input == null || input.Length == 0 || input[0].Length == 0) return new int[0];

        var result = new List<int>();
        var matrix = input.ToList();

        while (matrix.Any())
        {
            result.AddRange(matrix.First());
            matrix = matrix.Skip(1).ToList();

            if (!matrix.Any()) break;

            result.AddRange(matrix.Select(row => row.Last()));
            matrix = matrix.Select(row => row.Take(row.Length - 1).ToArray()).Where(row => row.Any()).ToList();

            if (!matrix.Any()) break;

            result.AddRange(matrix.Last().Reverse());
            matrix = matrix.Take(matrix.Count - 1).ToList();

            if (!matrix.Any()) break;

            result.AddRange(matrix.Select(row => row.First()).Reverse());
            matrix = matrix.Select(row => row.Skip(1).ToArray()).Where(row => row.Any()).ToList();
        }

        return result.ToArray();
    }
}


