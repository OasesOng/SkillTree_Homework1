using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SkillTree_Homework1.Models.ViewModels
{
    public class MoneyViewModel
    {
        [DisplayName("分類")]
        [Required]
        public int category { get; set; }

        [DisplayName("金額")]
        [Required]
        public int money { get; set; }

        [DisplayName("日期")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }


        [DisplayName("備註")]
        [Required]
        public string remark { get; set; }

    }

   
}