using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, "978-3-16-148410-0");
            DVD dvd1 = new DVD("The Shawshank Redemption", "Frank Darabont", 1994, 142);

            library.AddItem(book1);
            library.AddItem(dvd1);

            library.CheckoutItem(book1);
            library.CheckoutItem(dvd1);

            library.ReturnItem(book1);
            library.ReturnItem(dvd1);
        }
    }
}