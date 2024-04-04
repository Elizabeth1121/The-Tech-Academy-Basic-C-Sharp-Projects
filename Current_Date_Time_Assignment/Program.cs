
// getting the current time
DateTime currentTime = DateTime.Now;

// printing the current time
Console.WriteLine(currentTime);

// askin the user for a number
Console.WriteLine("Please give me a number: ");

// reading the number from the user
int number = int.Parse(Console.ReadLine());

// printing the time after the number of hours
Console.WriteLine(currentTime.AddHours(number) + " hours from now");