using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace SkillTree_MVC_HW.Models.ViewModels
{
    public class AccountViewModel
    {
        public string Type { get; set; }
        public DateTime DT { get; set; }
        public int Total { get; set; }
    }
}