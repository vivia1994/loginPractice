using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoginEmpty.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}