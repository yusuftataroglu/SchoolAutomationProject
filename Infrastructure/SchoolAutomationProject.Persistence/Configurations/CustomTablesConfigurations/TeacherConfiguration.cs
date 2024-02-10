using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations
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
            Id = Guid.Parse("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"),
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
            Id = Guid.Parse("4eca2d83-365e-4926-b42c-2415618b5e19"),
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
            Id = Guid.Parse("a82047bd-f57e-4c34-928c-8b8d2c3fa636"),
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
            Id = Guid.Parse("a444db40-a494-4e3d-91d1-eea2779bf147"),
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
            Id = Guid.Parse("2e032c26-8554-4ab9-8e06-77cfd8f9652d"),
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
            Id = Guid.Parse("fa70cb23-9c69-4548-8f15-77e93139ab41"),
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
            Id = Guid.Parse("35cced10-9fc1-4413-9e09-080b408b23c3"),
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
            Id = Guid.Parse("3ca93105-bfff-4791-9cc4-82a7a97ad756"),
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
            Id = Guid.Parse("f12dbbce-5d81-4f38-8eab-b267b2263556"),
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
            Id = Guid.Parse("dd82ca7c-38ca-4a8c-989b-a47d44d9b132"),
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
            Id = Guid.Parse("f6563118-b1bf-4d43-ab6d-c427a9f13f7c"),
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
