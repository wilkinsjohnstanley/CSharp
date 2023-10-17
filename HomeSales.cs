using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace HomeSales
{
    class HomeSales
    {
        static void Main(string[] args)
        {
           
           
            int dCount = 0;
            int eCount = 0;
            int fCount = 0;
            double dSum = 0;
            double eSum = 0;
            double fSum = 0;
            
            char in_who = 'n';

           

            while (in_who != 'Z')
            {
                Write("Enter next salesperson intital or Z to quit: ");
                in_who = char.ToUpper(ReadLine()[0]);

                switch (in_who)
                {
                    case 'D':
                        Write("Enter amount of sale:");
                        dSum += double.Parse(ReadLine());
                        dCount++;
                        break;
                    case 'E':
                        Write("Enter amount of sale:");
                        eSum += double.Parse(ReadLine());
                        eCount++;
                        break;
                    case 'F':
                        Write("Enter amount of sale:");
                        fSum += double.Parse(ReadLine());
                        fCount++;
                        break;
                    case 'Z':
                        //quit
                        break;
                    default:
                        WriteLine("Sorry - invalid salesperson");
                        break;
                }
            }
            WriteLine("Danielle sold ${0}", dSum);
            WriteLine("Edward   sold ${0}", eSum);
            WriteLine("Francis  sold ${0}", fSum);
            WriteLine("Total sales were ${0}", dSum+eSum+fSum);
            if (dSum == eSum){
              WriteLine("There was a tie");
            } else if (dSum == fSum){
              WriteLine("There was a tie");
            } else if (eSum == fSum){
              WriteLine("There was a tie");
            }


            if (dSum > eSum)
            {
                if (dSum > fSum)
                    WriteLine("Danielle sold the most");
                else 
                    WriteLine("Francis sold the most");
               
            }
            else if (eSum > fSum)
                WriteLine("Edward sold the most");

  
        }
    }
}
