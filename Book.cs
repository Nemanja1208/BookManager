using System;
using System.Collections.Generic;
using System.Text;

namespace Nemo
{
    public class Book
    {

        public string Title { get; set; }

        public string Author { get; set; }

        public int YearPublished { get; set; }

        //// Constructor
        //public Book(string title, string description)
        //{
        //    Title = title;
        //    Description = description;
        //}

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Titel: {Title}, Författare: {Author}, Årtal: {YearPublished}");
        }


    }
}
