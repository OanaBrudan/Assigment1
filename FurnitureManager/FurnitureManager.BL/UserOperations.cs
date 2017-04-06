using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManager.DAL;
using FurnitureManager.Models;
using System.Configuration;

namespace FurnitureManager.BL
{
    public class UserOperations
    {
        public User Login(string username, string password)
        {
            DataAccess dal = new DataAccess();
            User user = dal.GetUser(username, password);
           return user;
        }

        public void AddUsers(User user)
        {
            DataAccess dal = new DataAccess();
            dal.AddUser(user);
        }
     
    }
        
}
