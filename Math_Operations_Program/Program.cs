using Math_Operations_Program;


// creating an instance of the Operations class
Operations operations = new Operations();

// Prompting the user to enter a number
Console.WriteLine("Hello! please pick a number you would like to do math operations on.");
int number = Convert.ToInt32(Console.ReadLine());

// calling the methods from the Operations class
int numberAddition = operations.Add(number);
int numberSubtraction = operations.Subtract(number);
int numberMultiplication = operations.Multiply(number);

// Displaying the results
Console.WriteLine("For addition the anwser is: " + numberAddition);
Console.WriteLine("For subtraction the anwser is: " + numberSubtraction);
Console.WriteLine("For multiplication the anwser is: " + numberMultiplication);