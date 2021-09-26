using System;

namespace HigherLowerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {// function called for appinfo.
                appinfo();

                //random created
                Random rnd = new Random();

                //user and ai input collected
                Console.WriteLine("Enter a number between 1 and 10");

                int user = Convert.ToInt32(Console.ReadLine());
                int ai = rnd.Next(1, 10);
                Console.WriteLine("User number is:{0} ", user);
                Console.WriteLine("Ai number is:{0}", ai);

                // if statements created to check who wins
                if (user > ai)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("User wins");
                    Console.ResetColor();

                }
                else if (user < ai)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ai wins");
                    Console.ResetColor();

                }
                else
                {

                    Console.WriteLine("It is a Draw");
                }

                //Loop created to restart game after it finishes.
                Console.WriteLine("play again [Y or N]");
                String answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;

                }else if (answer == "N")
                {
                    return;

                }else
                {
                    return;
                }

            }

            //Function created for app info.
            static void appinfo()
            {

                String name = "higherlowergame";
                String version = "1.0";
                String author = "Saqib Mahmood";

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("{0}: Version {1} by {2}", name, version, author);
                Console.ResetColor();

            }

        }
    }
}
