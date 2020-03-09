using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP24
{
    class MyLibrary
    {
        private Dictionary<string, Book> _books;

        public MyLibrary()
        {
                _books = new Dictionary<string, Book>();
        }

        public bool AddBook(Book b)
        {
            if (_books.ContainsKey(b.Title))
            {
                return false;
            }

            else
            {
                _books.Add(b.Title, b);
                return true;
            }

        }

        public bool RemoveBook(string Title)
        {
            if (!_books.ContainsKey(Title))
            {
                return false;
            }

            else
            {
                _books.Remove(Title);
                return true;
            }

        }

        public bool HaveThisBook(string Title)
        {
            if (!_books.ContainsKey(Title))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Book GetBook(string Title)
        {
            if (!_books.ContainsKey(Title))
            {
                return null;

            }
            else
            {
                return _books[Title];
            }
        }
        public Book GetBookByAuthor(string author)
        {
            //option 1
            foreach(KeyValuePair<string,Book> pair in _books)
            {
                if (pair.Value.Author == author)
                    return pair.Value;
            }

            //option 2
            foreach (Book book in _books.Values)
            {
                if (book.Author == author)
                    return book;
            }
            return null;
        }
        public void ClearBook()
        {
            _books.Clear();
        }

        public List<string> GetAuthor()
        {
            List<string> authors = new List<string>();
            foreach (Book book in _books.Values)
            {
                authors.Add(book.Author);
            }
            return authors;
        }

        public List<Book> GetBooksSortedByAuthorsName()
        {
            List<Book> books = new List<Book>();
            foreach (Book book in _books.Values)
            {
                books.Add(book);
            }
            books.Sort(); // will use IComparable<Book> = by author
            return books;
        }

        public List<string> GetBooksTitleSorted()
        {
            List<string> titles = new List<string>();
            foreach (Book book in _books.Values)
            {
                titles.Add(book.Title);
            }
            titles.Sort();
            return titles;
        }
        public int CountBooks
        {
            get
            {
              return  _books.Count();
            }
        }


    }
}
