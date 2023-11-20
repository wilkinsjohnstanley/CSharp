using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESKGUI
{
public partial class Form1 : Form
{
public Form1()
{
InitializeComponent();
}

private void button1_Click(object sender, EventArgs e)
{
string num = textBox1.Text;
// calling drawer function
int number = drawers(num);
string wood = textBox2.Text;
// calling wood function
string type = woods(wood);
// calling cost function
double price = cost(number, type);
//calling function result
string res = result(number, wood, price);
label3.Text = res;

}
static int drawers(string num)
{
int numberDrawers = Convert.ToInt32(num);
return numberDrawers;
}
static string woods(string wood)
{
// assign value to wood type
string ch;
wood.ToLower();
if (wood == "pine")
ch = "p";
else if (wood == "oak")
ch = "o";
else if (wood == "mahogani")
ch = "m";
return ch;
}
static double cost(int number, string wood, double price)
{
//calculate price
double price;
if (wood == "p")
price = 100 + (number * 30);
else if (wood == "0")
price = 140 + (number * 30);
else if (wood == "m")
price = 180 + (number * 30);
return price;

}
static string result (int number, string wood, double price)
{
string res = "Number of drawers are" + number + "\n Desk is made up of" + wood + "\n Cost of the table is $" + price;
return res;
}
}
}
