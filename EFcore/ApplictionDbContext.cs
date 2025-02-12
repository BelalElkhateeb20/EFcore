using EFcore.Configrations;
using EFcore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore
{
    public class ApplictionDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder option) =>
             option.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=EFCore;Integrated Security=True");
        protected override void OnModelCreating(ModelBuilder modelBuilder)//This for build the table in Database
        {
            //modelBuilder.Entity<Post>(); //This is a DomainModel
            new BlogEntityTypeConfigration().Configure(modelBuilder.Entity<Blog>());
            modelBuilder.Ignore<Post>();
            //To Exclude DomainModel From Migration 
            modelBuilder.Entity<Blog>()
                .ToTable("Blogs",p => p.ExcludeFromMigrations());

            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogEntityTypeConfigration).Assembly);// this Performs the same work 
        }
        public DbSet<Blog> Blogs { get; set; } 
    }
}
