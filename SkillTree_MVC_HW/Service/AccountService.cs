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
                Id = account.Id,
                AccountType = account.Categoryyy,
                Total = account.Amounttt,
                CreateTime = account.Dateee,
                Notes = account.Remarkkk
            });
            return result;
        }

        public void Add(AccountViewModel account)
        {
            _db.AccountBook.Add(new AccountBook
            {
                Id = Guid.NewGuid(),
                Categoryyy = account.AccountType,
                Amounttt = account.Total,
                Dateee = account.CreateTime,
                Remarkkk = account.Notes
            });
        }

        public void Save()
        {
            try
            {
                _db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                throw ex;
            }
        }
    }
}