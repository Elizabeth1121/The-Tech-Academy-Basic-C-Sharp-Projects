decimal weight = 0;

// greeting
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

// Prompt user for package weight
Console.WriteLine("Please enter the package weight:");
weight = Convert.ToDecimal(Console.ReadLine());

if(weight > 50)
{
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
    return;
}

// if weight is less than or equal to 50, continue with the program
decimal width = 0;
decimal height = 0;
decimal length = 0;

// Prompt user for package width
Console.WriteLine("Please enter the package width:");
width = Convert.ToDecimal(Console.ReadLine());

// Prompt user for package height
Console.WriteLine("Please enter the package height:");
height = Convert.ToDecimal(Console.ReadLine());

// Prompt user for package length
Console.WriteLine("Please enter the package length:");
length = Convert.ToDecimal(Console.ReadLine());

// checking package dimensions
if (width <= 50 && height <= 50 && length <= 50)
{
    decimal total = (weight * width * height * length) / 100;

    // calculate shipping cost
    Console.WriteLine("Your estimated total for shipping this package is: $" + total);
    Console.WriteLine("Thank you.");
}
else
{
    // package too big
    Console.WriteLine("Package too big to be shipped via Package Express.");
}