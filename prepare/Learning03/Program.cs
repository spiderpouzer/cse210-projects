// Program.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing the Fraction class

        // 1/1 fraction using the default constructor
        Fraction frac1 = new Fraction();
        Console.WriteLine(frac1.GetFractionString()); // Output: 1/1
        Console.WriteLine(frac1.GetDecimalValue());   // Output: 1

        // 5/1 fraction using the constructor with one parameter
        Fraction frac2 = new Fraction(5);
        Console.WriteLine(frac2.GetFractionString()); // Output: 5/1
        Console.WriteLine(frac2.GetDecimalValue());   // Output: 5

        // 3/4 fraction using the constructor with two parameters
        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine(frac3.GetFractionString()); // Output: 3/4
        Console.WriteLine(frac3.GetDecimalValue());   // Output: 0.75

        // 1/3 fraction
        Fraction frac4 = new Fraction(1, 3);
        Console.WriteLine(frac4.GetFractionString()); // Output: 1/3
        Console.WriteLine(frac4.GetDecimalValue());   // Output: 0.333333...

        // Testing the setters and getters
        frac4.SetNumerator(2);
        frac4.SetDenominator(5);
        Console.WriteLine(frac4.GetFractionString()); // Output: 2/5
        Console.WriteLine(frac4.GetDecimalValue());   // Output: 0.4
    }
}
