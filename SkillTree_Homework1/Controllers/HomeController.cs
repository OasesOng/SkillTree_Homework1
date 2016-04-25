using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkillTree_Homework1.Models.ViewModels;
using SkillTree_Homework1.Models;

namespace SkillTree_Homework1.Controllers
{
    public class HomeController : Controller
    {
        private SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Account()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Account(MoneyViewModel data)
        {
            if (!ModelState.IsValid)
            {
                return View(data);
            }

            var accountBook = new AccountBook
            {
                Id = Guid.NewGuid(),
                Categoryyy = data.category,
                Amounttt = data.money,
                Dateee = data.date,
                Remarkkk = data.remark
            };

            db.AccountBook.Add(accountBook);
            db.SaveChanges();

            return View();
        }


        [ChildActionOnly]
        public ActionResult Record(MoneyViewModel data)
        {
            var records = db.AccountBook
                 .OrderByDescending(x => x.Dateee)
                 .Take(7)
                 .Select(x => new MoneyViewModel
                 {
                     category = x.Categoryyy,
                     money = x.Amounttt,
                     date = x.Dateee,
                     remark = x.Remarkkk
                 }
                
                );
            return View(records);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }

        private List<SelectListItem> GetCategoryListItem()
        {
            List<SelectListItem> listItems = new List<SelectListItem>();
            listItems.Add(new SelectListItem
            {
                Text = "支出",
                Value = "0"
            });
            listItems.Add(new SelectListItem
            {
                Text = "收入",
                Value = "1"
            });

            return listItems;
        }
    }
}