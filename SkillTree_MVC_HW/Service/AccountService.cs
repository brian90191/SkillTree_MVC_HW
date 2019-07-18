using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SkillTree_MVC_HW.Models;
using SkillTree_MVC_HW.Models.ViewModels;

namespace SkillTree_MVC_HW.Service
{
    public class AccountService
    {
        private readonly AccountModel _db;

        public AccountService()
        {
            _db = new AccountModel();
        }

        public IEnumerable<AccountViewModel> Lookup()
        {
            var result = _db.AccountBook.Select(account => new AccountViewModel()
            {
                Type = account.Categoryyy.ToString(),
                Total = account.Amounttt,
                CreateTime = account.Dateee
            });
            return result;
        }

        public void Add(AccountViewModel account)
        {
            _db.AccountBook.Add(new AccountBook
            {
                Categoryyy = Int32.Parse(account.Type),
                Amounttt = account.Total,
                Dateee = account.CreateTime
            });
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}