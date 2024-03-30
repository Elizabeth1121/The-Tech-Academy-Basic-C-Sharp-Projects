// Print statement here
Console.WriteLine("Anonymous Income Comparison Program");

// for the first person
Console.WriteLine("Person 1");

Console.WriteLine("Hourly Rate?");
double hourlyRate1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Hours worked per week?");
int hoursWorked1 = Convert.ToInt32(Console.ReadLine());

// for the second person
Console.WriteLine("Person 2");

Console.WriteLine("Hourly Rate?");
double hourlyRate2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Hours worked per week?");
int hoursWorked2 = Convert.ToInt32(Console.ReadLine());

// Annual salary for the first person
Console.WriteLine("Annual salary of Person 1:");
double annualSalary1 = hourlyRate1 * hoursWorked1 * 52;
Console.WriteLine(annualSalary1);

// Annual salary for the second person
Console.WriteLine("Annual salary of Person 2:");
double annualSalary2 = hourlyRate2 * hoursWorked2 * 52;
Console.WriteLine(annualSalary2);