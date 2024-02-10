﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolAutomationProject.Application.Repositories.AchievementRepositories;
using SchoolAutomationProject.Application.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Application.Repositories.ClassroomRepositories;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.DiscontinuedStudentRepositories;
using SchoolAutomationProject.Application.Repositories.GradeRepositories;
using SchoolAutomationProject.Application.Repositories.MainCourseRepositories;
using SchoolAutomationProject.Application.Repositories.ParentRepositories;
using SchoolAutomationProject.Application.Repositories.SemesterRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.Repositories.SubCourseRepositories;
using SchoolAutomationProject.Application.Repositories.TeacherRepositories;
using SchoolAutomationProject.Application.Repositories.TeacherScheduleRepositories;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Helpers;
using SchoolAutomationProject.Persistence.Repositories.AchievementRepositories;
using SchoolAutomationProject.Persistence.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Persistence.Repositories.ClassroomRepositories;
using SchoolAutomationProject.Persistence.Repositories.DiscontinuedStudentRepositories;
using SchoolAutomationProject.Persistence.Repositories.GradeRepositories;
using SchoolAutomationProject.Persistence.Repositories.MainCourseRepositories;
using SchoolAutomationProject.Persistence.Repositories.ParentRepositories;
using SchoolAutomationProject.Persistence.Repositories.SemesterRepositories;
using SchoolAutomationProject.Persistence.Repositories.StudentRepositories;
using SchoolAutomationProject.Persistence.Repositories.SubCourseRepositories;
using SchoolAutomationProject.Persistence.Repositories.TeacherRepositories;
using SchoolAutomationProject.Persistence.Repositories.TeacherScheduleRepositories;

namespace SchoolAutomationProject.Persistence.IoCContainer
{
    public static class ServiceRegistration
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddDbContext<SchoolAutomationProjectDbContext>(x => x.UseSqlServer(ConnectionStringHelper.GetConnectionString()));
            
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
        }
    }
}
