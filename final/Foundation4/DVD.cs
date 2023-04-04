using System;

namespace Library
{
    public class DVD : Media
    {
        private int length;

        public DVD(string title, string author, int year, int length) : base(title, author, year)
        {
            this.length = length;
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public override void Checkout()
        {
            Console.WriteLine($"DVD '{Title}' by {Author} checked out.");
        }

        public override void Return()
        {
            Console.WriteLine($"DVD '{Title}' by {Author} returned.");
        }
    }
}