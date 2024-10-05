// Fraction.cs

public class Fraction
{
    private int _numerator;
    private int _denominator;

    // Constructor 1: Initializes to 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor 2: Initializes with a top number, denominator is set to 1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor 3: Initializes with both top and bottom numbers
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        if (denominator == 0) // Ensure denominator is not zero
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _denominator = denominator;
    }

    // Getters and Setters
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _denominator = denominator;
    }

    // Method to return the fraction as a string
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
