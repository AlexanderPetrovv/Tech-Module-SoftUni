using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary2
{
    class Book
    {
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

    class BookLibrary
    {
        static void Main(string[] args)
        {
            int booksCnt = int.Parse(Console.ReadLine());
            Library myLibrary = new Library()
            {
                Name = "myBooks",
                Books = new List<Book>()
            };

            for (int i = 0; i < booksCnt; i++)
            {
                string bookInfo = Console.ReadLine();
                Book currentBook = ReadBook(bookInfo);
                myLibrary.Books.Add(currentBook);
            }

            var authorSales = myLibrary.Books
                .Select(b => b.Author)
                .Distinct()
                .Select(author => new
                {
                    Author = author,
                    Sales = myLibrary.Books.Where(book => book.Author == author).Sum(book => book.Price)
                })
                .OrderByDescending(a => a.Sales)
                .ThenBy(a => a.Author)
                .ToArray();

            foreach (var authorSale in authorSales)
            {
                Console.WriteLine($"{authorSale.Author} -> {authorSale.Sales:F2}");
            }
        }

        static Book ReadBook(string input)
        {
            string[] tokens = input.Split(' ');
            string title = tokens[0];
            string author = tokens[1];
            string publisher = tokens[2];
            DateTime releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            string isbn = tokens[4];
            decimal price = decimal.Parse(tokens[5]);

            Book currentBook = new Book()
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                ReleaseDate = releaseDate,
                Isbn = isbn,
                Price = price
            };

            return currentBook;
        }
    }
}
