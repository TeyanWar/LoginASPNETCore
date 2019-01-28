using LoginData;
using LoginData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LoginServices
{
    public class UserService : IUser
    {

        private AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(User newUser)
        {
            _context.Add(newUser);
            _context.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users
                .Include(user => user.Role);
        }

        public User GetById(int id)
        {
            return GetAll()
                .FirstOrDefault(user => user.Id == id);
        }

        public string GetEmail(int id)
        {
            throw new NotImplementedException();
        }

        public string GetFullName(int id)
        {
            throw new NotImplementedException();
        }

        public string GetLastAccess(int id)
        {
            throw new NotImplementedException();
        }

        public Role GetRole(int id)
        {
            return GetById(id).Role;
        }

        public string GetUsername(int id)
        {
            throw new NotImplementedException();
        }
    }
}
