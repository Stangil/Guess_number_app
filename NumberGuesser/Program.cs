using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            //Ask users name
            GreetUser();
            //START GAME
            while (true)
            {
                //Set number
                //CReate random number to guess
                Random random = new Random();
                int number = random.Next(1, 10);

                //Initialize guess var
                int guess = 0;

                //Ask user for number
                while (guess != number)
                {
                    Console.WriteLine("Guess a number between 1 and 10");
                    string inputNumber = Console.ReadLine();
                    //Check to see if guess is correct
                    if (!int.TryParse(inputNumber, out guess))
                    {
                        printColorMessage(ConsoleColor.Red, "Please enter a valid number");
                        continue;
                    }
                    //Check to see if input is a valid number
                    guess = Int32.Parse(inputNumber);
                    if (guess != number)
                    {
                        printColorMessage(ConsoleColor.Red, "Wrong number please try again!");
                    }
                    else
                    {
                        printColorMessage(ConsoleColor.Blue, "Correct!");

                        Console.WriteLine("Play Again? [Y or N?]");
                        string answer = Console.ReadLine().ToUpper();

                        if (answer == "Y")
                        {
                            continue;
                        }
                        else if(answer == "N")
                        {
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }
        static void GetAppInfo()
        {
            //Set app vars
            String appName = "Number Guesser";
            String appVersion = "1.1.0";
            String appAuthor = "Stan d man";
            // change text color
            Console.ForegroundColor = ConsoleColor.Blue;
            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            //reset text color
            Console.ResetColor();
        }
        static void GreetUser()
        {
            Console.WriteLine("Type your name: ");
            //get name
            String inputName = Console.ReadLine();
            Console.WriteLine("Hello {0} lets play!", inputName);
        }
        //Changes color to print messages
        static void printColorMessage(ConsoleColor color, String mes)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mes);
            Console.ResetColor();
        }
    }
}
