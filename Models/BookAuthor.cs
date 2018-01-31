using System;
using Microsoft.EntityFrameworkCore;

namespace Simple_Library.Models{
    public class BookAuthor{
        public int BookAuthorId { get; set; }
        public Book BookId { get; set; }
        public Author AuthorId { get; set; }
    }
}