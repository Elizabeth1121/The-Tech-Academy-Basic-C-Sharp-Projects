using Generic_Type_Parameter_Assignment;

// creating an instance of the Employee class with a type parameter of string
Employee<string> employee = new Employee<string>();
// adding items to the list of type string
employee.things.Add("Hello");
employee.things.Add("World");
employee.things.Add("!");

// creating an instance of the Employee class with a type parameter of int
Employee<int> employee2 = new Employee<int>();
// adding items to the list of type int
employee2.things.Add(1);
employee2.things.Add(2);
employee2.things.Add(3);
employee2.things.Add(4);

// printing the items in the list of type string
foreach (string thing in employee.things)
{
    Console.WriteLine(thing);
}

// printing the items in the list of type int
foreach (int thing in employee2.things)
{
    Console.WriteLine(thing);
}