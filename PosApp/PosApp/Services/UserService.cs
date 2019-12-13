using PosApp.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PosApp.Services
{
    public class UserService
    {
        public List<UserModel> users;
        public UserService()
        {

            users = new List<UserModel>()
            {
                new UserModel
                {
                    id = 1,
                    username = "admin",
                    password = "admin",
                    role = "admin"
                },
                new UserModel
                {
                    id = 2,
                    username = "customer",
                    password = "customer",
                    role = "customer"
                },
            };
        }

        public string getUser(string un, string pw)
        {
            if (!String.IsNullOrEmpty(un) && !String.IsNullOrEmpty(pw))
            {
                string role = users.Find(m => m.username == un && m.password == pw).role;
                if (String.IsNullOrEmpty(role))
                {
                    role = string.Empty;
                }
                return role;
            }
            return string.Empty;
        }
    }

}
