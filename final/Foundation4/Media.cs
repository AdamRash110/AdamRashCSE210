using System;

namespace Library
{
    public interface ICheckoutable
    {
        void Checkout();
        void Return();
    }

    public abstract class Media : ICheckoutable
    {
        private string title;
        private string author;
        private int year;

        public Media(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public abstract void Checkout();

        public abstract void Return();
    }
}