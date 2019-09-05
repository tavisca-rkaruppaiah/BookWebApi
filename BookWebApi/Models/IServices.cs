using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWebApi.Models
{
    public interface IServices
    {
        List<Book> Get();
        BookResponse Create(Book book);
        BookResponse GetById(int id);
        void Update(int id, Book book);
        void Remove(int id);
    }
}
