using System;
namespace assignment2;

class Program
{
    static void Main(string[] args)
    {
        Random number = new ();
        int num1 = number.Next(0, 101);
        int num2 = number.Next(0, 101);
        int num3 = number.Next(0, 101);
        int num4 = number.Next(0, 101);
        int num5 = number.Next(0, 101);
        int num6 = number.Next(0, 101);
        int num7 = number.Next(0, 101);
        int num8 = number.Next(0, 101);
        int num9 = number.Next(0, 101);
        int num10 = number.Next(0, 101);

        int[] numbers = { num1, num2, num3, num4, num5, num6, num7, num8, num9, num10};

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }


        int sum = numbers.Sum();
        double arithmetic_mean = sum / numbers.Length;
        Console.WriteLine();
        Console.WriteLine("arithemetic mean of array: " + arithmetic_mean);

        int quantity = 0;
        for (int i = 0;i < numbers.Length;i++)
        {
            if (numbers[i] > arithmetic_mean)
            {
                quantity += 1;
            }
        }
        Console.WriteLine("the amount of numbers that are greater than the arithemetic mean: " + quantity);

        for (int i = 0; i < numbers.Length;i++)
        {
            if (numbers[i] > arithmetic_mean)
            {
                Console.Write(numbers[i] + " ");
            }
        }






    }

}
