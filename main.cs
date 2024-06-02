using System;

class InchestoCentimeters
{
    static void Main()
    {
        const double CentimetersPerInch = 2.54;

        double inches = 5; 

        double centimeters = inches * CentimetersPerInch;

        Console.WriteLine($"{inches} inches is {centimeters} centimeters.");
    }
}