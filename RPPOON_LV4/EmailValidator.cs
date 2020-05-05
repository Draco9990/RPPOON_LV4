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
            return ContainsAt(candidate) && EndsWith(candidate);
        }

        public bool ContainsAt(string candidate)
        {
            return candidate.Contains("@");
        }

        public bool EndsWith(string candidate)
        {
            return candidate.EndsWith(".com") || candidate.EndsWith(".hr");
        }
    }
}
