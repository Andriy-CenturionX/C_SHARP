using System;
using System.Collections.Generic;

class Book : IComparable<Book>
{
    public string Title { get; set; }
    public int Year { get; set; }

    public int CompareTo(Book other)
    {
        return Year.CompareTo(other.Year); 
    }
}

class Program
{
    static void Main()
    {
        var books = new List<Book>
        {
            new Book { Title = "Book C", Year = 2020 },
            new Book { Title = "Book A", Year = 1488 },
            new Book { Title = "Book B", Year = 1939 }
        };

        books.Sort();

        foreach (var book in books)
            Console.WriteLine($"{book.Title} - {book.Year}");
    }
}
