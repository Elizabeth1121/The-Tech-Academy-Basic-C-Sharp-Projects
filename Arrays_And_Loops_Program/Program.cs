using System.Collections.Generic;
using System.Collections.Specialized;

// string array
string[] myString = new string[5];

Console.WriteLine("Enter some text please.");

// loop through the array and assign the user input to each element
for (int i = 0; i < myString.Length; i++)
{
    myString[i] = Console.ReadLine();
}

Console.WriteLine("You entered the following text:");

// loop through the array and print each element
foreach (string s in myString)
{
    Console.WriteLine(s);
}

// infinite loop
while (true)
{
    Console.WriteLine("This is an infinite loop");

    // fixing loop here
    Console.WriteLine("Press any key to exit the loop");
    Console.ReadKey();
    break;
}

// loop with a condition
int counter = 0;
while (counter < 5)
{
    Console.WriteLine("This loop will run 5 times");
    counter++;
}

// adding a space
Console.WriteLine(" ");

// loop with a condition
int counter2 = 0;
do
{
    Console.WriteLine("This loop will run 6 times");
    counter2++;
} while (counter2 <= 5);

// adding a list of strings
List<string> myStringList = new List<string>();
myStringList.Add("Hello");
myStringList.Add("World");
myStringList.Add("!");
myStringList.Add("This");
myStringList.Add("is");
myStringList.Add("a");
myStringList.Add("list");

Console.WriteLine("Please type in a word to see if it was added to our list: ");
string userInput = Console.ReadLine();

// see if user asked for an item from the list that dosent exist
if (!myStringList.Contains(userInput))
{
    Console.WriteLine("The word you entered is not in the list.");
}

// loop through the list and check if the user input is in the list
for (int i = 0;i < myStringList.Count;i++)
{
    if (myStringList[i] == userInput)
    {
        Console.WriteLine("The word is at this index: " + i);
        break;
    }
}

// a list of strings with two identical strings
List<string> myStringList2 = new List<string>();
myStringList2.Add("Hello");
myStringList2.Add("World");
myStringList2.Add("!");
myStringList2.Add("This");
myStringList2.Add("is");
myStringList2.Add("a");
myStringList2.Add("list");
myStringList2.Add("Hello");

// asking for user input
Console.WriteLine("Please type in a word to see if it was added to our list: ");
string userInput2 = Console.ReadLine();

// see if user asked for an item from the list that dosent exist
if (!myStringList2.Contains(userInput2))
{
    Console.WriteLine("The word you entered is not in the list.");
}

// loop through the list and check if the user input is in the list
for (int x = 0; x < myStringList2.Count; x++)
{
    if (myStringList2[x] == userInput2)
    {
        Console.WriteLine("The word is at this index: " + x);
    }
}

// a list with two identical strings
List<string> myStringList3 = new List<string>();
myStringList3.Add("Hello");
myStringList3.Add("World");
myStringList3.Add("!");
myStringList3.Add("This");
myStringList3.Add("is");
myStringList3.Add("a");
myStringList3.Add("list");
myStringList3.Add("Hello");

// create a list to store alreadey seen strings
List<string> seenStrings = new List<string>();

// for each loop to find dupe strings
foreach(string s in myStringList3)
{
    if(seenStrings.Contains(s))
    {
        Console.WriteLine("This string is a duplicate: " + s);
    }
    else
    {
        seenStrings.Add(s);
    }
}