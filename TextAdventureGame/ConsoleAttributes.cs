using System;
using System.Threading;
namespace TextAdventureGame
{
    public class ConsoleAttributes
    {
        //Text art: http://patorjk.com/software/taag/#p=display&f=Ogre&t=%20%20%20%20%20%20%20%20%20%20DQH%20%3A%0AThe%20Game

        public ConsoleAttributes()
        {
            
            
        }
        public static void ConsoleLoading()
        {
            string LoadingText = "...";
            string TitleBarText = "Loading";
            bool Loading = true;

            Console.Title = TitleBarText;

            while (Loading)
            {
                for (int i = 0; i < LoadingText.Length; i++)
                {
                    TitleBarText = TitleBarText + LoadingText[i];
                    Console.Title = TitleBarText;
                    Thread.Sleep(240);
                }
                TitleBarText = "";
            }
        }
        static void Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        //method for coloring dialogue
        static void Dialog(string message, string color)
        {
            if (color == "red")
            { Console.ForegroundColor = ConsoleColor.Red; }
            else if (color == "green")
            { Console.ForegroundColor = ConsoleColor.Green; }
            else if (color == "yellow")
            { Console.ForegroundColor = ConsoleColor.Yellow; }
            else
            { Console.ForegroundColor = ConsoleColor.White; }

            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
