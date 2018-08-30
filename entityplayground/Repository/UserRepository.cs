using entityplayground.Context;
using entityplayground.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace entityplayground.Repository
{
    class UserRepository
    {
        private UserContext userContext;

        public UserRepository()
        {
            this.userContext = new UserContext();
        }

        public void addAdmin()
        {
            var user = new UserEntity();
            user.Name = "John";
            this.userContext.Users.Add(user);
            this.userContext.SaveChanges();
        }

        public List<UserEntity> GetUsers()
        {
            return this.userContext.Users.ToList();
        }

    }    
}
