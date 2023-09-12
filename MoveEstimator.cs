using System;
using static System.Console;
using System.Globalization;
class MoveEstimator
{
    static void Main()
    {

        //WriteLine("This is an example: {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        /*
         Malcolm Movers charges a base rate of $200 per move plus $150 per hour and $2 per mile.

        Write a program named MoveEstimator that prompts a user for 
        and accepts estimates for the number of hours for a job 
        and the number of miles involved in the move and displays the total moving fee.

        For example, if 25 hours and 55 miles are input the output would be displayed as: 
        For a move taking 25 hours and going 55 miles the estimate is $4,060.00
        */

        string hours;
        string miles;
        int hoursInt;
        int milesInt;
       
        WriteLine("How many hours?");
        hours = ReadLine();
        WriteLine("How many miles?");
        miles = ReadLine();
        hoursInt = Convert.ToInt32(hours);
        milesInt = Convert.ToInt32(miles);
        int estimate = 200 + (hoursInt * 150) + (milesInt * 2);
        WriteLine("For a move taking {0} hours and going {1} miles the estimate is {2}", hours, miles, estimate.ToString("C", CultureInfo.GetCultureInfo("en-US")));

}
}
