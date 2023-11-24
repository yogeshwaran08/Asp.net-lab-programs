using System;

class Program
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {        
        Console.Write("Enter the number a : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number b : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Before swapping: num1 = {num1}, num2 = {num2}");

        Swap(ref num1, ref num2);

        Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
    }
}
