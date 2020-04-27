using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV4
{
    class Fasade : IRegistrationValidator
    {

        EmailValidator emailValidator = new EmailValidator();
        PasswordValidator passwordValidator = new PasswordValidator(5);

        public Fasade(EmailValidator emailValidatorIn, PasswordValidator passwordValidatorIn)
        {
            emailValidator = emailValidatorIn;
            passwordValidator = passwordValidatorIn;
        }

        public bool IsUserEntryValid(UserEntry entry)
        {
            return emailValidator.IsValidAddress(entry.Email) && passwordValidator.IsValidPassword(entry.Password);
        }
    }
}
