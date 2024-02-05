using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Domain.Entities.UniqueTables
{
    public class Achievement : BaseClass
    {
        public AchievementType Type { get; set; } // Belge türü (Takdir, Teşekkür)
        public string? Description { get; set; } // Belge açıklaması

        // Öğrenci - Belge ilişkisi
        public virtual Student Student { get; set; }
        public Guid StudentId { get; set; }

        //Achievement - Semester ilişkisi
        public virtual Semester Season { get; set; }
        public Guid SeasonId { get; set; }

    }
}
