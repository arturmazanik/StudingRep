using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product()
            {
                AuthorName = "Н.В. Гоголь",
                BookName = "Мёртвые души",
                About = "«...Говоря о Мертвых душах - можно вдоволь наговориться о России...» -это суждение Вяземского объясняло главную причину споров и определяло особое место книги в истории русской литературы",
                Price = 15.5
            });

            return View();
        }
    }
}