using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Simple_Library.Models{
    public class Book{
        public int BookId { get; set; }
        public string BookName { get; set; }

        public List<BookAuthor> Authors {get; set;}
    }
}