using System;
using System.Collections.Generic;

// creating string array
string[] names = new string[5] { "John", "Jane", "Joe", "Jill", "Jack" };

// asking for index of the array
Console.WriteLine("Please provide an array index 0-4");
int userInput_String = Convert.ToInt32(Console.ReadLine());

// displaying name at that index
Console.WriteLine("The name at index " + userInput_String + " is " + names[userInput_String]);

// creating array
int[] numbers = new int[6] { 1, 2, 3, 4, 5, 6 };

// asking for index of the array
Console.WriteLine("Please provide an array index 0-5");
int userInput = Convert.ToInt32(Console.ReadLine());

// checking for valid user input
if(userInput < 0 || userInput > 5)
{
    Console.WriteLine("Invalid input");
}
else
{
    // displaying number at that index
    Console.WriteLine("The number at index " + userInput + " is " + numbers[userInput]);
}