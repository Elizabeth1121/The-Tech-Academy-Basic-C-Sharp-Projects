using Overloading_Operators;

// create two employee objects
Employee employee = new Employee();
employee.ID = 1;
employee.firstName = "Joe";
employee.lastName = "Smith";

Employee employee2 = new Employee();
employee2.ID = 2;
employee2.firstName = "Joe";
employee2.lastName = "Smith";

// compare the two employee objects
Console.WriteLine(employee == employee2);
Console.WriteLine(employee != employee2);