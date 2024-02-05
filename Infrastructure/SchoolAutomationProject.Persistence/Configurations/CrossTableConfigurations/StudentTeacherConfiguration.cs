using Microsoft.EntityFrameworkCore;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Persistence.Configurations.CrossTableConfigurations
{
    public class StudentTeacherConfiguration : IEntityTypeConfiguration<StudentTeacher>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StudentTeacher> builder)
        {
            builder.HasKey(x => new { x.StudentId, x.TeacherId });
            builder.HasOne(x => x.Student).WithMany(x => x.StudentTeachers).HasForeignKey(x => x.StudentId).IsRequired();
            builder.HasOne(x => x.Teacher).WithMany(x => x.StudentTeachers).HasForeignKey(x => x.TeacherId).IsRequired();
        }
    }
}
