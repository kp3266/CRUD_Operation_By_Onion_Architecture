using DemoLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions con) : base(con)
        {


        }

        /// <summary>
        /// Represents the collection of users in the database.
        /// </summary>
        public DbSet<User> tblUser { get; set; }

    }
}
