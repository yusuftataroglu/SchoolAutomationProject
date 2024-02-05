using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Persistence.Configurations.UniqueTableConfigurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri
            builder.Property(x=> x.RegistrationNumber).HasMaxLength(9).IsRequired();
            builder.Property(x=> x.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(x=> x.LastName).HasMaxLength(50).IsRequired();
            builder.Property(x=> x.Gender).IsRequired();
            builder.Property(x=> x.GraduatedSchool).HasMaxLength(255).IsRequired();
            builder.Property(x=> x.GPA).IsRequired();
            builder.Property(x=> x.IsPreRegistered).IsRequired();
        }
    }
}
