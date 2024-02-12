using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace laba_2
{
    internal class UserValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is int)
            {
                return true;
            }
            ErrorMessage = ("id don't valid");
            return false;
        }
    }


    internal class UserValidationAttributeYear : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is int)
            {
                return true;
            }
            ErrorMessage = ("id don't valid");
            return false;
        }
    }
    internal class UserValidationAttributeweight : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is int)
            {
                return true;
            }
            ErrorMessage = ("id don't valid");
            return false;
        }
    }
}
