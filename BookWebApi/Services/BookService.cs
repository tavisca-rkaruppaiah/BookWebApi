using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookWebApi.Models;

namespace BookWebApi.Services
{
    public class BookService : IServices
    {
        BookDetails bookDetails = new BookDetails();
        public BookResponse Create(Book book)
        {
            if(Validation.IsPositiveNumber(book.id))
            {
                if (Validation.IsContainsLettersOnly(book.name))
                {
                    if (Validation.IsContainsLettersOnly(book.category))
                    {
                        if (Validation.IsContainsLettersOnly(book.author))
                        {
                            bookDetails.Add(book);

                            return new BookResponse(book, null);
                        }
                        else
                            return new BookResponse(null, new Error(100, "book author should contain Letters Only"));
                    }
                    else
                        return new BookResponse(null, new Error(100, "book category should contain Letters Only"));

                }
                else
                {
                    return new BookResponse(null, new Error(100, "bookname should contain Letters Only"));
                }

            }
            else
            {
                return new BookResponse(null, new Error(100, "Invalid Id, Id should be a positive number"));
            }
        }

        public void Remove(int id)
        {
            bookDetails.Remove(id);
        }

        public BookResponse GetById(int id)
        {
            if (Validation.IsPositiveNumber(id))
            {
                if (bookDetails.GetById(id) != null)
                {
                    return new BookResponse(bookDetails.GetById(id), null);
                }
                else
                {
                    return new BookResponse(null, new Error(404, "IdNotFound")); ;
                }

            }
            else
                return new BookResponse(null, new Error(100, "Invalid Id, Id should be a positive number"));

        }

        public List<Book> Get()
        {
            return bookDetails.Get();
        }

        public void Update(int id, Book book)
        {
            bookDetails.UpdateInformation(id, book);
        }
    }
}
