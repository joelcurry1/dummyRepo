using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ArkhamCityTextAdventure
{
    class Characters
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
        public void Slade(string Name)
        {
            Thread.Sleep(2000);
            DelayWrite($"Good day Mate! Nothing i like more than a firefight! I hope your ready for some action {Name}");
            Thread.Sleep(2000);
            DelayWrite("Here take this sword");
            Thread.Sleep(3000);
            DelayWrite("Will you take the Sword?");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                Thread.Sleep(2000);
                DelayWrite($"Smart {Name}! Lets Role!");
                Thread.Sleep(3000);
                DelayWrite($"Alright {Name} on 3 we bust through the front door and you make a Dash for the vault.... I'll Watch the hostages!");
                Thread.Sleep(3000);
                DelayWrite("Ready...... 3...2...1!!");
                Thread.Sleep(3000);
                DelayWrite("You rush to the Vault, get the cash run out only to find.....");
                Thread.Sleep(2000);
                DelayWrite("The place is full of cops! Guns are pointed at you! The cops yell at you!");
                Thread.Sleep(3000);
                DelayWrite("GET DOWN ON THE GROUND!!!");
                Thread.Sleep(3000);
                DelayWrite("Do you reach for your sword?");
                string response1 = Console.ReadLine().ToLower();
                if (response1 == "yes")
                {
                    Thread.Sleep(3000);
                    DelayWrite("Slade jumps over the counter.......'SAY HELLO TO MY LITTLE FRIEND' ");
                    Thread.Sleep(3000);
                    DelayWrite("You pull your Sword! You Lunge at the cops!!");
                    Thread.Sleep(3000);
                    DelayWrite("The cops fire!!!");
                    Thread.Sleep(3000);
                    DelayWrite("Your DEAD!!!");
                    Environment.Exit(1);
                }
                else if (response == "no" || response == "maybe")
                {
                    Thread.Sleep(3000);
                    DelayWrite("Slade jumps over the counter'SAY HELLO TO MY LITTLE FRIEND!!'");
                    Thread.Sleep(3000);
                    DelayWrite("The cops kill Slade!");
                    Thread.Sleep(3000);
                    DelayWrite("You drop to the floor!");
                    Thread.Sleep(3000);
                    DelayWrite(" The cops fire! They miss...");
                    Thread.Sleep(3000);
                    DelayWrite("Your UNDER ARREST!!");
                    Environment.Exit(1);
                }
            }
        }
        public void Boss(string Name)
        {
            Thread.Sleep(3000);
            DelayWrite($"Smart choice.... {Name}!");
            Thread.Sleep(2000);
            DelayWrite("Here take this gun.");
            Thread.Sleep(3000);
            DelayWrite("Will you take the Gun?");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                Thread.Sleep(3000);
                DelayWrite($"Alright {Name}! Lets Role!");
                Thread.Sleep(3000);
                DelayWrite($"Alright {Name} at 12:00am, I'm gonna cut the power on 3, when we get in to the bank, you go to the vault and get the cash ");
                Thread.Sleep(3000);
                DelayWrite("Ready...... 3...2...1!!");
                Thread.Sleep(3000);
                DelayWrite("You rush to the Vault, get the cash, you and Boss run out the front door; Turn right down the alley");
                Thread.Sleep(3000);
                DelayWrite("BAMMM!!!");
                Thread.Sleep(3000);
                DelayWrite("Something knocks Boss out cold he's on the ground!!!");
                Thread.Sleep(3000);
                DelayWrite("You hear a voice from the dark say");
                Thread.Sleep(3000);
                DelayWrite($"You think I don't know who you are {Name}!!");
                Thread.Sleep(3000);
                DelayWrite("Do you reach for your Gun?");
                string response1 = Console.ReadLine().ToLower();
                if (response1 == "yes")
                {
                    Thread.Sleep(3000);
                    DelayWrite("A shadowy figure jumps from the darkness grabs you and slams your face into the pavement! Knocking the gun out of your hand");
                    Thread.Sleep(4000);
                    DelayWrite("Its BATMAN!!!");
                    Thread.Sleep(3000);
                    DelayWrite("You have them fooled..... but i know its you......");
                    Thread.Sleep(5000);
                    DelayWrite("JOKER!!!");
                    Thread.Sleep(4000);
                    DelayWrite("HA HA HA HA HA HA HA");
                    Environment.Exit(1);
                }
                else if (response == "no" || response == "maybe")
                {
                    Thread.Sleep(3000);
                    DelayWrite("A shadowy figure jumps from the darkness grabs you and slams your face into the pavement!!!");
                    Thread.Sleep(4000);
                    DelayWrite("Its BATMAN!!!");
                    Thread.Sleep(5000);
                    DelayWrite("HA HA HA HA HA..... What took you so long!!!!!");
                    Thread.Sleep(5000);
                    DelayWrite("I knew it was you ....... JOKER!!!!!!!");
                    Thread.Sleep(3000);
                    DelayWrite("HA HA HA HA HA HA HA!!!!!");
                    Environment.Exit(1);
                }
            }
        }
        public void Butch(string Name)
        {
            Thread.Sleep(2000);
            DelayWrite($"What the heck are you lookin at. All you need to know {Name}, is nothing comes between me and money");
            Thread.Sleep(3000);
            DelayWrite("Here take this gun.");
            Thread.Sleep(3000);
            DelayWrite("Will you take the Gun?");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                Thread.Sleep(2000);
                DelayWrite($"Alright {Name}! Lets Role!");
                Thread.Sleep(2000);
                DelayWrite($"Alright {Name} on 3 we bust through the front door I will go to the vault.... You will watch the hostages!");
                Thread.Sleep(3000);
                DelayWrite("Ready...... 3...2...1!!");
                Thread.Sleep(2000);
                DelayWrite("Nobody MOVE!!!!!..... Butch goes to the vault gets the money...");
                Thread.Sleep(2000);
                DelayWrite("Suddenly the cops Burst through the front door.....!!!");
                Thread.Sleep(2000);
                DelayWrite("Butch turns and looks at you....");
                Thread.Sleep(2000);
                DelayWrite($"BYE {Name} HA HA!!!!");
                Thread.Sleep(2000);
                DelayWrite("Butch runs out the back door with all the MONEY!!!");
                Thread.Sleep(3000);
                DelayWrite("The place is full of cops! Guns are pointed at you! The cops yell at you!");
                Thread.Sleep(4000);
                DelayWrite("GET DOWN ON THE GROUND!!!");
                Thread.Sleep(3000);
                DelayWrite("Do you point the gun at the COPS???!!");
                string response1 = Console.ReadLine().ToLower();
                if (response1 == "yes")
                {
                    Thread.Sleep(3000);
                    DelayWrite(" 'SAY HELLO TO MY LITTLE FRIEND' ");
                    Thread.Sleep(3000);
                    DelayWrite("You pull your GUN! And fire at the cops!!");
                    Thread.Sleep(1000);
                    DelayWrite("The cops fire!!!");
                    Thread.Sleep(4000);
                    DelayWrite("Your DEAD!!!");
                    Environment.Exit(1);
                }
                else if (response == "no" || response == "maybe")
                {
                    Thread.Sleep(3000);
                    DelayWrite("You drop to the floor!");
                    Thread.Sleep(3000);
                    DelayWrite(" The cops fire! They miss...");
                    Thread.Sleep(3000);
                    DelayWrite("Your UNDER ARREST!!");
                    Environment.Exit(1);
                }
            }
        }
        public void MothersMilk(string Name)
        {
            Thread.Sleep(3000);
            DelayWrite($"First we get the money {Name} then we get the honey's!!!!");
            Thread.Sleep(2000);
            DelayWrite("Here take this gun.");
            Thread.Sleep(3000);
            DelayWrite("Will you take the Gun?");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                Thread.Sleep(3000);
                DelayWrite($"Alright {Name}! Lets Role!");
                Thread.Sleep(3000);
                DelayWrite($"Alright {Name} at 12:00am, I'm gonna cut the power on 3, when we get in to the bank, you go to the vault and get the cash ");
                Thread.Sleep(3000);
                DelayWrite("Ready...... 3...2...1!!");
                Thread.Sleep(3000);
                DelayWrite("You rush to the Vault, get the cash, you and Boss run out the front door; Turn right down the alley");
                Thread.Sleep(3000);
                DelayWrite("BAMMM!!!");
                Thread.Sleep(3000);
                DelayWrite("Something knocks Boss out cold he's on the ground!!!");
                Thread.Sleep(3000);
                DelayWrite("You hear a voice from the dark say");
                Thread.Sleep(3000);
                DelayWrite($"You think I don't know who you are {Name}!!");
                Thread.Sleep(3000);
                DelayWrite("Do you reach for your Gun?");
                string response1 = Console.ReadLine().ToLower();
                if (response1 == "yes")
                {
                    Thread.Sleep(3000);
                    DelayWrite("A shadowy figure jumps from the darkness grabs you and slams your face into the pavement! Knocking the gun out of your hand");
                    Thread.Sleep(4000);
                    DelayWrite("Its BATMAN!!!");
                    Thread.Sleep(3000);
                    DelayWrite("You have them fooled..... but i know its you......");
                    Thread.Sleep(5000);
                    DelayWrite("JOKER!!!");
                    Thread.Sleep(4000);
                    DelayWrite("HA HA HA HA HA HA HA");
                    Environment.Exit(1);
                }
                else if (response == "no" || response == "maybe")
                {
                    Thread.Sleep(3000);
                    DelayWrite("A shadowy figure jumps from the darkness grabs you and slams your face into the pavement!!!");
                    Thread.Sleep(4000);
                    DelayWrite("Its BATMAN!!!");
                    Thread.Sleep(5000);
                    DelayWrite("HA HA HA HA HA.........What took you so long!!!!!");
                    Thread.Sleep(5000);
                    DelayWrite("I knew it was you..............JOKER!!!!!!!");
                    Thread.Sleep(3000);
                    DelayWrite("HA HA HA HA HA HA HA!!!!!");
                    Environment.Exit(1);
                }
            }
        }
    }
}
