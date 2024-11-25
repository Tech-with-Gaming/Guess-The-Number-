Random random = new Random();
bool playAgain = true;

int min = 0;
int max = 100;
int guess;
int number;
int guesses;
String response;

while (playAgain)
{
    guess = 0;
    guesses = 0;
    number = random.Next(min, max + 1);
    response = "";
    
    while (guess != number)
    {
        Console.WriteLine("Enter Your Guess " + min + "-" + max + ":");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Guess: " + guess);

        if (guess > number)
        {
            Console.WriteLine("Go Low!");
        }
        else if (guess < number)
        {
            Console.WriteLine("Go High!");
        }
        guesses++;
    }
    Console.WriteLine("Number: " + number);
    Console.WriteLine("You Win!");
    Console.WriteLine("You Guessed in : " + guesses);

    Console.WriteLine("Would You like to Play Again? [y/n]: ");
    response = Console.ReadLine();
    response = response.ToLower();

    if (response == "y")
    {
        playAgain = true;

    }
    else
    {
        playAgain = false;
    }

}
Console.WriteLine("----------Thanks For Playing----------");