using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookLibraryModification
{
    class Book
    {
        public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            Isbn = isbn;
            Price = price;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            int booksCnt = int.Parse(Console.ReadLine());
            Library myLibrary = new Library()
            {
                Name = "Aprilov",
                Books = new List<Book>()
            };

            for (int i = 0; i < booksCnt; i++)
            {
                Book currentBook = ReadBook();
                myLibrary.Books.Add(currentBook);
            }

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            myLibrary.Books
                .Where(b => b.ReleaseDate > date)
                .OrderBy(b => b.ReleaseDate)
                .ThenBy(b => b.Title)
                .ToList()
                .ForEach(b => Console.WriteLine(b.Title + " -> " + String.Format("{0:dd.MM.yyyy}", b.ReleaseDate)));
        }

        static Book ReadBook()
        {
            string[] tokens = Console.ReadLine().Split(' ');
            string title = tokens[0];
            string author = tokens[1];
            string publisher = tokens[2];
            DateTime releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            string isbn = tokens[4];
            decimal price = decimal.Parse(tokens[5]);

            return new Book(title, author, publisher, releaseDate, isbn, price);
        }
    }
}
