using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Configurations.CustomTablesConfigurations
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
            Id = Guid.Parse("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"),
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
            Id = Guid.Parse("304a46c6-a4cb-4fed-8b44-0f40b510e881"),
            FirstName = "Ayşe",
            LastName = "Kaya",
            MobilePhone = "5559876543",
            WorkPhone = "5553456789",
            Address = "Deneme Mahallesi, Deneme Sokak No: 2",
            District = "Deneme İlçe",
            City = "Deneme Şehir",
            UserId="5fc06fe1-18ad-4bf9-8833-85c502b493cc",
            CreatedDate = DateTime.UtcNow,
            CreatedComputerName = "Computer2",
            CreatedIpAddress = "192.168.1.2"
        },
        new Parent
        {
            Id = Guid.Parse("0b28a8c9-b390-485d-815d-82977278f08d"),
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
            Id = Guid.Parse("45e137c7-0927-4931-bbf3-2b42a90f66d3"),
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
            Id = Guid.Parse("1f607b4f-3157-490d-9ce2-85883aa55c70"),
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
            Id = Guid.Parse("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"),
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
            Id = Guid.Parse("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"),
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
            Id = Guid.Parse("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"),
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
            Id = Guid.Parse("47d6a0ea-8050-420e-9500-2c9eb265a678"),
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
            Id = Guid.Parse("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"),
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
