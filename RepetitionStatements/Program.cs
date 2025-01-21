// See https://aka.ms/new-console-template for more information

// For Loop (Counter Controlled)
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("I am in a loop");
}

Console.WriteLine();
Console.WriteLine("FOR LOOP Finished");

// While Loop (Condition Controlled - Pre Check)
int n = 0;
while(n < 5)
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {n}: *");
}

Console.WriteLine();
Console.WriteLine("WHILE LOOP Finished");

//Do... While Loop (Condition Controlled - Post Check)
n = 0;
do
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {n}: *");
} while(n < 5);

// Foreach - Honourable Mention
//foreach (var item in collection);
