using System;

namespace Topic_7._1_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generater = new Random();
            generater.Next(11);
            int num = generater.Next(11);

            int guess, die1, die2;
            die1 = generater.Next(1, 7);
            die2 = generater.Next(1, 7);
            Console.WriteLine("guess the number");
            int.TryParse(Console.ReadLine(), out guess);
            while (guess != num)
            {
                Console.WriteLine("try again");
                int.TryParse(Console.ReadLine(), out guess);
                Console.WriteLine();
            }
            Console.WriteLine("you got it right");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("roll dice till you get doubles");
            Console.WriteLine();
            Console.WriteLine("Press enter to roll");
            Console.ReadLine();
            Console.WriteLine(die1 + " " + die2);
            while (die1 != die2)
            {
                Console.WriteLine("roll again");
                Console.ReadLine();
                die1 = generater.Next(1, 7);
                die2 = generater.Next(1, 7);
                Console.WriteLine(die1 + " " + die2);
                Console.WriteLine();
            }
            Console.WriteLine("you got it!");
            Console.ReadLine();
            Console.Clear();
            bool done = false;
            int entry = 12345, tries = 0, pin = 0;
            Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            while (!done)
            {
                Console.WriteLine("ENTER YOUR PIN: ");
                while (!Int32.TryParse(Console.ReadLine(), out pin))
                    Console.WriteLine("Please enter a valid number");
                tries++;
                if (pin == entry)
                {
                    Console.WriteLine("Pin Accepted.");
                    done = true;
                }
                else if (tries == 5)
                {
                    Console.WriteLine("Too many incorrect tries. Access denied");
                    done = true;
                }
            }
            Console.ReadLine();
            Console.Clear();
            int count = 0;
            Console.WriteLine("Type in a message, and I'll display it 5 times.");
            Console.Write("Message: ");
            string message = Console.ReadLine();
            while (count < 10)
            {
                Console.WriteLine((count + 1) + ". " + message);
                count++;
            }
            Console.ReadLine();
            Console.Clear();
            int repeat, messageTimes;
            string messages;
            messageTimes = 0;
            Console.WriteLine("Massage:");
            messages = Console.ReadLine();
            Console.WriteLine("how many times?");
            int.TryParse(Console.ReadLine(), out repeat);
            while (messageTimes < repeat)
            {
                Console.WriteLine(messages);
                messageTimes++;
            }
            Console.ReadLine();
            Console.Clear();
            int total = 0;
            int impcount = 0;
            int numbers = 5;
            int givenNum;
            Console.WriteLine("give number and i add them up");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            while (impcount < numbers)
            {
                Console.WriteLine("give number");
                int.TryParse(Console.ReadLine(), out givenNum);
                total += givenNum;
                impcount++;
            }
            Console.WriteLine();
            Console.WriteLine("total is: " + total);
            Console.ReadLine();
        }
    }
}
