using System;

namespace ViolationExample
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public User(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = ValidateEmail(email);
        }

        private string ValidateEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new FormatException("Email address has a wrong format.");
            }
            return email;
        }
    }
}
