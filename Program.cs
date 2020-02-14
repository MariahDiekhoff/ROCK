using System;
using System.Collections.Generic;

namespace ROCK
{

  class Program
  {
    static void Main(string[] args)
    {

      //welcome the player
      //Player1 chose your hand
      //player1 option
      Console.WriteLine("Welcome Player1");
      Console.WriteLine("Player1 choose your hand : ROCK, PAPER, SCISSORS");
      var player1 = Console.ReadLine();

      //make a list for objects
      var objects = new List<string>() { "ROCK", "PAPER", "SCISSORS" };

      Random rand1 = new Random();
      var index = rand1.Next(0, 3);
      var computerChoice = objects[index];
      Console.WriteLine(computerChoice);

      //rock
      Console.WriteLine($"Computer Chose {computerChoice}");

      if (player1 == "ROCK" && computerChoice == "ROCK")
      {
        Console.WriteLine("Draw!");
      }
      else if (player1 == "PAPER" && computerChoice == "ROCK")
      {

        Console.WriteLine("Player Wins!");
      }
      else if (player1 == "SCISSORS" && computerChoice == "ROCK")
      {

        Console.WriteLine("CPU Wins!");
      }

      //paper


      if (player1 == "PAPER" && computerChoice == "PAPER")
      {
        Console.WriteLine("DRAW!");
      }
      else if (player1 == "ROCK" && computerChoice == "PAPER")
      {
        Console.WriteLine("Computer Wins!");
      }
      else if (player1 == "SCISSORS" && computerChoice == "PAPER")
      {
        Console.WriteLine("PLAYER Wins!");
      }

      //SCISSORS


      if (player1 == "SCISSORS" && computerChoice == "SCISSORS")
      {
        Console.WriteLine("DRAW!");
      }
      else if (player1 == "ROCK" && computerChoice == "SCISSORS")
      {
        Console.WriteLine("Player Wins!");
      }
      else if (player1 == "PAPER" && computerChoice == "SCISSORS")
      {
        Console.WriteLine("Computer Wins!");
      }

    }
  }
}
