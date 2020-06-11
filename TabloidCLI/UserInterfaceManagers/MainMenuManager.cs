using System;

namespace TabloidCLI.UserInterfaceManagers
{
    public class MainMenuManager : IUserInterfaceManager
    {
        private const string CONNECTION_STRING = 
            @"Data Source=localhost\SQLEXPRESS;Database=TabloidCLI;Integrated Security=True";

        public IUserInterfaceManager Execute()
        {
            Console.WriteLine("");

            Console.WriteLine("This is a pleasent greeting that Andy would enjoy and is shown because you started the application!");

            Console.WriteLine("");

            Console.WriteLine("Main Menu");

            Console.WriteLine(" 1) Journal Management");
            Console.WriteLine(" 2) Blog Management");
            Console.WriteLine(" 3) Author Management");
            Console.WriteLine(" 4) Post Management");
            Console.WriteLine(" 5) Tag Management");
            Console.WriteLine(" 6) Search by Tag");
            Console.WriteLine(" 7) Change Background Color");
            Console.WriteLine(" 0) Exit");

            Console.Write("> ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                //case "1": return new JournalManager(this, CONNECTION_STRING);
                //case "2": return new BlogManager(this, CONNECTION_STRING);
                case "3": return new AuthorManager(this, CONNECTION_STRING);
                //case "4": return new PostManager(this, CONNECTION_STRING);
                case "5": return new TagManager(this, CONNECTION_STRING);
                case "6": return new SearchManager(this, CONNECTION_STRING);
                case "7":
                    Console.WriteLine("List of available colors:");
                    return DisplayColors();
                case "0":
                    Console.WriteLine("Good bye");
                    return null;
                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }
        }
    }
}
