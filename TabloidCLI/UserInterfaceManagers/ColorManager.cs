using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using System.Threading.Tasks;

namespace TabloidCLI.UserInterfaceManagers
{
    public class ColorManager : IUserInterfaceManager
    {
        private readonly IUserInterfaceManager _parentUI;
        public ColorManager(IUserInterfaceManager parentUI)
        {
            _parentUI = parentUI;
        }

        public IUserInterfaceManager Execute()
        {
            Console.WriteLine("Color Menu");
            Console.WriteLine(" 1) Choose background color");
            Console.WriteLine(" 2) Choose font color");
            Console.WriteLine(" 3) Choose theme");
            Console.WriteLine(" 0) Go Back");

            Console.Write("> ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ChooseBackground();
                    return this;
                case "2":
                    ChooseFont();
                    return this;
                case "3":
                    ChooseTheme();
                    return this;
                case "0":
                    return _parentUI;
                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }
        }

        private void ChooseBackground()
        {
            ConsoleColor[] consoleColors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

            for (int i = 0; i < consoleColors.Length; i++)
            {
                ConsoleColor color = consoleColors[i];
                Console.WriteLine($" {color}");
            }
            Console.Write("> ");

            string input = Console.ReadLine();
            try
            {
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), input, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Selection");
            }
        }

        private void ChooseFont()
        {
            ConsoleColor[] consoleColors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

            for (int i = 0; i < consoleColors.Length; i++)
            {
                ConsoleColor color = consoleColors[i];
                Console.WriteLine($" {color}");
            }
            Console.Write("> ");

            string input = Console.ReadLine();
            try
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), input, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Selection");
            }
        }
        private void ChooseTheme()
        {
            string[] themes = new string[]
            {
                "Easter Egg", "Donkey Kong", "Ocean View", "Bumble Bee", "TheHamptons", "Branty"
            };
            foreach(string theme in themes)
            {
                Console.WriteLine($"{theme}");
            }
            Console.Write("> ");
            string input = Console.ReadLine();
            try
            {
                if (input == "Easter Egg")
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                else if (input == "Donkey Kong")
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else if (input == "Ocean View")
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (input == "Bumble Bee")
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (input == "The Hamptons")
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                else if (input == "Branty")
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Green;
                }                        
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Selection");
            }

        }
    }
}
