using Entities.DAL;
using Entities.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library_Automation.Controllers
{
    public class BookController : Controller
    {
        LibraryContext context = new LibraryContext();
        BookDAL bookDAL = new BookDAL();
        // GET: Book
        public ActionResult Index()
        {
            var model = bookDAL.GetAll(context,null,"BookType");
            return View(model);
        }
    }
}