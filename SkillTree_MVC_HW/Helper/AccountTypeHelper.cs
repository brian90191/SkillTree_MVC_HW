using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillTree_MVC_HW.Helper
{
    public static class AccountTypeHelper
    {
        public static HtmlString DisplayTypeColor(this HtmlHelper htmlHelper, int type)
        {
            var className = "";
            if (type == 0)
            {
                className = "label label-success";
            }
            else
            {
                className = "label label-danger";
            }

            var accountTypeStr = type == 0 ? "支出" : "收入";
            return new MvcHtmlString($"<span class='{className}'>{accountTypeStr}</span>");
        }
    }
}