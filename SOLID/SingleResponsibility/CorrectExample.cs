namespace SingleResponsibility
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
            Email = email;
        }
    }

    public class EmailValidator
    {
        public bool ValidateEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                return false;
            }
            return true;
        }
    }
}
