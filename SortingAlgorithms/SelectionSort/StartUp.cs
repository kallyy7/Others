namespace SelectionSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int minNumber = int.MaxValue;
            int minIndex = 0;

            for (int a = 0; a < numbers.Count; a++)
            {
                int unsortedIndex = a;
                bool swaped = false;

                for (int b = 0; b < numbers.Count; b++)
                {
                    int currentNumber = numbers[b];

                    if (currentNumber < minNumber)
                    {
                        minIndex = b;
                        minNumber = currentNumber;
                        swaped = true;
                    }
                }

                if (swaped)
                {
                    Swap(numbers, minIndex, unsortedIndex);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void Swap(List<int> numbers, int minIndex, int unsortedIndex)
        {
            int temp = numbers[unsortedIndex];
            numbers[unsortedIndex] = numbers[minIndex];
            numbers[minIndex] = temp;
        }
    }
}
