﻿// See https://aka.ms/new-console-template for more information

//Declare Fixed Size Arrays
using System;

int[] grades = new int[5];
//5 space addresses - 0, 1, 2, 3, 4
//If n is the size of the array, then your array has addresses between 0 to n-1

//Add values to Fixed Size Array
//grades[0] = 1;
//grades[1] = 25;
//grades[2] = 38;
//grades[3] = 45;
//grades[4] = 54;

//grades = new int[] { 1, 25, 38, 45, 54 };
Console.WriteLine("Enter All Grades");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

//Print values in Fixed Sized Array
Console.WriteLine("The grades you entered are:");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}

//Declare Variable Sized Array
string[] studentNames = new string[] {"Test", "Student1", "etc..."};
//Add values to Variable Sized Array
Console.WriteLine("Enter All Names");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine("Enter Name: ");
    studentNames[i] = Console.ReadLine();
}
//Print values in Variable Sized Array
Console.WriteLine("The names you entered are:");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}