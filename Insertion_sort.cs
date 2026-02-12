using System;

class Insertion_sort
{
    static void Main()
    {
        int[] numbers = { 5, 2, 9, 1, 3 };

        // Insertion Sort
        for (int i = 1; i < numbers.Length; i++)
        {
            int key = numbers[i];     // Current number to insert
            int j = i - 1;

            // Move elements that are greater than key
            while (j >= 0 && numbers[j] > key)
            {
                numbers[j + 1] = numbers[j];
                j--;
            }

            numbers[j + 1] = key; // Insert key in correct position
        }

        // Print sorted array
        Console.WriteLine("Sorted array:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}                                       // OUTPUT 1 2 3 5 9

