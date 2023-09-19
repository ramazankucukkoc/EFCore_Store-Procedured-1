using EFCore_Store_Procedured_1.DTOs;
using EFCore_Store_Procedured_1.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Store_Procedured_1.DAL
{
    public class MSSQLDB:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=RAMAZANKUCUKKOC\\SQLEXPRESS;Database=EFCoreProd; Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(builder =>
            {

                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).UseIdentityColumn().HasColumnName("Id");
                builder.Property(x => x.Name).HasColumnName("Name").HasMaxLength(50);
                builder.Property(x => x.Description).HasColumnName("Description").HasMaxLength(50);
                builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId).HasConstraintName("CategoryId");
                builder.Property(x => x.UnitPrice).HasColumnName("UnitPrice");

                builder.ToTable("Products");
            });
            modelBuilder.Entity<Category>(builder =>
            {
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).UseIdentityColumn().HasColumnName("Id");
                builder.Property(x => x.Name).HasColumnName("Name").HasMaxLength(50);
                builder.Property(x => x.Description).HasColumnName("Description").HasMaxLength(50);
                builder.ToTable("Category");
            });

            modelBuilder.Entity<ProductListDto>().HasNoKey();
        }
        public DbSet<Product>  Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductListDto> ProductListDtos { get; set; }

    }
}
