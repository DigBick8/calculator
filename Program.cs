using System;

public static class Calculator
{
    public static void Main(string[] args)
    {
    int num1, num2;
    char operation = ' ';
    
    Console.Write("Enter first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter second number: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    
    double? result = Calculate(num1, num2, operation);
    
    if (result == null)
            Console.WriteLine("Result: null");
    else
            Console.WriteLine("Result: " + result);
    
    }
}
