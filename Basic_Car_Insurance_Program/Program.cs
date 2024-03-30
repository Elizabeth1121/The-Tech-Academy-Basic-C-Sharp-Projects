bool qualified = true;

// ask for age
Console.WriteLine("What is you age?");
int age = Convert.ToInt32(Console.ReadLine());

// how many speeding tickets do you have?
Console.WriteLine("How many speeding tickets do you have?");
int tickets = Convert.ToInt32(Console.ReadLine());

// ever had a dui?
Console.WriteLine("Have you ever had a DUI? (true or false)");
bool DUI = Convert.ToBoolean(Console.ReadLine());

// applicants must be over 15 years of age
// may not have DUIs
// no more than three speeding tickets
if (age < 15 || DUI == true || tickets > 3)
{
    qualified = false;
}

Console.WriteLine("Qualified?");
Console.WriteLine(qualified);