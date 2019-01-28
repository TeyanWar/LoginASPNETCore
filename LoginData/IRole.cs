using LoginData.Models;
using System.Collections.Generic;

namespace LoginData
{
    public interface IRole
    {
        IEnumerable<Role> GetAll();
        Role GetById(int id);

        void Add(Role newRole);
        string GetName(int id);
        string GetDesc(int id);        
    }
}
