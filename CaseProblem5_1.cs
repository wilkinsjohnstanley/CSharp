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
      const int ENTRANCE_FEE = 25;
      string entryString;
      int numThisYear;
      int numLastYear;
      int revenue;

      Write("Enter number of contestants last year >> ");
      entryString = ReadLine();
      numLastYear = Convert.ToInt32(entryString);
      if (numLastYear <= 0 && numLastYear >= 30){
         WriteLine("Enter a valid number between 0 and 30");
         WriteLine("Enter number of contestants last year ");
      entryString = ReadLine();
      numLastYear = Convert.ToInt32(entryString);
      } else 
      Write("Enter number of contestants this year ");
      entryString = ReadLine();
      numThisYear = Convert.ToInt32(entryString);
      if (numThisYear <= 0 && numThisYear >= 30){
         WriteLine("Enter a valid number between 0 and 30");
         WriteLine("Enter number of contestants last year ");
      entryString = ReadLine();
      numLastYear = Convert.ToInt32(entryString);
      }


             
      revenue = numThisYear * ENTRANCE_FEE;
      WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants",
         numLastYear, numThisYear);
      WriteLine("Revenue expected this year is {0}", revenue.ToString("C"));
      if(numThisYear > 2 * numLastYear)
         WriteLine("The competition is more than twice as big this year!");
      else
         if(numThisYear > numLastYear)
            WriteLine("The competition is bigger than ever!");
         else
            if(numThisYear < numLastYear)
               WriteLine("A tighter race this year! Come out and cast your vote!");
   }
}

