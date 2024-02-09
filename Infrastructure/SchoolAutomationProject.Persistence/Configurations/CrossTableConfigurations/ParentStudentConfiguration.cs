using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Configurations.UniqueTableConfigurations;

namespace SchoolAutomationProject.Persistence.Configurations.CrossTableConfigurations
{
    public class ParentStudentConfiguration : IEntityTypeConfiguration<ParentStudent>
    {

        public void Configure(EntityTypeBuilder<ParentStudent> builder)
        {
            builder.HasKey(x => new { x.ParentId, x.StudentId });
            builder.HasOne(x => x.Parent).WithMany(x => x.ParentStudents).HasForeignKey(x => x.ParentId).IsRequired();
            builder.HasOne(x => x.Student).WithMany(x => x.ParentStudents).HasForeignKey(x => x.StudentId).IsRequired();

            builder.HasData(GetSampleParentStudents());
        }

        private List<ParentStudent> GetSampleParentStudents()
        {
            Random rnd = new Random();
            var parentConfiguration = new ParentConfiguration();
            var parentList = parentConfiguration.GetSampleParents();
            var studentConfiguration = new StudentConfiguration();
            var studentList = studentConfiguration.GetSampleStudents();
            List<ParentStudent> parentStudents = new List<ParentStudent>();
            List<int> tempStudentIndexList = new List<int>();

            //for (int i = 0; i < studentList.Count; i++)
            //{
            //    for (int j = 0; j < parentList.Count; j++)
            //    {
            //        var parentListIndex = rnd.Next(parentList.Count);
            //        while (true)
            //        {
            //            if (parentListIndex != j)
            //            {
            //                parentStudents.Add(new ParentStudent { StudentId = studentList[i].Id, ParentId = parentList[parentListIndex].Id });
            //                break;
            //            }
            //            else
            //            {
            //                parentListIndex = rnd.Next(parentList.Count);
            //            }
            //        }
            //        var zar = rnd.Next(7);
            //        if (zar == 6)
            //        {
            //            var studentListIndex = rnd.Next(studentList.Count);
            //            while (true)
            //            {
            //                if (studentListIndex != i)
            //                {
            //                    parentStudents.Add(new ParentStudent { StudentId = studentList[studentListIndex].Id, ParentId = parentList[parentListIndex].Id });
            //                    break;
            //                }
            //                else
            //                {
            //                    studentListIndex = rnd.Next(studentList.Count);
            //                }
            //            }
            //        }
            //    }
            //}

            var random = new Random();

            // Velilere rastgele öğrenciler atayalım
            foreach (var parent in parentList)
            {
                // Velinin kaç öğrencisi olacağını rastgele belirleyelim (1 ile students.Count arasında)
                var numberOfChildren = random.Next(1, 4);

                // Rastgele seçilen öğrencileri velinin çocukları olarak ekleyelim
                var selectedStudents = new List<Student>();
                while (selectedStudents.Count < numberOfChildren)
                {
                    var student = studentList[random.Next(studentList.Count)];
                    // Aynı öğrenciyi birden fazla kez eklememek için kontrol ediyoruz
                    if (!selectedStudents.Contains(student))
                    {
                        parentStudents.Add(new ParentStudent { ParentId = parent.Id, StudentId = student.Id });
                        selectedStudents.Add(student);
                    }
                }
            }
            return parentStudents;
        }
    }
}
