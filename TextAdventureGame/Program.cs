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

            Game.StartGame();

            Console.Read();

            Game.NameCharacter();
            
            Console.Read();

        }
    }
    public static class Game
    {
        //character name
        static string characterName = "Ty Garvey";
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
            else
            {
                //Trying to get a loading title:
                //ConsoleAttributes.ConsoleLoading();
                Console.WriteLine($"Nice to meet you {characterName}.");
            }

            
            
        }

    }
    class Item { }
}
