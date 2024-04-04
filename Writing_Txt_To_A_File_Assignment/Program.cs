using System.IO;

// Ask the user for a number
Console.WriteLine("Hello user! Please type a number: ");
// Read the number from the user
int usernumber = Convert.ToInt32(Console.ReadLine());

// Write the number to a file -- **change the path to your file**
using (StreamWriter file = new StreamWriter(@"C: \path\to\your\file.txt"))
{
    // Write the number to the file
    file.WriteLine(usernumber);
}