class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        
        library.AddBook(new Book { Title = "Book1", Author = "Author1", Year = 2022 });
        library.AddBook(new Book { Title = "Book2", Author = "Author2", Year = 2019 });
        library.AddBook(new Book { Title = "Book1", Author = "Author3", Year = 2017 });

        library.PrintBooksByAuthor("Author1");

       
        library.RemoveBook(new Book { Title = "Book2", Author = "Author2", Year = 2019 });

        
        List<Book> foundBooks = library.FindBook("Book1");
        Console.WriteLine($"Found {foundBooks.Count} books with the title 'Book1' in the library.");
    }
}

