/*
The Console.ReadLine() method returns a string. Therefore, you cannot get information from another data type, such as int.
You can convert any type explicitly, by using one of the Convert.To methods:
*/
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age);
