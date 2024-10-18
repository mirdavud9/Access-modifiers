using Access_modifiers_Namespace_Array_in_class;
using System;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("Sefiller", "Viktor Hugo");
        Book book2 = new Book("Zamanin Qisa Tarixi", "Stiven Hovking");
        Book book3 = new Book("Cinayet və Ceza", "Fyodor Dostoyevski");

        BookLibrary library = new BookLibrary("Menim Kitabxanam");
        library.Add(book1);
        library.Add(book2);
        library.Add(book3);

        Console.WriteLine("Butun kitablar:");
        library.ShowAll();
        Console.WriteLine();

        library.BorrowBook("Sefillər");
        library.BorrowBook("Zamanin Qisa Tarixi");

        Console.WriteLine("\nKitablar goturuldukden sonra:");
        library.ShowAll();
        Console.WriteLine();

        library.ReturnBook("Sefiller");

        Console.WriteLine("\nKitablar qaytarildiqdan sonra:");
        library.ShowAll();
        Console.WriteLine();

        Console.WriteLine("\nViktor Hugo terefinden yazilan kitablar:");
        library.SearchByAuthor("Viktor Huqo");
    }
}
