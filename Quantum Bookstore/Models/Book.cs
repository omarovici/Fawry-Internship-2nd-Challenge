namespace Quantum_Bookstore.Models;

public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
    
    public Book(string isbn, string title, string author, int year, double price)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
        Year = year;
        Price = price;
    }
}