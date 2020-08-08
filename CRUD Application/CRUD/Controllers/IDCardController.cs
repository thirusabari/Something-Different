using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class IDCardController : Controller
    {
        // GET: IDCard
        public ActionResult IDCardList()
        {
            return View();
        }
    }
}