using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.ModelViews.EntityViewsAttributes.RegistrationAttributes
{
    public class RegistrationDateAge : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var date_age = value as string;

            if(string.IsNullOrEmpty(date_age))
            {
                return false;
            }

            return true;
        }
    }
}
