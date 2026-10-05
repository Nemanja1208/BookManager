using System;
using System.Collections.Generic;
using System.Text;

namespace Nemo
{
    public class Helper
    {
        public static void DisplayMeny()
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
