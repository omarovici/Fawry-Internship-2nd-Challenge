namespace Quantum_Bookstore.Models;

public class EBook : Book
{
    public string FileType {get; set;}

    public EBook(string title, string author, string publisher, int year, double price, string fileType)
        : base(title, author, publisher, year, price)
    {
        FileType =  fileType;
    }
}