﻿// See https://aka.ms/new-console-template for more information

//Basic Assignment Operator
int num = 5;

//Arithmetic Operators 
int num1 = 11;
int num2 = 12;
int sum = num1 + num2;

Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}");

num1 = num1 + 4;
Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}");

//Compound Assignment Operators

num1 += 4; //num1 = num1 + 4; 19
Console.WriteLine(num1);
num1 -= 4; //num1 = num1 - 4; 15
Console.WriteLine(num1);
num1 *= 4; //num1 = num1 * 4; 60
Console.WriteLine(num1);
num1 /= 4; //num1 = num1 / 4; 15
Console.WriteLine(num1);
num1 %= 4; //num1 = num1 % 4; 3
Console.WriteLine(num1);