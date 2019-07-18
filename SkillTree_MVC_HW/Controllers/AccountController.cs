using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkillTree_MVC_HW.Models.ViewModels;
using SkillTree_MVC_HW.Models;
using SkillTree_MVC_HW.Service;


namespace SkillTree_MVC_HW.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult DataList()
        {
            return View(_accountService.Lookup().OrderByDescending(d => d.CreateTime));
        }

        [ChildActionOnly]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Type,Total,CreateTime")]
                                   AccountViewModel account)
        {
            if (ModelState.IsValid)
            {
                _accountService.Add(account);
                _accountService.Save();
                //return RedirectToAction("Index");
            }

            return View(account);
        }
    }
}