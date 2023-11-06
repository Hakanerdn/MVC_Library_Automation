using Entities.DAL;
using Entities.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Library_Automation.Controllers
{
    public class NoticeController : Controller
    {
        LibraryContext context = new LibraryContext();
        NoticeDAL noticeDAL = new NoticeDAL();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult NoticeList()
        {
            var model = noticeDAL.GetAll(context);
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}