using System;

namespace Library
{
    public class Book : Media
    {
        private string isbn;

        public Book(string title, string author, int year, string isbn) : base(title, author, year)
        {
            this.isbn = isbn;
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public override void Checkout()
        {
            Console.WriteLine($"Book '{Title}' by {Author} checked out.");
        }

        public override void Return()
        {
            Console.WriteLine($"Book '{Title}' by {Author} returned.");
        }
    }
}