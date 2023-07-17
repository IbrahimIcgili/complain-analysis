using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplainAnalysis.Models;
using Microsoft.EntityFrameworkCore;

namespace ComplainAnalysis
{
    public class Context : DbContext
    {
        public Context()
        {

        }
        public DbSet<Complain> Complains { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=yazlab_project2;Search Path=public;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Complain>(entity =>
            {
                entity.ToTable("complaints");

                entity.Property(e => e.Product)
                .HasColumnName("product");

                entity.Property(e => e.Company)
                .HasColumnName("company");


                entity.Property(e => e.Issue)
                .HasColumnName("issue");

                entity.Property(e => e.State)
                .HasColumnName("state");

                entity.Property(e => e.ZipCode)
                .HasColumnName("zip_code");

                entity.Property(e => e.ComplainId)
                .HasColumnName("complaint_id");
            });
        }
    }
}
