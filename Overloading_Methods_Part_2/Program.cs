// for the static class
using Overloading_Methods_Part_2;

// using the static class with the divide method
Overloading_Part_2.MyMethod(10);

//user input
Console.WriteLine("Enter a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

// user input
Console.WriteLine("Enter another number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// result of the method
Console.WriteLine("Anwser " + Overloading_Part_2.Multiply(num1, num2) + '\n');

// user input
Console.WriteLine("Enter a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

// result of the overloaded method
Console.WriteLine("Anwser " + Overloading_Part_2.Multiply(num1, num2, num3) + '\n');

// for the non-static class
Non_Static ns = new Non_Static();
Console.WriteLine(ns.Add(10, 20));