// adding all known values here
int multiply_By = 50;
int add_By = 25;
double divide_By = 12.5;
int remainder_By = 7;

// user input here -- multiply by 50
Console.WriteLine("Enter a number to multiply by 50: ");
int user_input = Convert.ToInt32(Console.ReadLine());

// user input here -- add by 25
Console.WriteLine("Enter a number to add by 25: ");
int user_input2 = Convert.ToInt32(Console.ReadLine());

// user input here -- divide by 12.5
Console.WriteLine("Enter a number to divide by 12.5: ");
double user_input3 = Convert.ToDouble(Console.ReadLine());

// user input here -- remainder by 7
Console.WriteLine("Enter a number to divide by 7: ");
int user_input4 = Convert.ToInt32(Console.ReadLine());

// bool statement here
Console.WriteLine("Enter a number here:");
int user_Input5 = Convert.ToInt32(Console.ReadLine());

// multiply calculation here
Console.WriteLine(user_input * multiply_By);

// add calculation here
Console.WriteLine(user_input2 + add_By);

// divide calculation here
Console.WriteLine(user_input3 / divide_By);

// remainder calculation here
Console.WriteLine(user_input4 % remainder_By);

// bool statement here
string bool_Statement = user_Input5 > 50 ? "True" : "False";
Console.WriteLine(bool_Statement);