using System;
using SpaUserControl.Common.Resources;
using SpaUserControl.Common.Validation;

namespace SpaUserControl.Domain.Models
{
    public class User
    {        
        public User(string name ,string email)
        {
            Name = name;
            Email = email;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public void SetPassword(string password, string confirmPassword)
        {
            AssertionConcern.AssertArgumentNotNull(password, Errors.InvalidPassword);
            AssertionConcern.AssertArgumentNotNull(confirmPassword, Errors.InvalidPasswordConfirmation);
            AssertionConcern.AssertArgumentEquals(password, confirmPassword, Errors.PasswordNotMatch);
            AssertionConcern.AssertArgumentLength(password, 6, 20, Errors.InvalidPassword);
            this.Password = PasswordAssertionConcern.Encrypt(password);

        }

        public string resetPassword()
        {
            string password = Guid.NewGuid().ToString().Substring(0, 8);
            this.Password = PasswordAssertionConcern.Encrypt(password);
            return password;
        }

    }
}
