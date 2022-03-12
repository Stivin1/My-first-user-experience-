using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Models.ModelViews.EntityViewsAttributes.RegistrationAttributes
{
    public class RegistrationEmail : ValidationAttribute
    {
        string[] EmailDomains { get; set; }

        public RegistrationEmail(string[] EmailDomains)
        {
            this.EmailDomains = EmailDomains;
        }

        public override bool IsValid(object value)
        {
            var domain = value as string;

            Console.WriteLine(domain);

            if (domain != null)
            {
                for (int i = 0; i < EmailDomains.Length; i++)
                {
                    if (domain.Contains(EmailDomains[i])) return true;
                }
            }

            return false;
        }
    }
}
