/*
 * Don Quixote's Horse: The Game
 * by Tucker Ward, 020321
 *  
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */
using System;

namespace TextAdventureGame
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Don Quixote's Horse: The Game";

            //game starts

            Game.StartGame();

            //holds on title screen

            Console.Read();

            //stores character name

            Game.NameCharacter();
            
            Console.Read();

            Game.MidGame();

            Game.EndGame();
            
        }
    }
    public static class Game
    {
        //character name
        public static string characterName = "Ty Garvey";
        //print out game title and overview
        public static void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("" +
                "              ___  ____                       \n" +
                "             /   \\/___ \\/\\  /\\  _             \n" +
                "            / /\\ //  / / /_/ / (_)            \n" +
                "           / /_// \\_/ / __  /   _             \n" +
                "          /___,'\\___,_\\/ /_/   (_)            \n" +
                "                                              \n" +
                " _____ _              ___                     \n" +
                "/__   \\ |__   ___    / _ \\__ _ _ __ ___   ___ \n" +
                "  / /\\/ '_ \\ / _ \\  / /_\\/ _` | '_ ` _ \\ / _ \\ \n" +
                " / /  | | | |  __/ / /_\\\\ (_| | | | | | |  __/\n" +
                " \\/   |_| |_|\\___| \\____/\\__,_|_| |_| |_|\\___|\n" +
                "                                              \n");
            Console.ResetColor();
            Console.WriteLine("It's like the band but instead of music it's text.");
            Console.Write("Hit enter to continue");
            
        }
        //"Make a choice" method
        public static string Choice(string opt1, string opt2)
        {
            string input = "";
            Console.WriteLine(characterName + ", which will you choose: A or B?");
            input = Console.ReadLine();
            input = input.ToLower();
            if (input == "a")
            {
                Console.WriteLine($"You have chosen path A. {opt1}.\n");
            }
            else if (input == "b")
            {
                Console.WriteLine($"You have chosen path B. {opt2}.\n");
            }
            else
            {
                Console.WriteLine("Wrong input, try again.\n");
                Choice(opt1, opt2);
            }
            return input;
        }
        //ask player for a name, and save it
        public static void NameCharacter()
        {
            Console.WriteLine("What is your name?");
            Console.Title = "Name Selection";
            characterName = Console.ReadLine();
            string trimName = characterName.ToLower().Trim().Replace(" ","");
            if (trimName == "jasonbaker" || trimName == "tygarvey" || trimName == "robertchisolm" || trimName == "drewmelon" )
            {
                Console.WriteLine($"oh my gawd it's {characterName}.");
            }
            else if (trimName == "tuckerward")
            {
                Console.WriteLine($"original members only");
            }
            else if (trimName == "")
            {
                Console.WriteLine($"You have to have a name.");
                NameCharacter();
            }
            else
            {
                //Trying to get a loading title:
                //ConsoleAttributes.ConsoleLoading();
                Console.WriteLine($"Nice to meet you {characterName}.");
            }  
        }
        
        public static void MidGame()
        {
            //first branch split

            string question1A = "Buying a Boat";
            string question1B = "Buying two Jet Skis";

            Console.WriteLine($"Okay, {Game.characterName} you find yourself driving down the road.\n" +
                $"You are thinking to yourself of all the things that you would like to do.\n" +
                $"One thing in particualar comes to mind... what is it?\n" +
                $"\n" +
                $"A. {question1A}, or B. {question1B}"); ;

            string branch1 = Game.Choice(question1A, question1B);

            //second branch split

            string question2A = "A Payday Loan";
            string question2B = "Saving up";

            string question2C = "Love";
            string question2D = "Prestige";

            string branch2 = "";

            if (branch1 == "a")
            {
                Console.WriteLine($"Ah, so you are thinking of buying a boat.\n" +
                $"Boats can be very expensive, how do you plan to finance this boat?\n" +
                $"\n" +
                $"A. {question2A}, or B. {question2B}");
                branch2 = Game.Choice(question2A, question2B);
            }
            else
            {
                Console.WriteLine($"You're thinking of buying TWO jet skis?!\n" +
                $"Those can be very expensive, why do you think you need two jet skis?\n" +
                $"\n" +
                $"A. {question2C}, or B. {question2D}");
                branch2 = Game.Choice(question2C, question2D);
            }
            //third branch

            if (branch1 == "a" && branch2 == "a")
            {
                Console.WriteLine($"You must be prone to make poor decisions.\n");
            }
            else if (branch1 == "a" && branch2 == "b")
            {
                Console.WriteLine($"You seem really boring, you should go by that boat immediately.\n");
            }
            else if (branch1 == "b" && branch2 == "a")
            {
                Console.WriteLine($"You seem to be prone to make poor decisions, you may be more interested in boats.\n");
            }
            else if (branch1 == "b" && branch2 == "b")
            {
                Console.WriteLine($"You should reconsider buying the jet skis... you don't deserve them.\n");
            }
            
        }

        public static void EndGame()
        {
            Console.WriteLine($"Thank you for playing {characterName}, have a nice day.\n");
        }

    }
    class Item { }
}
