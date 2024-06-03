namespace _04._06._2024_task;

internal class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("Programming");
        book1.Name = "Programming";
        book1.AuthorName = "John Doe";
        book1.PageCount = 500;
        Console.WriteLine($"Book1 Code: {book1.Code}");

        Book book2 = new Book("Data Structures");
        book2.Name = "Data Structures";
        book2.AuthorName = "Jim Brown";
        book2.PageCount = 400;

        Book book3 = new Book("olasiliksiz");
        book3.Name = "Olasiliksiz";
        book3.AuthorName = "Adam Fwer";
        book3.PageCount = 254;
        Console.WriteLine($"Book Code: {book3.Code}");

        Library library = new Library();
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        library.AddBook(new Book("Book 1"));
        library.AddBook(new Book("Book 2"));
        library.AddBook(new Book("Book 3"));

        Book[] booksByName = library.FindAllBooksByName("book");
        Console.WriteLine("Books found by name:");
        foreach (Book book in booksByName)
        {
            Console.WriteLine($"{book.Name} , Code: {book.Code}");
        }

        Book bookByCode = library.FindBookBYCode("PR1");
        if (bookByCode != null)
        {
            Console.WriteLine($"Book found by code: {bookByCode.Name} by {bookByCode.AuthorName}, Pages: {bookByCode.PageCount}");
        }
        else
        {
            Console.WriteLine("Book not found by code.");
        }

        Book[] booksByPageCountRange = library.FindAllBooksByPageCountRange(250, 400);
        Console.WriteLine("Books found by page count range:");
        foreach (Book book in booksByPageCountRange)
        {
            Console.WriteLine($"{book.Name} by {book.AuthorName}, Pages: {book.PageCount}, Code: {book.Code}");
        }

        library.RemoveBookByCode("BO5");
        Console.WriteLine("After removing book by code:");        
        foreach (Book book in library.Books)
        {
            if (book != null)
            {
                Console.WriteLine($"{book.Name} , Code: {book.Code}");
            }
        }






    }
}
