using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.Enums;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations
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
            builder.Property(x => x.RegistrationNumber).HasMaxLength(9).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.GraduatedSchool).HasMaxLength(255).IsRequired();
            builder.Property(x => x.GPA).IsRequired();
            builder.Property(x => x.IsPreRegistered).IsRequired();
            //builder.HasOne(x=> x.Classroom).WithMany(x=> x.Students).HasForeignKey(x=> x.ClassroomId).OnDelete(DeleteBehavior.SetNull);

            //SeedData eklenmesi
            builder.HasData(GetSampleStudents());
        }

        public List<Student> GetSampleStudents()
        {
            List<Student> students = new List<Student>
    {
        new Student
        {
            Id = Guid.Parse("42c58e42-bbbf-4304-a553-11ba20522f20"),
            RegistrationNumber = "100-24",
            FirstName = "Fatma",
            LastName = "Yıldırım",
            Gender = Gender.Kız,
            GraduatedSchool = "Cumhuriyet İlkokulu",
            GPA = 88.2,
            IsPreRegistered = false,
            ClassroomId =Guid.Parse("666917cb-ccff-46e2-81be-1dc06b74ddcb"),
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer1",
            CreatedIpAddress = "192.168.1.1"
        },
        new Student
        {
            Id = Guid.Parse("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"),
            RegistrationNumber = "101-24",
            FirstName = "Mustafa",
            LastName = "Şahin",
            Gender = Gender.Erkek,
            GraduatedSchool = "Şehit Hasan Ortaokulu",
            GPA = 95.0,
            IsPreRegistered = true,
            ClassroomId =Guid.Parse("666917cb-ccff-46e2-81be-1dc06b74ddcb"),
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer2",
            CreatedIpAddress = "192.168.1.2"
        },
        new Student
        {
            Id = Guid.Parse("c1a02c1a-7f16-4262-a795-3d866a399a36"),
            RegistrationNumber = "102-24",
            FirstName = "Zeynep",
            LastName = "Güler",
            Gender = Gender.Kız,
            GraduatedSchool = "Atatürk İlkokulu",
            GPA = 82.7,
            IsPreRegistered = false,
            ClassroomId =Guid.Parse("666917cb-ccff-46e2-81be-1dc06b74ddcb"),
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer3",
            CreatedIpAddress = "192.168.1.3"
        },
        new Student
        {
            Id = Guid.Parse("84e959f6-d8b7-45e7-972b-f943292667e6"),
            RegistrationNumber = "103-24",
            FirstName = "Ayşe",
            LastName = "Kaya",
            Gender = Gender.Kız,
            GraduatedSchool = "Mehmet Akif İlkokulu",
            GPA = 91.5,
            IsPreRegistered = true,
            ClassroomId =Guid.Parse("666917cb-ccff-46e2-81be-1dc06b74ddcb"),
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer4",
            CreatedIpAddress = "192.168.1.4"
        },
        new Student
        {
            Id = Guid.Parse("96e2572b-819d-4094-83f9-e9e06fd9fca1"),
            RegistrationNumber = "104-24",
            FirstName = "Ahmet",
            LastName = "Arslan",
            Gender = Gender.Erkek,
            GraduatedSchool = "Ali Rıza Ortaokulu",
            GPA = 79.8,
            IsPreRegistered = false,
            ClassroomId =Guid.Parse("22d118a6-a81b-435f-a4c7-ffed69e37f12"),
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer5",
            CreatedIpAddress = "192.168.1.5"
        },
        new Student
        {
            Id = Guid.Parse("15b6a548-4045-4892-904a-aeeba517960d"),
            RegistrationNumber = "105-24",
            FirstName = "Emine",
            LastName = "Yılmaz",
            Gender = Gender.Kız,
            GraduatedSchool = "Hacı Ahmet İlkokulu",
            GPA = 87.3,
            IsPreRegistered = true,
            ClassroomId =Guid.Parse("22d118a6-a81b-435f-a4c7-ffed69e37f12"),
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer6",
            CreatedIpAddress = "192.168.1.6"
        },
        new Student
        {
            Id = Guid.Parse("4b90e195-c72c-400a-a19c-0828ce7d12e1"),
            RegistrationNumber = "106-24",
            FirstName = "Mehmet",
            LastName = "Kurt",
            Gender = Gender.Erkek,
            GraduatedSchool = "Mustafa Kemal Ortaokulu",
            GPA = 83.6,
            IsPreRegistered = false,
            ClassroomId =Guid.Parse("22d118a6-a81b-435f-a4c7-ffed69e37f12"),
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer7",
            CreatedIpAddress = "192.168.1.7"
        },
        new Student
        {
            Id = Guid.Parse("798f421b-3bb6-4d77-bfa4-292a0f11b46a"),
            RegistrationNumber = "107-24",
            FirstName = "Fatih",
            LastName = "Sarı",
            Gender = Gender.Erkek,
            GraduatedSchool = "Cumhuriyet İlkokulu",
            GPA = 94.2,
            IsPreRegistered = true,
            ClassroomId =Guid.Parse("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"),
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer8",
            CreatedIpAddress = "192.168.1.8"
        },
        new Student
        {
            Id = Guid.Parse("d9d28310-a5a6-4c31-87f2-7849f926d9fa"),
            RegistrationNumber = "108-24",
            FirstName = "Elif",
            LastName = "Demir",
            Gender = Gender.Kız,
            GraduatedSchool = "Fatih Sultan Mehmet Ortaokulu",
            GPA = 78.9,
            IsPreRegistered = false,
            ClassroomId =Guid.Parse("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"),
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer9",
            CreatedIpAddress = "192.168.1.9"
        },
        new Student
        {
            Id = Guid.Parse("7e5ae383-0067-4af0-94f3-43d725bef5d1"),
            RegistrationNumber = "109-24",
            FirstName = "Ali",
            LastName = "Özdemir",
            Gender = Gender.Erkek,
            GraduatedSchool = "İsmet İnönü İlkokulu",
            GPA = 88.7,
            IsPreRegistered = true,
            ClassroomId =Guid.Parse("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"),
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer10",
            CreatedIpAddress = "192.168.1.10"
        },
        new Student
        {
            Id = Guid.Parse("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"),
            RegistrationNumber = "110-24",
            FirstName = "Sema",
            LastName = "Tekin",
            Gender = Gender.Kız,
            GraduatedSchool = "Necmettin Erbakan Ortaokulu",
            GPA = 85.4,
            IsPreRegistered = false,
            ClassroomId =Guid.Parse("7a3741e2-d501-4710-b0c9-a0a53142ad79"),
            ContinuationStatus = ContinuationStatus.Mezun,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer11",
            CreatedIpAddress = "192.168.1.11"
        },
        new Student
        {
            Id = Guid.Parse("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"),
            RegistrationNumber = "111-24",
            FirstName = "Can",
            LastName = "Aydın",
            Gender = Gender.Erkek,
            GraduatedSchool = "Abdullah Gül İlkokulu",
            GPA = 92.1,
            IsPreRegistered = true,
            ClassroomId =Guid.Parse("7a3741e2-d501-4710-b0c9-a0a53142ad79"),
            ContinuationStatus = ContinuationStatus.Sevk,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer12",
            CreatedIpAddress = "192.168.1.12"
        }
    };

            return students;
        }

    }
}
