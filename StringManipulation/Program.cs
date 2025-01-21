// See https://aka.ms/new-console-template for more information
using System.Globalization;

string firstName = "Justin";
string lastName = "Verhosek";
DateTime date = DateTime.Now;

// Print to Screen
Console.WriteLine(firstName);
Console.WriteLine("String being printed");

// Concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("My full name is " + lastName +  " " + firstName);
Console.WriteLine($"My full name is {lastName}, {firstName}");

//String length
int length = firstName.Length;
Console.WriteLine($"Your name is {length} letter long");

//Replace string parts
string newName = firstName.Replace('J', 'A');
Console.WriteLine($"You new name is {newName}");

string newName1 = firstName.Replace('i', ' ');
Console.WriteLine($"You new name is {newName1}");

//Append to other string variables
string fullName = firstName + " " + lastName;
Console.WriteLine($"Your full name is {fullName}");

//Split String
string[] splitName = fullName.Split('v');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

string nullString = null;
string emptyString = "";
string whiteSpaceString = " ";

//Comapare Strings
if(string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}

if(firstName == lastName)
{
    Console.WriteLine("Name are equal");
}

if (firstName != lastName)
{
    Console.WriteLine("Name are not equal");
}

int comparisonResult = string.Compare(firstName, lastName);

if(comparisonResult == 0)
{
    Console.WriteLine("Names are equal");
}

else
{
    Console.WriteLine("Names are not equal");
}

//Convert to String
string convertedString = String.Empty;
int number = 123456789;

convertedString = number.ToString();
convertedString = 1478852369.ToString();

fullName.ToUpper();
fullName.ToLower();