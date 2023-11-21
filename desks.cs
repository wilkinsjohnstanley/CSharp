using System;

using System.Linq;

using System.Collections;

using System.Collections.Generic;



public class Test{

public static int no_drawer(){

Console.WriteLine("Enter the number of drawers : ");

return Int32.Parse(Console.ReadLine());

}

public static char wood_type(){

Console.WriteLine("Enter the type of woods('m' for mahogany, 'o' for oak, or 'p' for pine) : ");

return Console.ReadLine()[0];

}

public static double final_cost(int d,char ch){

double cost = 0.0;

if (ch == 'p') cost += d*100;

else if (ch == 'o') cost += d*140;

else cost += d*180;

cost += d*30;

return cost;

}

public static void display(int d,char ch,double p){

Console.WriteLine("Number of drawers : "+d);

if (ch == 'p')

Console.WriteLine("Type of Wood Chosen : pine");

else if (ch == '0')

Console.WriteLine("Type of Wood Chosen : oak");

else if (ch == 'm')

Console.WriteLine("Type of Wood Chosen : mahogany");

else

Console.WriteLine("Type of Wood Chosen : other");

Console.WriteLine("Total Cost is : "+p);

}

public static void Main(){

int drawers = no_drawer();

char ch_wood = wood_type();

double res = final_cost(drawers,ch_wood);

display(drawers, ch_wood,res);

}

}
