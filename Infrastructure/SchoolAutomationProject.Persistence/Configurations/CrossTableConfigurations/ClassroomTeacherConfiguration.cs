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
    public class ClassroomTeacherConfiguration : IEntityTypeConfiguration<ClassroomTeacher>
    {
        public void Configure(EntityTypeBuilder<ClassroomTeacher> builder)
        {
            builder.HasKey(x => new { x.ClassroomId, x.TeacherId });
            builder.HasOne(x => x.Classroom).WithMany(x => x.ClassroomTeachers).HasForeignKey(x => x.ClassroomId).IsRequired();
            builder.HasOne(x => x.Teacher).WithMany(x => x.ClassroomTeachers).HasForeignKey(x => x.TeacherId).IsRequired();
        }
    }
}
