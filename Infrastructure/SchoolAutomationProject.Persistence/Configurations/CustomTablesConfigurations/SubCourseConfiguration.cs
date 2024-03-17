using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations
{
    public class SubCourseConfiguration : IEntityTypeConfiguration<SubCourse>
    {
        public void Configure(EntityTypeBuilder<SubCourse> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri
            builder.Property(x => x.Code).HasMaxLength(9).IsRequired();
            builder.Property(x => x.WeeklyHour).IsRequired();

            //builder.HasData(GetSampleSubCourses());
        }

        public List<SubCourse> GetSampleSubCourses()
        {
            List<SubCourse> subCourses = new List<SubCourse>
    {
        new SubCourse
        {
            Id = Guid.Parse("c3caf58e-75b9-4e07-bac9-fe809da8ac54"),
            Code = "MAT101",
            WeeklyHour = 3,
            Position = 1,
            MainCourseId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer1",
            CreatedIpAddress = "192.168.1.1"
        },
        new SubCourse
        {
            Id = Guid.Parse("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"),
            Code = "MAT102",
            WeeklyHour = 3,
            Position = 2,
            MainCourseId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer2",
            CreatedIpAddress = "192.168.1.2"
        },
        new SubCourse
        {
            Id = Guid.Parse("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"),
            Code = "TUR101",
            WeeklyHour = 4,
            Position = 1,
            MainCourseId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer3",
            CreatedIpAddress = "192.168.1.3"
        },
        new SubCourse
        {
            Id = Guid.Parse("b1760af3-a642-4c3d-9c29-7364f4607a48"),
            Code = "TUR102",
            WeeklyHour = 4,
            Position = 2,
            MainCourseId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer4",
            CreatedIpAddress = "192.168.1.4"
        },
        new SubCourse
        {
            Id = Guid.Parse("a5f980a8-71c0-45a1-a360-8caff5e174ab"),
            Code = "BIO101",
            WeeklyHour = 3,
            Position = 1,
            MainCourseId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer5",
            CreatedIpAddress = "192.168.1.5"
        },
        new SubCourse
        {
            Id = Guid.Parse("c0340c3c-9153-4951-969d-1b0136758af7"),
            Code = "BIO102",
            WeeklyHour = 3,
            Position = 2,
            MainCourseId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer6",
            CreatedIpAddress = "192.168.1.6"
        },
        new SubCourse
        {
            Id = Guid.Parse("4ee32722-4aca-42f9-9fd6-060b9a3066c1"),
            Code = "PHY101",
            WeeklyHour = 4,
            Position = 1,
            MainCourseId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer7",
            CreatedIpAddress = "192.168.1.7"
        },
        new SubCourse
        {
            Id = Guid.Parse("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"),
            Code = "PHY102",
            WeeklyHour = 4,
            Position = 2,
            MainCourseId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer8",
            CreatedIpAddress = "192.168.1.8"
        },
        new SubCourse
        {
            Id = Guid.Parse("9aceddeb-6886-4535-9f45-989fee247cb9"),
            Code = "CHEM101",
            WeeklyHour = 3,
            Position = 1,
            MainCourseId = Guid.Parse("55555555-5555-5555-5555-555555555555"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer9",
            CreatedIpAddress = "192.168.1.9"
        },
        new SubCourse
        {
            Id = Guid.Parse("6b36a63c-a7c0-495c-9247-082ab342d65a"),
            Code = "CHEM102",
            WeeklyHour = 3,
            Position = 2,
            MainCourseId = Guid.Parse("55555555-5555-5555-5555-555555555555"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer10",
            CreatedIpAddress = "192.168.1.10"
        },
        new SubCourse
        {
            Id = Guid.Parse("bd914d22-1482-497d-a552-6926b915f669"),
            Code = "HIS101",
            WeeklyHour = 4,
            Position = 1,
            MainCourseId = Guid.Parse("66666666-6666-6666-6666-666666666666"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer11",
            CreatedIpAddress = "192.168.1.11"
        },
        new SubCourse
        {
            Id = Guid.Parse("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"),
            Code = "HIS102",
            WeeklyHour = 4,
            Position = 2,
            MainCourseId = Guid.Parse("66666666-6666-6666-6666-666666666666"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer12",
            CreatedIpAddress = "192.168.1.12"
        },
        new SubCourse
        {
            Id = Guid.Parse("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"),
            Code = "GEO101",
            WeeklyHour = 3,
            Position = 1,
            MainCourseId = Guid.Parse("77777777-7777-7777-7777-777777777777"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer13",
            CreatedIpAddress = "192.168.1.13"
        },
        new SubCourse
        {
            Id = Guid.Parse("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"),
            Code = "GEO102",
            WeeklyHour = 3,
            Position = 2,
            MainCourseId = Guid.Parse("77777777-7777-7777-7777-777777777777"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer14",
            CreatedIpAddress = "192.168.1.14"
        },
        new SubCourse
        {
            Id = Guid.Parse("b8be083e-1748-47cc-aab8-754f8a7434f1"),
            Code = "ENG101",
            WeeklyHour = 4,
            Position = 1,
            MainCourseId = Guid.Parse("88888888-8888-8888-8888-888888888888"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer15",
            CreatedIpAddress = "192.168.1.15"
        },
        new SubCourse
        {
            Id = Guid.Parse("36400de0-3b8c-4c08-ab07-628e17b9fc56"),
            Code = "ENG102",
            WeeklyHour = 4,
            Position = 2,
            MainCourseId = Guid.Parse("88888888-8888-8888-8888-888888888888"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer16",
            CreatedIpAddress = "192.168.1.16"
        },
        new SubCourse
        {
            Id = Guid.Parse("722fa150-b091-4ef8-a2ea-c2b782f42c73"),
            Code = "MUS101",
            WeeklyHour = 3,
            Position = 1,
            MainCourseId = Guid.Parse("99999999-9999-9999-9999-999999999999"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer17",
            CreatedIpAddress = "192.168.1.17"
        },
        new SubCourse
        {
            Id = Guid.Parse("9c7df23d-8358-45b5-94e1-fe907e573723"),
            Code = "MUS102",
            WeeklyHour = 3,
            Position = 2,
            MainCourseId = Guid.Parse("99999999-9999-9999-9999-999999999999"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer18",
            CreatedIpAddress = "192.168.1.18"
        },
        new SubCourse
        {
            Id = Guid.Parse("8c9f4082-6b71-4b52-8e96-01b3933e5797"),
            Code = "ART101",
            WeeklyHour = 4,
            Position = 1,
            MainCourseId = Guid.Parse("AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer19",
            CreatedIpAddress = "192.168.1.19"
        },
        new SubCourse
        {
            Id = Guid.Parse("fb221081-45cd-42be-abd4-45976e996233"),
            Code = "ART102",
            WeeklyHour = 4,
            Position = 2,
            MainCourseId = Guid.Parse("AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA"),
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer20",
            CreatedIpAddress = "192.168.1.20"
        }
    };

            return subCourses;
        }

    }
}
