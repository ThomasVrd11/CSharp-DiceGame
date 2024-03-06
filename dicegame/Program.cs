using System;

namespace dicegame
{
    class Program
    {
        static void Main(string[] args)
        {  
            string player1;
            string player2;

            System.Console.WriteLine("Enter Player 1's name: ");
            player1 = System.Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrEmpty(player1))
            {
                System.Console.WriteLine("Player 1's name cannot be empty! Please enter a name: ");
                player1 = System.Console.ReadLine() ?? string.Empty;              
            }
            if (player1 == "Hitler")
            {
                System.Console.WriteLine("bro wtf");
                return;
            }            
            System.Console.WriteLine("Enter Player 2's name: ");
            player2 = System.Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrEmpty(player2))
            {
                System.Console.WriteLine("Player 2's name cannot be empty! Please enter a name: ");
                player2 = System.Console.ReadLine() ?? string.Empty;         
            }

            int player1rn = 0;
            int player2rn = 0;
            int player1score = 0;
            int player2score = 0;
            
            System.Console.WriteLine("Welcome to the Dice Game!");

            for (int i = 0; i < 5; i++)
            {

                System.Console.WriteLine("Press any key to roll the dice!");
                Console.ReadKey();
                Random rnd = new Random();
                player1rn = rnd.Next(1, 7);
                player2rn = rnd.Next(1, 7);

                System.Console.WriteLine($"{player1} rolled a {player1rn}");
                System.Console.WriteLine($"{player2} rolled a {player2rn}");

                if (player1rn > player2rn)
                {
                    player1score+=5;
                    System.Console.WriteLine($"{player1} wins this round! He gets 5 points!");
                }
                else if (player2rn > player1rn)
                {
                    player2score+=5;
                    System.Console.WriteLine($"{player2} wins this round! He gets 5 points!");
                }
                else
                {
                    System.Console.WriteLine("It's a tie! Both players get 2 points!");
                    player1score+=2;
                    player2score+=2;
                }
                System.Console.WriteLine();
            }
                System.Console.WriteLine();
                System.Console.WriteLine($"{player1} has {player1score} points");
                System.Console.WriteLine($"{player2} has {player2score} points");
                if (player1score > player2score)
                {
                    System.Console.WriteLine($"{player1} wins!");
                }
                else if (player2score > player1score)
                {
                    System.Console.WriteLine($"{player2} wins!");
                }
                else
                {
                    System.Console.WriteLine("It's a tie! Go fuck yourself!");
                }
            
            Console.ReadKey();
        }
    }
}