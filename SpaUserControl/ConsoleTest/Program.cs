using System;
using SpaUserControl.Domain.Models;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Carlos", "carlos.saraiva@msn.com");
            try
            {
                user.SetPassword("123456", "123456");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            user.Validate();
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Password);

            user.ResetPassword();
            Console.WriteLine(user.Password);
            Console.ReadKey();
        }
    }
}
