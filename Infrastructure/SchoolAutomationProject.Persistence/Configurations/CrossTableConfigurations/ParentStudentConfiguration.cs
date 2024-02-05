using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Persistence.Configurations.CrossTableConfigurations
{
    public class ParentStudentConfiguration : IEntityTypeConfiguration<ParentStudent>
    {

        public void Configure(EntityTypeBuilder<ParentStudent> builder)
        {
            builder.HasKey(x => new { x.ParentId, x.StudentId });
            builder.HasOne(x => x.Parent).WithMany(x => x.ParentStudents).HasForeignKey(x => x.ParentId).IsRequired();
            builder.HasOne(x => x.Student).WithMany(x => x.ParentStudents).HasForeignKey(x => x.StudentId).IsRequired();
        }
    }
}
