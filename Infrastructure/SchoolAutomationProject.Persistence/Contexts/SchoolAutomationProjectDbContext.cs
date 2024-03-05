using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using SchoolAutomationProject.Persistence.Configurations.CrossTablesConfigurations;
using SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations;
using SchoolAutomationProject.Persistence.Configurations.IdentityTablesConfigurations;
using SchoolAutomationProject.Persistence.Helpers.ConnectionStringHelpers;
using SchoolAutomationProject.Persistence.Helpers.IpAddressHelpers;

namespace SchoolAutomationProject.Persistence.Contexts
{
    public class SchoolAutomationProjectDbContext : IdentityDbContext<AppUser, AppUserRole, string>
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
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<TeacherSchedule> TeacherSchedules { get; set; }
        public DbSet<ClassroomMainCourse> ClassroomMainCourses { get; set; }
        public DbSet<ClassroomTeacher> ClassroomTeachers { get; set; }
        public DbSet<AnnouncementRole> AnnouncementRoles { get; set; }


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
                        item.Entity.UpdatedUser = new HttpContextAccessor().HttpContext.User.Identity.Name; //todo değiştirilebilir.

                        if (item.Entity is Student)
                        {
                            var student = item.Entity as Student;
                            var originalValue = item.OriginalValues["ContinuationStatus"]?.ToString();
                            var currentValue = item.CurrentValues["ContinuationStatus"]?.ToString();
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
                        item.Entity.CreatedUser = new HttpContextAccessor().HttpContext.User.Identity.Name;

                        if (item.Entity is Student)
                        {

                            Student student = (Student)item.Entity;
                            student.IsPreRegistered = true;
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
                //appsettings.json dosyası bu katmanda olmadığı için Custom bir GetConnectionString metodu üzerinde ulaşıyoruz.
                optionsBuilder.UseSqlServer(ConnectionStringHelper.GetConnectionString());
            }

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
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
            modelBuilder.ApplyConfiguration(new TeacherScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new DiscontinuedStudentConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new MessageConfiguration());
            modelBuilder.ApplyConfiguration(new AnnouncementConfiguration());
            modelBuilder.ApplyConfiguration(new AdministratorConfiguration());
            modelBuilder.ApplyConfiguration(new HomeworkConfiguration());
            modelBuilder.ApplyConfiguration(new ClassroomMainCourseConfiguration());
            modelBuilder.ApplyConfiguration(new ClassroomTeacherConfiguration());
            modelBuilder.ApplyConfiguration(new AnnouncementRoleConfiguration());
        }


    }
}
