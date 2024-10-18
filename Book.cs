 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers_Namespace_Array_in_class
{

        using System;

public class Book
{
    private string _name;
    private string _author;
    private bool _isAvailable = true;  

    public Book(string name, string author)
    {
        _name = name;
        _author = author;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Kitab:{_name},Muellif:{_author},Movcuddur:{_isAvailable}");
    }

    public bool IsAvailable()
    {
        return _isAvailable;
    }

    public void SetAvailability(bool status)
    {
        _isAvailable = status;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAuthor()
    {
        return _author;
    }
}
}

