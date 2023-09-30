/* In Chapter 2, you created an interactive application named GreenvilleRevenue.

The program prompts a user for the number of contestants entered in this year’s and last year’s Greenville Idol competition, and then it displays the revenue expected for this year’s competition if each contestant pays a $25 entrance fee.

The programs also display a statement that compares the number of contestants each year. Using the program you wrote in Case Study 1 of Chapter 2, replace that statement with one of the following messages:

    If the competition has more than twice as many contestants as last year, display The competition is more than twice as big this year!

    If the competition is bigger than last year’s but not more than twice as big, display The competition is bigger than ever!

    If the competition is smaller than last year’s, display, A tighter race this year! Come out and cast your vote!

    In order to prepend the $ to currency values, the program will need to use the CultureInfo.GetCultureInfo method. In order to do this, include the statement using System.Globalization; at the top of your program and format the output statements as follows: WriteLine("This is an example: {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));

*/
using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue
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
        // WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", lastYearsContestants, thisYearsContestants);

        //Compute and display the revenue expected for this year’s competition if each contestant pays a $25 entrance fee.
        lastYearInt = Convert.ToInt32(lastYearsContestants);
        thisYearInt = Convert.ToInt32(thisYearsContestants);
        int revenue = (thisYearInt * 25);
        WriteLine("Revenue expected this year is {0}", revenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        //Compare values of this year and last years competition
        if (thisYearInt > lastYearInt * 2)
        {
            WriteLine("The competition is more than twice as big this year!");
        }
        else if (thisYearInt > lastYearInt)
        {
            WriteLine("The competition is bigger than ever!");
        }
        else if (thisYearInt < lastYearInt)
        {
            WriteLine("A tighter race this year! Come out and cast your vote!");
        }


    }
}

