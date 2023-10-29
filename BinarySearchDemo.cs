/*
• BinarySearch() method
– a sorted list of objects is split in half repeatedly as the search
gets closer and closer to a match
– Similar to the “guess a Number between 1 and 100” game
– Start with Is it less than 50? Less than 25? Less than 12? Etc.
• When not to use BinarySearch()
– If your array items are not arranged in ascending order
– If your array holds duplicate values and you want to find all of
them
– If you want to find a range match rather than an exact match
*/
using System;
using static System.Console;
class BinarySearchDemo
{
  static void Main()
  {
    int[] idNumbers = {122, 167, 204, 219, 345};
    int x;
    string entryString;
    int entryId;
    Write("Enter an Employee ID ");
    entryString = ReadLine();
    entryId = Convert.ToInt32(entryString);
    x = Array.BinarySearch(idNumbers, entryId);
    if(x<0)
      WriteLine("ID {0} not found", entryID);
    else
      WriteLine("ID {0} found at position {1} ",
                entryId, x);
  }
}
