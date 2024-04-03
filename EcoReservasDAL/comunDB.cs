using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoReservasEN;
namespace EcoReservasDAL
{
        public class comunDB : DbContext
        {
            public DbSet<Roles> Roles { get; set; }

            public DbSet<Users> Users { get; set; }
            public DbSet<Lugares> Lugares { get; set; }
            public DbSet<Reservas> Reservas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=emmabook\\SQLEXPRESS;Initial Catalog=ERDB;Integrated Security=True;Trust Server Certificate=True");
            }
        }
}
