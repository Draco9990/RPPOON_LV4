using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV4
{
    class Fasade : IRegistrationValidator
    {
        EmailValidator emailValidator;
        PasswordValidator passwordValidator;
        
        public Fasade(int minLength)
        {
            emailValidator = new EmailValidator();
            passwordValidator = new PasswordValidator(minLength);
        }

        public bool IsUserEntryValid(UserEntry entry)
        {
            return emailValidator.IsValidAddress(entry.Email) && passwordValidator.IsValidPassword(entry.Password);
        }
    }
}
