using System;
using Microsoft.EntityFrameworkCore;
using EmpregosYoyotaAPI.Models;

namespace EmpregosYoyotaAPI.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobCategory>().HasKey(x => new {x.JobId, x.CategoryId});
        }
       
        public DbSet<Category> Categories { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}