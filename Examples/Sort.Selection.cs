namespace Algorithms.Examples;

public static partial class Sort
{
    public static int[] OrderByAscending_SelectionSort(int[] input)
    {
        for (int i = 0; i <= input.Count() - 1; i++)
        {
            var foundMin = input[i];
            var foundMinIndex = i;

            for (int j = i + 1; j <= input.Count() - 1; j++)
            {
                if (input[j] < foundMin)
                {
                    foundMin = input[j];
                    foundMinIndex = j;
                }
            }
            
            if (foundMin != input[i])
            {
                input[foundMinIndex] = input[i];
                input[i] = foundMin;
            }
        }

        return input;
    }
}