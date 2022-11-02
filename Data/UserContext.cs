using System;
using Microsoft.EntityFrameworkCore;
using UserApi.Models;

namespace UserApi.Data
{
    public class UserContext : DbContext
    {
        protected readonly IConfiguration configuration;

        public UserContext(IConfiguration configuration, DbContextOptions<UserContext> options)
            : base(options)
        {
            this.configuration = configuration;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("BackendAuthConnection"));
            base.OnConfiguring(optionsBuilder);

        }
    }
}

