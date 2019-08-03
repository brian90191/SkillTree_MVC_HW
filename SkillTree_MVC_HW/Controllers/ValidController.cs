using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillTree_MVC_HW.Controllers
{
    public class ValidController : Controller
    {
        // GET: Valid
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckDate(DateTime CreateTime)
        {
            bool isValidate = true;
            DateTime today = DateTime.Now;
            int result = DateTime.Compare(CreateTime, today);

            if (result <= 0)
                isValidate = true;
            else
                isValidate = false;

            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}