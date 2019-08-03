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
            ViewData["AccountTypes"] = GetAccountTypeList();

            return View();
        }

        private List<SelectListItem> GetAccountTypeList()
        {
            List<SelectListItem> AccountTypeList = new List<SelectListItem>()
            {
                new SelectListItem() { Text= "支出", Value = "0" },
                new SelectListItem() { Text= "收入", Value = "1"}
            };

            return AccountTypeList;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccountType,Total,CreateTime,Notes")]
                                   AccountViewModel account)
        {
            if (ModelState.IsValid)
            {
                _accountService.Add(account);
                _accountService.Save();
            }

            ViewData["AccountTypes"] = GetAccountTypeList();

            return View(account);
        }
    }
}