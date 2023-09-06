namespace RockPaperScissors
{
    public class Program
    {
        public static void MyMethod()
        {
            // Repeat the game
            Console.WriteLine("Do you want to play again? : Y/N");
            string playAgain = Console.ReadLine();

            if (playAgain == "Y" || playAgain == "y" || playAgain == "Yes" || playAgain == "yes")
            {
                TheGame();
            }
            else
            {
                Console.WriteLine("Thank you for playing");
            }
        }
        public static void TheGame()
        {
            string[] choice = {"R", "P", "S"};
            Random random = new Random();

            // Get bot answer
            int botAnswer;
            botAnswer = random.Next(0,2);

            // Get user answer
            Console.WriteLine("Choose between one of these : R = Rock, P = Paper, S = Scissors");
            string playerAnswer = Console.ReadLine();

            // Prints out what the bot has chosen
            if (botAnswer == 0)
            {
                Console.WriteLine("The computer chose: Rock");
            }
            else if (botAnswer == 1)
            {
                Console.WriteLine("The computer chose: Paper");
            }
            else
            {
                Console.WriteLine("The computer chose: Scissors");
            }

            // Checks who wins
            if (playerAnswer == "r" || playerAnswer == "R")
            {
                if (botAnswer == 0)
                {
                    Console.WriteLine("Draw");
                    MyMethod();
                }
                else if (botAnswer == 1)
                {
                    Console.WriteLine("You lost");
                    MyMethod();
                }
                else
                {
                    Console.WriteLine("You win");
                    MyMethod();
                }
            }
            else if (playerAnswer == "p" || playerAnswer == "P")
            {
                if (botAnswer == 0)
                {
                    Console.WriteLine("You win");
                    MyMethod();
                }
                else if (botAnswer == 1)
                {
                    Console.WriteLine("Draw");
                    MyMethod();
                }
                else
                {
                    Console.WriteLine("You lost");
                    MyMethod();
                }
            }
            else
            {
                if (botAnswer == 0)
                {
                    Console.WriteLine("You lost");
                    MyMethod();
                }
                else if (botAnswer == 1)
                {
                    Console.WriteLine("You win");
                    MyMethod();
                }
                else
                {
                    Console.WriteLine("Draw");
                    MyMethod();
                }
            }
        }
        static void Main(string[] args)
        {
            // Welcome
            Console.WriteLine("Welcome to my Rock/Paper/Scissors");
            TheGame();
        }
    }   
}