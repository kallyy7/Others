namespace SelectionSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int minNumber = int.MaxValue;
            int minIndex = 0;

            for (int a = 0; a < numbers.Length; a++)
            {
                int unsortedIndex = a;
                bool swaped = false;

                for (int b = 0; b < numbers.Length; b++)
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

        private static void Swap(int[] numbers, int minIndex, int unsortedIndex)
        {
            int temp = numbers[unsortedIndex];
            numbers[unsortedIndex] = numbers[minIndex];
            numbers[minIndex] = temp;
        }
    }
}
