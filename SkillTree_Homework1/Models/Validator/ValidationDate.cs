using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SkillTree_Homework1.Models.Validator
{
    /// <summary>
    /// 自訂ValidationAttribute - 檢驗日期
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class ValidationDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime date = Convert.ToDateTime(value);
                if (date > DateTime.Now)
                {
                    return new ValidationResult("「日期」不得大於今天");
                }
            }
            return ValidationResult.Success;
        }
    }
}