using TabloidCLI.UserInterfaceManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace TabloidCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            // MainMenuManager implements the IUserInterfaceManager interface
            IUserInterfaceManager ui = new MainMenuManager();
            while (ui != null)
            {
                // Each call to Execute will return the next IUserInterfaceManager we should execute
                // When it returns null, we should exit the program;
                ui = ui.Execute();
            }

            // Display current Background color 
            // Console.WriteLine("Default Background Color: {0}", Console.BackgroundColor);

            // Set the Background color to blue 
            // Console.BackgroundColor = ConsoleColor.Blue;

            // Display current Background color 
            // Console.WriteLine("Changed Background Color: {0}", Console.BackgroundColor);

            

            

            
            string colorChosen = Console.ReadLine();


        }
        public static void DisplayColors()
        {          
            // Get the list of available colors 
            ConsoleColor[] consoleColors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

            // Display the list of available console colors 
            Console.WriteLine("Enter your new background color!");
            foreach (var color in consoleColors)
                Console.WriteLine(color);
        }
    }
}
