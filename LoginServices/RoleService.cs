using LoginData;
using LoginData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LoginServices
{
    public class RoleService : IRole
    {

        private AppDbContext _context;

        public RoleService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Role newRole)
        {
            _context.Add(newRole);
            _context.SaveChanges();
        }

        public IEnumerable<Role> GetAll()
        {
            return _context.Roles;
        }

        public Role GetById(int id)
        {
            return GetAll()
                .FirstOrDefault(Role => Role.Id == id);
        }

        public string GetDesc(int id)
        {
            throw new NotImplementedException();
        }
        

        public string GetName(int id)
        {
            throw new NotImplementedException();
        }
        
    
    }
}
