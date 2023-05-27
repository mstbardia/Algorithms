namespace Algorithms.Examples;

public static partial class Sort
{
    public static int[] OrderByAscending_BubbleSort(int[] input)
    {
        for (int i = input.Count() - 1; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                var leftItem = input[j];
                var rightItem = input[j + 1];

                if (leftItem > rightItem)
                {
                    input[j + 1] = leftItem;
                    input[j] = rightItem;
                }
            }
        }

        return input;
    }
}