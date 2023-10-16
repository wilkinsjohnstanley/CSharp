using System;
using static System.Console;
class SumFiveints
{
   static void Main()
   {
    // Write your main here
     WriteLine("SumFiveInts");
            int itr = 0;
            const int COUNT = 5;
            int sum = 0;
            while (itr < COUNT)
            {
                Write("Enter number {0}/{1}:", itr + 1, COUNT);
                sum += int.Parse(ReadLine());
                itr++;
            }
            WriteLine("Sum:{0}", sum);

            WriteLine("--End--");
   }
}
