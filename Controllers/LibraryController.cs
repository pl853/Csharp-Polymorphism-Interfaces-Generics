using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Simple_Library.Models;

namespace Simple_Library.Controllers
{
    public class LibraryController : Controller
    {
        private readonly DatabaseModel _dbContext;
        public LibraryController(DatabaseModel dbContext){
            _dbContext = dbContext;

            if (_dbContext.Authors.Count() == 0 &&
         _dbContext.Books.Count() == 0)
         
        System.Console.WriteLine("00000");
        Author a1 = new Author(){AuthorName = "John Ronald Reuel Tolkien",AuthorId = 1};
        Author a2 = new Author(){AuthorName = "Paulo Coelho",  AuthorId = 2};
        _dbContext.Authors.Add(a1);
        _dbContext.Authors.Add(a2);
        _dbContext.SaveChanges();
        System.Console.WriteLine("aaa");

        Book b1 = new Book(){BookId=1, BookName="The Lord Of The Rings"};
        Book b2 = new Book(){BookId=2, BookName="The Silmarillion"};

        Book b3 = new Book(){BookId=3, BookName="The Alchemist"};
        Book b4 = new Book(){BookId=4, BookName="The Pilgrimage"};

        Book b5 = new Book(){BookId=5, BookName="The Prophet"};
        Book b6 = new Book(){BookId=6, BookName="Kingdom of the Imagination"};
        _dbContext.Books.Add(b1);
        _dbContext.Books.Add(b2);
        _dbContext.Books.Add(b3);
        _dbContext.Books.Add(b4);
        _dbContext.Books.Add(b5);
        _dbContext.Books.Add(b6);

        BookAuthor ba11 = new BookAuthor(){AuthorId=a1.AuthorId, BookId=b1.BookId};
        BookAuthor ba12 = new BookAuthor(){AuthorId=a1.AuthorId, BookId=b2.BookId};
        BookAuthor ba23 = new BookAuthor(){AuthorId=a2.AuthorId, BookId=b3.BookId};
        BookAuthor ba24 = new BookAuthor(){AuthorId=a2.AuthorId, BookId=b4.BookId};
        _dbContext.BookAuthor.Add(ba11);
        _dbContext.BookAuthor.Add(ba12);
        _dbContext.BookAuthor.Add(ba23);
        _dbContext.BookAuthor.Add(ba24);

        _dbContext.SaveChanges();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("GetAll")]
        public AuthorBooks[] GetAll()
        {
            var authorsandbooks = (from a in _dbContext.Authors
                                    let a_books = (from a_b in _dbContext.BookAuthor 
                                                   from b in _dbContext.Books
                                                   where a_b.AuthorId == a.AuthorId && a_b.BookId == b.BookId
                                                   select b).ToArray()
                                                   select new AuthorBooks(){Author=a,Books=a_books}).ToArray();
            
            return authorsandbooks;
        }

        public class AuthorBooks{
            public Author Author {get;set;}
            public Book[] Books {get;set;}
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}