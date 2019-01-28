using LoginData.Models;
using System.Collections.Generic;

namespace LoginData
{
    public interface IUser
    {
        IEnumerable<User> GetAll();
        User GetById(int id);

        void Add(User newUser);
        string GetFullName(int id);
        string GetEmail(int id);
        string GetUsername(int id);
        string GetLastAccess(int id);

        Role GetRole(int id);
    }
}
