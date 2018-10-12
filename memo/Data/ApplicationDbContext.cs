using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using memo.Models;

namespace memo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<memo.Models.Memo> Memo { get; set; }

        /*
protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Memo>().HasData(
                new Memo() { Title = "Seed Data 1", Details= "This is seed data 1", Date = DateTime.Now },
                new Memo() { Title = "Seed Data 2", Details = "This is seed data 2", Date = DateTime.Now.AddHours(1) },
                new Memo() { Title = "Seed Data 3", Details = "This is seed data 3", Date = DateTime.Now.AddMinutes(30) });
        }
        */

          
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Memo[] data = new Memo[10];

            Memo memo;
            for (int i = 0; i < 10; i++)
            {
                memo = new Memo
                {
                    memoId = i + 2000,
                    OwnerId = "2eeff8de-6716-4c8a-81ae-8140a02957ab",
                    Date = DateTime.Now.AddHours(i + 3),
                    Title = String.Format("Memo {0}", i),
                    Details = String.Format("Details {0}", i)
                };
                data[i] = memo;
            };
            modelBuilder.Entity<Memo>().HasData(data);
        }
        
    }
}
