using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStore.Models
{
    public class ProductDbIniyializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Products.Add(new Product
            {
                Id = 1,
                BookName = "Мёртвые души",
                AuthorName = "Н.В. Гоголь",
                Price = 125.5
            });
            base.Seed(db);
        }
    }
}