using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Persistence.Configurations.IdentityTablesConfigurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(GetSampleAppUsers());
        }

        public static List<AppUser> GetSampleAppUsers()
        {
            var student = new Student
            {
                Id = Guid.NewGuid(),
                RegistrationNumber = "101-24",
                FirstName = "Mustafa",
                LastName = "Şahin",
                Gender = Gender.Erkek,
                GraduatedSchool = "Şehit Hasan Ortaokulu",
                GPA = 95.0,
                IsPreRegistered = true,
                ClassroomId = Guid.Parse("666917cb-ccff-46e2-81be-1dc06b74ddcb"),
                ContinuationStatus = ContinuationStatus.Devam,
                CreatedDate = DateTime.UtcNow,
                CreatedComputerName = "Computer2",
                CreatedIpAddress = "192.168.1.2"
            };

            var teacher = new Teacher
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
            };

            var parent = new Parent
            {
                Id = Guid.NewGuid(),
                FirstName = "Ayşe",
                LastName = "Kaya",
                MobilePhone = "5559876543",
                WorkPhone = "5553456789",
                Address = "Deneme Mahallesi, Deneme Sokak No: 2",
                District = "Deneme İlçe",
                City = "Deneme Şehir",
                CreatedDate = DateTime.UtcNow,
                CreatedComputerName = "Computer2",
                CreatedIpAddress = "192.168.1.2"
            };

            string[] admin = { "yusuf", "tataroğlu" };
            // Örnek öğrenci ve öğretmen bilgilerini kullanarak AppUser verileri oluşturuluyor
            var appUserList = new List<AppUser>()
            {
                 new AppUser
                {
                    Id = "2862264a-af6f-447a-a449-c317c736ed48", // Yeni bir Guid oluşturuluyor
                     UserName = $"{student.FirstName.ToLower()}{student.LastName.ToLower()}", // Öğrencinin adı ve soyadından oluşturulan bir kullanıcı adı
                     NormalizedUserName = $"{student.FirstName.ToUpper()}{student.LastName.ToUpper()}", // Kullanıcı adının büyük harflerle normal hali
                     Email = $"{student.FirstName.ToLower()}.{student.LastName.ToLower()}@example.com", // Öğrencinin adı ve soyadından oluşturulan bir e-posta adresi
                     NormalizedEmail = $"{student.FirstName.ToUpper()}.{student.LastName.ToUpper()}@EXAMPLE.COM", // E-posta adresinin büyük harflerle normal hali
                     EmailConfirmed = true, // E-posta adresinin onaylandığı varsayılıyor
                    PasswordHash = "HashedPassword", // Örnek bir şifre hash'i
                    SecurityStamp = Guid.NewGuid().ToString(), // Yeni bir Guid oluşturuluyor
                    ConcurrencyStamp = Guid.NewGuid().ToString(), // Yeni bir Guid oluşturuluyor
                    PhoneNumber = "1234567890", // Örnek bir telefon numarası
                    PhoneNumberConfirmed = true, // Telefon numarasının onaylandığı varsayılıyor
                    TwoFactorEnabled = false, // İki faktörlü kimlik doğrulamanın devre dışı olduğu varsayılıyor
                    LockoutEnd = null, // Kullanıcının kitlenme süresi (şu an kitli değil)
                    LockoutEnabled = false, // Kullanıcının kitlenme özelliğinin devre dışı olduğu varsayılıyor
                    AccessFailedCount = 0, // Erişim başarısızlıklarının sayısı
                },
                 new AppUser
        {
            Id = "1abfbe1e-41be-4440-8dd3-4bf6127d77d3", // Yeni bir Guid oluşturuluyor
            UserName = $"{teacher.FirstName.ToLower()}{teacher.LastName.ToLower()}", // Öğretmenin adı ve soyadından oluşturulan bir kullanıcı adı
            NormalizedUserName = $"{teacher.FirstName.ToUpper()}{teacher.LastName.ToUpper()}", // Kullanıcı adının büyük harflerle normal hali
            Email = $"{teacher.FirstName.ToLower()}.{teacher.LastName.ToLower()}@example.com", // Öğretmenin adı ve soyadından oluşturulan bir e-posta adresi
            NormalizedEmail = $"{teacher.FirstName.ToUpper()}.{teacher.LastName.ToUpper()}@EXAMPLE.COM", // E-posta adresinin büyük harflerle normal hali
            EmailConfirmed = true, // E-posta adresinin onaylandığı varsayılıyor
            PasswordHash = "HashedPassword", // Örnek bir şifre hash'i
            SecurityStamp = Guid.NewGuid().ToString(), // Yeni bir Guid oluşturuluyor
            ConcurrencyStamp = Guid.NewGuid().ToString(), // Yeni bir Guid oluşturuluyor
            PhoneNumber = "1234567890", // Örnek bir telefon numarası
            PhoneNumberConfirmed = true, // Telefon numarasının onaylandığı varsayılıyor
            TwoFactorEnabled = false, // İki faktörlü kimlik doğrulamanın devre dışı olduğu varsayılıyor
            LockoutEnd = null, // Kullanıcının kitlenme süresi (şu an kitli değil)
            LockoutEnabled = false, // Kullanıcının kitlenme özelliğinin devre dışı olduğu varsayılıyor
            AccessFailedCount = 0, // Erişim başarısızlıklarının sayısı
        },
                 new AppUser
        {
            Id = "5fc06fe1-18ad-4bf9-8833-85c502b493cc", // Yeni bir Guid oluşturuluyor
            UserName = $"{parent.FirstName.ToLower()}{parent.LastName.ToLower()}", // Öğretmenin adı ve soyadından oluşturulan bir kullanıcı adı
            NormalizedUserName = $"{parent.FirstName.ToUpper()}{parent.LastName.ToUpper()}", // Kullanıcı adının büyük harflerle normal hali
            Email = $"{parent.FirstName.ToLower()}.{parent.LastName.ToLower()}@example.com", // Öğretmenin adı ve soyadından oluşturulan bir e-posta adresi
            NormalizedEmail = $"{parent.FirstName.ToUpper()}.{parent.LastName.ToUpper()}@EXAMPLE.COM", // E-posta adresinin büyük harflerle normal hali
            EmailConfirmed = true, // E-posta adresinin onaylandığı varsayılıyor
            PasswordHash = "HashedPassword", // Örnek bir şifre hash'i
            SecurityStamp = Guid.NewGuid().ToString(), // Yeni bir Guid oluşturuluyor
            ConcurrencyStamp = Guid.NewGuid().ToString(), // Yeni bir Guid oluşturuluyor
            PhoneNumber = "1234567890", // Örnek bir telefon numarası
            PhoneNumberConfirmed = true, // Telefon numarasının onaylandığı varsayılıyor
            TwoFactorEnabled = false, // İki faktörlü kimlik doğrulamanın devre dışı olduğu varsayılıyor
            LockoutEnd = null, // Kullanıcının kitlenme süresi (şu an kitli değil)
            LockoutEnabled = false, // Kullanıcının kitlenme özelliğinin devre dışı olduğu varsayılıyor
            AccessFailedCount = 0, // Erişim başarısızlıklarının sayısı
        },
                 new AppUser
        {
            Id = "e042c938-cf05-4ef1-8e3c-bd4efefe1fe0", // Yeni bir Guid oluşturuluyor
            UserName = $"{admin[0].ToLower()}{admin[1].ToLower()}", // Öğretmenin adı ve soyadından oluşturulan bir kullanıcı adı
            NormalizedUserName = $"{admin[0].ToUpper()}{admin[1].ToUpper()}", // Kullanıcı adının büyük harflerle normal hali
            Email = $"{admin[0].ToLower()}.{admin[1].ToLower()}@example.com", // Öğretmenin adı ve soyadından oluşturulan bir e-posta adresi
            NormalizedEmail = $"{admin[0].ToUpper()}.{admin[1].ToUpper()}@EXAMPLE.COM", // E-posta adresinin büyük harflerle normal hali
            EmailConfirmed = true, // E-posta adresinin onaylandığı varsayılıyor
            PasswordHash = "HashedPassword", // Örnek bir şifre hash'i
            SecurityStamp = Guid.NewGuid().ToString(), // Yeni bir Guid oluşturuluyor
            ConcurrencyStamp = Guid.NewGuid().ToString(), // Yeni bir Guid oluşturuluyor
            PhoneNumber = "1234567890", // Örnek bir telefon numarası
            PhoneNumberConfirmed = true, // Telefon numarasının onaylandığı varsayılıyor
            TwoFactorEnabled = false, // İki faktörlü kimlik doğrulamanın devre dışı olduğu varsayılıyor
            LockoutEnd = null, // Kullanıcının kitlenme süresi (şu an kitli değil)
            LockoutEnabled = false, // Kullanıcının kitlenme özelliğinin devre dışı olduğu varsayılıyor
            AccessFailedCount = 0, // Erişim başarısızlıklarının sayısı
        }
            };
            return appUserList;

        }
    }
}
