using System;

namespace SOLID._1._SingleResponsibility
{
    /* BAD CODE */
    public class BadUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        private bool ValidateEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                return false;
            }
            return true;
        }
    }

    /* GOOD CODE */
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public class EmailValidator
    {
        private bool ValidateEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                return false;
            }
            return true;
        }
    }
}
