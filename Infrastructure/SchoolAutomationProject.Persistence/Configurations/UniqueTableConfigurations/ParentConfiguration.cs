using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.UniqueTables;

namespace SchoolAutomationProject.Persistence.Configurations.UniqueTableConfigurations
{
    public class ParentConfiguration : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
        {
            //BaseClass'tan gelen property özelleştirmeleri
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.CreatedComputerName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CreatedIpAddress).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UpdatedComputerName).HasMaxLength(255);
            builder.Property(x => x.UpdatedIpAddress).HasMaxLength(255);

            //Bu tabloya ait propertylerin özelleştirmeleri
            builder.Property(x=> x.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(x=> x.LastName).HasMaxLength(100).IsRequired();
            builder.Property(x=> x.MobilePhone).HasMaxLength(11).IsFixedLength().IsRequired();
            builder.Property(x => x.WorkPhone).HasMaxLength(11).IsFixedLength();
            builder.Property(x => x.Address).HasMaxLength(255).IsRequired();
            builder.Property(x => x.District).HasMaxLength(50).IsRequired();
            builder.Property(x => x.City).HasMaxLength(50).IsRequired();

            builder.HasData(GetSampleParents());

        }

        public List<Parent> GetSampleParents()
        {
            List<Parent> parents = new List<Parent>
    {
        new Parent
        {
            Id = Guid.NewGuid(),
            FirstName = "Ali",
            LastName = "Yılmaz",
            MobilePhone = "5551234567",
            WorkPhone = "5557654321",
            Address = "Örnek Mahallesi, Örnek Sokak No: 1",
            District = "Örnek İlçe",
            City = "Örnek Şehir",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer1",
            CreatedIpAddress = "192.168.1.1"
        },
        new Parent
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
        },
        new Parent
        {
            Id = Guid.NewGuid(),
            FirstName = "Mehmet",
            LastName = "Demir",
            MobilePhone = "5552345678",
            Address = "Test Mahallesi, Test Sokak No: 3",
            District = "Test İlçe",
            City = "Test Şehir",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer3",
            CreatedIpAddress = "192.168.1.3"
        },
        new Parent
        {
            Id = Guid.NewGuid(),
            FirstName = "Fatma",
            LastName = "Şahin",
            MobilePhone = "5558765432",
            WorkPhone = "5554567890",
            Address = "Örnek Mahallesi, Örnek Sokak No: 4",
            District = "Örnek İlçe",
            City = "Örnek Şehir",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer4",
            CreatedIpAddress = "192.168.1.4"
        },
        new Parent
        {
            Id = Guid.NewGuid(),
            FirstName = "Mustafa",
            LastName = "Aydın",
            MobilePhone = "5553456789",
            Address = "Deneme Mahallesi, Deneme Sokak No: 5",
            District = "Deneme İlçe",
            City = "Deneme Şehir",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer5",
            CreatedIpAddress = "192.168.1.5"
        },
        new Parent
        {
            Id = Guid.NewGuid(),
            FirstName = "Zeynep",
            LastName = "Erdoğan",
            MobilePhone = "5556543210",
            WorkPhone = "5555678901",
            Address = "Test Mahallesi, Test Sokak No: 6",
            District = "Test İlçe",
            City = "Test Şehir",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer6",
            CreatedIpAddress = "192.168.1.6"
        },
        new Parent
        {
            Id = Guid.NewGuid(),
            FirstName = "Emine",
            LastName = "Kurt",
            MobilePhone = "5555432109",
            Address = "Örnek Mahallesi, Örnek Sokak No: 7",
            District = "Örnek İlçe",
            City = "Örnek Şehir",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer7",
            CreatedIpAddress = "192.168.1.7"
        },
        new Parent
        {
            Id = Guid.NewGuid(),
            FirstName = "Ahmet",
            LastName = "Sarı",
            MobilePhone = "5554321098",
            WorkPhone = "5556789012",
            Address = "Deneme Mahallesi, Deneme Sokak No: 8",
            District = "Deneme İlçe",
            City = "Deneme Şehir",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer8",
            CreatedIpAddress = "192.168.1.8"
        },
        new Parent
        {
            Id = Guid.NewGuid(),
            FirstName = "Fatma",
            LastName = "Can",
            MobilePhone = "5553210987",
            Address = "Test Mahallesi, Test Sokak No: 9",
            District = "Test İlçe",
            City = "Test Şehir",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer9",
            CreatedIpAddress = "192.168.1.9"
        },
        new Parent
        {
            Id = Guid.NewGuid(),
            FirstName = "Mehmet",
            LastName = "Kara",
            MobilePhone = "5552109876",
            WorkPhone = "5557890123",
            Address = "Örnek Mahallesi, Örnek Sokak No: 10",
            District = "Örnek İlçe",
            City = "Örnek Şehir",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer10",
            CreatedIpAddress = "192.168.1.10"
        }
    };

            return parents;
        }

    }
}
