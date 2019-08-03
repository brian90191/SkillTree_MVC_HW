using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SkillTree_MVC_HW.Models.ViewModels
{
    public class AccountViewModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "請選擇支出或收入")]
        [Display(Name = "類別")]
        public int AccountType { get; set; }

        [Remote("CheckDate", "Valid", ErrorMessage = "日期不得大於今天")]
        [Display(Name = "日期")]
        public DateTime CreateTime { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "只能輸入正整數")]
        [Display(Name = "金額")]
        public int Total { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "最多輸入100個字元")]
        [Display(Name = "備註")]
        public string Notes { get; set; }
    }
}