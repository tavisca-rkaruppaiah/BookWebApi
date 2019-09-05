using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi.Models
{
    class BookDetails
    {
        private static List<Book> books = new List<Book>();
        public void Add(Book book)
        {
            books.Add(book);
        }

        public void Remove(int id)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].id == id)
                    books.RemoveAt(i);
            }
        }

        public Book GetById(int id)
        {
            for(int i = 0; i<books.Count; i++)
            {
                if (books[i].id == id)
                    return books[i];
            }
            return null;
        }

        public List<Book> Get()
        {
            return books;
        }

        public void UpdateInformation(int id, Book book)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].id == id)
                    books[i] = book;
            }
        }
    }
}
