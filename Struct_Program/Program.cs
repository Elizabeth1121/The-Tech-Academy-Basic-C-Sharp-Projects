// create a struct with a property that has a getter and a setter
Number number = new Number();

// set the value of the property
number.Amount = 100.0m;

// print the value of the property
Console.WriteLine(number.Amount);

// define a struct
struct Number
{
    // define a property with a getter and a setter
    public decimal Amount { get; set; }
}
