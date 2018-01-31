using System;
using Microsoft.EntityFrameworkCore;

namespace Simple_Library.Models{
    public class BookAuthor{
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}