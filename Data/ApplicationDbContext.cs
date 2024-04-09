using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
 {   
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        //the dbset is used to create tables in the db
        public DbSet<Category> Categories{ get; set;}

        //the OnModelCreating is used to insert records to the table in the db

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Category>().HasData(
                new Category {Id= 1, Name = "IPHOME", DisplayOrder =1},
                new Category {Id =2, Name = "IPPHONE", DisplayOrder = 2 },
                new Category {Id= 3 , Name = "laptop" ,  DisplayOrder=3}

            );
        }
    }

 }
