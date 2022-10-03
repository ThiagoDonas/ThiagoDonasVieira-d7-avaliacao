using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ThiagoDonasVieira_d7_avaliacao.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(GetUsers());
            base.OnModelCreating(modelBuilder);
        }

        private static User[] GetUsers()
        {
            return new User[]
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Thiago",
                    UserLogin = "Aluno@gmail.com",
                    Password = "123"

                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Saulo",
                    UserLogin = "admin@gmail.com",
                    Password = "admin123"
                }
            };
        }

    }
}
