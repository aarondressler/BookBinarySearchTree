using System.Collections;

namespace BookBST
{
    public class Book
    {
        public int Isbn { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public int Year { get; set; }

        public Book(int isbn, string author, string title, int rating, int year)
        {
            Isbn = isbn;
            Author = author;
            Title = title;
            Rating = rating;
            Year = year;
        }
    }
}