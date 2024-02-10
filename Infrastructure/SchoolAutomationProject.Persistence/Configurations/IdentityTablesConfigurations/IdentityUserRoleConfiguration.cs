using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Persistence.Configurations.IdentityTablesConfigurations
{
    public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(GetSampleIdentityUserRoles());
        }

        public List<IdentityUserRole<string>> GetSampleIdentityUserRoles()
        {
            return new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string> //Student
                {
                    RoleId="86e143a4-b96a-4821-9dad-28747c241f22",
                    UserId="2862264a-af6f-447a-a449-c317c736ed48"
                },
                new IdentityUserRole<string> //Teacher
                {
                    RoleId="bd6a6979-cbb1-4c4a-93f0-19a73a3cdcfc",
                    UserId="1abfbe1e-41be-4440-8dd3-4bf6127d77d3"
                },
                new IdentityUserRole<string> //Parent
                {
                    RoleId="bdac7a93-f4a4-4d94-a5ab-b4e6ccc7643f",
                    UserId="5fc06fe1-18ad-4bf9-8833-85c502b493cc"
                },
                new IdentityUserRole<string> //Admin
                {
                    RoleId="5836daf9-1a03-4190-872a-4fdc42cf4a50",
                    UserId="e042c938-cf05-4ef1-8e3c-bd4efefe1fe0"
                }
            };
        }
    }
}
