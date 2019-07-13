using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkillTree_MVC_HW.Models.ViewModels;

namespace SkillTree_MVC_HW.Controllers
{
    public class AccountController : Controller
    {
        private Random rnd = new Random();

        // GET: Account
        public ActionResult Index()
        {
            List<AccountViewModel> AccountList = new List<AccountViewModel>();

            string[] types = { "支出", "收入" };
            for (int i = 0; i < 100; i++)
            {
                int typeIndex = rnd.Next(2);
                int rndMoney = rnd.Next(1, 10000);

                var AccountResult = new AccountViewModel()
                {
                    Type = types[typeIndex],
                    CreateTime = RandomDay(),
                    Total = rndMoney
                };

                AccountList.Add(AccountResult);
            }

            return View(AccountList);
        }

        DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }
    }
}