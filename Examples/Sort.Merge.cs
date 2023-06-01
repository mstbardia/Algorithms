namespace Algorithms.Examples;

public static partial class Sort
{
    public static int[] OrderByAscending_MergeSort(int[] input)
    {
        return MergeSort(input, 0, input.Length - 1);
    }

    // method for merging arrays
    static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
    {
        var leftIndex = lowIndex;
        var rightIndex = middleIndex + 1;
        var tempArray = new int[highIndex - lowIndex + 1];
        var index = 0;

        while ((leftIndex <= middleIndex) && (rightIndex <= highIndex))
        {
            if (array[leftIndex] < array[rightIndex])
            {
                tempArray[index] = array[leftIndex];
                leftIndex++;
            }
            else
            {
                tempArray[index] = array[rightIndex];
                rightIndex++;
            }

            index++;
        }

        for (var i = leftIndex; i <= middleIndex; i++)
        {
            tempArray[index] = array[i];
            index++;
        }

        for (var i = rightIndex; i <= highIndex; i++)
        {
            tempArray[index] = array[i];
            index++;
        }

        for (var i = 0; i < tempArray.Length; i++)
        {
            array[lowIndex + i] = tempArray[i];
        }
    }

    // merge sort
    static int[] MergeSort(int[] array, int lowIndex, int highIndex)
    {
        if (lowIndex < highIndex)
        {
            var middleIndex = (lowIndex + highIndex) / 2;
            MergeSort(array, lowIndex, middleIndex);
            MergeSort(array, middleIndex + 1, highIndex);
            Merge(array, lowIndex, middleIndex, highIndex);
        }

        return array;
    }
}