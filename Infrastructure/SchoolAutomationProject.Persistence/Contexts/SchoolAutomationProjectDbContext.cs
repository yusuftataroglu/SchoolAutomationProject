using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.Enums;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Configurations.CrossTableConfigurations;
using SchoolAutomationProject.Persistence.Configurations.UniqueTableConfigurations;
using SchoolAutomationProject.Persistence.Helpers;

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
        public DbSet<DiscontinuedStudent> DiscontinuedStudents { get; set; }
        public DbSet<TeacherSchedule> TeacherSchedules { get; set; }
        public DbSet<ClassroomMainCourse> ClassroomMainCourses { get; set; }
        public DbSet<ClassroomTeacher> ClassroomTeachers { get; set; }
        public DbSet<ParentStudent> ParentStudents { get; set; }

        public SchoolAutomationProjectDbContext()
        {

        }

        public SchoolAutomationProjectDbContext(DbContextOptions options) : base(options)
        {
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entityEntry = ChangeTracker.Entries<BaseClass>();
            foreach (var item in entityEntry)
            {
                switch (item.State)
                {
                    case EntityState.Detached:
                        break;
                    case EntityState.Unchanged:
                        break;
                    case EntityState.Deleted:
                        break;
                    case EntityState.Modified:
                        item.Entity.UpdatedDate = DateTime.UtcNow;
                        item.Entity.UpdatedComputerName = Environment.MachineName;
                        item.Entity.UpdatedIpAddress = await IpAddressHelper.GetIpAddress();
                        if (item.Entity is Student)
                        {
                            var student = item.Entity as Student;
                            var originalValue = item.OriginalValues["ContinuationStatus"].ToString();
                            var currentValue = item.CurrentValues["ContinuationStatus"].ToString();
                            if (originalValue != currentValue)
                            {
                                //todo denenecek.
                                if (currentValue == ContinuationStatus.Mezun.ToString() || currentValue == ContinuationStatus.Sevk.ToString())
                                {
                                    await DiscontinuedStudents.AddAsync(new DiscontinuedStudent { StudentId = student.Id, CreatedComputerName = "yusuf-pc", CreatedDate = DateTime.UtcNow, CreatedIpAddress = "123.1.3.1" }); //todo otomatik atanacak.
                                }
                            }

                        }
                        break;
                    case EntityState.Added:
                        item.Entity.CreatedDate = DateTime.UtcNow;
                        item.Entity.CreatedComputerName = Environment.MachineName;
                        item.Entity.CreatedIpAddress = await IpAddressHelper.GetIpAddress();

                        if (item.Entity is Student)
                        {
                            Student student = (Student)item.Entity;
                            var lastRegistrationNumber = Students.OrderByDescending(x => x.RegistrationNumber).FirstOrDefault()?.RegistrationNumber;
                            if (lastRegistrationNumber == null)
                            {
                                student.RegistrationNumber = $"100-{DateTime.Now.Year.ToString().Substring(2)}";
                            }
                            else
                            {
                                student.RegistrationNumber = $"{Convert.ToInt32(lastRegistrationNumber.Split("-")[0]) + 1}-{DateTime.Now.Year.ToString().Substring(2)}";
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionStringHelper.GetConnectionString());
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClassroomMainCourseConfiguration());
            modelBuilder.ApplyConfiguration(new ClassroomTeacherConfiguration());
            modelBuilder.ApplyConfiguration(new ParentStudentConfiguration());
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
            modelBuilder.ApplyConfiguration(new DiscontinuedStudentConfiguration());
        }
    }
}
