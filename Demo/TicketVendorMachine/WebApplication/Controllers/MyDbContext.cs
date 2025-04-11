using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Configuration;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("ConnectionString") { }

        public DbSet<User> tblUsers { get; set; }
    }
}
