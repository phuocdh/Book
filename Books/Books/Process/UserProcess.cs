using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Process
{
    public static class UserProcess
    {

        public static bool Login(string user, string pass)
        {
            using (var bookEntities = new BookEntities())
            {
                var student = (from u in bookEntities.Users
                               where u.Id == user && u.Password == pass
                               select u).FirstOrDefault<User>();

                if (student == null || String.IsNullOrEmpty(student.Id))
                {
                    return false;
                }
                Properties.Settings.Default.Role = (int)student.Role1.RoleType;
                Properties.Settings.Default.Save();
                return true;
            }  
        }
    }
}
