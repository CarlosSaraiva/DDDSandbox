using System;
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
            AssertionConcern.AssertArgumentNotNull(password, "Senha Inválida");
            AssertionConcern.AssertArgumentNotNull(confirmPassword, "Confirmação de senha inválida");
            AssertionConcern.AssertArgumentEquals(password, confirmPassword, "As senhas são iguais!");
            AssertionConcern.AssertArgumentLength(password, 6, 20, "Senhas inválidas");
            this.Password = password;
        }


    }
}
