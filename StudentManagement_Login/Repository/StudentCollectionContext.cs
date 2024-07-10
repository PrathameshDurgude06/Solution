using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;

namespace StudentManagement.Repository
{
    public class StudentCollectionContext:DbContext
    {

        public DbSet<Student> dbcontext {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"server=localhost;port=3306;user=root;password=root123;database=studentmgnt";
            optionsBuilder.UseMySQL(connection);    
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Student>(
               entity =>
               {
                   entity.HasKey(e => e.std_id);
                   entity.Property(e => e.std_name)
                   .IsRequired();
                   entity.Property(e => e.std_email).IsRequired();
                   entity.Property(e=>e.std_fees).IsRequired();
                   entity.Property(e=>e.std_status).IsRequired();
                   entity.Property(e=>e.std_Address).IsRequired();
                   entity.Property(e=>e.std_admissiondate).IsRequired();
                   entity.Property(e=>e.std_phone).IsRequired();

               }
               );

            modelBuilder.Entity<Student>().ToTable("student");
        }
    }
}
