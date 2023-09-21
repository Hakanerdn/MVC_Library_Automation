﻿using Entities.DAL;
using Entities.Model;
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
        BookTypeDAL bookTypeDAL = new BookTypeDAL();
        public ActionResult Index()
        {
            var model = bookTypeDAL.GetAll(context);
            return View(model);
        }

        public ActionResult Add()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Add(BookType bookType)
        {
            if (ModelState.IsValid)
            {
                bookTypeDAL.InsertorUpdate(context, bookType);
                bookTypeDAL.Save(context);
                return RedirectToAction("Index");
            }
            return View(bookType);
        }

        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var model = bookTypeDAL.GetById(context, id);
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Update(BookType bookType)
        {
            if (ModelState.IsValid)
            {
                bookTypeDAL.InsertorUpdate(context, bookType);
                bookTypeDAL.Save(context);
                return RedirectToAction("Index");
            }
            return View(bookType);
        }

    }
}