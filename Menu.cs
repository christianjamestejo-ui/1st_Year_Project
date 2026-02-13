using System;


namespace MyApplication
{
    class Program
    {
        static void Main(int)

          
        {
          
            while (true)
            {
                Console.WriteLine("\t\nPick a sort:");
                Console.WriteLine("\t1.Selection_sort");
                Console.WriteLine("\t2.Insertion_sort");
                Console.WriteLine("\t3.Bubble_sort");
                Console.WriteLine("\t4.Exit");
                Console.Write("\tEnter your choice: ");
                int menu = int.Parse(Console.ReadLine());


                switch (menu)
                {
                    case 1:



                        // Declare the array globally so all menu options can access it
                        int[] numbers = null;
                        bool exit = false;

                        while (!exit)
                        {
                            Console.WriteLine("Menu:");
                            Console.WriteLine("1. Enter numbers");
                            Console.WriteLine("2. Display array");
                            Console.WriteLine("3. Selection Sort");
                            Console.WriteLine("4. Exit");
                            Console.Write("Choose an option: ");
                            int choice = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            switch (choice)
                            {
                                case 1:
                                    Console.Write("Enter numbers separated by space: ");
                                    string input = Console.ReadLine();
                                    numbers = Array.ConvertAll(input.Split(' '), int.Parse);
                                    Console.WriteLine("Numbers entered successfully!\n");
                                    break;

                                case 2:
                                    if (numbers == null || numbers.Length == 0)
                                        Console.WriteLine("Array is empty. Please enter numbers first.\n");
                                    else
                                        Console.WriteLine("Current Array: " + string.Join(", ", numbers) + "\n");
                                    break;

                                case 3:
                                    if (numbers == null || numbers.Length == 0)
                                    {
                                        Console.WriteLine("Array is empty. Please enter numbers first.\n");
                                    }
                                    else
                                    {
                                        SelectionSort(numbers);
                                        Console.WriteLine("Array sorted using Selection Sort: " + string.Join(", ", numbers) + "\n");
                                    }
                                    break;

                                case 4:
                                    exit = true;
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice!\n");
                                    break;
                            }
                        }

                        Console.WriteLine("Program ended.");

                        // -----------------------------
                        // Selection Sort method
                        void SelectionSort(int[] arr)
                        {
                            int n = arr.Length;
                            for (int i = 0; i < n - 1; i++)
                            {
                                int minIndex = i;

                                for (int j = i + 1; j < n; j++)
                                {
                                    if (arr[j] < arr[minIndex])
                                        minIndex = j;
                                }

                                int temp = arr[i];
                                arr[i] = arr[minIndex];
                                arr[minIndex] = temp;
                            }
                        }

                        break;
                    case 2:


                        {                          // Declare the array globally so all menu options can access it
                            int[] numbers1 = null;
                            bool exits = false;

                            while (!exits)
                            {
                                Console.WriteLine("Menu:");
                                Console.WriteLine("1. Enter numbers");
                                Console.WriteLine("2. Display array");
                                Console.WriteLine("3. Insertion Sort");
                                Console.WriteLine("4. Exit");
                                Console.Write("Choose an option: ");
                                int choice = int.Parse(Console.ReadLine());
                                Console.WriteLine();

                                switch (choice)
                                {
                                    case 1:
                                        Console.Write("Enter numbers separated by space: ");
                                        string input = Console.ReadLine();
                                        numbers1 = Array.ConvertAll(input.Split(' '), int.Parse);
                                        Console.WriteLine("Numbers entered successfully!\n");
                                        break;

                                    case 2:
                                        if (numbers1 == null || numbers1.Length == 0)
                                            Console.WriteLine("Array is empty. Please enter numbers first.\n");
                                        else
                                            Console.WriteLine("Current Array: " + string.Join(", ", numbers1) + "\n");
                                        break;

                                    case 3:
                                        if (numbers1 == null || numbers1.Length == 0)
                                        {
                                            Console.WriteLine("Array is empty. Please enter numbers first.\n");
                                        }
                                        else
                                        {
                                            InsertionSort(numbers1);
                                            Console.WriteLine("Array sorted using Insertion Sort: " + string.Join(", ", numbers1) + "\n");
                                        }
                                        break;

                                    case 4:
                                        exits = true;
                                        break;

                                    default:
                                        Console.WriteLine("Invalid choice!\n");
                                        break;
                                }
                            }
                        }
                        Console.WriteLine("Program ended.");

                        // -----------------------------
                        // Insertion Sort method
                        void InsertionSort(int[] arr)
                        {
                            int n = arr.Length;
                            for (int i = 1; i < n; i++)
                            {
                                int key = arr[i];
                                int j = i - 1;

                                // Move elements of arr[0..i-1] that are greater than key
                                // one position ahead of their current position
                                while (j >= 0 && arr[j] > key)
                                {
                                    arr[j + 1] = arr[j];
                                    j--;
                                }

                                arr[j + 1] = key;
                            }
                        }



                        break;
                    case 3:
                        {
                            static void Bubble()
                            {
                                int[] numbers = null;

                                while (true)
                                {
                                    Console.WriteLine("\tMenu:");
                                    Console.WriteLine("\t1. Enter numbers");
                                    Console.WriteLine("\t2. Display array");
                                    Console.WriteLine("\t3. Sort array using Bubble Sort");
                                    Console.WriteLine("\t4. Exit");
                                    Console.Write("\tEnter your choice: ");
                                    int choice = int.Parse(Console.ReadLine());

                                    switch (choice)
                                    {
                                        case 1:
                                            Console.Write("How many numbers do you want to enter? ");
                                            int size = int.Parse(Console.ReadLine());
                                            numbers = new int[size];

                                            for (int i = 0; i < size; i++)
                                            {
                                                Console.Write($"Enter number {i + 1} (or type 'q' to stop): ");
                                                string input = Console.ReadLine();

                                                if (input.ToLower() == "q")
                                                {
                                                    Console.WriteLine("Returning to menu...");
                                                    // Resize array to what has been entered so far
                                                    Array.Resize(ref numbers, i);
                                                    break;
                                                }

                                                if (int.TryParse(input, out int num))
                                                {
                                                    numbers[i] = num;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input, try again.");
                                                    i--; // repeat this index
                                                }
                                            }
                                            break;

                                        case 2:
                                            if (numbers == null || numbers.Length == 0)
                                                Console.WriteLine("Array is empty. Please enter numbers first.");
                                            else
                                                Console.WriteLine("Array: " + string.Join(", ", numbers));
                                            break;

                                        case 3:
                                            if (numbers == null || numbers.Length == 0)
                                                Console.WriteLine("Array is empty. Please enter numbers first.");
                                            else
                                            {
                                                BubbleSort(numbers);
                                                Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
                                            }
                                            break;

                                        case 4:
                                            Console.WriteLine("Exiting...");
                                            return;

                                        default:
                                            Console.WriteLine("Invalid choice");
                                            break;
                                    }
                                }
                            }

                            static void BubbleSort(int[] arr)
                            {
                                int n = arr.Length;
                                for (int i = 0; i < n - 1; i++)
                                {
                                    for (int j = 0; j < n - i - 1; j++)
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
                        }
                        break;
                    case 4:
                        return;


                    
                }
            }
        }
    }
}







