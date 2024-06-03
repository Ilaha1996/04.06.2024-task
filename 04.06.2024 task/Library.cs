namespace _04._06._2024_task;

public class Library
{
    public Book[] Books = Array.Empty<Book>();
    public void AddBook(Book book) 
    {
        Array.Resize(ref Books, Books.Length +1);
        Books[Books.Length-1] = book;    
    }

    public Book[] FindAllBooksByName (string value) 
    {
        Book[] result = new Book[0];
        string searchLower = value.ToLower(); 

        foreach (Book book in Books)
        {
            if (book != null)
            {
                string bookNameLower = book.Name.ToLower(); 

                if (bookNameLower.Contains(searchLower))
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = book;
                }
            }
        }
        return result;

    }


    public Book FindBookBYCode(string _code) 
    {

        string searchLower = _code.ToLower(); 

        foreach (Book book in Books)
        {
            if (book != null)
            {
                string bookCodeLower = book.Code.ToLower(); 

                if (bookCodeLower.Equals(searchLower))
                {
                    return book;
                }
            }
        }

        return null;
    }
    
    public Book[] FindAllBooksByPageCountRange(int min,int max) 
    {
        Book[] result = new Book[0];

        foreach (Book book in Books)
        {
            if (book != null && book.PageCount >= min && book.PageCount <= max)
            {
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = book;
            }
        }

        return result;

    }

    public void RemoveBookByCode (string _code) 
    {
        string searchLower = _code.ToLower(); 

        for (int i = 0; i < Books.Length; i++)
        {
            if (Books[i] != null)
            {
                string bookCodeLower = Books[i].Code.ToLower(); 

                if (bookCodeLower == searchLower)
                {
                    Books[i] = null;
                    return;
                }
            }
        }



    }

}
