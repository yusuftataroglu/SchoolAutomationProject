using Microsoft.EntityFrameworkCore;
using SchoolAutomationProject.Domain.Entities;

namespace SchoolAutomationProject.Persistence.Contexts
{
    public class SchoolAutomationProjectDbContext : DbContext //todo identity eklenebilir!
    {
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<MainCourse> MainCourses { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Semester> Seasons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SubCourse> SubCourses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public SchoolAutomationProjectDbContext()
        {

        }

        public SchoolAutomationProjectDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=YUSUF-PC\\SQLEXPRESS;database=SchoolTest;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
