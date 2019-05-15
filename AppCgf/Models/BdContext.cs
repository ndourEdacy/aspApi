using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppCgf.Models
{
    public class BdContext: DbContext
    {
        public DbSet<User> users { get; set; }
    }
}