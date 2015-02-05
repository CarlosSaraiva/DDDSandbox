using System;
using System.Diagnostics;
using SpaUserControl.Common.Resources;
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
            Console.WriteLine(Errors.Program_Main_Nome);
            string nome = Console.ReadLine();

            Console.WriteLine(Errors.Program_Main_e_mail_);
            string email = Console.ReadLine();            

            Console.WriteLine(Errors.Program_Main_Nova_senha_);
            string senha = Console.ReadLine();

            Console.WriteLine(Errors.Program_Main_Confirme_senha_);
            string confirmaSenha = Console.ReadLine();

            var user = new User(nome, email);
            user.SetPassword(senha, confirmaSenha);
            user.Validate();
            using (IUserRepository userRep = new UserRepository())
            {
                userRep.Create(user);
            }

            using (IUserRepository userRep = new UserRepository())
            {
                var usr = userRep.Get(email);
                if (usr != null)
                {
                    Console.WriteLine(usr.Email + " " + usr.Name + " " + usr.Id);
                }
                else
                {
                    Console.WriteLine(Errors.Program_Main_Usuário_não_encontrado);
                }
                
                Console.ReadKey();
            }
        }

    }


}
