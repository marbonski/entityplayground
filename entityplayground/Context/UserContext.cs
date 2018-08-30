using entityplayground.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityplayground.Context
{
    class UserContext : DbContext
    {
        public UserContext()
        {

        }

        public DbSet<UserEntity> Users { get; set; }
    }
}
