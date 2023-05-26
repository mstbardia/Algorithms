﻿namespace Algorithms.Examples;

public static class Sort
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