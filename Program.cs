using System;

public class Calculator
{
   public static int number1 = 5;
   public static int number2 = 10;

   public static int Add(int a, int b)
   {
       return a + b;
   }

   public static void Main(string[] args)
   {
       int result = Add(number1, number2);
       Console.WriteLine("Sum: " + result);
   }
}