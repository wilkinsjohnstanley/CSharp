/*
• Reverse() method
– The Reverse() method does not sort array elements; it only
rearranges their values to the opposite order
– An element that starts in position 0 is relocated to position
Length – 1 and an element that starts in position 1 is
relocated to position Length – 2
– Use it by passing the array name to the method
*/
using System;
using static System.Console;
class Reverse Array
{
  static void Main()
  {
    string[] names = {"Zach", "Rose", "Wendy", "Marcia"};
    int x;
    Array.Reverse(names);
    for(x=0;x<names.Length;++x)
      WriteLine(names[x]);
  }
}
