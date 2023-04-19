using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestKalan.Models;

namespace ConsoleApp1
{
    public class AppDbContext:DbContext
    {
        private const string connectionString = "Server=. ;Database=Test ;Integrated Security=SSPI; ;MultipleActiveResultSets=True; TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);

        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Women> Womens { get; set; }

    }
}
