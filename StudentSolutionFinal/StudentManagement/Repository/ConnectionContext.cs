using Microsoft.EntityFrameworkCore;
using BOL;
namespace DAL
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext() { }

        public DbSet<Student> students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = @"server=localhost;port=3306;user=root;password=root123;database=studentmanagement;";
            optionsBuilder.UseMySQL(con);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(s => s.Student_id);
                entity.Property(s => s.Student_Name);
                entity.Property(s => s.Email);
                entity.Property(s => s.Mobile_No);
                entity.Property(s => s.Address);
                entity.Property(s => s.Admission_date);
                entity.Property(s => s.Fees);
                entity.Property(s => s.Status);
            });
            modelBuilder.Entity<Student>().ToTable("students");
        }
    }
}
