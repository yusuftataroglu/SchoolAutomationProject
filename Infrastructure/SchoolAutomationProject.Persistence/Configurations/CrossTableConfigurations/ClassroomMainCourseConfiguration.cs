using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Persistence.Configurations.CrossTableConfigurations
{
    public class ClassroomMainCourseConfiguration : IEntityTypeConfiguration<ClassroomMainCourse>
    {
        public void Configure(EntityTypeBuilder<ClassroomMainCourse> builder)
        {
            builder.HasKey(x => new { x.ClassroomId, x.MainCourseId });
            builder.HasOne(x => x.Classroom).WithMany(x => x.ClassroomMainCourses).HasForeignKey(x => x.ClassroomId).IsRequired();
            builder.HasOne(x => x.MainCourse).WithMany(x => x.ClassroomMainCourses).HasForeignKey(x => x.MainCourseId).IsRequired();
        }
    }
}
