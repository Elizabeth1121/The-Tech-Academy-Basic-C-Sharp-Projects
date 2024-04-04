using TryCatch_Assignment;

// asking user for their age
Console.WriteLine("Please enter your age: ");

// try catch block to catch any exceptions
try
{
    // user input
	int userInput = Convert.ToInt32(Console.ReadLine());

    // if user input is less than or equal to 0, throw exception
    if (userInput <= 0)
    {
        throw new NegativeAgeException();
    }
    // if user input is greater than 0, display user input
    else
    {
        Console.WriteLine("Your age is... {0}", userInput);
    }
}
// catch NegativeAgeException
catch (NegativeAgeException)
{
    // display error message
    Console.WriteLine("Age is not valid, age cannot be zero or a negative number");
}
// catch any other exceptions
catch (Exception)
{
    // display error message
    Console.WriteLine("User input was incorrect, please review your input and try again.");
}