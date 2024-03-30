//creating random number
Random random = new Random();
int randomNumber = random.Next(1, 100);

// Start of the game
Console.WriteLine("Welcome to the Number Guessing Game! \n \nI have selected a random number between 1 and 100." +
    "\nCan you guess the number? \nPlease enter your guess: ");

// take input from user
int userGuess = Convert.ToInt32(Console.ReadLine());

// check if the user guess is correct
while(userGuess != randomNumber)
{
    // if correct
    if (userGuess == randomNumber)
    {
        break;
    }

    // if too low
    if(userGuess < randomNumber)
    {
        Console.WriteLine("Your guess is too low. Please try again: ");
        userGuess = Convert.ToInt32(Console.ReadLine());
    }
    // if too high
    else
    {
        Console.WriteLine("Your guess is too high. Please try again: ");
        userGuess = Convert.ToInt32(Console.ReadLine());
    }
}

// you win!
Console.WriteLine("Congratulations! You have guessed the correct number. The number was: " + randomNumber);