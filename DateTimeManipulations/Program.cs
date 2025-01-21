// See https://aka.ms/new-console-template for more information

//Empty DateTime
using System;
using System.Globalization;

DateTime date = new DateTime();

//Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(2002, 10, 1);
Console.WriteLine("My Dob is: " + dateOfBirth);
Console.WriteLine("My Dob is: " + dateOfBirth.Date);

Console.WriteLine("Day of Week: " + dateOfBirth.DayOfWeek);
Console.WriteLine("Day of Year: " + dateOfBirth.DayOfYear);

//Crate a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The time now is: " + now);

//Create a DateTime from a String
DateTime dateFromString = DateTime.Parse("1/31/2021", CultureInfo.InvariantCulture);
Console.WriteLine("The Date from string is: " + dateFromString);

//Add Aditional Time
Console.WriteLine("One hour from now is: " + now.AddHours(1));
Console.WriteLine("One day from now is: " + now.AddDays(1));

//Ticks from DateTime
Console.WriteLine("Time as a numeral: " + now.Ticks);

//Date Only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Date Only: " + dateOnlyOfBirth);

//Time Only
TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine("Time Only: " + timeOnly);