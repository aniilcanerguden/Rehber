using Microsoft.EntityFrameworkCore;
using Rehber.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rehber.API.Data
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server = DESKTOP-57873AE;Integrated Security=True;Connect Timeout=30;Initial Catalog=AgarthaRehberTask;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Rehberr> Rehberrs { get; set; }
    }
}
    