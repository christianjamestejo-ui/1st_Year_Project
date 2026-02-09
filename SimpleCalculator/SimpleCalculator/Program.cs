// Tejo, Christian James F.; Remonde, Sean R.
using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3, num2 = 2;
            Console.WriteLine($"{num1} + {num2} = {CalculateAdd( num1, num2)}");
            string result1 = (num1 < num2) ? "Invalid Input" : $"{num1} - {num2} = {CalculateSub(num1, num2)}";
            Console.WriteLine(result1);
            Console.WriteLine($"{num1} x {num2} = {CalculateMulti(num1, num2)}");
            if (num1 < num2)
            {
                Console.WriteLine("Invalid Input");
            }
            else if (num2 == 0)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.WriteLine($"{num1} / {num2} = {CalculateDivi(num1, num2)}");
            }
        }
        static int CalculateAdd(int num1, int num2)
        {
            return num1 + num2;
        }
        static int CalculateSub(int num1, int num2) 
        {  
            return num1 - num2; 
        }
        static int CalculateMulti(int num1, int num2)
        { 
            return num1 * num2;
        }
        static int CalculateDivi(int num1, int num2)
        { 
            return num1 / num2; 
        }
    }
}
