using System;
using System.Collections.Generic;
using System.Text;
using XUnitEntities;
using XUnitRepository.Interfaces;
using XUnitServices.Interfaces;

namespace XUnitServices.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<User> GetAllUsers()
        {
            return this.userRepository.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            return this.userRepository.GetUserById(id);
        }

        public User SaveUser(User user)
        {
            return this.userRepository.SaveUser(user);
        }

        public User UpdateUser(User user)
        {
            return this.userRepository.UpdateUser(user);
        }
    }
}
