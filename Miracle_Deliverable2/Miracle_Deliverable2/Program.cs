//variables
string userName;
string challAnswer;
int userScore = 0;
Random randomNumberGenerator = new Random();


Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");

Console.WriteLine("What is your Name?");

userName = Console.ReadLine();

Console.WriteLine("Do you want to do the COIN FLIP CHALLENGE? Yes/No");

challAnswer = Console.ReadLine();

if (challAnswer == "No")
{
    Console.WriteLine("You are a coward " + userName);
}
else if (challAnswer == "Yes")
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Heads or Tails?");
        string userFlip = Console.ReadLine();
        int coinFlip = randomNumberGenerator.Next(2); // randomly generates a 0 or a 1

        if (coinFlip == 0  && userFlip == "Heads")
        {
            Console.WriteLine("Correct!");
            userScore++;

        }
        else if (coinFlip == 1 && userFlip == "Tails")
        {
            Console.WriteLine("Correct!");
            userScore++;
        }
        else 
        {
            Console.WriteLine("Wrong!");
        }
    }
    Console.WriteLine("Thank you " + userName + " You got a score of " + userScore + ".");
}
