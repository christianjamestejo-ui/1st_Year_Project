using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 3, 8, 4, 2 };

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int min = i;// i is 1 but go

            for (int j = i + 1; j < numbers.Length; j++)// so i is + by 1 became 2 on how j is greater than number then the if statement and the //swap got cancled
            {
                if (numbers[j] < numbers[min])
                {
                    min = j;
                }
            }

            // swap
            int temp = numbers[i];
            numbers[i] = numbers[min];
            numbers[min] = temp;
        }

        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}
