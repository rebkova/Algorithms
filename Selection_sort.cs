using System;

namespace Selection_sort
{
    class Selection_sort
    {
        static void Main(string[] args)
        {

            int[] testArray = { 0, -5, -99, 4, 9, 7, 6 };
            SelectionSort(testArray);
            Print_Array(testArray);

        }

        private static void SelectionSort(int[] array)
        {
            /*selection sorting in an array*/
            for (int currentIndex = 0; currentIndex < array.Length; currentIndex++)
            {
                int currentMinIndex = IndexOfMinimum(array, currentIndex);
                if (array[currentMinIndex] < array[currentIndex])
                {
                    Swap(array, currentMinIndex, currentIndex);
                }
            }
        }

        private static int IndexOfMinimum (int[] array, int startIndex)
        {
            /*method for finding min value of an array*/
            int minValue = array[startIndex];
            int minIndex = startIndex;

            for (var i = minIndex + 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minIndex = i;
                    minValue = array[i];
                }
            }
            return minIndex;

        }

        private static void Swap(int[] array, int firstIndex, int secondIndex)
        {
            /*method for swapping items in an array*/
            int temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }

        private static void Print_Array(int[] array)
        {
            /*method for printing an array*/
            Console.Write("Test array after sorting: { ");
            foreach (int item in array)
            {
                Console.Write(item + ", ");
            }
            Console.Write("}");
        }
    }
}
