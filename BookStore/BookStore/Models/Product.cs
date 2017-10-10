using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Product
    {
        public int IDictionary { get; set; }
        public string AuthorName { get; set; }
        public string BookName { get; set; }
        public string About { get; set; }
        public double Price { get; set; }
    }
}