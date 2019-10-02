//https://www.youtube.com/watch?v=3foH7ZfC-Hk

using System;
using System.Net.WebSockets;

namespace Text_Adventure_Game_Turtorial
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
            firstChoice();
        }

        public static void gameTitle()
        {
            Console.WriteLine("Welcome to The Yellow Brick Road! \nThe greatest adventure game of all time.\n\n");
            Console.WriteLine("Press Enter to Begin");
            Console.ReadLine();
            Console.Clear(); //clears the screen
            firstChoice();
        }

        public static void firstChoice()
        {
            string choice;

            Console.WriteLine("You find yourself in Dorothy's silver sparkling shoes. You've landed in Oz and the house has killed the Wicked Witch of the East, her legs popping out from under the porch steps.");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Cry");
            Console.WriteLine("2. High five the munchkin next to you");
            Console.WriteLine("3. Speak with the locals");
            Console.Write("Choice: "); //.Write allows their input to appear next to
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            //handle what the user enters
            switch (choice)
            {
                case "1":
                case "cry":
                    {
                        Console.WriteLine("Your tears well up, dropping down to the ground in impossibly large drops. \n Puddles begin to form.");
                        Console.WriteLine("The puddles become so deep they drown a Munchkin family.");
                        Console.WriteLine("You've now established yourself as a serial killer in this new land.");
                        Console.WriteLine("The mayor of Munchkin Country is now approaching.");
                        Console.WriteLine("You begin to notice truncheons and torches as a large group of small, but angry creatures in military uniforms march your way.");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "2":
                case "high five":
                case "high five the munchkin next to you":
                    {
                        Console.WriteLine("You overestimate your strength and the Munchkin topples backward.");
                        Console.WriteLine("It is only then you realize you have just toppled an elderly Munchkin, now sprawled across the dirt in front of you.");
                        Console.WriteLine("Just as all the Munchkins of Munchkin Country are reappearing from hiding,");
                        Console.WriteLine("they see your hand in the air and their most-senior Munchkin, Unc Nunkie, on the ground beside you.");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "3":
                case "speak":
                case "speak with the locals":
                    {
                        Console.WriteLine("The residents of Munchkin Country slowly appear from hiding.");
                        Console.WriteLine("Still shaking, they see the Wicked Witch of the East is dead.");
                        Console.WriteLine("Suddenly, a great ruckus erupts as they cheer, jump for joy, and cry tears of relief.");
                        Console.WriteLine("The mayor of Munchkin Country approaches, a smile on her face.");
                        Console.WriteLine("Then, out of thin air, the Good Witch of the North appears in the center of town.");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        secondChoice();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command...'");
                        Console.WriteLine("Pres 'Enter' to try again.");
                        firstChoice();
                        break;
                    }
            }
        }

        public static void secondChoice()
        {
            Random rnd = new Random();
            string[] secondOptions = { "On the Yellow Brick Road, you see a meadow of poppies.", "On the Yellow Brick Road, you see an emerald city sparkling in the distance.", "On the Yellow Brick Road, you notice a shack with a straw roof.", "On The Yellow Brick Road, Toto takes off running after a small field mouse wearing a crown." };
            int randomNumber = rnd.Next(0, 3);
            string secondText = secondOptions[randomNumber];

            string userChoice;

            //now we need to output the secondText
            Console.WriteLine(secondText);
            Console.WriteLine("Do you want to continue? Yes or No?");
            Console.Write("Choice: ");
            userChoice = Console.ReadLine().ToLower();

            if (userChoice == "yes" || userChoice == "y")
            {
                if (secondText == secondOptions[0])
                {
                    Console.WriteLine("You run through the field of poppies. The poppies are lush and soft against your skin. \nBefore you know it, you're laying in their fragrant scent and fall asleep.\n");
                    Console.WriteLine("Press 'Enter'");
                    Console.ReadLine();
                    gameOver();
                }
                else if (secondText == secondOptions[1])
                {
                    Console.WriteLine("Your destination is in sight! But the road is still long. \nPerhaps it's time to gather some companions!\n");
                    Console.WriteLine("Press 'Enter'");
                    Console.ReadLine();
                    thirdChoice();
                }
                else if (secondText == secondOptions[2])
                {
                    Console.WriteLine("You cautiously approach the shack. You hear a moan, like an injured kitten may be inside. \nImmediately upon stepping through the darkened door,\na bag is thrown over your head and a tall man throws you over his shoulder, potatoe-sack style.\n");
                    Console.WriteLine("Press 'Enter'");
                    Console.ReadLine();
                    gameOver();
                }
                else if (secondText == secondOptions[3])
                {
                    string userFollowChoice;

                    Console.WriteLine("You yell after Toto, hoping you can catch HIM before HE catches the regal looking mouse.");
                    Console.WriteLine("You finally grab Toto before he can grab the mouse. Out of breath, she thanks you for saving her and introduces herself as The Queen of the Field Mice and invites you to meet her Rodent Kingdom.\n");
                    Console.WriteLine("You know you should be on your way, but find yourself curious.");
                    Console.WriteLine("Do you follow her? Yes or No");
                    userFollowChoice = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("I don't understand that command...'");
                    Console.WriteLine("Press 'Enter' to try again.");
                    secondChoice();
                }
                
            }
            else if (userChoice == "no" || userChoice == "n")
            {
                Console.WriteLine("A meteor slams into Oz at that exact moment, killing you and everyone who lives there.");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
                gameOver();
            }
            else
            {
                Console.WriteLine("I don't understand that command...'");
                Console.WriteLine("Press 'Enter' to try again.");
                secondChoice();
            }
        }

        public static void thirdChoice()
        {
            int wizardAge;

            Console.WriteLine("The Wizard agrees to see you after what seems like ages.");
            Console.WriteLine("The Wizard agreed to make you an honorary Emerald City citizen.");
            Console.WriteLine("But first, you must guess his age.");
            Console.Write("Your guess: ");
            int.TryParse(Console.ReadLine(), out wizardAge);


            while (wizardAge <= 70 && wizardAge >=100)
            {
                Console.WriteLine("Seriously? You can do better than that!");
                Console.WriteLine("\"Try again, Dorothy,\" says The Wizard");
                Console.Write("Your guess: ");
                int.TryParse(Console.ReadLine(), out wizardAge);
            }

            Console.WriteLine("You've guessed wisely, Dorothy. Welcome to The Emerald City");
            Console.WriteLine("Press 'Enter' to try again");
            Console.ReadLine();
            youWin();
        }

        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("At your funeral, they sing songs of your bravery. The Munchkins of Munchkin Country rename their townhall in your honor.");
            Console.WriteLine("Better luck next time.");
            Console.WriteLine("Press 'Enter' to try again");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void youWin()
        {
            Console.Clear();
            Console.WriteLine("Dorothy successfully makes it to The Emerald City and meets with The Wizard of Oz.");
            Console.WriteLine("All her dreams came true.");
            Console.WriteLine("And little Toto came too.");
            Console.WriteLine("Press 'Enter' to try again");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
    }
}
