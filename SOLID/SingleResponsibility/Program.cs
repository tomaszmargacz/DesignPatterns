using System;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailValidator emailValidator = new EmailValidator();
            User user = new User("Tomasz", "Margacz", "tomasz.margacz@gmail.com");

            if (!emailValidator.ValidateEmail(user.Email))
            {
                throw new FormatException("Email address has a wrong format.");
            }
        }
    }
}
