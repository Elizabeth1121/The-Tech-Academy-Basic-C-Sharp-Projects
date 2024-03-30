// added using statement to use System.Text
using System.Text;

// showing string concatenation
string str_1 = "Hello";
string str_2 = "World";
string str_3 = "!";


// concatenates the strings
string str_Concatenations = str_1 + " " + str_2 + str_3;
Console.WriteLine(str_Concatenations);

// converts the string to uppercase
string str_Uppercase = str_Concatenations.ToUpper();
Console.WriteLine(str_Uppercase);

// creates a string bilder and builds a pharagraph one sentence at a time
StringBuilder sb = new StringBuilder();

// appends the strings to the string builder
sb.Append("Hello");
sb.Append(" ");
sb.Append("World");
sb.Append("!");

// converts the string builder to a string
Console.WriteLine(sb.ToString());