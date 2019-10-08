//https://www.youtube.com/watch?v=3foH7ZfC-Hk

using System;
using System.Net.WebSockets;

namespace Text_Adventure_Game_Turtorial
{
    class Program
    {
        public static CharacterDetails State;
        static void Main(string[] args)
        {
            State = new CharacterDetails();
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
                        Console.WriteLine("Your tears well up, dropping down to the ground in impossible Alice In Wonderland proportions. \nPuddles begin to form.");
                        Console.WriteLine("The puddles become so deep they drown a Munchkin family.");
                        Console.WriteLine("You've now established yourself as a serial killer in this new land.");
                        Console.WriteLine("The mayor of Munchkin Country is fast approaching.");
                        Console.WriteLine("Over the horizon you see truncheons and torches appear out of the dusk, small but angry creatures in \nmilitary uniforms are marching your way.");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        youLose();
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
            string heelClickChoice;
            Console.WriteLine("This beautiful sparkling witch introduces herself as Glinda from the North. \nYou find yourself marveling at her glowing skin and satin hair.");
            Console.WriteLine("She tells you that she can grant you one wish.");
            Console.WriteLine("What wish would you like granted?");
            Console.WriteLine("[1] To go back home to Kansas");
            Console.WriteLine("[2] That ToTo live forever");
            Console.WriteLine("[3] That Aunt Em bites the dust");
            Console.Write("Choice: ");
            heelClickChoice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (heelClickChoice)
            {
                case "1":
                case "home":
                case "to go back home":
                case "to go back home to kansas":
                    {
                        Console.WriteLine("Glinda waves her wand over your sparkling shoes. They seem to shine brighter");
                        Console.WriteLine("She tells you to click your heels three times while repeating 'There's no place like home.'");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        thirdChoice();
                        break;
                    }
                case "2":
                case "that toto live forever":
                case "toto live forever":
                {
                    Console.WriteLine("Glinda frowns at you and looks you square in the eye");
                    Console.WriteLine("It's not fair to force a living creature to live forever. \nTheir souls are built to stay only as long as they are meant to.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    gameOver();
                    break;
                }
                case "3":
                case "that aunt em bites the dust":
                case "aunt em bites the dust":
                {
                    Console.WriteLine("Glinda got distracted by a cell phone ping and only heard 'bites the dust'.");
                    Console.WriteLine("Not wanting to look unprofessional, she immediately turns you into Freddie Mercury.");
                    Console.WriteLine("You now have an uncontrollable cocaine addiction and ToTo gets hooked on meth.");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    gameOver();
                    break;
                }
                default:
                {
                    Console.WriteLine("I don't understand that command...'");
                    Console.WriteLine("Pres 'Enter' to try again.");
                    thirdChoice();
                    break;
                }
            }

        }

        public static void thirdChoice()
        {
            Random rnd = new Random();
            string[] secondOptions = { "On the Yellow Brick Road, you see a meadow of poppies.", "On the Yellow Brick Road, you see an emerald city sparkling in the distance.", "On the Yellow Brick Road, you notice a shack with a straw roof.", "On The Yellow Brick Road, Toto takes off running after a small field mouse wearing a crown." };
            int randomNumber = rnd.Next(0, 3);
            string secondText = secondOptions[randomNumber];

            string userChoice;

            //now we need to output the secondText
            Console.WriteLine("You find yourself transported to a long winding road of yellow bricks. The sky seems to expand\nforever in all directions, blue as the ocean.");
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
                    companionChoice();
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
                    thirdChoice();
                }

            }
            else if (userChoice == "no" || userChoice == "n")
            {
                Console.WriteLine("A meteor slams into Oz at that exact moment, killing you and everyone who lives there.");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
                youLose();
            }
            else
            {
                Console.WriteLine("I don't understand that command...'");
                Console.WriteLine("Press 'Enter' to try again.");
                thirdChoice();
            }
        }

        public static void companionChoice()
        {
            string characterChoice;

            Console.WriteLine("Now that you've found yourself on a journey in a foreign land. It is time to find some local companions");
            Console.WriteLine("Glinda hands you three resumes, complete with pictures.");
            Console.WriteLine("Your first option is a ScareCrow come to life. He's zesty and lean, but lacks brains.");
            Console.WriteLine("Your second option is a Lion. He's big and scary-looking... but he's cowardly and afraid of ToTo.");
            Console.WriteLine("Your third option is a Tin Man. You find him oddly handsome, but discover he lacks a heart.");
            Console.WriteLine("Which character would you like to accompany you?\n[1]\n[2]\n[3]");
            Console.Write("Character choice: ");
            characterChoice= Console.ReadLine().ToLower();

            if (characterChoice == "1" || characterChoice == "scarecrow")
            {
                State.Companion = "Scarecrow";
                Console.WriteLine("You've chosen ScareCrow as your companion.");
                Console.WriteLine("Press 'Enter' to continue");
                yellowBrickRoadAdventure();

            }
            else if (characterChoice == "2" || characterChoice == "lion")
            {
                State.Companion = "Lion";
                Console.WriteLine("You've chosen the Lion as your companion.");
                Console.WriteLine("Press 'Enter' to continue");
                yellowBrickRoadAdventure();
            }
            else if (characterChoice == "3" || characterChoice == "tin man")
            {
                State.Companion = "Tin Man";
                Console.WriteLine("You've chosen the Tin Man as your companion.");
                Console.WriteLine("Press 'Enter' to continue");
                yellowBrickRoadAdventure();
            }
            else
            {
                Console.WriteLine("I don't understand that command...");
                Console.WriteLine("Press 'Enter' to try again.");
                companionChoice();
            }
        }

        public static void yellowBrickRoadAdventure()
        {
            Console.Clear();
            Console.WriteLine($"Well, the road is long but at least you have {State.Companion} to keep you company.");
            Console.WriteLine("And little ToTo too, of course.");
            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"{State.Companion} skips and prances down the brick road. He runs circles around you and tells you to hurry up.");
            Console.WriteLine("You break into a run. Toto by your heels.");
            Console.WriteLine("In the distance. A gleaming Emerald city peaks above the purple sky.");
            wizardOfOzChoice();
        }

        public static void wizardOfOzChoice()
        {
            int wizardAge;
            Console.Clear();
            Console.WriteLine("The Wizard agrees to see you after what seems like ages.");
            Console.WriteLine("The Wizard agreed to make you an honorary Emerald City citizen.");
            Console.WriteLine("But first, you must guess his age.");
            Console.Write("Your guess: ");
            int.TryParse(Console.ReadLine(), out wizardAge);


            while (wizardAge <= 70 && wizardAge >= 100)
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

        public static void youLose()
        {
            Console.Clear();
            Console.WriteLine("At your funeral they spit on your grave and use dark magic to keep you dead. You murdering fiend...");
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
