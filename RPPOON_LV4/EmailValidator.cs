using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV4
{
    class EmailValidator : IEmailValidatorService
    {
        public bool IsValidAddress(String candidate)
        {
            if (String.IsNullOrEmpty(candidate))
            {
                return false;
            }
            return candidate.Contains("@") && (candidate.EndsWith(".com")|| candidate.EndsWith(".hr"));
        }
    }
}
