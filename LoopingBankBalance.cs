using System;
using static System.Console;
class LoopingBankBalance
{
  static void Main()
  {
    double bankBalance = 1000;
    const double INT_RATE = 0.04;
    string inputString;
    char response;
    Write("Do you want to see your balance? Yes or No...");
    inputString = ReadLine();
    response = Convert.ToChar(inputString);
    while(reponse == 'Y')
    {
      WriteLine("Bank balancee is {0}",
      bankBalance.ToString("C));
      bankBalance = bankBalance+bankBalance*INT_RATE;
      Write("Do you want to see next year's balance? Yes or no...");
      inputString=ReadLine();
      reponse = Convert.ToChar(inputString);
    }
      WriteLine("Have a nice day!");
  }
}
