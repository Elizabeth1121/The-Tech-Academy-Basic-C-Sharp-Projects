using System.Collections.Generic;

// creating a list of integers
List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);
numbers.Add(7);
numbers.Add(8);
numbers.Add(9);
numbers.Add(10);

// asking user for a number to divide the list by
Console.WriteLine("Enter a number to divide the list by: ");

try
{
    int divisor = Convert.ToInt32(Console.ReadLine());

    // dividing each number in the list by the divisor
    for (int i = 0; i < numbers.Count; i++)
    {
        numbers[i] = numbers[i] / divisor;
        Console.WriteLine(numbers[i]);
    }
}
// looks for a divide by zero error
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero.");
}
// looks for a format error
catch (FormatException)
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}
// looks for any other error
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}
// runs finally block regardless of error
finally
{
    Console.WriteLine();
}