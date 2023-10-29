using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Library
{
    private List<Book> books = new List<Book>();

    public void PrintBooksByAuthor(string author)
    {
        var booksByAuthor = books.Where(b => b.Author == author).ToList();

        if (booksByAuthor.Count == 0)
        {
            Console.WriteLine("No books by this author found in the library.");
        }
        else
        {
            Console.WriteLine($"Books by {author}:");
            foreach (var book in booksByAuthor)
            {
                Console.WriteLine($"{book.Title} ({book.Year})");
            }
        }
    }

    public int Count => books.Count;

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"{book.Title} added to the library.");
    }

    public void RemoveBook(Book book)
    {
        bool removed = books.Remove(book);
        if (removed)
        {
            Console.WriteLine($"{book.Title} removed from the library.");
        }
        else
        {
            Console.WriteLine($"{book.Title} not found in the library.");
        }
    }

    public List<Book> FindBook(string title)
    {
        return books.Where(b => b.Title == title).ToList();
    }
}
