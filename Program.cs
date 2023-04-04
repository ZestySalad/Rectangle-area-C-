using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the length of the rectangle");
        double length = double.Parse(Console.ReadLine());

        Console.WriteLine("enter the width of the rectangle");
        double width = double.Parse(Console.ReadLine());

        double area = length * width;

        Console.WriteLine("The area of your rectangle is: " + area);
    }
}