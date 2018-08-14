namespace BubbleSort
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    int leftElement = numbers[i];
                    int rightElement = numbers[i + 1];

                    if (leftElement > rightElement)
                    {
                        int leftIndex = i;
                        Swap(numbers, leftIndex);
                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void Swap(List<int> numbers, int leftIndex)
        {
            int temp = numbers[leftIndex];
            numbers[leftIndex] = numbers[leftIndex + 1];
            numbers[leftIndex + 1] = temp;
        }
    }
}
