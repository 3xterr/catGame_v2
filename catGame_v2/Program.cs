using System;

namespace catGame_v2
{
    class Program
    {
        static Random random = new Random();
        static int catPosition;

        static void Main(string[] args)
        {
            initializeGame();
            playGame();
        }

        static void initializeGame()
        {
            catPosition = random.Next(1, 6);
        }

        static void playGame()
        {
            Console.WriteLine("\"Welcome to Find the cat game! Choose a door where you think the cat is:\nDoor 1\nDoor 2\nDoor 3\nDoor 4\nDoor 5");

            int playerGuess;

            do
            {
                playerGuess = getPlayerGuess();
                if (playerGuess == catPosition)
                {
                    Console.WriteLine("Congratulations! You win!!!");
                    break;
                }
                else
                {
                    MoveCat();
                }
            } while (true);
        }

        static int getPlayerGuess()
        {
            int guess;
            while (true)
            {
                Console.WriteLine("Enter your guess (1-5):");

                if (int.TryParse(Console.ReadLine(), out guess) && guess >= 1 && guess <= 5)
                {
                    return guess;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                }
            }

        }

        static void MoveCat()
        {
            int moveDirection = random.Next(1, 3);

            if (moveDirection == 1)
            {
                if (catPosition == 1)
                {
                    catPosition++;
                }
                else
                {
                    catPosition--;
                }
            }
            else if (moveDirection == 2)
            {
                if (catPosition == 5)
                {
                    catPosition--;
                }
                else
                {
                    catPosition++;
                }
            }

            Console.WriteLine("The cat has moved 1 door to the side. Try again.");
        }
    }
}