using Interface_Program;

// Create an instance of the Employee class
Employee employee = new Employee();
// Set the FirstName and LastName properties
employee.FirstName = "Sample";
employee.LastName = "Student";
// Call the SayName method
employee.SayName();
employee.Quit();
// Keep the console window open
Console.ReadLine();