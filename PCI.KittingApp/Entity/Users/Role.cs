using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Entity.Users
{
    public enum Role
    {
        Admin = 0,
        User = 1,
    }

    public static class RoleType
    {
        public static string Translate(Role? roleType)
        {
            switch (roleType)
            {
                case Role.Admin:
                    return "Admin";
                case Role.User:
                    return "User";
                default:
                    return "Unknown";
            }
        }
    }
}
