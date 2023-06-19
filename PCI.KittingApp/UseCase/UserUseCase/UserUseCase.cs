using PCI.KittingApp.Components;
using PCI.KittingApp.Entity.Users;
using PCI.KittingApp.Repository.SQLite;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.UseCase
{
    public class UserUseCase
    {
        private UserRepository _userRepository;
        private Simple3Des _simple3Des = new Simple3Des(ConfigurationManager.AppSettings["ExCorePasswordKey"]);
        internal User currentUser { get; set; }
        public UserUseCase(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetUsers()
        {
            return _userRepository.GetAllUser();
        }

        public User Login(string EmployeeId, string Password)
        {
            User findUser = _userRepository.GetUserByEmployeeId(EmployeeId);
            if (findUser == null) return null;
            if (CheckUserPropertyFull(findUser)) return null;

            if (Password == DecryptedPassword(findUser.Password)) return findUser;
            else return null;
        }

        private bool CheckUserPropertyFull(User user)
        {
            return (user.Email == null || user.Email == "") || (user.FullName == null || user.FullName == "") || (user.Password == null || user.Password == "") || (RoleType.Translate(user.Role) == "unknown");
        }

        public bool SignUp(User userData)
        {
            var checkData = _userRepository.GetUserByEmployeeId(userData.EmployeeId);
            if (checkData != null)
            {
                ZIAlertBox.Error("Duplicate Data", $"Employee with ID {userData.EmployeeId} already exists!");
                return false;
            }

            userData.Password = EncryptedPassword(userData.Password);
            return _userRepository.InsertUser(userData);
        }

        public bool DeleteUser(User userData)
        {
            var checkData = _userRepository.GetUserByEmployeeId(userData.EmployeeId);
            if (checkData == null)
            {
                ZIAlertBox.Error("Not Found Data", $"Employee with ID {userData.EmployeeId} doesn't exists!");
                return false;
            }

            return _userRepository.DeleteUserById(checkData.Id);
        }


        public bool UpdateUser(User userData)
        {
            var checkData = _userRepository.GetUserByEmployeeId(userData.EmployeeId);
            if (checkData == null)
            {
                ZIAlertBox.Error("Not Found Data", $"Employee with ID {userData.EmployeeId} doesn't exists!");
                return false;
            }

            userData.Password = EncryptedPassword(userData.Password);
            return _userRepository.UpdateUser(userData);
        }

        private string EncryptedPassword(string Password)
        {
            return _simple3Des.EncryptData(Password);
        }

        private string DecryptedPassword(string EncryptedPassword)
        {
            return _simple3Des.DecryptData(EncryptedPassword);
        }
    }
}
