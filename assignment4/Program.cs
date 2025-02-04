using System;

class Program
{
    static void Main()
    {
        // Create a Book object
        Book book = new("The Great Gatsby", "F. Scott Fitzgerald", 10.99, "1234567890");
        Console.WriteLine(book.ToString());

        // Create a Magazine object
        Magazine magazine = new("National Geographic", "Various Authors", 5.99, "0987654321", 202, "October");
        Console.WriteLine(magazine.ToString());

        // Create an Audiobook object
        AudioBook audioBook = new("1984", "George Orwell", 15.99, "1122334455", 12.5, "Simon Prebble");
        Console.WriteLine(audioBook.ToString());

        // Update the price of the Magazine and Audiobook
        magazine.SetPrice(6.99);
        audioBook.SetPrice(17.99);

        // Display the updated details
        Console.WriteLine(magazine.ToString());
        Console.WriteLine(audioBook.ToString());
    }
}

class Book
{
    private string title;
    private string author;
    private double price;
    private string isbn;

    public Book(string title, string author, double price, string isbn)
    {
        this.title = title;
        this.author = author;
        SetPrice(price);
        this.isbn = isbn;
    }

    public string Title => title;
    public string Author => author;
    public double Price => price;
    public string ISBN => isbn;

    public void SetPrice(double pr)
    {
        if (pr > 0)
        {
            price = pr;
        }
        else
        {
            Console.WriteLine("Price must be greater than zero. Setting to default value of 1.0.");
            price = 1.0;
        }
    }

    public override string ToString()
    {
        return $"Title: {title}\nAuthor: {author}\nPrice: {price}\nISBN: {isbn}";
    }
}

class Magazine : Book
{
    private int issueNumber;
    private string monthOfPublication;

    public Magazine(string title, string author, double price, string isbn, int issueNumber, string monthOfPublication)
        : base(title, author, price, isbn)
    {
        this.issueNumber = issueNumber;
        this.monthOfPublication = monthOfPublication;
    }

    public int IssueNumber => issueNumber;
    public string MonthOfPublication => monthOfPublication;

    public void SetPrice(double pr)
    {
        if (pr > 0)
        {
            base.SetPrice(pr + issueNumber * 0.1); // Adjust price based on issue number
        }
        else
        {
            Console.WriteLine("Price must be greater than zero. Setting to default value of 1.0.");
            base.SetPrice(1.0);
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"\nIssue Number: {issueNumber}\nMonth of Publication: {monthOfPublication}";
    }
}

class AudioBook : Book
{
    private string narrator;
    private double duration;

    public AudioBook(string title, string author, double price, string isbn, double duration, string narrator)
        : base(title, author, price, isbn)
    {
        this.duration = duration;
        this.narrator = narrator;
    }

    public string Narrator => narrator;
    public double Duration => duration;

    public void SetPrice(double pr)
    {
        if (pr > 0)
        {
            base.SetPrice(pr + duration * 0.5); // Adjust price based on duration
        }
        else
        {
            Console.WriteLine("Price must be greater than zero. Setting to default value of 1.0.");
            base.SetPrice(1.0);
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"\nNarrator: {narrator}\nDuration: {duration} hours";
    }
}