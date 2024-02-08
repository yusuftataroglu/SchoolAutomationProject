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
    public class MainCourseConfiguration : IEntityTypeConfiguration<MainCourse>
    {
        public void Configure(EntityTypeBuilder<MainCourse> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.HasData(GetSampleMainCourses());
        }

        public List<MainCourse> GetSampleMainCourses()
        {
            List<MainCourse> mainCourses = new List<MainCourse>
    {
        new MainCourse
        {
            Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
            Name = "Matematik",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer1",
            CreatedIpAddress = "192.168.1.1"
        },
        new MainCourse
        {
            Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
            Name = "Türkçe",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer2",
            CreatedIpAddress = "192.168.1.2"
        },
        new MainCourse
        {
            Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
            Name = "Biyoloji",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer3",
            CreatedIpAddress = "192.168.1.3"
        },
        new MainCourse
        {
            Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
            Name = "Fizik",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer4",
            CreatedIpAddress = "192.168.1.4"
        },
        new MainCourse
        {
            Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
            Name = "Kimya",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer5",
            CreatedIpAddress = "192.168.1.5"
        },
        new MainCourse
        {
            Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
            Name = "Tarih",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer6",
            CreatedIpAddress = "192.168.1.6"
        },
        new MainCourse
        {
            Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
            Name = "Coğrafya",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer7",
            CreatedIpAddress = "192.168.1.7"
        },
        new MainCourse
        {
            Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
            Name = "İngilizce",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer8",
            CreatedIpAddress = "192.168.1.8"
        },
        new MainCourse
        {
            Id = Guid.Parse("99999999-9999-9999-9999-999999999999"),
            Name = "Müzik",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer9",
            CreatedIpAddress = "192.168.1.9"
        },
        new MainCourse
        {
            Id = Guid.Parse("AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA"),
            Name = "Görsel Sanatlar",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer10",
            CreatedIpAddress = "192.168.1.10"
        }
    };

            return mainCourses;
        }


    }
}
