using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoExistingDbMVC.Models
{
    public partial class ActorDbContext : DbContext
    {
        public ActorDbContext()
        {
        }

        public ActorDbContext(DbContextOptions<ActorDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actors> Actors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");
        }
    }
}
