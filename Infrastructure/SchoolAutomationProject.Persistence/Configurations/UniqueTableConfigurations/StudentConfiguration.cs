using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.Enums;
using SchoolAutomationProject.Domain.Entities.UniqueTables;

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
            builder.Property(x => x.RegistrationNumber).HasMaxLength(9).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.GraduatedSchool).HasMaxLength(255).IsRequired();
            builder.Property(x => x.GPA).IsRequired();
            builder.Property(x => x.IsPreRegistered).IsRequired();

            //SeedData eklenmesi
            builder.HasData(GetSampleStudents());
        }

        public List<Student> GetSampleStudents()
        {
            List<Student> students = new List<Student>
    {
        new Student
        {
            Id = Guid.NewGuid(),
            RegistrationNumber = "100-24",
            FirstName = "Fatma",
            LastName = "Yıldırım",
            Gender = Gender.Kız,
            GraduatedSchool = "Cumhuriyet İlkokulu",
            GPA = 88.2,
            IsPreRegistered = false,
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer1",
            CreatedIpAddress = "192.168.1.1"
        },
        new Student
        {
            Id = Guid.NewGuid(),
            RegistrationNumber = "101-24",
            FirstName = "Mustafa",
            LastName = "Şahin",
            Gender = Gender.Erkek,
            GraduatedSchool = "Şehit Hasan Ortaokulu",
            GPA = 95.0,
            IsPreRegistered = true,
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer2",
            CreatedIpAddress = "192.168.1.2"
        },
        new Student
        {
            Id = Guid.NewGuid(),
            RegistrationNumber = "102-24",
            FirstName = "Zeynep",
            LastName = "Güler",
            Gender = Gender.Kız,
            GraduatedSchool = "Atatürk İlkokulu",
            GPA = 82.7,
            IsPreRegistered = false,
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer3",
            CreatedIpAddress = "192.168.1.3"
        },
        new Student
        {
            Id = Guid.NewGuid(),
            RegistrationNumber = "103-24",
            FirstName = "Ayşe",
            LastName = "Kaya",
            Gender = Gender.Kız,
            GraduatedSchool = "Mehmet Akif İlkokulu",
            GPA = 91.5,
            IsPreRegistered = true,
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer4",
            CreatedIpAddress = "192.168.1.4"
        },
        new Student
        {
            Id = Guid.NewGuid(),
            RegistrationNumber = "104-24",
            FirstName = "Ahmet",
            LastName = "Arslan",
            Gender = Gender.Erkek,
            GraduatedSchool = "Ali Rıza Ortaokulu",
            GPA = 79.8,
            IsPreRegistered = false,
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer5",
            CreatedIpAddress = "192.168.1.5"
        },
        new Student
        {
            Id = Guid.NewGuid(),
            RegistrationNumber = "105-24",
            FirstName = "Emine",
            LastName = "Yılmaz",
            Gender = Gender.Kız,
            GraduatedSchool = "Hacı Ahmet İlkokulu",
            GPA = 87.3,
            IsPreRegistered = true,
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer6",
            CreatedIpAddress = "192.168.1.6"
        },
        new Student
        {
            Id = Guid.NewGuid(),
            RegistrationNumber = "106-24",
            FirstName = "Mehmet",
            LastName = "Kurt",
            Gender = Gender.Erkek,
            GraduatedSchool = "Mustafa Kemal Ortaokulu",
            GPA = 83.6,
            IsPreRegistered = false,
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer7",
            CreatedIpAddress = "192.168.1.7"
        },
        new Student
        {
            Id = Guid.NewGuid(),
            RegistrationNumber = "107-24",
            FirstName = "Fatih",
            LastName = "Sarı",
            Gender = Gender.Erkek,
            GraduatedSchool = "Cumhuriyet İlkokulu",
            GPA = 94.2,
            IsPreRegistered = true,
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer8",
            CreatedIpAddress = "192.168.1.8"
        },
        new Student
        {
            Id = Guid.NewGuid(),
            RegistrationNumber = "108-24",
            FirstName = "Elif",
            LastName = "Demir",
            Gender = Gender.Kız,
            GraduatedSchool = "Fatih Sultan Mehmet Ortaokulu",
            GPA = 78.9,
            IsPreRegistered = false,
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer9",
            CreatedIpAddress = "192.168.1.9"
        },
        new Student
        {
            Id = Guid.NewGuid(),
            RegistrationNumber = "109-24",
            FirstName = "Ali",
            LastName = "Özdemir",
            Gender = Gender.Erkek,
            GraduatedSchool = "İsmet İnönü İlkokulu",
            GPA = 88.7,
            IsPreRegistered = true,
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer10",
            CreatedIpAddress = "192.168.1.10"
        },
        new Student
        {
            Id = Guid.NewGuid(),
            RegistrationNumber = "110-24",
            FirstName = "Sema",
            LastName = "Tekin",
            Gender = Gender.Kız,
            GraduatedSchool = "Necmettin Erbakan Ortaokulu",
            GPA = 85.4,
            IsPreRegistered = false,
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer11",
            CreatedIpAddress = "192.168.1.11"
        },
        new Student
        {
            Id = Guid.NewGuid(),
            RegistrationNumber = "111-24",
            FirstName = "Can",
            LastName = "Aydın",
            Gender = Gender.Erkek,
            GraduatedSchool = "Abdullah Gül İlkokulu",
            GPA = 92.1,
            IsPreRegistered = true,
            ContinuationStatus = ContinuationStatus.Devam,
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer12",
            CreatedIpAddress = "192.168.1.12"
        }
    };

            return students;
        }

    }
}
