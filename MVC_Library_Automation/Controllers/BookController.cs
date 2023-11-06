using Entities.DAL;
using Entities.Model;
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

        public ActionResult Index()
        {
            var model = bookDAL.GetAll(context, null, "BookType");
            return View(model);
        }

        public ActionResult Add()
        {
            ViewBag.liste = new SelectList(context.BookType, "Id", "Type");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Book entity)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.liste = new SelectList(context.BookType, "Id", "Type");
                return View();
            }
            bookDAL.InsertorUpdate(context, entity);
            bookDAL.Save(context);
            return RedirectToAction("Index");
        }

        public ActionResult Detail(int? id)
        {
            var model = bookDAL.GetByFilter(context, x => x.Id == id, "BookType");
            return View(model);
        }

        public ActionResult Delete(int id) {
            if(id == null)
            {
                return HttpNotFound();
            }
            bookDAL.Delete(context, x => x.Id == id);
            bookDAL.Save(context);
            return RedirectToAction("Index");

        }

    }
}
