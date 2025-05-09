

using System;

class Program
{
    static int ClimbRecursive(int n)
    {
        if (n <= 2) return n;
        return ClimbRecursive(n - 1) + ClimbRecursive(n - 2);
    }


    static void Main()
    {
        Console.WriteLine("Input: n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int result = ClimbRecursive(n);
        Console.WriteLine($"Output: {result}");

    }
}