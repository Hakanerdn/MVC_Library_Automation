using Entities.DAL;
using Entities.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library_Automation.Controllers
{
    public class BookTypeController : Controller
    {
        // GET: BookType
        LibraryContext context = new LibraryContext();
        BookTypeDAL BookTypeDAL = new BookTypeDAL();
        public ActionResult Index()
        {
            var model = BookTypeDAL.GetAll(context);
            return View(model);
        }
    }
}