/*using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue*/

/*Using the GreenvilleRevenue program you wrote in Case Study 1 of Chapter 4, 
modify the program so that the user must enter a number between 0 and 30, inclusive, for the number of contestants each year. 
If the user enters an incorrect number, the program prompts for a valid value.*/
using System;
using static System.Console;

class GreenvilleRevenue
{
    static void Main()
    {
        int lastYearNum, thisYearNum;
        string lastYear, thisYear;
        double admission = 25.00, revenue;

        do
        {
            Write("Enter the number of contestants in last year's competition: ");
            lastYear = ReadLine();
            lastYearNum = Int32.Parse(lastYear);
        }
        while (lastYearNum < 0 || lastYearNum > 30);

        do
        {
            Write("Enter the number of contestants in this year's competition: ");
            thisYear = ReadLine();
            thisYearNum = Int32.Parse(thisYear);
            bool moreThisYear = thisYearNum > lastYearNum;
            revenue = thisYearNum * admission;
        }
        while (thisYearNum < 0 || thisYearNum > 30);


        WriteLine();
        if (thisYearNum > (lastYearNum * 2))
            WriteLine("The Competition is more than twice as big this year!");
        else
            if (thisYearNum > lastYearNum)
            WriteLine("The competition is bigger than ever!");
        else
            if (thisYearNum < lastYearNum)
            WriteLine("A tighter race this year! Come out and cast your vote.");
        // WriteLine("There were {0} contestants last year, and {1} contestants this year.", lastYearNum, thisYearNum);
        // WriteLine("To say that there were more contestants this year than last would be {0}", moreThisYear);
        WriteLine();
        WriteLine("Expected revenue for this year's competition is: ${0}", revenue.ToString("F2"));
    }
}
