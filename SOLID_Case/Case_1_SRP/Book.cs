using System;

namespace SOLID.SOLID_Case_Answer.Case_Answer_1_SRP
{
    #region Bad Code
    //public class Book
    //{
    //    public string Title { get; set; }
    //    public string Author { get; set; }

    //    public void Print()
    //    {
    //        Console.WriteLine($"Title: {Title}, Author: {Author}");
    //    }

    //    public void Save()
    //    {
    //        // Code to save book to database
    //    }
    //}
    #endregion

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
    public class BookPrinter
    {
        public void Print(Book book)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
        }
    }
    public class SaveBook
    {
        public void Save(Book book)
        {

            Console.WriteLine("Book saved to database.");
        }
    }
}
