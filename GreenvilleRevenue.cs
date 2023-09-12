using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue

/*
Enter number of contestants last year >> 6      
Enter number of contestants this year >> 14
Last year's competition had 6 contestants, and this year's has 14 contestants
Revenue expected this year is $350.00
It is True that this year's competition is bigger than last year's.
*/
{
    static void Main()
    {

        //WriteLine("This is an example: {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));


        // Declare variable to hold 
        string thisYearsContestants;
        string lastYearsContestants;
        int thisYearInt;
        int lastYearInt;

        WriteLine("Enter number of contestants last year");
        lastYearsContestants = ReadLine();
        WriteLine("Enter number of contestants this year");
        thisYearsContestants = ReadLine();
        WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", lastYearsContestants, thisYearsContestants);

        //Compute and display the revenue expected for this year’s competition if each contestant pays a $25 entrance fee.
        lastYearInt = Convert.ToInt32(lastYearsContestants);
        thisYearInt = Convert.ToInt32(thisYearsContestants);
        int revenue = (thisYearInt * 25);
        WriteLine("Revenue expected this year is {0}", revenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        //Compare values of this year and last years competition
        if (thisYearInt > lastYearInt)
        {
            WriteLine("It is True that this year's competition is bigger than last year's.");
        }
        else
        {
            WriteLine("It is False that this year's competition is bigger than last year's.");

        }
    }
}