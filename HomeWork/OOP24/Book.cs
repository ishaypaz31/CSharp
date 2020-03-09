using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP24
{
    class Book : IComparable<Book>
    {
        public string Title { get; protected set; }
        public string Content { get; protected set; }
        public string Author { get; protected set; }
        public string Category { get; protected set; }

        public Book(string title, string content, string author, string category)
        {
            Title = title;
            Content = content;
            Author = author;
            Category = category;
        }

        public override string ToString()
        {
            return $"Book Title: {Title} , Content: {Content} , Author: {Author}, Category: {Category}";
        }

        public int CompareTo(Book other)
        {
            return Author.CompareTo(other.Author);
        }
    }
}
