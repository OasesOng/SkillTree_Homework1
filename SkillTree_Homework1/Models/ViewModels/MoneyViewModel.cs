using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;
using SkillTree_Homework1.Models.Validator;

namespace SkillTree_Homework1.Models.ViewModels
{
    public class MoneyViewModel
    {
        [DisplayName("分類")]
        [Required(ErrorMessage ="必須選擇分類")]
        public int category { get; set; }

        [DisplayName("金額")]
        [Required(ErrorMessage = "必須記錄金額")]
        [Range(0, int.MaxValue, ErrorMessage = "只能輸入正整數")]
        public int money { get; set; }

        [DisplayName("日期")]
        [Required(ErrorMessage = "必須填寫日期")]
        //使用ValidationDate
        [ValidationDate(ErrorMessage = "「日期」不得大於今天")]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }


        [DisplayName("備註")]
        [Required(ErrorMessage = "必須填寫備註")]
        [StringLength(100, ErrorMessage = "「備註」最大輸入100個字元")]
        public string remark { get; set; }
    }


}