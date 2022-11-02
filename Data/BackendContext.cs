using System;

using Microsoft.EntityFrameworkCore;
using UserApi.Models;

namespace UserApi.Data
{
    public class BackendContext : DbContext
    {
        protected readonly IConfiguration configuration;

        public BackendContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("BackendAuthConnection"));
        }

        public DbSet<User> Users { get; set; }

    }
}

