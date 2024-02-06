using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Configurations.CrossTableConfigurations;
using SchoolAutomationProject.Persistence.Configurations.UniqueTableConfigurations;
using System.Threading.Channels;

namespace SchoolAutomationProject.Persistence.Contexts
{
    public class SchoolAutomationProjectDbContext : DbContext //todo identity eklenebilir!
    {
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<MainCourse> MainCourses { get; set; }
        public DbSet<SubCourse> SubCourses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        public SchoolAutomationProjectDbContext()
        {

        }

        public SchoolAutomationProjectDbContext(DbContextOptions options) : base(options)
        {

        }
        //todo ChangeTracker eklenebilir!

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entityEntry = ChangeTracker.Entries();
            foreach (var item in entityEntry)
            {
                if (item.State == EntityState.Added)
                {
                    Console.WriteLine("Eklendi!!!!!!!");
                }
                else
                {
                    Console.WriteLine("Eklenemedi!!!!!");
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=YUSUF-PC\\SQLEXPRESS;database=SchoolTest;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClassroomMainCourseConfiguration());
            modelBuilder.ApplyConfiguration(new ClassroomTeacherConfiguration());
            modelBuilder.ApplyConfiguration(new ParentStudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentTeacherConfiguration());
            modelBuilder.ApplyConfiguration(new AchievementConfiguration());
            modelBuilder.ApplyConfiguration(new AttendanceConfiguration());
            modelBuilder.ApplyConfiguration(new ClassroomConfiguration());
            modelBuilder.ApplyConfiguration(new GradeConfiguration());
            modelBuilder.ApplyConfiguration(new MainCourseConfiguration());
            modelBuilder.ApplyConfiguration(new ParentConfiguration());
            modelBuilder.ApplyConfiguration(new SemesterConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new SubCourseConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
        }
    }
}
