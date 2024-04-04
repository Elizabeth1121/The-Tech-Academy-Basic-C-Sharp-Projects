using Constructor_Assignment;

// creating a const string variable
const string input = "Hello , World!";

// creating a new instance of the Person class
var person = new Person(Console.ReadLine(), Console.ReadLine());

// printing the values of the fName and lName fields of the person object
Console.WriteLine(person.fName + " " + person.lName);

// creating a new instance of the Person class with the default constructor
var person1 = new Person();

// printing the values of the fName and lName fields of the person1 object
Console.WriteLine(person1.fName + " " + person1.lName);

// printing the value of the input variable
Console.WriteLine(input);