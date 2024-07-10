using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TestovaciUloha.Model;

namespace TestovaciUloha
{
    public class Context : DbContext
    {
        public DbSet<Product> Product {  get; set; }
        public DbSet<Part> Part {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=TestDatabase;user=root;password=123456Ab;SslMode=none");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.createdAt)
                .HasDefaultValueSql("NOW()"); // Nastavíme výchozí hodnotu pro CreatedAt na aktuální čas
        }
    }
}
