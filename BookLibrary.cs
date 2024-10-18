using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers_Namespace_Array_in_class
{
public class BookLibrary
    {
        private string _name;
        private Book[] _books = new Book[0];  

        public BookLibrary(string name)
        {
            _name = name;
        }

        public void Add(Book book)
        {
            Array.Resize(ref _books, _books.Length + 1);
            _books[_books.Length - 1] = book;
        }

        public void Remove(Book book)
        {
            int index = Array.IndexOf(_books, book);
            if (index >= 0)
            {
                for (int i = index; i < _books.Length - 1; i++)
                {
                    _books[i] = _books[i + 1];
                }
                Array.Resize(ref _books, _books.Length - 1);
            }
        }

        public void ShowAll()
        {
            foreach (var book in _books)
            {
                book.GetInfo();
            }
        }

        public void BorrowBook(string name)
        {
            foreach (var book in _books)
            {
                if (book.GetName().Equals(name, StringComparison.OrdinalIgnoreCase) && book.IsAvailable())
                {
                    book.SetAvailability(false);  
                    Console.WriteLine($"{name} kitabi goturuldu.");
                    return;
                }
            }
            Console.WriteLine($"{name} kitabi movcud deyil ve ya artiq goturulub.");
        }

        public void ReturnBook(string name)
        {
            foreach (var book in _books)
            {
                if (book.GetName().Equals(name, StringComparison.OrdinalIgnoreCase) && !book.IsAvailable())
                {
                    book.SetAvailability(true);  
                    Console.WriteLine($"{name} kitabi qaytarıldı.");
                    return;
                }
            }
            Console.WriteLine($"{name} kitabi qaytarilmadi ve ya movcud deyil.");
        }

        public void SearchByAuthor(string author)
        {
            foreach (var book in _books)
            {
                if (book.GetAuthor().Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    book.GetInfo();  
                }
            }
        }
    }

}

