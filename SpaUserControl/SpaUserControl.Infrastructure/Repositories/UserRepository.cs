using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaUserControl.Domain.Contracts.Repositories;
using SpaUserControl.Domain.Models;
using SpaUserControl.Infrastructure.Data;

namespace SpaUserControl.Infrastructure.Repositories
{
    class UserRepository:IUserRepository
    {
        private AppDataContext _context = new AppDataContext();

        public User Get(Guid id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public User Get(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
        }

        public void Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            //Entity framework busca o usuario nome e compara com a variavel, verificando o que houve de alteração.
            _context.Entry<User>(user).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
