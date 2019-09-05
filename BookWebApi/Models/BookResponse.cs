using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi.Models
{
    public class BookResponse
    {
        public Book book;
        public Error error;//code=100 , message-invalid record 

        public BookResponse(Book book, Error error)
        {
            this.book = book;
            this.error = error;
        }
    }
}
