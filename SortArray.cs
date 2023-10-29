/*
• Sort() method
– Arranges array items in ascending order
– Works numerically for number types and alphabetically for
characters and strings
– Use it by passing the array name to Array.Sort()
– Often used before using the BinarySearch() method which
requires a sorted array
*/
using System;
using static System.Console;
class SortArray 
{
  static void Main(){
    string[] names = {"Olive", "Parrty", "Richard", "Ned", "Mindy};
      int x;
      Array.Sort(names);
      for (x = 0; x < names.length; ++x)
        WriteLine(names[x]);
  }
}
