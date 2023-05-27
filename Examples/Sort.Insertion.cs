namespace Algorithms.Examples;

public static partial class Sort
{
    public static int[] OrderByAscending_Insertion(int[] input)
    {
        for (int i = 1; i <= input.Count() - 1; i++)
        {
            var currentIndex = i;
            var previousIndex = i - 1;

            do
            {
                var currentItem = input[currentIndex];
                var previousItem = input[previousIndex];

                if (previousItem > currentItem)
                {
                    input[previousIndex] = currentItem;
                    input[currentIndex] = previousItem;
                }
                else
                    break;

                previousIndex--;
                currentIndex--;

            } while (previousIndex >= 0);
        }

        return input;
    }
}