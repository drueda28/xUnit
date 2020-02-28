using System;
using System.Collections.Generic;
using System.Text;
using XUnitEntities;
using XUnitRepository.Interfaces;

namespace XUnitRepository.Repositories
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAllUsers()
        {
            ////TODO: Implement logic to get all users from database

            List<User> users = new List<User>()
            {
                new User()
                {
                    Name = "Danna", LastName = "R", DateOfBirth = new DateTime(1995,01,01)
                },
                new User()
                {
                    Name = "Alberto", LastName = "J", DateOfBirth = new DateTime(1996,03,01)
                },
                new User()
                {
                    Name = "Joe", LastName = "Thomas", DateOfBirth = new DateTime(2000,07,01)
                },
            };

            return users;
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public User SaveUser(User user)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
