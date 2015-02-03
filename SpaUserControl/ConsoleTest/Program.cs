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
            var user = new User("Carlos", "carlos.saraiva@msn.com", "123456");

            Console.WriteLine(user.Name);
            Console.ReadKey();
        }
    }
}
