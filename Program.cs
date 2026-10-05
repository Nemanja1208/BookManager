namespace Nemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager();
            bool keepRunning = true;

            while (keepRunning)
            {
                // Jag skapar en meny
                Console.Clear();
                Helper.DisplayMeny();

                // Läs användarens val
                string usersChoice = Console.ReadLine()!;

                // Använd switch för att hantera användarens val
                switch (usersChoice)
                {
                    // LÄGGA TILL EN BOK
                    case "1":
                        // FRÅGA ANVÄNDAREN OM TITEL, FÖRFATTARE OCH ÅRTAL
                        bookManager.AddBookMetod();
                        break;

                    case "2":
                        Console.WriteLine("Här är alla våra böcker : ");
                        bookManager.ShowAllBooks();
                        break;

                    case "3":
                        bookManager.SearchBookByTitle();
                        break;

                    case "4":
                        Console.WriteLine("Avslutar programmet...");
                        keepRunning = false;
                        break;
                }
            }
        }
    }
}
