using System;

public class LargestFinder
{
    public static int FindLargest(int a, int b)
    {
        return (a > b) ? a : b;
    }

    public static int FindLargest(int a, int b, int c, int d)
    {
        int max1 = FindLargest(a, b);
        int max2 = FindLargest(c, d);

        return FindLargest(max1, max2);
    }

    public static void Main()
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int resultQ1 = FindLargest(num1, num2);

        Console.WriteLine($"The largest number from Q1 is: {resultQ1}");

        Console.WriteLine("Enter the third integer:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the fourth integer:");
        int num4 = Convert.ToInt32(Console.ReadLine());

        int resultQ2 = FindLargest(num1, num2, num3, num4);

        Console.WriteLine($"The largest number from Q2 is: {resultQ2}");
    }
}