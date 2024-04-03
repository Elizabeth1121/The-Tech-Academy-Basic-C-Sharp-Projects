using Lambda_Assignment;

// create a list of 10 employees
Employee employee1 = new Employee() { Id = 1, firstName = "Joe", lastName = "Smith" };
Employee employee2 = new Employee() { Id = 2, firstName = "Jane", lastName = "Doe" };
Employee employee3 = new Employee() { Id = 3, firstName = "John", lastName = "Doe" };
Employee employee4 = new Employee() { Id = 4, firstName = "Jane", lastName = "Smith" };
Employee employee5 = new Employee() { Id = 5, firstName = "John", lastName = "Smith" };
Employee employee6 = new Employee() { Id = 6, firstName = "Joe", lastName = "Doe" };
Employee employee7 = new Employee() { Id = 7, firstName = "Jane", lastName = "Smith" };
Employee employee8 = new Employee() { Id = 8, firstName = "John", lastName = "Doe" };
Employee employee9 = new Employee() { Id = 9, firstName = "Joe", lastName = "Smith" };
Employee employee10 = new Employee() { Id = 10, firstName = "Jane", lastName = "Doe" };

// create a list of employees
List<Employee> employees = new List<Employee>() { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };
// create a list of employees with the first name Joe
List<Employee> joes = new List<Employee>();
// create a list of employees with an Id greater than 5
List<Employee> id_Number = new List<Employee>();

// loop through the list of employees and add the employees with the first name Joe to the joes list
foreach (Employee employee in employees)
{
    if (employee.firstName == "Joe")
    {
        joes.Add(employee);
    }
}

// loop through the list of employees and add the employees with an Id greater than 5 to the id_Number list
joes.AddRange(employees.Where(x => x.firstName == "Joe").ToList());

// loop through the list of employees and add the employees with an Id greater than 5 to the id_Number list
id_Number.AddRange(employees.Where(x => x.Id > 5).ToList());