/*
Name: John Wilkins
Program name: Tables
Description: It computes the price of a table and chairs 
Date: 11/15/2023
 */
using System;
using static System.Console;

public class Tables{

    public static void Main()
    {

        int chairs = no_chairs();

        char ch_wood = wood_type();

        double res = final_cost(chairs, ch_wood);

        display(chairs, ch_wood, res);

    }

    //number of chairs method
    public static int no_chairs(){

WriteLine("Enter number of chairs ");
        int numberOfChairs = Convert.ToInt32(ReadLine());

        while (numberOfChairs < 2)
        {
            WriteLine("You must order at least two chairs");
            WriteLine("Enter number of chairs");
            numberOfChairs = Convert.ToInt32(ReadLine());
        }
        
            return numberOfChairs;
      
       

    }
    //type of wood method
public static char wood_type(){
        
        WriteLine("Enter type of wood - p, m or o ");
       char woodCheck = ReadLine()[0];
        while (woodCheck != 'p' && woodCheck != 'm' && woodCheck != 'o') 
        {
            WriteLine("You have entered an invalid wood type");
            WriteLine("Enter type of wood - p, m or o ");
            woodCheck = ReadLine()[0];
        }
/*Character input using Console.ReadLine()[0]
It's very simple, as we know that Console.ReadLine() reads a string and string is the set of characters. 
So we can use this method and extract its first character using 0th Index ([0]). 
In this case, we can input a single character and string also – it will return only first character.
         */
        return woodCheck;

}
    //a method that accepts number of chairs and wood type, then calculates 
public static double final_cost(int d,char ch){

double cost = 0.0;
       

        if (ch == 'p')
        {
            cost += 250;
            cost += d * 50;

        }
        else if (ch == 'm')
        {
            cost += 300;
            cost += d * 50;
        }

        else if (ch == 'o')
        {
            cost += 350;
            cost += d * 50;
        }


return cost;

}

public static void display(int d,char ch,double p){



        if (ch == 'p') 
        { 

            WriteLine("You have ordered a pine table with " + d + " chairs \r\n Total Cost is : " + p);
        }


        else if (ch == '0')
        {
            WriteLine("You have ordered a oak table with " + d + " chairs \r\n Total Cost is : " + p);
        }
        else if (ch == 'm')
        {
            WriteLine("You have ordered a mahoghany table with " + d + " chairs \r\n Total Cost is : " + p);
        }

            
       




    }



}
