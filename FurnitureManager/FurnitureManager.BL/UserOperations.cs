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
            if (user != null)
            {
               Security secure = new Security();
                if (secure.VerifyHash(password, user.Password))
               {
                    return user;
                }
            }
           return null;
        }

        public void AddUser(User user)
        {
            Security secure = new Security();
            user.Password = secure.HashSHA1(user.Password);

            DataAccess dal = new DataAccess();
            dal.AddUser(user);
        }
     
    }
        
}
