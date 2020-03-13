using System;
using System.Threading;

namespace ArkhamCityTextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            static void DelayWrite(string text, int charDelay = 50, bool delayNewLine = true)
            {
                foreach (char c in text)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(charDelay);
                }
                if (delayNewLine) System.Threading.Thread.Sleep(1000);
                Console.Write(Environment.NewLine);
            }

            Console.WriteLine("Are you ready to play?");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                Thread.Sleep(1000);
                DelayWrite("You've just joined 'the crew' and your about to rob a bank...");
                Thread.Sleep(1000);
                DelayWrite("What's your name?");
                string name = Console.ReadLine();
                Thread.Sleep(1000);
                DelayWrite($"Welcome {name}, My names Boss");
                Thread.Sleep(1000);
                DelayWrite("Which of my crew do you want to role with?");
                Thread.Sleep(1000);
                DelayWrite("Slade, Boss, Butch, Mothers Milk");
                response = Console.ReadLine().ToLower();


                switch (response)
                {
                    case "slade":
                        Thread.Sleep(1000);
                        Characters char1 = new Characters();
                        char1.Slade(name);
                        break;
                    case "boss":
                        Thread.Sleep(1000);
                        Characters char2 = new Characters();
                        char2.Boss(name);

                        break;
                    case "butch":
                        Thread.Sleep(1000);
                        Characters char3 = new Characters();
                        char3.Butch(name);
                        break;
                    case "mothers milk":
                        Thread.Sleep(1000);
                        Characters char4 = new Characters();
                        char4.MothersMilk(name);
                        break;
                }
            }
            else if (response == "no" || response == "maybe")
            {
                Thread.Sleep(1000);
                DelayWrite("Come back later...");
                Environment.Exit(1);
            }
            else
            {
                Thread.Sleep(1000);
                DelayWrite("The response you gave is not a valid response program terminated");
                Environment.Exit(1);


            }

        }
    }
}
