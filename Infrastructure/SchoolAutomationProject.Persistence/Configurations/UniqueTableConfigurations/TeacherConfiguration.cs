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
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri
            builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Department).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Role).HasMaxLength(50);

            builder.HasData(GetSampleTeachers());
        }

        public List<Teacher> GetSampleTeachers()
        {
            List<Teacher> teachers = new List<Teacher>
    {
        new Teacher
        {
            Id = Guid.NewGuid(),
            FirstName = "Ahmet",
            LastName = "Yılmaz",
            Role = "Öğretmen",
            Department = "Matematik",
            MainCourseId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer1",
            CreatedIpAddress = "192.168.1.1"
        },
        new Teacher
        {
            Id = Guid.NewGuid(),
            FirstName = "Ayşe",
            LastName = "Demir",
            Role = "Öğretmen",
            Department = "Matematik",
            MainCourseId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer2",
            CreatedIpAddress = "192.168.1.2"
        },
        new Teacher
        {
            Id = Guid.NewGuid(),
            FirstName = "Mehmet",
            LastName = "Kaya",
            Role = "Öğretmen",
            Department = "Türkçe",
            MainCourseId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer3",
            CreatedIpAddress = "192.168.1.3"
        },
        new Teacher
        {
            Id = Guid.NewGuid(),
            FirstName = "Fatma",
            LastName = "Şahin",
            Role = "Öğretmen",
            Department = "Biyoloji",
            MainCourseId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer4",
            CreatedIpAddress = "192.168.1.4"
        },
        new Teacher
        {
            Id = Guid.NewGuid(),
            FirstName = "Ali",
            LastName = "Demirci",
            Role = "Öğretmen",
            Department = "Fizik",
            MainCourseId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer5",
            CreatedIpAddress = "192.168.1.5"
        },
        new Teacher
        {
            Id = Guid.NewGuid(),
            FirstName = "Zeynep",
            LastName = "Yıldız",
            Role = "Öğretmen",
            Department = "Kimya",
            MainCourseId = Guid.Parse("55555555-5555-5555-5555-555555555555"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer6",
            CreatedIpAddress = "192.168.1.6"
        },
        new Teacher
        {
            Id = Guid.NewGuid(),
            FirstName = "Mehmet",
            LastName = "Kaya",
            Role = "Öğretmen",
            Department = "Tarih",
            MainCourseId = Guid.Parse("66666666-6666-6666-6666-666666666666"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer10",
            CreatedIpAddress = "192.168.1.10"
        },
        new Teacher
        {
            Id = Guid.NewGuid(),
            FirstName = "Ayşe",
            LastName = "Yılmaz",
            Role = "Öğretmen",
            Department = "Coğrafya",
            MainCourseId = Guid.Parse("77777777-7777-7777-7777-777777777777"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer11",
            CreatedIpAddress = "192.168.1.11"
        },
        new Teacher
        {
            Id = Guid.NewGuid(),
            FirstName = "Ahmet",
            LastName = "Çelik",
            Role = "Öğretmen",
            Department = "İngilizce",
            MainCourseId = Guid.Parse("88888888-8888-8888-8888-888888888888"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer12",
            CreatedIpAddress = "192.168.1.12"
        },
        new Teacher
        {
            Id = Guid.NewGuid(),
            FirstName = "Seda",
            LastName = "Demir",
            Role = "Öğretmen",
            Department = "Müzik",
            MainCourseId = Guid.Parse("99999999-9999-9999-9999-999999999999"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer13",
            CreatedIpAddress = "192.168.1.13"
        },
        new Teacher
        {
            Id = Guid.NewGuid(),
            FirstName = "Burak",
            LastName = "Korkmaz",
            Role = "Öğretmen",
            Department = "Görsel Sanatlar",
            MainCourseId = Guid.Parse("AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer14",
            CreatedIpAddress = "192.168.1.14"
        }
    };

            return teachers;
        }
    }
}
