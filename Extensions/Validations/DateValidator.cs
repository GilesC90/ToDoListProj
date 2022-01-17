using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Extensions.Validations
{
    public class DateValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime todayDate = Convert.ToDateTime(value);
            return todayDate >= DateTime.Now;
        }
    }
}