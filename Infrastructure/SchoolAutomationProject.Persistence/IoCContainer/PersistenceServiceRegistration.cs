﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.AchievementRepositories;
using SchoolAutomationProject.Application.Repositories.AdministratorRepositories;
using SchoolAutomationProject.Application.Repositories.AnnouncementRepositories;
using SchoolAutomationProject.Application.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Application.Repositories.ClassroomRepositories;
using SchoolAutomationProject.Application.Repositories.DiscontinuedStudentRepositories;
using SchoolAutomationProject.Application.Repositories.GradeRepositories;
using SchoolAutomationProject.Application.Repositories.HomeworkRepositories;
using SchoolAutomationProject.Application.Repositories.MainCourseRepositories;
using SchoolAutomationProject.Application.Repositories.MessageRepositories;
using SchoolAutomationProject.Application.Repositories.ParentRepositories;
using SchoolAutomationProject.Application.Repositories.SemesterRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.Repositories.SubCourseRepositories;
using SchoolAutomationProject.Application.Repositories.TeacherRepositories;
using SchoolAutomationProject.Application.Repositories.TeacherScheduleRepositories;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers;
using SchoolAutomationProject.Persistence.Repositories.AchievementRepositories;
using SchoolAutomationProject.Persistence.Repositories.AdministratorRepositories;
using SchoolAutomationProject.Persistence.Repositories.AnnouncementRepositories;
using SchoolAutomationProject.Persistence.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Persistence.Repositories.ClassroomRepositories;
using SchoolAutomationProject.Persistence.Repositories.DiscontinuedStudentRepositories;
using SchoolAutomationProject.Persistence.Repositories.GradeRepositories;
using SchoolAutomationProject.Persistence.Repositories.HomeworkRepositories;
using SchoolAutomationProject.Persistence.Repositories.MainCourseRepositories;
using SchoolAutomationProject.Persistence.Repositories.MessageRepositories;
using SchoolAutomationProject.Persistence.Repositories.ParentRepositories;
using SchoolAutomationProject.Persistence.Repositories.SemesterRepositories;
using SchoolAutomationProject.Persistence.Repositories.StudentRepositories;
using SchoolAutomationProject.Persistence.Repositories.SubCourseRepositories;
using SchoolAutomationProject.Persistence.Repositories.TeacherRepositories;
using SchoolAutomationProject.Persistence.Repositories.TeacherScheduleRepositories;

namespace SchoolAutomationProject.Persistence.IoCContainer
{
    public static class PersistenceServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Burada katmandan gelen configuration üzerinden appsetting.json dosyasına ulaşıyoruz.
            services.AddDbContext<SchoolAutomationProjectDbContext>(x => x.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            //Identity
            services.AddIdentity<AppUser, AppUserRole>(options =>
            {
                options.Password.RequireDigit = false; // Sayı gerekli değil
                options.Password.RequiredLength = 4; // Minimum 4 karakter
                options.Password.RequireLowercase = false; // Küçük harf gerekli değil
                options.Password.RequireUppercase = false; // Büyük harf gerekli değil
                options.Password.RequireNonAlphanumeric = false; // Alfanümerik olmayan karakter gerekli değil
            }).AddEntityFrameworkStores<SchoolAutomationProjectDbContext>().AddDefaultTokenProviders();

            //Cookie
            services.ConfigureApplicationCookie(x =>
            {
                x.Cookie = new CookieBuilder
                {
                    Name = "SchoolAutomationCookie"
                };
                x.LoginPath = new PathString("/Home/Login");
                x.AccessDeniedPath = new PathString("/Home/DeniedPage");
                x.SlidingExpiration = true;
                x.ExpireTimeSpan = TimeSpan.FromMinutes(120);
            });

            services.AddHttpContextAccessor();

            services.AddScoped<IAchievementReadRepository, AchievementReadRepository>();
            services.AddScoped<IAchievementWriteRepository, AchievementWriteRepository>();
            services.AddScoped<IAttendanceReadRepository, AttendanceReadRepository>();
            services.AddScoped<IAttendanceWriteRepository, AttendanceWriteRepository>();
            services.AddScoped<IClassroomReadRepository, ClassroomReadRepository>();
            services.AddScoped<IClassroomWriteRepository, ClassroomWriteRepository>();
            services.AddScoped<IDiscontinuedStudentReadRepository, DiscontinuedStudentReadRepository>();
            services.AddScoped<IDiscontinuedStudentWriteRepository, DiscontinuedStudentWriteRepository>();
            services.AddScoped<IGradeReadRepository, GradeReadRepository>();
            services.AddScoped<IGradeWriteRepository, GradeWriteRepository>();
            services.AddScoped<IMainCourseReadRepository, MainCourseReadRepository>();
            services.AddScoped<IMainCourseWriteRepository, MainCourseWriteRepository>();
            services.AddScoped<IParentReadRepository, ParentReadRepository>();
            services.AddScoped<IParentWriteRepository, ParentWriteRepository>();
            services.AddScoped<ISemesterReadRepository, SemesterReadRepository>();
            services.AddScoped<ISemesterWriteRepository, SemesterWriteRepository>();
            services.AddScoped<IStudentReadRepository, StudentReadRepository>();
            services.AddScoped<IStudentWriteRepository, StudentWriteRepository>();
            services.AddScoped<ISubCourseReadRepository, SubCourseReadRepository>();
            services.AddScoped<ISubCourseWriteRepository, SubCourseWriteRepository>();
            services.AddScoped<ITeacherReadRepository, TeacherReadRepository>();
            services.AddScoped<ITeacherWriteRepository, TeacherWriteRepository>();
            services.AddScoped<ITeacherScheduleReadRepository, TeacherScheduleReadRepository>();
            services.AddScoped<ITeacherScheduleWriteRepository, TeacherScheduleWriteRepository>();
            services.AddScoped<IAdministratorReadRepository, AdministratorReadRepository>();
            services.AddScoped<IAdministratorWriteRepository, AdministratorWriteRepository>();
            services.AddScoped<IAnnouncementReadRepository, AnnouncementReadRepository>();
            services.AddScoped<IAnnouncementWriteRepository, AnnouncementWriteRepository>();
            services.AddScoped<IMessageReadRepository, MessageReadRepository>();
            services.AddScoped<IMessageWriteRepository, MessageWriteRepository>();
            services.AddScoped<IHomeworkReadRepository, HomeworkReadRepository>();
            services.AddScoped<IHomeworkWriteRepository, HomeworkWriteRepository>();

            services.AddScoped<IFillEntityRelationshipsService, FillEntityRelationshipsService>();
            services.AddScoped<IAchievementFillRelationshipsService, AchievementFillRelationshipsService>();
            services.AddScoped<IAttendanceFillRelationshipsService, AttendanceFillRelationshipsService>();
            services.AddScoped<IClassroomFillRelationshipsService, ClassroomFillRelationshipsService>();
            services.AddScoped<IDiscontinuedStudentFillRelationshipsService, DiscontinuedStudentFillRelationshipsService>();
            services.AddScoped<IGradeFillRelationshipsService, GradeFillRelationshipsService>();
            services.AddScoped<IMainCourseFillRelationshipsService, MainCourseFillRelationshipsService>();
            services.AddScoped<IParentFillRelationshipsService, ParentFillRelationshipsService>();
            services.AddScoped<ISemesterFillRelationshipsService, SemesterFillRelationshipsService>();
            services.AddScoped<IStudentFillRelationshipsService, StudentFillRelationshipsService>();
            services.AddScoped<ISubCourseFillRelationshipsService, SubCourseFillRelationshipsService>();
            services.AddScoped<ITeacherFillRelationshipsService, TeacherFillRelationshipsService>();
            services.AddScoped<ITeacherScheduleFillRelationshipsService, TeacherScheduleFillRelationshipsService>();
            services.AddScoped<IAdministratorFillRelationshipsService, AdministratorFillRelationshipsService>();
            services.AddScoped<IAnnouncementFillRelationshipsService, AnnouncementFillRelationshipsService>();
            services.AddScoped<IMessageFillRelationshipsService, MessageFillRelationshipsService>();
            services.AddScoped<IHomeworkFillRelationshipsService, HomeworkFillRelationshipsService>();

        }
    }
}
