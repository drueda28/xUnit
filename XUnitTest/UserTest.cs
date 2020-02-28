using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using XUnitEntities;
using XUnitRepository.Interfaces;
using XUnitServices.Interfaces;
using XUnitServices.Services;
using FluentAssertions;
using FluentAssertions.Collections;

namespace XUnitTest
{
    public class UserTest
    {
        [Fact]
        public void Return_Amount_User_Test()
        {
            //arrange
            List<User> userList = new List<User>()
            {
                new User()
                {
                    Name = "Alberto",
                    DateOfBirth = new DateTime(1995,02,01),
                    LastName = "Posada"
                },
                new User()
                {
                    Name = "Jaime",
                    DateOfBirth = new DateTime(1980,03,20),
                    LastName = "Guerra"
                }
            };

            //IMPORTANT: ALWAYS mock the repository
            var userRepository = new Mock<IUserRepository>();
            userRepository.Setup(x => x.GetAllUsers()).Returns(userList);

            //Passing Mock of Repository
            IUserService userService = new UserService(userRepository.Object);

            //Act
            List<User> result = userService.GetAllUsers();

            var validateUser = userList.Where(d => d.Name == "Alberto").FirstOrDefault();

            //Assert
            Assert.True(userList.Any());
            Assert.True(validateUser.LastName == "Posada");
            Assert.True(validateUser.DateOfBirth == new DateTime(1995,02,01));

            //Fluent Assertions
            userList.Should().NotBeEmpty();
            validateUser.LastName.Should().Be("Posada");
            validateUser.DateOfBirth.Should().BeSameDateAs(new DateTime(1995, 02, 01));
        }
    }
}
