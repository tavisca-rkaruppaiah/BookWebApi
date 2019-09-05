using BookWebApi.Controllers;
using BookWebApi.Models;
using System;
using Xunit;

namespace BookWebApi.Tests
{
    public class UnitTestForWebApi
    {
        BookController bookController = new BookController();
        BookResponse bookResponse, bookResponse1;
        Book book;
        [Fact]
        public void IsIdNegativeNumber()
        {
            bookResponse = bookController.Get(-1);
            Assert.Equal("Invalid Id, Id should be a positive number", bookResponse.error.message);

        }

        [Fact]
        public void CreateBook()
        {
            book = new Book()
            {
                id = 1,
                name = "HarryPottor",
                category = "SciFi",
                price = 200,
                author = "JKRowling"
            };
         
            bookResponse = bookController.Post(book);
            bookResponse1 = new BookResponse(book, null);
            Assert.Equal(bookResponse1.book.id, bookResponse.book.id);
        }

        [Fact]
        public void IsNameInvalid()
        {
            book = new Book()
            {
                id = 1,
                name = "HarryPottor1",
                category = "SciFi",
                price = 200,
                author = "JKRowling"
            };
            bookResponse = bookController.Post(book);
            Assert.Equal("bookname should contain Letters Only", bookResponse.error.message);

        }

        [Fact]
        public void IsCategoryInvalid()
        {
            book = new Book()
            {
                id = 1,
                name = "HarryPottor",
                category = "SciFi2",
                price = 200,
                author = "JKRowling"
            };
            bookResponse = bookController.Post(book);
            Assert.Equal("book category should contain Letters Only", bookResponse.error.message);

        }

        [Fact]
        public void IsAuthorInvalid()
        {
            book = new Book()
            {
                id = 1,
                name = "HarryPottor",
                category = "SciFi",
                price = 200,
                author = "JKRowling12"
            };
            bookResponse = bookController.Post(book);
            Assert.Equal("book author should contain Letters Only", bookResponse.error.message);

        }
    }
}
