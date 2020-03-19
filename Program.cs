using System;

namespace cs_day1
{
  class Program
  {
    static void Main(string[] args)
    {
      Boolean running = true;
      int playerScore = 0;
      int compScore = 0;
      int tieCounter = 0;
      Console.Write("Please enter your name: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Thank you, {name}");

      Console.WriteLine("Would you like to play a game? (y/n)");
      if (Console.ReadKey().KeyChar == 'n' || Console.ReadKey().KeyChar == 'N')
      {
        running = false;
      }
      while (running)
      {

        Console.Clear();
        Console.WriteLine("Rock, Paper, or Scissors?");
        string playerChoice = Console.ReadLine().ToLower().Trim();
        Random rnd = new Random();
        int compRandom = rnd.Next(3);
        string[] choices = new string[]{
            "rock",
            "paper",
            "scissors"
        };

        while (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
        {
          Console.WriteLine("Please enter Rock, Paper, or Scissors.");
          playerChoice = Console.ReadLine().ToLower().Trim();
        };

        string compChoice = choices[compRandom];
        Console.WriteLine($"Player chose: {playerChoice}, Computer chose: {compChoice}");

        if (playerChoice == compChoice)
        {
          Console.WriteLine("It's a tie!");
          tieCounter++;
        }
        else if (playerChoice == "rock")
        {
          if (compChoice == "paper")
          {
            Console.WriteLine("Computer wins!");
            compScore++;
          }
          else
          {
            Console.WriteLine($"{name} wins!");
            playerScore++;
          }
        }
        else if (playerChoice == "paper")
        {
          if (compChoice == "scissors")
          {
            Console.WriteLine("Computer wins!");
            compScore++;
          }
          else
          {
            Console.WriteLine($"{name} wins!");
            playerScore++;
          }
        }
        else if (playerChoice == "scissors")
        {
          if (compChoice == "rock")
          {
            Console.WriteLine("Computer wins!");
            compScore++;
          }
          else
          {
            Console.WriteLine($"{name} wins!");
            playerScore++;
          }
        }

        Console.WriteLine($"Current Score: {name}: {playerScore} Computer: {compScore} Ties: {tieCounter}");
        Console.WriteLine("Would you like to play again? (y/n)");

        if (Console.ReadKey().KeyChar == 'n')
        {
          running = false;
          Console.WriteLine();
          Console.WriteLine($"Thank you for playing, {name}!");
          break;
        }

      }
    }
  }
}
