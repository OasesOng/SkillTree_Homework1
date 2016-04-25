using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SkillTree_Homework1.App_Code
{
    public static class Helper
    {
        /// <summary>
        /// 檢查目前之頁面的Routes
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="controllerName"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        public static bool IsCurrentPage(this HtmlHelper helper, string controllerName, string actionName)
        {
            var currentControllerName = (string)helper.ViewContext.RouteData.Values["controller"];
            var currentActionName = (string)helper.ViewContext.RouteData.Values["action"];

            if (currentControllerName.Equals(controllerName, StringComparison.CurrentCultureIgnoreCase)
                && currentActionName.Equals(actionName, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }



    }
}