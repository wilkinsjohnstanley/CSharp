﻿using System;
using static System.Console;

class ArrayDemo2

{
    static void Main()
    {
        int[] scores = new int[8];
        int x;
        string inputString;

        int count;
        const int DASHES = 50;

        //Add a loop that prompts the user, accepts a test score, converts the score to an integer, and stores it as the appropriate element of the scores array.
        for (x = 0; x < scores.Length; ++x)
        {
            Write("Enter your score on test {0} ", x + 1);
            inputString = ReadLine();
            scores[x] = Convert.ToInt32(inputString);
        }
        WriteLine();
        for (count = 0; count < DASHES; count++)
            Write("-");
        WriteLine();

        WriteLine("Scores in original order:");
        for(x=0; x < scores.Length;  x++)
        {
            Write("{0, 6}", scores[x]);
            WriteLine();
        }

        for (count = 0; count < DASHES; count++)
            Write("-");
        WriteLine();
        Array.Sort(scores);
        WriteLine("Scores in sorted order:");
        for (x = 0; x < scores.Length; ++x)
            Write("{0,6}", scores[x]);
        WriteLine();

        for (count = 0; count < DASHES; count++)
            Write("-");
        WriteLine();
        Array.Reverse(scores);
        WriteLine("Scores in reverse order:");
        for (x = 0; x < scores.Length; ++x)
            Write("{0,6}", scores[x]);
        WriteLine();
    }
}
