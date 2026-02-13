using System;
namespace Sort
{ 
 class Program
 {
    static void Main()
    {
        int[] numbers = null;

        while (true)
        {
            Console.WriteLine("\n==== MAIN MENU ====");
            Console.WriteLine("1. Enter numbers");
            Console.WriteLine("2. Display array");
            Console.WriteLine("3. Bubble Sort");
            Console.WriteLine("4. Selection Sort");
            Console.WriteLine("5. Insertion Sort");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("How many numbers? ");
                    int size = int.Parse(Console.ReadLine());
                    numbers = new int[size];

                    for (int i = 0; i < size; i++)
                    {
                        Console.Write($"Enter number {i + 1}: ");
                        numbers[i] = int.Parse(Console.ReadLine());
                    }
                    break;

                case 2:
                    if (numbers == null)
                        Console.WriteLine("Array is empty. Enter numbers first.");
                    else
                        Console.WriteLine("Array: " + string.Join(", ", numbers));
                    break;

                case 3:
                    if (numbers == null)
                        Console.WriteLine("Enter numbers first.");
                    else
                    {
                        BubbleSort(numbers);
                        Console.WriteLine("Sorted using Bubble Sort:");
                        Console.WriteLine(string.Join(", ", numbers));
                    }
                    break;

                case 4:
                    if (numbers == null)
                        Console.WriteLine("Enter numbers first.");
                    else
                    {
                        SelectionSort(numbers);
                        Console.WriteLine("Sorted using Selection Sort:");
                        Console.WriteLine(string.Join(", ", numbers));
                    }
                    break;

                case 5:
                    if (numbers == null)
                        Console.WriteLine("Enter numbers first.");
                    else
                    {
                        InsertionSort(numbers);
                        Console.WriteLine("Sorted using Insertion Sort:");
                        Console.WriteLine(string.Join(", ", numbers));
                    }
                    break;

                case 6:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    // 🔵 Bubble Sort
    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // 🟢 Selection Sort
    static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }
    }

    // 🟡 Insertion Sort
    static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }
  }
}