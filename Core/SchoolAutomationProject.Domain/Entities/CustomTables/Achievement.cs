using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.Enums;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class Achievement : BaseClass
    {
        public Achievement()
        {
            //Student = new Student();
            //Semester = new Semester();
        }
        public AchievementType Type { get; set; } // Belge türü (Takdir, Teşekkür)
        public string? Description { get; set; } // Belge açıklaması

        // Öğrenci - Belge ilişkisi
        public virtual Student Student { get; set; }
        public Guid? StudentId { get; set; }

        //Achievement - Semester ilişkisi
        public virtual Semester Semester { get; set; }
        public Guid? SemesterId { get; set; }

    }
}
