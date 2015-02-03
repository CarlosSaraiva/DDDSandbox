using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
            Console.WriteLine(user.Name);
            Console.ReadKey();
        }
    }
}
