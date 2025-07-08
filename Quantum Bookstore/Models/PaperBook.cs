namespace Quantum_Bookstore.Models;

public class PaperBook : Book
{
    public int Stock {get; set;}
    
    public PaperBook(string title, string author, string publisher, int year, double price, int stock)  
        : base(title, author, publisher, year, price)
    {
        if(stock<0) throw new Exception("Stock cannot be negative");
        Stock = stock;
    }
}