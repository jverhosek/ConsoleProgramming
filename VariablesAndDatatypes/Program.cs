// See https://aka.ms/new-console-template for more information

//Variable Declarations and Types
string fullName = string.Empty;
int age = 0;
double salary = 0.0;
char gender = char.MinValue;
bool working = false;

//Promt User for Input
Console.Write("Please Enter Your Name: ");
fullName = Console.ReadLine();

Console.Write("Please Enter Your Age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please Enter Your Salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Please Enter Your Gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are You Working?: ");
working = Convert.ToBoolean(Console.ReadLine());

// Print Information
Console.WriteLine("Your name is: " + fullName); //concatenation
Console.WriteLine("Your age is: {0}", age);
Console.WriteLine($"Your Salary is: {salary}"); //interpolation
Console.WriteLine($"Your Gender is: {gender}"); //interpolation
Console.WriteLine($"You Are Employed: {working}"); //interpolation

