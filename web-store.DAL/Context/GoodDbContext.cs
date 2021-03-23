using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using web_store.DAL.Model;

namespace web_store.DAL.Context
{
    public class GoodDbContext : DbContext
    {
        public DbSet<Good> Goods { get; set; }

        public GoodDbContext(DbContextOptions<GoodDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
