using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolAutomationProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomMainCourse_Classrooms_ClassroomId",
                table: "ClassroomMainCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomMainCourse_MainCourses_MainCourseId",
                table: "ClassroomMainCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomTeacher_Classrooms_ClassroomId",
                table: "ClassroomTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomTeacher_Teachers_TeacherId",
                table: "ClassroomTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentStudent_Parents_ParentId",
                table: "ParentStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentStudent_Students_StudentId",
                table: "ParentStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeacher_Students_StudentId",
                table: "StudentTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeacher_Teachers_TeacherId",
                table: "StudentTeacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentTeacher",
                table: "StudentTeacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParentStudent",
                table: "ParentStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassroomTeacher",
                table: "ClassroomTeacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassroomMainCourse",
                table: "ClassroomMainCourse");

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("005b45d6-c199-467e-bb56-124e7b61401b"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("03a32433-b892-415f-960d-b60001ae88e4"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("04ef92da-5441-43bd-867e-d74ac40e470c"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("0861fd6e-1311-4496-99d0-fe7e577ef987"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("0a9e55f1-26d5-49fa-a2f9-65312ae4b4f6"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("10ec9639-9bbd-416c-9efb-50d6f034d0ff"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("1bd3df30-f866-45cf-a70a-edab8d1fb846"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("21d8662e-8d2b-47f3-ba2c-cd05d385562e"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("27eec676-f2d1-4ab9-bf50-63c8832f6acf"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("3a002558-9d06-4730-9e44-ba24d147472b"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("3b9f795a-7105-4eb3-9e01-8b82dba83c7c"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("425d0fd5-c29e-4af6-84d0-c80e8a9079da"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("474df99d-561d-4730-8a81-808564c06c17"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("484d8f2c-d334-4ec7-9e98-749e83ecedf9"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("4d6f9e88-084b-4ef2-a6d9-fa5c48138a96"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("4e536b73-5abd-41e7-bcaa-751e0203baff"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("54fc4f48-5616-4d7f-90b4-a524a1eba7e3"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("55a9a49f-f721-44b2-a5f0-eceafce52874"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("57cea3cb-c465-4d25-918c-e812a23dc1e6"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5cff23a9-3480-451c-a5b7-f3944e3d3351"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5e71bdab-f9f1-44f6-8b12-12b0b4907df7"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("61300edd-9118-4fbb-9a05-97ece4f3b8ca"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6a01d3f9-57c0-4874-b080-51305e549844"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6ca29e10-64c6-43ad-8281-15ea532935fc"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6eb97262-7677-487c-a2a7-6ff3bff82c31"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("70b255b1-abef-43d1-ad68-8550b9a10b26"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("760f6cc0-63d2-4e0a-9d39-0c145158d3b2"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("7756e368-4b85-4d9c-80a5-23ab6e6e67bb"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("78039291-4200-4cf5-a79d-051ab24d9b81"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("7813b46d-88e3-43c6-935c-e5cd5f709e0e"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("7c615b55-4e13-4fbe-a43c-e084ff445abd"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("7d78e82c-44d2-4995-80fa-e1be8a8d4554"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("8495277f-498a-4d3c-9a93-e2f672c09b80"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("88ef78ef-c139-419e-b2d4-347686488bce"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("8ccc40d5-3cdd-4ff4-b623-bce967d18d65"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("913c983b-42b7-41b9-aa7c-e00caac7c3f6"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("91f08961-21ee-4e75-842a-b558c7d48ead"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("98634660-98af-4814-ab83-c63e4c23c7e3"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9e6e7075-32be-4170-bb60-45edac4aa095"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9ffaa578-b98b-4685-8c2c-d0c8160d64b0"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("a0ddc376-1f10-4b84-93c3-1b438f2aeced"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("a36d7f19-36fa-4a54-b7ea-d5a993e1d8a8"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("a836418e-5128-44d4-af0c-15a576456dcb"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("a96409a9-e24b-497e-a91b-c7d14a0fbe35"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("aa1dbc25-7ef4-441c-a028-20db54bc65ee"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("af42028c-aa2f-4abb-a8f1-efb899852640"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b079f2ce-bc67-4d34-83ea-e92ab835a5bf"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b4d1b928-945e-459d-84c1-84997d112035"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b543af2c-d948-472a-ba24-a05d32f36196"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("bc1748ae-293a-4abc-bf32-2c93d4006046"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("c544a8f2-10f8-4e5d-a7d2-10ba5090e4c8"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("cb565e1a-049c-4abf-93b1-dd7463ad487f"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("e0129d61-4d29-42f5-a932-6a71259b6d11"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("e49cee1d-9b52-4b62-9819-a1395c02c920"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("e993ace6-282b-41f1-a757-8619b0e2cbbc"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("e9b9879b-192b-4705-a7fe-6fe56b42961c"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("e9c51deb-d7f1-4808-a7b6-71ed067765f8"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f020800c-5db4-4685-8bd0-f58854b28382"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f593aab2-01d0-40c2-97ec-6c484dfa26e2"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f6526354-d9b8-4cfa-9227-0d3b3875241c"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("08a98a7d-f3ab-4a3f-baa7-0e323e3b40e8"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("0da4958c-db00-486b-9680-bd2ff6767548"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("18b120ae-1e7a-4d08-a1e7-179094dd412b"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("1cb9764b-f6c1-4eaa-8e4c-33f463794e68"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("241678ec-8d44-4e94-9dad-a3545f5ce7cf"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("2c5839c9-0695-4908-8b0c-2cd980825ea7"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("336c1e66-0295-42c0-b1c2-64214ca46092"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("3b7fbdd5-4534-4565-8f9b-6acfc61e2714"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("3c196425-83a8-4466-98fb-5cfe223a148d"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("3ebba850-a835-49a0-b0d1-ea16cf6780f8"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("4232ae7c-d3a8-4f53-b92c-a2ec0f0880e7"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("4822ed0b-1181-4af5-93e1-5cdce7240d30"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("48449b79-bf8a-49af-899b-dccadd00cfc3"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("4e903cbf-5417-4653-9ba6-f3d5b30d59eb"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("5ccaeba9-7715-43d8-8e31-0dd73272cbea"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("5e559fef-3900-41c6-b29f-73ce6da208bb"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("601b6ed7-7cb7-4648-be6f-c870a0c59db5"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("60208e53-48d1-4103-9399-284140668b95"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("676567b2-672b-4ab2-9ba5-cb98d317fe87"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("683ba387-bf02-4200-aff6-ba17ed1e8c2c"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("6dcb7bd9-cb91-426e-bac9-12d9ee4ba43d"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("73d8038a-74e8-423e-9128-adbfa0bb1de3"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("73f3c5c6-e73d-46f2-95ef-40f0015c9616"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("7534c264-d8c9-43d2-b155-0a5784d8675f"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("84105e68-66b6-4900-9ec5-cc60571dd2c8"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("8744f473-ea13-4904-b77c-241f28e24845"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("8bab2594-ab29-47f0-8b53-a8db70871d27"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("8eef8bdd-4b42-46e6-8952-f896937c4b3d"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("93a1d5ce-5a01-42f0-9ca7-f7dc99555341"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("9a827a93-d4b8-45fe-94df-40278cb3c453"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("9be11115-27f1-48be-a746-740f8a579e19"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("a46a6fee-58ec-40c2-91c4-d61c96b324b6"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("abe31a2c-8778-4820-9bfb-4962a2249b9d"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("af164c93-f9c5-489f-91dd-7dc94c759eee"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("afffcb39-d491-4634-80cb-0442827667c3"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("b046bece-b17a-4400-82d7-1551761832d1"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("b2dff3cc-a850-4bf2-8143-deb91649c671"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("c3492178-c569-4ed5-935e-c17d42463d0e"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("c36a364c-5f74-46e8-9549-a1d89995cf37"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("c6152c70-39ed-41af-bf31-6d821a3f0331"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("cb4d8a12-b59e-40f0-91aa-3dfb669f1dd7"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("d9582154-aa11-4261-b537-acc8e2249f35"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("decc0de1-d365-482e-9137-95265dd72558"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("ebe8a860-090f-4579-b610-efbf552645df"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("ed9e2f3d-9175-45f9-ad00-f1b5ea2fa119"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("eef1e8cb-037e-4c48-aa36-8a7f91969150"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("f3299e8c-cfd8-4c7e-ab7c-0b919efbeed6"));

            migrationBuilder.DeleteData(
                table: "DiscontinuedStudents",
                keyColumn: "Id",
                keyValue: new Guid("5f2d38fb-e30b-4f9b-968a-d12269189afe"));

            migrationBuilder.DeleteData(
                table: "DiscontinuedStudents",
                keyColumn: "Id",
                keyValue: new Guid("89ad77c7-d0c8-4d48-b21d-f1b9786e63dd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("005ea28f-c75b-41b3-b48a-7dc85e035128"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("00bf37ca-622c-4ef7-bb7c-d9fb2ec319b9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("00c2dc4e-1a0b-4910-b882-951971e40092"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("00f896e5-4f05-475b-80d2-420553bd7988"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("01037e02-5bcd-4359-b074-b3bf437a3872"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("011a013a-96ff-4fab-96d8-da7c02d77c0b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("011b0499-d457-4962-bea5-e8bd871c9fc3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("012bb3eb-07a7-4d31-8c4a-f607a3a097b9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0154f16f-0375-4b18-abc5-e007dc66f68b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("018ff3dc-8dcb-40b9-bc82-e961ec42c85b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("019777a5-3d4d-4bf9-86ab-55c9c3186493"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("01e1c7b3-162e-4034-82a5-ff2dbf1640b3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("022f186c-6ac5-4f25-af94-781b9891b40b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0251b2f3-c6e8-452f-9a20-ed60ec52d6a0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("026a263a-f53b-4e9c-a5f8-2095a4adc7a5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("02b0d01a-8c0b-4362-9715-6fe6b21c2c88"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("02ca6838-dadb-45bb-9658-21a7d2d79c52"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("03819b37-f4b8-4e03-932c-62ae0e40639a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("041e8c97-8fa6-4df3-a79b-104896969986"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0491b6b7-213d-4372-91d0-69571b6b2054"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("049d300b-0dad-4bdc-ac3a-db9fcb97dbfb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("04a19cbd-9ace-4b17-9b54-9bd8324805c9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("04db1d29-d6f5-42ab-8197-3d09c21aead7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("05024067-e2c8-4728-b874-91ac86158f00"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("055a86ce-77e5-4860-b388-f6d6c245cd11"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("05e3b08d-b013-4bd6-befa-69610660a046"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("06622404-8d13-4486-9591-7bb20b2b7046"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("06693ba1-6c05-4081-98f6-1e869f10cf0b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("06bf5e09-10d7-4c38-ac24-5cc76f2004a4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("06ccf203-a6ea-4316-acec-2b5186042b49"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0751f61f-3bc4-4dce-b137-3dc200f0740e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("078be022-f9cc-4a60-b5f4-22f77875c7f2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("07e07007-fe54-40e8-83e4-31a6b2a13174"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0816d348-bdce-4ca5-8084-4f314830e6b2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("08951da7-1923-4735-b77e-b28c1307cde2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("099f0124-d41e-4fd5-b3fe-819aebee1e24"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("09b8b8ee-87a8-4985-b6b8-b0fe664879f0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("09f69f74-57f6-4cf3-8e52-3290627682b8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("09f823de-8551-48e5-b99e-0b69288011b3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0a2d6bd7-a80e-497a-a92f-8fc95989c556"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0a9bcfab-61ad-4bbc-8a96-158beacb54e7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0b26d209-0414-4886-9ffd-76fc6e836a16"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0bbd807b-3f2a-4aba-a7dc-a358e2938398"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0bde01d2-6a4e-4de0-9790-09a35fc05f5b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0c326899-b8c3-43ff-96e8-7e195fa9d392"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0c4a8326-0162-418c-9949-c4326e2d442f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0caa3e40-caf8-4ac4-a922-ad1286891de0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0d21f61b-9d4d-4e21-92c8-193b3d949b39"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0d9daaaa-fcfa-4c29-b363-530e502b261b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0da0e00e-2eee-456f-9780-8f65149644ea"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0e46da89-6d4d-492d-ad79-674b92b0271c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0e92edab-5c28-4303-a5af-d7062ffec6f3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0f2d64c2-3717-4f98-84a4-f16a650b3bd1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0f2e32bf-778e-4d2f-a356-8b2d33e75d9f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0f35abd1-ea76-4b0a-b11b-02cc114230f1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0f793664-becc-4644-b6f9-8ab6d0ab6e42"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0fdc949d-5ff7-40d6-bcb9-f60920eb4ef8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0fe542db-6a81-43da-87c3-a2f5e0e81bd3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("11234aca-84ad-476b-bc9e-743e397f2496"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("11865926-4c50-4c48-8403-7a907a77ca25"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("11a4401b-26e8-497a-8884-a109c479c4a8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("11e73ca7-a4d9-4c63-8e7b-de6f22e7f7e6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("123f6e78-49db-4a05-9736-a74f051a35d6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("12aab508-a141-47d6-ad34-034b45a45e3f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("12ce948e-47ac-4f3b-9e98-d414753f2ac3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("12f4f029-33ae-4f23-b433-2eaa9fa317f6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1347904d-223c-47f7-b83d-8293fc3d4e47"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("138182f9-e6ba-4c35-aca4-8d3f136199fe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("138e5393-7117-4d46-8d78-c3f196a0275e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("138e8dd1-08bb-4d13-aa77-e81bc01a5387"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("13cbd71a-ab06-42ee-8f09-4eedd1e413ae"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("13fd107e-f94e-4e4a-bf4a-a33053836af6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1406ad94-3ad4-4f9a-9d1c-0eadac1666ab"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1433c641-6634-4535-aec6-19b8662527d7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("144da962-5cd2-4d57-9aa2-7f727645bd2a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("14bc339d-2e36-4137-a9cd-01657252ffff"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("14e139b5-d1f8-406b-8b16-58c05d1766ad"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("15171a92-a67c-44c4-a768-3405d61934b7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("158faa3e-c4e8-45f6-ae6d-6bed9e1793c3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("159cbd91-ca95-40a0-baf3-b068762d2daf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("15a129e2-0dd8-4b39-8b73-49d1c3e34cd1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("15aaad94-3bd1-42b3-8eb6-ebce012ab533"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("15cf7ecf-de41-43b2-927e-5dcf8aa410b1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("16de8730-a2ac-46e1-bdee-e9b988c73e4f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("16e69358-c607-4ccd-9597-de374f08b093"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("17595bc8-2140-4945-9102-c9d1ae2624ef"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1762c65a-c314-4c6f-9199-becf03d6e303"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("19361fb9-de6d-452b-9221-8c5cabc3a3b1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("19ce77d0-e77c-4c66-9b91-a0e9e84468dd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("19eba8c3-42b9-48d1-a0d0-4c0775c71094"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1a2f333b-09d0-489e-ae96-b8fae338b51b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1a8d5b3b-5816-4ee3-aaae-092e7c5af19c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1abd5480-59a2-4537-a9a2-2a01ec2b3d8a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1b028e79-08ba-4c89-a1b4-f428cf3de486"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1b0f9169-5cf0-4ee2-964a-43d005e126bf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1b913ad7-cbaa-4e5b-9770-4c33dde7a477"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1ba76708-5fce-4358-afea-83e4b3985f0c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1c013e94-d51f-4fe0-a341-f8abbec80bce"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1ca179ff-b5da-4923-8ef3-772984989a71"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1d18c0f8-91c5-4858-b6cb-a2798550b7ff"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1d2a3429-5e92-46d9-a588-d9d23d76a5ec"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1d6504f6-fee7-4bea-ab74-11dfe36a2703"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1da5bfff-3e94-46eb-9033-2229520bacbc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1dea681f-b366-4735-b397-78eb8bd29b0d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1e471341-4124-4b08-94f0-9ceb4be652d9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1eeecb00-5919-470c-86b6-c6baae3ae4eb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1f16f790-acf2-45a4-be2f-3563e548f797"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1fa7dc9f-fd3a-4865-b7cf-bb5f867e1e72"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1fef164c-d86f-4d92-83dd-cf19ca692c7d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2020405e-2c9b-4cb8-897c-b9d2243c31e8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("202522a8-4ec2-459d-94b9-7853d012cb4e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("20e998db-5fe6-42f9-87d8-1c54401b8aa5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("21027fb1-c6fe-4fd7-a890-9c68cd6e8700"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2103ff62-16d3-4af2-b28b-dcec3eeb7e17"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2121be09-2af6-44ec-ae7f-76e43d82e5df"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("213aaaa2-138b-46c6-8020-fa2d08236cfb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("218aac4b-747f-4242-84cc-b6b86563b786"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("21d1f6bf-dc05-45b2-9ab9-39b14fb7fc20"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("22bc4701-93a6-4ad4-b8aa-c3dab0b839d2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("22fcee10-831e-4a6a-9d39-27464fd1c9d8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("23383987-3255-4c64-8889-ca5735e1d4e7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("233aa6cc-7a37-4258-b468-e64977b75cc8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("23ac2364-4c05-4556-aa48-75fc9d6680b3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("249329ec-3c12-44e6-a270-046501be6c7d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("250b7627-3951-46ea-8302-02d462135f41"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("25528e7b-4ee5-4402-9123-83f58b8bc288"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("258bda7e-4600-487d-958e-69bd8808cc04"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("259d5d48-c7f7-4c9b-a1b0-3130a6b23631"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("259e3557-6b93-43ec-b03e-78fbaab4c970"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("25a5eb48-276f-4914-821a-3aa46476f59b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("25b0742c-8084-4ada-8ba5-2f68b469b11a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("25b1eb19-4aab-445e-839c-96423c201f17"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("26ce690e-7a38-400e-a986-0b5aa313ec0a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("275afd3e-84be-4aa5-8fb5-a7dc277f30d6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("27744785-161a-4672-9eaa-959b630403ff"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("278aa89c-a3c8-4406-9e2d-f565b55ad4e4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("279ec77d-2b23-404b-9a0c-5bc131617e1a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("279fff71-493f-4c17-911c-b829b52d768f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2856db29-bcea-4108-8c27-fc66a7879e88"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("286befd5-7975-47fa-9596-12258bc26108"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("28f91b21-a0af-45c0-ab7a-af47c452acd1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2909d773-de4e-4ca2-aeb2-355aa5dedefe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2931045a-2ab0-48f0-83ce-27bd2a1bd9fb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("293db877-ec0c-4e84-881a-978b7b89a9c2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2947742f-826c-4966-b421-2b315c82522d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("29a077c5-a7f7-4ddb-9c2c-0b93e909a235"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2a3b292c-40da-418c-a137-add22d165ebe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2af99fab-568f-4372-89d6-0849a876930a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2b4da6df-1985-46db-94c8-00b7f768c1ce"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2de38311-6655-43af-9644-007e925244d6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2e22b09f-4a9d-4c01-859f-c60d7d54e274"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2e45181a-2e0e-4b00-a4e9-a7d13e6b4cf6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2f06a3bf-95e6-489d-8341-eed7337fdaab"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2f400253-6749-4638-8067-97cb6eb0309c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2f46bc37-ac65-4a17-aaec-8308b9334508"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2f8be050-53f7-4722-9a8c-42ce10faef45"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2f9d1883-dfd2-481a-bf4e-2ae3a6d4b9c3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2fc91320-499a-4fbe-af07-8186ccd37c62"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("304e0717-d969-45e1-8453-3b7c9d857596"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("30838845-9545-49a1-aa2f-9fb24d1ea2a6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("30e631bf-bfd1-417e-a06c-05b73163ba48"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("30fe4c3a-d920-4ded-b053-d7c36a0301c1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("315741c3-cde5-4126-8d36-33381767e07d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("31b24cd1-6b78-43df-8fa2-5feceff06e14"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("31b45ad7-9043-4eaf-bb60-c4d714b40d72"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3269216f-2bf4-4df4-b2b1-ecfa8ce26b28"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("32942ba6-675c-4b1a-b95e-0d4b1f135100"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("330c1387-882d-4654-9edd-1d19de3b6616"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("33384386-39c1-49d9-a31e-213c06e97d44"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3360ebfa-5943-4e2d-99a9-028b295c3adb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("33915ac2-cfd6-4440-a3f6-fa242791f61a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("33a7a18b-2429-4945-9a07-2bc2a6af0b8c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("33cac9cd-0e73-4839-9215-0244430df60d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("343af657-ac5d-425a-8a6d-ab6c81e4d776"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("35164cc1-925e-47de-83f1-54ea06d73277"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("35253831-1e93-42b5-9c05-9813ec3dc679"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("35f89521-a4c3-4f56-b7c9-440099893f33"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3644c7a0-5dca-4ade-8303-aac4fbbd4cbb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("36569139-3f57-4552-8cb0-c6d38e3afd59"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("37765832-a80a-4bfd-8779-cc91c7f6c923"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("38b688be-482e-46c6-b868-6c16ca86d813"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("39185e7f-320d-4033-96d6-d5f0532dc1fb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("39352d7c-0197-49ae-9c5b-7031788bd115"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("39e606fd-9441-4905-a3d7-80fc278e068b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3a68b52a-dfbd-4153-8865-ab80231889ef"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3b9dac9e-1316-4283-b66d-062251e79bbf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3bee2ee4-9625-434e-b69c-ca520bcbaff7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3ca09455-19dd-44be-8525-df57f9a430d5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3ca651d3-89d8-4b99-86f2-cfcffff9d2b6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3ccc0a31-e7bc-4cba-b167-83ebf6a732e5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3e1f9c65-9a26-4a39-895c-4ee464fc775d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3e733b0d-fc35-420c-b8ad-73e5a9164af7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3e9c38e4-1ff2-42d2-a30a-aa497e5dd1d0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3eb0ef09-1e7f-4e69-98b3-3a76afb1d065"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3f33ea7c-58df-435a-8d95-1c56a1b0e159"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3f8d0410-fa04-4828-8b37-b71908a9dc45"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("401bbb37-7834-40ec-aa61-3b823ca01b1e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("40bd9fea-fb1a-4029-b12b-f7fd56d61cb9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("40d9a294-77ac-4766-b703-c220a5a2f796"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("410d8999-b6dd-4edd-a1c6-84d56a4f9903"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("41689bbd-939a-4ef9-9fda-49368ecc4fe0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4203a5eb-12cb-4d95-bf80-82ac006137a0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("42642f7a-095a-44e1-be73-09740b748214"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("43a5ae21-a3df-429e-b26a-ac028d35eee2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("43ac6975-f97a-46ee-bd0e-b883000f57c5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("43db039c-ee13-4cfa-82d9-2543b86e342d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("44fe0c88-496e-4e77-a683-b01146254fc1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("45c1c53c-e40b-4a18-b9cb-ec67e2e4a7d6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("46256afb-982c-4254-8bec-fe0d388c046c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("466945af-b789-4424-9765-fce020030e99"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("467193f4-fb09-4661-88aa-99c1e69dd0d8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("46b2dc7e-1c1c-4680-be01-ac6a897f61ff"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("46bd56d7-9799-44cf-991c-90b45d6c52c0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4757998d-db8a-49f1-8873-fd424d899aee"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4757df05-1016-4ce0-91d8-71b0908c19e9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("475ad080-96b7-4169-a7f9-e2368a894d61"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("47868abf-ab83-4da6-acc4-a774a99158f8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("49f24c03-3544-49b8-8d23-859da0bfd4d8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("49f88d8d-8aae-4d33-b768-1d09a7692e9b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4a17b6a0-4351-4a43-9c69-824f3a72ed4b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4a20f41d-16c2-4881-9e79-01f4f141b28b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4aa508bb-4d29-4436-b3d0-4ee83c33e266"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4b5bae8e-281b-4e02-b765-a85173bc9764"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4b699cc9-c331-47ec-aff4-c36e35e7e8f4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4b809fe3-039e-4923-a01c-7d2091a79712"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4bebc765-d849-4f2e-8109-823ce23dec55"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4c2335bd-39c3-4eb7-b579-1eb73e59bb39"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4c282337-8983-4312-ab54-24f9db3eaaa9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4c41f14f-e464-4041-acae-8d6ab65f4eec"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4d8a0fcb-8dd3-4802-8e41-910a20ad9162"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4e2e96e0-5591-4568-b982-08cc7a4e3b6d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4eaa3b40-8ded-43f5-9c72-dc3339998a12"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4ebed74b-5230-4867-b0a0-20d14dcc9acf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4f302ae4-ea76-4620-bc4e-61bc8c7b50bc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4f4c090b-ed0f-4eda-b637-dd8ae33750a7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4f6c71fe-cc6b-420d-bc9c-1526520f733f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4ff4881c-f766-4b0f-90af-ad836e9681ee"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5011260b-e888-4ec2-8f79-a106e0515f78"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("504a99a4-726f-4a22-9d1a-64a903bf0c95"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5057c206-69a0-4610-83d8-e6e5dbbe7c9b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("50d411ab-9e8d-4944-b674-21203f03bb4f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("50f668c8-9bdc-4e74-8136-dab5500c15a2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("514b3d7d-d1f5-4d91-a614-091451447dbc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("51fa18b1-1d95-47ca-a34e-059d8012f315"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("527fb084-cd00-447b-93c7-c0512419b65e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("52ef98f3-89cc-4da2-8db0-1cd5173f1ffd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("533ab318-fe4c-4fdb-b586-546bc077aa25"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5380ec26-1102-4482-bc45-4313c2e6fcba"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("53b93e24-807f-41b2-bc12-2cd2d29d4bad"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("53ffa805-8e2f-4f9b-82b6-8f0724a4a507"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5404d7a4-f08a-478f-8d49-e126073af3e9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5437a2c4-189b-4011-8379-b7321e9121c2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("54389b27-3def-412b-ae3f-d111e1150bb2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("546ac175-ff86-484f-9c06-19abf513b38d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5493b61f-cc9e-4cb5-877f-c9a32313d795"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("54dcf88a-3274-4438-a2d6-52af36b0e962"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("567cf9ef-45f0-4149-b8c1-75fa6b388238"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5730f457-a3a7-4595-8a47-16935efda370"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5740d3b5-789f-4c2a-be6c-49c70d9cf2e6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5768822e-4f8e-4ec2-ba90-1f9eaebb39d5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("583f4022-2718-4745-80d8-90bd3d2832ac"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("58da4f22-944c-4def-8c6e-0c45007ed76f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("58fe2e13-37f8-47b2-990e-5c07c108ddb9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5989103a-9d9a-4a8e-be17-05046bcdd394"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("59929bf8-e529-4620-a3ae-1219026db195"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("59c1dac9-f2e0-4ccc-b76f-40dce5e4d924"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5a47c21c-38b3-4380-b6d7-d05593fd64cc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5a8484b5-c793-4cb2-b32a-6a1a317675fa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5a88ca5e-7bbe-4b63-9d15-54e458e9b1be"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5b4a0885-7f64-4aa9-984b-03ae9ef212ee"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5c043532-08c5-4d82-bdae-1cfa791fa57e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5c374715-0c0e-461b-a478-05d0bbeea4b7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5c7bb51c-7cc7-4f50-8607-b65092a7f676"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5ce3ddfb-f666-4882-93dd-3bb5875bd685"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5cfbd9e4-9948-4028-afb7-97e24f1f2881"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5cff13ee-fede-486f-aaad-df7db850236b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5d0c7fac-fa92-4993-a8a3-50e15a2440ee"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5d4a9982-4315-4b82-b896-da67b2ea35a6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5d6744cd-3297-4e01-8c90-26598acdb1d5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5dc9fb42-01c9-405a-b868-a036b57fa859"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5dfcc59c-1c94-4bd0-87ee-6dd7c38341c8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5f07a57e-c8cc-47d2-98a4-e24cb9b5d2c8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5f2f57e1-4a3d-487e-997b-d537dc794e60"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5f7e6a6e-8eac-40a5-ba6d-b92fe5d7095f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5faf29e9-5b36-49dd-b29c-81597373581b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5fd99ffa-f0bf-46ce-889f-881d5641874e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5fefe889-9ea9-4f38-be89-f5a93a99e82e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6015a505-0c46-4399-a0b6-611fcf2af4af"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("60312293-a0b6-43d6-a753-307c49a26cdb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("61757e93-e10e-4e7d-82ca-c70b18721723"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("61c0929c-bb50-4e1f-9bcc-f0f6e0ff8426"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("61c9fb36-4354-44ab-98e2-21b3daa417f0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6368ad81-b480-40f8-a841-33fd4319cee2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6393a77e-f90f-4ab1-8b42-2ee514543c72"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("63e34543-f273-4fd5-928c-982cf099dedf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("64552bf8-6baa-452f-b2b4-cecad9d9d6ef"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6482578d-6dc3-424d-b340-0668ea5d2710"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("648f9edf-f576-4380-a418-c1c129fa2ca3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6571a193-11dc-4eeb-99e2-07c79e9aed0c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("65aca5b8-6d6e-49a0-b7c9-9635675cd03f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("65c9e122-29ca-48a3-b01b-c2dd4bfd136f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("66b93a2f-62fd-4bd5-903e-c87f56026d39"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("66f02e8e-e8da-43a5-a070-579dea239020"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("673e8c6b-8a5e-4dad-a776-cba0c8b06239"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("676acc2d-bc6a-458d-ad64-20364b996d0e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("67d6f150-7a8f-49a4-a7ca-560d889f1c00"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6816be72-a560-4626-8494-5eaf4c7f5038"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("685ddc3e-d431-48f1-b0d7-6aa458491110"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("68d0d154-cb8f-4da3-a302-8b41329adc23"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6a131a0e-2d73-449a-922f-2834eb311a35"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6a3ed3cd-cb6f-4381-8788-d0632208ff81"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6b4e9905-914e-4df4-83a1-f6dc9662af0e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6c14042a-f320-44d3-b54c-2f321cc94d34"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6cfca0e6-9497-41d9-b3e0-df6a0939f66e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6d2289b3-778b-4387-8c42-da96f6c5f50d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6d3c1dbe-73d1-45f0-a012-3613eb3f3654"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6dd0d689-2b8d-433d-928d-16916d9a48bf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6df61eea-976a-4b99-97c3-1f9e7433a821"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6e28215e-39b2-4a20-98c9-47237d75fe07"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6e3a5f92-c6c3-4bf3-a7c2-e481b481e132"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6e4a90d8-f842-40e3-a874-1c3fc6194485"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6e679359-5ef2-4a39-8fdf-d87e7eef92a1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6f2e9d89-0e47-4fe5-9cb1-db290dac8666"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6f462972-3e16-43d3-9ec2-de261f6de335"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("70b63f01-f025-421a-86b3-97d5c6876957"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("70c11539-417d-4542-b5d0-ef80260bc636"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("70c70c75-baa3-494a-9643-3583dccb0896"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("70d72d5e-a6c0-4b6a-8b47-016959994273"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("70df4d29-0b0e-41a8-89c2-df7311f3344b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("71c6bf75-47f9-4cd3-952e-e1472ebaf962"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7232ee51-3fdc-4c0e-b9d0-e1b04fd919d8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7242890d-a8e6-43a0-86f5-a89b7136471f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("72e41ff8-89b8-44e2-8794-48629bb0c49a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("72e4dc73-678b-4069-8019-e51c9a87c11d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("73011916-2f52-47d9-a258-ab9d0b818605"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("73850616-68b9-47bb-9dee-28c2fd5a7d90"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("739ccdbe-60f4-4480-a31a-d668043eea9c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("73b31d19-c7f9-49ea-bbcb-6edcf7072ded"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("73bbea36-7a4f-4fe2-9de1-7117dbe8d589"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("73f5e6a5-d41c-4654-aa54-ae2cfbd63f28"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("74ca9de5-58eb-4381-853a-7f6b08ca3d65"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("753d4a98-8695-4231-9e36-7bf363bbc606"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("756c366c-7f87-4901-a55c-32df03c36a05"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7585f90e-d0fb-4aec-a2c4-9bf4a518ce46"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("763864f0-bcde-44d0-82f1-6a45b19885c0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("766c3375-2058-4238-b906-0727b7e5f011"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("77633148-93cf-4da3-8da5-d3346d98dc6f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("77a11a30-1a7c-419c-96e4-7320e87e9c65"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("783145d6-51bc-41c0-8e5d-3ad8ae701c47"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7910c57d-e649-4f6a-a54e-dc7f17b69ed5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("794f2673-6284-400c-ac31-abb52093744b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7997aebb-3178-4108-981b-4302812dbebd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("79d16e96-3aef-45c4-8fd5-96c13cc5ce2c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7a134675-70d8-453b-89da-513bf9831c81"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7a7078b6-1fa1-40b8-b704-fa822a66260c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7ac847f9-2b0d-4ab7-bf80-28578ef655b1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7b317af3-192d-43aa-ba45-9b695406e74d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7b661fc0-ab83-48ae-8c81-f1daffee11c6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7c166a10-cdd4-4700-ac09-8cbaf394df74"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7c3c988d-56d0-45ee-8a29-7c540c7a428c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7c9590a0-cd01-4db8-8944-fec9621184cb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7cf25cc7-b24b-4816-8d51-ec409ebcd15f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7d6677a4-5f58-48e7-94d7-31345b1cba8f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7e166a9e-824c-4956-ad8d-a3b3be6b4c44"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7e206e17-f1e2-4f12-91cb-bfc74133f5c2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7e36c4c1-6f0e-4045-a35d-2fafcb62f1dd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7e7a79aa-4725-478f-9c9d-90aea9818017"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7e8efaf6-c7a8-4145-9620-5b6e4f019407"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7ea4f613-346e-4b75-9f23-9d7966563073"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7ea67465-bb7e-4c8e-961f-0505a63a8db9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7ebc3413-a14b-4b18-a241-49ec61478a33"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7ec59973-ae21-4e91-8468-d3f95005404b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7ed72de1-b991-4159-b237-1bcef0f74fe6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7f1c844f-4be9-44ac-9ed5-32c104b3d1d7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7fa32134-c4c1-4e5c-af4d-e8304194fb86"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("807ce8c9-6762-4520-9588-3731f9011ba7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("808e8cfd-7851-4230-a1c2-e763c674bbb9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("80f7cec4-2785-43c2-8695-ab1a0b51ddb5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8120ba21-4d40-4374-ba0c-680150314812"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8177dbb9-7210-4e75-8868-93d9e327332a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("81f26090-1d71-404c-8c55-3c5002c85a55"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("822a2cbb-490f-4a36-aa6b-1fc6d9f6b049"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("823edeb0-7251-4003-af3e-aa09c7f38691"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("824b504b-ce8a-4067-839b-19cea6b743f3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("82c3238a-6ef4-47a2-b9a5-a5e49eac5213"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8324cfbe-c28a-47a3-af9f-d1a38585d7d1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("837acf5a-8702-4a5b-a61a-2fe3de03b685"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("83b2ef06-e732-4a40-990b-8bee15f9bbd6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("850ad6ac-b909-4ae4-a4c3-2ae82cf7c78e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("85ca8f16-0634-4e93-851a-83a824063cb2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("86269b34-f1af-49fa-98d2-aa9c643b3bb2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("863410f3-1c51-40c7-bf85-e9a7e2e0c747"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("863abcc8-00f9-4ad9-9cb4-ba757c94b915"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("864d0892-53f6-4e83-a3d4-9e367ba693a0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("86727526-b628-4188-8ec2-5c97c25c9a36"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("871d2a88-44e0-4613-b74b-a26cc78b7e1b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("882c12d5-8460-4e20-8ebd-8f03db964514"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("88daf1d6-41ec-43a7-a491-a19e3691d600"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("88e6b401-b702-4985-9f0b-50a1d00137ba"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("89953d42-4139-45df-8664-ae402799ecb4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8a830760-a8dc-428a-b9f0-6ddd634faa26"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8ac477d2-69d0-47e3-9f38-6a12db358b75"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8b3aad25-075c-4ba4-8e32-91513ad40e7b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8c516daf-4782-428a-9ae8-57f2d24c8dd9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8c68fcdc-1e9e-4c3e-9095-3e3f6c64e09b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8cf84232-ccf3-4934-ac4d-ac5595299f92"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8e6d7a3f-f9fc-4592-9f49-ecb7a6cc7679"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8e8334f4-c91d-4c7b-8d6c-563ac3df14a4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8f963b33-fc06-4893-998a-570739f0508f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8fc0dbae-b52d-46a7-8b74-575a020164ce"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8fdeea20-2e00-4825-95b9-dea9358d6273"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8fe0e5d3-5ef6-429e-b633-1b26dae8c81c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8ffbf37d-1a1c-4d3e-91ba-83047ecbbca4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("900079ff-39c0-4cbd-a13c-8d371f29a483"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9019aa97-c7be-4051-a96d-df20e76cfcb7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("90901dad-590e-4c4c-8e98-07e513a789b4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("90c52a83-4552-4f2b-a03e-fea87281209c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("911a1444-a733-4b03-af2e-0412caf01e8a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("914b597a-585c-4559-a7fa-75de24521ea2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("919d5f95-91a7-466d-951f-be427028dbc2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("91b9d90e-6b07-4f49-805d-b5895e26302d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("92365c54-c85c-41a3-9339-72e834187591"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("923944bd-2596-4284-bbc5-24d32ad2aa8c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("932c2e9f-d8a8-4272-93c8-35585a267478"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("934b1e91-f529-4e0b-8ff0-ebd4760a16f8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9361cbe1-d976-4a4e-bf92-4c2baf350954"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("939a8c27-a0da-40dc-a422-ebd2db6192e0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("93f1c95e-be9e-487d-985e-9e1a99e1eac9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("940c2ea9-0eab-4354-b8fa-bdcb3573dde7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("948386d5-467c-4eea-a89a-e37e25d084ca"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("94e9b1ca-a42c-4c80-9097-df6d507258b8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("953f3c02-66f1-45b2-8bde-82963525dd90"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("95c979f7-d434-4c9b-85da-8fb35dcaa9ce"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("95e8307c-6f4d-43dd-b6a3-7240df985cb5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9621407b-ca04-46eb-8fd6-e51800bf85b7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("96385b08-8ae5-4f2e-881c-546b30f96b8c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("969e6aab-7641-4402-a4c6-a6b3b7c0e562"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("96a23189-d2ec-4b5c-9e4e-5ec2af575cc2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("96d9869d-d78b-4e49-91f7-0be7945677d6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("96f4d902-18af-4927-bbac-0e20637b2b93"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("97278e1f-e245-462f-b336-fd824d144345"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9745aee7-b7ab-4fd1-83fe-38463e1ebf78"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9748a597-534b-49df-a3d9-af3dc2ca251f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("97b20e50-25d3-4ada-bd39-0374b3cfc53b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("98eee27a-843d-44ab-83bb-b4afe07187eb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("98f371f9-6be0-450f-8305-2ca1e75a5ace"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("98fd0c5b-b0c5-40cb-9156-2041206c26c6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9987ec64-8158-4538-83ed-1a4b7dd54e58"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("999c26a8-837d-4d2b-9158-184b7c8bdbab"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("99f1d145-4f5f-4f54-8811-b9505e85955c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9ade267e-74e7-4197-9975-a380342869c2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9aed57f3-4589-4fd3-970c-a3f56e2f86f7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9b2d1a16-4c40-4268-a6ac-7e736ea5ae6f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9b2fba46-ea3a-4a8a-b0ea-24fc7669c953"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9b8e4567-9859-493b-ac4b-7bbaa258c258"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9b90052b-ba31-478a-860c-74d38d5667a1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9b986520-7227-4dd5-be22-0be6d21d905e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9c15760f-2357-443e-9c12-dc1d8b2261ef"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9c772ada-e0c8-47b1-aef0-486caf9a3bb2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9cc9bbd8-3e15-4076-bd98-62c9f0fc30ce"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9d2d1543-f2a1-4726-a029-4d6dd232f792"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9d3c4034-7ab7-4fbc-9796-4bd0c26ae6dd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9da17d6b-d284-43b5-8d52-36bab3e9f4b9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9dd63b28-5caa-4585-a880-ba7ee54cbbf8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9e5f8d34-18a3-436e-8e05-07f4d94174b0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9f6d946c-e078-41ce-b97d-1165bdc4abf3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9fb38536-8483-4e04-877c-528eb22a46f6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9fbfe142-f9ff-4dfb-a674-15ce8fb44a02"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9fcd615c-3abc-4c77-9972-f84fcd35dfc2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9fd0a1d0-b226-48b5-b8b3-b49c9c5fc313"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9ff1b10e-b67d-4441-bc4b-b571b8045e66"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a01ddb07-e1eb-4cc4-a464-d6331bcba2c5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a0b15748-2505-43a5-ab08-771d5cc2e7aa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a0e96a92-a60a-4b16-869a-629d9151b36d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a12a2461-d365-4ba6-b853-9b1ac0bc0d1d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a12a32d5-3549-46ba-9ef5-d9ddca0f7177"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a1b48cc8-6e3f-4943-80d3-d98135b8835c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a1f3eb06-6871-4be9-88ce-45fa505bf1fc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a34e304b-d6fb-4e74-8d4a-5d6d2790c320"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a3800b3a-8d62-453d-bb45-8273bac0d8d6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a49dd4e9-5adb-47e2-9550-1791c8238db4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a515f0c2-e2e4-431e-a636-09af22ccefed"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a56118b9-dfc9-4203-b563-f43aaca95fdc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a5995779-f16b-454f-8013-6ad0641e38f0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a5ac4c7d-0849-4857-8ba4-765234775754"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a5b33100-128c-43f7-bb39-653d291f918c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a5df050a-ed11-4d5e-ae6d-141b8628edb9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a6d7ba56-8106-4251-947b-d21545a5d224"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a6dc74dc-5104-4eef-bddf-48d538fe313c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a7615727-d2f0-416e-a815-28430df4e2c6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a77f6c6a-0c10-469b-8c3a-4373933125fe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a81bdae8-311a-4719-b1ac-fcc555f56b08"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a852f2d5-2a7d-4a02-8a5d-94681853d295"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a881d7bc-963a-4022-9da0-b9821a8f6d4b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a956aa05-e097-4bad-a76f-4e4f86a17fa0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a96a5d93-6308-4965-9b60-9a8573bd7ebe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aa723e1e-fcac-4cd4-8d28-28e31e25bb3b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aac809e2-f0df-4655-9c0b-62cd0880efd8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aace1dd3-f803-40b5-ae53-168f8ccbab4a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aafc168d-ed57-44be-b38f-b7c34e364e4e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ac24c874-e5e0-42c1-953f-4219819644a2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("acd4f354-7cdc-428f-acc8-50a20d125677"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ad2bf64c-05f1-4c7b-a938-715150d8cfa1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ad3c2039-586f-4925-a85f-55f70b29f640"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ae4c20a4-6061-413f-8487-662026532158"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aeb21413-463e-42b9-a870-b57fbdb73c94"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("af0b78d1-ddaf-494c-b603-7fda8fe88fd2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("af405ac9-4ab6-4ca8-ae8d-89be1d33f2d9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("af83d0f7-4d98-49a3-b9b2-290a5581ec09"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("afb70d21-4859-4ab6-bfb7-078fab49307e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b00190cf-c56c-4290-83c6-1bdbae1a4e07"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b0bc939b-b832-455b-8473-a2e54b8bdbe4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b11cae9f-6fb5-43a4-bdc3-ba5f2fc6b08b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b1620cd3-249f-44fa-980c-35ce275535e7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b1b9158f-dc8a-4dc9-bf61-2363994e1dd2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b2ee35ca-1f1a-49d8-a065-e75521e9769a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b322431e-49f2-4d8c-9a74-e86e53687bc6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b33de865-4922-48df-ba22-2f74e82329e8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b35bcdf7-c605-4c9d-af7d-7d3a8f5a1931"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b3aa4674-4f26-4abe-b704-eb9b7c85b21d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b4058141-f8cb-4085-ad54-0979db2a26cd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b42ae021-60df-4df5-860d-4c8f6f72bdb4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b46fca26-757b-4fd8-a9ab-f5bb84cf3072"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b4e2ad32-4444-48d7-9813-1c099b4b5fdd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b502e74a-84fe-4cc5-a5b2-5b2010033969"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b5509260-70d8-4636-aa64-a31531d85a79"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b5b41489-afca-436e-a56b-611e84008dd8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b5dc2909-4fce-4f31-9ed1-abd66c19ddf4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b6049df0-bddc-476d-ab52-b516a70d7626"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b6598c81-bc0f-40bb-8d52-5a6295a681ed"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b8166d1a-7465-477b-984c-e44694ad9c44"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b8dedd01-7af2-4e48-8eb7-09eff766174c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b8f68258-9706-4ab4-920c-d8eaba02ef5d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b923d9c5-3607-4096-b123-6c79ee6524a9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b9b12d61-0c1d-4e35-a909-07184aab395c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b9f538b5-3945-4bc6-bd53-3e74ca20ca8b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ba26baeb-82cf-4f52-8c0b-f40e4c7fe037"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ba2c9953-bd24-4747-9701-b754e9c95608"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ba670332-fc1c-411c-bac5-cf54a3a06866"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bb91f56b-51fa-41cb-9849-08ec88f78e0b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bbb7e239-debb-45c0-a479-b4870dbebe0a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bbc73028-8762-4542-883f-fa881cbfdd25"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bbe8387b-5f9a-462b-9936-6855c83aae21"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bc63ba76-4d5d-498d-abf9-342f234a58b4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bd15fdd8-9420-48bb-8799-0b55c958580e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bd438b96-407b-4318-ba11-34168928393c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bd5fe32c-cd54-4a45-81cd-5f49d30346d0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bda26790-3221-41d3-a031-2ea600960a40"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bdad87ba-e3f4-4330-a053-85a3fa924a64"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bdaf81d0-5f29-474d-8f0c-4263a6b97fab"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bdd81c8b-5cff-4759-b23e-cb4831ce4d48"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bf35a858-907d-4c1c-93c7-02636e0e23d9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bf720365-c638-4bbd-b0ef-cdf310e43e71"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bfe74407-deb6-4bab-836a-f65e7988580f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c01bad24-90b8-43ee-80ab-14797f83cf9f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c0a3d37c-045a-46e0-b132-f8f21d548fae"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c0c535d8-8f87-410c-a334-f4e227ee4370"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c0db8e20-6dd8-4545-9440-2703ef880b7b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c12163ff-5bba-44a0-bf2e-e18e8cb38562"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c2718c64-ddb9-43b0-b0a1-6dc1fa4ffe56"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c340e976-092c-492b-befd-ac16d94fdfe8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c34b84f2-e6ba-4111-be08-208e49fe082a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c3e4a708-d7ea-4a80-9ffe-08b6523cb01e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c47c31e4-c193-4b68-80af-1ed90c529c7e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c4df4fa7-dd62-4afb-a287-737f869a6646"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c535f715-80b2-437c-8d2d-2a1e67fd8c4a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c5aea7a6-dc56-4e15-9fde-e3ac415f0c62"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c5c9d005-430e-441b-af47-45be9c5d2012"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c5d987dd-9a3e-4811-95cf-3fd0f239ab31"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c6c7476f-3821-42cc-b93b-bc1c10c8c124"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c6f1f137-3735-4e7e-af25-281b85d42cd1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c72383dc-0d4d-489f-8ffe-19be8fdb595c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c7ef9ec0-08e0-4864-9029-81e04d980549"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c7f15b4d-6e85-4e97-a59d-f1158592b7a1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c8043953-48ad-4bf8-9650-7cfa00145477"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c8dfff70-c072-4abe-9f20-8594ca285cbf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c938678f-63af-4b87-b631-6f4a7477a3b5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c9672ef9-d615-45c6-9099-9409546260d9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c970e119-2c86-4464-acc9-076c8fbebbb0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c98936af-0225-478b-86d4-e5be538947b5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c99e85ea-f72b-40e1-9e53-ab7f799031bb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c9fc4d3e-82e0-4f00-a9b9-895e1d16d0e2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ca3682cf-bc00-401f-8338-6bb0ff2a04a0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ca4fd9a2-35ec-4eba-98f2-467619816de5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("caf7e11e-b489-4ebb-a50b-d6dab8ac29c1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cb36714a-a874-4712-9380-f7eb62a4ed8c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cb80dff4-4a06-4137-9975-a483cca119b6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cbdda22d-cd7b-4013-8d75-6e88da0932ee"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cc4d5bcd-365c-43cb-b6b6-533dc39c7574"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cc6f268b-b161-417a-9bee-7a3d68082e2e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cdf775ef-c7ef-418d-ad23-c3aa7f7f89b7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ce1e671f-d70a-41a2-9c64-7a2793463d37"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ce66a6c2-a965-4646-a474-cbf465079549"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ceaf97d4-0561-4eb5-8df3-36990fa8116b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cefd6c73-9b7f-4fce-b7a7-972969da48c7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d03da7e1-cdbf-40bb-b571-ae10b0d19813"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d0c8e58f-9f29-4c5f-9768-15ce43665212"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d10df3a3-fc94-49d3-91f0-57906f62e6ea"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d14c129c-1a88-4e47-a989-935b0ad96910"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d158b533-ab5d-47b6-8418-0f283538b0ba"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d1bac6b5-3f0a-4573-99fe-53f6f0c48738"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d1da0cce-6021-41a5-9866-a62318cae6e9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d245c508-c592-40d3-96b1-97ff68353b37"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d24dd601-bf98-49d3-b278-a01459802645"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d25464ec-0405-4e58-a5f8-7b2a4f1e3dde"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d2c4d358-d917-41ac-8b39-f7edb76f5991"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d2cfd22b-51a5-47c7-94b9-80bf9f6dfdc5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d33dafe8-6690-44a4-84de-1ae4bcc89da8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d3883e3f-d060-4692-af83-1c2cbb369af5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d40377b2-7e50-4d62-babd-578c01860197"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d44cdf0b-a70f-4f47-85cd-a00503c41041"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d537786a-1a2c-4358-b245-77bc763ea465"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d53ee1a9-77c0-4375-9f1a-3c99a59b4454"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d5e75409-72f0-4012-a176-46eeb3bec5ad"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d6547b6e-6e32-4091-bf64-7806d23e7143"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d6586568-4a00-4564-92bd-6fa7e40aebd1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d6d83144-5711-46d6-9f2e-4b180687b0d7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d6e4b97c-2f9d-4c66-9aef-63af4349c17d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d705ad76-cc7e-4dc2-a110-f6d7575e57f0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d732cc04-98e3-4e1e-83f7-e302a2ba72c3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d74001c0-e236-411c-907f-ab64eadadb22"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d77173e4-c848-4929-8d77-2080ff0476f2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d7822926-edf1-4f7d-a630-37b607f67dc7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d78df715-ad5f-4476-ab86-8684adb8b43e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d7e4d1ac-bac1-439f-aceb-9b75807beb4e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d7ef033e-d3a4-4f5f-ae51-ac13bf1132b1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("da1d2bd9-0640-45a1-a749-e89b17234875"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("da216fe0-80f7-4ea6-90a3-c9b5885e5e92"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("da3dd9ad-c49d-4ea7-abcd-8552220fc384"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("da782c77-313f-4897-a4b1-4733260b75c2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dbec9fdb-5727-4fd2-b437-61bd87d26c87"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dcd55fee-6b70-4c98-988d-a828178ded6a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dcdd8817-99ef-4121-9aa5-ec73e142efc2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dd12c870-8608-4103-92e3-17afe32e0607"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dd18721e-3e90-4daa-b6c7-917ca60b730e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("de840116-899d-4137-b144-9cdae124986e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("df9fa1ae-20d9-4ba0-96e0-00cdeb84734f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dfc7901d-76ba-4b8f-967d-b8e7d79eb982"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e0432add-c5c1-4b3d-9628-6e4c317fbee2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e0433c31-df6f-4c3e-bec9-7d4f5cf4e313"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e053fd0c-fac4-468f-a0f6-d27d302683c6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e0a9a74d-a7fd-42f7-bb9b-0b260efa7fb0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e11f8c31-ea88-4548-bf0a-7984a643b27f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e226ba09-34e9-4ead-a818-534728f4d704"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e2557edd-155c-4660-9176-9b6c99eac2e7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e345b743-17af-44bd-b660-adf98cd0a5f8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e3985fd7-fd0d-4bf9-bcb1-fd9cd1346c15"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e3af7005-763c-4311-a7c5-c7cc9d11d434"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e3e68162-61d9-45ab-9b50-43accdbd135c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e4dc9998-c3e3-4c31-b164-fa6fc70bb961"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e5504b46-665e-49d3-92e7-fb70bdca635d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e5550249-0127-49ec-85b9-7e584948af5d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e5a1c197-5094-4859-a0b2-ca92ed7e1578"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e5e1b5a6-c001-4b59-b5b5-b8994c78e705"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e7362497-6681-475f-8ff7-5aa902c4f350"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e7496b17-d235-4808-b150-e8b92dbb27a3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e766756e-9c3b-4798-b655-be4e8e9a0c8c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e77dbc3a-a72a-4b11-a278-abb88da08f15"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e7d3b4cb-f0e8-49af-9c66-a96f37baeb6c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e848e544-3503-4e22-92d2-d8f4fceb5cec"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e8a7acdc-f3a6-429b-87d7-b35cfa114af9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e8d6d63a-f2ea-498c-9b38-59de8a11f7c2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e970a730-c0e7-40b5-81c8-dd476ea10be7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ea1271b1-d7f6-42b6-b75a-2238cfb3e875"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ea4b7836-91db-4c63-b02c-584415e906af"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ea5a9bcc-f6fc-45ee-8001-b130778ca8d0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eab85ea9-7db0-4fab-99eb-6c339812d992"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eaed1ab1-6699-401a-9dbc-7a28dd0051a7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ebe6d360-c1ac-4249-a98c-0d2046c4dce8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ec093221-1e7c-4e6b-a148-0d0da1f8233f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ec1a468a-e7d2-4254-aba6-0366c1a32d88"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ecbc7778-82ae-47c1-beeb-4b87b1854a82"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ed02a6da-47bf-4b93-9740-6a7650b3ae82"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ed29f44d-c006-425c-b720-a4ecf731b338"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("edc6ac08-f22e-4d2e-9335-76e23bf380bc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ee9e82c1-704c-4bf7-9f1a-20c8478338a9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eec01cc0-8d7b-4d86-a154-24e2863d67e6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ef3f6b78-edbf-49bd-86c5-54b5ce70fdf5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ef681f1d-add4-441f-8385-f3b79e2f6151"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ef8bbdb0-0a72-4fd7-8b7d-debded868146"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("efa495e8-4453-42a5-8cf6-e692d5bab21f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eff922d0-2847-40c0-b8e5-9d06a74bcd2c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f0677f2f-3353-4cd3-ad1c-ed90c326d65b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f07a3e58-1ace-4bed-858b-da26f06b3628"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f0a396c9-d3a6-425b-b8a8-a77114836887"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f0a809c9-31ee-4517-abd3-de705f700d11"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f0f45303-433d-49cf-9c58-5a1dac6452a2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f22ba482-93e1-47ad-9a58-27dddeed7bfa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f2c6f533-68f6-4909-9e5b-d6fe9289435a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f44b0a9f-504a-4fc4-a5f3-bb1e726450c6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f5ca9146-39cd-461f-9815-6233f4383c71"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f623a134-17df-4eb3-8baf-1a4053d403e9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f67a4e72-c5f5-4e3f-9c88-4d88ddaff44a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f6f607af-0c6b-4aa7-bf2e-839a5ab9f892"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f7302380-7641-4b22-a48c-fe29397789c7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f772580b-aa13-48b1-a6cd-4d5f26079d02"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f773eceb-0f96-493f-a2b9-38124cd3bd00"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f78ca78b-cf5a-487e-a5b8-a0012dc18174"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f79dd4d1-02c1-4b8b-b9f2-4bb53253cd1d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f7a16b88-58de-48fd-a835-06f83ed18af2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f8fe4dd3-616d-4965-ba75-acf431664c18"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f904f5f2-22cd-4399-a488-ba141cabab2b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f930d6da-50fc-4d0a-a048-1a8bcaebf760"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f9a6dc08-4a23-4fee-940b-b856bb6ee2e8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f9a802c5-9173-4867-857a-784b251a593b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f9a8c310-83b0-4342-86b0-09ff06f5da23"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fa6e65d8-2e4a-4412-b54a-7dd535a32867"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fb44c236-80e3-4df9-89ea-938fd0e990e3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fc2b2e73-c650-40c3-b04f-9989caf0f7a9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fd0128b8-4242-454c-a70d-968f7b9337cc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fd5783a7-ea5d-4992-a0b4-2ab799e7fa65"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fd81ca34-a97b-473d-81d2-a8813d8236f5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fd82240e-d28d-4b3c-a1b0-878a4b0afc4a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fdb60f3d-cdc5-4078-a7b2-3856f8ab640c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fdbc91e2-7b8c-40c7-88fe-70414acb5a6a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fe3569ca-0b2c-4386-947d-a0c83927120d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fe55e2c8-5b84-4cc6-ad25-6ea6286db4a2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fed2b96f-3231-4dae-abb3-f37ccc8a9cc7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ff22e76a-9379-4bd3-8d2c-f1af1b98392c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ffdddeb4-4a04-4b50-b170-8ea8142e35bb"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("0a7a6910-f16e-43dd-9633-d56a985fbee3"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("32ce459b-99a9-4010-9360-d900347dd46d"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("4906a70b-e15e-47b0-9e21-5815337c7a1e"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("4aa38609-3c30-4feb-8944-01f9a31e1d89"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("50964b1c-c9b6-4ee4-ac52-4e91a32f2d9c"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("5e5a62f1-1de6-4eb2-9092-bd7f88920228"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("627e6039-faef-4b9f-b188-8ebe4dff6079"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("9bbbd7f5-1228-4e8b-8446-956422d179c2"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("bb8f43e1-072b-46e3-8ba7-eadc0ec795de"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("f6633d33-35b3-4cea-afe9-974150ece111"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("343926da-0b8e-4533-8722-920a8a941e3a"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("4a1c25ae-b923-4835-928d-ec8416c1e757"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("4b5ad2d8-d8d4-4051-99b0-ed1faca96863"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("633e1a42-df90-4e5a-a506-b8048118d742"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("7714f7f7-a416-486b-a53c-72709f8a4eaa"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("79a85ab2-ce3c-4254-8f29-0d4bbf374fc9"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("8391de52-cdf1-4b03-ab3f-ce7a734b1d0c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("9c9865de-7308-4084-a7c4-b8895859d773"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a7bb9000-3c94-41ca-8459-a2f1ccbb4bd7"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("c0bdaf00-0d02-4e06-8ec2-fdd46a4cdb9a"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("c723d712-bb24-41c2-ba2d-7b11501e4ed6"));

            migrationBuilder.RenameTable(
                name: "StudentTeacher",
                newName: "StudentTeachers");

            migrationBuilder.RenameTable(
                name: "ParentStudent",
                newName: "ParentStudents");

            migrationBuilder.RenameTable(
                name: "ClassroomTeacher",
                newName: "ClassroomTeachers");

            migrationBuilder.RenameTable(
                name: "ClassroomMainCourse",
                newName: "ClassroomMainCourses");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTeacher_TeacherId",
                table: "StudentTeachers",
                newName: "IX_StudentTeachers_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_ParentStudent_StudentId",
                table: "ParentStudents",
                newName: "IX_ParentStudents_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassroomTeacher_TeacherId",
                table: "ClassroomTeachers",
                newName: "IX_ClassroomTeachers_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassroomMainCourse_MainCourseId",
                table: "ClassroomMainCourses",
                newName: "IX_ClassroomMainCourses_MainCourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentTeachers",
                table: "StudentTeachers",
                columns: new[] { "StudentId", "TeacherId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParentStudents",
                table: "ParentStudents",
                columns: new[] { "ParentId", "StudentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassroomTeachers",
                table: "ClassroomTeachers",
                columns: new[] { "ClassroomId", "TeacherId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassroomMainCourses",
                table: "ClassroomMainCourses",
                columns: new[] { "ClassroomId", "MainCourseId" });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "SemesterId", "StudentId", "Type", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("00fd1fc4-df32-4559-a346-c2784e3b58bc"), "Computer48", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1667), "192.168.1.50", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null },
                    { new Guid("0b1b4b9a-fbd8-4114-9ada-82418a48bd3f"), "Computer36", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1616), "192.168.1.99", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("0c308948-176d-4c7f-aa53-e20e62ff9b5d"), "Computer17", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1528), "192.168.1.37", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("0e3f14f6-3c82-47ce-a03e-b0e794ad64c0"), "Computer39", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1629), "192.168.1.57", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("153430f2-7a1d-4708-9f62-61886108c45e"), "Computer3", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1464), "192.168.1.12", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("1610a6d1-ae4e-49db-b2f8-f0e7844385de"), "Computer60", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1724), "192.168.1.89", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("17380b9b-e0df-4459-90b5-15eba0f2ba5d"), "Computer26", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1573), "192.168.1.45", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null },
                    { new Guid("175834fe-7c99-4970-b446-c2e8011a8054"), "Computer31", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1595), "192.168.1.40", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null },
                    { new Guid("193ad920-4870-437b-8e40-8d6bd3db58c9"), "Computer40", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1634), "192.168.1.2", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null },
                    { new Guid("20fe5e20-704e-4cc3-8e07-c2e81f9b3308"), "Computer34", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1608), "192.168.1.89", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null },
                    { new Guid("27eeabe3-06f3-47c3-bea8-54eb4854262a"), "Computer32", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1599), "192.168.1.43", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("2fb1d50f-5c20-4c27-9ad4-ff6a2630fa1a"), "Computer56", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1708), "192.168.1.73", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null },
                    { new Guid("355f2be1-e78a-410b-8da6-7dc066151613"), "Computer33", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1603), "192.168.1.49", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null },
                    { new Guid("3703c4b6-49d9-4026-aef9-f3a9242a7f20"), "Computer12", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1505), "192.168.1.63", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("38f9adc4-da0a-4516-a021-5d9ec40ae22e"), "Computer10", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1497), "192.168.1.6", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("3dd0b1cb-d31a-43b6-aff9-a4ed00e4a21d"), "Computer16", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1524), "192.168.1.27", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null },
                    { new Guid("42fa7986-6309-4637-a847-ad85d8600ba9"), "Computer9", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1492), "192.168.1.48", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null },
                    { new Guid("4307566a-27f4-4c0f-bd23-cd01419673c8"), "Computer35", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1612), "192.168.1.69", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("4b3118aa-2fed-4478-b02b-030992ed9e80"), "Computer44", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1650), "192.168.1.83", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null },
                    { new Guid("507f4c27-11d0-4648-a2bb-baa435a013ee"), "Computer28", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1581), "192.168.1.45", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null },
                    { new Guid("5203b6f7-01e5-4f23-b993-99f8b24c61b3"), "Computer25", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1569), "192.168.1.75", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null },
                    { new Guid("57c6f419-e885-4292-a378-8875df83067d"), "Computer38", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1624), "192.168.1.24", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null },
                    { new Guid("5a1e701e-e363-4f02-b844-43dfd372b57c"), "Computer45", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1654), "192.168.1.48", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("5b9aabb2-52f6-4fba-8a77-8264afcdd854"), "Computer5", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1472), "192.168.1.23", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null },
                    { new Guid("645628d1-de1a-45b5-8979-916628db5268"), "Computer27", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1577), "192.168.1.25", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("6c1f6d7e-064e-43a1-92b0-5cd9568b7e63"), "Computer23", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1561), "192.168.1.2", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null },
                    { new Guid("6c303839-d9a6-499a-8c36-13fac8dbc6ef"), "Computer18", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1533), "192.168.1.11", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null },
                    { new Guid("6c93fa18-1b18-41fa-8b24-57821848bd3a"), "Computer4", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1468), "192.168.1.72", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("6ff0c7c4-8d24-4c91-b39e-3883d43a14a6"), "Computer41", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1638), "192.168.1.35", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null },
                    { new Guid("6ff57482-267a-46fc-9821-9711776bbfec"), "Computer51", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1679), "192.168.1.76", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null },
                    { new Guid("743d70c4-e627-45f6-8102-7f7e67cf7426"), "Computer50", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1675), "192.168.1.44", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null },
                    { new Guid("77adba9c-6a16-44b8-a22c-ab735bfbfb83"), "Computer54", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1698), "192.168.1.60", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("81565a02-c64a-4050-b3e9-b83642814b09"), "Computer47", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1663), "192.168.1.6", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null },
                    { new Guid("88343907-458d-4cba-8242-736b2eac5321"), "Computer49", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1671), "192.168.1.14", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("89673165-415b-4ef2-86d1-09bd603b9b99"), "Computer37", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1620), "192.168.1.50", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("8a45ef2d-0758-4b8c-a179-4ed63006f097"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1430), "192.168.1.57", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null },
                    { new Guid("909ade28-2504-4d1a-a84d-aca0f7619d53"), "Computer7", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1484), "192.168.1.68", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("976a8bfe-91cd-4eeb-b494-3180709c707a"), "Computer15", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1520), "192.168.1.23", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null },
                    { new Guid("9905949c-2e2b-4e35-9506-442b62c86250"), "Computer14", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1514), "192.168.1.37", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("9953611a-e537-4c59-bd63-a870ca592940"), "Computer59", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1720), "192.168.1.14", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("9d75937e-45e2-469d-8bc6-cdc3934c3f5e"), "Computer19", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1537), "192.168.1.52", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("a345665b-470c-4509-b4b0-b403fb9db979"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1460), "192.168.1.71", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("a77809ba-88d9-44dd-a170-a83801f00faf"), "Computer53", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1694), "192.168.1.51", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null },
                    { new Guid("b026b295-4163-42ad-802b-cdd33f260a95"), "Computer55", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1704), "192.168.1.85", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("b0b1a452-9a62-42d3-8b3f-657f195004ac"), "Computer13", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1510), "192.168.1.84", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null },
                    { new Guid("bddc4ba6-507d-4f27-a215-b82287d630b1"), "Computer43", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1646), "192.168.1.20", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("bea1a88e-c9db-4e4d-803a-45d76c0220a3"), "Computer22", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1549), "192.168.1.32", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null },
                    { new Guid("c2a84ed0-ab19-421e-842f-8d1c5ed03821"), "Computer57", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1712), "192.168.1.47", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null },
                    { new Guid("d33fe51b-e66d-4d1a-a82d-3b1a9bb80870"), "Computer29", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1585), "192.168.1.96", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null },
                    { new Guid("d8dd3ded-7db3-4244-8be0-56d6caee75c5"), "Computer21", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1545), "192.168.1.41", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("d8e8ff9b-2a31-4aae-a599-c680f188bfb0"), "Computer6", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1477), "192.168.1.4", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("dd64b2b6-0ba8-4f72-b60b-963a28a517fd"), "Computer42", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1642), "192.168.1.98", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null },
                    { new Guid("e4b809dc-0411-4104-9bae-cf53a1a69e5b"), "Computer20", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1541), "192.168.1.43", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null },
                    { new Guid("e7fc7d6d-1aac-4e28-8848-63da3c19a9e7"), "Computer11", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1501), "192.168.1.80", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null },
                    { new Guid("eebeb643-4342-488c-91a2-d3a6904c55c9"), "Computer8", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1488), "192.168.1.20", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null },
                    { new Guid("f1922319-e724-46fb-87e2-49d4be57f9b9"), "Computer30", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1589), "192.168.1.40", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null },
                    { new Guid("f3f9a646-9fd2-4905-8864-0d1f8e5b0b2d"), "Computer46", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1658), "192.168.1.36", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("f9440256-e7e6-4c21-b131-bcd0bfb333eb"), "Computer58", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1716), "192.168.1.57", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("fad61031-1b7b-4f11-9b03-384ff1cc9f14"), "Computer24", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1565), "192.168.1.75", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null },
                    { new Guid("fcd82280-a053-4184-95e0-a4624b52aebe"), "Computer52", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(1683), "192.168.1.83", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "AttendanceDate", "AttendanceStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("00a346fc-2e07-4725-a690-6803ec170780"), new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer4", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2653), "192.168.1.1", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("013c1bbc-cceb-4f6b-b457-5a19eaa062f4"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer33", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2839), "192.168.1.94", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("0143b903-b64f-45f2-9cb3-3e49d042a0e8"), new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer17", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2747), "192.168.1.87", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("149b1a9d-9f80-4be0-be4e-48d60ed41ac3"), new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer19", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2763), "192.168.1.15", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("25fbdb7f-9283-4f06-993e-704236a2eb62"), new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2621), "192.168.1.41", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("26f534ee-6c80-4438-bdee-84a17b0ccb58"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer16", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2730), "192.168.1.62", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("2e249717-0df0-4e50-b5c5-fe4e3af0bc21"), new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer36", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2858), "192.168.1.46", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("32703f9e-ca0f-4ea8-8ef5-05453d16c168"), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer22", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2780), "192.168.1.74", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("3322b773-6f30-47ce-918a-feae340ba04f"), new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer12", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2699), "192.168.1.95", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("343ab01a-2263-4fc9-95f2-c0a71890390d"), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer8", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2677), "192.168.1.17", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("4ccebd5f-eb38-48ba-a3ee-9d7ae458ab89"), new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer27", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2806), "192.168.1.60", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("4d557f27-49bd-416c-afc2-fae1fe5a5d88"), new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer30", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2821), "192.168.1.91", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("558c2a24-b00d-4813-a2cf-417d10279172"), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2635), "192.168.1.24", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("5f18ad86-ad69-4d82-bdd6-c48abdffe3d4"), new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer7", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2670), "192.168.1.23", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("6d228ced-1826-497c-b875-2483222df0da"), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer32", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2833), "192.168.1.47", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("6d4a3863-901a-424c-8413-2093f48fbd17"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer34", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2847), "192.168.1.4", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("7153b3f9-f583-4d81-b15c-c0e1762bb1a2"), new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer11", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2693), "192.168.1.54", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7b12011c-aa5c-4a9e-889b-8bf0f0f9c04e"), new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer26", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2801), "192.168.1.81", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("7bafd3b7-f735-4196-9edf-52328072ea81"), new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer23", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2785), "192.168.1.18", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("7df04418-26e6-4b56-a45e-42551abdb31f"), new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer21", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2774), "192.168.1.96", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("7eea1f6c-3d6f-46bc-85db-769bb78fddac"), new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer31", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2827), "192.168.1.93", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("824d0004-b37f-4c76-9496-9a14ec357fbe"), new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer3", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2646), "192.168.1.13", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("82ae1eb4-34a0-4134-b54b-6a2bbfba73e2"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer14", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2712), "192.168.1.4", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("85ec9c7b-b05f-47d2-a487-583c80bb5096"), new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer9", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2683), "192.168.1.23", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("8ab1a7c1-a4fb-4bb1-9ccb-fc4f80d1edb3"), new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer28", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2810), "192.168.1.73", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("8be08864-8ada-4bd9-a766-3ed8d51b3200"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer15", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2718), "192.168.1.51", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("8f427456-2575-4176-aaa9-ff02e8f6e408"), new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer29", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2815), "192.168.1.46", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("96f7da8c-2647-4566-9d1a-52c208c031f0"), new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer20", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2768), "192.168.1.71", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("a712136d-c442-421b-b499-fd7dbef5a053"), new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer35", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2853), "192.168.1.17", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ac08f84b-6c15-4142-a1be-7b898bdf1bb0"), new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer18", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2754), "192.168.1.98", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("b43cf769-8bb2-4873-a748-967688323282"), new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer5", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2658), "192.168.1.30", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("c2518e03-dbcb-40ca-99cd-fe76bbd146c4"), new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer6", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2663), "192.168.1.17", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c4fdfcd8-d9cb-40ef-b91c-11e0393b2806"), new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2641), "192.168.1.71", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("f511c8ea-802f-4c30-a95b-29228bf13d3d"), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer25", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2797), "192.168.1.68", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f56f69db-41f6-42cf-994c-644ee6d63f59"), new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer24", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2791), "192.168.1.77", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f69f5c22-b364-4df5-827f-80efa2eaf93c"), new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer13", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2706), "192.168.1.64", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("fdacf26b-63d7-4d05-b3f3-6fe5682c6ff6"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer10", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(2689), "192.168.1.80", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.InsertData(
                table: "DiscontinuedStudents",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "StudentId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("152257ab-0c6c-4d19-b325-fc796ae1aee9"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(3887), "192.168.1.10", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), null, null, null },
                    { new Guid("a5a4a0fc-feba-44c3-9343-6c56a6f5a64a"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(3902), "192.168.1.79", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ExamNumber", "Score", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("006a4e1d-d0e8-4c1d-b0b3-e3df71415c3c"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7260), "192.168.1.25", (byte)3, 62.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("00872897-31b2-4487-a184-8a54fcd410f6"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6062), "192.168.1.21", (byte)2, 92.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("00a26148-830d-4df2-acb3-2ff95582302c"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6313), "192.168.1.49", (byte)2, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("00a9c707-3eec-4c76-a1e5-28e4a79a12be"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4924), "192.168.1.75", (byte)1, 21.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("0127574d-feac-411b-89dc-aaf296a162ec"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7205), "192.168.1.7", (byte)3, 45.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("019ab708-8029-48b9-a6af-0af36234ecd5"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7273), "192.168.1.47", (byte)3, 18.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("01cefa0f-1f72-46ee-845c-61b99b08a210"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4694), "192.168.1.60", (byte)1, 66.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("03e39bb3-a480-4198-a23e-4b69304d9d05"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4954), "192.168.1.18", (byte)1, 73.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("0438c069-4f8d-4eec-944f-43c4cd755130"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7629), "192.168.1.75", (byte)3, 7.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("04535d0a-98d4-494c-85c7-f790812cf79f"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4811), "192.168.1.57", (byte)1, 25.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("04572dcf-df0c-43d2-92aa-177b9d97cd9f"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7191), "192.168.1.35", (byte)3, 59.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("0458ec5f-43e3-49ea-a8b5-61ae0c188714"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5587), "192.168.1.32", (byte)2, 24.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("050483b6-497c-4ef9-8330-ab247bdf82eb"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6377), "192.168.1.88", (byte)2, 97.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("05832014-75b2-4b5e-9c12-a1c45d9244e2"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6552), "192.168.1.46", (byte)2, 98.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("0592b57e-1f4b-48ad-8244-53c548382ec1"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5047), "192.168.1.45", (byte)1, 24.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("05b43a57-310c-4a9f-8124-710b3394308d"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6428), "192.168.1.13", (byte)2, 82.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("06c4694c-95cd-48ef-acd7-db90203d4b0c"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6123), "192.168.1.35", (byte)2, 4.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("074c95ad-cca1-473e-bcde-f77f0ef5d0e9"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6624), "192.168.1.50", (byte)3, 76.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("08646adc-e12b-47e2-9bfe-55c840311252"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6751), "192.168.1.38", (byte)3, 31.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("0887ccc8-0657-4472-97c4-da0960992100"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4764), "192.168.1.11", (byte)1, 77.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0956adb4-1556-4303-af98-916353ae319a"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5390), "192.168.1.38", (byte)1, 10.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("09c82f95-7408-4fe1-ad5b-6a758ac00bff"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7344), "192.168.1.57", (byte)3, 61.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("09f16dd1-daf4-4add-9b80-bf65f82ff720"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7373), "192.168.1.74", (byte)3, 45.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("09fa198c-0435-439c-9296-cace890a26f8"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6851), "192.168.1.82", (byte)3, 86.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0a1ebece-2b66-402b-b43f-6ff7d23a48f4"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5322), "192.168.1.5", (byte)1, 55.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("0a806dfb-27e1-4a03-86c9-487c743c29ac"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4988), "192.168.1.73", (byte)1, 7.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("0b7c0275-eea2-44c3-a41e-6acfcd97cafc"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7531), "192.168.1.49", (byte)3, 3.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0ba3fcd8-4658-4fbf-bb53-56eea892b248"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5310), "192.168.1.33", (byte)1, 79.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("0bc24d4b-4357-4ded-87bc-d070b953630a"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4460), "192.168.1.8", (byte)1, 60.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("0ca80336-5c27-4acb-b396-a39d184e560d"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5103), "192.168.1.77", (byte)1, 29.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("0d3d2fcf-e35c-4de6-867d-5687d40d5a67"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5825), "192.168.1.97", (byte)2, 81.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("0d5cd7e2-fe1c-44af-871e-ac5fca7e5861"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6299), "192.168.1.73", (byte)2, 30.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0ddb33b3-2541-4b14-9e73-4d0e3a30d36f"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6199), "192.168.1.5", (byte)2, 22.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("0de9a8cc-8661-40cc-bd70-59d6ec4af5b1"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5599), "192.168.1.6", (byte)2, 4.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("0ef11839-42c4-44e9-ab5e-458cb049a1ed"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4583), "192.168.1.54", (byte)1, 96.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0f5f1a2b-1f8f-4745-b100-14ff644044b9"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6283), "192.168.1.68", (byte)2, 20.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("0f879887-f5d0-4ed9-a7a2-943df0305834"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6877), "192.168.1.23", (byte)3, 3.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("0fe3db3b-60aa-44c6-93b4-3d11f6e395a1"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4756), "192.168.1.10", (byte)1, 20.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("1069c804-d7a5-447f-9c54-5a2ba87aa1a2"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6796), "192.168.1.27", (byte)3, 2.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("1198a34c-521f-4d1a-9214-8f28ede897ba"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7482), "192.168.1.26", (byte)3, 63.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("11e8b829-856f-465d-8ef4-bcaa49da5cb2"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4468), "192.168.1.65", (byte)1, 6.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("12045594-558f-4a3d-9112-2654ab9d7dee"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6462), "192.168.1.27", (byte)2, 38.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("1221c875-e57a-4ca0-a5cf-e48cf6e16ea4"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5235), "192.168.1.50", (byte)1, 17.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("126d889a-ddf7-4ad0-a598-1879b9809d34"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5448), "192.168.1.31", (byte)1, 83.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("12ab8a52-8f02-4d05-b224-4142af167326"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7655), "192.168.1.12", (byte)3, 93.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("13507fca-8753-4a93-acc7-3fc929f6c9f0"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6711), "192.168.1.86", (byte)3, 22.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("137edc85-d31f-49b2-85c1-484d32c721d9"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7149), "192.168.1.64", (byte)3, 26.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1396b7d5-7178-4606-ba87-83a00bf98214"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7105), "192.168.1.12", (byte)3, 76.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("13f75844-9dee-41fa-97f2-78746a62546e"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6161), "192.168.1.50", (byte)2, 85.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("141c4b5f-012e-4559-aa7a-a9fafc028780"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5907), "192.168.1.47", (byte)2, 2.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("143052cc-4405-4d37-9c2e-091eb3194d84"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5745), "192.168.1.14", (byte)2, 34.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("149acf62-9bdf-4b59-8b4d-ae51e3cae1fd"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7519), "192.168.1.71", (byte)3, 13.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("14aced7e-e365-4b2a-a29c-d1fbd368884d"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6737), "192.168.1.16", (byte)3, 66.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("15f1139f-0050-4765-96bc-3cac0f47cf3a"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4968), "192.168.1.40", (byte)1, 85.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("166f22a9-3be2-45b0-8007-a9f3db4d9f22"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4946), "192.168.1.14", (byte)1, 12.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("167c5363-049d-4c67-8301-56bda601772a"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7213), "192.168.1.72", (byte)3, 33.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("17072883-53ae-4c29-964b-f217f7a49098"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5132), "192.168.1.74", (byte)1, 53.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("170e5bcd-0569-4c21-b758-49ef8558b0a4"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7239), "192.168.1.65", (byte)3, 45.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("17580132-bc1e-42fd-8a1b-2b79b0994369"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6241), "192.168.1.88", (byte)2, 82.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("17a4d766-d791-41fd-827d-93d76d395af5"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5425), "192.168.1.78", (byte)1, 81.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("17dc1b88-2175-415f-ae55-7c88dbc6b2d6"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6839), "192.168.1.8", (byte)3, 38.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("18006250-22e3-4f23-bc73-b71fc165deaf"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7015), "192.168.1.24", (byte)3, 2.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("1807e483-0903-4ea2-90c6-a9b75e99b289"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4611), "192.168.1.69", (byte)1, 28.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("1819f641-95ed-4f61-845c-ec35389caac1"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6151), "192.168.1.81", (byte)2, 92.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("1836e24e-37f7-4f75-90de-09ec97c0a543"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7595), "192.168.1.51", (byte)3, 56.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("18392e96-64e5-4fbb-9d33-d6e16b087052"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6401), "192.168.1.33", (byte)2, 14.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("1874ab8e-59e9-4570-a83d-947c2f299c9e"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5775), "192.168.1.57", (byte)2, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("188239d1-b8b4-4af2-9861-626e5f78f537"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7671), "192.168.1.42", (byte)3, 72.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("18bdd4a2-29ac-4d3b-a2cf-55d5ef6fb722"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5618), "192.168.1.3", (byte)2, 69.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("18fd74c0-3681-415f-b532-efb641824e2c"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4477), "192.168.1.24", (byte)1, 94.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("191076aa-4a32-4c89-9cef-ebd2ce54a19d"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4669), "192.168.1.72", (byte)1, 36.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("19359f6b-de4e-4991-9df5-d675f597f616"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6985), "192.168.1.54", (byte)3, 75.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("1942efd8-54f1-4106-89b3-3e43212c79b1"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5664), "192.168.1.6", (byte)2, 44.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("199e7a57-4c87-4ae9-ad99-a292c9804df1"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5680), "192.168.1.84", (byte)2, 26.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("1a106b7e-b32f-41c8-880d-b6dde7f914c2"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5950), "192.168.1.48", (byte)2, 21.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("1a13ba58-d8fc-4b12-81b4-3adb5409bb64"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5158), "192.168.1.16", (byte)1, 94.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("1a70e879-578a-4cf4-a4ec-fbceb4824545"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5787), "192.168.1.51", (byte)2, 49.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("1ab4d78f-46b7-4dd2-9da4-1ab967107181"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6424), "192.168.1.70", (byte)2, 42.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("1b163d49-3265-4cd9-99da-6b2ee2cf6602"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7583), "192.168.1.72", (byte)3, 17.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("1b19bfd0-c661-4b4a-939e-313b4d182bb6"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4645), "192.168.1.13", (byte)1, 65.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("1b3b1ed5-f8d1-4c58-b584-3f383787cacb"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5032), "192.168.1.75", (byte)1, 83.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("1be2dc0c-0b9f-4d95-a58b-e40c1250c03b"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5340), "192.168.1.47", (byte)1, 14.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("1c3fa8e7-a50c-4b8f-b439-b2383a3e158b"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4795), "192.168.1.31", (byte)1, 88.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("1c58763a-4b80-40d4-ba58-89a93a76f2e8"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7709), "192.168.1.3", (byte)3, 33.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("1cc639c9-fd4c-4333-ac92-25c6e280eb7a"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6195), "192.168.1.44", (byte)2, 46.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("1d2e6e3d-f184-4bde-95d6-1dc86b6cb722"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5972), "192.168.1.8", (byte)2, 80.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("1dc25a9e-941a-42a3-a62b-7e283fb581d1"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7721), "192.168.1.38", (byte)3, 25.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("1dc34082-b114-4fa5-aae1-3489d52443ce"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4837), "192.168.1.6", (byte)1, 9.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("1dcdbafb-dd34-498b-a715-4017b7ad6062"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5280), "192.168.1.22", (byte)1, 24.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("1f189090-5fda-492d-b12c-eff5a66cbcbd"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7131), "192.168.1.27", (byte)3, 67.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("1f578790-bb72-4308-a064-f0b4428b50ab"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7611), "192.168.1.65", (byte)3, 92.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("1f6b447d-2fff-4b80-928b-c2a7f066d1c5"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4900), "192.168.1.50", (byte)1, 55.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("1fc4b244-3575-4051-8570-64612f1cf31b"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6088), "192.168.1.30", (byte)2, 78.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("1ff0dc6a-5ab0-44af-b925-c0bdef4dea92"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7290), "192.168.1.71", (byte)3, 38.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("2106b51d-0c7c-464e-9bb7-68a0dd202a94"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7037), "192.168.1.82", (byte)3, 52.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("21192d2f-c3be-4c8c-bb8e-88e67a74f4a8"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6630), "192.168.1.30", (byte)3, 33.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("21e38381-4ff6-4a08-b6a6-a420afe3bf99"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4874), "192.168.1.67", (byte)1, 77.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("22874558-9eb7-4030-8c0f-fe97a3f52e7f"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5607), "192.168.1.44", (byte)2, 10.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("22a46b2f-f95f-4fca-89c1-48349d79bbab"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6755), "192.168.1.93", (byte)3, 13.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("22c3f231-38f4-42a4-a4ad-a71cf7d7ae44"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7578), "192.168.1.13", (byte)3, 37.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("230b9de8-08c3-4fc3-a872-20b7e09a01ae"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4733), "192.168.1.99", (byte)1, 67.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("23e88788-8ce3-4a8f-a7d8-474e8275c148"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6969), "192.168.1.3", (byte)3, 43.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("24073ea7-2605-4cd8-bec3-88256948ae18"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6881), "192.168.1.19", (byte)3, 69.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("246226bc-bf8f-48d3-8bed-9e7dd89401bb"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4912), "192.168.1.15", (byte)1, 36.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("24846fd8-7ab1-4ce3-a5f2-eb818ed63f37"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6245), "192.168.1.43", (byte)2, 74.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("25368893-f166-4b0f-9296-c51daaf7142a"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4500), "192.168.1.46", (byte)1, 42.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("25e207da-8651-476b-adb1-f75f79e5e1fb"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5421), "192.168.1.66", (byte)1, 67.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("25fc3961-247d-4098-b8a0-3291c418de9f"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4473), "192.168.1.74", (byte)1, 7.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("2651da51-3e0b-4c58-8efa-c161f8a786bc"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4596), "192.168.1.89", (byte)1, 86.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("2689be8e-cdfc-4b8b-8947-1923411cf549"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6869), "192.168.1.94", (byte)3, 44.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("268cbae0-9b6f-43de-8ce4-cbd6acb1c3ec"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5247), "192.168.1.7", (byte)1, 97.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("26e34d49-4f4e-4175-822b-a35b6217638d"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6604), "192.168.1.47", (byte)2, 79.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("2784644e-dc3a-47c4-990e-b3dfc7201ef5"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6016), "192.168.1.87", (byte)2, 81.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("278a57c1-338a-4d85-9815-408ed6d0e3e9"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5494), "192.168.1.26", (byte)1, 45.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("282274ff-3601-4934-99bc-14bd817a75b6"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5508), "192.168.1.62", (byte)1, 58.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("2874df56-4f75-40e8-8b6c-cab151278d83"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7566), "192.168.1.36", (byte)3, 42.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("28e03163-0a30-417f-b09d-4eb921d58f26"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5639), "192.168.1.76", (byte)2, 39.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("2956e09d-a6a0-4097-8e23-524e520d4a94"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6291), "192.168.1.72", (byte)2, 27.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("29f348b1-84b7-4f23-bca8-740d6a7263cf"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5835), "192.168.1.72", (byte)2, 83.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("29f8f7ae-a142-4dc3-9027-7f39ce2b0f14"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5630), "192.168.1.92", (byte)2, 70.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("2a66905a-4989-4c79-bc9d-5a80805257cb"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4825), "192.168.1.93", (byte)1, 56.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("2a93b039-e5b6-48ab-959a-62d5cd3bd447"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5798), "192.168.1.88", (byte)2, 9.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("2aa40986-4979-4240-a8bd-058454a257ce"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5239), "192.168.1.78", (byte)1, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("2c1e83af-41d7-47a1-98b8-c6ca91dacf6c"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7093), "192.168.1.56", (byte)3, 21.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("2c354448-5b17-4e67-b92f-146e53dfefe8"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5386), "192.168.1.73", (byte)1, 76.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("2da9d3a4-a05d-4e35-92cd-bfcc40ce1581"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5990), "192.168.1.87", (byte)2, 97.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("30313548-131d-4d81-a1fb-89f1e997970f"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4606), "192.168.1.45", (byte)1, 11.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("30571e25-89ab-4741-a445-590886cfeb26"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6139), "192.168.1.77", (byte)2, 14.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("30e1bfe9-dd3d-43fb-ad2c-46bac397d5aa"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7281), "192.168.1.74", (byte)3, 54.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("3100669b-ee41-4d88-b63b-b36826ff40b6"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6578), "192.168.1.21", (byte)2, 30.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("31642898-7095-44fc-a40d-460b022c5a3f"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6993), "192.168.1.57", (byte)3, 76.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("322a9d6a-92ed-4762-a66c-25b9bfa215b1"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5546), "192.168.1.75", (byte)2, 23.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("323d9f01-3a4a-44aa-ac09-cdc281faf4d5"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5306), "192.168.1.21", (byte)1, 16.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("325d0c7f-0ad0-48ba-9fdd-7c010d1edf7d"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4724), "192.168.1.99", (byte)1, 2.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("33408bd9-b750-49c4-8bb4-e005fe036e17"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6496), "192.168.1.4", (byte)2, 99.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("33af87b7-de80-40d6-ab21-462af002a4b9"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5915), "192.168.1.94", (byte)2, 79.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("33b86397-7fe2-4b55-a476-8a577b825a26"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5400), "192.168.1.63", (byte)1, 53.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("33d2fdbd-259e-4506-9953-e4991a8af2cc"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5903), "192.168.1.55", (byte)2, 56.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("34246bf6-7b26-47bf-89ab-c89f4c7e4c3a"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5302), "192.168.1.78", (byte)1, 1.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("343b9321-f169-4845-a916-3e99c51ac23c"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5370), "192.168.1.6", (byte)1, 8.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("34e00c63-ca60-4044-91d6-88d4ce6c6d84"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5043), "192.168.1.33", (byte)1, 13.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("3502bd94-a342-4c6b-aa06-765b1da1e7b2"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7717), "192.168.1.64", (byte)3, 51.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("35babe1b-324f-4a84-b3e4-de242370fc5f"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4653), "192.168.1.37", (byte)1, 82.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3639cc22-ce57-4ab5-8be0-e9c5a1fc2dba"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6669), "192.168.1.53", (byte)3, 72.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("36a2ba96-54d1-4ffa-bc64-6decdb65c47e"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6747), "192.168.1.34", (byte)3, 62.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("36e610ec-81b8-4e07-8b70-8981a556d728"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7089), "192.168.1.85", (byte)3, 83.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("37263c5b-2263-4f46-b9bd-447eeff6b800"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4665), "192.168.1.58", (byte)1, 89.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("3738731d-a1fb-4eb8-82ef-2ca3ff922796"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6586), "192.168.1.25", (byte)2, 92.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("37605d08-901b-4e0e-a682-9ad9f5cbbf38"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5470), "192.168.1.44", (byte)1, 29.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("37b3faab-be18-42fb-9d84-0ef324f6bd1a"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5512), "192.168.1.78", (byte)1, 16.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("37e5f9cc-aa16-4e86-92be-7b4630d13fa0"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7247), "192.168.1.9", (byte)3, 88.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("3878e91a-6e81-4b33-8a79-ae43f225fc7d"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7675), "192.168.1.83", (byte)3, 48.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("38a7ab9b-ea2d-4b35-b984-02b1fa6073bf"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7414), "192.168.1.83", (byte)3, 49.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("38d0c269-e40b-4fd1-8b89-79783566a5d1"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5276), "192.168.1.61", (byte)1, 68.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("39160f2a-058f-4ccd-94aa-4211d9d1e17e"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4848), "192.168.1.18", (byte)1, 26.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("394059b3-3890-4718-8cb0-ccd0d971d2d7"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6233), "192.168.1.18", (byte)2, 2.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("3a195ce2-1511-4133-88a4-91f1797c00fd"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6450), "192.168.1.75", (byte)2, 72.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("3a44d1a4-0949-4f18-b6c5-a9ac59f93a00"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6642), "192.168.1.79", (byte)3, 73.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3ab6b6c9-819b-4d09-9eab-ce45e2dd161b"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6743), "192.168.1.58", (byte)3, 23.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("3ac1c9ed-9e99-4697-9894-1c2ae8b13398"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5923), "192.168.1.81", (byte)2, 43.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("3bdf909e-bd60-4797-a3ac-e43099264f73"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5016), "192.168.1.62", (byte)1, 16.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3c2482c0-6cd0-4247-b842-fb92990b4919"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4709), "192.168.1.51", (byte)1, 81.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("3ca8277f-a866-4f07-9f4f-4c97c26639b0"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6054), "192.168.1.43", (byte)2, 9.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("3cff8c4c-87ce-4814-bf3b-fec690fb5066"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5821), "192.168.1.60", (byte)2, 99.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("3d8efea3-c305-4798-abed-c168aaf1e371"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4579), "192.168.1.34", (byte)1, 70.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("3e2a8590-6527-40e6-8d72-0a847c7dad15"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5504), "192.168.1.64", (byte)1, 49.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("3e63ab61-2641-438e-abbe-c6e1b41257c5"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6484), "192.168.1.12", (byte)2, 19.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("3e7d1d27-e3d9-4c9a-9ec6-bb3bb996cfd4"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4807), "192.168.1.4", (byte)1, 92.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("3fa170eb-57c8-4105-ad50-c06a4e9a47ba"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6211), "192.168.1.78", (byte)2, 68.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("3fe148ca-9771-4215-bc0c-88d227b97e25"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5362), "192.168.1.39", (byte)1, 18.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("400ad547-0193-423a-b4aa-c1702484e288"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5919), "192.168.1.49", (byte)2, 59.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("401b3d65-7393-47ea-a82a-4bce92b42f63"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6542), "192.168.1.83", (byte)2, 34.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("40535a31-6583-42a1-9479-da539c202cf7"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7196), "192.168.1.71", (byte)3, 40.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("41adb515-21c6-4e42-999d-53a7a3706fc2"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5366), "192.168.1.18", (byte)1, 26.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("42e0be0a-330f-4337-a38e-aa33f283c900"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4856), "192.168.1.72", (byte)1, 86.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("43c1923b-2ff6-4879-aff2-64b7a2fe4fc6"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5927), "192.168.1.39", (byte)2, 76.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("43f824ba-4f14-4864-8489-b10bb409fdbe"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6458), "192.168.1.77", (byte)2, 67.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("44a65575-00f9-48fb-8841-adf2eebff8d9"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7448), "192.168.1.47", (byte)3, 33.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("44dec22a-7e73-44bb-9f53-99f7deab7190"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7071), "192.168.1.40", (byte)3, 23.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("44e3403d-531a-445b-93c6-3d03fb5dacd9"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4737), "192.168.1.50", (byte)1, 26.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("4547dc6b-227a-41a1-abb5-48ae4706dcb3"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4456), "192.168.1.81", (byte)1, 86.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("460784c6-78c3-41e4-9562-4b4c58521dae"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5473), "192.168.1.66", (byte)1, 58.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("4633a694-0d2a-4117-a320-b834d7eb7ffc"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6560), "192.168.1.34", (byte)2, 62.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("465e67d7-758e-4c4c-8d1d-c56969efa59c"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5634), "192.168.1.8", (byte)2, 71.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("47b01607-8605-4d2b-958f-23c9ba764691"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5767), "192.168.1.49", (byte)2, 19.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("48c92e5c-5254-4c33-bc28-3da5f9cc6d85"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7486), "192.168.1.90", (byte)3, 74.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("49941746-bfa4-4958-af24-66fada5d66d7"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4552), "192.168.1.70", (byte)1, 47.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("4b83a944-b605-4ebe-882b-909dadaa42af"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5978), "192.168.1.34", (byte)2, 33.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("4b97dab9-d86d-4913-af57-0b751c69a63d"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7243), "192.168.1.80", (byte)3, 43.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("4ba52076-8719-4638-aa21-682dcc740a26"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5817), "192.168.1.87", (byte)2, 10.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("4bc68dc0-cec5-4151-a683-08515f87f603"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5150), "192.168.1.70", (byte)1, 63.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("4bc6a868-9a8a-43a2-ae2f-7ede4c757ada"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7173), "192.168.1.13", (byte)3, 51.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("4bdca878-02c0-4142-87e9-e5851fdfcda8"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6616), "192.168.1.90", (byte)2, 27.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4be9dc17-a8c1-40e4-9dcd-a2de1ff1fbaf"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5439), "192.168.1.92", (byte)1, 35.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4bfa01c1-f579-40ad-8afe-012569138400"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6006), "192.168.1.62", (byte)2, 42.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("4c261e89-09bc-4fb7-af38-2832a246895b"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7588), "192.168.1.91", (byte)3, 0.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("4e1481de-6a91-4c05-9f47-8e1546eb77ef"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6492), "192.168.1.86", (byte)2, 43.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("4e5746b5-09a7-4197-8cba-baa94aa46052"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6556), "192.168.1.83", (byte)2, 32.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("4ef42a98-d7ed-4171-848b-22efcb154277"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5733), "192.168.1.85", (byte)2, 74.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("4f602331-ca09-4487-adb5-4a577b90b5a4"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6827), "192.168.1.97", (byte)3, 93.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("4fc9c0b5-42b6-422e-9e06-8360ba80b690"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7553), "192.168.1.45", (byte)3, 86.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("4ff38263-b2b3-4556-a4d8-6b161fb4d266"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6066), "192.168.1.54", (byte)2, 9.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("506ad817-ec9f-4c13-acc8-4a0b9f423af1"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7621), "192.168.1.73", (byte)3, 88.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("50bd4187-c65a-4f14-833f-425b649d74bc"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6367), "192.168.1.62", (byte)2, 0.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("51eca4ab-3c48-47b2-b326-fd710167cfb9"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5226), "192.168.1.51", (byte)1, 91.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("52c20491-571b-40fc-a783-a488843e3fe2"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4852), "192.168.1.30", (byte)1, 87.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("53241745-4afe-4546-8925-f25570add568"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6817), "192.168.1.57", (byte)3, 97.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("5339997b-b6d5-4263-9ba3-fb083e4f7ed8"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6203), "192.168.1.99", (byte)2, 60.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("54118acc-11dd-438a-a962-54709268e735"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6943), "192.168.1.32", (byte)3, 33.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("542b4e1c-ea87-4bd2-97ad-e8374053688a"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4938), "192.168.1.82", (byte)1, 75.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("547600e1-e584-447a-ba7d-b3a0fbca5ea0"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5998), "192.168.1.34", (byte)2, 47.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("54d15989-975b-4c4f-8928-7eae5affc7b8"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5456), "192.168.1.32", (byte)1, 88.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("553adbf1-d7ec-40b0-973c-4257d9f50d2b"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6590), "192.168.1.89", (byte)2, 88.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("556f9a6c-ed4a-4b83-811e-a28bfff443e5"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6389), "192.168.1.68", (byte)2, 20.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("558bfe4f-cdaa-410e-8558-754d1c3a9984"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5288), "192.168.1.2", (byte)1, 43.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("5591bf7b-0778-4dd9-b0ab-762580eea947"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5081), "192.168.1.72", (byte)1, 58.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("55c352b1-7b16-4cdd-9543-35a62c207771"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5847), "192.168.1.82", (byte)2, 44.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("56012afb-d9b2-46f4-9355-0023203ae165"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6113), "192.168.1.50", (byte)2, 23.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("56187e8d-a7e1-4c77-b28f-442427ee2686"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4690), "192.168.1.37", (byte)1, 55.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("57091b1d-3e02-4a16-b4f1-2543d55485de"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4548), "192.168.1.10", (byte)1, 69.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("57de2ba4-9295-4e74-b5a4-5347c6f564d8"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7363), "192.168.1.11", (byte)3, 97.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("5817c9d2-8d75-43c1-8ac5-966b28072527"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5779), "192.168.1.91", (byte)2, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("584bd915-0675-4c22-a9ae-9dea52a3f2e0"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5193), "192.168.1.4", (byte)1, 90.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("58a0908a-e1de-4fa7-8757-5ad0c5feb8bf"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5582), "192.168.1.15", (byte)2, 19.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("597afc1d-50f6-4216-ac6b-d8628ff587b2"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7318), "192.168.1.93", (byte)3, 9.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("59958a6f-aa8c-4f69-9d9e-c862b96589f5"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6032), "192.168.1.53", (byte)2, 10.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("5a1be47f-4e26-438c-94f7-9f65a92e2b93"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5684), "192.168.1.74", (byte)2, 73.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("5a6c9fdf-2c99-4dd6-b632-7b1ce14c018c"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6681), "192.168.1.8", (byte)3, 28.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("5a82ca5b-93e3-4e36-b2dc-73a62dac5916"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6355), "192.168.1.95", (byte)2, 72.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("5ae6b94b-339f-477c-8dc1-055ee5318529"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6097), "192.168.1.5", (byte)2, 92.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("5b05639e-1691-44b3-83cd-ee67a599d92d"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7493), "192.168.1.53", (byte)3, 28.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("5b150ca1-af75-4827-8576-453f201299b2"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5119), "192.168.1.69", (byte)1, 66.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("5b3ed27b-af32-4b38-9e4a-56d70fe0156b"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7574), "192.168.1.14", (byte)3, 86.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("5b864761-57c9-4fcd-944f-8b4e0f8a18d4"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6070), "192.168.1.70", (byte)2, 42.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("5c387d00-59b9-46a2-9506-6d8e2c7c8df8"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6474), "192.168.1.97", (byte)2, 71.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("5cd2662b-6939-4ce7-9b6f-ddcf9645c04b"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5795), "192.168.1.95", (byte)2, 96.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("5cd9368e-a81e-44fe-abb9-2cbb4154a41a"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5124), "192.168.1.1", (byte)1, 89.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("5dcaf313-b4ed-4e19-b55a-ea646ecf9631"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6500), "192.168.1.70", (byte)2, 47.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("5de782df-49b0-40ba-834c-9f47cd3db133"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6169), "192.168.1.23", (byte)2, 85.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("5e071903-107e-438c-92de-5adc5c5b8854"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4896), "192.168.1.70", (byte)1, 26.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("60310079-8205-4dbf-97cc-bf567bb3f282"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7097), "192.168.1.17", (byte)3, 53.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("6079fc41-ae52-40ea-9fd4-549316db22a3"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6058), "192.168.1.50", (byte)2, 55.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("60874719-0e90-4632-96b9-030d148af6eb"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5643), "192.168.1.71", (byte)2, 82.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("609dfb0c-12d6-476b-a186-46fbad0d503b"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5067), "192.168.1.19", (byte)1, 50.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("60ac5c85-64b6-48a6-8ce9-a78fa42457de"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5024), "192.168.1.38", (byte)1, 9.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("612abb30-7518-49f1-b033-869be931d27a"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7617), "192.168.1.74", (byte)3, 99.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("63130c06-c969-451d-901d-44744d69d2c2"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6385), "192.168.1.94", (byte)2, 86.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("63a26922-02db-4305-8685-468b78d82d45"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6693), "192.168.1.91", (byte)3, 66.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("64a46901-8e42-4dd4-b1e2-c41947436d97"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7410), "192.168.1.30", (byte)3, 14.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("64ca2bf6-e7e8-47ec-aa60-2317cee87eb4"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6275), "192.168.1.60", (byte)2, 68.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("64ff9023-9e5b-4218-9798-4302deaef19b"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7422), "192.168.1.58", (byte)3, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6539867e-f420-4d69-947c-145d5844bce1"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5808), "192.168.1.29", (byte)2, 14.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("65698615-a7c4-4975-a7f5-cdfb88ea2621"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6092), "192.168.1.29", (byte)2, 9.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("6673e513-b861-4e41-9c03-d4b8e307fd9e"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5429), "192.168.1.19", (byte)1, 38.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("67ec1e7f-1dee-459e-9cfe-636df3d71f84"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6359), "192.168.1.67", (byte)2, 16.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("6894391e-c623-450b-95e9-257d0951dedf"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7497), "192.168.1.42", (byte)3, 4.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("68ec8c39-3282-429e-93ac-c26756e1a04f"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7157), "192.168.1.52", (byte)3, 61.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("68f8164e-b099-4169-8253-1abf676c57e3"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4439), "192.168.1.17", (byte)1, 3.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("68f89aa7-3a23-4020-9eb6-606ced32a2e2"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5851), "192.168.1.57", (byte)2, 52.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("69335197-4e34-4458-9dde-c9cd99176c12"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5783), "192.168.1.36", (byte)2, 76.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("696f7941-c6b1-4710-b16e-4f15fd1d8c8e"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7067), "192.168.1.70", (byte)3, 54.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6a0f16dc-d66d-4c33-b9bf-0d6d50d83a7d"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6677), "192.168.1.96", (byte)3, 59.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("6aa37721-a812-48ca-8d50-1b1adf14293f"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4904), "192.168.1.79", (byte)1, 13.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("6aae7e61-8c47-4d39-8d93-20a7b6dd264c"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6050), "192.168.1.32", (byte)2, 60.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6abf486e-0e26-43e0-8584-585db92e287a"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6620), "192.168.1.70", (byte)2, 40.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("6b0b0a8f-7202-45e6-abd3-0725a8f9b065"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6947), "192.168.1.72", (byte)3, 90.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("6b27be71-bcd9-410e-b04b-5cc3da0fd242"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6508), "192.168.1.9", (byte)2, 52.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("6b2d7092-be6a-4f9d-bace-8d7fd57562ea"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6955), "192.168.1.41", (byte)3, 62.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("6bbc368e-6ac9-4c68-880a-fe63d571d55a"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4964), "192.168.1.57", (byte)1, 28.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("6cfe53c9-e566-4b54-8397-af9e4126539b"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4862), "192.168.1.20", (byte)1, 20.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("6d0792c7-0b0a-4bd3-9571-d158bdcdab01"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7456), "192.168.1.68", (byte)3, 81.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("6d2f55c4-5434-4c54-9f91-b3ce07029343"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6655), "192.168.1.70", (byte)3, 27.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("6d33426d-d243-4692-a39b-3f27d690141f"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5382), "192.168.1.83", (byte)1, 21.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("6f0a6cab-a45d-4d00-b311-5beae1c77ca8"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4866), "192.168.1.2", (byte)1, 58.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("6fa8c03b-f763-425e-9e44-f8ec8053345a"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5591), "192.168.1.43", (byte)2, 85.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("6fe9cccd-b8bf-4227-9185-c305bd2c7072"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6921), "192.168.1.51", (byte)3, 25.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("7014768c-5ed0-427e-bc6b-babbe5cfee2b"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5464), "192.168.1.63", (byte)1, 25.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("70302312-e7a2-4dcf-bb97-cb61b42b7d9d"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7123), "192.168.1.97", (byte)3, 89.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("705ffa45-f516-4964-9598-f11aab6fbaea"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7637), "192.168.1.56", (byte)3, 51.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("7098e0a7-00e0-4e45-a237-b0032c19189c"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4635), "192.168.1.71", (byte)1, 33.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("70c8b08e-8887-4985-9789-62bc9c8f74dd"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7535), "192.168.1.98", (byte)3, 49.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("71236f77-a6bc-4936-8333-d3153d1bc416"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4682), "192.168.1.73", (byte)1, 95.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("71673951-be8b-4570-89fb-e91d9476205c"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5885), "192.168.1.38", (byte)2, 16.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("7253d4c3-7d37-457b-bde7-38f2001c6c74"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5771), "192.168.1.72", (byte)2, 43.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("725cb152-4f0d-4d10-ad3d-1ced4885fc04"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7402), "192.168.1.51", (byte)3, 83.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("7265bd93-c439-4de0-b7f6-ea2110b8717f"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7539), "192.168.1.32", (byte)3, 61.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("728c8ade-1c37-448a-8c36-766197fc43bf"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6665), "192.168.1.11", (byte)3, 42.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("7298b726-95bc-464e-94f9-69413b48a311"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7285), "192.168.1.79", (byte)3, 33.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("730197f5-bc2f-4061-a11a-cab504d5cab7"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6127), "192.168.1.88", (byte)2, 14.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("73225364-6e43-4778-8d11-c851f7b4e35c"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5408), "192.168.1.79", (byte)1, 79.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("73243809-12c0-48e4-b345-c328f66ef3d0"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6339), "192.168.1.44", (byte)2, 48.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("73880cbf-ad1b-4775-888b-136579a91f54"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5348), "192.168.1.46", (byte)1, 80.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("73a29abc-7788-4410-b090-c491178ccafa"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5185), "192.168.1.5", (byte)1, 82.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("73cc3be4-3e55-4237-8069-23ffadc6de41"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6321), "192.168.1.87", (byte)2, 70.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("73d9075a-cfcf-417c-8a63-7b0c7a3a9f80"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7697), "192.168.1.88", (byte)3, 14.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("75074897-b5be-418c-a8a5-3a512665a889"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5829), "192.168.1.82", (byte)2, 87.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("7541b109-03a4-4c73-b155-aaa61c2df41f"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5931), "192.168.1.39", (byte)2, 58.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("7564b9ad-021b-4255-891c-ce2e669b57a4"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7397), "192.168.1.4", (byte)3, 24.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("756ce7e2-aaaf-4efe-acdf-96d38c9d3fd8"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6074), "192.168.1.95", (byte)2, 32.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("759d7881-7121-4117-a5d6-0805460a8165"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6861), "192.168.1.52", (byte)3, 38.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("75a946ce-19ac-4087-9e10-46207bbb13b7"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6411), "192.168.1.94", (byte)2, 62.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("75e39c7a-719d-420b-b66c-1bd866b8c412"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6040), "192.168.1.43", (byte)2, 86.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7641aad5-9cb0-41ad-a9bc-9f1efe2a0320"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4556), "192.168.1.51", (byte)1, 29.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("76721171-b652-4a94-854b-6ccb2204b7c1"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5676), "192.168.1.69", (byte)2, 91.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("76c35610-fd59-4526-8ad6-e33ce6226158"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4592), "192.168.1.88", (byte)1, 55.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("76e31e8a-a0b9-4086-a0b8-1246907d58a5"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6436), "192.168.1.27", (byte)2, 75.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("771e6afc-d2eb-4974-b5cc-22d3199c28ed"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4934), "192.168.1.23", (byte)1, 19.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("77fbe978-5668-483c-9b55-7c646192b709"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5435), "192.168.1.78", (byte)1, 32.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("77fc46bf-3383-4895-a1f9-728c98d66da1"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5298), "192.168.1.82", (byte)1, 33.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("785e8462-9953-49e6-bab1-0c4fda617f84"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5189), "192.168.1.16", (byte)1, 1.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("78942e56-ea22-462d-8a18-3b860babd87b"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6454), "192.168.1.71", (byte)2, 90.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("78cbd547-a82d-4dfc-85c3-c02ee5d03cf0"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5960), "192.168.1.77", (byte)2, 54.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("78de9243-ec61-4f27-bad0-631a08cf68a3"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5412), "192.168.1.10", (byte)1, 60.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("79227862-eba6-47df-a069-9ddb0692ac39"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6101), "192.168.1.68", (byte)2, 74.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("792fdeef-dbc4-4870-84c4-c299d447e8fb"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6733), "192.168.1.75", (byte)3, 36.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("7958724b-800e-4ddd-a2f5-649305dfb7c5"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5144), "192.168.1.89", (byte)1, 66.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7a0888ab-017f-482b-99f3-a6b82393c5a5"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5737), "192.168.1.12", (byte)2, 66.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("7a374ddd-9eee-42cf-a619-c549e86cb06e"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7515), "192.168.1.65", (byte)3, 4.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("7a6ee22f-0b2d-4c42-b89f-f908d9fe13b2"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6634), "192.168.1.49", (byte)3, 84.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("7bb0e761-d6bb-424d-93a8-95a765ec0e6e"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6317), "192.168.1.50", (byte)2, 18.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7bb80376-ffdc-4f3c-a2ca-d9219f5dfe69"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7115), "192.168.1.11", (byte)3, 48.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("7bc205fd-3da4-4a54-97a0-5da3f7bdb552"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6440), "192.168.1.21", (byte)2, 88.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("7bc6dcf5-ae57-4f48-8d92-e13a3f2f5c7e"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6225), "192.168.1.69", (byte)2, 90.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("7c166ab3-118c-4421-85d1-4867baca9a40"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5201), "192.168.1.32", (byte)1, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("7c27e720-e24f-43f9-9920-eaf046680657"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7041), "192.168.1.89", (byte)3, 70.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7c2ffe26-d2fe-416d-af15-fca4b6885f53"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6173), "192.168.1.3", (byte)2, 4.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("7c4fe24b-4f27-4442-ba15-8f45ba902035"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6012), "192.168.1.3", (byte)2, 55.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("7cc226f0-7e9a-4755-bca7-9f2f8096e33b"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6002), "192.168.1.40", (byte)2, 65.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("7d86f228-95ff-4f8e-a788-653955002337"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6325), "192.168.1.21", (byte)2, 61.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("7dbe4bd2-9e28-446f-a51c-a5223e614e6c"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4627), "192.168.1.26", (byte)1, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("7e1ac9d2-c74d-472d-8a51-5a9e1480a8a3"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4661), "192.168.1.37", (byte)1, 52.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("7ecb4d32-2201-4552-b86a-2e535c534c85"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5753), "192.168.1.22", (byte)2, 29.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("7f1632c3-c8a5-4603-84ea-357817d34f30"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5257), "192.168.1.95", (byte)1, 28.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("7f3ed638-542a-4a4c-86d9-92096b20a21e"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6689), "192.168.1.78", (byte)3, 71.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("800903cb-26df-40b9-ae60-b312b85b00e4"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4768), "192.168.1.34", (byte)1, 42.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("80142c02-4bc2-466c-b2d1-c6c8ad907444"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6582), "192.168.1.67", (byte)2, 98.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("80414b4e-1d30-4f24-a222-faec75a6d8fe"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7177), "192.168.1.15", (byte)3, 3.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8094860c-e8ef-445e-96f8-223ce6545d92"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4587), "192.168.1.5", (byte)1, 65.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("813df71c-704e-4354-8306-63192389bcd5"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4504), "192.168.1.20", (byte)1, 78.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("817c9247-da05-4b50-9486-6584b04fabc8"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6546), "192.168.1.5", (byte)2, 27.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("818d81be-b0cb-4fe8-8ac2-c15f0f5d123c"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4535), "192.168.1.80", (byte)1, 63.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("819fc94a-1e2a-4b3a-8314-bb3eaf2d5611"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4527), "192.168.1.78", (byte)1, 76.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("839460e0-3455-43c8-9ee7-c4b57bbdc30b"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4516), "192.168.1.54", (byte)1, 44.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("83da83a9-797a-4891-91f2-97578c19e8ee"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6131), "192.168.1.2", (byte)2, 30.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("83e387ba-97a7-43cc-bc1e-016f57b96807"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7523), "192.168.1.10", (byte)3, 94.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("83f2c8fb-31c1-4081-9736-63340acad51d"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6329), "192.168.1.96", (byte)2, 57.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("8412bbe4-cf36-4afe-90fc-5d28a4a2bef0"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6478), "192.168.1.70", (byte)2, 18.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("848ae5ee-a83c-4f5b-a7dd-87171f803b67"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5937), "192.168.1.66", (byte)2, 89.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("84cf9d16-9bd7-41a8-8d19-c2802c162495"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6843), "192.168.1.58", (byte)3, 41.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("84f93059-304b-4483-b118-f574c83c55c5"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6219), "192.168.1.7", (byte)2, 51.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("86e97df6-d3ee-4624-8756-92457e688c7f"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7003), "192.168.1.39", (byte)3, 85.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("87b5b78b-adb6-4155-9006-8fb081bfeb26"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7081), "192.168.1.44", (byte)3, 0.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("87f37afa-aa3a-465a-ad17-fce5be412a32"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5179), "192.168.1.90", (byte)1, 50.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("88420e76-eb7c-4a82-a562-9cde05698a76"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6538), "192.168.1.47", (byte)2, 90.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("88935c3b-b866-4f7f-8a01-0ec3f4629a5e"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4485), "192.168.1.16", (byte)1, 14.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("896268ad-6b48-4750-9d89-cbbba0cd49f9"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6759), "192.168.1.85", (byte)3, 59.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("89e724e8-00ea-44e7-aead-77e59700d2a6"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4631), "192.168.1.15", (byte)1, 77.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("8a43d75a-2b28-4472-8624-fb0305f4b594"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5538), "192.168.1.62", (byte)2, 83.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("8a5e47b4-7548-4d3e-b337-c8940e56080a"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5272), "192.168.1.62", (byte)1, 47.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8a83799b-4431-496c-81ec-373f9f591035"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5344), "192.168.1.32", (byte)1, 56.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("8aa4eba6-24d4-41f8-ad0d-08cd14166125"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6147), "192.168.1.16", (byte)2, 34.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("8b10ba23-6feb-491d-a1b2-4fd3c3e416b1"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7127), "192.168.1.83", (byte)3, 28.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8b3bbeeb-38b1-4d5b-8d58-29d61f9956b7"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5077), "192.168.1.51", (byte)1, 90.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("8badd74e-1654-4149-a3fb-5a1eae251a67"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7381), "192.168.1.77", (byte)3, 14.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("8bbfe669-c961-42f6-99d6-ffb99f1b480b"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5336), "192.168.1.73", (byte)1, 33.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("8c2590aa-dd3b-489e-8be5-1db06fa16547"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5108), "192.168.1.43", (byte)1, 96.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8c454fa1-6e9f-404c-8563-410a3849a578"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7641), "192.168.1.66", (byte)3, 52.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("8c96952f-7b01-4836-9078-d926713ee28e"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7603), "192.168.1.36", (byte)3, 5.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("8d701e5d-11fb-4dbc-867b-e106afb490f5"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5020), "192.168.1.43", (byte)1, 62.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8d915527-7d73-4f64-9399-654552353bb4"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5332), "192.168.1.64", (byte)1, 94.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("8dce6ecc-7e4b-44f8-9e65-cd0ddc4cb4c3"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6788), "192.168.1.54", (byte)3, 41.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("8df0860c-3438-402a-8035-56b442e22d60"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6080), "192.168.1.29", (byte)2, 28.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("8e3d0cf1-c9c3-48c7-a075-9da0692f5bf0"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6530), "192.168.1.46", (byte)2, 72.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8e54219c-9a0a-49db-94da-01d4d0497065"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6253), "192.168.1.99", (byte)2, 44.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8e6c999f-a19c-43d6-ba78-6c13f16cb0ec"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5516), "192.168.1.4", (byte)1, 0.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("8e8886c8-50a6-4e9d-9e4f-8c654226de01"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7436), "192.168.1.40", (byte)3, 58.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("8ec2f0dd-253a-4650-b419-b700d5cf4ad7"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5603), "192.168.1.89", (byte)2, 81.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("8ed90ae1-f37b-4296-937a-033c80b52c63"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4930), "192.168.1.85", (byte)1, 90.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8eef0bc0-77d9-47c9-b0d0-b6fc0cfc747d"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5964), "192.168.1.43", (byte)2, 51.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("8efe53ae-9439-4777-9b37-2ec480bf3390"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5763), "192.168.1.68", (byte)2, 42.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8f5d671b-8eb5-4bae-90b6-0dd5bd93ef6f"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7464), "192.168.1.17", (byte)3, 99.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("903d6b59-3e89-4057-9eb8-963e55528832"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6024), "192.168.1.12", (byte)2, 22.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("90568553-35df-4eda-8e57-b120b52d8b5c"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5155), "192.168.1.59", (byte)1, 65.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("90c9eded-a2dd-4f31-842d-008c2f4e966e"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7426), "192.168.1.97", (byte)3, 6.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("90eace55-7c08-46df-aff6-4fda9dafdeac"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7489), "192.168.1.96", (byte)3, 17.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("90f3bec0-bbae-4cbf-90fd-ac6ed404d0c9"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5595), "192.168.1.12", (byte)2, 17.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("91629bf2-e89e-487f-9d98-3f8b0eaa8115"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6432), "192.168.1.42", (byte)2, 79.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("91cea504-e6fd-44e5-9c4d-9254e1918b1a"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6767), "192.168.1.1", (byte)3, 46.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("92297204-f7d5-410c-930a-4fe6f804c07d"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7406), "192.168.1.5", (byte)3, 25.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("92a1cf60-fe92-4dcc-b74b-a944a7718d4d"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7153), "192.168.1.81", (byte)3, 23.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("92b5d5eb-5f3b-4a84-863f-6573253b9512"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6939), "192.168.1.10", (byte)3, 88.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("92cdbf05-f2b5-47ef-818d-fc3e8aac6292"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6865), "192.168.1.16", (byte)3, 44.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("932c63f7-9294-420f-89e2-efbafd93b176"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5897), "192.168.1.61", (byte)2, 39.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("93321f8b-4718-4819-89bb-6aca7050a074"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5039), "192.168.1.27", (byte)1, 87.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("9345324c-6820-43b3-bbee-350bb00ccc6e"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5404), "192.168.1.27", (byte)1, 5.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("93855b93-c319-4670-bec9-99b366fe5946"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6715), "192.168.1.5", (byte)3, 60.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("93e18fd8-2030-4b03-b6f5-f6e2831aae15"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7340), "192.168.1.89", (byte)3, 5.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("93efedef-40be-44a3-927b-04bc49047e46"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7298), "192.168.1.94", (byte)3, 7.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("945a7666-41fe-4e00-8f96-57bf35bf448e"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4799), "192.168.1.36", (byte)1, 56.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("946be847-b7cd-4bd9-b6ad-3c246578a3a9"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7314), "192.168.1.62", (byte)3, 32.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("94f1fe81-1359-4cb2-88a0-3561baff9cbd"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6207), "192.168.1.35", (byte)2, 56.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("95017d1e-8b77-494d-aca2-a70180ff188e"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5012), "192.168.1.41", (byte)1, 75.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("956d296b-cc35-42ca-8243-d9e053c02f11"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6237), "192.168.1.34", (byte)2, 22.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9656d8d3-3db7-486b-8f83-c90f636e3f2c"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7651), "192.168.1.76", (byte)3, 27.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("96fff2d7-9588-495d-8c93-8e78828fb33c"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6271), "192.168.1.91", (byte)2, 58.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("97263bcf-2032-4a98-801c-091dcfef1ba1"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7324), "192.168.1.26", (byte)3, 13.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("974f5a0b-174f-4d0b-83b7-7349da8c2adf"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6813), "192.168.1.69", (byte)3, 99.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("97c3cdfc-e480-4361-9231-72f16491a3e5"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6707), "192.168.1.96", (byte)3, 25.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("994697ac-1e59-41b1-bfd4-cf8083562379"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5356), "192.168.1.46", (byte)1, 77.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("99c6a106-a80b-43c1-850f-0d5dfa4745a2"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6771), "192.168.1.21", (byte)3, 26.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("9a2fcb92-3146-43e0-8d40-b0768f4d926c"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6381), "192.168.1.10", (byte)2, 26.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9a629248-f93d-4471-afbe-a66d0d1f12a3"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7570), "192.168.1.49", (byte)3, 68.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("9aaa1b22-45d6-4dff-995e-daf45e1f3206"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5994), "192.168.1.27", (byte)2, 95.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("9b2f7415-bef3-413f-8ab3-0bc8f616ae4f"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6488), "192.168.1.62", (byte)2, 40.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("9b94a04f-46af-43d6-aed2-82ff9411bb8f"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7251), "192.168.1.60", (byte)3, 41.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9bc5352b-f3cd-4441-bb16-b4a183ec7ae2"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4464), "192.168.1.96", (byte)1, 28.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("9bdd32d7-b3f5-40e4-aec3-8a0c624f848b"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7470), "192.168.1.27", (byte)3, 35.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("9d04c61f-2468-4282-94f1-a60445b2399b"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5163), "192.168.1.98", (byte)1, 36.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9d4d7e2e-9915-4415-8ba0-84bd2042f4c1"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6981), "192.168.1.80", (byte)3, 6.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9db21e31-59db-4142-bd49-592e0f10bccf"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6143), "192.168.1.92", (byte)2, 77.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("9e2405fb-35f1-4730-a69a-1bcfb5696ada"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7139), "192.168.1.1", (byte)3, 91.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("9e7cc387-aed6-4c90-af3b-ea4b6e627b23"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5051), "192.168.1.70", (byte)1, 21.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("9e966d23-c988-4344-b64a-4c2e04856622"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5262), "192.168.1.91", (byte)1, 25.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("9f9c017b-4be7-4f2b-9bb3-5e9db6092506"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4890), "192.168.1.19", (byte)1, 11.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9feef475-719c-4742-84f3-737c3283ab6a"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6504), "192.168.1.84", (byte)2, 7.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a09ac3dc-6345-4ccf-8bcb-8b56eda8918b"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5090), "192.168.1.21", (byte)1, 43.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a0a32098-bc9b-482b-99e3-eeea5ae5e192"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6407), "192.168.1.86", (byte)2, 92.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("a0c737fc-e100-4c76-8373-11624b7acdd3"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4833), "192.168.1.15", (byte)1, 8.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a1c3586d-11cf-4b90-a830-ea4cca312a4c"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5171), "192.168.1.20", (byte)1, 10.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("a239a5c0-fb1d-449c-a54e-9d46c42cfee4"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5352), "192.168.1.38", (byte)1, 60.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("a2445f46-a878-4e44-bdbf-ac129dd651ec"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5542), "192.168.1.7", (byte)2, 52.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("a299d9b6-9838-4174-97ad-da6b0dd737fc"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6165), "192.168.1.1", (byte)2, 44.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("a33930ea-7c6c-4bb1-8d4c-a9bd4e3a3ba4"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5968), "192.168.1.9", (byte)2, 61.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("a3603558-257c-4e17-a723-2978c38e3f0b"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7063), "192.168.1.10", (byte)3, 47.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("a3a13242-d597-43d3-b5fd-e4777a165ff6"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6900), "192.168.1.4", (byte)3, 8.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a4113312-6802-4132-8d94-f33069eeb138"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4776), "192.168.1.64", (byte)1, 8.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("a4201540-c8fe-4393-8edf-d8490a4bf4ac"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4950), "192.168.1.44", (byte)1, 90.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a4bf40ce-d375-457e-8a81-ea0c2325d522"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5839), "192.168.1.82", (byte)2, 56.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("a4d53c62-e328-463a-b93e-e204e303295f"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4870), "192.168.1.88", (byte)1, 68.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("a4fcf637-23ae-4b35-b84e-3efbf88aa0fa"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4649), "192.168.1.19", (byte)1, 58.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("a50556c6-e2f6-467a-b6e1-ed3cebbedc7f"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6608), "192.168.1.14", (byte)2, 30.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("a537d0c2-dbbb-4366-91b7-66296a61073a"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5562), "192.168.1.96", (byte)2, 5.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("a5b2a008-4a9a-4478-ab73-1d0e9a987afc"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4908), "192.168.1.46", (byte)1, 37.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("a6236f5f-49f7-4cfa-a74a-7142791d4e5f"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4720), "192.168.1.71", (byte)1, 85.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("a71ae80c-7c7c-44f8-b7a7-cc29e0c1c670"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7075), "192.168.1.72", (byte)3, 83.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("a737dc5e-528f-4188-b1e0-f105ce0859a7"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7027), "192.168.1.21", (byte)3, 89.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("a750ddb5-0a60-4c5e-81ce-ab85d6a135d6"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5085), "192.168.1.21", (byte)1, 81.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("a7559326-a586-49e1-adca-875d3fd3c7a7"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6831), "192.168.1.6", (byte)3, 91.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("a8331ec3-2b82-46c1-9229-0cc9fe6f08bb"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4657), "192.168.1.93", (byte)1, 51.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("a838b41a-305b-44ba-bc16-4854fc0f0c89"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4492), "192.168.1.39", (byte)1, 56.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("a8652205-5dd5-48f2-83ba-28223d8bf4ea"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5715), "192.168.1.16", (byte)2, 39.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("a88fc8a1-8c2e-4f89-bee8-050d5f889a80"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7306), "192.168.1.96", (byte)3, 67.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("a8a8de21-28ca-4977-8a8a-5e04e0f2e126"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7231), "192.168.1.45", (byte)3, 50.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("a8bbc7b9-1b0e-4bb0-8da5-1d52a004da15"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5532), "192.168.1.12", (byte)2, 1.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("a8d19c94-efcc-4dcd-b54c-a3bf4e7ec899"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6444), "192.168.1.87", (byte)2, 56.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("a9596bc1-8988-4a1c-a4bc-4c33e51a9b7a"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5945), "192.168.1.3", (byte)2, 11.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("a982cfc0-f324-4c84-8b51-8c013a3f4364"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7169), "192.168.1.67", (byte)3, 38.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("a98d6b72-bd8d-45dd-a49a-13a37591056c"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7109), "192.168.1.3", (byte)3, 39.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a9cb44fb-72bd-462f-bde6-744a4c753b7e"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7223), "192.168.1.34", (byte)3, 72.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("aa08a56c-d869-4351-aa6b-1f2b2342cbd3"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5008), "192.168.1.41", (byte)1, 74.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("aa3e9111-bd41-4df2-b133-6eb56b90567d"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7444), "192.168.1.26", (byte)3, 15.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("aa431675-5063-4da5-95d6-a3b3d0c3b970"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6835), "192.168.1.66", (byte)3, 43.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("aa82f8ea-f198-4014-92c9-64cbb3ad99f8"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7055), "192.168.1.90", (byte)3, 86.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("aabca9e6-b91f-4f92-83dc-f13ea919b53f"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6904), "192.168.1.25", (byte)3, 42.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("aaf72d87-fb05-478a-8673-aed70cb12a88"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7294), "192.168.1.5", (byte)3, 41.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ab000a90-b92a-451c-9668-40b28a8b2fb2"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6809), "192.168.1.94", (byte)3, 33.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("ab768b0f-32e0-411a-a96c-5bcc145d960a"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7187), "192.168.1.91", (byte)3, 66.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ab7abfe8-6b8b-448b-afad-de80170d9183"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6989), "192.168.1.77", (byte)3, 78.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("abc6d15f-fe5c-4f5d-bc59-4d553d95f9e5"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5626), "192.168.1.86", (byte)2, 49.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("abcfbc8e-b913-4fdd-920c-cf0a25661289"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7119), "192.168.1.51", (byte)3, 43.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ac1653e6-8135-4968-89ba-4ce49980a68d"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5719), "192.168.1.94", (byte)2, 78.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("ace6fd08-f02c-4929-b434-8a332e7e8350"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5982), "192.168.1.50", (byte)2, 88.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("ae359c38-bac4-4bed-866a-36158d2fccbd"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6596), "192.168.1.34", (byte)2, 70.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("ae388690-dbcf-4195-9de2-9e76e0502a21"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6565), "192.168.1.6", (byte)2, 65.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("aebfa85e-50c8-403e-99d8-906541b7cddd"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7007), "192.168.1.14", (byte)3, 20.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("aec58bdd-0659-414e-8fa7-37b30c55bf8b"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5614), "192.168.1.82", (byte)2, 99.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("aef2ee74-7e69-47aa-adf2-4bf7d97f03e9"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6117), "192.168.1.40", (byte)2, 94.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("afb2ef8c-370f-4620-a460-01d875baf85c"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5725), "192.168.1.58", (byte)2, 18.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("afc96b1a-55e4-4e95-922e-e99b31172e1a"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5655), "192.168.1.72", (byte)2, 53.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("b0467eba-cffb-4357-94c4-afa706128ece"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4998), "192.168.1.19", (byte)1, 53.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("b0b920d1-b80c-4e24-bcfd-38cb8f7cde74"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6309), "192.168.1.79", (byte)2, 15.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b0d0c1ac-414f-4de6-979c-65afdf58503a"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7328), "192.168.1.31", (byte)3, 18.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("b103a44d-acbe-44a2-91b2-22facb7ed15e"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6393), "192.168.1.39", (byte)2, 10.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b18721c2-4b1f-4449-959d-47c77dc8ffa4"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6157), "192.168.1.72", (byte)2, 7.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("b1c64ca8-3563-4227-835a-43d634868fb0"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6997), "192.168.1.34", (byte)3, 78.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("b1da6843-1d34-4b5b-b1bc-b500dba37d28"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6963), "192.168.1.98", (byte)3, 74.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("b21a941c-8ca0-4c08-a666-7f8c87395153"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7161), "192.168.1.46", (byte)3, 13.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b2c3e23e-0b95-44a7-84e8-00e06314467e"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5986), "192.168.1.60", (byte)2, 20.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("b2c7c388-7da5-42ec-855d-c18049c34c60"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6703), "192.168.1.17", (byte)3, 9.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b2d4e6bd-2f26-47ea-b070-4f0bad1ffca2"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6470), "192.168.1.20", (byte)2, 13.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("b2ec91c4-7293-4c78-94e1-09f6be52d994"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6373), "192.168.1.63", (byte)2, 93.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("b313dcd7-6f00-475d-81fd-e3a902b0300c"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6638), "192.168.1.11", (byte)3, 15.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b31fe4d3-dd6a-420d-a1ca-58dcbcbeebbb"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5136), "192.168.1.94", (byte)1, 20.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b32cbcee-0af5-4bf3-945f-c35ba554e6da"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7701), "192.168.1.27", (byte)3, 38.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("b425aff3-351d-4a72-8891-112f37746c74"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5578), "192.168.1.72", (byte)2, 94.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("b4ff02bc-cd39-4ec6-b9cb-0489fd66cf45"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5482), "192.168.1.65", (byte)1, 13.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("b5bd7ed0-b34f-41a4-bcb3-e700745ef564"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5059), "192.168.1.5", (byte)1, 93.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("b5eead5c-cf13-4666-89a2-e896b26d6d6c"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5528), "192.168.1.16", (byte)1, 43.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("b61ea21c-5762-4985-beaa-0d1d4ac22068"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4729), "192.168.1.67", (byte)1, 27.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("b64351af-4c91-42ba-99c2-e3daaf41e2f3"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6512), "192.168.1.55", (byte)2, 10.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b683f0db-0aa0-4593-ad1a-1a5ae1725277"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7625), "192.168.1.1", (byte)3, 75.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("b6b0d743-93b7-411e-b6d8-7279a7fe2661"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7276), "192.168.1.36", (byte)3, 24.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b6d85bf4-d69e-4733-9db5-826808f9b23e"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6526), "192.168.1.48", (byte)2, 22.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("b6dd0574-b037-49b5-9031-fa5fbf7b9a8c"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7713), "192.168.1.19", (byte)3, 69.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("b72afa46-d39e-4be2-9584-8ae18dd71d8f"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7478), "192.168.1.48", (byte)3, 44.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("b7dd0448-6411-4ccb-a2ab-12666b6826d6"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6935), "192.168.1.91", (byte)3, 59.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("b808e1a5-5aaa-4fad-bbb7-97e1eda53e26"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7227), "192.168.1.70", (byte)3, 8.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b8670454-a0b5-402a-99f9-a658a91b86f6"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5218), "192.168.1.16", (byte)1, 89.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("b8c6dba4-1f13-40c7-ad97-052b49ae83c2"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4815), "192.168.1.67", (byte)1, 73.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("b8e4a76c-d496-4649-a6c6-94e8c1164a17"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4878), "192.168.1.75", (byte)1, 95.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("b9363ce2-575c-4e06-a840-5bc01e6a7906"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7217), "192.168.1.89", (byte)3, 21.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("b98876ce-eac0-4d81-8cca-7110a6bcdd23"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4916), "192.168.1.93", (byte)1, 99.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b9a23f52-2e72-4484-9f4b-967693a5e311"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6229), "192.168.1.21", (byte)2, 63.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("b9c52fcd-9e98-4625-92b7-dae86e693adc"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6647), "192.168.1.95", (byte)3, 57.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("b9d54dec-8bba-43d0-9b47-ab6bbefa5d7e"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7336), "192.168.1.30", (byte)3, 65.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b9ec77c3-d6b7-4626-bef0-35a8185769f6"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6929), "192.168.1.67", (byte)3, 51.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("b9f8807f-9dac-4efe-8d3d-6816f24da95d"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5004), "192.168.1.66", (byte)1, 78.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("ba2b3412-127c-49b9-9a9b-b463c90d3e82"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4745), "192.168.1.59", (byte)1, 11.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("ba45417b-7552-44b7-a5ac-9c627672e1b9"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7687), "192.168.1.45", (byte)3, 54.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("ba893a67-3fe9-4c51-be99-39728225ad01"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5873), "192.168.1.30", (byte)2, 59.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("bb6707cf-9a38-4443-9380-0959dd8d4429"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6518), "192.168.1.62", (byte)2, 75.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("bb89be57-5156-4edf-884e-fd91758380c2"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7011), "192.168.1.68", (byte)3, 80.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("bc4a0ec8-e043-4b4e-9a59-4d38568697ce"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7256), "192.168.1.36", (byte)3, 83.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("bcd133c7-f696-4c8d-812e-86f66e849f53"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5749), "192.168.1.76", (byte)2, 39.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("bd48ccec-7a22-48df-bce1-f6d85df2cb24"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6763), "192.168.1.9", (byte)3, 35.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("bd89fe51-88e9-4989-97b5-01b71a219eb8"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7269), "192.168.1.65", (byte)3, 95.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("bdcbe321-2ab5-40bb-a1ba-1de6c12988ec"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5073), "192.168.1.68", (byte)1, 87.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("bdd77ce4-27c4-46f5-a327-2b4d08795f15"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6343), "192.168.1.85", (byte)2, 52.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("bdeb2269-9baf-4a03-999a-c62ebada7ab2"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4886), "192.168.1.65", (byte)1, 40.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("be32d277-eaa2-476a-93e7-197863aedf53"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5140), "192.168.1.57", (byte)1, 39.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("bea0ad4f-6a4c-408c-9eef-7a6f2acf033f"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6185), "192.168.1.93", (byte)2, 30.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("beb6f71e-325b-42c2-8f61-56853d6c6874"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4780), "192.168.1.38", (byte)1, 37.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("beb748b0-a108-4e20-a1d8-80c6b0f86f62"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5672), "192.168.1.52", (byte)2, 8.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("bf87e004-4166-4713-9785-209cb5e8e1c0"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5230), "192.168.1.95", (byte)1, 78.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c0618434-9791-4912-ba7a-9e83a3b8e691"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5690), "192.168.1.52", (byte)2, 1.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c0aca9c1-a76d-4f3f-a097-990914a77e94"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5486), "192.168.1.75", (byte)1, 14.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c0e21637-fea9-42ec-a613-f621fd41da47"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4972), "192.168.1.86", (byte)1, 18.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("c1680c8c-201c-4c4c-9821-ea03a0387d86"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4787), "192.168.1.18", (byte)1, 16.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c1c9a168-fc50-415e-b4e6-188fa3009714"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5893), "192.168.1.24", (byte)2, 57.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("c203ccdf-57cc-41dc-aff5-6ba2e5308055"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6857), "192.168.1.60", (byte)3, 9.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c256f635-b7fd-48b1-8659-f531e995863e"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7683), "192.168.1.18", (byte)3, 79.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c2713f13-7ef3-4b81-8374-555451620d91"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5706), "192.168.1.93", (byte)2, 57.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("c276dc58-6b6d-4fbe-ac44-992066943b3a"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6135), "192.168.1.92", (byte)2, 93.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c289495b-edf6-47f5-9b4f-8467012a64a6"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6917), "192.168.1.81", (byte)3, 8.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("c2f24923-65b4-4fea-a862-01f6ec7c733b"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5524), "192.168.1.40", (byte)1, 57.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("c42a1767-522d-4897-b22f-73ffb8d3bc4b"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7264), "192.168.1.22", (byte)3, 99.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("c4c5ed37-f259-4baf-9f2c-2c330ed66aaf"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5284), "192.168.1.19", (byte)1, 61.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("c50516c7-4385-45eb-8283-0cc290a042d9"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7544), "192.168.1.66", (byte)3, 97.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("c58344aa-c81b-4de7-b996-75d1d37b461a"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4686), "192.168.1.9", (byte)1, 87.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c5d984e1-95eb-4f1b-95e4-113c82bc9a0d"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7592), "192.168.1.94", (byte)3, 51.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c6208837-469a-4b53-a53f-608d137ff82a"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6028), "192.168.1.39", (byte)2, 48.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c628906b-0219-4d97-a022-956ea2a04761"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5554), "192.168.1.55", (byte)2, 42.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("c62ae190-570e-4fa3-87e8-fc9c1ce12d8d"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7377), "192.168.1.95", (byte)3, 77.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("c6ef917c-da34-4218-a953-fe415a9ebb54"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4716), "192.168.1.14", (byte)1, 30.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("c72b9fe0-af88-4342-8cf8-76b4d99e7dfc"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6397), "192.168.1.53", (byte)2, 46.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c73c6256-6dcf-4332-bfd7-baae0a566c86"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7557), "192.168.1.72", (byte)3, 40.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("c7e5bdba-1f59-42cb-a1a8-6cf400b1f8f7"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6020), "192.168.1.42", (byte)2, 11.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c93cb455-86c8-41a3-9e6e-6d291aec69e6"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4984), "192.168.1.95", (byte)1, 93.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("c94707b7-569d-4347-b759-fd5b1997ab24"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5941), "192.168.1.29", (byte)2, 76.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c96d744a-de85-4e88-a59d-a0a08ce6d40b"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5855), "192.168.1.3", (byte)2, 57.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c9831751-d474-4ed1-b508-7c7bbb561cb0"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6951), "192.168.1.66", (byte)3, 18.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c9d6a753-9526-4efa-be7a-4d7e0496fe03"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5222), "192.168.1.53", (byte)1, 28.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c9ed6a41-00ee-449f-8610-1af5c4b45188"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5911), "192.168.1.17", (byte)2, 45.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ca9823a5-b8c4-4e56-ac8b-f2a970214ded"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6181), "192.168.1.82", (byte)2, 20.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("caf225f3-d3ac-499a-ae47-8ab2ad8b9b45"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5443), "192.168.1.6", (byte)1, 47.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("cb076945-d73c-4b1c-9010-e23841383360"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6333), "192.168.1.64", (byte)2, 54.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("cbd46b7d-dc9d-44e5-9e7b-bc18b84e774a"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7368), "192.168.1.77", (byte)3, 96.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("cbdf2748-dfa2-418e-872e-b43655bbb5b2"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6805), "192.168.1.29", (byte)3, 23.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("cc4590c6-d6f8-4952-95ef-040487935479"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5452), "192.168.1.99", (byte)1, 0.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("ccaaa8e1-93ea-459c-beb5-428d7647b420"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7460), "192.168.1.21", (byte)3, 53.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ccaab503-a554-4ce2-9025-0a0de644e75a"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6873), "192.168.1.45", (byte)3, 40.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("ccdd15d7-0cf1-4cbc-a83b-910a2ff73fe4"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5099), "192.168.1.43", (byte)1, 80.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ccec45b5-c4c1-46f5-bdfc-819cabc536ff"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6925), "192.168.1.96", (byte)3, 78.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("cdad7154-026f-474b-b50c-f196c52cde23"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5550), "192.168.1.96", (byte)2, 52.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("cde0a436-079f-403e-b8a6-ee78b25382ab"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5294), "192.168.1.3", (byte)1, 15.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("cf24f61a-faf2-4fb0-bc85-1c71d8305b17"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5520), "192.168.1.22", (byte)1, 60.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("cf5cf6d8-ce07-493c-8752-34d3ada7bd36"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5314), "192.168.1.81", (byte)1, 81.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("cf6a49c8-6483-4a84-8e68-c7fd52af1f6b"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6037), "192.168.1.61", (byte)2, 77.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("cf6a577c-dd9c-4861-bfc5-94f869189e1e"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5881), "192.168.1.19", (byte)2, 32.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("cfdd1f15-4499-486e-947a-6be2f86e18fe"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6973), "192.168.1.78", (byte)3, 89.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("d029b4e3-ce1c-4e9f-b926-557f1c7976fb"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4571), "192.168.1.26", (byte)1, 11.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("d07f73be-7026-4570-98f2-bd420913f347"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7430), "192.168.1.61", (byte)3, 80.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("d18a49b6-bd3b-4565-8ff9-298459763300"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7101), "192.168.1.8", (byte)3, 28.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d1acdadd-a2c9-4e6f-9f8a-2ddb4a1d81de"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6522), "192.168.1.39", (byte)2, 47.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d2084bbb-ef70-4de6-9dcc-125a9d17df48"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6287), "192.168.1.70", (byte)2, 78.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("d223c31b-10fa-41c2-8fa2-3f6b75874bb4"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5813), "192.168.1.66", (byte)2, 93.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("d27cfd55-d9c6-4583-be4a-f0a203f6f79c"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5659), "192.168.1.8", (byte)2, 91.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("d3446309-bb6a-4128-a079-fa79bf204e16"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7143), "192.168.1.88", (byte)3, 94.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("d44e81a3-87f3-45f3-9812-dc28f2b67437"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6084), "192.168.1.84", (byte)2, 24.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d538cd6b-f113-4b66-94bd-4ae837d026e3"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5877), "192.168.1.47", (byte)2, 58.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("d5a3f3a0-1571-4c1a-a319-4e717a28bc79"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4543), "192.168.1.61", (byte)1, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("d660c8e0-2561-402f-980f-f6b6a9489add"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5490), "192.168.1.45", (byte)1, 71.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("d67b493d-935a-4544-96c3-e96cc92cc462"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5213), "192.168.1.97", (byte)1, 36.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("d698e3b8-7040-4543-8604-bf804af898ab"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7019), "192.168.1.5", (byte)3, 76.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("d69d3c12-3b90-48fb-a881-12ad27293b38"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4512), "192.168.1.92", (byte)1, 80.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("d82e6967-99a8-4885-b894-db5fd807c205"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5859), "192.168.1.28", (byte)2, 34.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("d8af1f29-0784-45ff-86c3-be652fe07ddd"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5175), "192.168.1.58", (byte)1, 5.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("d8c3cf32-06fb-4b12-a009-55ba3be51bd6"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7085), "192.168.1.92", (byte)3, 73.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d9222686-0f09-4d23-945c-77d496c6ea1b"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5094), "192.168.1.74", (byte)1, 78.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d9421711-35a9-48d8-9c7d-275774c4cc0d"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6719), "192.168.1.45", (byte)3, 94.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d95e77a4-c659-46b0-bc5a-f9b1ce748386"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7440), "192.168.1.42", (byte)3, 47.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("da00baa6-44c6-402b-8302-a4b047b126e8"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5243), "192.168.1.6", (byte)1, 29.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("da737ad9-b2f9-4a4c-962e-3c03cb47021d"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5063), "192.168.1.44", (byte)1, 73.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("da793be3-b49e-4c04-a0c0-d9f419628892"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5498), "192.168.1.12", (byte)1, 56.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("db184d4f-8bf1-4e04-aff8-c92d16a19e66"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4751), "192.168.1.28", (byte)1, 37.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("db290ce0-c0be-4c57-a381-6f5f008eeb89"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4976), "192.168.1.99", (byte)1, 91.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("dbdc555e-bb38-4184-90ee-5a66f6552778"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6046), "192.168.1.57", (byte)2, 9.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("dc1cc832-f4ab-4f2f-96b1-a448f37675a4"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5863), "192.168.1.48", (byte)2, 15.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("dc47e231-2761-4552-bb1d-2ab6b952769b"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7474), "192.168.1.93", (byte)3, 39.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("dca0ed07-a4d7-4392-b520-509ababe40c0"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6215), "192.168.1.37", (byte)2, 41.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("dcb8fa30-5017-4203-abd3-8f620a2d4258"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7031), "192.168.1.80", (byte)3, 70.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("dd4824cf-5fab-48d1-80ed-2920bd265a4d"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4920), "192.168.1.99", (byte)1, 37.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("dd54405c-7846-4b8d-a59d-9bf2be53eb44"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5558), "192.168.1.36", (byte)2, 44.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ddf5575d-47d1-47bc-9f6b-fe6e9a187cf6"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5205), "192.168.1.87", (byte)1, 1.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("de33c90e-3d17-4a9a-88cc-58a6c7eb971f"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6191), "192.168.1.33", (byte)2, 67.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("dea25268-baaf-4614-b37b-fafda1fdd384"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4520), "192.168.1.51", (byte)1, 53.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("df3a76b2-ccec-490e-ba47-0450407a38cb"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5869), "192.168.1.68", (byte)2, 79.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("df51d8c0-81bc-4d05-845c-d0b1c5d9bccb"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4623), "192.168.1.37", (byte)1, 97.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("dfac4d15-08df-4eb6-aaed-6f1f377dc839"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7332), "192.168.1.54", (byte)3, 59.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("dfc4a78d-4e2c-48c3-bd80-1a36065bfc6a"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7310), "192.168.1.37", (byte)3, 4.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("dffd61aa-5a48-4056-9a1b-5ff2ccbcc017"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6177), "192.168.1.57", (byte)2, 3.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("e02d6b5f-056e-4d00-a9c5-ef1233159e07"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5028), "192.168.1.82", (byte)1, 18.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e04c77c8-ce21-4e77-b11f-07067f268d7f"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7527), "192.168.1.82", (byte)3, 96.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("e080b88a-d9ae-49cd-ab03-0ccd6d3d31e8"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5741), "192.168.1.28", (byte)2, 16.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("e0f0ec87-4558-40cd-9f37-a2843dba09c0"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4803), "192.168.1.41", (byte)1, 89.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("e2b3b938-fc81-475a-b1e3-d46b2793c52f"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6699), "192.168.1.14", (byte)3, 78.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("e2d59c3d-06e7-4a80-8da0-1c6449f0cb28"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6886), "192.168.1.87", (byte)3, 97.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("e337526f-3dc6-46bf-a175-6ab8503f907e"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5573), "192.168.1.57", (byte)2, 83.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e370a57c-73e5-42a5-aa45-320c2e566257"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7607), "192.168.1.56", (byte)3, 51.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("e3a50789-8f9b-4baf-a6be-aedcb75006e5"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6351), "192.168.1.51", (byte)2, 97.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("e3e85131-c444-4fc2-a80f-fe65c7659351"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4531), "192.168.1.17", (byte)1, 26.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("e4005056-2833-4771-b25c-9f703deaf9b3"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6959), "192.168.1.97", (byte)3, 21.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("e430f0b3-9605-4fc2-a555-e5f0e0c88b0a"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5668), "192.168.1.73", (byte)2, 77.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e46e50af-2142-4c16-bce2-f3604ceefb64"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7691), "192.168.1.87", (byte)3, 26.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("e4df6764-f546-4b57-92ff-d5592a0dde64"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7135), "192.168.1.5", (byte)3, 67.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("e58211ac-2a9a-4f65-8a7b-1b72fb706af1"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6466), "192.168.1.61", (byte)2, 76.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("e63ccbba-9205-4568-9cba-a1620ebc1c89"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4678), "192.168.1.10", (byte)1, 73.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("e648c28d-7277-4336-868b-2eab18ff5995"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6651), "192.168.1.33", (byte)3, 34.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("e702ffa0-8f0b-48cd-af1d-0bd15d65c6e8"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6847), "192.168.1.43", (byte)3, 46.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e76d7bb3-6ae6-434d-968d-b02cad868ca8"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5128), "192.168.1.37", (byte)1, 24.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e866c629-6f72-47b4-996e-2853ce141b8b"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4829), "192.168.1.77", (byte)1, 46.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("e8b22579-3be8-405a-8f67-ba81995498e5"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4619), "192.168.1.88", (byte)1, 74.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("e90da3f8-6437-4e93-9a93-914eadbc9b3e"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4508), "192.168.1.94", (byte)1, 61.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("e9519a31-29c6-4bc1-a203-556c3216719d"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4641), "192.168.1.50", (byte)1, 34.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("ea3d6389-15f4-492d-8314-3fcbacab8df5"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4600), "192.168.1.31", (byte)1, 27.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ea4d5c9a-932b-4036-96fe-f140c105de0a"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5478), "192.168.1.19", (byte)1, 76.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("eaa88228-0eee-4d9f-9b3d-3fd6933369a2"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5711), "192.168.1.56", (byte)2, 88.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("eacdb2e6-3807-4c96-908b-bfe7914361ac"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5253), "192.168.1.12", (byte)1, 2.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("ead8d27b-3e46-4731-8d28-2624ea4d64ee"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5328), "192.168.1.29", (byte)1, 67.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("eadeb688-0792-47f2-babf-68a4793f4530"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4481), "192.168.1.57", (byte)1, 7.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("eaf68f3d-df12-446c-a46e-c8c42703798f"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7302), "192.168.1.37", (byte)3, 9.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("eb39d10e-a27d-4a90-b726-b01bae74b8af"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7385), "192.168.1.11", (byte)3, 3.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("eb7e9533-9572-4157-acfc-fc19957b614a"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6612), "192.168.1.62", (byte)2, 64.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("ebee5023-d885-47c0-b6e0-79d650e9066b"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7705), "192.168.1.78", (byte)3, 97.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("ebf01160-25e2-42bc-9d9e-95a379f50949"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5702), "192.168.1.63", (byte)2, 21.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("ec1ea3c8-a3b2-4d2b-a1fd-92aa1acad4ae"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5460), "192.168.1.18", (byte)1, 52.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ec4afcdb-49b2-479b-acde-d469a9f1ebfa"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7561), "192.168.1.58", (byte)3, 3.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("eca2ce30-e830-4fab-a1fd-651e87d7d338"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7235), "192.168.1.62", (byte)3, 33.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ecb1d180-5273-4312-b7ac-295d5d3f054e"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7418), "192.168.1.48", (byte)3, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("ed0008cf-3fc4-480f-b558-5807e6b73b07"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5318), "192.168.1.47", (byte)1, 36.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("ed12e385-3457-4a35-ba7c-6d94ea734680"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7393), "192.168.1.20", (byte)3, 60.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ed2f613c-c5d2-42bf-8f37-7d0bd1d50396"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6347), "192.168.1.16", (byte)2, 37.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("ed35a494-6472-4c1b-b4f9-ca70771c0f56"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5396), "192.168.1.66", (byte)1, 1.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ed71b7c8-2ed7-4888-859c-6407a0e5951e"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5622), "192.168.1.82", (byte)2, 44.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("edd54119-716c-4f73-9e30-785f59ea831d"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7633), "192.168.1.9", (byte)3, 52.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("edfebf99-bacb-4e45-ad11-a88288f137d4"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6279), "192.168.1.33", (byte)2, 46.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ee958bdb-fd0e-49b8-b1ea-50c0a40d2927"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6295), "192.168.1.51", (byte)2, 81.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("eebd4f28-610c-4d21-abef-5516e40325ba"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4942), "192.168.1.63", (byte)1, 86.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("eec83151-9a89-4c48-9a89-392f67d73628"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7452), "192.168.1.6", (byte)3, 96.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("eee032ee-1364-4617-bdb9-3f1a1ae317e1"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4980), "192.168.1.69", (byte)1, 65.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("ef65057e-791a-430e-b956-f286d43183e5"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5889), "192.168.1.48", (byte)2, 12.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("ef840b61-204c-4bc2-8fdb-ec1c46841395"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6792), "192.168.1.79", (byte)3, 32.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f10e40b8-d25c-4acd-8d5a-3294a659baf6"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6908), "192.168.1.43", (byte)3, 82.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("f1594ff5-ca2a-424f-a88a-bf729a145941"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5167), "192.168.1.46", (byte)1, 82.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("f1ce63aa-b43d-4370-b12a-ee87599a0f2b"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5843), "192.168.1.78", (byte)2, 62.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("f1e1de64-f685-4ae7-a375-6f49d353a8d4"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4741), "192.168.1.7", (byte)1, 45.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f20eb996-2fb2-41fe-86de-8913330150fa"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6685), "192.168.1.88", (byte)3, 66.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f2111741-b125-42dd-85dc-7e4f18761b07"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4699), "192.168.1.69", (byte)1, 79.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("f271d892-56f8-4116-9728-fd5aeabfdf24"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7209), "192.168.1.10", (byte)3, 53.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("f2a245d0-6f9b-4f09-8d0e-7361e2ee7543"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4821), "192.168.1.39", (byte)1, 96.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("f2c19a6f-1f52-48a6-8e95-2aacfb82cb50"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7599), "192.168.1.69", (byte)3, 98.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("f2d14de0-c3bf-4633-85f2-95a638e4a044"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6305), "192.168.1.96", (byte)2, 22.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f3531614-6ced-470d-9a08-931bcffcd088"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7645), "192.168.1.12", (byte)3, 97.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f391c6d9-34c2-40c2-a7ae-9c98636ca51d"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7165), "192.168.1.42", (byte)3, 33.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("f3aeabf7-e384-4a16-a201-b87f1131af9b"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7059), "192.168.1.85", (byte)3, 20.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f3b2b0f8-72e3-4cc3-bd26-9c6bd227b160"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6534), "192.168.1.6", (byte)2, 26.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("f3cf127c-89c0-4b8f-89d6-3f3a3beca97c"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5759), "192.168.1.86", (byte)2, 75.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f3d97270-4307-425a-8a46-307cc639b6e4"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4760), "192.168.1.39", (byte)1, 83.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("f43d9358-9163-44a4-84be-e145ba46d86f"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4791), "192.168.1.17", (byte)1, 62.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f4c77c84-d177-4d21-a7a3-c580b82ea7d8"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5197), "192.168.1.86", (byte)1, 86.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f5005aa4-3c40-4265-9602-3c963c3974f4"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4882), "192.168.1.1", (byte)1, 39.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f5241ef3-7557-4902-90fe-1ffbbc8a316a"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6801), "192.168.1.50", (byte)3, 81.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("f57989bf-6a0b-4007-9871-589e19d6b348"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6249), "192.168.1.51", (byte)2, 47.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("f5fb1897-a52d-4840-94f9-4f6d5600a0fc"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7183), "192.168.1.58", (byte)3, 34.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("f6754371-9084-4588-9703-43d37d9ef8d3"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7549), "192.168.1.72", (byte)3, 19.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("f6d65af9-348c-46ec-b4fe-e6d7f438d217"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7679), "192.168.1.25", (byte)3, 64.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f74106ee-7927-4b8d-8c28-43abd04eeb97"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5374), "192.168.1.52", (byte)1, 28.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f83ded07-650c-4160-947e-53da244e918a"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6977), "192.168.1.34", (byte)3, 39.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("f8865a73-635f-40ff-b82f-dbe9ae991b85"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6913), "192.168.1.71", (byte)3, 34.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f8ac2916-9911-4485-bbdd-12fc4fd0aa63"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6823), "192.168.1.56", (byte)3, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("f8bf75ce-e2fa-49aa-a8f7-88912c8721b3"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5055), "192.168.1.45", (byte)1, 32.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("f913d1ea-e67e-46e4-934a-ac6cb87613da"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6673), "192.168.1.14", (byte)3, 42.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("f9ac803a-2662-4143-8826-733dc0fcb56b"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5694), "192.168.1.30", (byte)2, 79.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f9d8fa0b-b124-4ffe-8a4e-63aa79b57769"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7023), "192.168.1.31", (byte)3, 51.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("fa18f1ab-4afd-42c8-8c66-726386630018"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6363), "192.168.1.45", (byte)2, 97.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("fb0c23fd-4f69-4534-8c3e-4217e9c0dedd"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4772), "192.168.1.71", (byte)1, 61.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("fc4fd369-8551-43d1-866b-292af0af7831"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5378), "192.168.1.88", (byte)1, 96.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("fc574bde-896f-4376-8140-3badcbe87920"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6600), "192.168.1.63", (byte)2, 65.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("fcd79419-74ea-4e00-8509-c8871ab13192"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4674), "192.168.1.54", (byte)1, 14.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("fd1e4e52-5deb-4830-9480-5939c892c510"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(6659), "192.168.1.52", (byte)3, 33.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("fd31f50c-a10e-4de2-aad3-af88cca244d6"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4575), "192.168.1.46", (byte)1, 80.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("fd484c73-52b4-4707-9881-fa826b837533"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7389), "192.168.1.29", (byte)3, 9.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("fdb3a8d7-9083-4c2a-8df8-a3f363585f1b"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(7358), "192.168.1.77", (byte)3, 42.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("fdce7252-9205-44e4-beb3-cd3b63a58fe1"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5209), "192.168.1.74", (byte)1, 88.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("fdfe737b-21b9-47e7-bcd8-02662906e3a6"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4539), "192.168.1.77", (byte)1, 14.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("fe7829ef-824f-4b45-8bc5-76ab9005ce62"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5698), "192.168.1.81", (byte)2, 51.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("fea17df9-f957-46e2-8ffe-99ec9ce7b824"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4958), "192.168.1.86", (byte)1, 37.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("fea68a34-5841-4c9d-8ddf-6a883decaf60"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4615), "192.168.1.43", (byte)1, 48.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("feaf8377-d83a-49c9-b51a-aa9f520dccc5"), "Computer0", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(4496), "192.168.1.37", (byte)1, 68.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("feff8cec-16f8-4784-8ac6-8add870851eb"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(5729), "192.168.1.47", (byte)2, 73.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "City", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "District", "FirstName", "LastName", "MobilePhone", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "WorkPhone" },
                values: new object[,]
                {
                    { new Guid("2609c5fa-8260-4942-aa15-310ec98ea5ee"), "Örnek Mahallesi, Örnek Sokak No: 10", "Örnek Şehir", "Computer10", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(9932), "192.168.1.10", "Örnek İlçe", "Mehmet", "Kara", "5552109876", null, null, null, "5557890123" },
                    { new Guid("8618be4a-9345-4805-9e20-7b751ce1a48d"), "Deneme Mahallesi, Deneme Sokak No: 8", "Deneme Şehir", "Computer8", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(9925), "192.168.1.8", "Deneme İlçe", "Ahmet", "Sarı", "5554321098", null, null, null, "5556789012" },
                    { new Guid("a10d5dce-fa04-448f-a046-580959191be4"), "Test Mahallesi, Test Sokak No: 3", "Test Şehir", "Computer3", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(9913), "192.168.1.3", "Test İlçe", "Mehmet", "Demir", "5552345678", null, null, null, null },
                    { new Guid("a9996656-58b7-43c7-a2cb-2b8ce8c77bbf"), "Deneme Mahallesi, Deneme Sokak No: 5", "Deneme Şehir", "Computer5", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(9917), "192.168.1.5", "Deneme İlçe", "Mustafa", "Aydın", "5553456789", null, null, null, null },
                    { new Guid("d06bd259-e8ae-4ebc-ae63-6f604216e145"), "Test Mahallesi, Test Sokak No: 6", "Test Şehir", "Computer6", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(9921), "192.168.1.6", "Test İlçe", "Zeynep", "Erdoğan", "5556543210", null, null, null, "5555678901" },
                    { new Guid("d6b896fd-a953-4600-b7b5-3afd9d6f3d1e"), "Örnek Mahallesi, Örnek Sokak No: 4", "Örnek Şehir", "Computer4", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(9915), "192.168.1.4", "Örnek İlçe", "Fatma", "Şahin", "5558765432", null, null, null, "5554567890" },
                    { new Guid("df7bd196-a0b2-44d1-9bb0-59ab1c13fff5"), "Örnek Mahallesi, Örnek Sokak No: 7", "Örnek Şehir", "Computer7", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(9923), "192.168.1.7", "Örnek İlçe", "Emine", "Kurt", "5555432109", null, null, null, null },
                    { new Guid("e1917ca5-956e-42bd-85b9-410c8bead315"), "Deneme Mahallesi, Deneme Sokak No: 2", "Deneme Şehir", "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(9911), "192.168.1.2", "Deneme İlçe", "Ayşe", "Kaya", "5559876543", null, null, null, "5553456789" },
                    { new Guid("effe2ba4-7dbd-4e38-b91a-8054aae96271"), "Test Mahallesi, Test Sokak No: 9", "Test Şehir", "Computer9", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(9927), "192.168.1.9", "Test İlçe", "Fatma", "Can", "5553210987", null, null, null, null },
                    { new Guid("f75d247f-baba-4ba3-9313-fc0beefcf7a0"), "Örnek Mahallesi, Örnek Sokak No: 1", "Örnek Şehir", "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 877, DateTimeKind.Utc).AddTicks(9901), "192.168.1.1", "Örnek İlçe", "Ali", "Yılmaz", "5551234567", null, null, null, "5557654321" }
                });

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("15b6a548-4045-4892-904a-aeeba517960d"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("bd914d22-1482-497d-a552-6926b915f669"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("c0340c3c-9153-4951-969d-1b0136758af7"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("fb221081-45cd-42be-abd4-45976e996233"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Department", "FirstName", "LastName", "MainCourseId", "Role", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("0405895f-9d73-4e0e-b57d-4baee271af7f"), "Computer10", new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(3281), "192.168.1.10", "Tarih", "Mehmet", "Kaya", new Guid("66666666-6666-6666-6666-666666666666"), "Öğretmen", null, null, null },
                    { new Guid("1f65eb90-d5d1-400d-8e19-b014b5c7d97f"), "Computer5", new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(3275), "192.168.1.5", "Fizik", "Ali", "Demirci", new Guid("44444444-4444-4444-4444-444444444444"), "Öğretmen", null, null, null },
                    { new Guid("523e7258-f694-4a51-910a-22d078da649b"), "Computer4", new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(3273), "192.168.1.4", "Biyoloji", "Fatma", "Şahin", new Guid("33333333-3333-3333-3333-333333333333"), "Öğretmen", null, null, null },
                    { new Guid("9ee0a1e4-2afc-46ff-80de-f53957479eed"), "Computer1", new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(3262), "192.168.1.1", "Matematik", "Ahmet", "Yılmaz", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null },
                    { new Guid("ab0f7275-9fce-43a1-b136-f656e756eb0b"), "Computer13", new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(3293), "192.168.1.13", "Müzik", "Seda", "Demir", new Guid("99999999-9999-9999-9999-999999999999"), "Öğretmen", null, null, null },
                    { new Guid("bfc629f7-35c0-4ab0-8bc5-fd643a275f8b"), "Computer2", new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(3268), "192.168.1.2", "Matematik", "Ayşe", "Demir", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null },
                    { new Guid("ce0dfa59-fe95-43f3-b8f2-369c77f886ed"), "Computer3", new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(3270), "192.168.1.3", "Türkçe", "Mehmet", "Kaya", new Guid("22222222-2222-2222-2222-222222222222"), "Öğretmen", null, null, null },
                    { new Guid("daa3695e-2665-4c72-83f5-d71ad2a48a78"), "Computer6", new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(3279), "192.168.1.6", "Kimya", "Zeynep", "Yıldız", new Guid("55555555-5555-5555-5555-555555555555"), "Öğretmen", null, null, null },
                    { new Guid("e21c601c-0885-41fa-b002-f3d8cb2b7b45"), "Computer11", new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(3287), "192.168.1.11", "Coğrafya", "Ayşe", "Yılmaz", new Guid("77777777-7777-7777-7777-777777777777"), "Öğretmen", null, null, null },
                    { new Guid("e2d4d9d8-def0-472f-a3d3-c7b257796ba0"), "Computer14", new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(3295), "192.168.1.14", "Görsel Sanatlar", "Burak", "Korkmaz", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Öğretmen", null, null, null },
                    { new Guid("e77ac035-eb28-4c3e-a024-4351a050a31e"), "Computer12", new DateTime(2024, 2, 9, 11, 24, 35, 878, DateTimeKind.Utc).AddTicks(3290), "192.168.1.12", "İngilizce", "Ahmet", "Çelik", new Guid("88888888-8888-8888-8888-888888888888"), "Öğretmen", null, null, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomMainCourses_Classrooms_ClassroomId",
                table: "ClassroomMainCourses",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomMainCourses_MainCourses_MainCourseId",
                table: "ClassroomMainCourses",
                column: "MainCourseId",
                principalTable: "MainCourses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomTeachers_Classrooms_ClassroomId",
                table: "ClassroomTeachers",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomTeachers_Teachers_TeacherId",
                table: "ClassroomTeachers",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParentStudents_Parents_ParentId",
                table: "ParentStudents",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParentStudents_Students_StudentId",
                table: "ParentStudents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeachers_Students_StudentId",
                table: "StudentTeachers",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeachers_Teachers_TeacherId",
                table: "StudentTeachers",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomMainCourses_Classrooms_ClassroomId",
                table: "ClassroomMainCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomMainCourses_MainCourses_MainCourseId",
                table: "ClassroomMainCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomTeachers_Classrooms_ClassroomId",
                table: "ClassroomTeachers");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassroomTeachers_Teachers_TeacherId",
                table: "ClassroomTeachers");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentStudents_Parents_ParentId",
                table: "ParentStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentStudents_Students_StudentId",
                table: "ParentStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeachers_Students_StudentId",
                table: "StudentTeachers");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeachers_Teachers_TeacherId",
                table: "StudentTeachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentTeachers",
                table: "StudentTeachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParentStudents",
                table: "ParentStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassroomTeachers",
                table: "ClassroomTeachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassroomMainCourses",
                table: "ClassroomMainCourses");

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("00fd1fc4-df32-4559-a346-c2784e3b58bc"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("0b1b4b9a-fbd8-4114-9ada-82418a48bd3f"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("0c308948-176d-4c7f-aa53-e20e62ff9b5d"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("0e3f14f6-3c82-47ce-a03e-b0e794ad64c0"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("153430f2-7a1d-4708-9f62-61886108c45e"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("1610a6d1-ae4e-49db-b2f8-f0e7844385de"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("17380b9b-e0df-4459-90b5-15eba0f2ba5d"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("175834fe-7c99-4970-b446-c2e8011a8054"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("193ad920-4870-437b-8e40-8d6bd3db58c9"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("20fe5e20-704e-4cc3-8e07-c2e81f9b3308"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("27eeabe3-06f3-47c3-bea8-54eb4854262a"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("2fb1d50f-5c20-4c27-9ad4-ff6a2630fa1a"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("355f2be1-e78a-410b-8da6-7dc066151613"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("3703c4b6-49d9-4026-aef9-f3a9242a7f20"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("38f9adc4-da0a-4516-a021-5d9ec40ae22e"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("3dd0b1cb-d31a-43b6-aff9-a4ed00e4a21d"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("42fa7986-6309-4637-a847-ad85d8600ba9"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("4307566a-27f4-4c0f-bd23-cd01419673c8"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("4b3118aa-2fed-4478-b02b-030992ed9e80"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("507f4c27-11d0-4648-a2bb-baa435a013ee"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5203b6f7-01e5-4f23-b993-99f8b24c61b3"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("57c6f419-e885-4292-a378-8875df83067d"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5a1e701e-e363-4f02-b844-43dfd372b57c"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5b9aabb2-52f6-4fba-8a77-8264afcdd854"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("645628d1-de1a-45b5-8979-916628db5268"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6c1f6d7e-064e-43a1-92b0-5cd9568b7e63"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6c303839-d9a6-499a-8c36-13fac8dbc6ef"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6c93fa18-1b18-41fa-8b24-57821848bd3a"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6ff0c7c4-8d24-4c91-b39e-3883d43a14a6"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6ff57482-267a-46fc-9821-9711776bbfec"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("743d70c4-e627-45f6-8102-7f7e67cf7426"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("77adba9c-6a16-44b8-a22c-ab735bfbfb83"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("81565a02-c64a-4050-b3e9-b83642814b09"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("88343907-458d-4cba-8242-736b2eac5321"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("89673165-415b-4ef2-86d1-09bd603b9b99"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("8a45ef2d-0758-4b8c-a179-4ed63006f097"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("909ade28-2504-4d1a-a84d-aca0f7619d53"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("976a8bfe-91cd-4eeb-b494-3180709c707a"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9905949c-2e2b-4e35-9506-442b62c86250"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9953611a-e537-4c59-bd63-a870ca592940"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9d75937e-45e2-469d-8bc6-cdc3934c3f5e"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("a345665b-470c-4509-b4b0-b403fb9db979"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("a77809ba-88d9-44dd-a170-a83801f00faf"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b026b295-4163-42ad-802b-cdd33f260a95"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b0b1a452-9a62-42d3-8b3f-657f195004ac"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("bddc4ba6-507d-4f27-a215-b82287d630b1"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("bea1a88e-c9db-4e4d-803a-45d76c0220a3"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("c2a84ed0-ab19-421e-842f-8d1c5ed03821"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d33fe51b-e66d-4d1a-a82d-3b1a9bb80870"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d8dd3ded-7db3-4244-8be0-56d6caee75c5"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d8e8ff9b-2a31-4aae-a599-c680f188bfb0"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("dd64b2b6-0ba8-4f72-b60b-963a28a517fd"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("e4b809dc-0411-4104-9bae-cf53a1a69e5b"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("e7fc7d6d-1aac-4e28-8848-63da3c19a9e7"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("eebeb643-4342-488c-91a2-d3a6904c55c9"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f1922319-e724-46fb-87e2-49d4be57f9b9"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f3f9a646-9fd2-4905-8864-0d1f8e5b0b2d"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f9440256-e7e6-4c21-b131-bcd0bfb333eb"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("fad61031-1b7b-4f11-9b03-384ff1cc9f14"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("fcd82280-a053-4184-95e0-a4624b52aebe"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("00a346fc-2e07-4725-a690-6803ec170780"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("013c1bbc-cceb-4f6b-b457-5a19eaa062f4"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("0143b903-b64f-45f2-9cb3-3e49d042a0e8"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("149b1a9d-9f80-4be0-be4e-48d60ed41ac3"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("25fbdb7f-9283-4f06-993e-704236a2eb62"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("26f534ee-6c80-4438-bdee-84a17b0ccb58"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("2e249717-0df0-4e50-b5c5-fe4e3af0bc21"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("32703f9e-ca0f-4ea8-8ef5-05453d16c168"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("3322b773-6f30-47ce-918a-feae340ba04f"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("343ab01a-2263-4fc9-95f2-c0a71890390d"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("4ccebd5f-eb38-48ba-a3ee-9d7ae458ab89"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("4d557f27-49bd-416c-afc2-fae1fe5a5d88"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("558c2a24-b00d-4813-a2cf-417d10279172"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("5f18ad86-ad69-4d82-bdd6-c48abdffe3d4"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("6d228ced-1826-497c-b875-2483222df0da"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("6d4a3863-901a-424c-8413-2093f48fbd17"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("7153b3f9-f583-4d81-b15c-c0e1762bb1a2"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("7b12011c-aa5c-4a9e-889b-8bf0f0f9c04e"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("7bafd3b7-f735-4196-9edf-52328072ea81"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("7df04418-26e6-4b56-a45e-42551abdb31f"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("7eea1f6c-3d6f-46bc-85db-769bb78fddac"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("824d0004-b37f-4c76-9496-9a14ec357fbe"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("82ae1eb4-34a0-4134-b54b-6a2bbfba73e2"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("85ec9c7b-b05f-47d2-a487-583c80bb5096"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("8ab1a7c1-a4fb-4bb1-9ccb-fc4f80d1edb3"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("8be08864-8ada-4bd9-a766-3ed8d51b3200"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("8f427456-2575-4176-aaa9-ff02e8f6e408"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("96f7da8c-2647-4566-9d1a-52c208c031f0"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("a712136d-c442-421b-b499-fd7dbef5a053"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("ac08f84b-6c15-4142-a1be-7b898bdf1bb0"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("b43cf769-8bb2-4873-a748-967688323282"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("c2518e03-dbcb-40ca-99cd-fe76bbd146c4"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("c4fdfcd8-d9cb-40ef-b91c-11e0393b2806"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("f511c8ea-802f-4c30-a95b-29228bf13d3d"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("f56f69db-41f6-42cf-994c-644ee6d63f59"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("f69f5c22-b364-4df5-827f-80efa2eaf93c"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("fdacf26b-63d7-4d05-b3f3-6fe5682c6ff6"));

            migrationBuilder.DeleteData(
                table: "DiscontinuedStudents",
                keyColumn: "Id",
                keyValue: new Guid("152257ab-0c6c-4d19-b325-fc796ae1aee9"));

            migrationBuilder.DeleteData(
                table: "DiscontinuedStudents",
                keyColumn: "Id",
                keyValue: new Guid("a5a4a0fc-feba-44c3-9343-6c56a6f5a64a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("006a4e1d-d0e8-4c1d-b0b3-e3df71415c3c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("00872897-31b2-4487-a184-8a54fcd410f6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("00a26148-830d-4df2-acb3-2ff95582302c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("00a9c707-3eec-4c76-a1e5-28e4a79a12be"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0127574d-feac-411b-89dc-aaf296a162ec"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("019ab708-8029-48b9-a6af-0af36234ecd5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("01cefa0f-1f72-46ee-845c-61b99b08a210"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("03e39bb3-a480-4198-a23e-4b69304d9d05"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0438c069-4f8d-4eec-944f-43c4cd755130"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("04535d0a-98d4-494c-85c7-f790812cf79f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("04572dcf-df0c-43d2-92aa-177b9d97cd9f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0458ec5f-43e3-49ea-a8b5-61ae0c188714"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("050483b6-497c-4ef9-8330-ab247bdf82eb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("05832014-75b2-4b5e-9c12-a1c45d9244e2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0592b57e-1f4b-48ad-8244-53c548382ec1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("05b43a57-310c-4a9f-8124-710b3394308d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("06c4694c-95cd-48ef-acd7-db90203d4b0c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("074c95ad-cca1-473e-bcde-f77f0ef5d0e9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("08646adc-e12b-47e2-9bfe-55c840311252"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0887ccc8-0657-4472-97c4-da0960992100"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0956adb4-1556-4303-af98-916353ae319a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("09c82f95-7408-4fe1-ad5b-6a758ac00bff"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("09f16dd1-daf4-4add-9b80-bf65f82ff720"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("09fa198c-0435-439c-9296-cace890a26f8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0a1ebece-2b66-402b-b43f-6ff7d23a48f4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0a806dfb-27e1-4a03-86c9-487c743c29ac"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0b7c0275-eea2-44c3-a41e-6acfcd97cafc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0ba3fcd8-4658-4fbf-bb53-56eea892b248"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0bc24d4b-4357-4ded-87bc-d070b953630a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0ca80336-5c27-4acb-b396-a39d184e560d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0d3d2fcf-e35c-4de6-867d-5687d40d5a67"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0d5cd7e2-fe1c-44af-871e-ac5fca7e5861"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0ddb33b3-2541-4b14-9e73-4d0e3a30d36f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0de9a8cc-8661-40cc-bd70-59d6ec4af5b1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0ef11839-42c4-44e9-ab5e-458cb049a1ed"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0f5f1a2b-1f8f-4745-b100-14ff644044b9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0f879887-f5d0-4ed9-a7a2-943df0305834"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0fe3db3b-60aa-44c6-93b4-3d11f6e395a1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1069c804-d7a5-447f-9c54-5a2ba87aa1a2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1198a34c-521f-4d1a-9214-8f28ede897ba"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("11e8b829-856f-465d-8ef4-bcaa49da5cb2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("12045594-558f-4a3d-9112-2654ab9d7dee"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1221c875-e57a-4ca0-a5cf-e48cf6e16ea4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("126d889a-ddf7-4ad0-a598-1879b9809d34"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("12ab8a52-8f02-4d05-b224-4142af167326"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("13507fca-8753-4a93-acc7-3fc929f6c9f0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("137edc85-d31f-49b2-85c1-484d32c721d9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1396b7d5-7178-4606-ba87-83a00bf98214"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("13f75844-9dee-41fa-97f2-78746a62546e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("141c4b5f-012e-4559-aa7a-a9fafc028780"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("143052cc-4405-4d37-9c2e-091eb3194d84"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("149acf62-9bdf-4b59-8b4d-ae51e3cae1fd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("14aced7e-e365-4b2a-a29c-d1fbd368884d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("15f1139f-0050-4765-96bc-3cac0f47cf3a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("166f22a9-3be2-45b0-8007-a9f3db4d9f22"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("167c5363-049d-4c67-8301-56bda601772a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("17072883-53ae-4c29-964b-f217f7a49098"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("170e5bcd-0569-4c21-b758-49ef8558b0a4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("17580132-bc1e-42fd-8a1b-2b79b0994369"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("17a4d766-d791-41fd-827d-93d76d395af5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("17dc1b88-2175-415f-ae55-7c88dbc6b2d6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("18006250-22e3-4f23-bc73-b71fc165deaf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1807e483-0903-4ea2-90c6-a9b75e99b289"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1819f641-95ed-4f61-845c-ec35389caac1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1836e24e-37f7-4f75-90de-09ec97c0a543"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("18392e96-64e5-4fbb-9d33-d6e16b087052"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1874ab8e-59e9-4570-a83d-947c2f299c9e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("188239d1-b8b4-4af2-9861-626e5f78f537"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("18bdd4a2-29ac-4d3b-a2cf-55d5ef6fb722"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("18fd74c0-3681-415f-b532-efb641824e2c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("191076aa-4a32-4c89-9cef-ebd2ce54a19d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("19359f6b-de4e-4991-9df5-d675f597f616"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1942efd8-54f1-4106-89b3-3e43212c79b1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("199e7a57-4c87-4ae9-ad99-a292c9804df1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1a106b7e-b32f-41c8-880d-b6dde7f914c2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1a13ba58-d8fc-4b12-81b4-3adb5409bb64"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1a70e879-578a-4cf4-a4ec-fbceb4824545"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1ab4d78f-46b7-4dd2-9da4-1ab967107181"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1b163d49-3265-4cd9-99da-6b2ee2cf6602"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1b19bfd0-c661-4b4a-939e-313b4d182bb6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1b3b1ed5-f8d1-4c58-b584-3f383787cacb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1be2dc0c-0b9f-4d95-a58b-e40c1250c03b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1c3fa8e7-a50c-4b8f-b439-b2383a3e158b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1c58763a-4b80-40d4-ba58-89a93a76f2e8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1cc639c9-fd4c-4333-ac92-25c6e280eb7a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1d2e6e3d-f184-4bde-95d6-1dc86b6cb722"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1dc25a9e-941a-42a3-a62b-7e283fb581d1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1dc34082-b114-4fa5-aae1-3489d52443ce"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1dcdbafb-dd34-498b-a715-4017b7ad6062"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1f189090-5fda-492d-b12c-eff5a66cbcbd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1f578790-bb72-4308-a064-f0b4428b50ab"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1f6b447d-2fff-4b80-928b-c2a7f066d1c5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1fc4b244-3575-4051-8570-64612f1cf31b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1ff0dc6a-5ab0-44af-b925-c0bdef4dea92"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2106b51d-0c7c-464e-9bb7-68a0dd202a94"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("21192d2f-c3be-4c8c-bb8e-88e67a74f4a8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("21e38381-4ff6-4a08-b6a6-a420afe3bf99"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("22874558-9eb7-4030-8c0f-fe97a3f52e7f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("22a46b2f-f95f-4fca-89c1-48349d79bbab"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("22c3f231-38f4-42a4-a4ad-a71cf7d7ae44"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("230b9de8-08c3-4fc3-a872-20b7e09a01ae"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("23e88788-8ce3-4a8f-a7d8-474e8275c148"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("24073ea7-2605-4cd8-bec3-88256948ae18"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("246226bc-bf8f-48d3-8bed-9e7dd89401bb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("24846fd8-7ab1-4ce3-a5f2-eb818ed63f37"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("25368893-f166-4b0f-9296-c51daaf7142a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("25e207da-8651-476b-adb1-f75f79e5e1fb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("25fc3961-247d-4098-b8a0-3291c418de9f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2651da51-3e0b-4c58-8efa-c161f8a786bc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2689be8e-cdfc-4b8b-8947-1923411cf549"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("268cbae0-9b6f-43de-8ce4-cbd6acb1c3ec"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("26e34d49-4f4e-4175-822b-a35b6217638d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2784644e-dc3a-47c4-990e-b3dfc7201ef5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("278a57c1-338a-4d85-9815-408ed6d0e3e9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("282274ff-3601-4934-99bc-14bd817a75b6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2874df56-4f75-40e8-8b6c-cab151278d83"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("28e03163-0a30-417f-b09d-4eb921d58f26"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2956e09d-a6a0-4097-8e23-524e520d4a94"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("29f348b1-84b7-4f23-bca8-740d6a7263cf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("29f8f7ae-a142-4dc3-9027-7f39ce2b0f14"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2a66905a-4989-4c79-bc9d-5a80805257cb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2a93b039-e5b6-48ab-959a-62d5cd3bd447"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2aa40986-4979-4240-a8bd-058454a257ce"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2c1e83af-41d7-47a1-98b8-c6ca91dacf6c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2c354448-5b17-4e67-b92f-146e53dfefe8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2da9d3a4-a05d-4e35-92cd-bfcc40ce1581"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("30313548-131d-4d81-a1fb-89f1e997970f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("30571e25-89ab-4741-a445-590886cfeb26"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("30e1bfe9-dd3d-43fb-ad2c-46bac397d5aa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3100669b-ee41-4d88-b63b-b36826ff40b6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("31642898-7095-44fc-a40d-460b022c5a3f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("322a9d6a-92ed-4762-a66c-25b9bfa215b1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("323d9f01-3a4a-44aa-ac09-cdc281faf4d5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("325d0c7f-0ad0-48ba-9fdd-7c010d1edf7d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("33408bd9-b750-49c4-8bb4-e005fe036e17"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("33af87b7-de80-40d6-ab21-462af002a4b9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("33b86397-7fe2-4b55-a476-8a577b825a26"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("33d2fdbd-259e-4506-9953-e4991a8af2cc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("34246bf6-7b26-47bf-89ab-c89f4c7e4c3a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("343b9321-f169-4845-a916-3e99c51ac23c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("34e00c63-ca60-4044-91d6-88d4ce6c6d84"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3502bd94-a342-4c6b-aa06-765b1da1e7b2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("35babe1b-324f-4a84-b3e4-de242370fc5f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3639cc22-ce57-4ab5-8be0-e9c5a1fc2dba"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("36a2ba96-54d1-4ffa-bc64-6decdb65c47e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("36e610ec-81b8-4e07-8b70-8981a556d728"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("37263c5b-2263-4f46-b9bd-447eeff6b800"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3738731d-a1fb-4eb8-82ef-2ca3ff922796"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("37605d08-901b-4e0e-a682-9ad9f5cbbf38"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("37b3faab-be18-42fb-9d84-0ef324f6bd1a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("37e5f9cc-aa16-4e86-92be-7b4630d13fa0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3878e91a-6e81-4b33-8a79-ae43f225fc7d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("38a7ab9b-ea2d-4b35-b984-02b1fa6073bf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("38d0c269-e40b-4fd1-8b89-79783566a5d1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("39160f2a-058f-4ccd-94aa-4211d9d1e17e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("394059b3-3890-4718-8cb0-ccd0d971d2d7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3a195ce2-1511-4133-88a4-91f1797c00fd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3a44d1a4-0949-4f18-b6c5-a9ac59f93a00"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3ab6b6c9-819b-4d09-9eab-ce45e2dd161b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3ac1c9ed-9e99-4697-9894-1c2ae8b13398"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3bdf909e-bd60-4797-a3ac-e43099264f73"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3c2482c0-6cd0-4247-b842-fb92990b4919"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3ca8277f-a866-4f07-9f4f-4c97c26639b0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3cff8c4c-87ce-4814-bf3b-fec690fb5066"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3d8efea3-c305-4798-abed-c168aaf1e371"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3e2a8590-6527-40e6-8d72-0a847c7dad15"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3e63ab61-2641-438e-abbe-c6e1b41257c5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3e7d1d27-e3d9-4c9a-9ec6-bb3bb996cfd4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3fa170eb-57c8-4105-ad50-c06a4e9a47ba"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3fe148ca-9771-4215-bc0c-88d227b97e25"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("400ad547-0193-423a-b4aa-c1702484e288"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("401b3d65-7393-47ea-a82a-4bce92b42f63"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("40535a31-6583-42a1-9479-da539c202cf7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("41adb515-21c6-4e42-999d-53a7a3706fc2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("42e0be0a-330f-4337-a38e-aa33f283c900"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("43c1923b-2ff6-4879-aff2-64b7a2fe4fc6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("43f824ba-4f14-4864-8489-b10bb409fdbe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("44a65575-00f9-48fb-8841-adf2eebff8d9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("44dec22a-7e73-44bb-9f53-99f7deab7190"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("44e3403d-531a-445b-93c6-3d03fb5dacd9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4547dc6b-227a-41a1-abb5-48ae4706dcb3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("460784c6-78c3-41e4-9562-4b4c58521dae"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4633a694-0d2a-4117-a320-b834d7eb7ffc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("465e67d7-758e-4c4c-8d1d-c56969efa59c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("47b01607-8605-4d2b-958f-23c9ba764691"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("48c92e5c-5254-4c33-bc28-3da5f9cc6d85"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("49941746-bfa4-4958-af24-66fada5d66d7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4b83a944-b605-4ebe-882b-909dadaa42af"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4b97dab9-d86d-4913-af57-0b751c69a63d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4ba52076-8719-4638-aa21-682dcc740a26"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4bc68dc0-cec5-4151-a683-08515f87f603"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4bc6a868-9a8a-43a2-ae2f-7ede4c757ada"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4bdca878-02c0-4142-87e9-e5851fdfcda8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4be9dc17-a8c1-40e4-9dcd-a2de1ff1fbaf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4bfa01c1-f579-40ad-8afe-012569138400"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4c261e89-09bc-4fb7-af38-2832a246895b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4e1481de-6a91-4c05-9f47-8e1546eb77ef"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4e5746b5-09a7-4197-8cba-baa94aa46052"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4ef42a98-d7ed-4171-848b-22efcb154277"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4f602331-ca09-4487-adb5-4a577b90b5a4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4fc9c0b5-42b6-422e-9e06-8360ba80b690"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4ff38263-b2b3-4556-a4d8-6b161fb4d266"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("506ad817-ec9f-4c13-acc8-4a0b9f423af1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("50bd4187-c65a-4f14-833f-425b649d74bc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("51eca4ab-3c48-47b2-b326-fd710167cfb9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("52c20491-571b-40fc-a783-a488843e3fe2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("53241745-4afe-4546-8925-f25570add568"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5339997b-b6d5-4263-9ba3-fb083e4f7ed8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("54118acc-11dd-438a-a962-54709268e735"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("542b4e1c-ea87-4bd2-97ad-e8374053688a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("547600e1-e584-447a-ba7d-b3a0fbca5ea0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("54d15989-975b-4c4f-8928-7eae5affc7b8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("553adbf1-d7ec-40b0-973c-4257d9f50d2b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("556f9a6c-ed4a-4b83-811e-a28bfff443e5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("558bfe4f-cdaa-410e-8558-754d1c3a9984"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5591bf7b-0778-4dd9-b0ab-762580eea947"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("55c352b1-7b16-4cdd-9543-35a62c207771"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("56012afb-d9b2-46f4-9355-0023203ae165"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("56187e8d-a7e1-4c77-b28f-442427ee2686"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("57091b1d-3e02-4a16-b4f1-2543d55485de"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("57de2ba4-9295-4e74-b5a4-5347c6f564d8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5817c9d2-8d75-43c1-8ac5-966b28072527"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("584bd915-0675-4c22-a9ae-9dea52a3f2e0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("58a0908a-e1de-4fa7-8757-5ad0c5feb8bf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("597afc1d-50f6-4216-ac6b-d8628ff587b2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("59958a6f-aa8c-4f69-9d9e-c862b96589f5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5a1be47f-4e26-438c-94f7-9f65a92e2b93"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5a6c9fdf-2c99-4dd6-b632-7b1ce14c018c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5a82ca5b-93e3-4e36-b2dc-73a62dac5916"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5ae6b94b-339f-477c-8dc1-055ee5318529"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5b05639e-1691-44b3-83cd-ee67a599d92d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5b150ca1-af75-4827-8576-453f201299b2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5b3ed27b-af32-4b38-9e4a-56d70fe0156b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5b864761-57c9-4fcd-944f-8b4e0f8a18d4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5c387d00-59b9-46a2-9506-6d8e2c7c8df8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5cd2662b-6939-4ce7-9b6f-ddcf9645c04b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5cd9368e-a81e-44fe-abb9-2cbb4154a41a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5dcaf313-b4ed-4e19-b55a-ea646ecf9631"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5de782df-49b0-40ba-834c-9f47cd3db133"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5e071903-107e-438c-92de-5adc5c5b8854"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("60310079-8205-4dbf-97cc-bf567bb3f282"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6079fc41-ae52-40ea-9fd4-549316db22a3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("60874719-0e90-4632-96b9-030d148af6eb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("609dfb0c-12d6-476b-a186-46fbad0d503b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("60ac5c85-64b6-48a6-8ce9-a78fa42457de"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("612abb30-7518-49f1-b033-869be931d27a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("63130c06-c969-451d-901d-44744d69d2c2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("63a26922-02db-4305-8685-468b78d82d45"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("64a46901-8e42-4dd4-b1e2-c41947436d97"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("64ca2bf6-e7e8-47ec-aa60-2317cee87eb4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("64ff9023-9e5b-4218-9798-4302deaef19b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6539867e-f420-4d69-947c-145d5844bce1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("65698615-a7c4-4975-a7f5-cdfb88ea2621"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6673e513-b861-4e41-9c03-d4b8e307fd9e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("67ec1e7f-1dee-459e-9cfe-636df3d71f84"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6894391e-c623-450b-95e9-257d0951dedf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("68ec8c39-3282-429e-93ac-c26756e1a04f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("68f8164e-b099-4169-8253-1abf676c57e3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("68f89aa7-3a23-4020-9eb6-606ced32a2e2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("69335197-4e34-4458-9dde-c9cd99176c12"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("696f7941-c6b1-4710-b16e-4f15fd1d8c8e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6a0f16dc-d66d-4c33-b9bf-0d6d50d83a7d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6aa37721-a812-48ca-8d50-1b1adf14293f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6aae7e61-8c47-4d39-8d93-20a7b6dd264c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6abf486e-0e26-43e0-8584-585db92e287a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6b0b0a8f-7202-45e6-abd3-0725a8f9b065"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6b27be71-bcd9-410e-b04b-5cc3da0fd242"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6b2d7092-be6a-4f9d-bace-8d7fd57562ea"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6bbc368e-6ac9-4c68-880a-fe63d571d55a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6cfe53c9-e566-4b54-8397-af9e4126539b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6d0792c7-0b0a-4bd3-9571-d158bdcdab01"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6d2f55c4-5434-4c54-9f91-b3ce07029343"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6d33426d-d243-4692-a39b-3f27d690141f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6f0a6cab-a45d-4d00-b311-5beae1c77ca8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6fa8c03b-f763-425e-9e44-f8ec8053345a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6fe9cccd-b8bf-4227-9185-c305bd2c7072"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7014768c-5ed0-427e-bc6b-babbe5cfee2b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("70302312-e7a2-4dcf-bb97-cb61b42b7d9d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("705ffa45-f516-4964-9598-f11aab6fbaea"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7098e0a7-00e0-4e45-a237-b0032c19189c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("70c8b08e-8887-4985-9789-62bc9c8f74dd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("71236f77-a6bc-4936-8333-d3153d1bc416"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("71673951-be8b-4570-89fb-e91d9476205c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7253d4c3-7d37-457b-bde7-38f2001c6c74"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("725cb152-4f0d-4d10-ad3d-1ced4885fc04"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7265bd93-c439-4de0-b7f6-ea2110b8717f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("728c8ade-1c37-448a-8c36-766197fc43bf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7298b726-95bc-464e-94f9-69413b48a311"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("730197f5-bc2f-4061-a11a-cab504d5cab7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("73225364-6e43-4778-8d11-c851f7b4e35c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("73243809-12c0-48e4-b345-c328f66ef3d0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("73880cbf-ad1b-4775-888b-136579a91f54"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("73a29abc-7788-4410-b090-c491178ccafa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("73cc3be4-3e55-4237-8069-23ffadc6de41"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("73d9075a-cfcf-417c-8a63-7b0c7a3a9f80"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("75074897-b5be-418c-a8a5-3a512665a889"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7541b109-03a4-4c73-b155-aaa61c2df41f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7564b9ad-021b-4255-891c-ce2e669b57a4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("756ce7e2-aaaf-4efe-acdf-96d38c9d3fd8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("759d7881-7121-4117-a5d6-0805460a8165"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("75a946ce-19ac-4087-9e10-46207bbb13b7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("75e39c7a-719d-420b-b66c-1bd866b8c412"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7641aad5-9cb0-41ad-a9bc-9f1efe2a0320"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("76721171-b652-4a94-854b-6ccb2204b7c1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("76c35610-fd59-4526-8ad6-e33ce6226158"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("76e31e8a-a0b9-4086-a0b8-1246907d58a5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("771e6afc-d2eb-4974-b5cc-22d3199c28ed"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("77fbe978-5668-483c-9b55-7c646192b709"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("77fc46bf-3383-4895-a1f9-728c98d66da1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("785e8462-9953-49e6-bab1-0c4fda617f84"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("78942e56-ea22-462d-8a18-3b860babd87b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("78cbd547-a82d-4dfc-85c3-c02ee5d03cf0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("78de9243-ec61-4f27-bad0-631a08cf68a3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("79227862-eba6-47df-a069-9ddb0692ac39"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("792fdeef-dbc4-4870-84c4-c299d447e8fb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7958724b-800e-4ddd-a2f5-649305dfb7c5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7a0888ab-017f-482b-99f3-a6b82393c5a5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7a374ddd-9eee-42cf-a619-c549e86cb06e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7a6ee22f-0b2d-4c42-b89f-f908d9fe13b2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7bb0e761-d6bb-424d-93a8-95a765ec0e6e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7bb80376-ffdc-4f3c-a2ca-d9219f5dfe69"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7bc205fd-3da4-4a54-97a0-5da3f7bdb552"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7bc6dcf5-ae57-4f48-8d92-e13a3f2f5c7e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7c166ab3-118c-4421-85d1-4867baca9a40"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7c27e720-e24f-43f9-9920-eaf046680657"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7c2ffe26-d2fe-416d-af15-fca4b6885f53"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7c4fe24b-4f27-4442-ba15-8f45ba902035"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7cc226f0-7e9a-4755-bca7-9f2f8096e33b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7d86f228-95ff-4f8e-a788-653955002337"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7dbe4bd2-9e28-446f-a51c-a5223e614e6c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7e1ac9d2-c74d-472d-8a51-5a9e1480a8a3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7ecb4d32-2201-4552-b86a-2e535c534c85"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7f1632c3-c8a5-4603-84ea-357817d34f30"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7f3ed638-542a-4a4c-86d9-92096b20a21e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("800903cb-26df-40b9-ae60-b312b85b00e4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("80142c02-4bc2-466c-b2d1-c6c8ad907444"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("80414b4e-1d30-4f24-a222-faec75a6d8fe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8094860c-e8ef-445e-96f8-223ce6545d92"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("813df71c-704e-4354-8306-63192389bcd5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("817c9247-da05-4b50-9486-6584b04fabc8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("818d81be-b0cb-4fe8-8ac2-c15f0f5d123c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("819fc94a-1e2a-4b3a-8314-bb3eaf2d5611"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("839460e0-3455-43c8-9ee7-c4b57bbdc30b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("83da83a9-797a-4891-91f2-97578c19e8ee"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("83e387ba-97a7-43cc-bc1e-016f57b96807"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("83f2c8fb-31c1-4081-9736-63340acad51d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8412bbe4-cf36-4afe-90fc-5d28a4a2bef0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("848ae5ee-a83c-4f5b-a7dd-87171f803b67"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("84cf9d16-9bd7-41a8-8d19-c2802c162495"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("84f93059-304b-4483-b118-f574c83c55c5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("86e97df6-d3ee-4624-8756-92457e688c7f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("87b5b78b-adb6-4155-9006-8fb081bfeb26"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("87f37afa-aa3a-465a-ad17-fce5be412a32"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("88420e76-eb7c-4a82-a562-9cde05698a76"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("88935c3b-b866-4f7f-8a01-0ec3f4629a5e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("896268ad-6b48-4750-9d89-cbbba0cd49f9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("89e724e8-00ea-44e7-aead-77e59700d2a6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8a43d75a-2b28-4472-8624-fb0305f4b594"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8a5e47b4-7548-4d3e-b337-c8940e56080a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8a83799b-4431-496c-81ec-373f9f591035"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8aa4eba6-24d4-41f8-ad0d-08cd14166125"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8b10ba23-6feb-491d-a1b2-4fd3c3e416b1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8b3bbeeb-38b1-4d5b-8d58-29d61f9956b7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8badd74e-1654-4149-a3fb-5a1eae251a67"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8bbfe669-c961-42f6-99d6-ffb99f1b480b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8c2590aa-dd3b-489e-8be5-1db06fa16547"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8c454fa1-6e9f-404c-8563-410a3849a578"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8c96952f-7b01-4836-9078-d926713ee28e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8d701e5d-11fb-4dbc-867b-e106afb490f5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8d915527-7d73-4f64-9399-654552353bb4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8dce6ecc-7e4b-44f8-9e65-cd0ddc4cb4c3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8df0860c-3438-402a-8035-56b442e22d60"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8e3d0cf1-c9c3-48c7-a075-9da0692f5bf0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8e54219c-9a0a-49db-94da-01d4d0497065"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8e6c999f-a19c-43d6-ba78-6c13f16cb0ec"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8e8886c8-50a6-4e9d-9e4f-8c654226de01"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8ec2f0dd-253a-4650-b419-b700d5cf4ad7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8ed90ae1-f37b-4296-937a-033c80b52c63"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8eef0bc0-77d9-47c9-b0d0-b6fc0cfc747d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8efe53ae-9439-4777-9b37-2ec480bf3390"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8f5d671b-8eb5-4bae-90b6-0dd5bd93ef6f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("903d6b59-3e89-4057-9eb8-963e55528832"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("90568553-35df-4eda-8e57-b120b52d8b5c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("90c9eded-a2dd-4f31-842d-008c2f4e966e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("90eace55-7c08-46df-aff6-4fda9dafdeac"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("90f3bec0-bbae-4cbf-90fd-ac6ed404d0c9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("91629bf2-e89e-487f-9d98-3f8b0eaa8115"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("91cea504-e6fd-44e5-9c4d-9254e1918b1a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("92297204-f7d5-410c-930a-4fe6f804c07d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("92a1cf60-fe92-4dcc-b74b-a944a7718d4d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("92b5d5eb-5f3b-4a84-863f-6573253b9512"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("92cdbf05-f2b5-47ef-818d-fc3e8aac6292"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("932c63f7-9294-420f-89e2-efbafd93b176"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("93321f8b-4718-4819-89bb-6aca7050a074"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9345324c-6820-43b3-bbee-350bb00ccc6e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("93855b93-c319-4670-bec9-99b366fe5946"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("93e18fd8-2030-4b03-b6f5-f6e2831aae15"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("93efedef-40be-44a3-927b-04bc49047e46"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("945a7666-41fe-4e00-8f96-57bf35bf448e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("946be847-b7cd-4bd9-b6ad-3c246578a3a9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("94f1fe81-1359-4cb2-88a0-3561baff9cbd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("95017d1e-8b77-494d-aca2-a70180ff188e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("956d296b-cc35-42ca-8243-d9e053c02f11"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9656d8d3-3db7-486b-8f83-c90f636e3f2c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("96fff2d7-9588-495d-8c93-8e78828fb33c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("97263bcf-2032-4a98-801c-091dcfef1ba1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("974f5a0b-174f-4d0b-83b7-7349da8c2adf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("97c3cdfc-e480-4361-9231-72f16491a3e5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("994697ac-1e59-41b1-bfd4-cf8083562379"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("99c6a106-a80b-43c1-850f-0d5dfa4745a2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9a2fcb92-3146-43e0-8d40-b0768f4d926c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9a629248-f93d-4471-afbe-a66d0d1f12a3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9aaa1b22-45d6-4dff-995e-daf45e1f3206"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9b2f7415-bef3-413f-8ab3-0bc8f616ae4f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9b94a04f-46af-43d6-aed2-82ff9411bb8f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9bc5352b-f3cd-4441-bb16-b4a183ec7ae2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9bdd32d7-b3f5-40e4-aec3-8a0c624f848b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9d04c61f-2468-4282-94f1-a60445b2399b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9d4d7e2e-9915-4415-8ba0-84bd2042f4c1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9db21e31-59db-4142-bd49-592e0f10bccf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9e2405fb-35f1-4730-a69a-1bcfb5696ada"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9e7cc387-aed6-4c90-af3b-ea4b6e627b23"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9e966d23-c988-4344-b64a-4c2e04856622"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9f9c017b-4be7-4f2b-9bb3-5e9db6092506"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9feef475-719c-4742-84f3-737c3283ab6a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a09ac3dc-6345-4ccf-8bcb-8b56eda8918b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a0a32098-bc9b-482b-99e3-eeea5ae5e192"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a0c737fc-e100-4c76-8373-11624b7acdd3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a1c3586d-11cf-4b90-a830-ea4cca312a4c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a239a5c0-fb1d-449c-a54e-9d46c42cfee4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a2445f46-a878-4e44-bdbf-ac129dd651ec"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a299d9b6-9838-4174-97ad-da6b0dd737fc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a33930ea-7c6c-4bb1-8d4c-a9bd4e3a3ba4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a3603558-257c-4e17-a723-2978c38e3f0b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a3a13242-d597-43d3-b5fd-e4777a165ff6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a4113312-6802-4132-8d94-f33069eeb138"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a4201540-c8fe-4393-8edf-d8490a4bf4ac"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a4bf40ce-d375-457e-8a81-ea0c2325d522"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a4d53c62-e328-463a-b93e-e204e303295f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a4fcf637-23ae-4b35-b84e-3efbf88aa0fa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a50556c6-e2f6-467a-b6e1-ed3cebbedc7f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a537d0c2-dbbb-4366-91b7-66296a61073a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a5b2a008-4a9a-4478-ab73-1d0e9a987afc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a6236f5f-49f7-4cfa-a74a-7142791d4e5f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a71ae80c-7c7c-44f8-b7a7-cc29e0c1c670"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a737dc5e-528f-4188-b1e0-f105ce0859a7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a750ddb5-0a60-4c5e-81ce-ab85d6a135d6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a7559326-a586-49e1-adca-875d3fd3c7a7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a8331ec3-2b82-46c1-9229-0cc9fe6f08bb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a838b41a-305b-44ba-bc16-4854fc0f0c89"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a8652205-5dd5-48f2-83ba-28223d8bf4ea"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a88fc8a1-8c2e-4f89-bee8-050d5f889a80"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a8a8de21-28ca-4977-8a8a-5e04e0f2e126"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a8bbc7b9-1b0e-4bb0-8da5-1d52a004da15"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a8d19c94-efcc-4dcd-b54c-a3bf4e7ec899"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a9596bc1-8988-4a1c-a4bc-4c33e51a9b7a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a982cfc0-f324-4c84-8b51-8c013a3f4364"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a98d6b72-bd8d-45dd-a49a-13a37591056c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a9cb44fb-72bd-462f-bde6-744a4c753b7e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aa08a56c-d869-4351-aa6b-1f2b2342cbd3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aa3e9111-bd41-4df2-b133-6eb56b90567d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aa431675-5063-4da5-95d6-a3b3d0c3b970"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aa82f8ea-f198-4014-92c9-64cbb3ad99f8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aabca9e6-b91f-4f92-83dc-f13ea919b53f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aaf72d87-fb05-478a-8673-aed70cb12a88"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ab000a90-b92a-451c-9668-40b28a8b2fb2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ab768b0f-32e0-411a-a96c-5bcc145d960a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ab7abfe8-6b8b-448b-afad-de80170d9183"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("abc6d15f-fe5c-4f5d-bc59-4d553d95f9e5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("abcfbc8e-b913-4fdd-920c-cf0a25661289"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ac1653e6-8135-4968-89ba-4ce49980a68d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ace6fd08-f02c-4929-b434-8a332e7e8350"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ae359c38-bac4-4bed-866a-36158d2fccbd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ae388690-dbcf-4195-9de2-9e76e0502a21"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aebfa85e-50c8-403e-99d8-906541b7cddd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aec58bdd-0659-414e-8fa7-37b30c55bf8b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aef2ee74-7e69-47aa-adf2-4bf7d97f03e9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("afb2ef8c-370f-4620-a460-01d875baf85c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("afc96b1a-55e4-4e95-922e-e99b31172e1a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b0467eba-cffb-4357-94c4-afa706128ece"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b0b920d1-b80c-4e24-bcfd-38cb8f7cde74"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b0d0c1ac-414f-4de6-979c-65afdf58503a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b103a44d-acbe-44a2-91b2-22facb7ed15e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b18721c2-4b1f-4449-959d-47c77dc8ffa4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b1c64ca8-3563-4227-835a-43d634868fb0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b1da6843-1d34-4b5b-b1bc-b500dba37d28"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b21a941c-8ca0-4c08-a666-7f8c87395153"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b2c3e23e-0b95-44a7-84e8-00e06314467e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b2c7c388-7da5-42ec-855d-c18049c34c60"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b2d4e6bd-2f26-47ea-b070-4f0bad1ffca2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b2ec91c4-7293-4c78-94e1-09f6be52d994"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b313dcd7-6f00-475d-81fd-e3a902b0300c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b31fe4d3-dd6a-420d-a1ca-58dcbcbeebbb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b32cbcee-0af5-4bf3-945f-c35ba554e6da"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b425aff3-351d-4a72-8891-112f37746c74"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b4ff02bc-cd39-4ec6-b9cb-0489fd66cf45"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b5bd7ed0-b34f-41a4-bcb3-e700745ef564"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b5eead5c-cf13-4666-89a2-e896b26d6d6c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b61ea21c-5762-4985-beaa-0d1d4ac22068"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b64351af-4c91-42ba-99c2-e3daaf41e2f3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b683f0db-0aa0-4593-ad1a-1a5ae1725277"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b6b0d743-93b7-411e-b6d8-7279a7fe2661"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b6d85bf4-d69e-4733-9db5-826808f9b23e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b6dd0574-b037-49b5-9031-fa5fbf7b9a8c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b72afa46-d39e-4be2-9584-8ae18dd71d8f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b7dd0448-6411-4ccb-a2ab-12666b6826d6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b808e1a5-5aaa-4fad-bbb7-97e1eda53e26"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b8670454-a0b5-402a-99f9-a658a91b86f6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b8c6dba4-1f13-40c7-ad97-052b49ae83c2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b8e4a76c-d496-4649-a6c6-94e8c1164a17"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b9363ce2-575c-4e06-a840-5bc01e6a7906"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b98876ce-eac0-4d81-8cca-7110a6bcdd23"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b9a23f52-2e72-4484-9f4b-967693a5e311"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b9c52fcd-9e98-4625-92b7-dae86e693adc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b9d54dec-8bba-43d0-9b47-ab6bbefa5d7e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b9ec77c3-d6b7-4626-bef0-35a8185769f6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b9f8807f-9dac-4efe-8d3d-6816f24da95d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ba2b3412-127c-49b9-9a9b-b463c90d3e82"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ba45417b-7552-44b7-a5ac-9c627672e1b9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ba893a67-3fe9-4c51-be99-39728225ad01"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bb6707cf-9a38-4443-9380-0959dd8d4429"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bb89be57-5156-4edf-884e-fd91758380c2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bc4a0ec8-e043-4b4e-9a59-4d38568697ce"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bcd133c7-f696-4c8d-812e-86f66e849f53"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bd48ccec-7a22-48df-bce1-f6d85df2cb24"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bd89fe51-88e9-4989-97b5-01b71a219eb8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bdcbe321-2ab5-40bb-a1ba-1de6c12988ec"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bdd77ce4-27c4-46f5-a327-2b4d08795f15"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bdeb2269-9baf-4a03-999a-c62ebada7ab2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("be32d277-eaa2-476a-93e7-197863aedf53"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bea0ad4f-6a4c-408c-9eef-7a6f2acf033f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("beb6f71e-325b-42c2-8f61-56853d6c6874"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("beb748b0-a108-4e20-a1d8-80c6b0f86f62"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bf87e004-4166-4713-9785-209cb5e8e1c0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c0618434-9791-4912-ba7a-9e83a3b8e691"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c0aca9c1-a76d-4f3f-a097-990914a77e94"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c0e21637-fea9-42ec-a613-f621fd41da47"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c1680c8c-201c-4c4c-9821-ea03a0387d86"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c1c9a168-fc50-415e-b4e6-188fa3009714"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c203ccdf-57cc-41dc-aff5-6ba2e5308055"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c256f635-b7fd-48b1-8659-f531e995863e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c2713f13-7ef3-4b81-8374-555451620d91"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c276dc58-6b6d-4fbe-ac44-992066943b3a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c289495b-edf6-47f5-9b4f-8467012a64a6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c2f24923-65b4-4fea-a862-01f6ec7c733b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c42a1767-522d-4897-b22f-73ffb8d3bc4b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c4c5ed37-f259-4baf-9f2c-2c330ed66aaf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c50516c7-4385-45eb-8283-0cc290a042d9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c58344aa-c81b-4de7-b996-75d1d37b461a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c5d984e1-95eb-4f1b-95e4-113c82bc9a0d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c6208837-469a-4b53-a53f-608d137ff82a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c628906b-0219-4d97-a022-956ea2a04761"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c62ae190-570e-4fa3-87e8-fc9c1ce12d8d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c6ef917c-da34-4218-a953-fe415a9ebb54"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c72b9fe0-af88-4342-8cf8-76b4d99e7dfc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c73c6256-6dcf-4332-bfd7-baae0a566c86"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c7e5bdba-1f59-42cb-a1a8-6cf400b1f8f7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c93cb455-86c8-41a3-9e6e-6d291aec69e6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c94707b7-569d-4347-b759-fd5b1997ab24"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c96d744a-de85-4e88-a59d-a0a08ce6d40b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c9831751-d474-4ed1-b508-7c7bbb561cb0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c9d6a753-9526-4efa-be7a-4d7e0496fe03"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c9ed6a41-00ee-449f-8610-1af5c4b45188"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ca9823a5-b8c4-4e56-ac8b-f2a970214ded"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("caf225f3-d3ac-499a-ae47-8ab2ad8b9b45"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cb076945-d73c-4b1c-9010-e23841383360"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cbd46b7d-dc9d-44e5-9e7b-bc18b84e774a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cbdf2748-dfa2-418e-872e-b43655bbb5b2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cc4590c6-d6f8-4952-95ef-040487935479"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ccaaa8e1-93ea-459c-beb5-428d7647b420"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ccaab503-a554-4ce2-9025-0a0de644e75a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ccdd15d7-0cf1-4cbc-a83b-910a2ff73fe4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ccec45b5-c4c1-46f5-bdfc-819cabc536ff"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cdad7154-026f-474b-b50c-f196c52cde23"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cde0a436-079f-403e-b8a6-ee78b25382ab"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cf24f61a-faf2-4fb0-bc85-1c71d8305b17"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cf5cf6d8-ce07-493c-8752-34d3ada7bd36"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cf6a49c8-6483-4a84-8e68-c7fd52af1f6b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cf6a577c-dd9c-4861-bfc5-94f869189e1e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cfdd1f15-4499-486e-947a-6be2f86e18fe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d029b4e3-ce1c-4e9f-b926-557f1c7976fb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d07f73be-7026-4570-98f2-bd420913f347"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d18a49b6-bd3b-4565-8ff9-298459763300"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d1acdadd-a2c9-4e6f-9f8a-2ddb4a1d81de"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d2084bbb-ef70-4de6-9dcc-125a9d17df48"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d223c31b-10fa-41c2-8fa2-3f6b75874bb4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d27cfd55-d9c6-4583-be4a-f0a203f6f79c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d3446309-bb6a-4128-a079-fa79bf204e16"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d44e81a3-87f3-45f3-9812-dc28f2b67437"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d538cd6b-f113-4b66-94bd-4ae837d026e3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d5a3f3a0-1571-4c1a-a319-4e717a28bc79"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d660c8e0-2561-402f-980f-f6b6a9489add"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d67b493d-935a-4544-96c3-e96cc92cc462"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d698e3b8-7040-4543-8604-bf804af898ab"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d69d3c12-3b90-48fb-a881-12ad27293b38"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d82e6967-99a8-4885-b894-db5fd807c205"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d8af1f29-0784-45ff-86c3-be652fe07ddd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d8c3cf32-06fb-4b12-a009-55ba3be51bd6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d9222686-0f09-4d23-945c-77d496c6ea1b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d9421711-35a9-48d8-9c7d-275774c4cc0d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d95e77a4-c659-46b0-bc5a-f9b1ce748386"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("da00baa6-44c6-402b-8302-a4b047b126e8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("da737ad9-b2f9-4a4c-962e-3c03cb47021d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("da793be3-b49e-4c04-a0c0-d9f419628892"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("db184d4f-8bf1-4e04-aff8-c92d16a19e66"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("db290ce0-c0be-4c57-a381-6f5f008eeb89"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dbdc555e-bb38-4184-90ee-5a66f6552778"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dc1cc832-f4ab-4f2f-96b1-a448f37675a4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dc47e231-2761-4552-bb1d-2ab6b952769b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dca0ed07-a4d7-4392-b520-509ababe40c0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dcb8fa30-5017-4203-abd3-8f620a2d4258"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dd4824cf-5fab-48d1-80ed-2920bd265a4d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dd54405c-7846-4b8d-a59d-9bf2be53eb44"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ddf5575d-47d1-47bc-9f6b-fe6e9a187cf6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("de33c90e-3d17-4a9a-88cc-58a6c7eb971f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dea25268-baaf-4614-b37b-fafda1fdd384"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("df3a76b2-ccec-490e-ba47-0450407a38cb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("df51d8c0-81bc-4d05-845c-d0b1c5d9bccb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dfac4d15-08df-4eb6-aaed-6f1f377dc839"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dfc4a78d-4e2c-48c3-bd80-1a36065bfc6a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dffd61aa-5a48-4056-9a1b-5ff2ccbcc017"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e02d6b5f-056e-4d00-a9c5-ef1233159e07"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e04c77c8-ce21-4e77-b11f-07067f268d7f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e080b88a-d9ae-49cd-ab03-0ccd6d3d31e8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e0f0ec87-4558-40cd-9f37-a2843dba09c0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e2b3b938-fc81-475a-b1e3-d46b2793c52f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e2d59c3d-06e7-4a80-8da0-1c6449f0cb28"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e337526f-3dc6-46bf-a175-6ab8503f907e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e370a57c-73e5-42a5-aa45-320c2e566257"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e3a50789-8f9b-4baf-a6be-aedcb75006e5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e3e85131-c444-4fc2-a80f-fe65c7659351"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e4005056-2833-4771-b25c-9f703deaf9b3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e430f0b3-9605-4fc2-a555-e5f0e0c88b0a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e46e50af-2142-4c16-bce2-f3604ceefb64"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e4df6764-f546-4b57-92ff-d5592a0dde64"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e58211ac-2a9a-4f65-8a7b-1b72fb706af1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e63ccbba-9205-4568-9cba-a1620ebc1c89"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e648c28d-7277-4336-868b-2eab18ff5995"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e702ffa0-8f0b-48cd-af1d-0bd15d65c6e8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e76d7bb3-6ae6-434d-968d-b02cad868ca8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e866c629-6f72-47b4-996e-2853ce141b8b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e8b22579-3be8-405a-8f67-ba81995498e5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e90da3f8-6437-4e93-9a93-914eadbc9b3e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e9519a31-29c6-4bc1-a203-556c3216719d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ea3d6389-15f4-492d-8314-3fcbacab8df5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ea4d5c9a-932b-4036-96fe-f140c105de0a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eaa88228-0eee-4d9f-9b3d-3fd6933369a2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eacdb2e6-3807-4c96-908b-bfe7914361ac"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ead8d27b-3e46-4731-8d28-2624ea4d64ee"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eadeb688-0792-47f2-babf-68a4793f4530"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eaf68f3d-df12-446c-a46e-c8c42703798f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eb39d10e-a27d-4a90-b726-b01bae74b8af"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eb7e9533-9572-4157-acfc-fc19957b614a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ebee5023-d885-47c0-b6e0-79d650e9066b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ebf01160-25e2-42bc-9d9e-95a379f50949"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ec1ea3c8-a3b2-4d2b-a1fd-92aa1acad4ae"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ec4afcdb-49b2-479b-acde-d469a9f1ebfa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eca2ce30-e830-4fab-a1fd-651e87d7d338"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ecb1d180-5273-4312-b7ac-295d5d3f054e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ed0008cf-3fc4-480f-b558-5807e6b73b07"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ed12e385-3457-4a35-ba7c-6d94ea734680"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ed2f613c-c5d2-42bf-8f37-7d0bd1d50396"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ed35a494-6472-4c1b-b4f9-ca70771c0f56"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ed71b7c8-2ed7-4888-859c-6407a0e5951e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("edd54119-716c-4f73-9e30-785f59ea831d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("edfebf99-bacb-4e45-ad11-a88288f137d4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ee958bdb-fd0e-49b8-b1ea-50c0a40d2927"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eebd4f28-610c-4d21-abef-5516e40325ba"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eec83151-9a89-4c48-9a89-392f67d73628"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eee032ee-1364-4617-bdb9-3f1a1ae317e1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ef65057e-791a-430e-b956-f286d43183e5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ef840b61-204c-4bc2-8fdb-ec1c46841395"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f10e40b8-d25c-4acd-8d5a-3294a659baf6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f1594ff5-ca2a-424f-a88a-bf729a145941"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f1ce63aa-b43d-4370-b12a-ee87599a0f2b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f1e1de64-f685-4ae7-a375-6f49d353a8d4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f20eb996-2fb2-41fe-86de-8913330150fa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f2111741-b125-42dd-85dc-7e4f18761b07"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f271d892-56f8-4116-9728-fd5aeabfdf24"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f2a245d0-6f9b-4f09-8d0e-7361e2ee7543"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f2c19a6f-1f52-48a6-8e95-2aacfb82cb50"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f2d14de0-c3bf-4633-85f2-95a638e4a044"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f3531614-6ced-470d-9a08-931bcffcd088"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f391c6d9-34c2-40c2-a7ae-9c98636ca51d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f3aeabf7-e384-4a16-a201-b87f1131af9b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f3b2b0f8-72e3-4cc3-bd26-9c6bd227b160"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f3cf127c-89c0-4b8f-89d6-3f3a3beca97c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f3d97270-4307-425a-8a46-307cc639b6e4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f43d9358-9163-44a4-84be-e145ba46d86f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f4c77c84-d177-4d21-a7a3-c580b82ea7d8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f5005aa4-3c40-4265-9602-3c963c3974f4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f5241ef3-7557-4902-90fe-1ffbbc8a316a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f57989bf-6a0b-4007-9871-589e19d6b348"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f5fb1897-a52d-4840-94f9-4f6d5600a0fc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f6754371-9084-4588-9703-43d37d9ef8d3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f6d65af9-348c-46ec-b4fe-e6d7f438d217"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f74106ee-7927-4b8d-8c28-43abd04eeb97"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f83ded07-650c-4160-947e-53da244e918a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f8865a73-635f-40ff-b82f-dbe9ae991b85"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f8ac2916-9911-4485-bbdd-12fc4fd0aa63"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f8bf75ce-e2fa-49aa-a8f7-88912c8721b3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f913d1ea-e67e-46e4-934a-ac6cb87613da"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f9ac803a-2662-4143-8826-733dc0fcb56b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f9d8fa0b-b124-4ffe-8a4e-63aa79b57769"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fa18f1ab-4afd-42c8-8c66-726386630018"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fb0c23fd-4f69-4534-8c3e-4217e9c0dedd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fc4fd369-8551-43d1-866b-292af0af7831"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fc574bde-896f-4376-8140-3badcbe87920"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fcd79419-74ea-4e00-8509-c8871ab13192"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fd1e4e52-5deb-4830-9480-5939c892c510"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fd31f50c-a10e-4de2-aad3-af88cca244d6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fd484c73-52b4-4707-9881-fa826b837533"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fdb3a8d7-9083-4c2a-8df8-a3f363585f1b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fdce7252-9205-44e4-beb3-cd3b63a58fe1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fdfe737b-21b9-47e7-bcd8-02662906e3a6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fe7829ef-824f-4b45-8bc5-76ab9005ce62"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fea17df9-f957-46e2-8ffe-99ec9ce7b824"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fea68a34-5841-4c9d-8ddf-6a883decaf60"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("feaf8377-d83a-49c9-b51a-aa9f520dccc5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("feff8cec-16f8-4784-8ac6-8add870851eb"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("2609c5fa-8260-4942-aa15-310ec98ea5ee"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("8618be4a-9345-4805-9e20-7b751ce1a48d"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("a10d5dce-fa04-448f-a046-580959191be4"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("a9996656-58b7-43c7-a2cb-2b8ce8c77bbf"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("d06bd259-e8ae-4ebc-ae63-6f604216e145"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("d6b896fd-a953-4600-b7b5-3afd9d6f3d1e"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("df7bd196-a0b2-44d1-9bb0-59ab1c13fff5"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("e1917ca5-956e-42bd-85b9-410c8bead315"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("effe2ba4-7dbd-4e38-b91a-8054aae96271"));

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("f75d247f-baba-4ba3-9313-fc0beefcf7a0"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("0405895f-9d73-4e0e-b57d-4baee271af7f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("1f65eb90-d5d1-400d-8e19-b014b5c7d97f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("523e7258-f694-4a51-910a-22d078da649b"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("9ee0a1e4-2afc-46ff-80de-f53957479eed"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("ab0f7275-9fce-43a1-b136-f656e756eb0b"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("bfc629f7-35c0-4ab0-8bc5-fd643a275f8b"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("ce0dfa59-fe95-43f3-b8f2-369c77f886ed"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("daa3695e-2665-4c72-83f5-d71ad2a48a78"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e21c601c-0885-41fa-b002-f3d8cb2b7b45"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e2d4d9d8-def0-472f-a3d3-c7b257796ba0"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e77ac035-eb28-4c3e-a024-4351a050a31e"));

            migrationBuilder.RenameTable(
                name: "StudentTeachers",
                newName: "StudentTeacher");

            migrationBuilder.RenameTable(
                name: "ParentStudents",
                newName: "ParentStudent");

            migrationBuilder.RenameTable(
                name: "ClassroomTeachers",
                newName: "ClassroomTeacher");

            migrationBuilder.RenameTable(
                name: "ClassroomMainCourses",
                newName: "ClassroomMainCourse");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTeachers_TeacherId",
                table: "StudentTeacher",
                newName: "IX_StudentTeacher_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_ParentStudents_StudentId",
                table: "ParentStudent",
                newName: "IX_ParentStudent_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassroomTeachers_TeacherId",
                table: "ClassroomTeacher",
                newName: "IX_ClassroomTeacher_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassroomMainCourses_MainCourseId",
                table: "ClassroomMainCourse",
                newName: "IX_ClassroomMainCourse_MainCourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentTeacher",
                table: "StudentTeacher",
                columns: new[] { "StudentId", "TeacherId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParentStudent",
                table: "ParentStudent",
                columns: new[] { "ParentId", "StudentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassroomTeacher",
                table: "ClassroomTeacher",
                columns: new[] { "ClassroomId", "TeacherId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassroomMainCourse",
                table: "ClassroomMainCourse",
                columns: new[] { "ClassroomId", "MainCourseId" });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "SemesterId", "StudentId", "Type", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("005b45d6-c199-467e-bb56-124e7b61401b"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8449), "192.168.1.81", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null },
                    { new Guid("03a32433-b892-415f-960d-b60001ae88e4"), "Computer9", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8481), "192.168.1.39", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("04ef92da-5441-43bd-867e-d74ac40e470c"), "Computer31", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8580), "192.168.1.97", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("0861fd6e-1311-4496-99d0-fe7e577ef987"), "Computer23", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8540), "192.168.1.97", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null },
                    { new Guid("0a9e55f1-26d5-49fa-a2f9-65312ae4b4f6"), "Computer22", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8536), "192.168.1.35", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null },
                    { new Guid("10ec9639-9bbd-416c-9efb-50d6f034d0ff"), "Computer30", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8576), "192.168.1.52", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null },
                    { new Guid("1bd3df30-f866-45cf-a70a-edab8d1fb846"), "Computer36", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8602), "192.168.1.54", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("21d8662e-8d2b-47f3-ba2c-cd05d385562e"), "Computer14", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8502), "192.168.1.93", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null },
                    { new Guid("27eec676-f2d1-4ab9-bf50-63c8832f6acf"), "Computer51", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8664), "192.168.1.81", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null },
                    { new Guid("3a002558-9d06-4730-9e44-ba24d147472b"), "Computer16", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8511), "192.168.1.74", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null },
                    { new Guid("3b9f795a-7105-4eb3-9e01-8b82dba83c7c"), "Computer19", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8524), "192.168.1.92", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("425d0fd5-c29e-4af6-84d0-c80e8a9079da"), "Computer49", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8656), "192.168.1.5", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null },
                    { new Guid("474df99d-561d-4730-8a81-808564c06c17"), "Computer3", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8453), "192.168.1.61", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("484d8f2c-d334-4ec7-9e98-749e83ecedf9"), "Computer18", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8520), "192.168.1.70", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("4d6f9e88-084b-4ef2-a6d9-fa5c48138a96"), "Computer8", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8477), "192.168.1.9", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("4e536b73-5abd-41e7-bcaa-751e0203baff"), "Computer42", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8627), "192.168.1.82", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null },
                    { new Guid("54fc4f48-5616-4d7f-90b4-a524a1eba7e3"), "Computer12", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8493), "192.168.1.94", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("55a9a49f-f721-44b2-a5f0-eceafce52874"), "Computer7", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8470), "192.168.1.18", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("57cea3cb-c465-4d25-918c-e812a23dc1e6"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8416), "192.168.1.46", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null },
                    { new Guid("5cff23a9-3480-451c-a5b7-f3944e3d3351"), "Computer20", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8528), "192.168.1.47", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null },
                    { new Guid("5e71bdab-f9f1-44f6-8b12-12b0b4907df7"), "Computer53", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8672), "192.168.1.23", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null },
                    { new Guid("61300edd-9118-4fbb-9a05-97ece4f3b8ca"), "Computer60", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8708), "192.168.1.79", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("6a01d3f9-57c0-4874-b080-51305e549844"), "Computer47", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8647), "192.168.1.72", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("6ca29e10-64c6-43ad-8281-15ea532935fc"), "Computer17", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8515), "192.168.1.4", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("6eb97262-7677-487c-a2a7-6ff3bff82c31"), "Computer48", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8652), "192.168.1.33", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("70b255b1-abef-43d1-ad68-8550b9a10b26"), "Computer41", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8623), "192.168.1.98", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("760f6cc0-63d2-4e0a-9d39-0c145158d3b2"), "Computer56", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8686), "192.168.1.70", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null },
                    { new Guid("7756e368-4b85-4d9c-80a5-23ab6e6e67bb"), "Computer21", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8532), "192.168.1.51", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null },
                    { new Guid("78039291-4200-4cf5-a79d-051ab24d9b81"), "Computer6", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8466), "192.168.1.99", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("7813b46d-88e3-43c6-935c-e5cd5f709e0e"), "Computer39", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8614), "192.168.1.28", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null },
                    { new Guid("7c615b55-4e13-4fbe-a43c-e084ff445abd"), "Computer15", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8506), "192.168.1.33", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("7d78e82c-44d2-4995-80fa-e1be8a8d4554"), "Computer10", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8485), "192.168.1.99", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null },
                    { new Guid("8495277f-498a-4d3c-9a93-e2f672c09b80"), "Computer33", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8590), "192.168.1.48", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null },
                    { new Guid("88ef78ef-c139-419e-b2d4-347686488bce"), "Computer5", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8461), "192.168.1.86", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("8ccc40d5-3cdd-4ff4-b623-bce967d18d65"), "Computer46", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8643), "192.168.1.43", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null },
                    { new Guid("913c983b-42b7-41b9-aa7c-e00caac7c3f6"), "Computer54", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8676), "192.168.1.16", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null },
                    { new Guid("91f08961-21ee-4e75-842a-b558c7d48ead"), "Computer28", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8569), "192.168.1.96", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("98634660-98af-4814-ab83-c63e4c23c7e3"), "Computer27", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8565), "192.168.1.15", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("9e6e7075-32be-4170-bb60-45edac4aa095"), "Computer32", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8586), "192.168.1.85", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("9ffaa578-b98b-4685-8c2c-d0c8160d64b0"), "Computer35", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8598), "192.168.1.8", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null },
                    { new Guid("a0ddc376-1f10-4b84-93c3-1b438f2aeced"), "Computer4", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8457), "192.168.1.61", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("a36d7f19-36fa-4a54-b7ea-d5a993e1d8a8"), "Computer24", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8545), "192.168.1.25", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null },
                    { new Guid("a836418e-5128-44d4-af0c-15a576456dcb"), "Computer45", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8639), "192.168.1.60", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("a96409a9-e24b-497e-a91b-c7d14a0fbe35"), "Computer59", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8704), "192.168.1.15", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null },
                    { new Guid("aa1dbc25-7ef4-441c-a028-20db54bc65ee"), "Computer50", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8660), "192.168.1.16", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null },
                    { new Guid("af42028c-aa2f-4abb-a8f1-efb899852640"), "Computer38", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8610), "192.168.1.43", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("b079f2ce-bc67-4d34-83ea-e92ab835a5bf"), "Computer11", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8489), "192.168.1.91", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null },
                    { new Guid("b4d1b928-945e-459d-84c1-84997d112035"), "Computer58", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8700), "192.168.1.97", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("b543af2c-d948-472a-ba24-a05d32f36196"), "Computer57", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8696), "192.168.1.3", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("bc1748ae-293a-4abc-bf32-2c93d4006046"), "Computer13", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8498), "192.168.1.28", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null },
                    { new Guid("c544a8f2-10f8-4e5d-a7d2-10ba5090e4c8"), "Computer25", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8549), "192.168.1.39", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("cb565e1a-049c-4abf-93b1-dd7463ad487f"), "Computer43", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8631), "192.168.1.69", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("e0129d61-4d29-42f5-a932-6a71259b6d11"), "Computer26", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8561), "192.168.1.95", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 0, null, null, null },
                    { new Guid("e49cee1d-9b52-4b62-9819-a1395c02c920"), "Computer55", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8680), "192.168.1.99", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null },
                    { new Guid("e993ace6-282b-41f1-a757-8619b0e2cbbc"), "Computer40", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8620), "192.168.1.27", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null },
                    { new Guid("e9b9879b-192b-4705-a7fe-6fe56b42961c"), "Computer44", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8635), "192.168.1.55", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null },
                    { new Guid("e9c51deb-d7f1-4808-a7b6-71ed067765f8"), "Computer34", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8594), "192.168.1.71", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null },
                    { new Guid("f020800c-5db4-4685-8bd0-f58854b28382"), "Computer37", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8606), "192.168.1.20", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("f593aab2-01d0-40c2-97ec-6c484dfa26e2"), "Computer52", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8668), "192.168.1.50", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null },
                    { new Guid("f6526354-d9b8-4cfa-9227-0d3b3875241c"), "Computer29", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(8573), "192.168.1.71", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "AttendanceDate", "AttendanceStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("08a98a7d-f3ab-4a3f-baa7-0e323e3b40e8"), new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer24", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9769), "192.168.1.7", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("0da4958c-db00-486b-9680-bd2ff6767548"), new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer27", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9787), "192.168.1.36", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("18b120ae-1e7a-4d08-a1e7-179094dd412b"), new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer17", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9735), "192.168.1.37", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1cb9764b-f6c1-4eaa-8e4c-33f463794e68"), new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer9", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9686), "192.168.1.92", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("241678ec-8d44-4e94-9dad-a3545f5ce7cf"), new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer12", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9702), "192.168.1.88", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("2c5839c9-0695-4908-8b0c-2cd980825ea7"), new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer21", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9754), "192.168.1.78", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("336c1e66-0295-42c0-b1c2-64214ca46092"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9625), "192.168.1.28", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("3b7fbdd5-4534-4565-8f9b-6acfc61e2714"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer25", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9777), "192.168.1.57", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("3c196425-83a8-4466-98fb-5cfe223a148d"), new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer28", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9792), "192.168.1.49", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("3ebba850-a835-49a0-b0d1-ea16cf6780f8"), new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer44", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9874), "192.168.1.81", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("4232ae7c-d3a8-4f53-b92c-a2ec0f0880e7"), new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer16", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9721), "192.168.1.54", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("4822ed0b-1181-4af5-93e1-5cdce7240d30"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer36", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9833), "192.168.1.85", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("48449b79-bf8a-49af-899b-dccadd00cfc3"), new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer37", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9837), "192.168.1.28", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("4e903cbf-5417-4653-9ba6-f3d5b30d59eb"), new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer32", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9810), "192.168.1.25", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("5ccaeba9-7715-43d8-8e31-0dd73272cbea"), new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer3", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9651), "192.168.1.94", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("5e559fef-3900-41c6-b29f-73ce6da208bb"), new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer40", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9852), "192.168.1.70", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("601b6ed7-7cb7-4648-be6f-c870a0c59db5"), new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer43", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9869), "192.168.1.6", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("60208e53-48d1-4103-9399-284140668b95"), new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer20", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9749), "192.168.1.51", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("676567b2-672b-4ab2-9ba5-cb98d317fe87"), new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer31", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9805), "192.168.1.60", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("683ba387-bf02-4200-aff6-ba17ed1e8c2c"), new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer38", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9842), "192.168.1.28", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6dcb7bd9-cb91-426e-bac9-12d9ee4ba43d"), new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer8", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9677), "192.168.1.56", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("73d8038a-74e8-423e-9128-adbfa0bb1de3"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer4", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9655), "192.168.1.35", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("73f3c5c6-e73d-46f2-95ef-40f0015c9616"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer45", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9879), "192.168.1.41", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("7534c264-d8c9-43d2-b155-0a5784d8675f"), new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer29", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9796), "192.168.1.12", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("84105e68-66b6-4900-9ec5-cc60571dd2c8"), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer11", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9697), "192.168.1.4", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8744f473-ea13-4904-b77c-241f28e24845"), new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer42", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9863), "192.168.1.55", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("8bab2594-ab29-47f0-8b53-a8db70871d27"), new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer30", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9801), "192.168.1.15", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("8eef8bdd-4b42-46e6-8952-f896937c4b3d"), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer33", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9817), "192.168.1.30", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("93a1d5ce-5a01-42f0-9ca7-f7dc99555341"), new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer5", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9661), "192.168.1.46", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("9a827a93-d4b8-45fe-94df-40278cb3c453"), new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer18", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9740), "192.168.1.60", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9be11115-27f1-48be-a746-740f8a579e19"), new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9646), "192.168.1.98", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a46a6fee-58ec-40c2-91c4-d61c96b324b6"), new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer15", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9716), "192.168.1.43", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("abe31a2c-8778-4820-9bfb-4962a2249b9d"), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer26", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9781), "192.168.1.9", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("af164c93-f9c5-489f-91dd-7dc94c759eee"), new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer19", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9744), "192.168.1.30", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("afffcb39-d491-4634-80cb-0442827667c3"), new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9641), "192.168.1.61", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("b046bece-b17a-4400-82d7-1551761832d1"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer46", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9883), "192.168.1.48", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b2dff3cc-a850-4bf2-8143-deb91649c671"), new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer14", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9712), "192.168.1.26", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("c3492178-c569-4ed5-935e-c17d42463d0e"), new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer10", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9690), "192.168.1.67", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("c36a364c-5f74-46e8-9549-a1d89995cf37"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer22", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9758), "192.168.1.33", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c6152c70-39ed-41af-bf31-6d821a3f0331"), new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer7", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9672), "192.168.1.77", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("cb4d8a12-b59e-40f0-91aa-3dfb669f1dd7"), new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer23", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9764), "192.168.1.9", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("d9582154-aa11-4261-b537-acc8e2249f35"), new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer39", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9847), "192.168.1.33", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("decc0de1-d365-482e-9137-95265dd72558"), new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer34", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9823), "192.168.1.84", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ebe8a860-090f-4579-b610-efbf552645df"), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer6", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9667), "192.168.1.52", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("ed9e2f3d-9175-45f9-ad00-f1b5ea2fa119"), new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer35", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9828), "192.168.1.96", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("eef1e8cb-037e-4c48-aa36-8a7f91969150"), new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer41", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9858), "192.168.1.42", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("f3299e8c-cfd8-4c7e-ab7c-0b919efbeed6"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer13", new DateTime(2024, 2, 9, 11, 23, 5, 151, DateTimeKind.Utc).AddTicks(9707), "192.168.1.10", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.InsertData(
                table: "DiscontinuedStudents",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "StudentId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("5f2d38fb-e30b-4f9b-968a-d12269189afe"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 153, DateTimeKind.Utc).AddTicks(529), "192.168.1.77", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), null, null, null },
                    { new Guid("89ad77c7-d0c8-4d48-b21d-f1b9786e63dd"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 153, DateTimeKind.Utc).AddTicks(544), "192.168.1.35", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ExamNumber", "Score", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("005ea28f-c75b-41b3-b48a-7dc85e035128"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2784), "192.168.1.34", (byte)2, 99.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("00bf37ca-622c-4ef7-bb7c-d9fb2ec319b9"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3238), "192.168.1.10", (byte)2, 36.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("00c2dc4e-1a0b-4910-b882-951971e40092"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4030), "192.168.1.33", (byte)3, 86.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("00f896e5-4f05-475b-80d2-420553bd7988"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2268), "192.168.1.18", (byte)1, 4.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("01037e02-5bcd-4359-b074-b3bf437a3872"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4358), "192.168.1.76", (byte)3, 9.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("011a013a-96ff-4fab-96d8-da7c02d77c0b"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3784), "192.168.1.24", (byte)3, 64.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("011b0499-d457-4962-bea5-e8bd871c9fc3"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3796), "192.168.1.63", (byte)3, 26.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("012bb3eb-07a7-4d31-8c4a-f607a3a097b9"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4555), "192.168.1.6", (byte)3, 26.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("0154f16f-0375-4b18-abc5-e007dc66f68b"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2763), "192.168.1.44", (byte)2, 3.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("018ff3dc-8dcb-40b9-bc82-e961ec42c85b"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2941), "192.168.1.96", (byte)2, 79.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("019777a5-3d4d-4bf9-86ab-55c9c3186493"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4681), "192.168.1.51", (byte)3, 91.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("01e1c7b3-162e-4034-82a5-ff2dbf1640b3"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1896), "192.168.1.65", (byte)1, 21.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("022f186c-6ac5-4f25-af94-781b9891b40b"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2402), "192.168.1.10", (byte)1, 15.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0251b2f3-c6e8-452f-9a20-ed60ec52d6a0"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1929), "192.168.1.54", (byte)1, 34.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("026a263a-f53b-4e9c-a5f8-2095a4adc7a5"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3760), "192.168.1.20", (byte)3, 7.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("02b0d01a-8c0b-4362-9715-6fe6b21c2c88"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2035), "192.168.1.75", (byte)1, 56.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("02ca6838-dadb-45bb-9658-21a7d2d79c52"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2207), "192.168.1.85", (byte)1, 99.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("03819b37-f4b8-4e03-932c-62ae0e40639a"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4551), "192.168.1.46", (byte)3, 57.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("041e8c97-8fa6-4df3-a79b-104896969986"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2358), "192.168.1.16", (byte)1, 86.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0491b6b7-213d-4372-91d0-69571b6b2054"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2257), "192.168.1.92", (byte)1, 12.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("049d300b-0dad-4bdc-ac3a-db9fcb97dbfb"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3234), "192.168.1.48", (byte)2, 19.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("04a19cbd-9ace-4b17-9b54-9bd8324805c9"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4258), "192.168.1.20", (byte)3, 0.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("04db1d29-d6f5-42ab-8197-3d09c21aead7"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1848), "192.168.1.67", (byte)1, 93.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("05024067-e2c8-4728-b874-91ac86158f00"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2598), "192.168.1.20", (byte)1, 41.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("055a86ce-77e5-4860-b388-f6d6c245cd11"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4170), "192.168.1.5", (byte)3, 68.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("05e3b08d-b013-4bd6-befa-69610660a046"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3481), "192.168.1.15", (byte)2, 62.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("06622404-8d13-4486-9591-7bb20b2b7046"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2946), "192.168.1.49", (byte)2, 18.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("06693ba1-6c05-4081-98f6-1e869f10cf0b"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2730), "192.168.1.55", (byte)2, 97.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("06bf5e09-10d7-4c38-ac24-5cc76f2004a4"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4094), "192.168.1.23", (byte)3, 67.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("06ccf203-a6ea-4316-acec-2b5186042b49"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2337), "192.168.1.68", (byte)1, 26.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("0751f61f-3bc4-4dce-b137-3dc200f0740e"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4343), "192.168.1.68", (byte)3, 98.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("078be022-f9cc-4a60-b5f4-22f77875c7f2"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3800), "192.168.1.19", (byte)3, 15.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("07e07007-fe54-40e8-83e4-31a6b2a13174"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3712), "192.168.1.44", (byte)3, 26.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("0816d348-bdce-4ca5-8084-4f314830e6b2"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2722), "192.168.1.97", (byte)2, 91.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("08951da7-1923-4735-b77e-b28c1307cde2"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1859), "192.168.1.73", (byte)1, 22.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("099f0124-d41e-4fd5-b3fe-819aebee1e24"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2249), "192.168.1.60", (byte)1, 90.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("09b8b8ee-87a8-4985-b6b8-b0fe664879f0"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3767), "192.168.1.11", (byte)3, 38.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("09f69f74-57f6-4cf3-8e52-3290627682b8"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3506), "192.168.1.98", (byte)2, 90.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("09f823de-8551-48e5-b99e-0b69288011b3"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1932), "192.168.1.99", (byte)1, 10.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("0a2d6bd7-a80e-497a-a92f-8fc95989c556"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2675), "192.168.1.1", (byte)2, 38.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("0a9bcfab-61ad-4bbc-8a96-158beacb54e7"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3088), "192.168.1.1", (byte)2, 33.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("0b26d209-0414-4886-9ffd-76fc6e836a16"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3316), "192.168.1.2", (byte)2, 78.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0bbd807b-3f2a-4aba-a7dc-a358e2938398"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4001), "192.168.1.65", (byte)3, 40.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("0bde01d2-6a4e-4de0-9790-09a35fc05f5b"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2512), "192.168.1.54", (byte)1, 74.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("0c326899-b8c3-43ff-96e8-7e195fa9d392"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2696), "192.168.1.63", (byte)2, 58.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("0c4a8326-0162-418c-9949-c4326e2d442f"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3861), "192.168.1.83", (byte)3, 29.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("0caa3e40-caf8-4ac4-a922-ad1286891de0"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3453), "192.168.1.67", (byte)2, 53.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("0d21f61b-9d4d-4e21-92c8-193b3d949b39"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2970), "192.168.1.48", (byte)2, 57.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("0d9daaaa-fcfa-4c29-b363-530e502b261b"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2578), "192.168.1.86", (byte)1, 10.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("0da0e00e-2eee-456f-9780-8f65149644ea"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2844), "192.168.1.90", (byte)2, 31.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("0e46da89-6d4d-492d-ad79-674b92b0271c"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4078), "192.168.1.13", (byte)3, 56.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("0e92edab-5c28-4303-a5af-d7062ffec6f3"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4091), "192.168.1.86", (byte)3, 64.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("0f2d64c2-3717-4f98-84a4-f16a650b3bd1"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3416), "192.168.1.30", (byte)2, 60.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("0f2e32bf-778e-4d2f-a356-8b2d33e75d9f"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2305), "192.168.1.15", (byte)1, 94.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("0f35abd1-ea76-4b0a-b11b-02cc114230f1"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3246), "192.168.1.74", (byte)2, 36.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("0f793664-becc-4644-b6f9-8ab6d0ab6e42"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4106), "192.168.1.30", (byte)3, 57.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("0fdc949d-5ff7-40d6-bcb9-f60920eb4ef8"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4045), "192.168.1.31", (byte)3, 39.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("0fe542db-6a81-43da-87c3-a2f5e0e81bd3"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3740), "192.168.1.33", (byte)3, 64.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("11234aca-84ad-476b-bc9e-743e397f2496"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4017), "192.168.1.85", (byte)3, 41.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("11865926-4c50-4c48-8403-7a907a77ca25"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2832), "192.168.1.57", (byte)2, 79.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("11a4401b-26e8-497a-8884-a109c479c4a8"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2370), "192.168.1.95", (byte)1, 2.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("11e73ca7-a4d9-4c63-8e7b-de6f22e7f7e6"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4235), "192.168.1.78", (byte)3, 96.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("123f6e78-49db-4a05-9736-a74f051a35d6"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1811), "192.168.1.39", (byte)1, 48.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("12aab508-a141-47d6-ad34-034b45a45e3f"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2414), "192.168.1.85", (byte)1, 65.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("12ce948e-47ac-4f3b-9e98-d414753f2ac3"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4127), "192.168.1.5", (byte)3, 57.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("12f4f029-33ae-4f23-b433-2eaa9fa317f6"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1917), "192.168.1.38", (byte)1, 30.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("1347904d-223c-47f7-b83d-8293fc3d4e47"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2480), "192.168.1.77", (byte)1, 63.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("138182f9-e6ba-4c35-aca4-8d3f136199fe"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3518), "192.168.1.19", (byte)2, 19.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("138e5393-7117-4d46-8d78-c3f196a0275e"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1864), "192.168.1.28", (byte)1, 37.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("138e8dd1-08bb-4d13-aa77-e81bc01a5387"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3259), "192.168.1.56", (byte)2, 52.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("13cbd71a-ab06-42ee-8f09-4eedd1e413ae"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2166), "192.168.1.97", (byte)1, 46.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("13fd107e-f94e-4e4a-bf4a-a33053836af6"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1647), "192.168.1.57", (byte)1, 51.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1406ad94-3ad4-4f9a-9d1c-0eadac1666ab"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4318), "192.168.1.81", (byte)3, 18.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("1433c641-6634-4535-aec6-19b8662527d7"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3997), "192.168.1.73", (byte)3, 63.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("144da962-5cd2-4d57-9aa2-7f727645bd2a"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3330), "192.168.1.3", (byte)2, 40.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("14bc339d-2e36-4137-a9cd-01657252ffff"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3366), "192.168.1.51", (byte)2, 4.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("14e139b5-d1f8-406b-8b16-58c05d1766ad"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1726), "192.168.1.30", (byte)1, 80.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("15171a92-a67c-44c4-a768-3405d61934b7"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4367), "192.168.1.81", (byte)3, 31.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("158faa3e-c4e8-45f6-ae6d-6bed9e1793c3"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4131), "192.168.1.2", (byte)3, 23.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("159cbd91-ca95-40a0-baf3-b068762d2daf"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3780), "192.168.1.39", (byte)3, 57.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("15a129e2-0dd8-4b39-8b73-49d1c3e34cd1"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3226), "192.168.1.82", (byte)2, 62.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("15aaad94-3bd1-42b3-8eb6-ebce012ab533"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1593), "192.168.1.41", (byte)1, 66.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("15cf7ecf-de41-43b2-927e-5dcf8aa410b1"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4074), "192.168.1.5", (byte)3, 93.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("16de8730-a2ac-46e1-bdee-e9b988c73e4f"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4661), "192.168.1.18", (byte)3, 3.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("16e69358-c607-4ccd-9597-de374f08b093"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2905), "192.168.1.81", (byte)2, 60.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("17595bc8-2140-4945-9102-c9d1ae2624ef"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3043), "192.168.1.12", (byte)2, 68.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1762c65a-c314-4c6f-9199-becf03d6e303"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1731), "192.168.1.45", (byte)1, 44.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("19361fb9-de6d-452b-9221-8c5cabc3a3b1"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3174), "192.168.1.38", (byte)2, 32.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("19ce77d0-e77c-4c66-9b91-a0e9e84468dd"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4066), "192.168.1.34", (byte)3, 31.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("19eba8c3-42b9-48d1-a0d0-4c0775c71094"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3565), "192.168.1.77", (byte)2, 24.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("1a2f333b-09d0-489e-ae96-b8fae338b51b"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4271), "192.168.1.81", (byte)3, 98.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("1a8d5b3b-5816-4ee3-aaae-092e7c5af19c"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2690), "192.168.1.50", (byte)2, 17.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("1abd5480-59a2-4537-a9a2-2a01ec2b3d8a"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2341), "192.168.1.23", (byte)1, 17.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1b028e79-08ba-4c89-a1b4-f428cf3de486"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2978), "192.168.1.16", (byte)2, 30.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("1b0f9169-5cf0-4ee2-964a-43d005e126bf"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3357), "192.168.1.61", (byte)2, 24.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("1b913ad7-cbaa-4e5b-9770-4c33dde7a477"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4371), "192.168.1.15", (byte)3, 45.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("1ba76708-5fce-4358-afea-83e4b3985f0c"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4605), "192.168.1.57", (byte)3, 67.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("1c013e94-d51f-4fe0-a341-f8abbec80bce"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3096), "192.168.1.75", (byte)2, 82.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("1ca179ff-b5da-4923-8ef3-772984989a71"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3166), "192.168.1.97", (byte)2, 75.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("1d18c0f8-91c5-4858-b6cb-a2798550b7ff"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2081), "192.168.1.16", (byte)1, 60.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1d2a3429-5e92-46d9-a588-d9d23d76a5ec"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2718), "192.168.1.52", (byte)2, 87.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("1d6504f6-fee7-4bea-ab74-11dfe36a2703"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3148), "192.168.1.7", (byte)2, 26.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("1da5bfff-3e94-46eb-9033-2229520bacbc"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2995), "192.168.1.17", (byte)2, 27.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("1dea681f-b366-4735-b397-78eb8bd29b0d"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3385), "192.168.1.72", (byte)2, 43.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("1e471341-4124-4b08-94f0-9ceb4be652d9"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2726), "192.168.1.28", (byte)2, 12.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("1eeecb00-5919-470c-86b6-c6baae3ae4eb"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4222), "192.168.1.1", (byte)3, 23.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("1f16f790-acf2-45a4-be2f-3563e548f797"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2457), "192.168.1.40", (byte)1, 12.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("1fa7dc9f-fd3a-4865-b7cf-bb5f867e1e72"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4482), "192.168.1.70", (byte)3, 51.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("1fef164c-d86f-4d92-83dd-cf19ca692c7d"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2330), "192.168.1.70", (byte)1, 0.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("2020405e-2c9b-4cb8-897c-b9d2243c31e8"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3056), "192.168.1.72", (byte)2, 6.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("202522a8-4ec2-459d-94b9-7853d012cb4e"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3389), "192.168.1.75", (byte)2, 12.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("20e998db-5fe6-42f9-87d8-1c54401b8aa5"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2820), "192.168.1.22", (byte)2, 94.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("21027fb1-c6fe-4fd7-a890-9c68cd6e8700"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2751), "192.168.1.50", (byte)2, 67.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("2103ff62-16d3-4af2-b28b-dcec3eeb7e17"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1709), "192.168.1.71", (byte)1, 95.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("2121be09-2af6-44ec-ae7f-76e43d82e5df"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2142), "192.168.1.49", (byte)1, 3.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("213aaaa2-138b-46c6-8020-fa2d08236cfb"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3280), "192.168.1.21", (byte)2, 67.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("218aac4b-747f-4242-84cc-b6b86563b786"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4535), "192.168.1.76", (byte)3, 13.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("21d1f6bf-dc05-45b2-9ab9-39b14fb7fc20"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4085), "192.168.1.67", (byte)3, 54.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("22bc4701-93a6-4ad4-b8aa-c3dab0b839d2"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2795), "192.168.1.98", (byte)2, 85.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("22fcee10-831e-4a6a-9d39-27464fd1c9d8"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4102), "192.168.1.85", (byte)3, 30.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("23383987-3255-4c64-8889-ca5735e1d4e7"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2129), "192.168.1.57", (byte)1, 94.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("233aa6cc-7a37-4258-b468-e64977b75cc8"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2178), "192.168.1.73", (byte)1, 83.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("23ac2364-4c05-4556-aa48-75fc9d6680b3"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1631), "192.168.1.10", (byte)1, 65.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("249329ec-3c12-44e6-a270-046501be6c7d"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1790), "192.168.1.79", (byte)1, 17.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("250b7627-3951-46ea-8302-02d462135f41"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3460), "192.168.1.82", (byte)2, 99.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("25528e7b-4ee5-4402-9123-83f58b8bc288"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3370), "192.168.1.73", (byte)2, 65.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("258bda7e-4600-487d-958e-69bd8808cc04"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3853), "192.168.1.72", (byte)3, 5.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("259d5d48-c7f7-4c9b-a1b0-3130a6b23631"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2840), "192.168.1.24", (byte)2, 43.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("259e3557-6b93-43ec-b03e-78fbaab4c970"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3825), "192.168.1.4", (byte)3, 32.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("25a5eb48-276f-4914-821a-3aa46476f59b"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4419), "192.168.1.50", (byte)3, 77.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("25b0742c-8084-4ada-8ba5-2f68b469b11a"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4330), "192.168.1.45", (byte)3, 93.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("25b1eb19-4aab-445e-839c-96423c201f17"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3051), "192.168.1.8", (byte)2, 86.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("26ce690e-7a38-400e-a986-0b5aa313ec0a"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4226), "192.168.1.7", (byte)3, 75.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("275afd3e-84be-4aa5-8fb5-a7dc277f30d6"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4408), "192.168.1.51", (byte)3, 14.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("27744785-161a-4672-9eaa-959b630403ff"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2537), "192.168.1.11", (byte)1, 24.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("278aa89c-a3c8-4406-9e2d-f565b55ad4e4"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4539), "192.168.1.84", (byte)3, 42.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("279ec77d-2b23-404b-9a0c-5bc131617e1a"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3221), "192.168.1.69", (byte)2, 44.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("279fff71-493f-4c17-911c-b829b52d768f"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2999), "192.168.1.52", (byte)2, 33.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("2856db29-bcea-4108-8c27-fc66a7879e88"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2658), "192.168.1.6", (byte)2, 16.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("286befd5-7975-47fa-9596-12258bc26108"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2918), "192.168.1.64", (byte)2, 56.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("28f91b21-a0af-45c0-ab7a-af47c452acd1"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2077), "192.168.1.2", (byte)1, 19.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("2909d773-de4e-4ca2-aeb2-355aa5dedefe"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2734), "192.168.1.86", (byte)2, 59.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("2931045a-2ab0-48f0-83ce-27bd2a1bd9fb"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2625), "192.168.1.55", (byte)1, 10.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("293db877-ec0c-4e84-881a-978b7b89a9c2"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3817), "192.168.1.12", (byte)3, 26.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("2947742f-826c-4966-b421-2b315c82522d"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4210), "192.168.1.49", (byte)3, 15.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("29a077c5-a7f7-4ddb-9c2c-0b93e909a235"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2276), "192.168.1.8", (byte)1, 51.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2a3b292c-40da-418c-a137-add22d165ebe"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1855), "192.168.1.1", (byte)1, 60.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("2af99fab-568f-4372-89d6-0849a876930a"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1609), "192.168.1.42", (byte)1, 37.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("2b4da6df-1985-46db-94c8-00b7f768c1ce"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4203), "192.168.1.2", (byte)3, 52.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("2de38311-6655-43af-9644-007e925244d6"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1735), "192.168.1.43", (byte)1, 40.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("2e22b09f-4a9d-4c01-859f-c60d7d54e274"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2780), "192.168.1.73", (byte)2, 72.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("2e45181a-2e0e-4b00-a4e9-a7d13e6b4cf6"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3265), "192.168.1.24", (byte)2, 26.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("2f06a3bf-95e6-489d-8341-eed7337fdaab"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4642), "192.168.1.64", (byte)3, 1.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("2f400253-6749-4638-8067-97cb6eb0309c"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2564), "192.168.1.20", (byte)1, 0.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("2f46bc37-ac65-4a17-aaec-8308b9334508"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2377), "192.168.1.30", (byte)1, 14.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("2f8be050-53f7-4722-9a8c-42ce10faef45"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1851), "192.168.1.36", (byte)1, 42.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("2f9d1883-dfd2-481a-bf4e-2ae3a6d4b9c3"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4379), "192.168.1.73", (byte)3, 71.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("2fc91320-499a-4fbe-af07-8186ccd37c62"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3072), "192.168.1.63", (byte)2, 78.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("304e0717-d969-45e1-8453-3b7c9d857596"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3284), "192.168.1.7", (byte)2, 5.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("30838845-9545-49a1-aa2f-9fb24d1ea2a6"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2650), "192.168.1.65", (byte)2, 22.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("30e631bf-bfd1-417e-a06c-05b73163ba48"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1823), "192.168.1.11", (byte)1, 2.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("30fe4c3a-d920-4ded-b053-d7c36a0301c1"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2100), "192.168.1.69", (byte)1, 18.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("315741c3-cde5-4126-8d36-33381767e07d"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2211), "192.168.1.37", (byte)1, 74.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("31b24cd1-6b78-43df-8fa2-5feceff06e14"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4182), "192.168.1.47", (byte)3, 92.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("31b45ad7-9043-4eaf-bb60-c4d714b40d72"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4678), "192.168.1.32", (byte)3, 9.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("3269216f-2bf4-4df4-b2b1-ecfa8ce26b28"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4395), "192.168.1.56", (byte)3, 96.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("32942ba6-675c-4b1a-b95e-0d4b1f135100"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2605), "192.168.1.60", (byte)1, 3.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("330c1387-882d-4654-9edd-1d19de3b6616"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3374), "192.168.1.16", (byte)2, 54.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("33384386-39c1-49d9-a31e-213c06e97d44"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4264), "192.168.1.90", (byte)3, 75.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("3360ebfa-5943-4e2d-99a9-028b295c3adb"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1913), "192.168.1.74", (byte)1, 45.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("33915ac2-cfd6-4440-a3f6-fa242791f61a"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1974), "192.168.1.76", (byte)1, 70.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("33a7a18b-2429-4945-9a07-2bc2a6af0b8c"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2759), "192.168.1.85", (byte)2, 22.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("33cac9cd-0e73-4839-9215-0244430df60d"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2092), "192.168.1.72", (byte)1, 93.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("343af657-ac5d-425a-8a6d-ab6c81e4d776"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3104), "192.168.1.71", (byte)2, 57.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("35164cc1-925e-47de-83f1-54ea06d73277"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2533), "192.168.1.50", (byte)1, 48.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("35253831-1e93-42b5-9c05-9813ec3dc679"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4693), "192.168.1.12", (byte)3, 4.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("35f89521-a4c3-4f56-b7c9-440099893f33"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2117), "192.168.1.72", (byte)1, 27.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("3644c7a0-5dca-4ade-8303-aac4fbbd4cbb"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3116), "192.168.1.44", (byte)2, 50.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("36569139-3f57-4552-8cb0-c6d38e3afd59"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1961), "192.168.1.4", (byte)1, 88.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("37765832-a80a-4bfd-8779-cc91c7f6c923"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2443), "192.168.1.3", (byte)1, 32.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("38b688be-482e-46c6-b868-6c16ca86d813"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3470), "192.168.1.49", (byte)2, 21.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("39185e7f-320d-4033-96d6-d5f0532dc1fb"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2064), "192.168.1.17", (byte)1, 72.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("39352d7c-0197-49ae-9c5b-7031788bd115"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4471), "192.168.1.11", (byte)3, 80.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("39e606fd-9441-4905-a3d7-80fc278e068b"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1750), "192.168.1.9", (byte)1, 34.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("3a68b52a-dfbd-4153-8865-ab80231889ef"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3587), "192.168.1.68", (byte)2, 82.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("3b9dac9e-1316-4283-b66d-062251e79bbf"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4339), "192.168.1.75", (byte)3, 88.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("3bee2ee4-9625-434e-b69c-ca520bcbaff7"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2914), "192.168.1.90", (byte)2, 94.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3ca09455-19dd-44be-8525-df57f9a430d5"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2423), "192.168.1.44", (byte)1, 21.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("3ca651d3-89d8-4b99-86f2-cfcffff9d2b6"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2647), "192.168.1.24", (byte)2, 51.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3ccc0a31-e7bc-4cba-b167-83ebf6a732e5"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4186), "192.168.1.69", (byte)3, 36.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("3e1f9c65-9a26-4a39-895c-4ee464fc775d"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2472), "192.168.1.8", (byte)1, 69.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3e733b0d-fc35-420c-b8ad-73e5a9164af7"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4293), "192.168.1.63", (byte)3, 26.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("3e9c38e4-1ff2-42d2-a30a-aa497e5dd1d0"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2203), "192.168.1.11", (byte)1, 29.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("3eb0ef09-1e7f-4e69-98b3-3a76afb1d065"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1869), "192.168.1.2", (byte)1, 9.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("3f33ea7c-58df-435a-8d95-1c56a1b0e159"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3756), "192.168.1.42", (byte)3, 11.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("3f8d0410-fa04-4828-8b37-b71908a9dc45"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3433), "192.168.1.66", (byte)2, 71.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("401bbb37-7834-40ec-aa61-3b823ca01b1e"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1877), "192.168.1.72", (byte)1, 77.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("40bd9fea-fb1a-4029-b12b-f7fd56d61cb9"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4490), "192.168.1.38", (byte)3, 91.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("40d9a294-77ac-4766-b703-c220a5a2f796"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4375), "192.168.1.25", (byte)3, 19.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("410d8999-b6dd-4edd-a1c6-84d56a4f9903"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3083), "192.168.1.1", (byte)2, 89.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("41689bbd-939a-4ef9-9fda-49368ecc4fe0"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4247), "192.168.1.79", (byte)3, 46.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("4203a5eb-12cb-4d95-bf80-82ac006137a0"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2010), "192.168.1.3", (byte)1, 78.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("42642f7a-095a-44e1-be73-09740b748214"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3723), "192.168.1.28", (byte)3, 12.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("43a5ae21-a3df-429e-b26a-ac028d35eee2"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3141), "192.168.1.22", (byte)2, 20.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("43ac6975-f97a-46ee-bd0e-b883000f57c5"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2220), "192.168.1.4", (byte)1, 65.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("43db039c-ee13-4cfa-82d9-2543b86e342d"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2394), "192.168.1.87", (byte)1, 4.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("44fe0c88-496e-4e77-a683-b01146254fc1"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3695), "192.168.1.58", (byte)3, 26.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("45c1c53c-e40b-4a18-b9cb-ec67e2e4a7d6"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3929), "192.168.1.4", (byte)3, 28.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("46256afb-982c-4254-8bec-fe0d388c046c"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2410), "192.168.1.21", (byte)1, 24.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("466945af-b789-4424-9765-fce020030e99"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1836), "192.168.1.98", (byte)1, 11.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("467193f4-fb09-4661-88aa-99c1e69dd0d8"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4617), "192.168.1.11", (byte)3, 47.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("46b2dc7e-1c1c-4680-be01-ac6a897f61ff"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4013), "192.168.1.11", (byte)3, 84.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("46bd56d7-9799-44cf-991c-90b45d6c52c0"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4526), "192.168.1.9", (byte)3, 3.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4757998d-db8a-49f1-8873-fd424d899aee"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4310), "192.168.1.42", (byte)3, 12.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("4757df05-1016-4ce0-91d8-71b0908c19e9"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4314), "192.168.1.99", (byte)3, 37.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("475ad080-96b7-4169-a7f9-e2368a894d61"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4625), "192.168.1.24", (byte)3, 27.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("47868abf-ab83-4da6-acc4-a774a99158f8"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4596), "192.168.1.27", (byte)3, 60.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("49f24c03-3544-49b8-8d23-859da0bfd4d8"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3217), "192.168.1.47", (byte)2, 69.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("49f88d8d-8aae-4d33-b768-1d09a7692e9b"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2224), "192.168.1.19", (byte)1, 27.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("4a17b6a0-4351-4a43-9c69-824f3a72ed4b"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2072), "192.168.1.92", (byte)1, 61.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("4a20f41d-16c2-4881-9e79-01f4f141b28b"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2391), "192.168.1.29", (byte)1, 19.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("4aa508bb-4d29-4436-b3d0-4ee83c33e266"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2861), "192.168.1.32", (byte)2, 60.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("4b5bae8e-281b-4e02-b765-a85173bc9764"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2460), "192.168.1.36", (byte)1, 67.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("4b699cc9-c331-47ec-aff4-c36e35e7e8f4"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3502), "192.168.1.70", (byte)2, 47.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("4b809fe3-039e-4923-a01c-7d2091a79712"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3672), "192.168.1.13", (byte)3, 28.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("4bebc765-d849-4f2e-8109-823ce23dec55"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3003), "192.168.1.38", (byte)2, 67.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("4c2335bd-39c3-4eb7-b579-1eb73e59bb39"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3305), "192.168.1.19", (byte)2, 25.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("4c282337-8983-4312-ab54-24f9db3eaaa9"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2430), "192.168.1.20", (byte)1, 38.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("4c41f14f-e464-4041-acae-8d6ab65f4eec"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2516), "192.168.1.68", (byte)1, 16.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("4d8a0fcb-8dd3-4802-8e41-910a20ad9162"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3024), "192.168.1.91", (byte)2, 31.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("4e2e96e0-5591-4568-b982-08cc7a4e3b6d"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3615), "192.168.1.94", (byte)2, 50.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("4eaa3b40-8ded-43f5-9c72-dc3339998a12"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3063), "192.168.1.40", (byte)2, 2.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4ebed74b-5230-4867-b0a0-20d14dcc9acf"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4214), "192.168.1.94", (byte)3, 55.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("4f302ae4-ea76-4620-bc4e-61bc8c7b50bc"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3833), "192.168.1.89", (byte)3, 95.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("4f4c090b-ed0f-4eda-b637-dd8ae33750a7"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2981), "192.168.1.39", (byte)2, 44.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4f6c71fe-cc6b-420d-bc9c-1526520f733f"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3703), "192.168.1.20", (byte)3, 59.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("4ff4881c-f766-4b0f-90af-ad836e9681ee"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4354), "192.168.1.21", (byte)3, 45.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("5011260b-e888-4ec2-8f79-a106e0515f78"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1799), "192.168.1.60", (byte)1, 6.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("504a99a4-726f-4a22-9d1a-64a903bf0c95"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2216), "192.168.1.27", (byte)1, 99.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("5057c206-69a0-4610-83d8-e6e5dbbe7c9b"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1654), "192.168.1.15", (byte)1, 87.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("50d411ab-9e8d-4944-b674-21203f03bb4f"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2484), "192.168.1.21", (byte)1, 9.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("50f668c8-9bdc-4e74-8136-dab5500c15a2"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3395), "192.168.1.63", (byte)2, 91.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("514b3d7d-d1f5-4d91-a614-091451447dbc"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1965), "192.168.1.38", (byte)1, 18.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("51fa18b1-1d95-47ca-a34e-059d8012f315"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4174), "192.168.1.35", (byte)3, 45.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("527fb084-cd00-447b-93c7-c0512419b65e"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3137), "192.168.1.94", (byte)2, 54.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("52ef98f3-89cc-4da2-8db0-1cd5173f1ffd"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4383), "192.168.1.56", (byte)3, 39.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("533ab318-fe4c-4fdb-b586-546bc077aa25"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2639), "192.168.1.36", (byte)2, 75.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5380ec26-1102-4482-bc45-4313c2e6fcba"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1949), "192.168.1.69", (byte)1, 72.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("53b93e24-807f-41b2-bc12-2cd2d29d4bad"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4450), "192.168.1.84", (byte)3, 13.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("53ffa805-8e2f-4f9b-82b6-8f0724a4a507"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3420), "192.168.1.40", (byte)2, 62.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("5404d7a4-f08a-478f-8d49-e126073af3e9"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3428), "192.168.1.23", (byte)2, 45.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("5437a2c4-189b-4011-8379-b7321e9121c2"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4457), "192.168.1.6", (byte)3, 67.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("54389b27-3def-412b-ae3f-d111e1150bb2"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4114), "192.168.1.84", (byte)3, 64.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("546ac175-ff86-484f-9c06-19abf513b38d"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4665), "192.168.1.45", (byte)3, 37.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("5493b61f-cc9e-4cb5-877f-c9a32313d795"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1717), "192.168.1.56", (byte)1, 43.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("54dcf88a-3274-4438-a2d6-52af36b0e962"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3933), "192.168.1.60", (byte)3, 36.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("567cf9ef-45f0-4149-b8c1-75fa6b388238"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4254), "192.168.1.35", (byte)3, 41.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("5730f457-a3a7-4595-8a47-16935efda370"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3937), "192.168.1.35", (byte)3, 14.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("5740d3b5-789f-4c2a-be6c-49c70d9cf2e6"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4514), "192.168.1.88", (byte)3, 54.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("5768822e-4f8e-4ec2-ba90-1f9eaebb39d5"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3857), "192.168.1.5", (byte)3, 6.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("583f4022-2718-4745-80d8-90bd3d2832ac"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2243), "192.168.1.53", (byte)1, 85.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("58da4f22-944c-4def-8c6e-0c45007ed76f"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2776), "192.168.1.23", (byte)2, 88.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("58fe2e13-37f8-47b2-990e-5c07c108ddb9"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2556), "192.168.1.51", (byte)1, 9.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("5989103a-9d9a-4a8e-be17-05046bcdd394"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1589), "192.168.1.51", (byte)1, 78.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("59929bf8-e529-4620-a3ae-1219026db195"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3345), "192.168.1.80", (byte)2, 92.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("59c1dac9-f2e0-4ccc-b76f-40dce5e4d924"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1577), "192.168.1.84", (byte)1, 24.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("5a47c21c-38b3-4380-b6d7-d05593fd64cc"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2489), "192.168.1.38", (byte)1, 84.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("5a8484b5-c793-4cb2-b32a-6a1a317675fa"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3170), "192.168.1.26", (byte)2, 29.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5a88ca5e-7bbe-4b63-9d15-54e458e9b1be"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3922), "192.168.1.14", (byte)3, 86.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("5b4a0885-7f64-4aa9-984b-03ae9ef212ee"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1832), "192.168.1.78", (byte)1, 5.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("5c043532-08c5-4d82-bdae-1cfa791fa57e"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2667), "192.168.1.66", (byte)2, 92.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("5c374715-0c0e-461b-a478-05d0bbeea4b7"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1613), "192.168.1.73", (byte)1, 14.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("5c7bb51c-7cc7-4f50-8607-b65092a7f676"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2018), "192.168.1.94", (byte)1, 52.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("5ce3ddfb-f666-4882-93dd-3bb5875bd685"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2354), "192.168.1.66", (byte)1, 60.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("5cfbd9e4-9948-4028-afb7-97e24f1f2881"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3477), "192.168.1.69", (byte)2, 93.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("5cff13ee-fede-486f-aaad-df7db850236b"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2447), "192.168.1.96", (byte)1, 9.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("5d0c7fac-fa92-4993-a8a3-50e15a2440ee"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1771), "192.168.1.93", (byte)1, 37.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("5d4a9982-4315-4b82-b896-da67b2ea35a6"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3598), "192.168.1.2", (byte)2, 81.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("5d6744cd-3297-4e01-8c90-26598acdb1d5"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3582), "192.168.1.63", (byte)2, 78.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("5dc9fb42-01c9-405a-b868-a036b57fa859"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4297), "192.168.1.56", (byte)3, 8.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("5dfcc59c-1c94-4bd0-87ee-6dd7c38341c8"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3676), "192.168.1.40", (byte)3, 61.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5f07a57e-c8cc-47d2-98a4-e24cb9b5d2c8"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2602), "192.168.1.51", (byte)1, 92.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("5f2f57e1-4a3d-487e-997b-d537dc794e60"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4621), "192.168.1.77", (byte)3, 1.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("5f7e6a6e-8eac-40a5-ba6d-b92fe5d7095f"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3540), "192.168.1.78", (byte)2, 31.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("5faf29e9-5b36-49dd-b29c-81597373581b"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3805), "192.168.1.75", (byte)3, 30.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("5fd99ffa-f0bf-46ce-889f-881d5641874e"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4362), "192.168.1.77", (byte)3, 92.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("5fefe889-9ea9-4f38-be89-f5a93a99e82e"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2260), "192.168.1.29", (byte)1, 84.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("6015a505-0c46-4399-a0b6-611fcf2af4af"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2125), "192.168.1.58", (byte)1, 72.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("60312293-a0b6-43d6-a753-307c49a26cdb"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1761), "192.168.1.89", (byte)1, 25.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("61757e93-e10e-4e7d-82ca-c70b18721723"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2897), "192.168.1.21", (byte)2, 24.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("61c0929c-bb50-4e1f-9bcc-f0f6e0ff8426"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3752), "192.168.1.53", (byte)3, 47.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("61c9fb36-4354-44ab-98e2-21b3daa417f0"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2909), "192.168.1.43", (byte)2, 41.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("6368ad81-b480-40f8-a841-33fd4319cee2"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3912), "192.168.1.8", (byte)3, 11.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("6393a77e-f90f-4ab1-8b42-2ee514543c72"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1701), "192.168.1.3", (byte)1, 20.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("63e34543-f273-4fd5-928c-982cf099dedf"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1938), "192.168.1.69", (byte)1, 25.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("64552bf8-6baa-452f-b2b4-cecad9d9d6ef"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3047), "192.168.1.17", (byte)2, 3.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6482578d-6dc3-424d-b340-0668ea5d2710"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1819), "192.168.1.12", (byte)1, 17.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("648f9edf-f576-4380-a418-c1c129fa2ca3"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2991), "192.168.1.65", (byte)2, 99.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("6571a193-11dc-4eeb-99e2-07c79e9aed0c"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3905), "192.168.1.62", (byte)3, 46.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("65aca5b8-6d6e-49a0-b7c9-9635675cd03f"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3301), "192.168.1.30", (byte)2, 78.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("65c9e122-29ca-48a3-b01b-c2dd4bfd136f"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4218), "192.168.1.87", (byte)3, 6.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("66b93a2f-62fd-4bd5-903e-c87f56026d39"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3060), "192.168.1.64", (byte)2, 43.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("66f02e8e-e8da-43a5-a070-579dea239020"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4494), "192.168.1.97", (byte)3, 81.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("673e8c6b-8a5e-4dad-a776-cba0c8b06239"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1997), "192.168.1.80", (byte)1, 49.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("676acc2d-bc6a-458d-ad64-20364b996d0e"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2893), "192.168.1.57", (byte)2, 43.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("67d6f150-7a8f-49a4-a7ca-560d889f1c00"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3320), "192.168.1.68", (byte)2, 41.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("6816be72-a560-4626-8494-5eaf4c7f5038"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2195), "192.168.1.78", (byte)1, 18.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("685ddc3e-d431-48f1-b0d7-6aa458491110"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3604), "192.168.1.92", (byte)2, 94.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("68d0d154-cb8f-4da3-a302-8b41329adc23"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3092), "192.168.1.99", (byte)2, 38.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("6a131a0e-2d73-449a-922f-2834eb311a35"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3748), "192.168.1.47", (byte)3, 88.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("6a3ed3cd-cb6f-4381-8788-d0632208ff81"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2451), "192.168.1.96", (byte)1, 22.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("6b4e9905-914e-4df4-83a1-f6dc9662af0e"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2419), "192.168.1.14", (byte)1, 85.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("6c14042a-f320-44d3-b54c-2f321cc94d34"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3292), "192.168.1.18", (byte)2, 68.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("6cfca0e6-9497-41d9-b3e0-df6a0939f66e"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2366), "192.168.1.75", (byte)1, 0.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("6d2289b3-778b-4387-8c42-da96f6c5f50d"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2381), "192.168.1.71", (byte)1, 28.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("6d3c1dbe-73d1-45f0-a012-3613eb3f3654"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3578), "192.168.1.53", (byte)2, 8.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("6dd0d689-2b8d-433d-928d-16916d9a48bf"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3941), "192.168.1.69", (byte)3, 75.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("6df61eea-976a-4b99-97c3-1f9e7433a821"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2568), "192.168.1.36", (byte)1, 10.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("6e28215e-39b2-4a20-98c9-47237d75fe07"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2170), "192.168.1.41", (byte)1, 94.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("6e3a5f92-c6c3-4bf3-a7c2-e481b481e132"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2501), "192.168.1.88", (byte)1, 1.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("6e4a90d8-f842-40e3-a874-1c3fc6194485"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3880), "192.168.1.83", (byte)3, 8.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("6e679359-5ef2-4a39-8fdf-d87e7eef92a1"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2085), "192.168.1.26", (byte)1, 58.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6f2e9d89-0e47-4fe5-9cb1-db290dac8666"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4588), "192.168.1.68", (byte)3, 52.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("6f462972-3e16-43d3-9ec2-de261f6de335"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3623), "192.168.1.92", (byte)2, 39.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("70b63f01-f025-421a-86b3-97d5c6876957"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1680), "192.168.1.98", (byte)1, 81.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("70c11539-417d-4542-b5d0-ef80260bc636"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3954), "192.168.1.71", (byte)3, 6.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("70c70c75-baa3-494a-9643-3583dccb0896"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3876), "192.168.1.64", (byte)3, 58.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("70d72d5e-a6c0-4b6a-8b47-016959994273"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2930), "192.168.1.89", (byte)2, 45.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("70df4d29-0b0e-41a8-89c2-df7311f3344b"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4568), "192.168.1.51", (byte)3, 40.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("71c6bf75-47f9-4cd3-952e-e1472ebaf962"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4391), "192.168.1.6", (byte)3, 25.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("7232ee51-3fdc-4c0e-b9d0-e1b04fd919d8"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1688), "192.168.1.88", (byte)1, 15.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("7242890d-a8e6-43a0-86f5-a89b7136471f"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2828), "192.168.1.65", (byte)2, 49.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("72e41ff8-89b8-44e2-8794-48629bb0c49a"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3027), "192.168.1.3", (byte)2, 94.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("72e4dc73-678b-4069-8019-e51c9a87c11d"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3177), "192.168.1.28", (byte)2, 79.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("73011916-2f52-47d9-a258-ab9d0b818605"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4657), "192.168.1.82", (byte)3, 2.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("73850616-68b9-47bb-9dee-28c2fd5a7d90"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3273), "192.168.1.14", (byte)2, 87.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("739ccdbe-60f4-4480-a31a-d668043eea9c"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2679), "192.168.1.34", (byte)2, 56.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("73b31d19-c7f9-49ea-bbcb-6edcf7072ded"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2836), "192.168.1.98", (byte)2, 65.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("73bbea36-7a4f-4fe2-9de1-7117dbe8d589"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1605), "192.168.1.36", (byte)1, 51.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("73f5e6a5-d41c-4654-aa54-ae2cfbd63f28"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1635), "192.168.1.5", (byte)1, 83.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("74ca9de5-58eb-4381-853a-7f6b08ca3d65"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4442), "192.168.1.15", (byte)3, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("753d4a98-8695-4231-9e36-7bf363bbc606"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1705), "192.168.1.92", (byte)1, 61.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("756c366c-7f87-4901-a55c-32df03c36a05"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3209), "192.168.1.30", (byte)2, 35.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7585f90e-d0fb-4aec-a2c4-9bf4a518ce46"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2933), "192.168.1.66", (byte)2, 62.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("763864f0-bcde-44d0-82f1-6a45b19885c0"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1827), "192.168.1.25", (byte)1, 43.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("766c3375-2058-4238-b906-0727b7e5f011"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2868), "192.168.1.48", (byte)2, 24.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("77633148-93cf-4da3-8da5-d3346d98dc6f"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4507), "192.168.1.40", (byte)3, 40.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("77a11a30-1a7c-419c-96e4-7320e87e9c65"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1893), "192.168.1.54", (byte)1, 79.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("783145d6-51bc-41c0-8e5d-3ad8ae701c47"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2635), "192.168.1.8", (byte)2, 19.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("7910c57d-e649-4f6a-a54e-dc7f17b69ed5"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1970), "192.168.1.30", (byte)1, 36.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("794f2673-6284-400c-ac31-abb52093744b"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3120), "192.168.1.14", (byte)2, 39.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7997aebb-3178-4108-981b-4302812dbebd"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3720), "192.168.1.88", (byte)3, 45.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("79d16e96-3aef-45c4-8fd5-96c13cc5ce2c"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3885), "192.168.1.82", (byte)3, 69.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("7a134675-70d8-453b-89da-513bf9831c81"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3202), "192.168.1.76", (byte)2, 74.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7a7078b6-1fa1-40b8-b704-fa822a66260c"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1742), "192.168.1.51", (byte)1, 18.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("7ac847f9-2b0d-4ab7-bf80-28578ef655b1"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3014), "192.168.1.58", (byte)2, 97.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("7b317af3-192d-43aa-ba45-9b695406e74d"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2683), "192.168.1.25", (byte)2, 70.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("7b661fc0-ab83-48ae-8c81-f1daffee11c6"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1953), "192.168.1.11", (byte)1, 36.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("7c166a10-cdd4-4700-ac09-8cbaf394df74"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3510), "192.168.1.85", (byte)2, 23.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("7c3c988d-56d0-45ee-8a29-7c540c7a428c"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2374), "192.168.1.35", (byte)1, 77.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("7c9590a0-cd01-4db8-8944-fec9621184cb"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4629), "192.168.1.85", (byte)3, 19.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("7cf25cc7-b24b-4816-8d51-ec409ebcd15f"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1925), "192.168.1.32", (byte)1, 83.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("7d6677a4-5f58-48e7-94d7-31345b1cba8f"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4461), "192.168.1.42", (byte)3, 53.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("7e166a9e-824c-4956-ad8d-a3b3be6b4c44"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4118), "192.168.1.2", (byte)3, 57.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("7e206e17-f1e2-4f12-91cb-bfc74133f5c2"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4576), "192.168.1.25", (byte)3, 31.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("7e36c4c1-6f0e-4045-a35d-2fafcb62f1dd"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3514), "192.168.1.8", (byte)2, 11.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("7e7a79aa-4725-478f-9c9d-90aea9818017"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4653), "192.168.1.26", (byte)3, 61.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("7e8efaf6-c7a8-4145-9620-5b6e4f019407"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2199), "192.168.1.94", (byte)1, 78.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("7ea4f613-346e-4b75-9f23-9d7966563073"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3206), "192.168.1.76", (byte)2, 16.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("7ea67465-bb7e-4c8e-961f-0505a63a8db9"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3643), "192.168.1.56", (byte)2, 80.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("7ebc3413-a14b-4b18-a241-49ec61478a33"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1888), "192.168.1.89", (byte)1, 14.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("7ec59973-ae21-4e91-8468-d3f95005404b"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4411), "192.168.1.32", (byte)3, 28.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("7ed72de1-b991-4159-b237-1bcef0f74fe6"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3338), "192.168.1.52", (byte)2, 4.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("7f1c844f-4be9-44ac-9ed5-32c104b3d1d7"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4251), "192.168.1.29", (byte)3, 7.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("7fa32134-c4c1-4e5c-af4d-e8304194fb86"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3847), "192.168.1.77", (byte)3, 18.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("807ce8c9-6762-4520-9588-3731f9011ba7"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2053), "192.168.1.17", (byte)1, 50.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("808e8cfd-7851-4230-a1c2-e763c674bbb9"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2710), "192.168.1.83", (byte)2, 78.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("80f7cec4-2785-43c2-8695-ab1a0b51ddb5"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4081), "192.168.1.92", (byte)3, 84.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("8120ba21-4d40-4374-ba0c-680150314812"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3349), "192.168.1.4", (byte)2, 62.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8177dbb9-7210-4e75-8868-93d9e327332a"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2805), "192.168.1.78", (byte)2, 50.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("81f26090-1d71-404c-8c55-3c5002c85a55"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1746), "192.168.1.44", (byte)1, 5.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("822a2cbb-490f-4a36-aa6b-1fc6d9f6b049"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2743), "192.168.1.89", (byte)2, 17.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("823edeb0-7251-4003-af3e-aa09c7f38691"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4478), "192.168.1.39", (byte)3, 76.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("824b504b-ce8a-4067-839b-19cea6b743f3"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4530), "192.168.1.13", (byte)3, 18.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("82c3238a-6ef4-47a2-b9a5-a5e49eac5213"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3194), "192.168.1.38", (byte)2, 25.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8324cfbe-c28a-47a3-af9f-d1a38585d7d1"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3489), "192.168.1.6", (byte)2, 53.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("837acf5a-8702-4a5b-a61a-2fe3de03b685"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3309), "192.168.1.24", (byte)2, 18.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("83b2ef06-e732-4a40-990b-8bee15f9bbd6"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3619), "192.168.1.14", (byte)2, 70.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("850ad6ac-b909-4ae4-a4c3-2ae82cf7c78e"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2253), "192.168.1.80", (byte)1, 85.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("85ca8f16-0634-4e93-851a-83a824063cb2"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4279), "192.168.1.12", (byte)3, 72.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("86269b34-f1af-49fa-98d2-aa9c643b3bb2"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4166), "192.168.1.60", (byte)3, 45.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("863410f3-1c51-40c7-bf85-e9a7e2e0c747"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1738), "192.168.1.37", (byte)1, 96.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("863abcc8-00f9-4ad9-9cb4-ba757c94b915"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3926), "192.168.1.69", (byte)3, 62.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("864d0892-53f6-4e83-a3d4-9e367ba693a0"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2240), "192.168.1.5", (byte)1, 30.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("86727526-b628-4188-8ec2-5c97c25c9a36"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2521), "192.168.1.17", (byte)1, 12.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("871d2a88-44e0-4613-b74b-a26cc78b7e1b"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3521), "192.168.1.58", (byte)2, 45.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("882c12d5-8460-4e20-8ebd-8f03db964514"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4306), "192.168.1.78", (byte)3, 34.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("88daf1d6-41ec-43a7-a491-a19e3691d600"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3007), "192.168.1.92", (byte)2, 88.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("88e6b401-b702-4985-9f0b-50a1d00137ba"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4638), "192.168.1.36", (byte)3, 1.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("89953d42-4139-45df-8664-ae402799ecb4"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1643), "192.168.1.59", (byte)1, 61.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("8a830760-a8dc-428a-b9f0-6ddd634faa26"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4322), "192.168.1.38", (byte)3, 99.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("8ac477d2-69d0-47e3-9f38-6a12db358b75"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3868), "192.168.1.74", (byte)3, 5.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("8b3aad25-075c-4ba4-8e32-91513ad40e7b"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4423), "192.168.1.55", (byte)3, 14.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("8c516daf-4782-428a-9ae8-57f2d24c8dd9"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3626), "192.168.1.69", (byte)2, 21.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8c68fcdc-1e9e-4c3e-9095-3e3f6c64e09b"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4522), "192.168.1.74", (byte)3, 14.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("8cf84232-ccf3-4934-ac4d-ac5595299f92"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4042), "192.168.1.38", (byte)3, 15.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("8e6d7a3f-f9fc-4592-9f49-ecb7a6cc7679"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2096), "192.168.1.59", (byte)1, 68.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("8e8334f4-c91d-4c7b-8d6c-563ac3df14a4"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1844), "192.168.1.64", (byte)1, 52.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("8f963b33-fc06-4893-998a-570739f0508f"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2362), "192.168.1.71", (byte)1, 1.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("8fc0dbae-b52d-46a7-8b74-575a020164ce"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1978), "192.168.1.42", (byte)1, 80.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8fdeea20-2e00-4825-95b9-dea9358d6273"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4580), "192.168.1.17", (byte)3, 16.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8fe0e5d3-5ef6-429e-b633-1b26dae8c81c"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4302), "192.168.1.28", (byte)3, 50.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("8ffbf37d-1a1c-4d3e-91ba-83047ecbbca4"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3962), "192.168.1.18", (byte)3, 55.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("900079ff-39c0-4cbd-a13c-8d371f29a483"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2174), "192.168.1.24", (byte)1, 89.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("9019aa97-c7be-4051-a96d-df20e76cfcb7"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3945), "192.168.1.92", (byte)3, 29.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("90901dad-590e-4c4c-8e98-07e513a789b4"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3950), "192.168.1.50", (byte)3, 30.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("90c52a83-4552-4f2b-a03e-fea87281209c"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2049), "192.168.1.8", (byte)1, 59.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("911a1444-a733-4b03-af2e-0412caf01e8a"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1873), "192.168.1.94", (byte)1, 95.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("914b597a-585c-4559-a7fa-75de24521ea2"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2643), "192.168.1.91", (byte)2, 18.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("919d5f95-91a7-466d-951f-be427028dbc2"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2002), "192.168.1.67", (byte)1, 5.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("91b9d90e-6b07-4f49-805d-b5895e26302d"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1597), "192.168.1.15", (byte)1, 22.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("92365c54-c85c-41a3-9339-72e834187591"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3607), "192.168.1.27", (byte)2, 76.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("923944bd-2596-4284-bbc5-24d32ad2aa8c"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2937), "192.168.1.86", (byte)2, 88.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("932c2e9f-d8a8-4272-93c8-35585a267478"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3865), "192.168.1.31", (byte)3, 97.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("934b1e91-f529-4e0b-8ff0-ebd4760a16f8"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3893), "192.168.1.11", (byte)3, 87.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("9361cbe1-d976-4a4e-bf92-4c2baf350954"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2592), "192.168.1.31", (byte)1, 95.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("939a8c27-a0da-40dc-a422-ebd2db6192e0"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2281), "192.168.1.72", (byte)1, 36.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("93f1c95e-be9e-487d-985e-9e1a99e1eac9"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4649), "192.168.1.83", (byte)3, 78.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("940c2ea9-0eab-4354-b8fa-bdcb3573dde7"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3639), "192.168.1.64", (byte)2, 32.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("948386d5-467c-4eea-a89a-e37e25d084ca"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3987), "192.168.1.38", (byte)3, 70.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("94e9b1ca-a42c-4c80-9097-df6d507258b8"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2285), "192.168.1.63", (byte)1, 11.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("953f3c02-66f1-45b2-8bde-82963525dd90"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3744), "192.168.1.5", (byte)3, 87.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("95c979f7-d434-4c9b-85da-8fb35dcaa9ce"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2508), "192.168.1.12", (byte)1, 38.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("95e8307c-6f4d-43dd-b6a3-7240df985cb5"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4026), "192.168.1.7", (byte)3, 55.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("9621407b-ca04-46eb-8fd6-e51800bf85b7"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4350), "192.168.1.43", (byte)3, 88.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("96385b08-8ae5-4f2e-881c-546b30f96b8c"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3412), "192.168.1.45", (byte)2, 4.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("969e6aab-7641-4402-a4c6-a6b3b7c0e562"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4511), "192.168.1.91", (byte)3, 58.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("96a23189-d2ec-4b5c-9e4e-5ec2af575cc2"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4178), "192.168.1.77", (byte)3, 33.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("96d9869d-d78b-4e49-91f7-0be7945677d6"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2872), "192.168.1.19", (byte)2, 10.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("96f4d902-18af-4927-bbac-0e20637b2b93"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2613), "192.168.1.93", (byte)1, 75.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("97278e1f-e245-462f-b336-fd824d144345"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4157), "192.168.1.15", (byte)3, 7.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("9745aee7-b7ab-4fd1-83fe-38463e1ebf78"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1906), "192.168.1.90", (byte)1, 22.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("9748a597-534b-49df-a3d9-af3dc2ca251f"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4199), "192.168.1.75", (byte)3, 59.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("97b20e50-25d3-4ada-bd39-0374b3cfc53b"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2060), "192.168.1.57", (byte)1, 60.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("98eee27a-843d-44ab-83bb-b4afe07187eb"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1639), "192.168.1.13", (byte)1, 21.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("98f371f9-6be0-450f-8305-2ca1e75a5ace"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3611), "192.168.1.41", (byte)2, 95.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("98fd0c5b-b0c5-40cb-9156-2041206c26c6"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4335), "192.168.1.75", (byte)3, 72.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("9987ec64-8158-4538-83ed-1a4b7dd54e58"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3571), "192.168.1.44", (byte)2, 98.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("999c26a8-837d-4d2b-9158-184b7c8bdbab"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2824), "192.168.1.98", (byte)2, 29.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("99f1d145-4f5f-4f54-8811-b9505e85955c"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2609), "192.168.1.43", (byte)1, 16.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("9ade267e-74e7-4197-9975-a380342869c2"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2766), "192.168.1.90", (byte)2, 36.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("9aed57f3-4589-4fd3-970c-a3f56e2f86f7"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4110), "192.168.1.69", (byte)3, 51.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("9b2d1a16-4c40-4268-a6ac-7e736ea5ae6f"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4563), "192.168.1.60", (byte)3, 80.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9b2fba46-ea3a-4a8a-b0ea-24fc7669c953"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2162), "192.168.1.3", (byte)1, 98.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("9b8e4567-9859-493b-ac4b-7bbaa258c258"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2297), "192.168.1.31", (byte)1, 88.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("9b90052b-ba31-478a-860c-74d38d5667a1"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2136), "192.168.1.25", (byte)1, 70.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9b986520-7227-4dd5-be22-0be6d21d905e"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1946), "192.168.1.12", (byte)1, 79.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("9c15760f-2357-443e-9c12-dc1d8b2261ef"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4474), "192.168.1.21", (byte)3, 60.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("9c772ada-e0c8-47b1-aef0-486caf9a3bb2"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3958), "192.168.1.71", (byte)3, 59.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("9cc9bbd8-3e15-4076-bd98-62c9f0fc30ce"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3735), "192.168.1.74", (byte)3, 39.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("9d2d1543-f2a1-4726-a029-4d6dd232f792"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2985), "192.168.1.18", (byte)2, 90.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("9d3c4034-7ab7-4fbc-9796-4bd0c26ae6dd"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3836), "192.168.1.42", (byte)3, 29.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("9da17d6b-d284-43b5-8d52-36bab3e9f4b9"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3437), "192.168.1.1", (byte)2, 37.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("9dd63b28-5caa-4585-a880-ba7ee54cbbf8"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3663), "192.168.1.19", (byte)2, 80.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("9e5f8d34-18a3-436e-8e05-07f4d94174b0"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3277), "192.168.1.38", (byte)2, 8.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9f6d946c-e078-41ce-b97d-1165bdc4abf3"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4465), "192.168.1.16", (byte)3, 71.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("9fb38536-8483-4e04-877c-528eb22a46f6"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4518), "192.168.1.23", (byte)3, 99.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9fbfe142-f9ff-4dfb-a674-15ce8fb44a02"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3313), "192.168.1.26", (byte)2, 35.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9fcd615c-3abc-4c77-9972-f84fcd35dfc2"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3156), "192.168.1.10", (byte)2, 8.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("9fd0a1d0-b226-48b5-b8b3-b49c9c5fc313"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1600), "192.168.1.60", (byte)1, 91.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("9ff1b10e-b67d-4441-bc4b-b571b8045e66"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4433), "192.168.1.75", (byte)3, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("a01ddb07-e1eb-4cc4-a464-d6331bcba2c5"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2885), "192.168.1.14", (byte)2, 68.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a0b15748-2505-43a5-ab08-771d5cc2e7aa"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2045), "192.168.1.74", (byte)1, 16.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a0e96a92-a60a-4b16-869a-629d9151b36d"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4674), "192.168.1.20", (byte)3, 98.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("a12a2461-d365-4ba6-b853-9b1ac0bc0d1d"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2468), "192.168.1.72", (byte)1, 45.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("a12a32d5-3549-46ba-9ef5-d9ddca0f7177"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4005), "192.168.1.98", (byte)3, 69.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("a1b48cc8-6e3f-4943-80d3-d98135b8835c"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4062), "192.168.1.38", (byte)3, 14.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("a1f3eb06-6871-4be9-88ce-45fa505bf1fc"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3716), "192.168.1.85", (byte)3, 81.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a34e304b-d6fb-4e74-8d4a-5d6d2790c320"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2006), "192.168.1.36", (byte)1, 79.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a3800b3a-8d62-453d-bb45-8273bac0d8d6"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3655), "192.168.1.99", (byte)2, 35.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a49dd4e9-5adb-47e2-9550-1791c8238db4"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3185), "192.168.1.94", (byte)2, 18.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("a515f0c2-e2e4-431e-a636-09af22ccefed"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2525), "192.168.1.81", (byte)1, 61.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a56118b9-dfc9-4203-b563-f43aaca95fdc"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4347), "192.168.1.53", (byte)3, 3.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("a5995779-f16b-454f-8013-6ad0641e38f0"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1677), "192.168.1.95", (byte)1, 21.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("a5ac4c7d-0849-4857-8ba4-765234775754"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3362), "192.168.1.69", (byte)2, 83.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("a5b33100-128c-43f7-bb39-653d291f918c"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1993), "192.168.1.10", (byte)1, 75.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a5df050a-ed11-4d5e-ae6d-141b8628edb9"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4632), "192.168.1.76", (byte)3, 78.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("a6d7ba56-8106-4251-947b-d21545a5d224"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3553), "192.168.1.28", (byte)2, 62.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("a6dc74dc-5104-4eef-bddf-48d538fe313c"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4053), "192.168.1.58", (byte)3, 19.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("a7615727-d2f0-416e-a815-28430df4e2c6"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2104), "192.168.1.90", (byte)1, 32.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("a77f6c6a-0c10-469b-8c3a-4373933125fe"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3970), "192.168.1.14", (byte)3, 10.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("a81bdae8-311a-4719-b1ac-fcc555f56b08"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2322), "192.168.1.10", (byte)1, 19.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("a852f2d5-2a7d-4a02-8a5d-94681853d295"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2039), "192.168.1.25", (byte)1, 8.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("a881d7bc-963a-4022-9da0-b9821a8f6d4b"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4326), "192.168.1.78", (byte)3, 24.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a956aa05-e097-4bad-a76f-4e4f86a17fa0"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3636), "192.168.1.82", (byte)2, 0.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("a96a5d93-6308-4965-9b60-9a8573bd7ebe"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3535), "192.168.1.92", (byte)2, 77.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("aa723e1e-fcac-4cd4-8d28-28e31e25bb3b"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4438), "192.168.1.72", (byte)3, 66.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("aac809e2-f0df-4655-9c0b-62cd0880efd8"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3404), "192.168.1.79", (byte)2, 30.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("aace1dd3-f803-40b5-ae53-168f8ccbab4a"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3011), "192.168.1.87", (byte)2, 24.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("aafc168d-ed57-44be-b38f-b7c34e364e4e"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2464), "192.168.1.64", (byte)1, 70.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ac24c874-e5e0-42c1-953f-4219819644a2"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4058), "192.168.1.25", (byte)3, 41.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("acd4f354-7cdc-428f-acc8-50a20d125677"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1957), "192.168.1.59", (byte)1, 20.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("ad2bf64c-05f1-4c7b-a938-715150d8cfa1"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4404), "192.168.1.85", (byte)3, 18.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ad3c2039-586f-4925-a85f-55f70b29f640"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1619), "192.168.1.3", (byte)1, 92.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("ae4c20a4-6061-413f-8487-662026532158"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2853), "192.168.1.56", (byte)2, 63.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("aeb21413-463e-42b9-a870-b57fbdb73c94"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3456), "192.168.1.41", (byte)2, 75.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("af0b78d1-ddaf-494c-b603-7fda8fe88fd2"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2014), "192.168.1.95", (byte)1, 82.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("af405ac9-4ab6-4ca8-ae8d-89be1d33f2d9"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3708), "192.168.1.46", (byte)3, 30.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("af83d0f7-4d98-49a3-b9b2-290a5581ec09"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2113), "192.168.1.55", (byte)1, 14.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("afb70d21-4859-4ab6-bfb7-078fab49307e"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2621), "192.168.1.71", (byte)1, 19.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b00190cf-c56c-4290-83c6-1bdbae1a4e07"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2889), "192.168.1.18", (byte)2, 41.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b0bc939b-b832-455b-8473-a2e54b8bdbe4"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1786), "192.168.1.93", (byte)1, 91.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("b11cae9f-6fb5-43a4-bdc3-ba5f2fc6b08b"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3549), "192.168.1.46", (byte)2, 97.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("b1620cd3-249f-44fa-980c-35ce275535e7"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2301), "192.168.1.95", (byte)1, 87.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b1b9158f-dc8a-4dc9-bf61-2363994e1dd2"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3181), "192.168.1.84", (byte)2, 92.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("b2ee35ca-1f1a-49d8-a065-e75521e9769a"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3242), "192.168.1.26", (byte)2, 68.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("b322431e-49f2-4d8c-9a74-e86e53687bc6"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3189), "192.168.1.71", (byte)2, 58.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("b33de865-4922-48df-ba22-2f74e82329e8"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4685), "192.168.1.4", (byte)3, 29.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b35bcdf7-c605-4c9d-af7d-7d3a8f5a1931"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1921), "192.168.1.84", (byte)1, 76.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b3aa4674-4f26-4abe-b704-eb9b7c85b21d"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4098), "192.168.1.36", (byte)3, 43.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b4058141-f8cb-4085-ad54-0979db2a26cd"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4387), "192.168.1.61", (byte)3, 54.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("b42ae021-60df-4df5-860d-4c8f6f72bdb4"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4009), "192.168.1.99", (byte)3, 47.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("b46fca26-757b-4fd8-a9ab-f5bb84cf3072"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4497), "192.168.1.81", (byte)3, 14.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("b4e2ad32-4444-48d7-9813-1c099b4b5fdd"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1668), "192.168.1.21", (byte)1, 11.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b502e74a-84fe-4cc5-a5b2-5b2010033969"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2068), "192.168.1.18", (byte)1, 50.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b5509260-70d8-4636-aa64-a31531d85a79"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2121), "192.168.1.30", (byte)1, 75.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b5b41489-afca-436e-a56b-611e84008dd8"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4239), "192.168.1.73", (byte)3, 95.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b5dc2909-4fce-4f31-9ed1-abd66c19ddf4"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1672), "192.168.1.52", (byte)1, 66.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("b6049df0-bddc-476d-ab52-b516a70d7626"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3557), "192.168.1.71", (byte)2, 55.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("b6598c81-bc0f-40bb-8d52-5a6295a681ed"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3466), "192.168.1.43", (byte)2, 34.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("b8166d1a-7465-477b-984c-e44694ad9c44"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3647), "192.168.1.40", (byte)2, 18.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("b8dedd01-7af2-4e48-8eb7-09eff766174c"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2313), "192.168.1.61", (byte)1, 24.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("b8f68258-9706-4ab4-920c-d8eaba02ef5d"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4231), "192.168.1.4", (byte)3, 4.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("b923d9c5-3607-4096-b123-6c79ee6524a9"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3872), "192.168.1.1", (byte)3, 42.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("b9b12d61-0c1d-4e35-a909-07184aab395c"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2547), "192.168.1.28", (byte)1, 56.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b9f538b5-3945-4bc6-bd53-3e74ca20ca8b"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1794), "192.168.1.31", (byte)1, 6.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ba26baeb-82cf-4f52-8c0b-f40e4c7fe037"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2406), "192.168.1.98", (byte)1, 41.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ba2c9953-bd24-4747-9701-b754e9c95608"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3445), "192.168.1.8", (byte)2, 98.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ba670332-fc1c-411c-bac5-cf54a3a06866"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1684), "192.168.1.44", (byte)1, 55.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("bb91f56b-51fa-41cb-9849-08ec88f78e0b"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3590), "192.168.1.87", (byte)2, 50.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("bbb7e239-debb-45c0-a479-b4870dbebe0a"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2504), "192.168.1.79", (byte)1, 20.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("bbc73028-8762-4542-883f-fa881cbfdd25"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2857), "192.168.1.80", (byte)2, 54.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("bbe8387b-5f9a-462b-9936-6855c83aae21"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4559), "192.168.1.44", (byte)3, 66.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("bc63ba76-4d5d-498d-abf9-342f234a58b4"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4275), "192.168.1.97", (byte)3, 14.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("bd15fdd8-9420-48bb-8799-0b55c958580e"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2056), "192.168.1.51", (byte)1, 93.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("bd438b96-407b-4318-ba11-34168928393c"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1840), "192.168.1.9", (byte)1, 53.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("bd5fe32c-cd54-4a45-81cd-5f49d30346d0"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4267), "192.168.1.47", (byte)3, 43.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("bda26790-3221-41d3-a031-2ea600960a40"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4415), "192.168.1.23", (byte)3, 76.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("bdad87ba-e3f4-4330-a053-85a3fa924a64"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2387), "192.168.1.98", (byte)1, 23.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("bdaf81d0-5f29-474d-8f0c-4263a6b97fab"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2398), "192.168.1.11", (byte)1, 44.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("bdd81c8b-5cff-4759-b23e-cb4831ce4d48"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1713), "192.168.1.86", (byte)1, 98.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("bf35a858-907d-4c1c-93c7-02636e0e23d9"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2588), "192.168.1.18", (byte)1, 64.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("bf720365-c638-4bbd-b0ef-cdf310e43e71"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3561), "192.168.1.85", (byte)2, 97.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("bfe74407-deb6-4bab-836a-f65e7988580f"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2309), "192.168.1.40", (byte)1, 67.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("c01bad24-90b8-43ee-80ab-14797f83cf9f"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3288), "192.168.1.12", (byte)2, 6.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c0a3d37c-045a-46e0-b132-f8f21d548fae"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3473), "192.168.1.54", (byte)2, 8.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("c0c535d8-8f87-410c-a334-f4e227ee4370"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2493), "192.168.1.17", (byte)1, 34.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c0db8e20-6dd8-4545-9440-2703ef880b7b"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4600), "192.168.1.89", (byte)3, 8.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("c12163ff-5bba-44a0-bf2e-e18e8cb38562"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2714), "192.168.1.39", (byte)2, 63.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("c2718c64-ddb9-43b0-b0a1-6dc1fa4ffe56"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4161), "192.168.1.97", (byte)3, 10.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c340e976-092c-492b-befd-ac16d94fdfe8"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4034), "192.168.1.20", (byte)3, 74.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("c34b84f2-e6ba-4111-be08-208e49fe082a"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3909), "192.168.1.31", (byte)3, 94.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("c3e4a708-d7ea-4a80-9ffe-08b6523cb01e"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3100), "192.168.1.94", (byte)2, 2.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c47c31e4-c193-4b68-80af-1ed90c529c7e"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2497), "192.168.1.56", (byte)1, 79.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c4df4fa7-dd62-4afb-a287-737f869a6646"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2326), "192.168.1.69", (byte)1, 15.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c535f715-80b2-437c-8d2d-2a1e67fd8c4a"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3297), "192.168.1.16", (byte)2, 58.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c5aea7a6-dc56-4e15-9fde-e3ac415f0c62"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1900), "192.168.1.79", (byte)1, 72.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c5c9d005-430e-441b-af47-45be9c5d2012"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3485), "192.168.1.88", (byte)2, 6.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("c5d987dd-9a3e-4811-95cf-3fd0f239ab31"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2317), "192.168.1.93", (byte)1, 65.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c6c7476f-3821-42cc-b93b-bc1c10c8c124"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3378), "192.168.1.56", (byte)2, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c6f1f137-3735-4e7e-af25-281b85d42cd1"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2799), "192.168.1.26", (byte)2, 53.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("c72383dc-0d4d-489f-8ffe-19be8fdb595c"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3727), "192.168.1.67", (byte)3, 77.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c7ef9ec0-08e0-4864-9029-81e04d980549"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3353), "192.168.1.91", (byte)2, 62.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("c7f15b4d-6e85-4e97-a59d-f1158592b7a1"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4123), "192.168.1.34", (byte)3, 82.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("c8043953-48ad-4bf8-9650-7cfa00145477"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2876), "192.168.1.77", (byte)2, 62.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("c8dfff70-c072-4abe-9f20-8594ca285cbf"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2572), "192.168.1.55", (byte)1, 43.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c938678f-63af-4b87-b631-6f4a7477a3b5"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4049), "192.168.1.15", (byte)3, 4.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("c9672ef9-d615-45c6-9099-9409546260d9"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2154), "192.168.1.55", (byte)1, 93.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c970e119-2c86-4464-acc9-076c8fbebbb0"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2022), "192.168.1.50", (byte)1, 97.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("c98936af-0225-478b-86d4-e5be538947b5"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2133), "192.168.1.85", (byte)1, 31.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("c99e85ea-f72b-40e1-9e53-ab7f799031bb"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1779), "192.168.1.10", (byte)1, 39.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("c9fc4d3e-82e0-4f00-a9b9-895e1d16d0e2"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4689), "192.168.1.42", (byte)3, 58.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("ca3682cf-bc00-401f-8338-6bb0ff2a04a0"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3788), "192.168.1.98", (byte)3, 24.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("ca4fd9a2-35ec-4eba-98f2-467619816de5"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2158), "192.168.1.7", (byte)1, 63.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("caf7e11e-b489-4ebb-a50b-d6dab8ac29c1"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3124), "192.168.1.21", (byte)2, 0.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("cb36714a-a874-4712-9380-f7eb62a4ed8c"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3699), "192.168.1.35", (byte)3, 64.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("cb80dff4-4a06-4137-9975-a483cca119b6"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1660), "192.168.1.52", (byte)1, 60.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("cbdda22d-cd7b-4013-8d75-6e88da0932ee"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1721), "192.168.1.40", (byte)1, 43.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("cc4d5bcd-365c-43cb-b6b6-533dc39c7574"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3897), "192.168.1.44", (byte)3, 13.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("cc6f268b-b161-417a-9bee-7a3d68082e2e"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1985), "192.168.1.87", (byte)1, 83.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("cdf775ef-c7ef-418d-ad23-c3aa7f7f89b7"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3334), "192.168.1.1", (byte)2, 93.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("ce1e671f-d70a-41a2-9c64-7a2793463d37"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4038), "192.168.1.99", (byte)3, 20.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ce66a6c2-a965-4646-a474-cbf465079549"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3075), "192.168.1.70", (byte)2, 34.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("ceaf97d4-0561-4eb5-8df3-36990fa8116b"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2864), "192.168.1.72", (byte)2, 15.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("cefd6c73-9b7f-4fce-b7a7-972969da48c7"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3269), "192.168.1.40", (byte)2, 89.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("d03da7e1-cdbf-40bb-b571-ae10b0d19813"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2901), "192.168.1.58", (byte)2, 32.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("d0c8e58f-9f29-4c5f-9768-15ce43665212"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4206), "192.168.1.5", (byte)3, 72.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d10df3a3-fc94-49d3-91f0-57906f62e6ea"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4400), "192.168.1.40", (byte)3, 25.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("d14c129c-1a88-4e47-a989-935b0ad96910"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3680), "192.168.1.69", (byte)3, 77.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("d158b533-ab5d-47b6-8418-0f283538b0ba"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3821), "192.168.1.73", (byte)3, 72.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("d1bac6b5-3f0a-4573-99fe-53f6f0c48738"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2687), "192.168.1.4", (byte)2, 16.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("d1da0cce-6021-41a5-9866-a62318cae6e9"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3659), "192.168.1.27", (byte)2, 42.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d245c508-c592-40d3-96b1-97ff68353b37"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3668), "192.168.1.46", (byte)3, 92.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("d24dd601-bf98-49d3-b278-a01459802645"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4486), "192.168.1.53", (byte)3, 53.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("d25464ec-0405-4e58-a5f8-7b2a4f1e3dde"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2427), "192.168.1.99", (byte)1, 36.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("d2c4d358-d917-41ac-8b39-f7edb76f5991"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2791), "192.168.1.47", (byte)2, 97.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("d2cfd22b-51a5-47c7-94b9-80bf9f6dfdc5"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3594), "192.168.1.73", (byte)2, 58.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d33dafe8-6690-44a4-84de-1ae4bcc89da8"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2228), "192.168.1.22", (byte)1, 79.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d3883e3f-d060-4692-af83-1c2cbb369af5"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4446), "192.168.1.40", (byte)3, 73.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d40377b2-7e50-4d62-babd-578c01860197"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2476), "192.168.1.56", (byte)1, 27.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("d44cdf0b-a70f-4f47-85cd-a00503c41041"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2788), "192.168.1.14", (byte)2, 3.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("d537786a-1a2c-4358-b245-77bc763ea465"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3773), "192.168.1.89", (byte)3, 44.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d53ee1a9-77c0-4375-9f1a-3c99a59b4454"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4613), "192.168.1.33", (byte)3, 34.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d5e75409-72f0-4012-a176-46eeb3bec5ad"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3901), "192.168.1.19", (byte)3, 79.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("d6547b6e-6e32-4091-bf64-7806d23e7143"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2654), "192.168.1.74", (byte)2, 16.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("d6586568-4a00-4564-92bd-6fa7e40aebd1"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4020), "192.168.1.91", (byte)3, 0.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("d6d83144-5711-46d6-9f2e-4b180687b0d7"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3918), "192.168.1.97", (byte)3, 14.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("d6e4b97c-2f9d-4c66-9aef-63af4349c17d"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2617), "192.168.1.98", (byte)1, 10.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("d705ad76-cc7e-4dc2-a110-f6d7575e57f0"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4584), "192.168.1.51", (byte)3, 29.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("d732cc04-98e3-4e1e-83f7-e302a2ba72c3"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1815), "192.168.1.73", (byte)1, 95.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("d74001c0-e236-411c-907f-ab64eadadb22"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2671), "192.168.1.53", (byte)2, 31.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("d77173e4-c848-4929-8d77-2080ff0476f2"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2543), "192.168.1.11", (byte)1, 99.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("d7822926-edf1-4f7d-a630-37b607f67dc7"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2183), "192.168.1.67", (byte)1, 82.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("d78df715-ad5f-4476-ab86-8684adb8b43e"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3889), "192.168.1.82", (byte)3, 44.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("d7e4d1ac-bac1-439f-aceb-9b75807beb4e"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2232), "192.168.1.66", (byte)1, 37.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("d7ef033e-d3a4-4f5f-ae51-ac13bf1132b1"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3382), "192.168.1.40", (byte)2, 50.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("da1d2bd9-0640-45a1-a749-e89b17234875"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3129), "192.168.1.46", (byte)2, 55.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("da216fe0-80f7-4ea6-90a3-c9b5885e5e92"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2191), "192.168.1.47", (byte)1, 10.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("da3dd9ad-c49d-4ea7-abcd-8552220fc384"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3966), "192.168.1.60", (byte)3, 15.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("da782c77-313f-4897-a4b1-4733260b75c2"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3035), "192.168.1.27", (byte)2, 77.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("dbec9fdb-5727-4fd2-b437-61bd87d26c87"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2187), "192.168.1.54", (byte)1, 15.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("dcd55fee-6b70-4c98-988d-a828178ded6a"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3250), "192.168.1.56", (byte)2, 44.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("dcdd8817-99ef-4121-9aa5-ec73e142efc2"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2926), "192.168.1.98", (byte)2, 74.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("dd12c870-8608-4103-92e3-17afe32e0607"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3651), "192.168.1.99", (byte)2, 18.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("dd18721e-3e90-4daa-b6c7-917ca60b730e"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4289), "192.168.1.36", (byte)3, 18.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("de840116-899d-4137-b144-9cdae124986e"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3067), "192.168.1.23", (byte)2, 54.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("df9fa1ae-20d9-4ba0-96e0-00cdeb84734f"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3441), "192.168.1.22", (byte)2, 62.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("dfc7901d-76ba-4b8f-967d-b8e7d79eb982"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2345), "192.168.1.29", (byte)1, 92.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e0432add-c5c1-4b3d-9628-6e4c317fbee2"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2333), "192.168.1.56", (byte)1, 61.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("e0433c31-df6f-4c3e-bec9-7d4f5cf4e313"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3777), "192.168.1.30", (byte)3, 95.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("e053fd0c-fac4-468f-a0f6-d27d302683c6"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3685), "192.168.1.20", (byte)3, 86.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("e0a9a74d-a7fd-42f7-bb9b-0b260efa7fb0"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4145), "192.168.1.74", (byte)3, 50.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e11f8c31-ea88-4548-bf0a-7984a643b27f"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1989), "192.168.1.14", (byte)1, 65.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("e226ba09-34e9-4ead-a818-534728f4d704"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3198), "192.168.1.56", (byte)2, 42.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e2557edd-155c-4660-9176-9b6c99eac2e7"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3145), "192.168.1.31", (byte)2, 53.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("e345b743-17af-44bd-b660-adf98cd0a5f8"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2849), "192.168.1.10", (byte)2, 39.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e3985fd7-fd0d-4bf9-bcb1-fd9cd1346c15"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3531), "192.168.1.93", (byte)2, 57.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e3af7005-763c-4311-a7c5-c7cc9d11d434"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3162), "192.168.1.80", (byte)2, 31.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("e3e68162-61d9-45ab-9b50-43accdbd135c"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4193), "192.168.1.48", (byte)3, 64.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("e4dc9998-c3e3-4c31-b164-fa6fc70bb961"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3731), "192.168.1.77", (byte)3, 88.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e5504b46-665e-49d3-92e7-fb70bdca635d"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4592), "192.168.1.77", (byte)3, 1.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("e5550249-0127-49ec-85b9-7e584948af5d"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4189), "192.168.1.72", (byte)3, 83.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("e5a1c197-5094-4859-a0b2-ca92ed7e1578"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3018), "192.168.1.4", (byte)2, 92.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e5e1b5a6-c001-4b59-b5b5-b8994c78e705"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3498), "192.168.1.99", (byte)2, 85.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("e7362497-6681-475f-8ff7-5aa902c4f350"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1694), "192.168.1.10", (byte)1, 27.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("e7496b17-d235-4808-b150-e8b92dbb27a3"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2551), "192.168.1.37", (byte)1, 67.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("e766756e-9c3b-4798-b655-be4e8e9a0c8c"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3408), "192.168.1.32", (byte)2, 68.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("e77dbc3a-a72a-4b11-a278-abb88da08f15"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3424), "192.168.1.32", (byte)2, 12.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("e7d3b4cb-f0e8-49af-9c66-a96f37baeb6c"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2529), "192.168.1.54", (byte)1, 45.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("e848e544-3503-4e22-92d2-d8f4fceb5cec"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4645), "192.168.1.22", (byte)3, 11.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("e8a7acdc-f3a6-429b-87d7-b35cfa114af9"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2631), "192.168.1.3", (byte)2, 41.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("e8d6d63a-f2ea-498c-9b38-59de8a11f7c2"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4609), "192.168.1.77", (byte)3, 27.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("e970a730-c0e7-40b5-81c8-dd476ea10be7"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4149), "192.168.1.20", (byte)3, 11.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("ea1271b1-d7f6-42b6-b75a-2238cfb3e875"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4243), "192.168.1.55", (byte)3, 98.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("ea4b7836-91db-4c63-b02c-584415e906af"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1807), "192.168.1.24", (byte)1, 12.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("ea5a9bcc-f6fc-45ee-8001-b130778ca8d0"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2110), "192.168.1.98", (byte)1, 62.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("eab85ea9-7db0-4fab-99eb-6c339812d992"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2955), "192.168.1.65", (byte)2, 35.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("eaed1ab1-6699-401a-9dbc-7a28dd0051a7"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2922), "192.168.1.87", (byte)2, 55.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ebe6d360-c1ac-4249-a98c-0d2046c4dce8"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3829), "192.168.1.62", (byte)3, 96.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("ec093221-1e7c-4e6b-a148-0d0da1f8233f"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1782), "192.168.1.5", (byte)1, 39.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("ec1a468a-e7d2-4254-aba6-0366c1a32d88"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4153), "192.168.1.71", (byte)3, 27.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ecbc7778-82ae-47c1-beeb-4b87b1854a82"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3975), "192.168.1.50", (byte)3, 8.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("ed02a6da-47bf-4b93-9740-6a7650b3ae82"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2349), "192.168.1.78", (byte)1, 46.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("ed29f44d-c006-425c-b720-a4ecf731b338"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3031), "192.168.1.75", (byte)2, 89.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("edc6ac08-f22e-4d2e-9335-76e23bf380bc"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3449), "192.168.1.14", (byte)2, 64.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("ee9e82c1-704c-4bf7-9f1a-20c8478338a9"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4070), "192.168.1.36", (byte)3, 28.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("eec01cc0-8d7b-4d86-a154-24e2863d67e6"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3978), "192.168.1.55", (byte)3, 32.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("ef3f6b78-edbf-49bd-86c5-54b5ce70fdf5"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4503), "192.168.1.23", (byte)3, 96.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ef681f1d-add4-441f-8385-f3b79e2f6151"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3493), "192.168.1.54", (byte)2, 84.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("ef8bbdb0-0a72-4fd7-8b7d-debded868146"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3039), "192.168.1.15", (byte)2, 13.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("efa495e8-4453-42a5-8cf6-e692d5bab21f"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4547), "192.168.1.29", (byte)3, 40.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("eff922d0-2847-40c0-b8e5-9d06a74bcd2c"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4697), "192.168.1.14", (byte)3, 50.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("f0677f2f-3353-4cd3-ad1c-ed90c326d65b"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2264), "192.168.1.20", (byte)1, 82.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("f07a3e58-1ace-4bed-858b-da26f06b3628"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2560), "192.168.1.22", (byte)1, 88.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f0a396c9-d3a6-425b-b8a8-a77114836887"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1775), "192.168.1.52", (byte)1, 82.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("f0a809c9-31ee-4517-abd3-de705f700d11"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1665), "192.168.1.42", (byte)1, 28.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("f0f45303-433d-49cf-9c58-5a1dac6452a2"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1697), "192.168.1.73", (byte)1, 29.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f22ba482-93e1-47ad-9a58-27dddeed7bfa"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2755), "192.168.1.45", (byte)2, 45.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("f2c6f533-68f6-4909-9e5b-d6fe9289435a"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1767), "192.168.1.63", (byte)1, 59.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f44b0a9f-504a-4fc4-a5f3-bb1e726450c6"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4670), "192.168.1.75", (byte)3, 50.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f5ca9146-39cd-461f-9815-6233f4383c71"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3133), "192.168.1.45", (byte)2, 46.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("f623a134-17df-4eb3-8baf-1a4053d403e9"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3574), "192.168.1.56", (byte)2, 96.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("f67a4e72-c5f5-4e3f-9c88-4d88ddaff44a"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1942), "192.168.1.26", (byte)1, 53.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("f6f607af-0c6b-4aa7-bf2e-839a5ab9f892"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2747), "192.168.1.67", (byte)2, 74.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("f7302380-7641-4b22-a48c-fe29397789c7"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3525), "192.168.1.43", (byte)2, 56.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("f772580b-aa13-48b1-a6cd-4d5f26079d02"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4454), "192.168.1.63", (byte)3, 56.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f773eceb-0f96-493f-a2b9-38124cd3bd00"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(4543), "192.168.1.73", (byte)3, 81.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("f78ca78b-cf5a-487e-a5b8-a0012dc18174"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1803), "192.168.1.62", (byte)1, 2.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f79dd4d1-02c1-4b8b-b9f2-4bb53253cd1d"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3324), "192.168.1.9", (byte)2, 51.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("f7a16b88-58de-48fd-a835-06f83ed18af2"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3230), "192.168.1.25", (byte)2, 62.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("f8fe4dd3-616d-4965-ba75-acf431664c18"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1910), "192.168.1.42", (byte)1, 35.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("f904f5f2-22cd-4399-a488-ba141cabab2b"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2772), "192.168.1.74", (byte)2, 54.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f930d6da-50fc-4d0a-a048-1a8bcaebf760"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2089), "192.168.1.63", (byte)1, 86.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("f9a6dc08-4a23-4fee-940b-b856bb6ee2e8"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3764), "192.168.1.16", (byte)3, 93.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("f9a802c5-9173-4867-857a-784b251a593b"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3792), "192.168.1.37", (byte)3, 73.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f9a8c310-83b0-4342-86b0-09ff06f5da23"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3213), "192.168.1.88", (byte)2, 28.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("fa6e65d8-2e4a-4412-b54a-7dd535a32867"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1651), "192.168.1.62", (byte)1, 79.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("fb44c236-80e3-4df9-89ea-938fd0e990e3"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2272), "192.168.1.83", (byte)1, 36.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("fc2b2e73-c650-40c3-b04f-9989caf0f7a9"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2439), "192.168.1.10", (byte)1, 80.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("fd0128b8-4242-454c-a70d-968f7b9337cc"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2881), "192.168.1.16", (byte)2, 12.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("fd5783a7-ea5d-4992-a0b4-2ab799e7fa65"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3630), "192.168.1.11", (byte)2, 27.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("fd81ca34-a97b-473d-81d2-a8813d8236f5"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2974), "192.168.1.52", (byte)2, 75.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("fd82240e-d28d-4b3c-a1b0-878a4b0afc4a"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(1982), "192.168.1.73", (byte)1, 3.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("fdb60f3d-cdc5-4078-a7b2-3856f8ab640c"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2663), "192.168.1.90", (byte)2, 51.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("fdbc91e2-7b8c-40c7-88fe-70414acb5a6a"), "Computer0", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2236), "192.168.1.20", (byte)1, 22.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("fe3569ca-0b2c-4386-947d-a0c83927120d"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3079), "192.168.1.17", (byte)2, 72.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("fe55e2c8-5b84-4cc6-ad25-6ea6286db4a2"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3152), "192.168.1.38", (byte)2, 87.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("fed2b96f-3231-4dae-abb3-f37ccc8a9cc7"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2950), "192.168.1.25", (byte)2, 91.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("ff22e76a-9379-4bd3-8d2c-f1af1b98392c"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(2739), "192.168.1.12", (byte)2, 35.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("ffdddeb4-4a04-4b50-b170-8ea8142e35bb"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(3341), "192.168.1.23", (byte)2, 73.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(5765));

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Address", "City", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "District", "FirstName", "LastName", "MobilePhone", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress", "WorkPhone" },
                values: new object[,]
                {
                    { new Guid("0a7a6910-f16e-43dd-9633-d56a985fbee3"), "Deneme Mahallesi, Deneme Sokak No: 2", "Deneme Şehir", "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(6721), "192.168.1.2", "Deneme İlçe", "Ayşe", "Kaya", "5559876543", null, null, null, "5553456789" },
                    { new Guid("32ce459b-99a9-4010-9360-d900347dd46d"), "Test Mahallesi, Test Sokak No: 6", "Test Şehir", "Computer6", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(6731), "192.168.1.6", "Test İlçe", "Zeynep", "Erdoğan", "5556543210", null, null, null, "5555678901" },
                    { new Guid("4906a70b-e15e-47b0-9e21-5815337c7a1e"), "Deneme Mahallesi, Deneme Sokak No: 5", "Deneme Şehir", "Computer5", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(6727), "192.168.1.5", "Deneme İlçe", "Mustafa", "Aydın", "5553456789", null, null, null, null },
                    { new Guid("4aa38609-3c30-4feb-8944-01f9a31e1d89"), "Örnek Mahallesi, Örnek Sokak No: 1", "Örnek Şehir", "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(6715), "192.168.1.1", "Örnek İlçe", "Ali", "Yılmaz", "5551234567", null, null, null, "5557654321" },
                    { new Guid("50964b1c-c9b6-4ee4-ac52-4e91a32f2d9c"), "Test Mahallesi, Test Sokak No: 3", "Test Şehir", "Computer3", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(6723), "192.168.1.3", "Test İlçe", "Mehmet", "Demir", "5552345678", null, null, null, null },
                    { new Guid("5e5a62f1-1de6-4eb2-9092-bd7f88920228"), "Test Mahallesi, Test Sokak No: 9", "Test Şehir", "Computer9", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(6739), "192.168.1.9", "Test İlçe", "Fatma", "Can", "5553210987", null, null, null, null },
                    { new Guid("627e6039-faef-4b9f-b188-8ebe4dff6079"), "Deneme Mahallesi, Deneme Sokak No: 8", "Deneme Şehir", "Computer8", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(6735), "192.168.1.8", "Deneme İlçe", "Ahmet", "Sarı", "5554321098", null, null, null, "5556789012" },
                    { new Guid("9bbbd7f5-1228-4e8b-8446-956422d179c2"), "Örnek Mahallesi, Örnek Sokak No: 7", "Örnek Şehir", "Computer7", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(6733), "192.168.1.7", "Örnek İlçe", "Emine", "Kurt", "5555432109", null, null, null, null },
                    { new Guid("bb8f43e1-072b-46e3-8ba7-eadc0ec795de"), "Örnek Mahallesi, Örnek Sokak No: 10", "Örnek Şehir", "Computer10", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(6742), "192.168.1.10", "Örnek İlçe", "Mehmet", "Kara", "5552109876", null, null, null, "5557890123" },
                    { new Guid("f6633d33-35b3-4cea-afe9-974150ece111"), "Örnek Mahallesi, Örnek Sokak No: 4", "Örnek Şehir", "Computer4", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(6725), "192.168.1.4", "Örnek İlçe", "Fatma", "Şahin", "5558765432", null, null, null, "5554567890" }
                });

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("15b6a548-4045-4892-904a-aeeba517960d"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("bd914d22-1482-497d-a552-6926b915f669"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("c0340c3c-9153-4951-969d-1b0136758af7"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("fb221081-45cd-42be-abd4-45976e996233"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Department", "FirstName", "LastName", "MainCourseId", "Role", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("343926da-0b8e-4533-8722-920a8a941e3a"), "Computer1", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9851), "192.168.1.1", "Matematik", "Ahmet", "Yılmaz", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null },
                    { new Guid("4a1c25ae-b923-4835-928d-ec8416c1e757"), "Computer4", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9860), "192.168.1.4", "Biyoloji", "Fatma", "Şahin", new Guid("33333333-3333-3333-3333-333333333333"), "Öğretmen", null, null, null },
                    { new Guid("4b5ad2d8-d8d4-4051-99b0-ed1faca96863"), "Computer2", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9855), "192.168.1.2", "Matematik", "Ayşe", "Demir", new Guid("11111111-1111-1111-1111-111111111111"), "Öğretmen", null, null, null },
                    { new Guid("633e1a42-df90-4e5a-a506-b8048118d742"), "Computer13", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9880), "192.168.1.13", "Müzik", "Seda", "Demir", new Guid("99999999-9999-9999-9999-999999999999"), "Öğretmen", null, null, null },
                    { new Guid("7714f7f7-a416-486b-a53c-72709f8a4eaa"), "Computer6", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9865), "192.168.1.6", "Kimya", "Zeynep", "Yıldız", new Guid("55555555-5555-5555-5555-555555555555"), "Öğretmen", null, null, null },
                    { new Guid("79a85ab2-ce3c-4254-8f29-0d4bbf374fc9"), "Computer5", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9862), "192.168.1.5", "Fizik", "Ali", "Demirci", new Guid("44444444-4444-4444-4444-444444444444"), "Öğretmen", null, null, null },
                    { new Guid("8391de52-cdf1-4b03-ab3f-ce7a734b1d0c"), "Computer12", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9877), "192.168.1.12", "İngilizce", "Ahmet", "Çelik", new Guid("88888888-8888-8888-8888-888888888888"), "Öğretmen", null, null, null },
                    { new Guid("9c9865de-7308-4084-a7c4-b8895859d773"), "Computer3", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9857), "192.168.1.3", "Türkçe", "Mehmet", "Kaya", new Guid("22222222-2222-2222-2222-222222222222"), "Öğretmen", null, null, null },
                    { new Guid("a7bb9000-3c94-41ca-8459-a2f1ccbb4bd7"), "Computer10", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9872), "192.168.1.10", "Tarih", "Mehmet", "Kaya", new Guid("66666666-6666-6666-6666-666666666666"), "Öğretmen", null, null, null },
                    { new Guid("c0bdaf00-0d02-4e06-8ec2-fdd46a4cdb9a"), "Computer14", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9882), "192.168.1.14", "Görsel Sanatlar", "Burak", "Korkmaz", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Öğretmen", null, null, null },
                    { new Guid("c723d712-bb24-41c2-ba2d-7b11501e4ed6"), "Computer11", new DateTime(2024, 2, 9, 11, 23, 5, 152, DateTimeKind.Utc).AddTicks(9874), "192.168.1.11", "Coğrafya", "Ayşe", "Yılmaz", new Guid("77777777-7777-7777-7777-777777777777"), "Öğretmen", null, null, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomMainCourse_Classrooms_ClassroomId",
                table: "ClassroomMainCourse",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomMainCourse_MainCourses_MainCourseId",
                table: "ClassroomMainCourse",
                column: "MainCourseId",
                principalTable: "MainCourses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomTeacher_Classrooms_ClassroomId",
                table: "ClassroomTeacher",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassroomTeacher_Teachers_TeacherId",
                table: "ClassroomTeacher",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParentStudent_Parents_ParentId",
                table: "ParentStudent",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParentStudent_Students_StudentId",
                table: "ParentStudent",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeacher_Students_StudentId",
                table: "StudentTeacher",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeacher_Teachers_TeacherId",
                table: "StudentTeacher",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
