using System;
using System.Collections.Generic;
using System.Text;
using XUnitEntities;

namespace XUnitServices.Interfaces
{
    public interface IUserService
    {
        User SaveUser(User user);
        User UpdateUser(User user);
        User GetUserById(int id);
        List<User> GetAllUsers();
    }
}
