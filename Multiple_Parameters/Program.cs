using Multiple_Parameters;

Math_Operations math = new Math_Operations();

// user input
Console.WriteLine("Enter a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

// user input
Console.WriteLine("Enter a second number (this is optional, press enter if you want to leave this blank): ");
string num2 = Console.ReadLine();

// if the user leaves the second number blank, the default value of 3 will be used
int result = math.Add(num1, num2 == "" ? 3 : Convert.ToInt32(num2));

// output
Console.WriteLine("The result is: " + result);