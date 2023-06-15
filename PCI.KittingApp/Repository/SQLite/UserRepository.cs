using Camstar.Util;
using PCI.KittingApp.Config;
using PCI.KittingApp.Driver.SQLite;
using PCI.KittingApp.Entity.Users;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Repository.SQLite
{
    public class UserRepository
    {
        private ReadWriteOperation<User> _transactionDriver;
        public UserRepository(ReadWriteOperation<User> transactionDriver)
        {
            _transactionDriver = transactionDriver;
        }
        public bool DeleteUserById(string Id)
        {
            try
            {
                _transactionDriver.Write($"DELETE FROM Users WHERE Id = {Id}");
                return true;
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(ex.Source, ex);
                return false;
            }
        }

        public List<User> GetAllUser()
        {
            return _transactionDriver.ReadAll("SELECT * FROM Users");
        }

        public User GetUserByEmployeeId(string EmployeeId)
        {
            return _transactionDriver.Read($"SELECT * FROM Users WHERE EmployeeId = {EmployeeId}");
        }

        public bool InsertUser(User user)
        {
            try
            {
                _transactionDriver.Write(user, "INSERT INTO Users (EmployeeId, FullName, Email, Role, Password) VALUES (@EmployeeId, @FullName, @Email, @Role, @Password)");
                return true;
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(ex.Source, ex);
                return false;
            }

        }

        public bool UpdateUser(User user)
        {
            try
            {
                _transactionDriver.Write(user, "UPDATE Users SET EmployeeId = @EmployeeId, FullName = @FullName, Email = @Email, Role = @Role, Password = @Password WHERE Id = @Id");
                return true;
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(ex.Source, ex);
                return false;
            }
        }
    }
}
