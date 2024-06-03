namespace _04._06._2024_task;

public class Book
{
    private int _id;
    public static int Counter;
    public Book()
    {
        
        Counter++;
        _id =Counter;

    }

    private string _name;
    private string _authorName;
    private int _pageCount;
    private string _code;

    public Book(string name) :this() 
    {
        this._name = name;
        GenerateCode();
            
    }

    public int Id { get { return _id; } }
    public string Name { get { return _name; } set { _name = value; } }
    public string AuthorName { get { return _authorName; } set { _authorName = value; } }
    public int PageCount { get { return _pageCount; } set { _pageCount = value; } }
    public string Code 
    { 
      get { return _code; } 
      set { _code = value; }       
    }
    private void GenerateCode() 
    {
        string firstTwoLetters;
        if (Name.Length >= 2)
        {
            firstTwoLetters = Name.Substring(0, 2).ToUpper();
        }
        else if (Name.Length == 1)
        {
            firstTwoLetters = Name.ToUpper() + "X";
        }
        else
        {
            firstTwoLetters = "XX";
        }

        
        _code = $"{firstTwoLetters}{Id}";

    }
}


