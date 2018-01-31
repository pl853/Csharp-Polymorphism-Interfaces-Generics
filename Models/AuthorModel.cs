using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Simple_Library.Models{
    public class Author{
        public int AuthorId { get; set; }
        public string  AuthorName { get; set; }
        public List<BookAuthor> Books { get; set; }
    }
}