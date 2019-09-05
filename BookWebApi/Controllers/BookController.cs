using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookWebApi.Models;
using BookWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        BookService bookService = new BookService();
        // GET: api/Book
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return bookService.Get();
        }

        // GET: api/Book/5
        [HttpGet("{id}", Name = "Get")]
        public BookResponse Get(int id)
        {
            return bookService.GetById(id);
        }

        // POST: api/Book
        [HttpPost]
        public BookResponse Post([FromBody] Book book)
        {
            return bookService.Create(book);
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book book)
        {
            bookService.Update(id, book);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            bookService.Remove(id);
        }
    }
}
