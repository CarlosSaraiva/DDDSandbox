using System;
using SpaUserControl.Domain;
using SpaUserControl.Domain.Contracts.Repositories;
using SpaUserControl.Domain.Models;
using SpaUserControl.Infrastructure.Repositories;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Carlos", "carlos@gmail.com");
            user.SetPassword("12345676", "12345676");
            user.Validate();
            using (IUserRepository userRep = new UserRepository())
            {
                userRep.Create(user);
            }

            using (IUserRepository userRep = new UserRepository())
            {
                var usr = userRep.Get("carlos.saraiva@msn.com");
                Console.WriteLine(usr.Email);
                Console.ReadKey();
            }
        }

    }


}
