
// try catch block to handle the exception when the user enters an invalid day of the week
try
{
    // Prompt the user to enter the current day of the week
    Console.WriteLine("Please enter the current day of the week: ");
    string user_Input = Console.ReadLine();

    // Convert the user input to the enum type
    days_Of_The_Week day = (days_Of_The_Week)Enum.Parse(typeof(days_Of_The_Week), user_Input);
}
// Catch the exception when the user enters an invalid day of the week
catch (ArgumentException)
{
    // Display an error message to the user
    Console.WriteLine("Please enter a valid day of the week.");
}


// public enum to define the days of the week
public enum days_Of_The_Week
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}