using System;
using static System.Console;
class InchesToCentimetersInteractive
{
    static void Main()
    {
        const double CENTIMETERS_PER_INCH = 2.54;
        string inches;
        int inchInt;
        WriteLine("Enter inches:");
        inches = ReadLine();
        inchInt = Convert.ToInt32(inches);
        WriteLine("{0} inches is {1} centimeters", inches, inchInt * CENTIMETERS_PER_INCH);
    }
}
