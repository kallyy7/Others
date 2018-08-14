namespace InsertionSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        Insert(inputArray, j);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", inputArray));
        }

        private static void Insert(int[] inputArray, int j)
        {
            int temp = inputArray[j - 1];
            inputArray[j - 1] = inputArray[j];
            inputArray[j] = temp;
        }
    }
}