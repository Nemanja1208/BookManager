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
                DisplayMeny();

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
            



            //Skapa en konsolapplikation som hanterar en samling böcker.
            //Skapa en klass Bok med egenskaper:
            //Titel(string)
            //Författare(string)
            //YearPublished(int)
            //Skapa en List < Bok > för att lagra böcker.
            //I menyn ska användaren kunna:
            //📗 Lägga till en bok(be om titel, författare och årtal).
            //📖 Visa alla böcker i samlingen.
            //🔍 Söka efter en bok genom titel och visa dess detaljer.

            //💡 Tips:
            //Använd foreach för att visa alla böcker.
            //Använd if och ToLower() för enkel sökning utan att vara känslig för stora / små bokstäver.
        }

        private static void DisplayMeny()
        {
            Console.WriteLine("Välkommen till bokhanteraren!");

            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1 : Lägga till en bok");
            Console.WriteLine("2 : Visa alla böcker");
            Console.WriteLine("3 : Söka efter en bok genom titel");
            Console.WriteLine("4 : Avsluta");
        }

    }
}
