using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration
{
    class Book
    {
        public int Index { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        List<Book> AllBooks = new List<Book>();

        public void AddBook()
        {
            Console.WriteLine("Please insert details of the book");
            Console.WriteLine("Title: ");

            Book thisBook = new Book();
        }

        public void SearchBook()
        {
            Console.WriteLine("Give me the title please\n");
            var searchedtitle = Console.ReadLine().ToString();
            foreach (var book in AllBooks)
            {
                if (book.Title == searchedtitle)
                {
                    Console.WriteLine("yeap, found it!\n");
                    book.ShowBook();
                }
            }
        }

        private void ShowBook()
        {

        }
    }

}

