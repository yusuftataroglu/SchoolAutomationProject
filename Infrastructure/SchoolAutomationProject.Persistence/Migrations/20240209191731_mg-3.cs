using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolAutomationProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mg3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentTeachers");

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("13814383-896a-4092-953b-cc392e74b99f"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("13df78fb-b646-4961-b70c-a3d7ba23ff1f"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("1620ca06-4eaa-48ea-a9b1-a72db426d0db"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("1dab6c87-2696-4311-82e2-574df77fe1f0"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("22fdd99c-6a4e-4a21-a511-895284a609c4"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("2702afa0-c0c4-4586-88ae-753846a319ae"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("2f011854-00dd-4aa8-a21a-18cc0534dfb4"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("2fe4e089-120f-4483-908c-6cf0ae61f981"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("3a9dbdc5-3bf7-4c5f-80a2-8f17cceb209c"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("3d006d10-07f8-4c5a-ac9b-017b032bec0a"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("3de849b7-3238-4241-9834-9ce534463cdf"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("3ffe8d94-715e-4b1a-8037-b270bbdafdfc"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("40471b1b-b495-4eb1-8577-136506f7359c"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("42c801ed-67ea-44a8-ba60-1d26b5d63954"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("43e35c4d-8f07-4c92-8414-a410426226ef"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("47efa78e-b70a-4c45-9b13-dc4da78397aa"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("4832f719-7038-4e14-b0ff-14aff40cbb30"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("4ff46f1f-1de3-4cd1-839a-8439d22cc269"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("584fad35-c897-44a1-b513-0fd99aac5fb0"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5bdbea96-3bac-44fc-a4bb-740998d624d7"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("674991e9-9148-4e96-a1bb-b572eae2fd1e"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("695249c6-cb8e-4413-a00f-58f396f1ef41"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6cf4dcb8-7a49-420f-b1f9-00b392079c59"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6ec3bcae-3357-4ce4-b4de-97d08192d58f"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6f405c20-52e4-4f0e-b1b3-f185bfbd4245"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("71cf8392-5587-4b89-bb56-66712749ab2d"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("72149a6b-f5e0-457c-a3e4-dd995d8f7c75"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("74513fe9-673f-493a-b667-50b827d89b90"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("77415ba6-8d6e-42a3-be5a-614ac152300d"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("7f20bcff-ac5d-4d30-92b4-86256bc72305"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("813c70e7-fb14-481d-9445-045773441f70"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("82058ba5-b87f-48e3-a2d5-f5b6f5b49679"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("93a6501e-a30f-43b9-a61e-70d4fa2a2b27"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9722ee05-1867-4b5a-9c78-cee2b81f6a59"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9b1db56e-9365-4007-92a4-6574a6eb28ab"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9b98c894-2f4d-457c-829c-7e10ee0b71a5"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b017d95f-e2f3-47bf-9273-bd539e0b5b79"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b1cfa455-bf40-4e1a-82e8-221c4d2312eb"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b23e6099-0ed4-4b9d-86ba-952a48c3e2ad"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b6690389-b174-4f90-80d3-76e4aeb0c1c7"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("bd79f10b-ddc9-431b-88a2-58121cead337"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("c89b574f-dcd4-4988-b724-15456b7dde1a"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("ca4d89fb-0e83-4090-b525-138d29a05ce7"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d16c6b16-9b32-48f5-87c8-0f99347cba28"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d3798645-8c33-4eca-a96a-7da3dd54ce47"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d7852cff-4e05-4a9e-aa8d-240c43386733"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d9a638b3-2d1b-45e8-9d10-c1c078433408"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("da0832eb-6175-4b61-9f62-5b96b83d6c19"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("da931601-0acb-412b-8ae8-7d20d69a8dc3"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("dbf35703-39fd-443c-abc5-ba4b5de86da9"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("e058e845-1bc2-48f4-87a5-955978b1cc8f"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("e265b59a-47e6-4ff3-9e5d-160c0ccb2b18"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("e3bc3b4d-5770-49b2-b338-2ab37e1aaceb"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("e3d62a52-c6d3-4ec2-8ff8-cd781d26f38a"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("e7d43844-0a45-47d4-a91d-7fd384c35631"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("eb22b25b-fa5c-41ca-b202-d73872131447"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f2d19713-4864-4d7a-9363-c2d73abb8f60"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f4de8dcb-9aa9-4513-a7f8-ff6e290cea1e"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f9759118-1a60-4069-82d3-e9e0c13a4fcd"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("fb7aed6b-a6cf-4f5c-8469-8b26704d0d74"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("00209d2d-0aba-43f1-84c5-ae3746d90b71"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("05f5c056-f728-4eb8-bc08-d0083e0b20f8"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("06bff186-8553-4016-ac88-1d63ae207c00"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("0a057adf-c5e8-43eb-b05e-d2d5406ca693"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("115020b1-f87f-42a1-abfa-85b9047dde67"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("1735c9c1-fda5-4212-a8b7-4512a8540c84"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("188febe2-eccd-444e-a99b-aef89c333767"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("1b6298f9-c827-495d-a5c2-e51d63a86dfa"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("269583fb-ec1e-417b-9016-c8343b41fef3"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("2b8cf035-2d00-4ba2-ba15-86784be9d5a8"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("2cfa5f6e-cf37-421a-80f2-8d56b75df90c"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("2fa3b3d5-0478-4698-9f51-c79734132698"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("309511a4-b058-477c-9e9a-3fd02f4ca58a"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("31df290a-887f-4a35-ae43-e3d4821896a4"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("3295c052-19f6-418b-b313-3de4a60e5a12"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("37349423-e8c7-4052-985d-5420c78a925b"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("3afcf884-f8a4-4057-a7cb-23e431df4d69"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("3e9bea53-fefc-405c-a360-970b58317c71"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("45d33f57-03c5-442c-9f5a-f56b876ef0cb"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("460d4267-e392-4200-a7ea-69c8f92097d6"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("4a94683a-e411-457f-b6b4-bc8ab6cf7629"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("4db072c0-2ec1-4599-abd4-7af640600006"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("551b886e-4f2f-4de1-800c-81c3725ff24f"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("5761ae14-36f2-4ec5-bdbf-2a48101653b0"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("5938993d-4703-45f3-9107-96c76465f1b3"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("73a26842-9ecc-4721-b63f-d02cf582c81a"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("7531e312-eb9d-4fca-85ba-5d0c07352df6"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("75c4a2f1-23ba-45b7-b3e5-efd3311fda59"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("80992068-7437-438e-b67f-febf4a858d55"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("84850e90-6160-4177-a147-12f2edfecf4f"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("984f9b95-f000-4345-ba72-fe22109de680"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("9aba04af-f1c3-44b0-8219-24bd40e00a38"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("9f60725f-3728-4b9b-ad79-8323828d6305"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("a101c8d9-5f64-4d3b-a326-8639a9cd7498"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("a3f5821f-588b-4957-b06a-03c4bb0bd1d0"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("a5ef5b4f-7ecd-4313-923b-0a06c9d78b3a"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("a91887c2-7ac1-4e23-8a2e-ec44859dc01a"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("c4c564a5-5a6f-4bbf-9fd2-5d2d78a52acb"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("c7938211-1f7d-4718-80a3-3dd0be100287"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("cd6028f1-7db0-49f5-bcdd-21a5811ff061"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("cd6517f0-6a79-49c6-8e6f-7bf73bd0d2fa"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("d8d3d76c-25b2-4124-bc82-a0e2acebdab8"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("db041518-6a66-4e0c-ba97-4fde6edbd581"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("dd86bf22-947d-48ff-a73f-8e60b73a79ca"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("de68a7a5-3803-496a-8ddf-b3a6dd3abd68"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("e4d84602-96cc-4886-8115-2dc0644164d1"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("e60f223b-8956-4bbb-829b-276e9cc061f1"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("e6c5985b-5b5e-48d5-8501-52ec606293e0"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("f1db920d-5b41-4766-8c0f-d7d8624c9a59"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("f33c9bac-98fe-43ef-b9d2-c733bdb47ada"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("f33fa7be-1f48-4058-9d3f-2f1703a8b414"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("f3537be7-447a-454f-8472-63b5ff2514e1"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("f436e14b-ce8c-454b-a694-3da113a54aca"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("f6a29744-d9ee-4553-b87c-233c3e496c42"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("f9dd41c1-3d4b-4aaf-a628-ad87cbdae320"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("fb68d6dc-004e-48e2-bc97-d799b84c9da6"));

            migrationBuilder.DeleteData(
                table: "DiscontinuedStudents",
                keyColumn: "Id",
                keyValue: new Guid("98911bd9-852a-41db-9f46-d0bdb6395c9d"));

            migrationBuilder.DeleteData(
                table: "DiscontinuedStudents",
                keyColumn: "Id",
                keyValue: new Guid("e862b094-5cfe-400f-87b8-66c3f9d697ad"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("00180a39-67c2-4eb1-84f4-3fc539881437"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("001a0066-e0f3-4ba6-a99d-d154036e93dc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("002371e6-7ee3-4445-9ea8-963db0ef1f09"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("00540c20-1ccd-46be-ae20-7d522950837e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("00de51c8-dabd-44f2-a0c0-a6d7091849ec"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("00def782-cc3e-4f7d-b90b-e9654ecdbe70"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0116b187-cd60-4540-b601-e3e0e8c857ba"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("02402ccd-84d6-4881-865b-9575f14f5118"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("024d87b3-c7a1-41a9-b75c-7322044b1ddf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0307b2cd-6ed4-4ae5-bfb4-6dbef9a18c57"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0331f976-a736-40fa-b646-8754c2d1c521"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("038cbfc1-b32c-4a44-89e9-cc81a5e0bfc2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("03e7ad16-f470-4487-9607-2fd5c097ed62"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("042cda12-3f22-4033-9bf0-574d5270a3b5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0441a25d-a09b-464b-832b-8e1fdf769ae0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("04b345e4-28df-48dc-86b2-a17b6a1114ad"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("05d8e38b-53cb-478c-a0af-209e391a13a2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("05f115c3-1ebb-4097-8565-7c7554c7f7eb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0630141b-f04a-4073-9ee1-d4ea79ce368a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("06699b9d-7a8b-41e4-bfbd-ec4c869fe1d5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0685c3de-0299-4efd-aeea-5632bdc9ac42"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("06b3b5ed-681a-4a62-8fc7-f578e4cd8f48"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("07764fc8-9840-4836-b5ca-a1e1febdcfb1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("08492694-228d-41e7-87b0-8986738b3eff"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("086f9d32-ec20-48b2-bbb5-1134c4bbd64c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("09965bac-6188-42a8-857a-17505c5ecaeb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("09b3740c-1510-44db-b1ea-314aaef7e30d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("09fc66f1-999b-4128-adf5-3c112f6ff654"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0a6df0ba-e001-4fff-95d5-4d48dd5b0894"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0a793da5-a0ad-4cc8-8d62-9bedb825f902"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0abe34ce-65c6-4db0-9e75-dfb00f313a9b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0ac48b74-f761-4a0b-93b6-0505f8eb15fa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0b544d3e-59fc-4ce4-9bbf-2417a5892875"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0b6346d0-38c7-473e-9582-3a9361b3dcbf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0b8422dc-6d07-4abe-92c8-04ba047ca500"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0ba2e791-8b31-4941-bc93-8bbfbe12d3f7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0bb5d439-a0e0-45ef-927b-8f139a0fa361"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0bd6ce54-3630-4fae-b530-05a8d372a910"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0ce9a7f2-c6d4-4f5b-93b4-059068e62a40"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0db19ba8-f6c2-4129-908d-1962515f9ecf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0dd36471-3999-4af4-967f-cca59dcfa5bf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0e6b2ab1-7007-428b-b602-c0448a090455"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0e9a42f4-c8c0-4026-b374-a65f2213dcd4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0edb12dd-1c7f-437a-a0bd-5da4b31d8237"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0f75d4f6-288f-4d6d-9d84-3d9d414ff4ce"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("10a283b3-f800-4864-8585-ec7da25b8b53"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("10ad6764-31c2-4430-92d9-3493ad733538"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("110c1a93-ff0e-483f-ab16-4e620d776d3f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("11722b6a-6940-4420-ae8e-7d58a630b926"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("11a0ed33-f7f6-4f74-ad8e-cfe82a8391aa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("11e2b6af-ca47-4fca-8ca1-9dbc7325649c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("11ed29bd-e9dc-467a-83f1-8a5839618a7d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("11fe6c18-b6a9-457d-9b23-69e5eefe2992"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("12854460-2a64-4792-9477-431a484b2628"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("12fdaaee-eed8-458c-96c4-c75d3047b82e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("136a2b04-736c-41f5-82a0-74301a140fca"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("13a36623-5bc4-4844-9950-01eaf8532c44"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("13be2f75-d748-4b16-891f-926e1fe3ac1d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("14492fcd-c8ff-4ab2-9adf-17b78193bccc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("15007490-1aeb-4009-8a8c-7852a33aada6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1532631d-8dc8-4b8d-9679-ed3bc54b287f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("15bfc223-271b-4a9a-b52d-a2412d71fb58"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("163ce895-10c9-4f70-893b-45b953b7c364"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("16f02a7a-415d-4d5a-ad80-eca93c83098b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("170f0d5a-4f9d-452b-9249-c7e1b03eb1a7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1725cd26-984f-402d-91fa-f218feee2c1c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("17801ee5-1bdb-459b-a33c-2368d4c8a370"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("179a0abd-6d31-4cfd-8745-4278333b00ce"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("18072ee5-3e27-4577-b3b7-25b0ae186da4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1855b228-bdbd-4408-8acd-198efad50f63"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("18fcae90-95ab-45dc-8740-ceedf8b4542c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1a3430f9-8487-41b7-9579-a7a7ee7b871d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1a7f042d-3b03-414d-a0f0-242cb85c1d4c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1b5dfecb-8c2d-4c45-97e3-57d3aa70a05d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1b8d85dc-23b0-49d3-8800-609a65c496b4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1bb88c64-c7d1-4ed6-ad79-72f9da5c2323"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1bc19b3a-7c85-4566-8fe5-b8317dc3509e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1c77a360-9081-4d4f-8395-94df39de0c75"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1d805204-2e23-4c53-8a81-aafc36babe7e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1e2934c7-a1d4-4404-81b5-f915c446a38f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1e2d1cdd-c4db-432c-b7bd-b65242c2a880"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1e4713a8-8d21-4e81-85b6-fbc45eee44bf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1e515a5a-c853-435a-9796-06944d390ab8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1edc5295-ec41-4021-9f53-13054519e48b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1f9b93b5-dd47-40b4-b543-e42596213dac"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1f9e8128-aba7-44d3-8ea2-da8ef50db5c4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("207c1c0a-879a-40fc-9566-e2a75bc8f922"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("20a2cdad-88c3-4a66-877c-4df89638044c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("20f76045-d0b0-40d0-992e-a9b8cc37b26c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2116d94b-c5e2-4aca-9c9e-4a9c409a2ad4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("21e00179-d994-452f-9ea6-5aeb6eead463"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("21ea89cd-f2cf-423a-b3c2-8cc4d61ad6f3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("22644c9d-4ed9-4158-9785-240ff8f81e7e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("22bff107-138e-40cf-9870-cd5c08add3ec"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("22fbee39-7fd8-4927-ba2a-005fbaafaed9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("23b3c7f7-78fa-417c-8e43-7b6c01b9419a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("242cd591-474b-40d4-8834-11bf658839b4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("243407b2-1bbc-4329-9911-50d838c257fb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("24e6c8fe-afba-4076-9c1f-5bfe64e9e37b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2512d0f7-6d5a-456a-9d34-5646901c694f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2524a3da-8d61-4583-82f4-2942b9b3353b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2556c3bb-723e-420c-ba06-f3ad6e47f321"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2561beaf-1af0-49da-9957-5c3198562478"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("259a6aca-22cf-47b0-8050-66527d16d89e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("25b0944a-09ce-49a3-9aa3-4d5df9b6afe1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("25bb3310-ada4-447c-8b9c-94befa8671f9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2641b055-c6ff-4834-9087-6cafc7926627"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("26623e76-9e71-4ba8-83d3-25452cece3e0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("26bdcd08-8fe4-439f-bb8a-1bf016dc6240"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("26d9517e-2929-437e-afa9-09348d3c4931"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("26e06b4d-acf0-434e-abbf-bb31e81b086f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2739f25b-e1a1-472e-936e-663332f4e6f5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2745cfd0-e580-4dab-94fb-82f027a41bfc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("27723f9d-8479-4f34-9467-4ec7cf1ed123"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("27973316-afc6-4a57-a517-be958b42a825"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("27ccfcdb-2a2c-41b8-9344-353ba25a2174"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("27fddfdc-8c40-4d3d-9afa-2f19c9b7eb6f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("284ffaa6-fa38-4895-8576-65434f003973"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("289f4778-e0b3-4335-9d29-c936b737eaf5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("299444fc-d74b-419e-ae48-b919e685b218"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("29b2d42b-4c7f-4fff-98be-955c8c66986c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("29b3b1e8-5321-46ea-b14a-39012163c91c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2aef3efd-7522-4e24-8374-416cfd2cdc5d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2af30392-b5e2-4c6c-82f5-6045b60bcc4e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2afabea2-acb9-408b-91d0-9a3a339f024f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2aff3394-ce8d-4e82-a60c-98a5aaeefc3f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2bc9bf8c-7197-44c8-a15b-d069d7893bfa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2bd8a682-a62b-45e1-8b84-b63278f69999"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2c6b05f5-fd8c-4264-8e68-4926d356b101"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2c6be4bb-9b77-42c4-956a-514ed9785091"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2c72283c-b8bb-4199-96a3-216dcf41bb16"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2cae5f54-9c55-417d-bf62-4269440e3842"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2d23da44-0240-4c6a-82f8-abeea31e949f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2d4c9a7e-867a-45f5-948a-7fa70c6ee758"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2dfaf1f5-b3fb-4980-818f-558a9c148d02"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2e508afe-06e4-4472-8f11-87d57ab96955"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2f24c375-fa18-4495-b65e-e073142370fd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2f89503d-bb04-4a2f-9ae4-168908d13911"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2fd02708-6b45-4e1a-86f3-137bce838781"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3013440e-5659-46bc-b3c0-5125a2641a08"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("30635471-fa05-4584-91cb-f2f13d20ce3d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("30b8d610-e13d-46f3-b039-ad081e26535a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3138ae24-9d06-487f-9fdd-f5290f11c38c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("31861c54-7507-4d8e-82a7-899091875a5a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("319b5bb2-e963-4558-a9ca-97820419604a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("31bc9d92-086e-4df5-88a2-8d5eb154e302"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("324b5fc1-06d8-4b52-8364-0152c8cb6bd0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("328f1b15-b1eb-4aea-952c-7dcab683b64e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3297e6e6-22aa-4cc9-b0d3-2e73a7579aa3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("32e60d10-2ca0-4e42-8e6e-618d4e4d9d28"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3301a906-b60a-482b-92b5-28571a8e4e0f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("33f7e680-4ec4-4781-a8b9-93cae18dfa2d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3444d267-6241-4b68-b42c-8fcbf9e9bce7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("346c6679-9c67-460b-980e-56ccb60119da"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("34de0774-2c57-41b2-bef6-ef9a208cf732"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("34edf299-d4b4-461e-ae9e-ce2a47ecf3d7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("351e1853-5a83-4a3a-8b8f-e0566eab2f79"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("35825abc-e573-48cc-91f7-7ee60ae1cda1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("360ac790-f08d-4c1f-a969-6e5970434bdc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("36fffe0f-afdf-4bd0-9c70-777130c92b99"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("37ab2ea2-1ed0-4706-b22e-9e66edb6db5b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3829ce3c-9864-420d-90a2-2e0e2a32564c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("385bae8c-55b9-4ed1-80ce-dcf7e4b26bbb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3872209a-eadf-4c3f-81d4-e8723943e881"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3883b504-6c83-4510-83a3-61263525b45f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("395dda6f-c91b-4048-965d-cb1d772322fd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("39712b16-1cd5-4542-a0c6-43c69b8df6ca"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("39dca3af-6c2e-49e2-856d-c32a06efb597"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3a132c43-cb70-4c79-888b-9447f7c25d3a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3b5c8265-2bb0-408d-ad7a-3a88af643d9a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3c5311f4-423c-4abd-8523-1ee428258f07"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3cecd69b-d2af-41a5-bc44-6d15478df826"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3e730221-f367-4b73-b257-59e8b5435c0c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3e8b6e05-5d71-4181-b1bd-85a80220415c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3ebbbee8-24a3-423f-bd19-eb0d5d667ba9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3f672ae7-d0c3-41c4-a040-3e12f37429eb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3fee756b-79bd-4d5e-b328-fb1852db9a76"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("400bef04-683e-4980-a9db-3849bfe184b1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("40151205-e2bd-408b-af45-c2fc1505f94b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4060e4f6-59c7-4b40-9472-b2804e72cc08"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("408e9783-6ef8-4689-a3a1-ce91efcea378"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("40901225-5787-4272-abbd-42eeea76c5c1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("40a87a93-4aec-4892-b07b-7d5ea944fed3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("41ac26c5-4d45-4f3c-965e-1a69cd9d1d19"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("41e60b46-a0c7-45f3-aebc-1bd6d216f404"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("41f75b34-2902-4e0c-b482-4a004b5893fe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4266c6bf-9220-4f86-8569-1829df6dfc75"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4286d2e8-2986-48e2-9749-5a10660e9498"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("431afbff-8b37-4dcd-9aa1-a883f80b8dbe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4330b5a6-3536-4e5f-ba25-7c84e1b1deeb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("433d626d-922e-4dd7-aa09-c9e75aa38952"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("43424da8-36bd-4a8c-b6d9-71e5d28909b3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4348c6d7-776a-4377-a7f6-5179c2887d28"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("43546557-56c5-4e86-95bd-f515eb079256"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4362af8c-9186-47d4-a80b-58c5cd4ae0d7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("440e4617-c8bd-4093-a18c-8f81c0a6db67"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("440e7b41-ada9-4d84-98ec-f30101200810"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4423bf2d-749b-402d-acd8-aff93c0fefd0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("463d0a19-ec7d-4a93-9af4-0d1a4ee90d0a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("46599de8-80d7-426c-aa85-3e9250dc50b9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("46b216fa-9db8-439f-a68d-3971fa02b123"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("46f29322-2f69-4b5a-b036-c99d4e4a7dd7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("47208d40-993d-4eef-b675-f6a235992386"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("473f3ccf-8685-40cc-a52b-f84da9419765"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("478936a4-46bb-4476-abae-284d7648098f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("47a76a83-7b03-444e-ae12-7dc8af1d20e4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("47ac4387-cf84-4718-96a3-12274fd0e436"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("47cd0be5-0e6c-488e-b54f-9aab346ec81d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("47d85c99-f6c5-48a7-9ae9-e3a1fc4bc66b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("48a88126-fbe1-4e6b-87ae-3295fcc2a278"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("48b09496-cab9-42ff-9a25-6a098865ef45"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("49195fba-7a21-4383-a8e5-309b4f4df871"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("49acaf06-4fc4-414b-9392-ae10767b43c0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4a018465-05af-4c47-a938-661823f47af9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4a569c5d-dac5-43b9-b0b9-1df5855db35d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4b0e638f-34fe-4b50-b505-aa1de400c998"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4b25b414-d05f-407d-bca9-f8ae0a67e0bf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4ba12563-8b16-419a-a7a8-0695f68329e7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4be5bbbf-b405-4c3f-a8ff-6a57ba52cc1f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4bf50f58-9f89-48df-96a8-05dbe2936fb4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4bfd65d9-6c9d-4d11-9df9-013729efd58c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4cb3a705-0129-453c-84b8-ff34cb975ec8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4d84dc73-483a-48fe-aaf7-c523279ee019"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4e56cf19-87ca-471d-81ea-e720e2c3a71d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4ec8c6c1-0947-4fe6-99b6-f74b1c385527"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4f9004b0-d81f-407e-b8a6-ae2a4d6764aa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4f9e151d-6608-40bc-8a2a-e6adecf822e8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4fb4868a-1343-41eb-8db5-3ad25b9ee47c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4fd42488-95a9-41ed-abd0-7bdddfaf6e57"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4ff59add-6bc4-4d05-8c49-db775a8dda09"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("50d662d4-5949-4103-8324-81a32bec070d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("51563b9e-7372-4f85-949f-2f59da45082d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("517e384e-2744-441f-912c-84ba05571a57"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("51ab58e1-351c-46ad-ad49-36ef6d7dcd6f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("52004c84-0576-4e5c-b993-e0c448279b7a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("527c7a0c-e166-4260-ac16-8831198c7db4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("52fb7306-5c62-483b-907f-e87f3820cd3c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("53172085-13ae-443f-af37-25d03b0dbb92"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("537dc058-ff0d-49f6-a395-c9d4f211372c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("539597e6-7922-4f50-b033-5bbec39ad0a7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("53fe11b7-01f5-4edf-a91e-9f51cf49d977"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("54065c95-2e55-492a-bb3c-629b6cb39618"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("544e638e-f885-4ce1-b88c-85fd7f6f4fd3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5530e517-ce51-4fc8-b271-ae08f4c61800"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("55c9a18e-1a89-42f5-a9d7-16e25e53acfb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5651644c-7e10-4274-8b22-4642b23d7048"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("566bbb1f-d5d0-48d2-a63c-d624f4a8d076"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("56b3135f-6320-467e-960b-ed59e30a38cd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("56cf6179-fab3-4d9d-ac95-6790271b2e78"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("56f3075b-346b-48e8-8606-01631bf4c73b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("578b200c-e5f1-4d40-913f-45cc0a58fffa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("579e3ceb-8336-4009-b861-07ab18a71070"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5910dcd5-2128-46a1-b5d6-744976fb2f2b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("593a130f-67d9-4dbd-98d2-95e29ea02176"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("59bd72dc-b305-4296-89b3-13dba90ce0d7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5a21f07f-8646-462c-8fda-69a15d04ecb2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5a5d0aa6-b9d5-492d-b3e0-d0587fa370f8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5a7bf652-da2a-416c-b5f2-91248190b62e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5a92e202-7547-4627-bdc1-e7d3b9d27f34"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5a988eb8-98f5-4c24-8f8d-7ad49e3c11a6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5aa1a8e7-767b-4884-8a85-2e74a9d81f19"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5afa38d3-19f8-42ad-94e4-f1acf85235a3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5b4de5a9-456b-4f90-bfa7-d9a2a7ae41bb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5b7b5af2-6e01-441a-9db6-e67c56ae4798"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5c118660-6c8a-4e9a-9193-664db65108e0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5c17debd-001d-4007-8a24-98e6f8b09f15"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5c394296-30a1-45b7-8779-486817b24749"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5cf79895-191e-44e0-9876-81ae6281721a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5e00f3ec-f57c-4196-b0d8-100f395cadb5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5e982ff8-4e68-4f7e-ab29-fb18e0a7169c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5ea3eec7-fca9-43d0-9067-77552e223fbd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5ef2c1cf-9d21-48b4-bb85-5f5ea2ed7bc9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5ef57d6d-3262-47d3-9e26-d381302db8fb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5f0248a8-aec6-441d-bfe5-d96e6bf81114"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5f2de718-23cd-4b78-a910-b356886ef286"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5fb0438a-ee90-49f0-9304-278f039c2aa0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5fc7c7bc-9aad-4df0-991a-22cad036d180"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5fd18039-ffad-4fcc-baee-df0e93a2c9e3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5ff5cd2d-6364-419f-bc5b-2d7b35e00375"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("60dbdc82-397b-4bea-a6e7-8cafe6defd6d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("612e5759-6f1b-402c-8673-d83d642cf7a9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6282efc6-5077-4503-9824-e2e9cefad726"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("62d472f2-9c2f-4c5a-b47f-f508dc577124"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("63026ed2-0692-46b2-8959-cf2149e221ba"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("634b21f3-9350-4437-acee-5d2c22634742"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("63520e32-1dbf-40f6-9cd4-ad8f7c1739b4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6443bb9a-cae3-4f4e-bed9-76688ac33b62"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("64b6ce6d-4fb7-42d9-bd1b-989b2dec8814"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("65a1be02-e74c-4a8e-b6fb-7d5669f5e0cb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("661f52e0-c139-44e0-920f-153a77bb979a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("664e7f22-31d7-48b2-ab72-0fdca5862147"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("66b9e75f-3044-4304-8e2f-e87ada5f8c82"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("66f53c0d-317f-4e9c-a64b-1e3c9526e01e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("674eefb5-634e-4f82-a574-996362b767ac"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("678ab866-ffc9-4589-b85e-0f2fdded8cd3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("68006ec8-89b0-41bb-bf0f-ec467c2ceeb0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("68b67bf7-294a-4012-8eef-e69530d5bccc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("68c39147-d3ba-4f0d-ace5-2d15875d5aa1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("69194754-7f46-461a-b585-bb23b41aa181"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("691d14d5-5312-45f1-82e1-d7bf36be7c0b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("69202a18-5cac-4053-9a8d-714d825bb87c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("69356cf1-85d2-4d04-b6f7-261d539bbdb2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6990c9c3-dd68-4e30-aab4-ba63db71219d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("69cb6f93-9df0-49fa-92ff-f2091e15d798"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6a0cf504-b267-45ae-a86f-8f660fc4dad2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6c023c7d-a071-4edd-9b73-2b7bffbfc010"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6c0fbd06-5e81-4b66-8928-89d19ebc5c73"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6c2204d8-e058-4b58-9f64-f7998f836fb6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6c25f9fc-8541-452a-a654-9363e49bac34"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6d01c0fa-3e08-4be3-aea3-71c4f1ea92c3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6d367063-b0f8-4cb3-a68a-87a5fe70bf28"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6d59e6f1-c1c3-4fe4-9ac1-1520f74227de"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6d618819-faad-4c05-b555-6d076dec73f1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6d628c7e-aea7-45bf-be95-53e769359ef0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6dbcc591-8358-4ad7-9c81-8761b979a481"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6e308ae5-38e1-4980-906f-d676f8c207ed"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6e45c4b2-2150-4ba7-b883-b1adac6b675b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6ed2e405-1541-436c-af41-2dceab4d6ddf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6f337fe5-14e0-4a27-a288-142a2ca105c1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6f33aac4-39f4-4efc-8f19-4c04a0f9f19a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6f7c830c-dd60-4263-ba88-c701dfbbe8a7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6fda2103-cd8b-47ea-95a9-9ce258d208a9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("70950bd2-d19e-48fe-aadd-b8e66dd632fb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("70a88f55-5f8c-4149-bf26-bbc93063df9e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7146fa04-8e72-4d7f-8962-ae4adc6d2e1b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("714c794a-cbff-4b2a-b5a0-91c6866e432a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7158c453-6143-4c6d-9c7b-f13359866f9b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("72a4b3a6-015b-4f8c-a2e8-8c07831142e8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("72afdd46-6d17-429a-a67e-451948e969f6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("72d6ee81-87f2-4d9a-8fca-ba260a747e80"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7316f8a4-db25-44e9-b7d2-085723de6cbf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("738df3b6-0c4f-49c7-963a-1058bb10ff05"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("73bd8279-5bf9-47dd-bb57-6e5712d92998"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("73ffd232-a2a8-4236-b3ba-ddfa66782c44"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7400e5f2-ca5b-4def-9bcc-4e34b1d933c6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("741a7fcd-1e5e-448d-81f5-8131d2bb6247"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("743e4467-c93c-4b96-9da0-4650d437d5d0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("74a09441-2729-4545-bfcc-58f0e217198e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("751df41c-a4cf-40a1-914a-6779053f4754"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("75834d1d-12ab-4a6d-b20e-f3174dd5be13"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("75b0f03c-1bd0-4b97-9da8-66c72604e9d4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("75e3a9ed-8b23-48d8-9612-d67ba1b579bd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7715aa41-f976-4e8e-afaf-4c089b014134"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("772d2200-3327-43d5-98c8-bf4cb045eaa1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("778f92a7-763f-45fe-b929-aae9d99948c2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("781a3542-6269-42c1-bd76-84eeb12fedb2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7831c351-5093-47b4-824e-667119b74ffe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("78a51247-f557-4411-9fb1-164c66d72a1c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("78bfe333-4da2-43c1-b0d1-7c4f5186c5ea"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("78d53f6a-65c5-4df7-9d82-57649fa3ba2f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("79c36f94-4adf-4b8d-8b92-a895c37bc375"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("79c89c41-4acb-43da-8226-603a704d0ef7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7a362e57-f9da-471c-92cc-1638e35aecd8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7a89299f-0500-4812-bbd2-9496b9304f15"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7adfd527-157b-4f16-8ae9-a3495c8d2d4d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7ae31677-284b-4f96-b387-2f4be99b3328"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7bb8e37f-bbd1-47fa-86a9-8f0c99c8613f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7d1b2d9f-19ef-4299-aa37-e65c6fa76d25"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7d238387-8528-41a3-a84e-d5939f930d25"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7e62722a-332a-4d35-a66a-561e2705d9d0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7e86c605-b3c5-4342-8ade-f5722f504cb9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7e95da21-f351-4562-b136-5416c0ee213d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7ebc1249-2d1d-41c1-a1ee-09549fa2f7db"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7f3962c6-f58c-46f0-ba39-7bdeb58b983e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7f79e6dd-bb5a-49b0-82a2-c4cc85a51978"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7f9a538c-6908-4605-b297-207f67a9af55"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7fcbc0de-533f-45c1-afde-e4821a2baf95"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("80735c47-f1eb-4fb8-87fb-9ba26b79c5ab"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("80fbafa7-1615-4afc-b878-c1291c24770f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("816c5788-4d2a-4881-9e97-f29826715710"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("81bfd7cc-6347-424e-bfec-0739cb664c2d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("81c2a04d-a440-45d8-8ad0-b5186a6c9021"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("81dbb7e0-22f1-44a1-ab2e-2f927f535a63"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8207fe17-dbb5-418a-b10d-5f6d6c7b1be6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("82ceeb61-2f11-44f9-a6a3-9127425d37f5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("83caae63-bfda-4752-8028-f43139508caa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8436dca3-3277-440c-b9b1-b67a7c91095f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("84b5084e-27f0-4328-8ad5-0e79181e9a8c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("84def9ee-4123-4f24-8665-b16bcec9050f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8524e45c-eaa8-4042-b70f-8dac2dc92960"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("852cdfb5-a414-4780-9c98-dcd5e5e6b035"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8580d347-0035-452f-af3b-d1951f617bca"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8581f2ac-4519-4ba6-99d2-59387362d710"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("85cedae5-1423-43fb-b2a6-cd596379609e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("85e9ee76-45e2-4ef9-a266-0c2146f04a3d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("85fb2f42-db97-42b2-b06e-53aba882f144"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("87080206-4306-4055-aa73-5aa328f3d70d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("870ea109-9983-49a8-8300-5e1a5d3b0406"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("875bfb41-5576-4c0f-a18b-352fc0e66bbf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8792d87a-52f7-4107-9fd4-6066066cfa8e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("87dd7cac-8d57-49d9-99a8-be6deef82a72"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("87df6740-0a48-43ed-aebe-46fd49770105"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8807404f-8ed5-4444-afc6-1a0436cefee3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8871990d-6482-4e69-ba46-784cc54dc142"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("887ecd38-9cf0-4946-9a04-13795498e927"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("887f7c0a-1b9b-443d-93d6-07c34c0eec2d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8887148c-31cb-4b12-8510-201fe2d0b168"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8958df42-ad38-405a-88e3-d227bc664c6a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8b6e1d2c-445a-4ad3-aa05-06696f70b725"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8b72453b-1e27-43ba-b98b-382d1609026b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8d2c8919-e981-4b7b-9ea2-0971bdc5d9e8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8d7d364a-1c90-44e3-801d-54811eb8462b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8d806a67-b53f-4ab8-ac8c-a440b045a776"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8daa3e51-be83-4b69-9d71-862c91579069"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8dce34f7-2c91-41d9-83e3-892dd1e33e0b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8dec0c03-a2a5-4a1e-be41-436449983247"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8e03f26f-f2e3-4ba7-8132-3850d88e1bfa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8e75e1c3-4a3f-4c87-bc65-134d01d3265b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8eea2bdd-568e-4071-b3c8-0d706dcdf828"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8f2609de-230e-4c22-b179-2f5b52c5f2c4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8fd1c0e4-503f-439b-b10c-398040f14d35"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("905e6c8f-9e39-4a4a-99b2-9314b2816d97"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("90771014-5991-4d2c-9ff5-23bc6588d60d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("90a81b95-4d41-494b-a9e1-794d20fd58e5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("91d7a656-46d8-423d-8f99-8f1afb2e01e1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9236834d-f148-4a5e-87e8-a2ab61044aad"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("92961c42-63af-4669-a8e0-795638e90823"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("92e0a787-5e2e-47a4-9fed-35fb6fd0ddd3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("92f6f6b5-a3bf-4338-a79e-87a08fd4989a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("92fa785d-d02c-4aa6-a524-4cc208807034"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9312baa6-9cb6-4f55-a2ed-993202a45d0e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("937d8951-1a77-41b0-8d5b-26beb98413ed"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("948f4221-0348-48fc-a940-70132db16306"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("94e7ee94-d757-4674-8358-e5615fb51574"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("952491e5-369a-4012-bd54-62ca00b6bb81"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("960655cb-467e-4de7-ac51-028374851401"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("96641166-87de-4415-af16-681d6836d857"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9676a7e5-a84c-4c1e-bd35-7ad1f574fcca"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("96c0bc15-a62e-4089-a8ad-5a53ee808889"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("96ce4dcf-2b79-4b3d-925e-fb15000ee050"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("96de3e69-29e8-40fa-b848-a35f1749f38c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("97f424c1-66a3-4794-acf3-b54cd286d7a3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9817b6d1-b1e6-486b-95c7-8206a1ae48f7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("985092b0-3831-4faf-9e6f-1e5eeb54d0a1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("988e6982-b725-4bf8-a83c-3262ea5dffdb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("98a0c139-4425-43de-bfc3-b7775ed82d75"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("98b061d5-01e6-45dd-9ebc-6640c9d62805"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("995e667c-246b-4488-939c-cd4b1cbdca66"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9976ce91-1d93-4025-9a19-21497607c167"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("99b636dc-7b12-455b-835d-7c5fd93daa7c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("99dc47e5-6fca-43db-9996-5aefa64d4dda"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9a3a52c9-da5e-4e1b-9f13-0db89857675b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9a942306-b201-4619-a637-38004ab14e5b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9acd2097-4120-40fe-a0f0-c8558ec71154"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9b06a05a-e78d-453f-8a26-85ead9790ff7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9b498c7a-f8ef-44ac-9b5f-5d4513164119"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9b53166e-6a90-4793-ad56-fecce12a69de"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9b6c2845-176e-46d4-8efe-630675b67d0a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9bd9d384-b61f-4f42-90e1-dfa5c04cf35e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9bf24539-1988-4953-b998-52ad66633739"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9c01bbba-eb61-40e9-8897-6db4e3b76f93"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9c2eb07c-af3e-4817-8cdc-0ae168797fe0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9cc2c01e-abb1-44c7-aedb-1f72344b3aef"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9d28ca2f-7396-4e74-8252-4ed393ffbb2c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9d52a155-2be9-47bf-bd07-bfcdb9d2a9fb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9d88255c-3e98-40f3-bd7e-c3a41db8cd77"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9dac547e-2956-4563-9680-c76cd6f22f62"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9dda1292-68c2-42e8-9c4b-5da8068de764"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9e044104-dd1a-45d1-a58d-0ad5adf8360f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9e3ddd0e-c3ac-4600-93e2-652a23aafee8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9ec148b5-a2e7-4f9f-998e-4eb199bc22b5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9ed1105e-e6e2-41e0-90a6-73a68b89bf3c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9f49a781-00cd-490f-8470-d2b2fbeca2e8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9f66b8b7-212f-4cbb-9557-7ab4d758fda9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9fe2fe47-9d70-4019-8057-77d290ab4aed"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a04bef56-c34a-4ecc-b975-cc0d30a3d389"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a0e13e3a-80a7-491b-9dae-c43e86065027"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a17da4e5-a96b-446b-9d7d-173ccb4fef63"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a1ab12bb-6dc8-4557-8968-68a2a0421dc6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a1bda2f3-b31d-48ce-9b5a-c6397870d2f9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a1ed5eed-fd49-4986-aa5d-04bdf6d6bc27"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a286036f-a284-4846-8d8b-8da475064299"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a2ba249b-e4ba-4f1f-9c7f-c61812f53f01"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a38bbb53-fac4-4bca-a074-9773c7c99720"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a3963db0-cfcd-4906-8e83-1d2a51497e79"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a3eeb1b7-9153-476c-9fb1-7f5042abf37c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a3f02183-4786-4968-b5af-b8abee990b1b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a41f3125-1f90-4f00-89a8-b943e4fc447a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a43382af-1cc8-4ada-95d0-8672b11f8e87"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a4479451-5bf9-4fff-83e8-c417f2b5cc57"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a468ebe0-3011-419e-851e-859261d5eba2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a49f9442-0986-4424-b10e-6e6caaa78135"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a5428b6c-e246-4d7b-a896-fc9bc43e9965"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a57d6c45-917a-4304-b412-002aece184cb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a5f0105a-c624-4cf0-9640-d79a02cced71"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a78226e8-4c7d-4056-a456-bae564e77a41"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a7e97920-3790-4ddc-8f84-7174834a52e4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a851364e-7ab3-4f94-b63d-2cfa2a622e6e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a8f7fd9f-34f4-4cf8-a1d7-e51f10830dc1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a92d97a4-4d09-40b2-81ff-682d6c834c5f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a94dfca0-58b6-40c0-89d4-fc2cb33fe5d8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aa0fe854-c68d-418b-add4-f3454e8d9679"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ab588490-4ea8-4f2c-80c4-f14cc04a917a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ac791c85-9fc4-48bd-8342-98a78459526a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("acaa3de5-e7e8-49ff-a3ad-891704efcae0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("acbe21f3-4a38-4c8a-9096-b2c0d58d58cf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("adaba41d-b1c2-48ef-81c3-1f03fd183d66"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ae13ad76-0932-480b-9354-7c86acf22b53"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ae7b86d9-137e-4832-9f99-f265367145a5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aec72c86-4c9d-4d83-a7e4-7a07bc28a32e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aef29431-04df-457d-91bb-e1e259b0dfc3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aef49681-aa2c-4477-91e0-c91079844bdf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("af5ee5e7-debf-4cfd-9243-2ef609267b34"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("afcf8dd9-09c4-417f-800a-00d2d1810a31"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b0662b0b-11d1-4c9b-bc78-3dbd5e94adeb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b0a2e09a-4027-40ef-9849-0efb7a6af5fb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b0ffa2b1-85d1-48a1-90d1-2b419c9d7110"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b125ecea-074f-49d6-ac69-62c23ce2ff65"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b15d6397-925f-46cd-a3de-bdbad81aa2ef"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b17f729d-b15b-490d-9947-945e50582f15"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b1b4718b-419e-4c9b-a8e1-5b541953b2a7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b251f624-6133-42c7-8148-29710f328569"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b2a8a340-9a5a-4e04-9a13-9a29d87c2483"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b30a910c-4091-4349-aa32-978ae82a34c2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b387785b-f2a1-49ba-93c4-58bb2fafc416"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b46d7986-740e-4336-a7c6-8e296be06d96"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b49d65fa-bc65-4e1f-be31-29e8e154270f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b4ae3921-4f44-4cc4-bd4a-7b457e20eca6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b52192fe-1990-4317-a055-3d21aacf922b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b55f5b98-ec93-422b-923b-e6d597a09ba2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b56c2446-ce0f-41f1-bc91-61e3a842d476"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b58ccfd3-ea1b-4c36-b823-dcf679c8bf9d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b5d8bf0c-d48b-4ab9-a151-13f80209dc92"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b610d877-9ace-41cb-94fd-80e5c5e2e501"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b67dfb68-a900-4f11-a51f-dcaf48490b8a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b6809ccd-f916-4906-aa56-023487067217"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b6b2c819-e8de-414b-a92e-3461561a7516"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b77d0b90-cc10-447d-ac99-54dde99417d3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b7dce9b0-3554-473b-ac43-1890f44bb1ba"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b83fe884-af20-4964-a284-9beb247f37be"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b8913b55-0df0-4108-9d76-1e02c7404e2e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b8b604e1-80b3-453f-8f38-4ca81b9091a3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b8f38750-8933-45f1-af12-d02d300e80a9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b915a4e6-8a0a-441c-8f8a-c474d0776038"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b924aa00-33f6-48fa-a41f-bc18b1b1d335"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b948d5e1-f969-47eb-bccf-a79bf147dbbc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b96b5c9b-2ab3-4faa-b4f9-26424f45e741"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b994248e-ce2d-4476-a3f9-506273b788fb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bb12752e-5011-4ef6-a8d4-fe4d83883504"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bcb5fca4-4817-48d5-b284-520349b4587c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bcdc76de-496c-4cc8-8331-32f34f6e0a25"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bd8960c9-98c5-4954-96fc-f9eb3903738b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bd9dc88a-a735-428f-9336-5c88420a2fbf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bdc8f846-e000-4d25-b188-ff6e05244b24"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("be82efb6-467d-4758-977c-cf4f26b95076"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bebd61d7-9535-4e2b-9c55-693df42796c2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c07a27cc-0663-483d-9e97-1621d0eb5877"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c0cf3f1a-c3c3-4337-a1b6-f9fd40dcb804"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c1b00ed2-df00-45d6-947d-5603aaf3096f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c1b37e36-ad1f-48eb-8933-438bfe123f44"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c21c9a0b-b53a-4835-a974-2574e0ff10de"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c21f538d-32bf-4671-9b86-b632fb4258ed"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c2263dc0-8514-4a4f-840d-19ce34798dfd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c261b355-89a2-4a2a-af44-a52001919f5e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c26631f2-e126-4a6e-a5b5-d92c965b3c8b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c2fc2acb-0403-48a6-a303-9b9cb893f536"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c3a54338-309a-4cc2-99dd-c489bbeb8779"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c4496c4b-f29a-41d4-a227-d525f5f901bd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c486e582-8353-4ac9-b287-a2b54f2a8045"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c4ebf3c2-9a6d-4d3f-9212-392a0f9537bf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c505c1e6-e531-4414-9f1b-7e90ea4d9bc4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c5f868c5-3725-416c-8732-76dfeda0c5f7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c6575789-f105-4d8b-bba2-ea3178e0ae44"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c67c1c33-7b24-4c50-91ec-20caede1a8cd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c6aaf264-4c31-4bc4-8190-0255204bf8d7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c6acf9ac-c044-461c-ad36-1dd39730de22"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c6cae6b9-28d6-40f0-879d-67fb21650806"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c8236fce-f5c3-4833-8e9a-2c721769df5c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c85a6e2a-da79-429a-9640-36ff43e27eae"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c87b92d4-3cc1-4a19-9c44-fd5910dedb57"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c887094b-f1b8-4b51-a9e5-338e2707abfa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c9b55100-160a-4541-a11f-89e6470f111a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ca54facc-66e6-4c16-9b95-97035cd491dd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ca98aab1-d642-424f-a7e5-adfcf70b0c7a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cad4ff2a-a600-4cd7-bc1e-9f7e1c7b4e07"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cb90dde0-10d8-4bee-a243-8f9f91d284a6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cb9893e0-04bb-45e5-96bd-2a0f5363b6f0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cc27138e-0da8-422a-91c7-372516a1f46d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cc4991e6-31a6-4da3-8c40-10bdd21a161c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ccf0007e-68fe-4aaa-98ff-48dcec776c52"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cd2bef95-fd8d-4360-9f9d-a6ac46f1c7ed"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cd639469-3174-4c2d-a464-d817813ee24d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cd850baf-89ac-451d-889a-11dc8cd04a5f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cdc5fb89-d576-4b13-af4d-bff065fb0ae8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cde520b7-43e7-437d-964d-b2997b370175"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ce0bcaa9-6170-46a5-95ec-9cf9609d4d31"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ce1cdbca-fbf8-4e43-ab73-320c57d3e5dc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cf0cd3c7-4129-47cb-8cb9-4af23a066112"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cf8f2cf2-792e-4236-bfd7-565d916b1e9d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cfe40d12-04b1-4447-8feb-aba08b9585a4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d0b0c57c-f986-43e1-972a-15ef89680e09"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d0f41935-3c4a-4b11-a65f-1925b6633c8b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d0fe40f4-2d9a-4481-8b68-09f52dc27038"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d112e5af-99ac-4471-bf9c-d4656e150683"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d1a7779b-97e2-4fa7-b3ee-e41f1c4a07b9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d1b4d1d3-66ac-4ff2-8875-30e936957ca6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d1babf86-a653-4932-890a-763a69864aa6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d1fdf238-0d09-4240-a205-42609a1f2f6c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d241436f-9ecc-4277-a4ef-257ab864cc67"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d2bfb31a-06c2-449d-9e5a-fb073b274f4c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d33ef014-aa0f-4b42-9cb3-7f43c1ad60da"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d3c1e419-80bb-4dbb-906e-5c17efaeec90"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d3ff3fab-21bb-4717-935b-41acc601e099"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d429c045-9dd8-4b39-a726-feea08e6e8d0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d449862f-dddf-4777-b396-c848585c4530"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d48c5d11-25da-4250-b3ee-f84aca46dcd6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d49c0940-4289-4b7a-b3d3-b13f86905c16"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d544278a-9a70-46ea-9445-2f1c98ba022d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d58823a9-a0f1-44b1-8d5b-eed0afa58217"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d5f47e04-7181-4b05-a2bd-adff76fa2f7a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d5f9c539-7bfe-4bab-8ca9-f1bbff499fb3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d6090c8a-0cc9-4f05-90f7-485528dde487"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d6675f8b-980a-4a77-825c-42180da56272"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d773a6dc-784d-4274-abdd-ad0581952e6a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d7a2e482-93df-466e-8075-9dc684ea7743"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d7a3a2b2-c807-4d18-996b-04d34887f7a7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d7e85984-d11c-4ee8-a439-9549ca5063e1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d83f735d-e0d7-431c-92f6-79214a3499b3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d8c976c6-38bb-48e1-8b20-b1a7a9f630f2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d8e83f2a-9ae7-4eb1-9713-5bcf672c403d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d90c0d38-9059-4fc8-b686-a68febb15cb1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d9221416-12b0-4074-bf39-c7085c558291"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d92d4b95-89e4-4577-9dea-7d9518ce4a1b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d9a99939-a95d-4369-aed2-b7d82e2e8036"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dad5afb3-3c86-45b0-96ab-f0cb3bff08fa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("db49e09e-b1f5-49ae-94e0-78d54b656b3c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("db4b4307-b8f1-49c5-9125-98aa20d10727"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("db7864d7-68ac-47d2-8b19-217d31e08547"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("db98ea53-e80b-4bd3-9cbf-12719b66b5e1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dbe36a90-4807-4072-b568-5b71c6778f4f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dc11ce98-3d2d-4ec4-bbc7-8e491536795e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dc5a8393-855a-4b85-90c1-52d043dd4c6c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dccd8446-e0d4-4ee8-be0c-36c4ec4e7fe1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dd52e5d4-b033-4880-a708-8aac42bd4869"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dd77d662-8d12-4963-80c5-e7da575ae153"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ddb97cb6-753d-4707-93db-3dc6d9266747"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("de646939-5c45-4769-a898-ed2b3ea81678"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("de7ea6cd-e3df-4842-898f-244d6c70d85f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("de8de8f1-a80b-437f-a941-5169f8a57eb8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("df09ac85-5506-4104-b013-9fdf748a5e1e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("df1a20fc-b0da-4187-a738-6ad8f25df221"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("df79ded0-5ee2-4da4-acfd-1e5641d07794"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("df8b348a-b718-414a-8b76-5b943799452e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dfb92919-1849-4a10-8ec9-df09de763bc6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e05ab139-9a11-45a8-aee3-7c0e4638704c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e067c003-afe0-4f14-aac4-b2fe2daa6b06"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e07f5771-b690-4141-9cf3-582db08489f6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e0e2257c-2d61-4ed8-940c-9bf01ac27ae3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e1d9b746-b7b0-4212-bca7-2c4bfc8ec1b4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e205d5c9-0fdd-487c-a715-03306ada7ce1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e31f2f58-49e6-4dd3-abc0-e2cc81678b2e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e363ef7c-1298-4d13-821f-99acf237ec80"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e3ac0e68-9371-4884-b4d0-92e8f761abb3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e3cbc796-361c-4000-b8ff-425cb508ae1a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e3fac5db-987a-4094-8847-4714ff6a991b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e43365ff-64da-4b14-8f8d-e6999663e894"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e5141f46-bd83-4228-b26f-fe9fa47ea004"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e5c6b4ff-b7f9-465c-a9f8-2ea487d0b030"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e700189b-b5a9-4244-b9f8-d52d36ece388"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e7bbfb7a-79c2-4316-96c5-98653aa32b59"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e7de927e-6494-48f5-8dde-0909284d7aa6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e84e2577-4595-4563-a832-e6f68f30d856"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e90da1ed-e4aa-4ce6-991e-87d0f5d8d5e8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e95df58a-30ee-4e5e-a3b7-b1e446295036"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ea8e147e-7557-46c5-87ec-7adcf9a0514c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ea90275a-dd72-4ffd-9143-8dfc6581dac6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eae9285b-8c9a-4d53-809e-ab2bb6a75ed5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eaefd550-4f12-409d-a160-93de504666b6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eb3618bf-1c2a-4380-af2f-03bca44537cd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eb7810bb-f48f-42f2-bd44-a29304bf3c9e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ec470ceb-59c4-4699-9dfa-f39a02a7f897"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ec7df910-e183-403e-8dca-3bd7d4970ff7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ecd21430-e55c-4286-81f0-bc364ee1a781"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ed2e0c3d-1f70-43fb-a87a-554673aadba0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ed6899fa-477e-4fa8-aff5-c5ddf95dd653"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ed77f8ca-f6cc-44bf-bca2-57dd9f3ef598"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("edcb1b51-b294-47d2-adb8-c879098db649"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ee0580f1-4a0e-4371-b60c-a9714af9a67f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ee28f804-5e2f-49ca-9b2a-a546a011a682"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ef03aba3-fea6-4e0c-97f4-ce84bbf34e2e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ef6d9684-46d7-4626-9cd9-07424da831dc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f002227e-f534-4ed7-bdad-c3bbaeccad3e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f01e3945-2da0-4311-a257-7bab3c80963d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f19306dd-ee65-485b-a6cf-d8cd79d89cd0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f1b49a05-5e63-43c4-8d67-27a013d3d5c4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f1cf53a5-c0f9-435d-9d7a-8546a035d38a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f1e543fa-a17e-4be5-80b8-e7e22db945b3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f1ebd939-d422-415a-a32d-5d63f0fc426c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f25745bf-5190-48a6-8b73-3503caf039b7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f27f8ddd-ea12-4c9a-af89-41b30da0acea"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f2e267df-c45a-4185-b4f0-b79bdd5fef8d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f3558729-9520-41c3-8edd-330286c51087"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f36891f9-ad1f-4703-97e7-4af8644a6f96"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f38c6246-6eb9-42e8-b52c-f440fb35e8d0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f408ad95-27da-4420-aeb3-9953a65b61d0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f4795ab9-7f49-4baf-9200-62dbda101735"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f4b7235f-1144-44cd-b6e5-484c06f68034"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f4b9ddc2-610f-492d-8954-05f6662f0cc5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f4cccf74-fec4-4dc0-a50a-c8e8d33fe334"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f56389de-a46e-4906-aea7-cef69fd5822c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f58fe554-31d7-4d4a-a7a9-d91eeeaf6a19"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f6002a39-aeb0-444c-9249-bcc06123b38c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f67b6380-7dae-4e34-b33c-5d05979ff66d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f6c85353-3d70-4de0-a45e-0504fbbedc51"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f759c6be-b03c-4abd-963c-53758804d264"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f792b47c-b5a6-4621-8fc2-7a213dbffc51"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f802948d-7685-4343-b2db-5ee462398664"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f804ed0d-f913-4c0e-9f84-3c3172ff4d68"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f8454504-b584-4d99-a73b-0c49355d29e9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f8aac98f-26d2-497a-9e24-cd045114d27d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f99f5181-606f-4a51-9972-e483bcc3fa43"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f9aff653-7ce3-4b54-9887-4eed188f6647"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fa1b26b3-2d11-4aef-bb20-ef6ff4dff31c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fb50bab9-d9ad-449a-b3e4-81bb2351159f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fbb1f207-a46c-4ac5-949e-dd932e547fad"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fc5dc847-d5d8-4243-a963-805a589ee923"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fd9347b9-82e6-45f0-82b9-856bb1fdfdfe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fe2bd1af-db4c-47a1-9040-7ca7dbb1c054"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("feb9cf67-7ecf-490f-8a7d-d3f6659e11e7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ff966114-6fbc-4643-ab83-310db8531328"));

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6") });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "SemesterId", "StudentId", "Type", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("001a78d2-4541-411d-9367-674f34ed8326"), "Computer56", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5920), "192.168.1.33", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("0054b162-5a1b-4f35-9b92-db3ada3a41c6"), "Computer34", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5819), "192.168.1.19", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null },
                    { new Guid("045e33e2-057c-4a63-aa4c-89ef17e0afe5"), "Computer58", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5928), "192.168.1.33", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("09fd3d46-f58e-4b3d-b99f-ca5992c8c6ad"), "Computer14", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5735), "192.168.1.57", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("0cf79cfa-f66d-44a4-8be8-2c731e480bb1"), "Computer31", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5807), "192.168.1.95", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null },
                    { new Guid("0e099793-ad28-468a-bbda-0afa3e760b2d"), "Computer52", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5902), "192.168.1.46", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null },
                    { new Guid("14d23143-b60b-4ec1-b448-42a06896ee1a"), "Computer37", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5833), "192.168.1.85", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null },
                    { new Guid("160f9f96-c9de-4645-a6e5-acf3159dd4d1"), "Computer60", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5935), "192.168.1.48", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null },
                    { new Guid("17fe743c-37b7-4f48-a719-d007e7d6d7e5"), "Computer28", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5794), "192.168.1.55", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("1b613a59-1e6c-4413-939a-b0f37e463e2a"), "Computer51", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5898), "192.168.1.90", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("25fde954-5837-4353-8edf-6f64caa6fcf9"), "Computer30", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5803), "192.168.1.31", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null },
                    { new Guid("31242db2-ce53-42e0-a57b-16c92347b127"), "Computer48", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5886), "192.168.1.74", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null },
                    { new Guid("342c1ac2-3ec8-4ede-af1d-cd404b0aa23b"), "Computer5", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5688), "192.168.1.73", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("3531a4f8-b25d-4a30-b2b6-e1cbfec929a8"), "Computer18", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5752), "192.168.1.27", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("36197828-d297-459a-bd4a-473c4b1bb1fc"), "Computer32", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5811), "192.168.1.10", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("4198c9e4-0061-408f-a5a0-2b9bb9730e73"), "Computer50", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5894), "192.168.1.65", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("44ddc2d2-fa1e-46c7-8839-f36ff66078d3"), "Computer12", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5725), "192.168.1.42", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null },
                    { new Guid("489bfbb9-88bf-4c8b-a1f5-e03dd02bc14d"), "Computer25", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5781), "192.168.1.67", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null },
                    { new Guid("48b4e24b-453f-4093-b1ba-bef4efc37908"), "Computer42", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5861), "192.168.1.28", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null },
                    { new Guid("4ac77790-2f52-48da-856a-19b98ff1604b"), "Computer27", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5789), "192.168.1.36", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null },
                    { new Guid("4bc3cd38-b7f9-4fba-a97a-a60a7f374864"), "Computer20", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5760), "192.168.1.52", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null },
                    { new Guid("4e751f0b-71eb-4349-9583-fc22caeb7efb"), "Computer24", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5777), "192.168.1.84", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("524a01e8-e6be-428d-af93-32b6ba25c0a0"), "Computer17", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5747), "192.168.1.84", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null },
                    { new Guid("5366f1c3-6eb3-4bf5-bd07-e0c7492953a8"), "Computer36", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5827), "192.168.1.83", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("581c441c-de67-4b3f-9788-c1c21c923423"), "Computer54", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5912), "192.168.1.91", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("5be3873a-edbc-41a2-b799-f07ada4c4f9c"), "Computer29", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5799), "192.168.1.66", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null },
                    { new Guid("5fb4cc04-cda2-431c-a47a-dc102806f3fc"), "Computer23", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5773), "192.168.1.78", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("64eaea2a-9f5e-4025-9e3e-9579c1b49a42"), "Computer3", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5675), "192.168.1.89", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null },
                    { new Guid("68393f02-4ff4-4c03-ae95-efd0aa53777a"), "Computer59", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5931), "192.168.1.99", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null },
                    { new Guid("687f8f84-e1e7-4071-afef-a1c29e1b1a9b"), "Computer21", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5765), "192.168.1.12", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null },
                    { new Guid("6a261599-0bdb-43a3-a546-596a2615db8d"), "Computer11", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5721), "192.168.1.18", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null },
                    { new Guid("714ee635-8e30-4546-94b9-4018226214d8"), "Computer9", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5712), "192.168.1.17", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("73887f1a-ce6a-44fe-ab13-a63435600c27"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5670), "192.168.1.5", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("74fffebf-3534-46e7-bf58-f1071113bcf3"), "Computer13", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5731), "192.168.1.3", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("7bd5ccd4-bcf2-4414-a732-72246b7dcf6f"), "Computer19", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5756), "192.168.1.31", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("7c4dd14a-ae73-4c47-848d-016356ab118b"), "Computer55", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5916), "192.168.1.70", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("83c8a33d-7d6d-48aa-8a88-70a5065b9877"), "Computer22", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5769), "192.168.1.34", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("89bb1b97-271b-4cd4-b3b5-2677a73d6473"), "Computer49", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5890), "192.168.1.95", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null },
                    { new Guid("8a5b8fb7-c98d-4ef9-90fd-08e10eaf07a9"), "Computer16", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5743), "192.168.1.28", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null },
                    { new Guid("8b96e0a2-69fe-417a-91c5-fb9ef4afecc4"), "Computer57", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5924), "192.168.1.23", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 1, null, null, null },
                    { new Guid("9acde3a5-15aa-495f-bf0e-45f4df2a7284"), "Computer45", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5874), "192.168.1.54", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("9b6f6bc4-2c38-454b-9cf3-191d448daaf4"), "Computer7", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5697), "192.168.1.20", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("9bb1753f-c33d-4384-9cc2-fb88df993487"), "Computer15", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5739), "192.168.1.67", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 1, null, null, null },
                    { new Guid("9d301ffa-1832-4095-8ac6-d3c9f28fedc3"), "Computer40", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5853), "192.168.1.79", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 1, null, null, null },
                    { new Guid("ab4d0de1-bf04-49da-a060-c175758ac2bf"), "Computer39", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5849), "192.168.1.99", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null },
                    { new Guid("abeefd6b-65b1-4ec7-b39f-bfb477934d93"), "Computer6", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5693), "192.168.1.61", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null },
                    { new Guid("b5a65cc0-8e66-4596-aaa0-3f14b02e2f9a"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5636), "192.168.1.27", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null },
                    { new Guid("c319e340-6cb2-40fe-bc77-96a0d29bfbfb"), "Computer33", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5815), "192.168.1.82", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null },
                    { new Guid("c444c04f-85de-417a-beb7-e159a73e9ba1"), "Computer47", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5882), "192.168.1.6", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("c874d065-9a3c-4a97-ae30-63eba8ec0019"), "Computer53", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5908), "192.168.1.18", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 0, null, null, null },
                    { new Guid("cdec2131-09e6-4a09-b216-b28275075908"), "Computer35", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5823), "192.168.1.36", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("cdffa943-2667-441c-96c3-ee6ada37291f"), "Computer38", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5845), "192.168.1.31", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("d3ee12ee-074e-4ce8-880f-f862a641c884"), "Computer41", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5857), "192.168.1.20", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null },
                    { new Guid("daeec080-c3fd-4481-a8c1-13a8cd7fbb1f"), "Computer43", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5865), "192.168.1.43", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("e1126d95-b807-471f-8903-940c70f3ab35"), "Computer26", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5785), "192.168.1.9", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null },
                    { new Guid("ef1ecc3e-ab3e-441d-aa08-dc5f71d2d89a"), "Computer8", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5708), "192.168.1.93", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null },
                    { new Guid("f1f4d219-0164-4c60-a0eb-ca296596b27e"), "Computer44", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5869), "192.168.1.79", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null },
                    { new Guid("f67c5b6a-e2e3-4411-be66-90b0d6ac2dd8"), "Computer46", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5878), "192.168.1.11", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null },
                    { new Guid("faa4b506-bae5-42b3-b71e-04f515125fa0"), "Computer10", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5717), "192.168.1.3", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("fc50f963-c127-43e5-842d-418e8ffa4d75"), "Computer4", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(5679), "192.168.1.27", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "AttendanceDate", "AttendanceStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("064584ce-bdff-4614-bd5b-f130d2509405"), new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer21", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6911), "192.168.1.65", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("10d75806-8026-4929-b8fc-37bfdad54767"), new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6795), "192.168.1.90", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("117b6a3e-78a9-443a-baf0-74a058e7664a"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer23", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6922), "192.168.1.57", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("12ba0a6e-626f-41c5-ba5d-103d9f24e35b"), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer11", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6855), "192.168.1.14", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("1912e6d5-394e-4dca-a0a3-66438312c251"), new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer31", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6968), "192.168.1.84", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("19331843-4f8a-4462-b077-1ca923e3007c"), new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer26", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6939), "192.168.1.46", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("315d0902-4ec2-4714-ba58-c2a741a1502f"), new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer32", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6973), "192.168.1.35", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("3c72c332-8a6e-4780-87be-b23a8e38557d"), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer24", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6927), "192.168.1.15", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("44d777c7-fa07-4957-ba06-e0a2d006d6c4"), new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer22", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6917), "192.168.1.86", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("53437d5c-6fda-4c08-a0ce-8f56562d4cad"), new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer40", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(7023), "192.168.1.7", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("5aaf4c30-9011-4a9d-8352-0b5b1dfff2fd"), new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer20", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6906), "192.168.1.21", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6066cd0a-cd0b-4beb-81a5-10b0fdd8a1fb"), new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer6", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6827), "192.168.1.50", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("651cc96b-d735-4496-bb98-a59a81d1130d"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer41", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(7027), "192.168.1.37", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("682bc2a2-e19e-4b84-b03d-637de69b5f95"), new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer13", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6864), "192.168.1.43", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6f035e3c-e958-4d3a-9070-5e86e36f1142"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer33", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6987), "192.168.1.85", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("704ba0ba-d944-43f0-b5c8-c8ae44e99868"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer5", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6820), "192.168.1.99", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("70d89a01-1bc0-47e4-a866-19547366539f"), new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6799), "192.168.1.58", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("71bd89b6-5066-48fb-9183-7510688390e5"), new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer29", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6956), "192.168.1.96", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("7201e5c8-0739-47df-89d9-04fd603c1caa"), new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6784), "192.168.1.65", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("75c64bd3-6176-421f-9da9-7da6e4d890dd"), new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer9", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6846), "192.168.1.97", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("79bad982-4009-4050-95be-63231b55040b"), new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer27", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6944), "192.168.1.79", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("7e03b402-6e3e-4d1f-8cc2-dd2fafe751ab"), new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer34", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6992), "192.168.1.90", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("81f2eb64-e9c1-48cc-96f0-975d35527d94"), new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer3", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6804), "192.168.1.49", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("84bf1bfa-83cf-413e-8ad0-89ea8c5c04eb"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer18", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6895), "192.168.1.44", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("86dbb7b0-5a0c-468f-8452-4a4fc70fd869"), new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer38", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(7013), "192.168.1.74", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("9204c3d1-2590-43af-b6bb-742532f6dfb3"), new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer17", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6891), "192.168.1.85", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("aa688324-d518-4b05-98dc-4772f2d7c84d"), new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer37", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(7007), "192.168.1.52", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("af24d961-9ae9-4c47-aa79-6403a2e8711f"), new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer12", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6859), "192.168.1.35", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("b757270d-50bf-431b-ad34-1f8e963f8e4b"), new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer19", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6900), "192.168.1.68", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("c09bf4c1-2221-4286-9b81-78758fe84a7e"), new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer7", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6834), "192.168.1.56", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("cc995ac8-0321-4ca6-860f-a305e0325245"), new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer8", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6840), "192.168.1.33", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("df0ae768-f0c6-4788-8277-2bf9a45d07d9"), new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer30", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6963), "192.168.1.46", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("df606e3c-a0f8-4d4f-bc41-73e182176fe3"), new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer16", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6886), "192.168.1.81", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("e0d57d8b-4aef-45c7-83fb-c2aea5041b28"), new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer28", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6950), "192.168.1.68", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e587c5b8-1968-416d-8b18-5f5dd3c3ddd0"), new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer10", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6850), "192.168.1.85", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e7c878c6-b7c7-48c1-be33-ecc431f17f42"), new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer39", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(7018), "192.168.1.95", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("eaafedca-d3f0-4fc3-b317-d854a4dcef55"), new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer25", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6934), "192.168.1.38", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ec9d20e0-97f6-4d95-8fd9-f6268c1dd56f"), new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer4", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6815), "192.168.1.49", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("f06f7b9f-07a5-44b1-9dd0-7430f2b87b51"), new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer35", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6997), "192.168.1.66", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f4908739-efe9-49f5-a05a-3f70b4015572"), new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer14", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6874), "192.168.1.96", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("fddc2bd2-c1fc-4c9a-b882-a7131d654022"), new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer36", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(7002), "192.168.1.81", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("fe03295a-a89b-4d63-941b-1f9d3fb17b10"), new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer15", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(6881), "192.168.1.87", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(7753));

            migrationBuilder.InsertData(
                table: "DiscontinuedStudents",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "StudentId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("d299271a-984d-44cb-96d2-eca5b7c7063a"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(7311), "192.168.1.72", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), null, null, null },
                    { new Guid("d3ecf483-2478-41fb-badc-fd407ab669e4"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(7330), "192.168.1.58", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ExamNumber", "Score", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("005a2e1f-0998-481a-9111-cf99644d805a"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(412), "192.168.1.17", (byte)2, 90.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("01344f6e-5c9a-42b6-976c-6001f0357985"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(699), "192.168.1.41", (byte)2, 79.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("01977125-9285-464d-ab8a-296178fa4cd1"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8570), "192.168.1.99", (byte)1, 34.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("0268cabc-08a8-48e4-bc30-3d7fb225dc76"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9186), "192.168.1.85", (byte)1, 65.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("029faf66-7c53-465d-97a9-35e18e62db3c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9591), "192.168.1.13", (byte)1, 3.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("032d2cf9-8632-46b2-b0ac-066e93a68505"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9038), "192.168.1.83", (byte)1, 79.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("0342650c-92a6-4996-a9ba-f752a8e6b085"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(825), "192.168.1.30", (byte)3, 88.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("040097df-b482-4e5e-844e-ed8c982933b7"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9399), "192.168.1.35", (byte)1, 11.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("0409ea95-9a3f-4582-b4d7-3c2e6039a448"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(374), "192.168.1.49", (byte)2, 8.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("0467dcd2-6575-49b3-ae26-2ffc0cd675bb"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8624), "192.168.1.28", (byte)1, 38.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("04ad93a6-05d0-4b34-8eb9-1471c6e304ae"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(122), "192.168.1.93", (byte)2, 2.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("04c28d80-bcdf-4234-8f99-e3bc7f1e9d70"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8733), "192.168.1.97", (byte)1, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("04f7a0e6-22db-4476-a528-6c45e44b396f"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(295), "192.168.1.55", (byte)2, 72.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("04fcaa12-d284-4411-8e1a-03f0a5a1628a"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9985), "192.168.1.23", (byte)2, 88.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("050258c1-6187-4220-9a55-25bf9493715a"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1645), "192.168.1.17", (byte)3, 54.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("05543f27-5d7d-4aee-9c16-5dbe1029290c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8777), "192.168.1.84", (byte)1, 74.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("059d2593-41ae-428a-9c31-7b204bf386ec"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1072), "192.168.1.85", (byte)3, 54.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("06041cba-2986-4e56-8e84-15b24da45280"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1393), "192.168.1.66", (byte)3, 43.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("0648274d-e400-4b71-acfd-8a18a8caf26d"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9416), "192.168.1.69", (byte)1, 63.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("06f5bb94-84af-43a4-b7b9-2cfa63fa10b1"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(23), "192.168.1.2", (byte)2, 37.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("072ad266-8a8b-49c3-8e07-3540b29db29d"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1590), "192.168.1.74", (byte)3, 91.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("073fd6bc-bbc0-4223-b3c1-d844073ecb1c"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1287), "192.168.1.61", (byte)3, 97.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("076e8dcc-f2bd-4b9a-b481-256991a5f118"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9878), "192.168.1.20", (byte)2, 2.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("07b24e69-5e3c-4a41-9ead-a0e2bcc658de"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(604), "192.168.1.3", (byte)2, 22.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("07f7b0b1-c5a1-4b1b-a403-dce628b9561e"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8600), "192.168.1.22", (byte)1, 9.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("080a95c0-b34d-4c84-8165-8ee48d829d0f"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9595), "192.168.1.2", (byte)1, 22.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("082a0416-cc14-48f7-9dd7-52e9a0d53d87"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8956), "192.168.1.61", (byte)1, 68.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("082a93eb-91b2-4132-ba07-3bd59388810c"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(164), "192.168.1.78", (byte)2, 0.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("08524867-c500-4884-adde-80b49bee8953"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(471), "192.168.1.27", (byte)2, 45.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("08aede67-462b-4a6e-ba0d-2f8efc41be19"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1304), "192.168.1.94", (byte)3, 44.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("08fb9482-4676-4bc9-a7c6-0d905aa46fcc"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1050), "192.168.1.19", (byte)3, 49.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("09afaf67-3a0a-4ae4-bcd0-9b0d3661beba"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9520), "192.168.1.39", (byte)1, 50.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("0a61b433-13b2-4d5c-80e7-69da5b2d1a4d"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(645), "192.168.1.24", (byte)2, 45.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("0aa93d29-10e2-4402-8e18-08bd1a7f5da4"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1068), "192.168.1.50", (byte)3, 7.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("0b5f99f0-0ea7-4f30-8fba-8647e77e753a"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1662), "192.168.1.96", (byte)3, 64.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("0b76825b-21c7-4eed-a8e8-0bdc4e7611fe"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9849), "192.168.1.86", (byte)2, 52.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("0bc38b46-0ac9-45dd-91bb-a14fae2fb02c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9362), "192.168.1.9", (byte)1, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("0be5ca95-428f-48d8-8d5d-7f4aba1a7058"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1064), "192.168.1.1", (byte)3, 82.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("0c2e058c-64e2-424f-8317-0b3fdbe4083c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8919), "192.168.1.18", (byte)1, 62.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("0c64955c-80f0-412f-a897-b1a5cf7fd277"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(291), "192.168.1.81", (byte)2, 9.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("0c9a3607-2738-49bd-a351-dda2ff94a828"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9635), "192.168.1.46", (byte)1, 91.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0cd0dcb0-66bf-4df5-8094-790e0fb116a0"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1658), "192.168.1.96", (byte)3, 15.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("0cd24fc7-fafe-4e24-94e4-a438138cbc99"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9480), "192.168.1.80", (byte)1, 11.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("0d1f38fc-3eac-49ea-b107-0ced2f62dcb6"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(802), "192.168.1.79", (byte)3, 80.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("0d22d351-777c-473c-8136-e878f8066d9c"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(242), "192.168.1.52", (byte)2, 69.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("0d37bb6d-fd8d-48b5-8ffd-6561d2f10d50"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1246), "192.168.1.29", (byte)3, 49.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("0d385800-a75a-4162-94c6-317280719250"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8524), "192.168.1.31", (byte)1, 51.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("0d5a796c-0a48-491e-93f4-77833333445e"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9628), "192.168.1.90", (byte)1, 26.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("0dd323a9-b5c6-4751-9303-2816a620a7b2"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8546), "192.168.1.48", (byte)1, 25.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("0df6361d-921e-4411-93b8-880929ebbd80"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1614), "192.168.1.43", (byte)3, 67.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("0e2023d6-47bd-4fd7-939e-c3e6a643eba5"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8991), "192.168.1.27", (byte)1, 95.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("0e5bdac3-3324-457d-b1cf-7b2a2f0bdf69"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1283), "192.168.1.92", (byte)3, 97.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("0e95078b-1e82-4e46-a451-bda12a45ede9"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9060), "192.168.1.89", (byte)1, 59.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("0ed2b858-ab65-4362-a66f-445f18f67a27"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9615), "192.168.1.95", (byte)1, 31.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("0f43f04e-bb39-48f4-ab3e-44afba0c99c6"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9484), "192.168.1.21", (byte)1, 5.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("1047c601-0463-4171-8949-1c01346176f4"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9015), "192.168.1.67", (byte)1, 70.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("104fd613-c63f-4b97-9414-0c59de471ed2"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9054), "192.168.1.57", (byte)1, 98.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("11168a6e-8da2-4ada-986e-7b84b29b6698"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(386), "192.168.1.3", (byte)2, 4.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("11abc6d9-2475-4327-8338-ed89d703fcdc"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9632), "192.168.1.86", (byte)1, 10.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("125b0a04-183a-411b-b72f-5c64b0bffa2b"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9174), "192.168.1.48", (byte)1, 4.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("1388e27a-c1b1-4cbb-91ef-96de96e5d88a"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1438), "192.168.1.65", (byte)3, 78.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("13ca7805-09ca-41f4-9a81-fbef30932ff3"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9755), "192.168.1.81", (byte)2, 9.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("13da51c9-09b1-4577-b694-1b5e0b04cb6d"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1429), "192.168.1.96", (byte)3, 37.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("147d9876-2809-4c34-a2d6-8899e55d22e9"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9661), "192.168.1.45", (byte)2, 80.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("14c9a00f-5bc5-463e-816e-d01253f9a6d2"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1545), "192.168.1.98", (byte)3, 75.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("14e660f6-71c0-41da-9ed1-b8dad38baf01"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1167), "192.168.1.38", (byte)3, 72.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("1567c775-45df-4da1-b1a1-f63dea784593"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1521), "192.168.1.42", (byte)3, 9.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("1581c438-8f95-467a-af5d-590d33d13149"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(89), "192.168.1.28", (byte)2, 92.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("15b9f0a6-67c0-475e-94c2-3dfe7906241a"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9897), "192.168.1.79", (byte)2, 54.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("166b20da-1877-408f-8bf5-89e49912b9c6"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9561), "192.168.1.67", (byte)1, 84.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("16971b5a-9ec1-4b7f-a534-40de585387d8"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1442), "192.168.1.24", (byte)3, 70.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("16d3f413-2ad8-4d14-b691-0fb05e4090d4"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9129), "192.168.1.57", (byte)1, 8.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("1767ed22-1f18-491f-9394-ba10383e56e5"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1134), "192.168.1.67", (byte)3, 82.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("182731a1-aa2a-41dc-894b-5294ea080d2f"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(695), "192.168.1.66", (byte)2, 36.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("18365a96-59d3-448e-b3ba-a51f14357040"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1707), "192.168.1.34", (byte)3, 62.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("18982ff3-8f8d-4b99-92e4-11ccdfa41204"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(641), "192.168.1.35", (byte)2, 49.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("191af12a-969f-4bc5-bfe3-bcf2c555b8a8"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9853), "192.168.1.68", (byte)2, 15.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("19a9bb3b-6cc7-489a-ae8c-f0bec2b3096e"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9994), "192.168.1.9", (byte)2, 16.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("1b1c1813-8451-44f8-9a6d-81d20f84d45b"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(209), "192.168.1.39", (byte)2, 52.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("1b21ed8b-d312-4eb0-b459-42dceb24eaa0"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9218), "192.168.1.76", (byte)1, 0.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("1b21f4c1-3487-431a-8f3a-5c58aec4ca36"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9466), "192.168.1.51", (byte)1, 76.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("1beab494-d291-4b22-83fd-8eeca5d83ac4"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9207), "192.168.1.74", (byte)1, 38.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("1c289acb-bb06-4711-bb3f-8131d200b570"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1406), "192.168.1.21", (byte)3, 83.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("1c3f171f-5c9c-4fac-a6c2-4a61655e43c2"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8707), "192.168.1.1", (byte)1, 86.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("1c40f4b0-0bec-474e-a3cc-94877e41fbbf"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1238), "192.168.1.48", (byte)3, 26.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("1c5d7497-3ee4-4b08-9c42-f0abd2a63b70"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(769), "192.168.1.88", (byte)3, 46.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("1d7457cb-83da-4d02-9b7e-e596ef854760"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9104), "192.168.1.61", (byte)1, 57.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("1d8515e7-e951-4e35-9f24-c14350aab435"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(972), "192.168.1.6", (byte)3, 30.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("1e21a512-afa9-49bb-9a18-254d6a73ea9d"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1500), "192.168.1.50", (byte)3, 75.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1ecb9966-b882-405e-ace9-829338306e9c"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(855), "192.168.1.69", (byte)3, 55.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("1fcabf44-399a-4ac4-aef3-7247b73650d2"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9572), "192.168.1.6", (byte)1, 95.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("1fd43674-a9d8-44c1-a7aa-c65685608d4f"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(528), "192.168.1.18", (byte)2, 70.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("1fff9ae9-f566-408b-8f1e-505a0b21385c"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1183), "192.168.1.62", (byte)3, 39.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("206b4471-8c3c-40b0-8ac8-6121797381ef"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1213), "192.168.1.98", (byte)3, 89.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("209ad185-d1e6-4b0e-ae70-cc515ddc964b"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(112), "192.168.1.32", (byte)2, 33.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("210b3710-9393-4f66-bac1-c67b249f4e8d"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9918), "192.168.1.80", (byte)2, 25.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("2159d85d-0de1-4097-b554-62e508ec19b5"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9730), "192.168.1.79", (byte)2, 36.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("221edc12-70e2-4656-ab09-fb78cfa3eaa4"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(39), "192.168.1.2", (byte)2, 86.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("2232374c-fa38-4d1a-9afa-29340f5b6cb0"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1262), "192.168.1.66", (byte)3, 57.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("2249cbe1-fc20-4e3b-b14d-4b70521d5d72"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1275), "192.168.1.8", (byte)3, 55.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("2268df3b-ba71-45a4-b86e-6472f22c268b"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1271), "192.168.1.65", (byte)3, 38.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("227490bd-ba91-48fd-9ff6-afa33e611adc"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8692), "192.168.1.9", (byte)1, 63.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("22957c93-45a8-4834-a967-a20593f5dccf"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9441), "192.168.1.12", (byte)1, 64.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("2317d0ec-9fd4-49a5-8562-83c09c0f5791"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(279), "192.168.1.78", (byte)2, 74.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("23af7c5e-2400-4a5a-a004-6da552b4e78f"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(682), "192.168.1.72", (byte)2, 42.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("23af80e8-d3d2-4409-a8b5-0b975161b5c1"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(993), "192.168.1.16", (byte)3, 5.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("23cfd387-a375-4628-93a8-fe995f610c32"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9112), "192.168.1.83", (byte)1, 13.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("24f74e19-8954-4972-be50-c8b3ad30c7b7"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(979), "192.168.1.17", (byte)3, 46.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("251cb860-435f-44b8-9545-b3410558ea6c"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(430), "192.168.1.47", (byte)2, 33.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("25969c3e-5349-48f3-bb22-b0cf3824f1ff"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9125), "192.168.1.83", (byte)1, 37.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("25b3ef1e-93d1-4854-8557-2acbf4b7b0d8"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(139), "192.168.1.1", (byte)2, 51.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("26e2b6d1-0366-4d05-aca1-bb1a67d61f96"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8946), "192.168.1.8", (byte)1, 32.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("26e93d44-4eca-476b-bfd4-73be53e1952f"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1529), "192.168.1.72", (byte)3, 64.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("278f255a-5d26-4f8b-9818-6affbceee7b9"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(859), "192.168.1.7", (byte)3, 86.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("27901579-9ab2-4948-a9cc-6dfe898906c4"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(308), "192.168.1.5", (byte)2, 0.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("27a30413-893c-4ae9-bfe5-b0a3aa3d1ee9"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8987), "192.168.1.91", (byte)1, 2.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("284598be-647c-472f-b344-394644e00081"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9269), "192.168.1.97", (byte)1, 45.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("284ff2d2-513c-4c74-a1c6-4d0f5846987f"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1631), "192.168.1.39", (byte)3, 79.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("2916a26e-51b0-48c2-acc4-bdb8701bfa0d"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1743), "192.168.1.55", (byte)3, 56.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("29694b8e-b3b9-4cb7-9242-7a539f5c8351"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9680), "192.168.1.78", (byte)2, 90.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("2a7083db-2509-44f7-8880-ad2c41cfdc9f"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8649), "192.168.1.20", (byte)1, 8.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("2a727d3c-de85-4630-8ab7-35244a67f23a"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8787), "192.168.1.18", (byte)1, 41.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("2aa90a08-a090-415e-85ff-0e54020e961a"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9512), "192.168.1.90", (byte)1, 98.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("2ab1e1e6-f885-4dd5-b864-a924ea25f2f2"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(64), "192.168.1.56", (byte)2, 23.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("2acd646a-6373-4a5d-b46c-f800134485a8"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(180), "192.168.1.55", (byte)2, 65.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2b9b0260-d8f3-44e1-9866-e1057cfe3d90"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9092), "192.168.1.42", (byte)1, 61.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("2ba4d9ac-7bcb-431f-8183-fe3f24851a0a"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1105), "192.168.1.84", (byte)3, 74.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("2c065cac-1a7a-4197-ae6e-0e39151bf957"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(835), "192.168.1.74", (byte)3, 94.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("2c09f7b4-9f2a-4c7b-9ac7-1130d5eabca3"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8725), "192.168.1.61", (byte)1, 51.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2c211932-eea6-4ba9-9c94-ae60ae4f0b48"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8998), "192.168.1.43", (byte)1, 31.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("2c3296c6-c5ec-4bb3-ba2e-c448ace0585c"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(250), "192.168.1.37", (byte)2, 63.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("2c420543-110f-41c5-a0f5-4eef5b44f10f"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8887), "192.168.1.73", (byte)1, 97.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("2c6afb0d-dc86-4288-ba9a-e69124872ab3"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1475), "192.168.1.59", (byte)3, 81.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("2cf70ecf-c6fe-432b-b3ee-0a65175c35b6"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1691), "192.168.1.10", (byte)3, 86.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("2d425d24-b08e-428c-ae09-2e3e9be122b8"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(143), "192.168.1.64", (byte)2, 18.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("2d496d9b-1a50-4347-908e-f99409de3ffb"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9618), "192.168.1.32", (byte)1, 87.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("2d5003f7-533f-4414-af7f-66f8a3792506"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8924), "192.168.1.1", (byte)1, 98.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2d6ec09c-ca62-4ced-a675-40b86adb28c8"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(843), "192.168.1.34", (byte)3, 87.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("2d7129da-2d46-4fbb-87fa-e25c3f6ae668"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1174), "192.168.1.73", (byte)3, 82.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("2dd4b32e-b219-4de2-b250-5a854cec92b0"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1146), "192.168.1.32", (byte)3, 50.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("2de6a569-877b-4386-a56a-67a7ac7bb64f"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8792), "192.168.1.7", (byte)1, 85.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("2ea9ff98-6a44-4f59-b3f5-a1094166c959"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(151), "192.168.1.52", (byte)2, 44.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("2ed6b736-6d0a-47ff-813d-f64d78a4e49b"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8762), "192.168.1.73", (byte)1, 83.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("2fc9f0d0-9413-4f6c-ab0e-df28ef98a474"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1170), "192.168.1.93", (byte)3, 76.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("308ca7af-f013-4176-9a95-7df12c5df4fa"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(147), "192.168.1.24", (byte)2, 43.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("30b5a0fe-f3f8-45d6-b72f-f7669a47952c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8929), "192.168.1.12", (byte)1, 37.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("31867e62-a215-4cb8-8381-02611ff868fb"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9358), "192.168.1.39", (byte)1, 29.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("31f1f492-79ea-4b09-9539-350e7f6795a9"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9346), "192.168.1.61", (byte)1, 52.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("323e995c-2b9e-41a8-8b73-856753f051b9"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(895), "192.168.1.11", (byte)3, 17.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("324eaabb-b397-4fce-9bff-1a8e3467e7de"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8994), "192.168.1.64", (byte)1, 69.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("324ed8f8-0e08-4b28-9f73-ea2f20ca9d11"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9981), "192.168.1.83", (byte)2, 83.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("3269ab01-5b48-49da-b0f7-f2ca1e0561e2"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8828), "192.168.1.1", (byte)1, 6.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("3374235f-847e-4201-8670-48ed78f7e3c4"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(47), "192.168.1.57", (byte)2, 27.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("3439cad3-90c9-4f8e-a666-babc7bad11a9"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9845), "192.168.1.42", (byte)2, 74.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("3590d080-a1b1-4ed0-8a53-c3e6e3f4fe1f"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(72), "192.168.1.30", (byte)2, 62.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("366e0b40-45ba-47f7-b756-13b5cc37e047"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1515), "192.168.1.39", (byte)3, 18.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("369a2a63-6a28-42c6-b9df-ecbef8573cae"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9178), "192.168.1.48", (byte)1, 37.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("36a82afa-7d53-42df-b76a-24f3816004a5"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(810), "192.168.1.40", (byte)3, 65.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("3717b5e1-4a9f-40fc-aa28-1ac1ef1abc1e"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(616), "192.168.1.90", (byte)2, 75.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("3833401c-16a8-483e-b518-1f589e0875cd"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1130), "192.168.1.18", (byte)3, 37.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("38e0abb3-d02d-4559-a438-d1858ad8dd0c"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9956), "192.168.1.12", (byte)2, 39.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("38e4c0ff-5bc7-43d3-af04-81fdb49318fd"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(989), "192.168.1.39", (byte)3, 63.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("39867ecd-9c36-46a0-9474-12e480f6fcce"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8633), "192.168.1.93", (byte)1, 19.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("39bc8298-4b81-49be-9989-243487b9e79c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9072), "192.168.1.61", (byte)1, 56.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("3a1624c4-0af8-4778-b9c4-64a9584e1426"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1101), "192.168.1.23", (byte)3, 49.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("3a46702c-10e2-4873-80c2-8f16b59b08ca"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(275), "192.168.1.89", (byte)2, 7.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("3a69ef8e-50e3-45e7-9a0f-1e450f11d971"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9408), "192.168.1.58", (byte)1, 39.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("3a82f4b9-3540-4117-8611-ef9252c5656f"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9222), "192.168.1.98", (byte)1, 62.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3a9e0fe5-e17c-4127-aeaf-080231aad069"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9934), "192.168.1.4", (byte)2, 92.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3ab8c51d-2f93-4968-82ef-ef3d3d8851a0"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1537), "192.168.1.54", (byte)3, 2.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("3b4bac64-32ed-48d3-9f5e-3c01a29c60eb"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(939), "192.168.1.17", (byte)3, 2.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("3b7112b9-1178-4ad1-9ce1-98a4e5babb21"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1577), "192.168.1.12", (byte)3, 32.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("3bf70c1e-ea51-40ba-b1fc-9645f6731d58"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9326), "192.168.1.31", (byte)1, 6.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("3c4552cd-b86e-4a6b-9a50-5845af91d26b"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9010), "192.168.1.32", (byte)1, 12.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("3c72fdd4-72ad-40bd-8e1d-ff5a368721f8"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1594), "192.168.1.23", (byte)3, 36.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("3cad1c84-8cbb-4b79-ad0d-edda7557829c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8729), "192.168.1.54", (byte)1, 7.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("3cce670d-3f71-4d14-8cd9-ae702f15cfda"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9657), "192.168.1.33", (byte)2, 79.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("3de28811-bd6a-438c-aa58-7d0dfb72c32b"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9780), "192.168.1.71", (byte)2, 89.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("3dfb1416-dc46-48a5-bad4-531f79dc95bd"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9240), "192.168.1.88", (byte)1, 92.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("3e28e662-bf8c-4cb3-975c-cc644e4faae5"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(898), "192.168.1.35", (byte)3, 95.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("3e554596-a939-4890-932c-728db45b41a4"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8802), "192.168.1.11", (byte)1, 69.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("3ec7c6b3-92fd-49a0-9239-36a1cec92531"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8537), "192.168.1.22", (byte)1, 30.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("3f27c49e-b65c-450a-a38a-bb5ba12a74b3"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1627), "192.168.1.63", (byte)3, 9.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3f2e3b45-8c69-4be5-a54a-d7cd9a5f67c0"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1410), "192.168.1.4", (byte)3, 33.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("4043c9e3-959e-463e-8178-1969ae4216ca"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9100), "192.168.1.47", (byte)1, 6.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("40d36bbb-210f-40a3-a765-9a270f408ddd"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1054), "192.168.1.14", (byte)3, 31.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("41022b36-d05f-4260-a485-3572743f5189"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(419), "192.168.1.79", (byte)2, 22.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("411e829b-8b67-4253-a166-e290c632a365"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8818), "192.168.1.11", (byte)1, 96.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("415551aa-3fbf-4a41-a5b3-16533ad50c6d"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1695), "192.168.1.96", (byte)3, 92.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("42872236-e317-4c42-91fd-9ee3b7878c4b"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9248), "192.168.1.47", (byte)1, 85.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("42cb101a-16d7-48dc-9209-30d23570325c"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(760), "192.168.1.11", (byte)3, 83.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("4341dd5e-02aa-42a0-bb17-bfc192454b4d"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8758), "192.168.1.46", (byte)1, 66.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("4426f856-a908-46d3-afc0-95798031a462"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(737), "192.168.1.74", (byte)3, 70.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("44a87037-c0d0-4b3b-81a2-41f2330281cd"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9379), "192.168.1.75", (byte)1, 68.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("44aa4627-b3eb-4d5c-b329-5697793f4031"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9557), "192.168.1.70", (byte)1, 76.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("44d0ba68-978e-4006-8d4d-be87898c0427"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1772), "192.168.1.23", (byte)3, 95.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("45cd6787-9358-4c44-9a4e-4d5aaf9b91cf"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(390), "192.168.1.3", (byte)2, 55.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("45f8c263-1e83-4091-8fc6-31d73576292a"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1202), "192.168.1.34", (byte)3, 66.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("46384671-fed4-4066-b1db-84b22242cf00"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1221), "192.168.1.33", (byte)3, 37.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("46896b73-4324-4166-a978-71e5fcdf97fb"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(105), "192.168.1.97", (byte)2, 78.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("4698c0b6-0a05-4ca7-84cf-42ee0350cf62"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9259), "192.168.1.48", (byte)1, 67.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("46b832b3-65f1-4d5c-af2d-3751cb730800"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(246), "192.168.1.42", (byte)2, 30.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("46c92e9f-eade-4576-9a85-9e1422af7308"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1058), "192.168.1.6", (byte)3, 84.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("46d46bee-da9f-41db-8884-2d3d35c32ab4"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(459), "192.168.1.98", (byte)2, 9.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("46e46236-c185-42dc-878b-1b02aaa3e00f"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1157), "192.168.1.72", (byte)3, 28.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("470e4ad2-62de-470f-98ac-6b8142943cf5"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(935), "192.168.1.27", (byte)3, 75.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("471db2d3-8e80-4a55-a832-f7457976177d"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1503), "192.168.1.12", (byte)3, 89.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("474cc113-6bb0-4f31-a6b2-ac88f7198d5a"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8565), "192.168.1.38", (byte)1, 43.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("479ba698-967b-4c6b-b2f2-301f3513f711"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8934), "192.168.1.70", (byte)1, 72.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("47cddd82-15ec-43d9-9484-011fd45c21c3"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9288), "192.168.1.43", (byte)1, 49.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("47f231e3-2cac-4a55-94f8-f8857e87c3bf"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8875), "192.168.1.3", (byte)1, 35.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("482a1668-e352-4c26-b093-104dcbfcad7b"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1179), "192.168.1.1", (byte)3, 52.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("48b025d4-4e82-4d97-8a84-94b0054003c5"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1507), "192.168.1.11", (byte)3, 57.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("49140f64-f7b7-428e-9404-62fee66c9e6b"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8574), "192.168.1.19", (byte)1, 58.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("49bc3138-e841-4700-8f66-60f6fe5c32ab"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1242), "192.168.1.31", (byte)3, 42.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("4a2dc413-fb36-43e0-92df-37d3b5c4ff04"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1602), "192.168.1.42", (byte)3, 85.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4b07eaa3-f748-4b1f-a94f-b48b8609193b"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1703), "192.168.1.47", (byte)3, 17.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("4b28507b-22ec-4ddd-8276-ae3c49aed902"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(168), "192.168.1.51", (byte)2, 44.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("4b313447-4128-44ac-b033-9f55dbcb286e"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(943), "192.168.1.55", (byte)3, 47.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("4b492551-7712-443c-8ed3-ce64b7b2c590"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1776), "192.168.1.2", (byte)3, 65.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("4b8b8749-0e46-4b84-8af3-9499b5de3711"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9404), "192.168.1.53", (byte)1, 54.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("4bb6f86d-de75-4618-af40-844783b3fab0"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8941), "192.168.1.79", (byte)1, 18.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("4c4ad495-ffab-4b63-82b7-405d6391096f"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9395), "192.168.1.1", (byte)1, 60.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("4c8d3314-ff83-444c-956c-199cdffbae06"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(674), "192.168.1.15", (byte)2, 86.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("4cfc2d53-dfe5-4a3b-96f8-a667b2978ff5"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(201), "192.168.1.69", (byte)2, 80.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("4cfca6de-f7b0-4d20-b81f-7973df822563"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(703), "192.168.1.5", (byte)2, 61.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4db0f942-e762-49c6-8e97-be5e5ef0313f"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(300), "192.168.1.56", (byte)2, 86.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("4e6fb20b-7012-4da0-8dd1-0e86910e6d87"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1562), "192.168.1.39", (byte)3, 44.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("4ea47e4f-5686-4cb9-a40a-0e51a4ce1bcb"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(517), "192.168.1.22", (byte)2, 62.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("4fb34070-dfb2-4c79-9757-54eaa8f20cfd"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1229), "192.168.1.81", (byte)3, 10.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("4fc2179f-8e21-4f18-a48b-c8c7d9e36746"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1610), "192.168.1.42", (byte)3, 60.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("4fd5d75a-7cec-4b32-989f-49792eb35b39"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(789), "192.168.1.30", (byte)3, 21.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("4fe57b7b-1cd3-490c-aa01-880ac69d5ead"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1209), "192.168.1.37", (byte)3, 75.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("500d6e6c-de47-4ae2-a7bd-af2a11e276f5"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1450), "192.168.1.32", (byte)3, 65.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("50195afc-de7c-4efa-a68a-c8d54144b723"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9901), "192.168.1.9", (byte)2, 62.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("503fc963-8c6f-4d38-8eab-84e6cb6d2c4c"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(715), "192.168.1.6", (byte)3, 93.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("5043b250-4620-44aa-bb17-f6421a5d8a8e"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9869), "192.168.1.74", (byte)2, 90.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("505c2286-422c-4ae0-ab1b-a56001af7b52"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(785), "192.168.1.62", (byte)3, 61.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("51412f2f-7cd2-48b8-aa58-179876cedf87"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(906), "192.168.1.49", (byte)3, 29.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("517e89c9-0a74-410b-b99b-262dbbea71dc"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(678), "192.168.1.1", (byte)2, 46.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("51f8db9e-a7fd-4743-b9b9-3f0abccc1cba"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1018), "192.168.1.44", (byte)3, 47.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("528d63b2-9624-46c3-b50a-44484c79a43a"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(320), "192.168.1.62", (byte)2, 98.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("529034f9-4446-42ec-9bc1-15064f24f4db"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9455), "192.168.1.18", (byte)1, 66.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("556284f3-8381-4e9d-b736-3d4cb8de597c"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(764), "192.168.1.16", (byte)3, 71.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("55e23574-d5af-4b44-979f-fa0368d6d06b"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9948), "192.168.1.77", (byte)2, 74.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("5612f43b-0be7-456e-8c6b-fa226d6b27b3"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1377), "192.168.1.9", (byte)3, 97.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("565e039a-8666-4d12-bdcf-25d6c52e98dc"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1120), "192.168.1.53", (byte)3, 12.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("57110262-dc95-4a9c-94d6-3716ae48f74a"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(406), "192.168.1.1", (byte)2, 69.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("5745ae8a-f031-463d-83a9-3e6e7ba2adf5"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9251), "192.168.1.54", (byte)1, 32.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("577ce9dd-98d9-40b5-a1cf-942b924fb3d2"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8608), "192.168.1.45", (byte)1, 30.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("57dc974d-32f5-4f12-addd-74e4fc4e9bd4"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(806), "192.168.1.7", (byte)3, 86.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("58262766-7c2a-454c-892d-380b6b4d6a2b"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8604), "192.168.1.66", (byte)1, 65.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("5864a208-4198-4c0f-9fd9-2c3517ab6fda"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(253), "192.168.1.12", (byte)2, 60.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("591d8535-b3a1-4420-8623-8b7ee44766fc"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9354), "192.168.1.97", (byte)1, 32.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("593ba590-3130-4277-8e2e-60979a41d853"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9292), "192.168.1.84", (byte)1, 24.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("594ea60a-0797-4bf8-981c-6840f583f9d7"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1619), "192.168.1.99", (byte)3, 47.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5ae5fbc2-24cb-4a89-88a9-1b583ad29320"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8891), "192.168.1.20", (byte)1, 15.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("5b1c7588-db51-4849-812e-708516239b7e"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1653), "192.168.1.88", (byte)3, 51.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("5b2d0e4b-1c8b-44a7-8c37-76499591272a"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8666), "192.168.1.99", (byte)1, 19.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("5b50470d-986a-445b-b6e8-276663a6029d"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1623), "192.168.1.79", (byte)3, 87.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("5b77333c-e432-4811-adb9-97f90ad192ba"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(928), "192.168.1.50", (byte)3, 71.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("5ba2cd12-16d0-4338-a8d0-97293b7d2e63"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(557), "192.168.1.91", (byte)2, 64.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("5bc23e82-b0ac-4446-9885-29991a5903c3"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9116), "192.168.1.91", (byte)1, 57.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("5bfbe944-f613-4324-b009-24d4a7e6552d"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(197), "192.168.1.2", (byte)2, 89.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("5ca51674-5a89-4f41-989f-2f61da29bfd4"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9149), "192.168.1.47", (byte)1, 65.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("5ca59354-34ab-49a5-8030-72ef0896bee6"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(60), "192.168.1.11", (byte)2, 63.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("5d479bd3-ebd2-425c-adb7-e559f0c92de6"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9938), "192.168.1.31", (byte)2, 6.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("5d4cd729-0b7d-4645-a71f-914012aa0b8e"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(813), "192.168.1.99", (byte)3, 31.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("5d52331d-44f3-4367-b031-a7dda8b87014"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8583), "192.168.1.45", (byte)1, 98.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("5e2d24fa-263a-4549-a94c-0b2ff08ed346"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1092), "192.168.1.72", (byte)3, 6.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("5e56410c-6fbe-40ec-806e-ed9863b3c4aa"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(875), "192.168.1.90", (byte)3, 7.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("5e65b0b9-b5ea-4c18-b901-c635545f2a76"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1586), "192.168.1.91", (byte)3, 49.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("5e7ca713-fe9a-4a7a-92f5-2046d22926f1"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8966), "192.168.1.81", (byte)1, 62.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("5ea4cdcf-2dbe-4050-82b7-50326d6551ba"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(952), "192.168.1.84", (byte)3, 84.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("5eaa676b-84bd-481f-ae61-3abeb1aee4f5"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(608), "192.168.1.27", (byte)2, 32.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("5ec15f0c-f1fe-408d-a1e4-e507a29df4cd"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8797), "192.168.1.28", (byte)1, 80.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("5eff6c01-41c7-44fa-b40f-032b11a951c7"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9735), "192.168.1.64", (byte)2, 57.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("5f410aaf-44c1-4926-bf16-7683f3551a55"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8867), "192.168.1.76", (byte)1, 72.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("5f761f4e-7b50-4886-9408-ae202ff77c98"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9035), "192.168.1.28", (byte)1, 46.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("5f7d80ca-0b96-4b00-9a8a-774b490630ac"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9042), "192.168.1.10", (byte)1, 96.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5fec9a0b-42b6-489b-a738-c40be04f57d0"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9145), "192.168.1.43", (byte)1, 43.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("600aa013-5613-41ba-8d3d-823d7a14d7d3"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9437), "192.168.1.31", (byte)1, 99.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("6079af71-e8db-427b-9717-436ae6e8c52c"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(488), "192.168.1.53", (byte)2, 57.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("6095154e-3f26-4cb6-9f26-0697bcae8540"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9458), "192.168.1.61", (byte)1, 33.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("60b2f45f-d095-409d-b1d4-df661db210d0"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1566), "192.168.1.12", (byte)3, 0.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("60c46e8a-7362-49d4-90d6-504b9956fcd6"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9697), "192.168.1.44", (byte)2, 68.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("60e5f39b-5419-44f0-946b-772316865ef7"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9236), "192.168.1.7", (byte)1, 27.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("6157afe7-d03d-47af-bdb7-8a4a4f1b57c0"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(691), "192.168.1.81", (byte)2, 92.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("6241fd20-e08c-42d1-8b66-a5f645e433d7"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9232), "192.168.1.2", (byte)1, 85.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("6277c5ee-3726-465d-827e-079dc8478c63"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(217), "192.168.1.70", (byte)2, 37.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("627ac3b0-f5ec-41a1-b1cb-9c004971ce88"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1569), "192.168.1.84", (byte)3, 27.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("629e469c-c3ae-4780-8676-9c45c355f511"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9447), "192.168.1.78", (byte)1, 8.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("62d99ffe-a4b0-44b1-94f5-abfc2d8eab55"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(821), "192.168.1.63", (byte)3, 16.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("630bf490-bdb1-4904-8c3e-b40de6c608d5"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8611), "192.168.1.68", (byte)1, 72.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("635c1dfd-7218-4f21-ae41-f9c9ab224ee9"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(740), "192.168.1.15", (byte)3, 15.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("638b3ce4-107f-4bda-be08-a2205c46a4f0"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1681), "192.168.1.76", (byte)3, 66.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("63b07889-6310-45d3-b977-249cec4ade3d"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1381), "192.168.1.56", (byte)3, 94.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("64b0aef4-58a1-440e-9213-1e5482c4e952"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(612), "192.168.1.58", (byte)2, 79.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("64e7fe5a-1c99-4b80-aa59-e0f11e2b8265"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8813), "192.168.1.36", (byte)1, 8.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("665a90f9-b9df-471e-b0f8-8bc75df6dd34"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9532), "192.168.1.52", (byte)1, 34.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("6721d95a-4da9-4b6a-bbbf-142b786dee14"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1027), "192.168.1.57", (byte)3, 41.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("674e5f66-680e-4fe0-b15a-bc3db242f445"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9893), "192.168.1.47", (byte)2, 44.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("67676f6e-c09d-4b6c-aae4-004031d8c273"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1267), "192.168.1.92", (byte)3, 5.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("682295f2-2b5d-4084-a082-328edb5db755"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1454), "192.168.1.1", (byte)3, 93.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("68f4adf5-1376-42a3-b4ec-41fc9fcc87f8"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1330), "192.168.1.67", (byte)3, 56.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("69c12b53-4e52-4b74-ae78-53516a9880b0"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(451), "192.168.1.33", (byte)2, 24.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("69c193a2-bd9b-43fb-8b3d-1eeb3c136fc7"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1005), "192.168.1.90", (byte)3, 60.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("6a92861d-5b78-4b5d-b6a0-922e105a10a5"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(184), "192.168.1.32", (byte)2, 32.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("6b762c64-632b-48d3-801a-2747b7b32084"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1389), "192.168.1.39", (byte)3, 98.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("6bf3095c-a6ca-47e3-86e3-55fa67613b5e"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(337), "192.168.1.16", (byte)2, 3.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("6c285146-6c3e-40f0-a780-4e59f1c1e9e6"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(394), "192.168.1.87", (byte)2, 71.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("6ccbc2de-a683-4944-aaf0-d21e52a92da6"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9068), "192.168.1.86", (byte)1, 38.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("6d24597b-69ce-4736-9bf3-88bca3ad838d"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9776), "192.168.1.53", (byte)2, 11.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("6d2c6f39-7353-49c5-bc40-83640609e5b9"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8717), "192.168.1.4", (byte)1, 78.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("6dc2d70f-9dd9-4761-bd80-6c87bf6b5bef"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(931), "192.168.1.39", (byte)3, 45.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("6de35932-e798-45ec-95cc-eb463e46244a"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9624), "192.168.1.55", (byte)1, 99.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6dedf9f0-3531-408d-ba32-b3905297402c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9524), "192.168.1.22", (byte)1, 27.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("6e03dc9e-fe57-4e73-ae52-21beae67e8a4"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9387), "192.168.1.52", (byte)1, 36.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("6e17395b-f2dc-4ba6-b1b7-85d2a8de59c4"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9836), "192.168.1.85", (byte)2, 90.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("6eb2ec4d-bb26-45bd-a21a-5cf12e5770a8"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1678), "192.168.1.23", (byte)3, 97.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("6fd0095d-4444-41de-93ea-2c1e149036f1"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8578), "192.168.1.24", (byte)1, 55.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("718be456-a753-40c4-a8c3-a34fcf261b2a"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9300), "192.168.1.3", (byte)1, 42.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("71e1da4b-666c-4522-9e82-3538ed6e637a"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(366), "192.168.1.11", (byte)2, 69.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("71e44329-480b-4557-9eec-a4c00edbc363"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(625), "192.168.1.95", (byte)2, 67.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("7256053a-5caf-4d83-827a-1acaed06fbd1"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(796), "192.168.1.79", (byte)3, 93.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("72cfaa67-745c-4861-a1c7-f270a3905ea6"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(205), "192.168.1.79", (byte)2, 59.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("72e8e1c1-7871-4f88-bf12-e5ceef781722"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(553), "192.168.1.51", (byte)2, 13.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("72efa750-0fd9-4df6-a240-77039579b53e"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1138), "192.168.1.64", (byte)3, 63.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7358ad44-2a6c-4467-84d5-3663e47ec165"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9133), "192.168.1.93", (byte)1, 51.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("736ef6dd-c39d-460d-8a63-a09ad88afd57"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(463), "192.168.1.80", (byte)2, 69.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("7372af0a-80a2-4ecc-bf5d-65d3a9cf3239"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1217), "192.168.1.60", (byte)3, 50.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("73e05ce6-bc53-49d9-920e-97d780cd2109"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1368), "192.168.1.48", (byte)3, 29.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("75635e2d-dd82-4e16-af4b-32a7320a95c0"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9383), "192.168.1.54", (byte)1, 55.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("75e4ea28-477f-47fd-8a5d-4ab7b12ed5e7"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9809), "192.168.1.26", (byte)2, 48.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("764e2eb9-1d6d-4d98-ac4c-5042b9c2ac97"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1291), "192.168.1.32", (byte)3, 74.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("76f80e4d-002a-44de-8183-2b8001ab88ae"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(333), "192.168.1.19", (byte)2, 76.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("7859ec00-3017-4e9b-9aca-afc98f2c2792"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(56), "192.168.1.73", (byte)2, 82.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7b671084-fdac-4bfc-859b-a6390bc8bb63"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8592), "192.168.1.24", (byte)1, 32.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("7b831c0e-0c02-432f-ba6a-eeaa1ac26dad"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9772), "192.168.1.56", (byte)2, 3.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("7b886d6e-9629-45e8-a7d9-9061fecbf03f"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(312), "192.168.1.59", (byte)2, 27.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("7b8dfa79-9a8d-4c01-947e-5d8cf70ca801"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1511), "192.168.1.26", (byte)3, 12.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("7bce436b-a958-4ceb-83b1-47014d227cd4"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1080), "192.168.1.18", (byte)3, 14.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("7c96f70a-ff82-4eb2-bedf-1c798cce0e53"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(847), "192.168.1.89", (byte)3, 20.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("7caa917c-4aea-42e3-9a31-3a0b9dc6d146"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1533), "192.168.1.29", (byte)3, 71.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("7d00a996-af4f-4279-8b44-25a8d28080fe"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9960), "192.168.1.28", (byte)2, 22.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7d7b1d6c-7d0b-4c4c-a1a3-0d8588eab6b4"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9166), "192.168.1.13", (byte)1, 21.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7d930025-239b-41c1-b3ac-fdf2c2b26984"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9910), "192.168.1.11", (byte)2, 21.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("7df2edbe-fe3c-493f-b550-c1c42c812e8f"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9474), "192.168.1.85", (byte)1, 12.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("7e861377-1c66-4530-a646-c57dd4d8cd58"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9075), "192.168.1.33", (byte)1, 1.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7ef0a97b-921b-408d-84ab-9abe791fff3c"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(532), "192.168.1.9", (byte)2, 82.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("7ef0ce73-8948-4dca-ac80-dbe06ca7ac18"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1088), "192.168.1.54", (byte)3, 4.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("7f8ec592-c7d5-402b-8459-8dbdf18a3d93"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(829), "192.168.1.30", (byte)3, 1.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("7fe95386-8d03-477b-8d68-14e3f8cd525c"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(131), "192.168.1.89", (byte)2, 65.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("80924487-bbb8-4cd4-9205-3dd7b409f158"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8961), "192.168.1.73", (byte)1, 20.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("815279fe-bfd5-4e17-9051-5509da8dc559"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(744), "192.168.1.97", (byte)3, 1.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("81c81c00-25f0-4236-b987-184ba4d5859a"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(31), "192.168.1.93", (byte)2, 97.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("81fa86a8-988a-450a-96db-aa3de1c2e50d"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(748), "192.168.1.42", (byte)3, 23.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8203bde3-2b92-4f6f-92c0-74838edaf8c6"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(773), "192.168.1.48", (byte)3, 30.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("8237f616-0428-4fef-adb7-739569ac4a68"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9366), "192.168.1.94", (byte)1, 71.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("8279a350-610b-4eea-a7f2-91676421f1e6"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(507), "192.168.1.80", (byte)2, 36.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("82a2f924-583e-413f-827f-67d7e2fd74f5"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(172), "192.168.1.4", (byte)2, 6.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("82ab2f09-c6dd-4095-a591-f87703985a11"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(924), "192.168.1.32", (byte)3, 35.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("831d4d94-8a92-45fb-9704-f0f9a8ef2f01"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8658), "192.168.1.6", (byte)1, 4.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("83324268-933f-488f-ab8e-d2b9f6559ddc"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(662), "192.168.1.4", (byte)2, 68.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("834be243-26e3-4550-b43f-72c0d8977959"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(84), "192.168.1.85", (byte)2, 55.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("83c8ced0-46b5-44fe-907b-87f47fa326d9"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(869), "192.168.1.3", (byte)3, 90.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("84d5456d-2a9a-4573-b2fc-32f154f7a0bd"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(361), "192.168.1.96", (byte)2, 24.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("84ef2951-bf62-4e73-896c-11ed45242383"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(600), "192.168.1.59", (byte)2, 46.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("84fe108b-5b09-4381-8fb5-ebf0b6e3da9a"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1142), "192.168.1.4", (byte)3, 71.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("85379a95-a3b2-42f8-a402-8eb52afdf702"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(345), "192.168.1.87", (byte)2, 71.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("853f7f3f-259d-4c6e-95e1-dd45d81ef9a4"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9318), "192.168.1.20", (byte)1, 42.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("85d0a921-94fb-432f-a65b-21a23e94f937"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9861), "192.168.1.46", (byte)2, 20.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("86328074-4127-4ab5-8137-1c061e46f38e"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1769), "192.168.1.70", (byte)3, 93.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("86e62dee-65a9-492c-9fbc-d66eee9b8ec6"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(213), "192.168.1.95", (byte)2, 13.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("87347349-2558-4bcf-b371-aec1c79ab38e"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1719), "192.168.1.22", (byte)3, 41.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8746551d-3224-4d5a-9968-4ead4df73e0a"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(513), "192.168.1.23", (byte)2, 12.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("875bd5e1-2ed4-43d8-af9c-6239cb6f7039"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8596), "192.168.1.15", (byte)1, 27.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("87d02dd2-9c8b-43f1-8c42-356deec8d030"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(496), "192.168.1.43", (byte)2, 4.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("88a308d4-90c7-4b14-91f4-0a12793c3862"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9030), "192.168.1.97", (byte)1, 87.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("88a695a9-d16e-453f-8c3f-37e0e5ebedaf"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1765), "192.168.1.63", (byte)3, 76.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("88c6c202-1aa0-4613-8f93-9e29de81d69d"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9096), "192.168.1.92", (byte)1, 46.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("88d57855-d65f-4518-ac61-c2ef7c4771df"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9914), "192.168.1.79", (byte)2, 93.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("88f238b4-4724-4f2f-a029-46e2071cadcb"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8670), "192.168.1.75", (byte)1, 48.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("89062ccd-7ebc-47ea-a384-cb27c2a01272"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(447), "192.168.1.52", (byte)2, 51.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("8b3e2d32-cdb3-4c87-8dfd-b319ac3aaab1"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(328), "192.168.1.1", (byte)2, 54.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("8b622427-e54d-4108-a417-5680345ac563"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9889), "192.168.1.20", (byte)2, 7.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("8c30423e-6e44-4823-b89b-cbdab07d45a6"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(93), "192.168.1.1", (byte)2, 57.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("8c392d55-05b0-4bae-a8de-cb1d4df4fccf"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9603), "192.168.1.71", (byte)1, 24.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("8cd0ef26-b20d-4898-af7d-a31200a09138"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(910), "192.168.1.29", (byte)3, 80.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("8da4623a-1e3a-4b91-bce7-319c1b8e6848"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9763), "192.168.1.41", (byte)2, 80.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8dfb7c84-5474-42b4-8c10-efcfc2ef3652"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9684), "192.168.1.53", (byte)2, 30.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("8dfcac9c-81c5-4933-8eba-2f7e86d49c70"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1364), "192.168.1.81", (byte)3, 73.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("8e95b293-fe29-4507-b9e9-643e461a4b7e"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(35), "192.168.1.28", (byte)2, 50.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8ebd1823-3b9e-47ce-854c-ab30f83921a4"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8628), "192.168.1.9", (byte)1, 0.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("8ebdd030-697d-4de5-bf9d-0321996ed84c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9190), "192.168.1.62", (byte)1, 41.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("8f9d5c94-8b44-406d-a17c-28f0d69fe0bb"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9343), "192.168.1.17", (byte)1, 37.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("8fbbc256-9d76-4c94-91e5-81ac49cbc78f"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1761), "192.168.1.88", (byte)3, 28.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("8fcbb146-1275-476a-b633-622321e9971c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9079), "192.168.1.52", (byte)1, 4.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("90ae31fe-15d5-4fdd-be53-b0a6f19a0fb2"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8554), "192.168.1.48", (byte)1, 7.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("90e27c08-1592-4c06-913b-d033be9eba5b"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(633), "192.168.1.41", (byte)2, 75.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("915fdf02-7e6a-4ce3-855d-7c38963a681b"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(378), "192.168.1.52", (byte)2, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("9170cfdd-d949-4a5d-8bdf-e78e7c3dce0e"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8645), "192.168.1.32", (byte)1, 72.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("91e59825-cc8e-44a9-b70c-83bb035203b8"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9805), "192.168.1.17", (byte)2, 9.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("92455c03-efb1-49d6-a657-1c923d7256bc"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9182), "192.168.1.62", (byte)1, 64.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("927e829b-93a3-4884-a1fc-1f882e56d418"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9832), "192.168.1.19", (byte)2, 48.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("92b048e0-2bcb-4ca9-bd19-7dfb3e00a7e8"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1606), "192.168.1.78", (byte)3, 98.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("93356b15-55df-4888-9743-58ce53dfd0e8"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1649), "192.168.1.51", (byte)3, 87.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("93ad3382-6e1a-4702-a9e4-665754e6d669"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(283), "192.168.1.2", (byte)2, 99.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("944380b9-c464-45ce-be9a-64ff04796a06"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1254), "192.168.1.74", (byte)3, 94.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("9494eb32-3e7f-4a6c-9696-2d1da91682be"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8871), "192.168.1.94", (byte)1, 6.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("94e93980-9613-4669-8d4c-92357b12cdfa"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1295), "192.168.1.3", (byte)3, 76.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("94ef4331-dc58-48d7-a28b-d09b560f1368"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1076), "192.168.1.30", (byte)3, 33.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("954d4a1b-0b5a-4003-b9f6-59a2cea55a6a"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(341), "192.168.1.1", (byte)2, 82.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9592ece9-1774-4bc8-ad58-aec7a6260020"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9215), "192.168.1.75", (byte)1, 92.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("9604317c-5745-4906-8f9b-bc750bd9beee"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(155), "192.168.1.29", (byte)2, 48.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("9627f758-e86a-481c-89d5-1ee901ab3039"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(259), "192.168.1.13", (byte)2, 65.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("9636ca15-b9e8-4049-83e6-4651e3daca1a"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1525), "192.168.1.50", (byte)3, 48.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("9666a409-c671-4308-81a8-ec67b74f218e"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8904), "192.168.1.50", (byte)1, 28.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("9768736d-e05d-4bdc-9a5f-e86d047c88ed"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1047), "192.168.1.81", (byte)3, 80.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("9775cbaf-cbe5-40f9-8d66-401ebbcbf7ca"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1385), "192.168.1.17", (byte)3, 25.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("97daf3ba-85c4-4575-9911-6c7331f46716"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8971), "192.168.1.28", (byte)1, 72.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("982a780e-6762-44d0-99cd-decbf493b177"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1400), "192.168.1.13", (byte)3, 45.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("983102cc-8c6b-4e41-a3e0-a188d8e4d531"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8754), "192.168.1.76", (byte)1, 8.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("9851fe23-aeaa-44de-b292-7e8f0bf5700d"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(540), "192.168.1.75", (byte)2, 32.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("985b72f0-e4e7-4d0a-a123-68aa37311df7"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1466), "192.168.1.76", (byte)3, 31.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("989c96aa-d63e-41a5-98e1-82c4682b942c"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1032), "192.168.1.31", (byte)3, 59.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("98acd448-8479-41f5-8314-347cf0c06f41"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(14), "192.168.1.37", (byte)2, 92.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("98b4d550-0eb9-4289-9714-80bcbb9149bb"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8909), "192.168.1.49", (byte)1, 18.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("98db00b2-2dca-4c6a-abc8-c0d7fbe71d65"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9137), "192.168.1.6", (byte)1, 73.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("9934f0c6-7f7f-4828-9e42-b068de95f92c"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(455), "192.168.1.81", (byte)2, 72.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("99c97b00-e6c0-4a1c-a2dc-3c26049434fd"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(520), "192.168.1.48", (byte)2, 39.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9a50d505-0afd-4f74-9e0f-d90beb67b616"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9375), "192.168.1.41", (byte)1, 23.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("9a9525a3-9ea5-496c-b6fe-c9c128041ef7"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9922), "192.168.1.62", (byte)2, 45.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("9abebe8f-21a6-422b-af60-25acbed0d3cf"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9743), "192.168.1.16", (byte)2, 55.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("9af3de6b-8836-4451-b65c-600da31ccfab"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(370), "192.168.1.66", (byte)2, 86.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("9afad860-cd78-4f0e-a616-cda2a8a95542"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9759), "192.168.1.3", (byte)2, 47.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("9b19453d-47f4-4393-8d65-aace1104d80b"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9423), "192.168.1.41", (byte)1, 30.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("9b222780-f8c9-4fb9-978f-b5f43587dfad"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(851), "192.168.1.44", (byte)3, 63.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("9b8ad650-a25b-490b-9861-b35a77181570"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9639), "192.168.1.53", (byte)1, 38.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("9bb7989c-1b39-4f64-98a7-d48c72380974"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1300), "192.168.1.67", (byte)3, 25.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("9bb8a3c1-8401-41eb-acb4-e1b3613e2f6c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9083), "192.168.1.14", (byte)1, 12.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("9c1721c9-7439-432e-b01d-e0ff15b7efe2"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1352), "192.168.1.33", (byte)3, 15.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("9c18ed69-5f85-4baa-a10b-2534fff0e289"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1641), "192.168.1.84", (byte)3, 5.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("9c241eed-7353-455a-8888-cf5ee83db455"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1554), "192.168.1.50", (byte)3, 56.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("9d268bd8-bd76-4dd6-8dca-fa44336e0530"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(947), "192.168.1.42", (byte)3, 43.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("9d57392e-4dc3-4253-a3f8-ff0ac962ba08"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9788), "192.168.1.34", (byte)2, 47.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("9da1e692-ba8e-4d92-b0cd-66db6b5b3c27"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(914), "192.168.1.71", (byte)3, 4.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("9dd42198-6a94-4f24-af1a-9ef6ba70ac5d"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(304), "192.168.1.72", (byte)2, 44.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9e45b883-5bb8-4f24-b039-298777bba486"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9503), "192.168.1.82", (byte)1, 40.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("9e6324b9-9d92-4525-8125-c794751435bb"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(666), "192.168.1.37", (byte)2, 20.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("9e684d74-9cae-4c54-93e3-e4b2ceb832ca"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9339), "192.168.1.18", (byte)1, 9.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("9e9b6a42-ce45-4481-9b2c-531bbd8c2cab"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9705), "192.168.1.83", (byte)2, 48.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("9eee6e08-e230-4ecd-a15a-63bfc55b2a8a"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9329), "192.168.1.82", (byte)1, 21.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("9f4a7109-7126-4f48-9309-e2e56e7ff756"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(629), "192.168.1.71", (byte)2, 71.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("9f4e3344-88a4-413c-8eec-2444ac25fb8d"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9930), "192.168.1.51", (byte)2, 11.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("a030774e-033c-4bb7-8e0d-c65ca8e1c85e"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(2), "192.168.1.10", (byte)2, 90.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a0b94bac-8669-4ea4-9e48-d2e87349a8e7"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(480), "192.168.1.52", (byte)2, 93.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("a0f14cb5-cae9-4a65-8479-a304c741db9d"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(549), "192.168.1.51", (byte)2, 22.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("a12b09e1-4706-4a93-903c-4fcec38058d4"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9006), "192.168.1.92", (byte)1, 60.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("a1a32aa8-0a14-458d-9f2f-ba4dc1fe595c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9087), "192.168.1.98", (byte)1, 42.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("a227f8ff-a48e-42a3-bcdf-3ecb720c93f2"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(777), "192.168.1.77", (byte)3, 12.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("a2e7143f-0b27-45ee-94bc-e6505d4702ce"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1666), "192.168.1.12", (byte)3, 45.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("a38441cf-f078-472c-8b99-0eaafa9e4701"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9314), "192.168.1.13", (byte)1, 95.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a3a08d1e-297a-43a9-bf43-42e5e726572a"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1446), "192.168.1.71", (byte)3, 31.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a3fae462-f4e1-4b5d-8388-a85e3da03648"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1163), "192.168.1.45", (byte)3, 55.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("a44766e2-4558-4ea3-b698-590c0f47643c"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(18), "192.168.1.46", (byte)2, 61.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a470c3e4-1f6c-4c9e-b43a-ced2d293ce39"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1234), "192.168.1.25", (byte)3, 57.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a4854d07-cbf4-46e7-b480-3e5ee2c4f8c0"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(160), "192.168.1.7", (byte)2, 81.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a4b5d02e-4ba8-495e-916e-2a93fd5a92c1"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1356), "192.168.1.76", (byte)3, 3.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("a4c6816e-61de-470f-afad-bd07b2265e07"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8616), "192.168.1.1", (byte)1, 72.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a50d32e3-4cac-438b-a8d9-fed63b1e9c3f"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(503), "192.168.1.94", (byte)2, 3.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("a53ac5c6-4f3a-4ed1-8f8c-38a3ce050204"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1109), "192.168.1.28", (byte)3, 60.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("a5508707-b0ea-4d4d-b73b-67a2ad9b7fe6"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(920), "192.168.1.11", (byte)3, 97.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("a5dea436-d5ef-48dd-a2f6-77ab4014b329"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(707), "192.168.1.82", (byte)2, 77.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("a66e9b67-bde5-4997-8241-7423c9172fa5"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1736), "192.168.1.69", (byte)3, 43.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("a6a2ea74-a473-4996-9acf-e2ffa18d996c"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(960), "192.168.1.61", (byte)3, 81.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("a7262402-2f8a-4748-a0a6-aa4f49fa6d20"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(442), "192.168.1.61", (byte)2, 38.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("a7da3807-7e0f-40e2-adde-3cf0e7aba5d5"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8766), "192.168.1.14", (byte)1, 26.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("a89fb272-a846-484c-8236-50d3921060ca"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9120), "192.168.1.86", (byte)1, 3.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a8bc532a-5e22-40bf-a6bb-597685fdb4ac"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1308), "192.168.1.53", (byte)3, 4.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("a9139e9b-2d8c-4019-99f4-e365079fb367"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(467), "192.168.1.66", (byte)2, 23.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("a938da27-b31f-4857-9162-4a2e73e897ce"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1250), "192.168.1.39", (byte)3, 9.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("a9b62e16-d0a3-497b-a7bc-5930d36275cf"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(956), "192.168.1.24", (byte)3, 92.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("a9cea159-5a4b-4f2c-ae44-717a5b3cd864"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9002), "192.168.1.48", (byte)1, 64.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("aa0d196b-e389-42e2-865f-40a2b7053bb2"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1084), "192.168.1.71", (byte)3, 3.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("aad19d3d-2928-44d7-9dd5-820f33ce86e7"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9170), "192.168.1.53", (byte)1, 60.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("ab0ead88-b6cd-400c-9769-9ae6d8d6e971"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(756), "192.168.1.90", (byte)3, 66.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ab100a3d-6d98-4fba-8d5b-dbfcb01e10d2"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9371), "192.168.1.92", (byte)1, 55.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("ab10457e-989e-4c99-9bab-7983aed6eced"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1421), "192.168.1.92", (byte)3, 32.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("ab4f58a7-4594-4252-90db-ced6adbda0c8"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(10), "192.168.1.73", (byte)2, 5.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("ab7f14b6-c13f-4775-b828-b4c975d1672d"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1279), "192.168.1.38", (byte)3, 13.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("ab91dfb5-de31-4eaf-9b86-faa074a637a7"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1548), "192.168.1.36", (byte)3, 18.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("ab9b98b6-9b46-4cf6-b22e-b103e1ce29d5"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1747), "192.168.1.61", (byte)3, 94.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ac1e32ba-fe13-40b3-a4fe-682168f0bbff"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(500), "192.168.1.14", (byte)2, 69.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("ac251fe3-89ba-4cea-99f2-11d369ebc891"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(484), "192.168.1.73", (byte)2, 83.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("acb4d453-df5c-4ec6-8a50-9a0aa2e52fa4"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1340), "192.168.1.26", (byte)3, 67.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("acc4dd21-9ebc-49d5-8ca1-b2339c966efa"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9540), "192.168.1.21", (byte)1, 30.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("ace27f2f-5443-492d-ab53-2554efefe0a7"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9297), "192.168.1.36", (byte)1, 72.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("ad535c59-d6bc-4497-900b-33e5bd0f4697"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(324), "192.168.1.76", (byte)2, 12.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ad779ed4-cb6c-4694-8925-b0bdd6c06a35"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(839), "192.168.1.8", (byte)3, 71.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("adb99a32-249f-49d9-a595-c2d736556023"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8686), "192.168.1.19", (byte)1, 19.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("aec29400-0a60-4c9c-aa96-88899c64d2f8"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1541), "192.168.1.29", (byte)3, 50.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("aedc3422-896a-4d33-ae58-945f0eefe435"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9905), "192.168.1.68", (byte)2, 44.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("afd39e09-5280-4dcb-98f6-6dc1dfd3bdc5"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(238), "192.168.1.10", (byte)2, 55.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("b06fd17f-3c4f-45c6-9987-019bc31c030b"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9516), "192.168.1.35", (byte)1, 16.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("b0efb93d-bbfa-4ed2-8bb7-cc4ad9661333"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9495), "192.168.1.25", (byte)1, 47.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("b147d8b2-1fc7-47db-8f04-6fd52683610d"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9226), "192.168.1.87", (byte)1, 28.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("b1e968ee-09f3-4581-8358-c27669a28999"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9310), "192.168.1.46", (byte)1, 35.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b20e224d-80fa-4c07-a87a-605d91da14c0"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1023), "192.168.1.19", (byte)3, 59.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("b2220027-0b1f-46ef-8f68-0afb55f31f8c"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(287), "192.168.1.33", (byte)2, 81.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b23cea1c-3d2c-4389-8daa-b845d9edb316"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9944), "192.168.1.6", (byte)2, 3.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("b28365db-a862-4cd1-8068-28b8e87b555d"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(561), "192.168.1.33", (byte)2, 35.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("b2e46528-a5fa-494c-b7e1-02f7b326c437"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9277), "192.168.1.66", (byte)1, 63.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("b3042815-89ae-4b88-bc91-22c6c198a3f5"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(536), "192.168.1.98", (byte)2, 47.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("b309242c-92fd-4d2e-8e38-aa539c0b5b92"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(176), "192.168.1.2", (byte)2, 8.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b31a15c3-ac77-4e40-b770-40128ac39268"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9857), "192.168.1.37", (byte)2, 72.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("b369aeb8-fe4a-4507-8842-9c0b55948595"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1417), "192.168.1.36", (byte)3, 34.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("b401ef48-a4b9-47ff-99bd-4d3ee5a115a1"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(193), "192.168.1.1", (byte)2, 49.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b439ea0e-e62e-45ff-942e-6a9c4b78b1b5"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1724), "192.168.1.87", (byte)3, 48.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("b59e2f63-c0cf-4fba-8fc5-b59bd4e7d0ea"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(101), "192.168.1.32", (byte)2, 43.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("b61d365b-0713-4984-a0be-0f56c7b87b15"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1715), "192.168.1.32", (byte)3, 44.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("b687d7e5-ed22-450b-b157-24d1f27c46c1"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9470), "192.168.1.82", (byte)1, 42.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("b68a83d8-35ef-48b2-9a2d-1ffc42907b14"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8879), "192.168.1.93", (byte)1, 84.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("b701e4b9-9971-4172-9e7b-508039e65d60"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9952), "192.168.1.50", (byte)2, 37.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("b7257252-52a4-4a42-ad50-bb6afc1514b9"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8738), "192.168.1.6", (byte)1, 48.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b76e58be-907b-45c5-b63c-05d17c1e6df8"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1348), "192.168.1.26", (byte)3, 11.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("b81d7f31-e427-4f5d-a0dd-5021df46f27c"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(234), "192.168.1.90", (byte)2, 54.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("b845cb9a-a7ee-445d-b824-ee6405f36073"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9926), "192.168.1.19", (byte)2, 43.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("babc39c9-755d-46df-8dc3-93ce6e18a64f"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1740), "192.168.1.40", (byte)3, 87.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("bb2c5570-f58d-4889-a68f-89ca6bc263b5"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9333), "192.168.1.75", (byte)1, 91.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("bba5693b-17b6-4e3b-b27c-517ae366f05d"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(80), "192.168.1.71", (byte)2, 22.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("bbaa4906-2f1f-4b40-877a-715d82537b99"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(711), "192.168.1.59", (byte)3, 1.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("bbfb2c8a-9337-407e-9bde-f1c0c3a5a563"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9528), "192.168.1.99", (byte)1, 34.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("bc2b6017-bca3-4c5b-9cd7-3f3dc0994006"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1462), "192.168.1.66", (byte)3, 51.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("bcb5fd62-e2fa-48fd-bfa0-5befbf8b3cef"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(879), "192.168.1.42", (byte)3, 6.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("bce3f097-bb5f-430c-964d-74df7eb1f673"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1258), "192.168.1.64", (byte)3, 69.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("bceaed8d-ca38-43b8-8cb3-a3acc1d45f86"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1396), "192.168.1.86", (byte)3, 2.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("bdc2ad68-5e85-4096-bcc4-a2b457c42467"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(781), "192.168.1.34", (byte)3, 22.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("bde07fe1-ccc7-4816-be5f-53104b176060"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1013), "192.168.1.75", (byte)3, 25.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("bec1fcbf-fcd3-4294-a596-2d140cd5a97f"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8895), "192.168.1.64", (byte)1, 7.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c12a9517-271d-49bc-bf93-66cfeada5e19"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(230), "192.168.1.63", (byte)2, 25.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c1ae0e39-95a6-40a6-9de1-0d2df01672ce"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9549), "192.168.1.56", (byte)1, 27.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("c278ebbd-810f-4a90-b576-97d337e2f522"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1225), "192.168.1.41", (byte)3, 17.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c2ee792c-cc40-4370-97f4-1b911ccd88b3"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(68), "192.168.1.97", (byte)2, 70.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c3611092-ec5b-4909-96be-aad3ae5f96ec"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9751), "192.168.1.80", (byte)2, 53.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("c36b114c-9574-4f7f-86e6-52066564dcde"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9739), "192.168.1.94", (byte)2, 3.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("c3e60715-766d-47c7-b87b-93154ab60983"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1496), "192.168.1.39", (byte)3, 57.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("c463115c-3345-4559-a2ca-5bea96de92e3"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9412), "192.168.1.91", (byte)1, 86.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c4753d20-016b-446b-99cc-ecb5ea6ef6b0"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(792), "192.168.1.63", (byte)3, 52.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("c4c83eb2-6af8-49a7-8059-1544e42faf67"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(658), "192.168.1.4", (byte)2, 44.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c4e3fb02-e063-4751-9362-522efde6883e"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8662), "192.168.1.97", (byte)1, 27.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c4e6e71d-7f74-41f2-b32e-07112ff38ffd"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9701), "192.168.1.75", (byte)2, 8.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("c4ebebcf-8034-4828-9249-e537e5d5e483"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(589), "192.168.1.41", (byte)2, 67.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c66adefc-486c-4f0a-aaad-5ca764bc44a1"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9709), "192.168.1.3", (byte)2, 83.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("c67241b3-df73-4bc4-b65b-2a4257f4c99c"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1124), "192.168.1.88", (byte)3, 22.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c68d5763-cf17-4e21-adc1-5b9a0fc3a8f6"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8843), "192.168.1.44", (byte)1, 58.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("c6f6e17f-bf97-4562-ba39-435d6ee67b05"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8678), "192.168.1.9", (byte)1, 64.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c745d324-69f4-478c-ba92-0189d3040a5c"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(271), "192.168.1.98", (byte)2, 6.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("c7bb347c-7ce8-4b67-b72f-a4f51fe3186b"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1598), "192.168.1.34", (byte)3, 98.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("c7c760d6-2f44-4c82-98e4-f5e6f45bd047"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9977), "192.168.1.66", (byte)2, 29.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c860ee7a-d3a1-4a41-96ad-43a144219c6a"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1113), "192.168.1.80", (byte)3, 91.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("c8637a39-7661-4ee2-9ddd-bc72c8b431b6"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8862), "192.168.1.51", (byte)1, 42.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("c89b4be6-024e-430c-9981-8a1e6245dcac"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(475), "192.168.1.56", (byte)2, 57.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("c926fb7f-1c03-4c5b-b023-c17417a2acf6"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9873), "192.168.1.65", (byte)2, 3.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("c97cfe45-6eb3-4552-b06b-d6ce0f906842"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9865), "192.168.1.93", (byte)2, 14.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ca1ff2a0-47b3-44d5-975e-b0c454d3007e"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9108), "192.168.1.76", (byte)1, 59.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("ca91865d-eff8-406f-8c5b-a5cc7126ab9f"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8674), "192.168.1.90", (byte)1, 99.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("ca9b7b5e-82e2-4fd2-aab1-07320bc481c6"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1425), "192.168.1.44", (byte)3, 99.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("ca9eb0a2-20e4-4a36-a664-42eae5938923"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(968), "192.168.1.54", (byte)3, 13.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("caaa72ba-9bb1-4c6e-be43-38e3ea957600"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(316), "192.168.1.83", (byte)2, 31.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("cb1ee892-adc3-4700-8a85-3d939d7491ae"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9553), "192.168.1.5", (byte)1, 24.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("cb8d3e14-f8cb-4c81-952d-7fd54bab09c9"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9713), "192.168.1.18", (byte)2, 28.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("cb9b7c1a-c97d-4549-b671-051396e04938"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(649), "192.168.1.54", (byte)2, 19.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("cbf66115-d554-4433-a01f-be7629675e8a"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9611), "192.168.1.84", (byte)1, 77.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("cc579829-29b8-40cd-b274-5d2d1328e0c8"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1320), "192.168.1.96", (byte)3, 20.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("cc7dd679-e69a-4db7-bff0-3ac9e26310e1"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8746), "192.168.1.58", (byte)1, 31.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("cced3acc-9085-46ee-88fc-186d31a5e3e3"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9689), "192.168.1.56", (byte)2, 90.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("cd0bbbee-730d-4ba7-9195-90d6aeb9d67e"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8982), "192.168.1.82", (byte)1, 94.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("cd8d79dc-fbd7-4f65-8884-549a61c4efc2"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9828), "192.168.1.65", (byte)2, 42.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("cdb85b8a-3122-4e55-8a31-e56062eb73f7"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8838), "192.168.1.97", (byte)1, 33.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("cdcee052-22ad-4f27-a52b-6cad437500ac"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1670), "192.168.1.43", (byte)3, 49.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("cde6c7fa-c873-4d77-87b4-664b2af2007d"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9768), "192.168.1.61", (byte)2, 16.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ceb96fb8-2402-4b36-8a02-e5cb9f81051c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9050), "192.168.1.66", (byte)1, 66.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("cec18d0f-40f8-4c1e-a80d-b027103d45cd"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(593), "192.168.1.57", (byte)2, 48.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("cee19363-fdef-4a4e-a307-9713cea6dd8a"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9462), "192.168.1.69", (byte)1, 89.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("cfe13956-c1ed-4961-ade3-f3f610fa012b"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8807), "192.168.1.22", (byte)1, 55.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("d09d6a57-d6d2-4f58-88bc-ac53af70161e"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1558), "192.168.1.70", (byte)3, 7.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d11f987d-ba9e-4777-b2a4-54163cb06ecb"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(353), "192.168.1.39", (byte)2, 2.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("d1673f3b-05bd-483c-a6b2-6cd6d6e21c8d"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9668), "192.168.1.35", (byte)2, 96.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("d16c595f-bf57-4b73-b292-1e46b3aca4b8"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9306), "192.168.1.8", (byte)1, 47.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d1af7ebf-1a32-44bd-baa0-6db4e7aaea19"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9193), "192.168.1.1", (byte)1, 95.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("d2ad71d1-b6a1-4b5a-a3b4-f721f9e0f419"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(434), "192.168.1.6", (byte)2, 87.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("d3223e5a-beba-427b-bd6f-1a46b00e2c8a"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(975), "192.168.1.58", (byte)3, 60.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("d329fb4b-80ce-4cde-9aa2-aaca553ca32f"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1192), "192.168.1.71", (byte)3, 66.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d351c42c-dc76-423d-b99e-47f504db0423"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1732), "192.168.1.72", (byte)3, 11.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("d3aa96d3-c711-4c27-b933-b73935505919"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1573), "192.168.1.73", (byte)3, 67.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("d3cd60d6-8f0f-451d-99a4-45d33785c166"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(997), "192.168.1.29", (byte)3, 59.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("d3ebdd27-a587-494e-96a9-319c70e25208"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(43), "192.168.1.94", (byte)2, 56.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d4b00688-41fa-4540-8450-b4a3ede6bf57"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9643), "192.168.1.38", (byte)1, 46.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("d4b08295-63c8-4ce3-b9f2-042a02761bfc"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9255), "192.168.1.40", (byte)1, 73.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("d5059e69-61ef-46c6-9266-cf65c10c0bea"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(670), "192.168.1.90", (byte)2, 78.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("d532ae2a-d57c-4d61-9d2a-c4b75f762f17"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9607), "192.168.1.32", (byte)1, 1.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("d676382e-3697-4df3-91de-bd102ebc3011"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1751), "192.168.1.78", (byte)3, 9.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("d6a0a3f6-332a-4dce-8120-7d73fc8c8ccd"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9665), "192.168.1.23", (byte)2, 28.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d7398615-28f2-481d-b206-ad11ab941ef6"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9211), "192.168.1.33", (byte)1, 30.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("d75d8ed8-7ec4-4312-afff-4f49409892da"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9672), "192.168.1.64", (byte)2, 44.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("d767ea42-130d-4644-b02b-0623bb0bf7b9"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9998), "192.168.1.45", (byte)2, 0.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("d78b16ef-613f-4e01-9d6d-d474b9e62354"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8773), "192.168.1.45", (byte)1, 97.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("d7ba90cd-b2a8-459f-91d6-87cce5f84bba"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1009), "192.168.1.34", (byte)3, 66.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d7d7053f-0c04-4e90-a7cd-acc20f292b7b"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(637), "192.168.1.75", (byte)2, 92.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d8950b6a-584d-4a00-9e97-946b41fb34c1"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9273), "192.168.1.82", (byte)1, 76.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("d8b5d6ca-a3c9-4484-91d7-b8ec30d80d01"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1324), "192.168.1.2", (byte)3, 24.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("d8c660c0-ffe5-4a52-b9b4-b505d84d1356"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1360), "192.168.1.36", (byte)3, 11.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("d8d491f9-b128-43b9-836b-42e7cb892369"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(654), "192.168.1.59", (byte)2, 33.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("d9a2d1b8-ebbd-4683-a45a-6aaa1eac7038"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1001), "192.168.1.96", (byte)3, 45.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d9f613a8-d3d1-40a8-8587-44f7c21430ea"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8823), "192.168.1.89", (byte)1, 69.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("da1e9cea-5a3e-49f6-a0eb-bb1d7d4bc4c9"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9823), "192.168.1.55", (byte)2, 8.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("daa0d4ae-dabd-45dd-beb2-92d83e695c24"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9840), "192.168.1.39", (byte)2, 44.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("dab298ff-96ea-4f21-9f53-982aaf08a787"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1206), "192.168.1.90", (byte)3, 84.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("dade3a3f-d8db-4ce3-8d46-ba79f66144aa"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1433), "192.168.1.58", (byte)3, 65.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("daf8aeb9-fb7b-46cf-af9a-4b6e89bd196a"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8641), "192.168.1.28", (byte)1, 62.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("db42c9e8-70c7-4a0a-96e8-3fb556b5a984"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1581), "192.168.1.27", (byte)3, 86.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("db7cf440-eb6c-44fd-a7a6-1c160b2bbb1b"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(349), "192.168.1.4", (byte)2, 32.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("db8aa177-0472-45fd-bc5b-dc9cbef1c323"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9488), "192.168.1.29", (byte)1, 35.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("dc2558f9-b691-443b-a691-21696db01f2c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8883), "192.168.1.30", (byte)1, 47.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("dc4f3361-7d16-48de-b452-afab4865126f"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9507), "192.168.1.95", (byte)1, 77.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("dcfb39db-2002-4bbd-8034-1b1b14f6e2e1"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1153), "192.168.1.32", (byte)3, 53.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("dd307398-ebd0-436e-aab4-6daf544fd926"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1685), "192.168.1.29", (byte)3, 11.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("dd5b5d16-d3dd-4de9-83f1-8a2a0c3ed9b2"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9322), "192.168.1.24", (byte)1, 27.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("dd78572e-6fca-4c60-b2f3-14127ad1b538"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(583), "192.168.1.59", (byte)2, 96.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ddeae864-bf92-4b64-b6df-8c464c17e4d8"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(817), "192.168.1.86", (byte)3, 18.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("dee0b8bf-f714-4a6b-ba66-32fce8e88a45"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1344), "192.168.1.99", (byte)3, 49.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("df5127a0-a2b7-4b70-9f13-158ccf524f5b"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9161), "192.168.1.58", (byte)1, 88.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e1a7ae65-af85-48a1-b5a8-815a334fd3fd"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1116), "192.168.1.11", (byte)3, 13.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e1bbe975-6414-4f40-97f2-a5fd563cbcd9"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1711), "192.168.1.40", (byte)3, 49.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("e1c46135-6df0-4f78-b005-13b2b8a837d0"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(565), "192.168.1.88", (byte)2, 9.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e1dd2873-fb38-4a65-bc98-ab77607423e8"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(226), "192.168.1.9", (byte)2, 29.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("e266879a-d31b-4f02-8ca1-8eaefe0de842"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9499), "192.168.1.36", (byte)1, 92.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e298a9fc-9ca4-4779-a1f3-bba18a830270"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1373), "192.168.1.91", (byte)3, 61.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("e2f7c2f3-8544-428d-9d95-47dd759c96f2"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(127), "192.168.1.43", (byte)2, 97.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("e3003cf2-6b04-4afa-b1ec-858ad1b9473b"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1414), "192.168.1.70", (byte)3, 59.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("e34e4c35-0ce4-429e-a25b-10e9665be968"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(752), "192.168.1.27", (byte)3, 94.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("e397f316-ad2d-4705-9b14-dc3d6d609e58"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8742), "192.168.1.89", (byte)1, 76.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("e3a5d6cd-86f1-45f0-bc20-e779bb191735"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9882), "192.168.1.51", (byte)2, 29.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("e3bfca10-f59a-4eca-b0db-2f7fb584c1b8"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8833), "192.168.1.35", (byte)1, 64.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("e4744e07-e1b9-488b-92e9-76cd3603ab01"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(6), "192.168.1.12", (byte)2, 6.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("e4c5e5c0-46b4-4c19-be6a-e305931ebc20"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8975), "192.168.1.94", (byte)1, 93.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e556590a-a686-495c-945e-abfb76e5fd7c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9265), "192.168.1.7", (byte)1, 90.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e57ebbe4-fa59-4905-9576-4091d9f43f57"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8900), "192.168.1.87", (byte)1, 2.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e5e2c480-a0ed-4135-aaee-fb769ecd79c5"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(964), "192.168.1.45", (byte)3, 20.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("e63a5465-5b6f-4480-acb4-462293928ebe"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9064), "192.168.1.10", (byte)1, 42.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e65dbd0e-2a90-4140-aec2-445cf3611d7e"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9545), "192.168.1.64", (byte)1, 40.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("e6c544d9-867d-4488-a562-ffce385384e3"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9747), "192.168.1.69", (byte)2, 28.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("e6c5db51-8dad-4f0f-86cf-0b8bc03b2b11"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9203), "192.168.1.77", (byte)1, 35.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("e6d73ac7-d74c-46db-882d-0905c60934ec"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1728), "192.168.1.34", (byte)3, 87.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e6f8088e-2c01-4b60-96de-72ee72c51192"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9199), "192.168.1.76", (byte)1, 91.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("e70e15a5-9232-413c-8939-f90c2b038881"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9990), "192.168.1.43", (byte)2, 8.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e7782b3b-8648-4dec-9a05-75448a49025e"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9536), "192.168.1.76", (byte)1, 7.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("e8207973-5d40-4da2-82cb-7d6f920dc697"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(579), "192.168.1.68", (byte)2, 67.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e83cff82-3cfd-43a8-a4b0-6c5c6ee2ad0a"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9391), "192.168.1.40", (byte)1, 58.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("e8405ae8-dc53-41c6-894e-515c209884b8"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(51), "192.168.1.26", (byte)2, 75.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e8e3f24b-cafb-4384-989c-5315743bd26a"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(135), "192.168.1.95", (byte)2, 29.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("e8e93fa6-4802-4007-9730-2d5901db82e1"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9886), "192.168.1.10", (byte)2, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("e90a476a-2e23-4382-86db-658eab5dcb2b"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9651), "192.168.1.70", (byte)2, 0.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("e95b2403-c1fe-4e0c-9ae1-74535af6e174"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9801), "192.168.1.77", (byte)2, 63.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e9621c5f-f599-48de-ad95-287b8c6b89ac"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9647), "192.168.1.70", (byte)2, 18.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("eae24817-6877-4738-ae50-6bb4d2d87bb2"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(188), "192.168.1.66", (byte)2, 76.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("eafa3d5d-07cc-4cd7-bcb5-ee010516e534"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9141), "192.168.1.9", (byte)1, 78.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("eb767f76-25a4-4a28-8705-fc0e92246391"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9451), "192.168.1.4", (byte)1, 8.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("ec390903-bb0c-4534-ad63-489d69250cf0"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9795), "192.168.1.92", (byte)2, 96.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("ecee02a8-598b-4d8e-a75b-a1c905d8668f"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(597), "192.168.1.30", (byte)2, 2.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ed0269d0-2c1b-459b-bbf8-b953ec47f631"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(357), "192.168.1.52", (byte)2, 56.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("ed7081c1-3e8a-48c5-bc3d-c39d0d4362ac"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9244), "192.168.1.95", (byte)1, 15.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ed8554a4-3602-4cb3-9592-a285c0b7803a"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8951), "192.168.1.63", (byte)1, 80.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("ee1f1092-92d3-4784-980e-91ed869f6657"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1674), "192.168.1.31", (byte)3, 3.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("eeb20537-fb19-4bbf-b628-7b319e796f7b"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(902), "192.168.1.66", (byte)3, 54.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("ef021383-0f6b-4319-85ab-e092d909c2c1"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9350), "192.168.1.21", (byte)1, 57.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("ef31378c-f3d7-4738-89c2-c2118d6dab87"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(220), "192.168.1.5", (byte)2, 16.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("efa3e629-14a5-49da-bd29-6f833eb80972"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(621), "192.168.1.56", (byte)2, 41.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("f0040751-2e35-4a20-a466-8c2b8d39a46f"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1316), "192.168.1.66", (byte)3, 70.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f04b8237-6e48-445c-ac95-c5b5910d16c5"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9599), "192.168.1.23", (byte)1, 42.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("f0fbe95d-0c62-429c-92b0-3dc448cb31fe"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8682), "192.168.1.65", (byte)1, 77.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f117a86e-c5c1-40c3-980d-9f4ba37252e2"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1699), "192.168.1.26", (byte)3, 53.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f152b044-fbe3-46e1-9be4-a151dd63f1a8"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8750), "192.168.1.78", (byte)1, 92.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f274367a-6e7a-452c-8696-8d2d5e18daf3"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9568), "192.168.1.95", (byte)1, 51.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f350d1ec-5cdb-4e03-8c4c-74fac8c05aeb"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9564), "192.168.1.71", (byte)1, 18.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f356cfd6-dd08-4b3a-9493-99edc2ec4f18"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9693), "192.168.1.94", (byte)2, 88.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("f381a0bc-0bc9-49bf-8589-0cb863ad9a93"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8782), "192.168.1.49", (byte)1, 43.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f3d9f525-3111-43bb-816c-8efbb0a56e04"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(687), "192.168.1.74", (byte)2, 9.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f62258ba-d911-4a1a-ab3c-3cb9d846484b"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1196), "192.168.1.49", (byte)3, 85.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f6be3897-5249-4607-b714-53f5670189c4"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(108), "192.168.1.22", (byte)2, 45.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f6da3641-2a56-43c3-8d78-57d0565033fe"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1150), "192.168.1.75", (byte)3, 13.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("f72f733e-5b79-40f3-8c83-c1debbf81050"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(27), "192.168.1.23", (byte)2, 73.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f774e796-a894-46b5-bd8d-3749883d1f89"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1757), "192.168.1.27", (byte)3, 40.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f7adcad1-0b0e-4a88-9a77-cb59b11109d7"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1458), "192.168.1.69", (byte)3, 22.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("f7d0c458-0e0b-4ef0-b429-b54bc2d522e4"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(399), "192.168.1.6", (byte)2, 26.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("f81e320b-cbe4-4198-a097-1572965d1ea4"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(492), "192.168.1.13", (byte)2, 92.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f855edd8-47f3-4362-ac67-169beb032300"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8550), "192.168.1.77", (byte)1, 81.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f8cf823e-e922-476b-9762-9ad2f3f0faa5"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9047), "192.168.1.45", (byte)1, 74.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("f917e8bd-817d-4dc6-8e71-6d06bb8d85f0"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1471), "192.168.1.76", (byte)3, 33.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("f9cc2e22-2674-458b-b08e-dd5d493d76c7"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9491), "192.168.1.60", (byte)1, 93.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f9d5dd15-5f78-42f7-8ca4-4a1ba08c4a68"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8637), "192.168.1.15", (byte)1, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("fa0fd34c-dc9f-4b3f-9355-3a1b0088df96"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(382), "192.168.1.14", (byte)2, 27.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("fab2b836-9efc-4b59-b0f4-4c3ee4610ce1"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(545), "192.168.1.72", (byte)2, 10.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("fb43e610-ce52-4b62-9b93-c8dc0630502e"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(97), "192.168.1.48", (byte)2, 78.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("fb5147ba-42b2-4644-a4c4-8e810cf5ed38"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8914), "192.168.1.74", (byte)1, 27.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("fb99109a-8e7f-4d7f-a25f-3aedcb2bbb0d"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(524), "192.168.1.86", (byte)2, 51.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("fcefc5cf-c7ee-4c59-81b3-1f68b7f46105"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8713), "192.168.1.90", (byte)1, 81.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("fd21bfec-f224-437a-9e90-90c5f232c0b5"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9791), "192.168.1.23", (byte)2, 15.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("fd22c466-7ede-4dbd-9f7d-6e9775174082"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(76), "192.168.1.25", (byte)2, 7.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("fd970e1f-e7c1-4780-a4c6-e0297718be13"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1312), "192.168.1.96", (byte)3, 56.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("fdae59f8-dad2-40a5-a810-867e747e9678"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9420), "192.168.1.85", (byte)1, 0.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("fdc80e5e-cf2d-45d7-b892-9ac6703c9276"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(1097), "192.168.1.51", (byte)3, 81.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("fdded90f-220f-4abc-8247-469acd587772"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8653), "192.168.1.31", (byte)1, 58.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("fe10b4d4-e143-4d41-bf0c-6fb5b73627af"), "Computer2", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(985), "192.168.1.3", (byte)3, 12.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("fece827c-de38-43d9-9f47-9ada6f3ca3cd"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8588), "192.168.1.77", (byte)1, 14.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("ff4ec7ce-5f2e-4ce9-a746-b6235b6fe994"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(438), "192.168.1.31", (byte)2, 16.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("ff6022b3-ee7d-4de1-8062-67967132716d"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9784), "192.168.1.42", (byte)2, 67.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("ff941e97-e401-42b1-b4f0-90e82db14fb8"), "Computer1", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(9676), "192.168.1.54", (byte)2, 35.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ff9b2afd-34fd-4f9b-9c68-76b5504f869c"), "Computer0", new DateTime(2024, 2, 9, 19, 17, 30, 471, DateTimeKind.Utc).AddTicks(8721), "192.168.1.34", (byte)1, 65.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(2693));

            migrationBuilder.InsertData(
                table: "ParentStudents",
                columns: new[] { "ParentId", "StudentId" },
                values: new object[,]
                {
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1") },
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36") },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20") },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6") },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1") },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") },
                    { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1") },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a") },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c") },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36") },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1") },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1") },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36") },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c") }
                });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("0b28a8c9-b390-485d-815d-82977278f08d"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("15b6a548-4045-4892-904a-aeeba517960d"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("bd914d22-1482-497d-a552-6926b915f669"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("c0340c3c-9153-4951-969d-1b0136758af7"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("fb221081-45cd-42be-abd4-45976e996233"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("2e032c26-8554-4ab9-8e06-77cfd8f9652d"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("35cced10-9fc1-4413-9e09-080b408b23c3"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("3ca93105-bfff-4791-9cc4-82a7a97ad756"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("4eca2d83-365e-4926-b42c-2415618b5e19"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a444db40-a494-4e3d-91d1-eea2779bf147"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a82047bd-f57e-4c34-928c-8b8d2c3fa636"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("dd82ca7c-38ca-4a8c-989b-a47d44d9b132"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("f12dbbce-5d81-4f38-8eab-b267b2263556"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("f6563118-b1bf-4d43-ab6d-c427a9f13f7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("fa70cb23-9c69-4548-8f15-77e93139ab41"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 19, 17, 30, 472, DateTimeKind.Utc).AddTicks(6692));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("001a78d2-4541-411d-9367-674f34ed8326"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("0054b162-5a1b-4f35-9b92-db3ada3a41c6"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("045e33e2-057c-4a63-aa4c-89ef17e0afe5"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("09fd3d46-f58e-4b3d-b99f-ca5992c8c6ad"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("0cf79cfa-f66d-44a4-8be8-2c731e480bb1"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("0e099793-ad28-468a-bbda-0afa3e760b2d"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("14d23143-b60b-4ec1-b448-42a06896ee1a"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("160f9f96-c9de-4645-a6e5-acf3159dd4d1"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("17fe743c-37b7-4f48-a719-d007e7d6d7e5"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("1b613a59-1e6c-4413-939a-b0f37e463e2a"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("25fde954-5837-4353-8edf-6f64caa6fcf9"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("31242db2-ce53-42e0-a57b-16c92347b127"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("342c1ac2-3ec8-4ede-af1d-cd404b0aa23b"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("3531a4f8-b25d-4a30-b2b6-e1cbfec929a8"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("36197828-d297-459a-bd4a-473c4b1bb1fc"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("4198c9e4-0061-408f-a5a0-2b9bb9730e73"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("44ddc2d2-fa1e-46c7-8839-f36ff66078d3"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("489bfbb9-88bf-4c8b-a1f5-e03dd02bc14d"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("48b4e24b-453f-4093-b1ba-bef4efc37908"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("4ac77790-2f52-48da-856a-19b98ff1604b"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("4bc3cd38-b7f9-4fba-a97a-a60a7f374864"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("4e751f0b-71eb-4349-9583-fc22caeb7efb"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("524a01e8-e6be-428d-af93-32b6ba25c0a0"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5366f1c3-6eb3-4bf5-bd07-e0c7492953a8"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("581c441c-de67-4b3f-9788-c1c21c923423"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5be3873a-edbc-41a2-b799-f07ada4c4f9c"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5fb4cc04-cda2-431c-a47a-dc102806f3fc"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("64eaea2a-9f5e-4025-9e3e-9579c1b49a42"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("68393f02-4ff4-4c03-ae95-efd0aa53777a"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("687f8f84-e1e7-4071-afef-a1c29e1b1a9b"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("6a261599-0bdb-43a3-a546-596a2615db8d"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("714ee635-8e30-4546-94b9-4018226214d8"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("73887f1a-ce6a-44fe-ab13-a63435600c27"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("74fffebf-3534-46e7-bf58-f1071113bcf3"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("7bd5ccd4-bcf2-4414-a732-72246b7dcf6f"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("7c4dd14a-ae73-4c47-848d-016356ab118b"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("83c8a33d-7d6d-48aa-8a88-70a5065b9877"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("89bb1b97-271b-4cd4-b3b5-2677a73d6473"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("8a5b8fb7-c98d-4ef9-90fd-08e10eaf07a9"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("8b96e0a2-69fe-417a-91c5-fb9ef4afecc4"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9acde3a5-15aa-495f-bf0e-45f4df2a7284"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9b6f6bc4-2c38-454b-9cf3-191d448daaf4"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9bb1753f-c33d-4384-9cc2-fb88df993487"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("9d301ffa-1832-4095-8ac6-d3c9f28fedc3"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("ab4d0de1-bf04-49da-a060-c175758ac2bf"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("abeefd6b-65b1-4ec7-b39f-bfb477934d93"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b5a65cc0-8e66-4596-aaa0-3f14b02e2f9a"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("c319e340-6cb2-40fe-bc77-96a0d29bfbfb"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("c444c04f-85de-417a-beb7-e159a73e9ba1"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("c874d065-9a3c-4a97-ae30-63eba8ec0019"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("cdec2131-09e6-4a09-b216-b28275075908"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("cdffa943-2667-441c-96c3-ee6ada37291f"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d3ee12ee-074e-4ce8-880f-f862a641c884"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("daeec080-c3fd-4481-a8c1-13a8cd7fbb1f"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("e1126d95-b807-471f-8903-940c70f3ab35"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("ef1ecc3e-ab3e-441d-aa08-dc5f71d2d89a"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f1f4d219-0164-4c60-a0eb-ca296596b27e"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("f67c5b6a-e2e3-4411-be66-90b0d6ac2dd8"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("faa4b506-bae5-42b3-b71e-04f515125fa0"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("fc50f963-c127-43e5-842d-418e8ffa4d75"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("064584ce-bdff-4614-bd5b-f130d2509405"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("10d75806-8026-4929-b8fc-37bfdad54767"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("117b6a3e-78a9-443a-baf0-74a058e7664a"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("12ba0a6e-626f-41c5-ba5d-103d9f24e35b"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("1912e6d5-394e-4dca-a0a3-66438312c251"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("19331843-4f8a-4462-b077-1ca923e3007c"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("315d0902-4ec2-4714-ba58-c2a741a1502f"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("3c72c332-8a6e-4780-87be-b23a8e38557d"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("44d777c7-fa07-4957-ba06-e0a2d006d6c4"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("53437d5c-6fda-4c08-a0ce-8f56562d4cad"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("5aaf4c30-9011-4a9d-8352-0b5b1dfff2fd"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("6066cd0a-cd0b-4beb-81a5-10b0fdd8a1fb"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("651cc96b-d735-4496-bb98-a59a81d1130d"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("682bc2a2-e19e-4b84-b03d-637de69b5f95"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("6f035e3c-e958-4d3a-9070-5e86e36f1142"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("704ba0ba-d944-43f0-b5c8-c8ae44e99868"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("70d89a01-1bc0-47e4-a866-19547366539f"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("71bd89b6-5066-48fb-9183-7510688390e5"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("7201e5c8-0739-47df-89d9-04fd603c1caa"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("75c64bd3-6176-421f-9da9-7da6e4d890dd"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("79bad982-4009-4050-95be-63231b55040b"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("7e03b402-6e3e-4d1f-8cc2-dd2fafe751ab"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("81f2eb64-e9c1-48cc-96f0-975d35527d94"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("84bf1bfa-83cf-413e-8ad0-89ea8c5c04eb"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("86dbb7b0-5a0c-468f-8452-4a4fc70fd869"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("9204c3d1-2590-43af-b6bb-742532f6dfb3"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("aa688324-d518-4b05-98dc-4772f2d7c84d"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("af24d961-9ae9-4c47-aa79-6403a2e8711f"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("b757270d-50bf-431b-ad34-1f8e963f8e4b"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("c09bf4c1-2221-4286-9b81-78758fe84a7e"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("cc995ac8-0321-4ca6-860f-a305e0325245"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("df0ae768-f0c6-4788-8277-2bf9a45d07d9"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("df606e3c-a0f8-4d4f-bc41-73e182176fe3"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("e0d57d8b-4aef-45c7-83fb-c2aea5041b28"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("e587c5b8-1968-416d-8b18-5f5dd3c3ddd0"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("e7c878c6-b7c7-48c1-be33-ecc431f17f42"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("eaafedca-d3f0-4fc3-b317-d854a4dcef55"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("ec9d20e0-97f6-4d95-8fd9-f6268c1dd56f"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("f06f7b9f-07a5-44b1-9dd0-7430f2b87b51"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("f4908739-efe9-49f5-a05a-3f70b4015572"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("fddc2bd2-c1fc-4c9a-b882-a7131d654022"));

            migrationBuilder.DeleteData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: new Guid("fe03295a-a89b-4d63-941b-1f9d3fb17b10"));

            migrationBuilder.DeleteData(
                table: "DiscontinuedStudents",
                keyColumn: "Id",
                keyValue: new Guid("d299271a-984d-44cb-96d2-eca5b7c7063a"));

            migrationBuilder.DeleteData(
                table: "DiscontinuedStudents",
                keyColumn: "Id",
                keyValue: new Guid("d3ecf483-2478-41fb-badc-fd407ab669e4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("005a2e1f-0998-481a-9111-cf99644d805a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("01344f6e-5c9a-42b6-976c-6001f0357985"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("01977125-9285-464d-ab8a-296178fa4cd1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0268cabc-08a8-48e4-bc30-3d7fb225dc76"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("029faf66-7c53-465d-97a9-35e18e62db3c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("032d2cf9-8632-46b2-b0ac-066e93a68505"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0342650c-92a6-4996-a9ba-f752a8e6b085"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("040097df-b482-4e5e-844e-ed8c982933b7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0409ea95-9a3f-4582-b4d7-3c2e6039a448"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0467dcd2-6575-49b3-ae26-2ffc0cd675bb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("04ad93a6-05d0-4b34-8eb9-1471c6e304ae"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("04c28d80-bcdf-4234-8f99-e3bc7f1e9d70"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("04f7a0e6-22db-4476-a528-6c45e44b396f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("04fcaa12-d284-4411-8e1a-03f0a5a1628a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("050258c1-6187-4220-9a55-25bf9493715a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("05543f27-5d7d-4aee-9c16-5dbe1029290c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("059d2593-41ae-428a-9c31-7b204bf386ec"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("06041cba-2986-4e56-8e84-15b24da45280"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0648274d-e400-4b71-acfd-8a18a8caf26d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("06f5bb94-84af-43a4-b7b9-2cfa63fa10b1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("072ad266-8a8b-49c3-8e07-3540b29db29d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("073fd6bc-bbc0-4223-b3c1-d844073ecb1c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("076e8dcc-f2bd-4b9a-b481-256991a5f118"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("07b24e69-5e3c-4a41-9ead-a0e2bcc658de"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("07f7b0b1-c5a1-4b1b-a403-dce628b9561e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("080a95c0-b34d-4c84-8165-8ee48d829d0f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("082a0416-cc14-48f7-9dd7-52e9a0d53d87"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("082a93eb-91b2-4132-ba07-3bd59388810c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("08524867-c500-4884-adde-80b49bee8953"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("08aede67-462b-4a6e-ba0d-2f8efc41be19"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("08fb9482-4676-4bc9-a7c6-0d905aa46fcc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("09afaf67-3a0a-4ae4-bcd0-9b0d3661beba"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0a61b433-13b2-4d5c-80e7-69da5b2d1a4d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0aa93d29-10e2-4402-8e18-08bd1a7f5da4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0b5f99f0-0ea7-4f30-8fba-8647e77e753a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0b76825b-21c7-4eed-a8e8-0bdc4e7611fe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0bc38b46-0ac9-45dd-91bb-a14fae2fb02c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0be5ca95-428f-48d8-8d5d-7f4aba1a7058"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0c2e058c-64e2-424f-8317-0b3fdbe4083c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0c64955c-80f0-412f-a897-b1a5cf7fd277"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0c9a3607-2738-49bd-a351-dda2ff94a828"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0cd0dcb0-66bf-4df5-8094-790e0fb116a0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0cd24fc7-fafe-4e24-94e4-a438138cbc99"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0d1f38fc-3eac-49ea-b107-0ced2f62dcb6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0d22d351-777c-473c-8136-e878f8066d9c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0d37bb6d-fd8d-48b5-8ffd-6561d2f10d50"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0d385800-a75a-4162-94c6-317280719250"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0d5a796c-0a48-491e-93f4-77833333445e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0dd323a9-b5c6-4751-9303-2816a620a7b2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0df6361d-921e-4411-93b8-880929ebbd80"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0e2023d6-47bd-4fd7-939e-c3e6a643eba5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0e5bdac3-3324-457d-b1cf-7b2a2f0bdf69"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0e95078b-1e82-4e46-a451-bda12a45ede9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0ed2b858-ab65-4362-a66f-445f18f67a27"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("0f43f04e-bb39-48f4-ab3e-44afba0c99c6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1047c601-0463-4171-8949-1c01346176f4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("104fd613-c63f-4b97-9414-0c59de471ed2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("11168a6e-8da2-4ada-986e-7b84b29b6698"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("11abc6d9-2475-4327-8338-ed89d703fcdc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("125b0a04-183a-411b-b72f-5c64b0bffa2b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1388e27a-c1b1-4cbb-91ef-96de96e5d88a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("13ca7805-09ca-41f4-9a81-fbef30932ff3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("13da51c9-09b1-4577-b694-1b5e0b04cb6d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("147d9876-2809-4c34-a2d6-8899e55d22e9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("14c9a00f-5bc5-463e-816e-d01253f9a6d2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("14e660f6-71c0-41da-9ed1-b8dad38baf01"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1567c775-45df-4da1-b1a1-f63dea784593"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1581c438-8f95-467a-af5d-590d33d13149"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("15b9f0a6-67c0-475e-94c2-3dfe7906241a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("166b20da-1877-408f-8bf5-89e49912b9c6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("16971b5a-9ec1-4b7f-a534-40de585387d8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("16d3f413-2ad8-4d14-b691-0fb05e4090d4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1767ed22-1f18-491f-9394-ba10383e56e5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("182731a1-aa2a-41dc-894b-5294ea080d2f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("18365a96-59d3-448e-b3ba-a51f14357040"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("18982ff3-8f8d-4b99-92e4-11ccdfa41204"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("191af12a-969f-4bc5-bfe3-bcf2c555b8a8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("19a9bb3b-6cc7-489a-ae8c-f0bec2b3096e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1b1c1813-8451-44f8-9a6d-81d20f84d45b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1b21ed8b-d312-4eb0-b459-42dceb24eaa0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1b21f4c1-3487-431a-8f3a-5c58aec4ca36"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1beab494-d291-4b22-83fd-8eeca5d83ac4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1c289acb-bb06-4711-bb3f-8131d200b570"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1c3f171f-5c9c-4fac-a6c2-4a61655e43c2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1c40f4b0-0bec-474e-a3cc-94877e41fbbf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1c5d7497-3ee4-4b08-9c42-f0abd2a63b70"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1d7457cb-83da-4d02-9b7e-e596ef854760"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1d8515e7-e951-4e35-9f24-c14350aab435"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1e21a512-afa9-49bb-9a18-254d6a73ea9d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1ecb9966-b882-405e-ace9-829338306e9c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1fcabf44-399a-4ac4-aef3-7247b73650d2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1fd43674-a9d8-44c1-a7aa-c65685608d4f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("1fff9ae9-f566-408b-8f1e-505a0b21385c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("206b4471-8c3c-40b0-8ac8-6121797381ef"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("209ad185-d1e6-4b0e-ae70-cc515ddc964b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("210b3710-9393-4f66-bac1-c67b249f4e8d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2159d85d-0de1-4097-b554-62e508ec19b5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("221edc12-70e2-4656-ab09-fb78cfa3eaa4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2232374c-fa38-4d1a-9afa-29340f5b6cb0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2249cbe1-fc20-4e3b-b14d-4b70521d5d72"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2268df3b-ba71-45a4-b86e-6472f22c268b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("227490bd-ba91-48fd-9ff6-afa33e611adc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("22957c93-45a8-4834-a967-a20593f5dccf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2317d0ec-9fd4-49a5-8562-83c09c0f5791"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("23af7c5e-2400-4a5a-a004-6da552b4e78f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("23af80e8-d3d2-4409-a8b5-0b975161b5c1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("23cfd387-a375-4628-93a8-fe995f610c32"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("24f74e19-8954-4972-be50-c8b3ad30c7b7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("251cb860-435f-44b8-9545-b3410558ea6c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("25969c3e-5349-48f3-bb22-b0cf3824f1ff"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("25b3ef1e-93d1-4854-8557-2acbf4b7b0d8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("26e2b6d1-0366-4d05-aca1-bb1a67d61f96"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("26e93d44-4eca-476b-bfd4-73be53e1952f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("278f255a-5d26-4f8b-9818-6affbceee7b9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("27901579-9ab2-4948-a9cc-6dfe898906c4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("27a30413-893c-4ae9-bfe5-b0a3aa3d1ee9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("284598be-647c-472f-b344-394644e00081"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("284ff2d2-513c-4c74-a1c6-4d0f5846987f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2916a26e-51b0-48c2-acc4-bdb8701bfa0d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("29694b8e-b3b9-4cb7-9242-7a539f5c8351"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2a7083db-2509-44f7-8880-ad2c41cfdc9f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2a727d3c-de85-4630-8ab7-35244a67f23a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2aa90a08-a090-415e-85ff-0e54020e961a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2ab1e1e6-f885-4dd5-b864-a924ea25f2f2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2acd646a-6373-4a5d-b46c-f800134485a8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2b9b0260-d8f3-44e1-9866-e1057cfe3d90"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2ba4d9ac-7bcb-431f-8183-fe3f24851a0a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2c065cac-1a7a-4197-ae6e-0e39151bf957"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2c09f7b4-9f2a-4c7b-9ac7-1130d5eabca3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2c211932-eea6-4ba9-9c94-ae60ae4f0b48"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2c3296c6-c5ec-4bb3-ba2e-c448ace0585c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2c420543-110f-41c5-a0f5-4eef5b44f10f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2c6afb0d-dc86-4288-ba9a-e69124872ab3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2cf70ecf-c6fe-432b-b3ee-0a65175c35b6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2d425d24-b08e-428c-ae09-2e3e9be122b8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2d496d9b-1a50-4347-908e-f99409de3ffb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2d5003f7-533f-4414-af7f-66f8a3792506"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2d6ec09c-ca62-4ced-a675-40b86adb28c8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2d7129da-2d46-4fbb-87fa-e25c3f6ae668"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2dd4b32e-b219-4de2-b250-5a854cec92b0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2de6a569-877b-4386-a56a-67a7ac7bb64f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2ea9ff98-6a44-4f59-b3f5-a1094166c959"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2ed6b736-6d0a-47ff-813d-f64d78a4e49b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("2fc9f0d0-9413-4f6c-ab0e-df28ef98a474"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("308ca7af-f013-4176-9a95-7df12c5df4fa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("30b5a0fe-f3f8-45d6-b72f-f7669a47952c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("31867e62-a215-4cb8-8381-02611ff868fb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("31f1f492-79ea-4b09-9539-350e7f6795a9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("323e995c-2b9e-41a8-8b73-856753f051b9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("324eaabb-b397-4fce-9bff-1a8e3467e7de"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("324ed8f8-0e08-4b28-9f73-ea2f20ca9d11"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3269ab01-5b48-49da-b0f7-f2ca1e0561e2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3374235f-847e-4201-8670-48ed78f7e3c4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3439cad3-90c9-4f8e-a666-babc7bad11a9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3590d080-a1b1-4ed0-8a53-c3e6e3f4fe1f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("366e0b40-45ba-47f7-b756-13b5cc37e047"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("369a2a63-6a28-42c6-b9df-ecbef8573cae"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("36a82afa-7d53-42df-b76a-24f3816004a5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3717b5e1-4a9f-40fc-aa28-1ac1ef1abc1e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3833401c-16a8-483e-b518-1f589e0875cd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("38e0abb3-d02d-4559-a438-d1858ad8dd0c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("38e4c0ff-5bc7-43d3-af04-81fdb49318fd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("39867ecd-9c36-46a0-9474-12e480f6fcce"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("39bc8298-4b81-49be-9989-243487b9e79c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3a1624c4-0af8-4778-b9c4-64a9584e1426"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3a46702c-10e2-4873-80c2-8f16b59b08ca"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3a69ef8e-50e3-45e7-9a0f-1e450f11d971"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3a82f4b9-3540-4117-8611-ef9252c5656f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3a9e0fe5-e17c-4127-aeaf-080231aad069"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3ab8c51d-2f93-4968-82ef-ef3d3d8851a0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3b4bac64-32ed-48d3-9f5e-3c01a29c60eb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3b7112b9-1178-4ad1-9ce1-98a4e5babb21"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3bf70c1e-ea51-40ba-b1fc-9645f6731d58"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3c4552cd-b86e-4a6b-9a50-5845af91d26b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3c72fdd4-72ad-40bd-8e1d-ff5a368721f8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3cad1c84-8cbb-4b79-ad0d-edda7557829c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3cce670d-3f71-4d14-8cd9-ae702f15cfda"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3de28811-bd6a-438c-aa58-7d0dfb72c32b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3dfb1416-dc46-48a5-bad4-531f79dc95bd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3e28e662-bf8c-4cb3-975c-cc644e4faae5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3e554596-a939-4890-932c-728db45b41a4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3ec7c6b3-92fd-49a0-9239-36a1cec92531"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3f27c49e-b65c-450a-a38a-bb5ba12a74b3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("3f2e3b45-8c69-4be5-a54a-d7cd9a5f67c0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4043c9e3-959e-463e-8178-1969ae4216ca"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("40d36bbb-210f-40a3-a765-9a270f408ddd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("41022b36-d05f-4260-a485-3572743f5189"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("411e829b-8b67-4253-a166-e290c632a365"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("415551aa-3fbf-4a41-a5b3-16533ad50c6d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("42872236-e317-4c42-91fd-9ee3b7878c4b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("42cb101a-16d7-48dc-9209-30d23570325c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4341dd5e-02aa-42a0-bb17-bfc192454b4d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4426f856-a908-46d3-afc0-95798031a462"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("44a87037-c0d0-4b3b-81a2-41f2330281cd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("44aa4627-b3eb-4d5c-b329-5697793f4031"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("44d0ba68-978e-4006-8d4d-be87898c0427"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("45cd6787-9358-4c44-9a4e-4d5aaf9b91cf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("45f8c263-1e83-4091-8fc6-31d73576292a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("46384671-fed4-4066-b1db-84b22242cf00"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("46896b73-4324-4166-a978-71e5fcdf97fb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4698c0b6-0a05-4ca7-84cf-42ee0350cf62"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("46b832b3-65f1-4d5c-af2d-3751cb730800"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("46c92e9f-eade-4576-9a85-9e1422af7308"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("46d46bee-da9f-41db-8884-2d3d35c32ab4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("46e46236-c185-42dc-878b-1b02aaa3e00f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("470e4ad2-62de-470f-98ac-6b8142943cf5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("471db2d3-8e80-4a55-a832-f7457976177d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("474cc113-6bb0-4f31-a6b2-ac88f7198d5a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("479ba698-967b-4c6b-b2f2-301f3513f711"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("47cddd82-15ec-43d9-9484-011fd45c21c3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("47f231e3-2cac-4a55-94f8-f8857e87c3bf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("482a1668-e352-4c26-b093-104dcbfcad7b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("48b025d4-4e82-4d97-8a84-94b0054003c5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("49140f64-f7b7-428e-9404-62fee66c9e6b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("49bc3138-e841-4700-8f66-60f6fe5c32ab"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4a2dc413-fb36-43e0-92df-37d3b5c4ff04"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4b07eaa3-f748-4b1f-a94f-b48b8609193b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4b28507b-22ec-4ddd-8276-ae3c49aed902"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4b313447-4128-44ac-b033-9f55dbcb286e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4b492551-7712-443c-8ed3-ce64b7b2c590"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4b8b8749-0e46-4b84-8af3-9499b5de3711"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4bb6f86d-de75-4618-af40-844783b3fab0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4c4ad495-ffab-4b63-82b7-405d6391096f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4c8d3314-ff83-444c-956c-199cdffbae06"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4cfc2d53-dfe5-4a3b-96f8-a667b2978ff5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4cfca6de-f7b0-4d20-b81f-7973df822563"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4db0f942-e762-49c6-8e97-be5e5ef0313f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4e6fb20b-7012-4da0-8dd1-0e86910e6d87"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4ea47e4f-5686-4cb9-a40a-0e51a4ce1bcb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4fb34070-dfb2-4c79-9757-54eaa8f20cfd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4fc2179f-8e21-4f18-a48b-c8c7d9e36746"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4fd5d75a-7cec-4b32-989f-49792eb35b39"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("4fe57b7b-1cd3-490c-aa01-880ac69d5ead"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("500d6e6c-de47-4ae2-a7bd-af2a11e276f5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("50195afc-de7c-4efa-a68a-c8d54144b723"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("503fc963-8c6f-4d38-8eab-84e6cb6d2c4c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5043b250-4620-44aa-bb17-f6421a5d8a8e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("505c2286-422c-4ae0-ab1b-a56001af7b52"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("51412f2f-7cd2-48b8-aa58-179876cedf87"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("517e89c9-0a74-410b-b99b-262dbbea71dc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("51f8db9e-a7fd-4743-b9b9-3f0abccc1cba"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("528d63b2-9624-46c3-b50a-44484c79a43a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("529034f9-4446-42ec-9bc1-15064f24f4db"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("556284f3-8381-4e9d-b736-3d4cb8de597c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("55e23574-d5af-4b44-979f-fa0368d6d06b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5612f43b-0be7-456e-8c6b-fa226d6b27b3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("565e039a-8666-4d12-bdcf-25d6c52e98dc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("57110262-dc95-4a9c-94d6-3716ae48f74a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5745ae8a-f031-463d-83a9-3e6e7ba2adf5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("577ce9dd-98d9-40b5-a1cf-942b924fb3d2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("57dc974d-32f5-4f12-addd-74e4fc4e9bd4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("58262766-7c2a-454c-892d-380b6b4d6a2b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5864a208-4198-4c0f-9fd9-2c3517ab6fda"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("591d8535-b3a1-4420-8623-8b7ee44766fc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("593ba590-3130-4277-8e2e-60979a41d853"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("594ea60a-0797-4bf8-981c-6840f583f9d7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5ae5fbc2-24cb-4a89-88a9-1b583ad29320"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5b1c7588-db51-4849-812e-708516239b7e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5b2d0e4b-1c8b-44a7-8c37-76499591272a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5b50470d-986a-445b-b6e8-276663a6029d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5b77333c-e432-4811-adb9-97f90ad192ba"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5ba2cd12-16d0-4338-a8d0-97293b7d2e63"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5bc23e82-b0ac-4446-9885-29991a5903c3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5bfbe944-f613-4324-b009-24d4a7e6552d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5ca51674-5a89-4f41-989f-2f61da29bfd4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5ca59354-34ab-49a5-8030-72ef0896bee6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5d479bd3-ebd2-425c-adb7-e559f0c92de6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5d4cd729-0b7d-4645-a71f-914012aa0b8e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5d52331d-44f3-4367-b031-a7dda8b87014"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5e2d24fa-263a-4549-a94c-0b2ff08ed346"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5e56410c-6fbe-40ec-806e-ed9863b3c4aa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5e65b0b9-b5ea-4c18-b901-c635545f2a76"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5e7ca713-fe9a-4a7a-92f5-2046d22926f1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5ea4cdcf-2dbe-4050-82b7-50326d6551ba"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5eaa676b-84bd-481f-ae61-3abeb1aee4f5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5ec15f0c-f1fe-408d-a1e4-e507a29df4cd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5eff6c01-41c7-44fa-b40f-032b11a951c7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5f410aaf-44c1-4926-bf16-7683f3551a55"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5f761f4e-7b50-4886-9408-ae202ff77c98"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5f7d80ca-0b96-4b00-9a8a-774b490630ac"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("5fec9a0b-42b6-489b-a738-c40be04f57d0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("600aa013-5613-41ba-8d3d-823d7a14d7d3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6079af71-e8db-427b-9717-436ae6e8c52c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6095154e-3f26-4cb6-9f26-0697bcae8540"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("60b2f45f-d095-409d-b1d4-df661db210d0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("60c46e8a-7362-49d4-90d6-504b9956fcd6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("60e5f39b-5419-44f0-946b-772316865ef7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6157afe7-d03d-47af-bdb7-8a4a4f1b57c0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6241fd20-e08c-42d1-8b66-a5f645e433d7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6277c5ee-3726-465d-827e-079dc8478c63"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("627ac3b0-f5ec-41a1-b1cb-9c004971ce88"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("629e469c-c3ae-4780-8676-9c45c355f511"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("62d99ffe-a4b0-44b1-94f5-abfc2d8eab55"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("630bf490-bdb1-4904-8c3e-b40de6c608d5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("635c1dfd-7218-4f21-ae41-f9c9ab224ee9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("638b3ce4-107f-4bda-be08-a2205c46a4f0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("63b07889-6310-45d3-b977-249cec4ade3d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("64b0aef4-58a1-440e-9213-1e5482c4e952"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("64e7fe5a-1c99-4b80-aa59-e0f11e2b8265"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("665a90f9-b9df-471e-b0f8-8bc75df6dd34"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6721d95a-4da9-4b6a-bbbf-142b786dee14"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("674e5f66-680e-4fe0-b15a-bc3db242f445"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("67676f6e-c09d-4b6c-aae4-004031d8c273"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("682295f2-2b5d-4084-a082-328edb5db755"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("68f4adf5-1376-42a3-b4ec-41fc9fcc87f8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("69c12b53-4e52-4b74-ae78-53516a9880b0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("69c193a2-bd9b-43fb-8b3d-1eeb3c136fc7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6a92861d-5b78-4b5d-b6a0-922e105a10a5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6b762c64-632b-48d3-801a-2747b7b32084"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6bf3095c-a6ca-47e3-86e3-55fa67613b5e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6c285146-6c3e-40f0-a780-4e59f1c1e9e6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6ccbc2de-a683-4944-aaf0-d21e52a92da6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6d24597b-69ce-4736-9bf3-88bca3ad838d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6d2c6f39-7353-49c5-bc40-83640609e5b9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6dc2d70f-9dd9-4761-bd80-6c87bf6b5bef"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6de35932-e798-45ec-95cc-eb463e46244a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6dedf9f0-3531-408d-ba32-b3905297402c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6e03dc9e-fe57-4e73-ae52-21beae67e8a4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6e17395b-f2dc-4ba6-b1b7-85d2a8de59c4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6eb2ec4d-bb26-45bd-a21a-5cf12e5770a8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("6fd0095d-4444-41de-93ea-2c1e149036f1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("718be456-a753-40c4-a8c3-a34fcf261b2a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("71e1da4b-666c-4522-9e82-3538ed6e637a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("71e44329-480b-4557-9eec-a4c00edbc363"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7256053a-5caf-4d83-827a-1acaed06fbd1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("72cfaa67-745c-4861-a1c7-f270a3905ea6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("72e8e1c1-7871-4f88-bf12-e5ceef781722"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("72efa750-0fd9-4df6-a240-77039579b53e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7358ad44-2a6c-4467-84d5-3663e47ec165"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("736ef6dd-c39d-460d-8a63-a09ad88afd57"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7372af0a-80a2-4ecc-bf5d-65d3a9cf3239"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("73e05ce6-bc53-49d9-920e-97d780cd2109"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("75635e2d-dd82-4e16-af4b-32a7320a95c0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("75e4ea28-477f-47fd-8a5d-4ab7b12ed5e7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("764e2eb9-1d6d-4d98-ac4c-5042b9c2ac97"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("76f80e4d-002a-44de-8183-2b8001ab88ae"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7859ec00-3017-4e9b-9aca-afc98f2c2792"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7b671084-fdac-4bfc-859b-a6390bc8bb63"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7b831c0e-0c02-432f-ba6a-eeaa1ac26dad"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7b886d6e-9629-45e8-a7d9-9061fecbf03f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7b8dfa79-9a8d-4c01-947e-5d8cf70ca801"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7bce436b-a958-4ceb-83b1-47014d227cd4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7c96f70a-ff82-4eb2-bedf-1c798cce0e53"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7caa917c-4aea-42e3-9a31-3a0b9dc6d146"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7d00a996-af4f-4279-8b44-25a8d28080fe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7d7b1d6c-7d0b-4c4c-a1a3-0d8588eab6b4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7d930025-239b-41c1-b3ac-fdf2c2b26984"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7df2edbe-fe3c-493f-b550-c1c42c812e8f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7e861377-1c66-4530-a646-c57dd4d8cd58"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7ef0a97b-921b-408d-84ab-9abe791fff3c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7ef0ce73-8948-4dca-ac80-dbe06ca7ac18"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7f8ec592-c7d5-402b-8459-8dbdf18a3d93"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("7fe95386-8d03-477b-8d68-14e3f8cd525c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("80924487-bbb8-4cd4-9205-3dd7b409f158"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("815279fe-bfd5-4e17-9051-5509da8dc559"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("81c81c00-25f0-4236-b987-184ba4d5859a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("81fa86a8-988a-450a-96db-aa3de1c2e50d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8203bde3-2b92-4f6f-92c0-74838edaf8c6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8237f616-0428-4fef-adb7-739569ac4a68"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8279a350-610b-4eea-a7f2-91676421f1e6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("82a2f924-583e-413f-827f-67d7e2fd74f5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("82ab2f09-c6dd-4095-a591-f87703985a11"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("831d4d94-8a92-45fb-9704-f0f9a8ef2f01"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("83324268-933f-488f-ab8e-d2b9f6559ddc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("834be243-26e3-4550-b43f-72c0d8977959"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("83c8ced0-46b5-44fe-907b-87f47fa326d9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("84d5456d-2a9a-4573-b2fc-32f154f7a0bd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("84ef2951-bf62-4e73-896c-11ed45242383"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("84fe108b-5b09-4381-8fb5-ebf0b6e3da9a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("85379a95-a3b2-42f8-a402-8eb52afdf702"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("853f7f3f-259d-4c6e-95e1-dd45d81ef9a4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("85d0a921-94fb-432f-a65b-21a23e94f937"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("86328074-4127-4ab5-8137-1c061e46f38e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("86e62dee-65a9-492c-9fbc-d66eee9b8ec6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("87347349-2558-4bcf-b371-aec1c79ab38e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8746551d-3224-4d5a-9968-4ead4df73e0a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("875bd5e1-2ed4-43d8-af9c-6239cb6f7039"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("87d02dd2-9c8b-43f1-8c42-356deec8d030"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("88a308d4-90c7-4b14-91f4-0a12793c3862"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("88a695a9-d16e-453f-8c3f-37e0e5ebedaf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("88c6c202-1aa0-4613-8f93-9e29de81d69d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("88d57855-d65f-4518-ac61-c2ef7c4771df"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("88f238b4-4724-4f2f-a029-46e2071cadcb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("89062ccd-7ebc-47ea-a384-cb27c2a01272"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8b3e2d32-cdb3-4c87-8dfd-b319ac3aaab1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8b622427-e54d-4108-a417-5680345ac563"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8c30423e-6e44-4823-b89b-cbdab07d45a6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8c392d55-05b0-4bae-a8de-cb1d4df4fccf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8cd0ef26-b20d-4898-af7d-a31200a09138"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8da4623a-1e3a-4b91-bce7-319c1b8e6848"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8dfb7c84-5474-42b4-8c10-efcfc2ef3652"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8dfcac9c-81c5-4933-8eba-2f7e86d49c70"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8e95b293-fe29-4507-b9e9-643e461a4b7e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8ebd1823-3b9e-47ce-854c-ab30f83921a4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8ebdd030-697d-4de5-bf9d-0321996ed84c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8f9d5c94-8b44-406d-a17c-28f0d69fe0bb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8fbbc256-9d76-4c94-91e5-81ac49cbc78f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("8fcbb146-1275-476a-b633-622321e9971c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("90ae31fe-15d5-4fdd-be53-b0a6f19a0fb2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("90e27c08-1592-4c06-913b-d033be9eba5b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("915fdf02-7e6a-4ce3-855d-7c38963a681b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9170cfdd-d949-4a5d-8bdf-e78e7c3dce0e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("91e59825-cc8e-44a9-b70c-83bb035203b8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("92455c03-efb1-49d6-a657-1c923d7256bc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("927e829b-93a3-4884-a1fc-1f882e56d418"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("92b048e0-2bcb-4ca9-bd19-7dfb3e00a7e8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("93356b15-55df-4888-9743-58ce53dfd0e8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("93ad3382-6e1a-4702-a9e4-665754e6d669"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("944380b9-c464-45ce-be9a-64ff04796a06"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9494eb32-3e7f-4a6c-9696-2d1da91682be"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("94e93980-9613-4669-8d4c-92357b12cdfa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("94ef4331-dc58-48d7-a28b-d09b560f1368"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("954d4a1b-0b5a-4003-b9f6-59a2cea55a6a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9592ece9-1774-4bc8-ad58-aec7a6260020"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9604317c-5745-4906-8f9b-bc750bd9beee"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9627f758-e86a-481c-89d5-1ee901ab3039"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9636ca15-b9e8-4049-83e6-4651e3daca1a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9666a409-c671-4308-81a8-ec67b74f218e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9768736d-e05d-4bdc-9a5f-e86d047c88ed"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9775cbaf-cbe5-40f9-8d66-401ebbcbf7ca"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("97daf3ba-85c4-4575-9911-6c7331f46716"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("982a780e-6762-44d0-99cd-decbf493b177"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("983102cc-8c6b-4e41-a3e0-a188d8e4d531"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9851fe23-aeaa-44de-b292-7e8f0bf5700d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("985b72f0-e4e7-4d0a-a123-68aa37311df7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("989c96aa-d63e-41a5-98e1-82c4682b942c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("98acd448-8479-41f5-8314-347cf0c06f41"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("98b4d550-0eb9-4289-9714-80bcbb9149bb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("98db00b2-2dca-4c6a-abc8-c0d7fbe71d65"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9934f0c6-7f7f-4828-9e42-b068de95f92c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("99c97b00-e6c0-4a1c-a2dc-3c26049434fd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9a50d505-0afd-4f74-9e0f-d90beb67b616"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9a9525a3-9ea5-496c-b6fe-c9c128041ef7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9abebe8f-21a6-422b-af60-25acbed0d3cf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9af3de6b-8836-4451-b65c-600da31ccfab"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9afad860-cd78-4f0e-a616-cda2a8a95542"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9b19453d-47f4-4393-8d65-aace1104d80b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9b222780-f8c9-4fb9-978f-b5f43587dfad"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9b8ad650-a25b-490b-9861-b35a77181570"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9bb7989c-1b39-4f64-98a7-d48c72380974"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9bb8a3c1-8401-41eb-acb4-e1b3613e2f6c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9c1721c9-7439-432e-b01d-e0ff15b7efe2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9c18ed69-5f85-4baa-a10b-2534fff0e289"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9c241eed-7353-455a-8888-cf5ee83db455"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9d268bd8-bd76-4dd6-8dca-fa44336e0530"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9d57392e-4dc3-4253-a3f8-ff0ac962ba08"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9da1e692-ba8e-4d92-b0cd-66db6b5b3c27"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9dd42198-6a94-4f24-af1a-9ef6ba70ac5d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9e45b883-5bb8-4f24-b039-298777bba486"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9e6324b9-9d92-4525-8125-c794751435bb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9e684d74-9cae-4c54-93e3-e4b2ceb832ca"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9e9b6a42-ce45-4481-9b2c-531bbd8c2cab"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9eee6e08-e230-4ecd-a15a-63bfc55b2a8a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9f4a7109-7126-4f48-9309-e2e56e7ff756"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("9f4e3344-88a4-413c-8eec-2444ac25fb8d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a030774e-033c-4bb7-8e0d-c65ca8e1c85e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a0b94bac-8669-4ea4-9e48-d2e87349a8e7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a0f14cb5-cae9-4a65-8479-a304c741db9d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a12b09e1-4706-4a93-903c-4fcec38058d4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a1a32aa8-0a14-458d-9f2f-ba4dc1fe595c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a227f8ff-a48e-42a3-bcdf-3ecb720c93f2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a2e7143f-0b27-45ee-94bc-e6505d4702ce"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a38441cf-f078-472c-8b99-0eaafa9e4701"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a3a08d1e-297a-43a9-bf43-42e5e726572a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a3fae462-f4e1-4b5d-8388-a85e3da03648"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a44766e2-4558-4ea3-b698-590c0f47643c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a470c3e4-1f6c-4c9e-b43a-ced2d293ce39"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a4854d07-cbf4-46e7-b480-3e5ee2c4f8c0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a4b5d02e-4ba8-495e-916e-2a93fd5a92c1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a4c6816e-61de-470f-afad-bd07b2265e07"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a50d32e3-4cac-438b-a8d9-fed63b1e9c3f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a53ac5c6-4f3a-4ed1-8f8c-38a3ce050204"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a5508707-b0ea-4d4d-b73b-67a2ad9b7fe6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a5dea436-d5ef-48dd-a2f6-77ab4014b329"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a66e9b67-bde5-4997-8241-7423c9172fa5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a6a2ea74-a473-4996-9acf-e2ffa18d996c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a7262402-2f8a-4748-a0a6-aa4f49fa6d20"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a7da3807-7e0f-40e2-adde-3cf0e7aba5d5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a89fb272-a846-484c-8236-50d3921060ca"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a8bc532a-5e22-40bf-a6bb-597685fdb4ac"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a9139e9b-2d8c-4019-99f4-e365079fb367"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a938da27-b31f-4857-9162-4a2e73e897ce"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a9b62e16-d0a3-497b-a7bc-5930d36275cf"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("a9cea159-5a4b-4f2c-ae44-717a5b3cd864"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aa0d196b-e389-42e2-865f-40a2b7053bb2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aad19d3d-2928-44d7-9dd5-820f33ce86e7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ab0ead88-b6cd-400c-9769-9ae6d8d6e971"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ab100a3d-6d98-4fba-8d5b-dbfcb01e10d2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ab10457e-989e-4c99-9bab-7983aed6eced"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ab4f58a7-4594-4252-90db-ced6adbda0c8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ab7f14b6-c13f-4775-b828-b4c975d1672d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ab91dfb5-de31-4eaf-9b86-faa074a637a7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ab9b98b6-9b46-4cf6-b22e-b103e1ce29d5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ac1e32ba-fe13-40b3-a4fe-682168f0bbff"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ac251fe3-89ba-4cea-99f2-11d369ebc891"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("acb4d453-df5c-4ec6-8a50-9a0aa2e52fa4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("acc4dd21-9ebc-49d5-8ca1-b2339c966efa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ace27f2f-5443-492d-ab53-2554efefe0a7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ad535c59-d6bc-4497-900b-33e5bd0f4697"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ad779ed4-cb6c-4694-8925-b0bdd6c06a35"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("adb99a32-249f-49d9-a595-c2d736556023"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aec29400-0a60-4c9c-aa96-88899c64d2f8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("aedc3422-896a-4d33-ae58-945f0eefe435"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("afd39e09-5280-4dcb-98f6-6dc1dfd3bdc5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b06fd17f-3c4f-45c6-9987-019bc31c030b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b0efb93d-bbfa-4ed2-8bb7-cc4ad9661333"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b147d8b2-1fc7-47db-8f04-6fd52683610d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b1e968ee-09f3-4581-8358-c27669a28999"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b20e224d-80fa-4c07-a87a-605d91da14c0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b2220027-0b1f-46ef-8f68-0afb55f31f8c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b23cea1c-3d2c-4389-8daa-b845d9edb316"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b28365db-a862-4cd1-8068-28b8e87b555d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b2e46528-a5fa-494c-b7e1-02f7b326c437"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b3042815-89ae-4b88-bc91-22c6c198a3f5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b309242c-92fd-4d2e-8e38-aa539c0b5b92"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b31a15c3-ac77-4e40-b770-40128ac39268"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b369aeb8-fe4a-4507-8842-9c0b55948595"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b401ef48-a4b9-47ff-99bd-4d3ee5a115a1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b439ea0e-e62e-45ff-942e-6a9c4b78b1b5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b59e2f63-c0cf-4fba-8fc5-b59bd4e7d0ea"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b61d365b-0713-4984-a0be-0f56c7b87b15"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b687d7e5-ed22-450b-b157-24d1f27c46c1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b68a83d8-35ef-48b2-9a2d-1ffc42907b14"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b701e4b9-9971-4172-9e7b-508039e65d60"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b7257252-52a4-4a42-ad50-bb6afc1514b9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b76e58be-907b-45c5-b63c-05d17c1e6df8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b81d7f31-e427-4f5d-a0dd-5021df46f27c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("b845cb9a-a7ee-445d-b824-ee6405f36073"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("babc39c9-755d-46df-8dc3-93ce6e18a64f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bb2c5570-f58d-4889-a68f-89ca6bc263b5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bba5693b-17b6-4e3b-b27c-517ae366f05d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bbaa4906-2f1f-4b40-877a-715d82537b99"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bbfb2c8a-9337-407e-9bde-f1c0c3a5a563"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bc2b6017-bca3-4c5b-9cd7-3f3dc0994006"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bcb5fd62-e2fa-48fd-bfa0-5befbf8b3cef"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bce3f097-bb5f-430c-964d-74df7eb1f673"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bceaed8d-ca38-43b8-8cb3-a3acc1d45f86"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bdc2ad68-5e85-4096-bcc4-a2b457c42467"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bde07fe1-ccc7-4816-be5f-53104b176060"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("bec1fcbf-fcd3-4294-a596-2d140cd5a97f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c12a9517-271d-49bc-bf93-66cfeada5e19"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c1ae0e39-95a6-40a6-9de1-0d2df01672ce"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c278ebbd-810f-4a90-b576-97d337e2f522"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c2ee792c-cc40-4370-97f4-1b911ccd88b3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c3611092-ec5b-4909-96be-aad3ae5f96ec"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c36b114c-9574-4f7f-86e6-52066564dcde"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c3e60715-766d-47c7-b87b-93154ab60983"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c463115c-3345-4559-a2ca-5bea96de92e3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c4753d20-016b-446b-99cc-ecb5ea6ef6b0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c4c83eb2-6af8-49a7-8059-1544e42faf67"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c4e3fb02-e063-4751-9362-522efde6883e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c4e6e71d-7f74-41f2-b32e-07112ff38ffd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c4ebebcf-8034-4828-9249-e537e5d5e483"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c66adefc-486c-4f0a-aaad-5ca764bc44a1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c67241b3-df73-4bc4-b65b-2a4257f4c99c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c68d5763-cf17-4e21-adc1-5b9a0fc3a8f6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c6f6e17f-bf97-4562-ba39-435d6ee67b05"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c745d324-69f4-478c-ba92-0189d3040a5c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c7bb347c-7ce8-4b67-b72f-a4f51fe3186b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c7c760d6-2f44-4c82-98e4-f5e6f45bd047"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c860ee7a-d3a1-4a41-96ad-43a144219c6a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c8637a39-7661-4ee2-9ddd-bc72c8b431b6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c89b4be6-024e-430c-9981-8a1e6245dcac"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c926fb7f-1c03-4c5b-b023-c17417a2acf6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("c97cfe45-6eb3-4552-b06b-d6ce0f906842"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ca1ff2a0-47b3-44d5-975e-b0c454d3007e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ca91865d-eff8-406f-8c5b-a5cc7126ab9f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ca9b7b5e-82e2-4fd2-aab1-07320bc481c6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ca9eb0a2-20e4-4a36-a664-42eae5938923"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("caaa72ba-9bb1-4c6e-be43-38e3ea957600"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cb1ee892-adc3-4700-8a85-3d939d7491ae"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cb8d3e14-f8cb-4c81-952d-7fd54bab09c9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cb9b7c1a-c97d-4549-b671-051396e04938"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cbf66115-d554-4433-a01f-be7629675e8a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cc579829-29b8-40cd-b274-5d2d1328e0c8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cc7dd679-e69a-4db7-bff0-3ac9e26310e1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cced3acc-9085-46ee-88fc-186d31a5e3e3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cd0bbbee-730d-4ba7-9195-90d6aeb9d67e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cd8d79dc-fbd7-4f65-8884-549a61c4efc2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cdb85b8a-3122-4e55-8a31-e56062eb73f7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cdcee052-22ad-4f27-a52b-6cad437500ac"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cde6c7fa-c873-4d77-87b4-664b2af2007d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ceb96fb8-2402-4b36-8a02-e5cb9f81051c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cec18d0f-40f8-4c1e-a80d-b027103d45cd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cee19363-fdef-4a4e-a307-9713cea6dd8a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("cfe13956-c1ed-4961-ade3-f3f610fa012b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d09d6a57-d6d2-4f58-88bc-ac53af70161e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d11f987d-ba9e-4777-b2a4-54163cb06ecb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d1673f3b-05bd-483c-a6b2-6cd6d6e21c8d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d16c595f-bf57-4b73-b292-1e46b3aca4b8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d1af7ebf-1a32-44bd-baa0-6db4e7aaea19"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d2ad71d1-b6a1-4b5a-a3b4-f721f9e0f419"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d3223e5a-beba-427b-bd6f-1a46b00e2c8a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d329fb4b-80ce-4cde-9aa2-aaca553ca32f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d351c42c-dc76-423d-b99e-47f504db0423"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d3aa96d3-c711-4c27-b933-b73935505919"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d3cd60d6-8f0f-451d-99a4-45d33785c166"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d3ebdd27-a587-494e-96a9-319c70e25208"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d4b00688-41fa-4540-8450-b4a3ede6bf57"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d4b08295-63c8-4ce3-b9f2-042a02761bfc"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d5059e69-61ef-46c6-9266-cf65c10c0bea"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d532ae2a-d57c-4d61-9d2a-c4b75f762f17"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d676382e-3697-4df3-91de-bd102ebc3011"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d6a0a3f6-332a-4dce-8120-7d73fc8c8ccd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d7398615-28f2-481d-b206-ad11ab941ef6"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d75d8ed8-7ec4-4312-afff-4f49409892da"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d767ea42-130d-4644-b02b-0623bb0bf7b9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d78b16ef-613f-4e01-9d6d-d474b9e62354"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d7ba90cd-b2a8-459f-91d6-87cce5f84bba"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d7d7053f-0c04-4e90-a7cd-acc20f292b7b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d8950b6a-584d-4a00-9e97-946b41fb34c1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d8b5d6ca-a3c9-4484-91d7-b8ec30d80d01"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d8c660c0-ffe5-4a52-b9b4-b505d84d1356"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d8d491f9-b128-43b9-836b-42e7cb892369"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d9a2d1b8-ebbd-4683-a45a-6aaa1eac7038"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("d9f613a8-d3d1-40a8-8587-44f7c21430ea"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("da1e9cea-5a3e-49f6-a0eb-bb1d7d4bc4c9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("daa0d4ae-dabd-45dd-beb2-92d83e695c24"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dab298ff-96ea-4f21-9f53-982aaf08a787"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dade3a3f-d8db-4ce3-8d46-ba79f66144aa"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("daf8aeb9-fb7b-46cf-af9a-4b6e89bd196a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("db42c9e8-70c7-4a0a-96e8-3fb556b5a984"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("db7cf440-eb6c-44fd-a7a6-1c160b2bbb1b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("db8aa177-0472-45fd-bc5b-dc9cbef1c323"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dc2558f9-b691-443b-a691-21696db01f2c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dc4f3361-7d16-48de-b452-afab4865126f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dcfb39db-2002-4bbd-8034-1b1b14f6e2e1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dd307398-ebd0-436e-aab4-6daf544fd926"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dd5b5d16-d3dd-4de9-83f1-8a2a0c3ed9b2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dd78572e-6fca-4c60-b2f3-14127ad1b538"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ddeae864-bf92-4b64-b6df-8c464c17e4d8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("dee0b8bf-f714-4a6b-ba66-32fce8e88a45"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("df5127a0-a2b7-4b70-9f13-158ccf524f5b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e1a7ae65-af85-48a1-b5a8-815a334fd3fd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e1bbe975-6414-4f40-97f2-a5fd563cbcd9"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e1c46135-6df0-4f78-b005-13b2b8a837d0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e1dd2873-fb38-4a65-bc98-ab77607423e8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e266879a-d31b-4f02-8ca1-8eaefe0de842"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e298a9fc-9ca4-4779-a1f3-bba18a830270"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e2f7c2f3-8544-428d-9d95-47dd759c96f2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e3003cf2-6b04-4afa-b1ec-858ad1b9473b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e34e4c35-0ce4-429e-a25b-10e9665be968"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e397f316-ad2d-4705-9b14-dc3d6d609e58"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e3a5d6cd-86f1-45f0-bc20-e779bb191735"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e3bfca10-f59a-4eca-b0db-2f7fb584c1b8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e4744e07-e1b9-488b-92e9-76cd3603ab01"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e4c5e5c0-46b4-4c19-be6a-e305931ebc20"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e556590a-a686-495c-945e-abfb76e5fd7c"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e57ebbe4-fa59-4905-9576-4091d9f43f57"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e5e2c480-a0ed-4135-aaee-fb769ecd79c5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e63a5465-5b6f-4480-acb4-462293928ebe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e65dbd0e-2a90-4140-aec2-445cf3611d7e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e6c544d9-867d-4488-a562-ffce385384e3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e6c5db51-8dad-4f0f-86cf-0b8bc03b2b11"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e6d73ac7-d74c-46db-882d-0905c60934ec"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e6f8088e-2c01-4b60-96de-72ee72c51192"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e70e15a5-9232-413c-8939-f90c2b038881"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e7782b3b-8648-4dec-9a05-75448a49025e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e8207973-5d40-4da2-82cb-7d6f920dc697"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e83cff82-3cfd-43a8-a4b0-6c5c6ee2ad0a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e8405ae8-dc53-41c6-894e-515c209884b8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e8e3f24b-cafb-4384-989c-5315743bd26a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e8e93fa6-4802-4007-9730-2d5901db82e1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e90a476a-2e23-4382-86db-658eab5dcb2b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e95b2403-c1fe-4e0c-9ae1-74535af6e174"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("e9621c5f-f599-48de-ad95-287b8c6b89ac"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eae24817-6877-4738-ae50-6bb4d2d87bb2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eafa3d5d-07cc-4cd7-bcb5-ee010516e534"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eb767f76-25a4-4a28-8705-fc0e92246391"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ec390903-bb0c-4534-ad63-489d69250cf0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ecee02a8-598b-4d8e-a75b-a1c905d8668f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ed0269d0-2c1b-459b-bbf8-b953ec47f631"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ed7081c1-3e8a-48c5-bc3d-c39d0d4362ac"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ed8554a4-3602-4cb3-9592-a285c0b7803a"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ee1f1092-92d3-4784-980e-91ed869f6657"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("eeb20537-fb19-4bbf-b628-7b319e796f7b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ef021383-0f6b-4319-85ab-e092d909c2c1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ef31378c-f3d7-4738-89c2-c2118d6dab87"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("efa3e629-14a5-49da-bd29-6f833eb80972"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f0040751-2e35-4a20-a466-8c2b8d39a46f"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f04b8237-6e48-445c-ac95-c5b5910d16c5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f0fbe95d-0c62-429c-92b0-3dc448cb31fe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f117a86e-c5c1-40c3-980d-9f4ba37252e2"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f152b044-fbe3-46e1-9be4-a151dd63f1a8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f274367a-6e7a-452c-8696-8d2d5e18daf3"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f350d1ec-5cdb-4e03-8c4c-74fac8c05aeb"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f356cfd6-dd08-4b3a-9493-99edc2ec4f18"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f381a0bc-0bc9-49bf-8589-0cb863ad9a93"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f3d9f525-3111-43bb-816c-8efbb0a56e04"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f62258ba-d911-4a1a-ab3c-3cb9d846484b"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f6be3897-5249-4607-b714-53f5670189c4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f6da3641-2a56-43c3-8d78-57d0565033fe"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f72f733e-5b79-40f3-8c83-c1debbf81050"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f774e796-a894-46b5-bd8d-3749883d1f89"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f7adcad1-0b0e-4a88-9a77-cb59b11109d7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f7d0c458-0e0b-4ef0-b429-b54bc2d522e4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f81e320b-cbe4-4198-a097-1572965d1ea4"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f855edd8-47f3-4362-ac67-169beb032300"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f8cf823e-e922-476b-9762-9ad2f3f0faa5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f917e8bd-817d-4dc6-8e71-6d06bb8d85f0"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f9cc2e22-2674-458b-b08e-dd5d493d76c7"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("f9d5dd15-5f78-42f7-8ca4-4a1ba08c4a68"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fa0fd34c-dc9f-4b3f-9355-3a1b0088df96"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fab2b836-9efc-4b59-b0f4-4c3ee4610ce1"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fb43e610-ce52-4b62-9b93-c8dc0630502e"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fb5147ba-42b2-4644-a4c4-8e810cf5ed38"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fb99109a-8e7f-4d7f-a25f-3aedcb2bbb0d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fcefc5cf-c7ee-4c59-81b3-1f68b7f46105"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fd21bfec-f224-437a-9e90-90c5f232c0b5"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fd22c466-7ede-4dbd-9f7d-6e9775174082"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fd970e1f-e7c1-4780-a4c6-e0297718be13"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fdae59f8-dad2-40a5-a810-867e747e9678"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fdc80e5e-cf2d-45d7-b892-9ac6703c9276"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fdded90f-220f-4abc-8247-469acd587772"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fe10b4d4-e143-4d41-bf0c-6fb5b73627af"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("fece827c-de38-43d9-9f47-9ada6f3ca3cd"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ff4ec7ce-5f2e-4ce9-a746-b6235b6fe994"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ff6022b3-ee7d-4de1-8062-67967132716d"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ff941e97-e401-42b1-b4f0-90e82db14fb8"));

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: new Guid("ff9b2afd-34fd-4f9b-9c68-76b5504f869c"));

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") });

            migrationBuilder.DeleteData(
                table: "ParentStudents",
                keyColumns: new[] { "ParentId", "StudentId" },
                keyValues: new object[] { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c") });

            migrationBuilder.CreateTable(
                name: "StudentTeachers",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTeachers", x => new { x.StudentId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_StudentTeachers_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "SemesterId", "StudentId", "Type", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("13814383-896a-4092-953b-cc392e74b99f"), "Computer16", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6113), "192.168.1.56", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 0, null, null, null },
                    { new Guid("13df78fb-b646-4961-b70c-a3d7ba23ff1f"), "Computer24", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6147), "192.168.1.10", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("1620ca06-4eaa-48ea-a9b1-a72db426d0db"), "Computer13", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6101), "192.168.1.47", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("1dab6c87-2696-4311-82e2-574df77fe1f0"), "Computer50", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6265), "192.168.1.11", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("22fdd99c-6a4e-4a21-a511-895284a609c4"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6052), "192.168.1.86", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("2702afa0-c0c4-4586-88ae-753846a319ae"), "Computer39", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6218), "192.168.1.36", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null },
                    { new Guid("2f011854-00dd-4aa8-a21a-18cc0534dfb4"), "Computer6", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6070), "192.168.1.77", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null },
                    { new Guid("2fe4e089-120f-4483-908c-6cf0ae61f981"), "Computer57", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6293), "192.168.1.68", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null },
                    { new Guid("3a9dbdc5-3bf7-4c5f-80a2-8f17cceb209c"), "Computer36", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6205), "192.168.1.97", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 2, null, null, null },
                    { new Guid("3d006d10-07f8-4c5a-ac9b-017b032bec0a"), "Computer60", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6317), "192.168.1.87", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null },
                    { new Guid("3de849b7-3238-4241-9834-9ce534463cdf"), "Computer12", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6097), "192.168.1.70", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 1, null, null, null },
                    { new Guid("3ffe8d94-715e-4b1a-8037-b270bbdafdfc"), "Computer41", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6226), "192.168.1.7", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("40471b1b-b495-4eb1-8577-136506f7359c"), "Computer58", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6298), "192.168.1.81", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 2, null, null, null },
                    { new Guid("42c801ed-67ea-44a8-ba60-1d26b5d63954"), "Computer45", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6243), "192.168.1.57", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("43e35c4d-8f07-4c92-8414-a410426226ef"), "Computer43", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6236), "192.168.1.66", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("47efa78e-b70a-4c45-9b13-dc4da78397aa"), "Computer54", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6281), "192.168.1.50", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null },
                    { new Guid("4832f719-7038-4e14-b0ff-14aff40cbb30"), "Computer27", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6161), "192.168.1.43", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("4ff46f1f-1de3-4cd1-839a-8439d22cc269"), "Computer52", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6273), "192.168.1.43", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("584fad35-c897-44a1-b513-0fd99aac5fb0"), "Computer14", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6105), "192.168.1.43", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 1, null, null, null },
                    { new Guid("5bdbea96-3bac-44fc-a4bb-740998d624d7"), "Computer10", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6089), "192.168.1.64", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("674991e9-9148-4e96-a1bb-b572eae2fd1e"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6004), "192.168.1.55", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 0, null, null, null },
                    { new Guid("695249c6-cb8e-4413-a00f-58f396f1ef41"), "Computer25", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6151), "192.168.1.43", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 1, null, null, null },
                    { new Guid("6cf4dcb8-7a49-420f-b1f9-00b392079c59"), "Computer20", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6131), "192.168.1.32", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("6ec3bcae-3357-4ce4-b4de-97d08192d58f"), "Computer55", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6285), "192.168.1.98", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 0, null, null, null },
                    { new Guid("6f405c20-52e4-4f0e-b1b3-f185bfbd4245"), "Computer3", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6057), "192.168.1.61", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("71cf8392-5587-4b89-bb56-66712749ab2d"), "Computer28", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6165), "192.168.1.61", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("72149a6b-f5e0-457c-a3e4-dd995d8f7c75"), "Computer42", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6232), "192.168.1.39", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 1, null, null, null },
                    { new Guid("74513fe9-673f-493a-b667-50b827d89b90"), "Computer21", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6135), "192.168.1.70", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("77415ba6-8d6e-42a3-be5a-614ac152300d"), "Computer7", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6074), "192.168.1.63", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null },
                    { new Guid("7f20bcff-ac5d-4d30-92b4-86256bc72305"), "Computer22", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6139), "192.168.1.75", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("813c70e7-fb14-481d-9445-045773441f70"), "Computer33", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6191), "192.168.1.37", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 0, null, null, null },
                    { new Guid("82058ba5-b87f-48e3-a2d5-f5b6f5b49679"), "Computer47", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6252), "192.168.1.73", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 1, null, null, null },
                    { new Guid("93a6501e-a30f-43b9-a61e-70d4fa2a2b27"), "Computer48", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6255), "192.168.1.39", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), 0, null, null, null },
                    { new Guid("9722ee05-1867-4b5a-9c78-cee2b81f6a59"), "Computer53", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6277), "192.168.1.91", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 1, null, null, null },
                    { new Guid("9b1db56e-9365-4007-92a4-6574a6eb28ab"), "Computer4", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6060), "192.168.1.95", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("9b98c894-2f4d-457c-829c-7e10ee0b71a5"), "Computer19", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6127), "192.168.1.22", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 2, null, null, null },
                    { new Guid("b017d95f-e2f3-47bf-9273-bd539e0b5b79"), "Computer18", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6123), "192.168.1.34", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 2, null, null, null },
                    { new Guid("b1cfa455-bf40-4e1a-82e8-221c4d2312eb"), "Computer9", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6082), "192.168.1.82", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), 2, null, null, null },
                    { new Guid("b23e6099-0ed4-4b9d-86ba-952a48c3e2ad"), "Computer5", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6064), "192.168.1.32", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null },
                    { new Guid("b6690389-b174-4f90-80d3-76e4aeb0c1c7"), "Computer17", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6117), "192.168.1.4", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null },
                    { new Guid("bd79f10b-ddc9-431b-88a2-58121cead337"), "Computer59", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6302), "192.168.1.81", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("c89b574f-dcd4-4988-b724-15456b7dde1a"), "Computer34", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6198), "192.168.1.44", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 0, null, null, null },
                    { new Guid("ca4d89fb-0e83-4090-b525-138d29a05ce7"), "Computer23", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6143), "192.168.1.97", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null },
                    { new Guid("d16c6b16-9b32-48f5-87c8-0f99347cba28"), "Computer37", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6210), "192.168.1.87", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("d3798645-8c33-4eca-a96a-7da3dd54ce47"), "Computer49", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6259), "192.168.1.36", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), 2, null, null, null },
                    { new Guid("d7852cff-4e05-4a9e-aa8d-240c43386733"), "Computer32", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6187), "192.168.1.52", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 0, null, null, null },
                    { new Guid("d9a638b3-2d1b-45e8-9d10-c1c078433408"), "Computer31", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6183), "192.168.1.45", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), 1, null, null, null },
                    { new Guid("da0832eb-6175-4b61-9f62-5b96b83d6c19"), "Computer11", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6093), "192.168.1.61", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 2, null, null, null },
                    { new Guid("da931601-0acb-412b-8ae8-7d20d69a8dc3"), "Computer35", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6201), "192.168.1.73", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), 0, null, null, null },
                    { new Guid("dbf35703-39fd-443c-abc5-ba4b5de86da9"), "Computer46", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6247), "192.168.1.2", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), 1, null, null, null },
                    { new Guid("e058e845-1bc2-48f4-87a5-955978b1cc8f"), "Computer44", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6239), "192.168.1.30", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("e265b59a-47e6-4ff3-9e5d-160c0ccb2b18"), "Computer29", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6174), "192.168.1.50", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), 2, null, null, null },
                    { new Guid("e3bc3b4d-5770-49b2-b338-2ab37e1aaceb"), "Computer26", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6157), "192.168.1.85", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("e3d62a52-c6d3-4ec2-8ff8-cd781d26f38a"), "Computer30", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6179), "192.168.1.69", null, new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"), new Guid("15b6a548-4045-4892-904a-aeeba517960d"), 0, null, null, null },
                    { new Guid("e7d43844-0a45-47d4-a91d-7fd384c35631"), "Computer8", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6078), "192.168.1.12", null, new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 2, null, null, null },
                    { new Guid("eb22b25b-fa5c-41ca-b202-d73872131447"), "Computer51", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6269), "192.168.1.84", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 0, null, null, null },
                    { new Guid("f2d19713-4864-4d7a-9363-c2d73abb8f60"), "Computer40", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6222), "192.168.1.56", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), 2, null, null, null },
                    { new Guid("f4de8dcb-9aa9-4513-a7f8-ff6e290cea1e"), "Computer38", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6214), "192.168.1.5", null, new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), 2, null, null, null },
                    { new Guid("f9759118-1a60-4069-82d3-e9e0c13a4fcd"), "Computer15", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6109), "192.168.1.42", null, new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), 2, null, null, null },
                    { new Guid("fb7aed6b-a6cf-4f5c-8469-8b26704d0d74"), "Computer56", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(6289), "192.168.1.51", null, new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"), new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), 1, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "AttendanceDate", "AttendanceStatus", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("00209d2d-0aba-43f1-84c5-ae3746d90b71"), new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer9", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7208), "192.168.1.12", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("05f5c056-f728-4eb8-bc08-d0083e0b20f8"), new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer20", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7270), "192.168.1.52", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("06bff186-8553-4016-ac88-1d63ae207c00"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer51", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7432), "192.168.1.24", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("0a057adf-c5e8-43eb-b05e-d2d5406ca693"), new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer37", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7360), "192.168.1.80", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("115020b1-f87f-42a1-abfa-85b9047dde67"), new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer40", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7376), "192.168.1.40", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("1735c9c1-fda5-4212-a8b7-4512a8540c84"), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer46", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7406), "192.168.1.74", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("188febe2-eccd-444e-a99b-aef89c333767"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer7", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7198), "192.168.1.89", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1b6298f9-c827-495d-a5c2-e51d63a86dfa"), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer18", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7256), "192.168.1.14", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("269583fb-ec1e-417b-9016-c8343b41fef3"), new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer27", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7302), "192.168.1.75", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("2b8cf035-2d00-4ba2-ba15-86784be9d5a8"), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer22", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7278), "192.168.1.45", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("2cfa5f6e-cf37-421a-80f2-8d56b75df90c"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer26", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7296), "192.168.1.31", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("2fa3b3d5-0478-4698-9f51-c79734132698"), new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer16", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7245), "192.168.1.68", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("309511a4-b058-477c-9e9a-3fd02f4ca58a"), new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer47", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7411), "192.168.1.19", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("31df290a-887f-4a35-ae43-e3d4821896a4"), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer53", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7442), "192.168.1.85", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("3295c052-19f6-418b-b313-3de4a60e5a12"), new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer36", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7356), "192.168.1.7", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("37349423-e8c7-4052-985d-5420c78a925b"), new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer31", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7328), "192.168.1.61", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("3afcf884-f8a4-4057-a7cb-23e431df4d69"), new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer12", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7226), "192.168.1.93", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("3e9bea53-fefc-405c-a360-970b58317c71"), new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer48", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7415), "192.168.1.46", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("45d33f57-03c5-442c-9f5a-f56b876ef0cb"), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer8", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7203), "192.168.1.85", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("460d4267-e392-4200-a7ea-69c8f92097d6"), new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer28", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7313), "192.168.1.47", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("4a94683a-e411-457f-b6b4-bc8ab6cf7629"), new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer25", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7292), "192.168.1.11", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("4db072c0-2ec1-4599-abd4-7af640600006"), new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer39", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7372), "192.168.1.28", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("551b886e-4f2f-4de1-800c-81c3725ff24f"), new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer13", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7230), "192.168.1.42", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5761ae14-36f2-4ec5-bdbf-2a48101653b0"), new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer30", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7323), "192.168.1.68", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("5938993d-4703-45f3-9107-96c76465f1b3"), new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7163), "192.168.1.76", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("73a26842-9ecc-4721-b63f-d02cf582c81a"), new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer33", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7338), "192.168.1.16", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7531e312-eb9d-4fca-85ba-5d0c07352df6"), new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer29", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7318), "192.168.1.59", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("75c4a2f1-23ba-45b7-b3e5-efd3311fda59"), new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer50", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7425), "192.168.1.67", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("80992068-7437-438e-b67f-febf4a858d55"), new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer32", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7333), "192.168.1.71", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("84850e90-6160-4177-a147-12f2edfecf4f"), new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer6", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7193), "192.168.1.68", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("984f9b95-f000-4345-ba72-fe22109de680"), new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer42", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7386), "192.168.1.2", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("9aba04af-f1c3-44b0-8219-24bd40e00a38"), new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer3", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7176), "192.168.1.82", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9f60725f-3728-4b9b-ad79-8323828d6305"), new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7151), "192.168.1.6", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("a101c8d9-5f64-4d3b-a326-8639a9cd7498"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer35", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7351), "192.168.1.36", new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("a3f5821f-588b-4957-b06a-03c4bb0bd1d0"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer5", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7188), "192.168.1.54", new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("a5ef5b4f-7ecd-4313-923b-0a06c9d78b3a"), new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer4", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7181), "192.168.1.86", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("a91887c2-7ac1-4e23-8a2e-ec44859dc01a"), new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer24", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7287), "192.168.1.9", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("c4c564a5-5a6f-4bbf-9fd2-5d2d78a52acb"), new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer41", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7381), "192.168.1.85", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("c7938211-1f7d-4718-80a3-3dd0be100287"), new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer55", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7452), "192.168.1.54", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("cd6028f1-7db0-49f5-bcdd-21a5811ff061"), new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer38", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7366), "192.168.1.27", new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("cd6517f0-6a79-49c6-8e6f-7bf73bd0d2fa"), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer43", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7392), "192.168.1.13", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("d8d3d76c-25b2-4124-bc82-a0e2acebdab8"), new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer21", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7274), "192.168.1.72", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("db041518-6a66-4e0c-ba97-4fde6edbd581"), new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer23", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7283), "192.168.1.12", new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("dd86bf22-947d-48ff-a73f-8e60b73a79ca"), new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer54", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7446), "192.168.1.35", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("de68a7a5-3803-496a-8ddf-b3a6dd3abd68"), new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer17", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7250), "192.168.1.34", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("e4d84602-96cc-4886-8115-2dc0644164d1"), new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer34", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7344), "192.168.1.44", new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("e60f223b-8956-4bbb-829b-276e9cc061f1"), new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer11", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7221), "192.168.1.20", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("e6c5985b-5b5e-48d5-8501-52ec606293e0"), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7167), "192.168.1.41", new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f1db920d-5b41-4766-8c0f-d7d8624c9a59"), new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer44", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7397), "192.168.1.82", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f33c9bac-98fe-43ef-b9d2-c733bdb47ada"), new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer52", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7437), "192.168.1.42", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f33fa7be-1f48-4058-9d3f-2f1703a8b414"), new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer15", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7240), "192.168.1.77", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f3537be7-447a-454f-8472-63b5ff2514e1"), new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer49", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7419), "192.168.1.9", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f436e14b-ce8c-454b-a694-3da113a54aca"), new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Computer10", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7214), "192.168.1.9", new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("f6a29744-d9ee-4553-b87c-233c3e496c42"), new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Computer19", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7265), "192.168.1.44", new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f9dd41c1-3d4b-4aaf-a628-ad87cbdae320"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Computer45", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7402), "192.168.1.67", new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("fb68d6dc-004e-48e2-bc97-d799b84c9da6"), new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Computer14", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(7235), "192.168.1.56", new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("05c0da3b-87a7-4b85-b3e6-aa133dbab5f0"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("22d118a6-a81b-435f-a4c7-ffed69e37f12"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("666917cb-ccff-46e2-81be-1dc06b74ddcb"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: new Guid("7a3741e2-d501-4710-b0c9-a0a53142ad79"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.InsertData(
                table: "DiscontinuedStudents",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "StudentId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("98911bd9-852a-41db-9f46-d0bdb6395c9d"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(7895), "192.168.1.51", new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), null, null, null },
                    { new Guid("e862b094-5cfe-400f-87b8-66c3f9d697ad"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(7878), "192.168.1.83", new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ExamNumber", "Score", "StudentId", "SubCourseId", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { new Guid("00180a39-67c2-4eb1-84f4-3fc539881437"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1127), "192.168.1.30", (byte)2, 86.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("001a0066-e0f3-4ba6-a99d-d154036e93dc"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(744), "192.168.1.62", (byte)2, 82.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("002371e6-7ee3-4445-9ea8-963db0ef1f09"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1883), "192.168.1.97", (byte)3, 17.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("00540c20-1ccd-46be-ae20-7d522950837e"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9108), "192.168.1.58", (byte)1, 55.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("00de51c8-dabd-44f2-a0c0-a6d7091849ec"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1037), "192.168.1.94", (byte)2, 71.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("00def782-cc3e-4f7d-b90b-e9654ecdbe70"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9448), "192.168.1.20", (byte)1, 51.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("0116b187-cd60-4540-b601-e3e0e8c857ba"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1203), "192.168.1.21", (byte)3, 90.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("02402ccd-84d6-4881-865b-9575f14f5118"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(157), "192.168.1.29", (byte)2, 63.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("024d87b3-c7a1-41a9-b75c-7322044b1ddf"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1116), "192.168.1.81", (byte)2, 80.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("0307b2cd-6ed4-4ae5-bfb4-6dbef9a18c57"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9064), "192.168.1.86", (byte)1, 36.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("0331f976-a736-40fa-b646-8754c2d1c521"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1445), "192.168.1.28", (byte)3, 70.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("038cbfc1-b32c-4a44-89e9-cc81a5e0bfc2"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(273), "192.168.1.82", (byte)2, 8.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("03e7ad16-f470-4487-9607-2fd5c097ed62"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1389), "192.168.1.42", (byte)3, 76.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("042cda12-3f22-4033-9bf0-574d5270a3b5"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1506), "192.168.1.6", (byte)3, 63.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("0441a25d-a09b-464b-832b-8e1fdf769ae0"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1575), "192.168.1.69", (byte)3, 41.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("04b345e4-28df-48dc-86b2-a17b6a1114ad"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(310), "192.168.1.65", (byte)2, 77.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("05d8e38b-53cb-478c-a0af-209e391a13a2"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1481), "192.168.1.64", (byte)3, 58.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("05f115c3-1ebb-4097-8565-7c7554c7f7eb"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(661), "192.168.1.97", (byte)2, 44.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("0630141b-f04a-4073-9ee1-d4ea79ce368a"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9502), "192.168.1.46", (byte)1, 78.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("06699b9d-7a8b-41e4-bfbd-ec4c869fe1d5"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1174), "192.168.1.68", (byte)2, 51.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("0685c3de-0299-4efd-aeea-5632bdc9ac42"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(400), "192.168.1.1", (byte)2, 5.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("06b3b5ed-681a-4a62-8fc7-f578e4cd8f48"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(38), "192.168.1.16", (byte)1, 62.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("07764fc8-9840-4836-b5ca-a1e1febdcfb1"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(740), "192.168.1.9", (byte)2, 43.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("08492694-228d-41e7-87b0-8986738b3eff"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9494), "192.168.1.78", (byte)1, 41.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("086f9d32-ec20-48b2-bbb5-1134c4bbd64c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9915), "192.168.1.63", (byte)1, 36.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("09965bac-6188-42a8-857a-17505c5ecaeb"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9158), "192.168.1.66", (byte)1, 30.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("09b3740c-1510-44db-b1ea-314aaef7e30d"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(539), "192.168.1.79", (byte)2, 59.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("09fc66f1-999b-4128-adf5-3c112f6ff654"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(950), "192.168.1.73", (byte)2, 15.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("0a6df0ba-e001-4fff-95d5-4d48dd5b0894"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(971), "192.168.1.40", (byte)2, 24.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("0a793da5-a0ad-4cc8-8d62-9bedb825f902"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(384), "192.168.1.96", (byte)2, 13.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("0abe34ce-65c6-4db0-9e75-dfb00f313a9b"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9347), "192.168.1.80", (byte)1, 49.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("0ac48b74-f761-4a0b-93b6-0505f8eb15fa"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(145), "192.168.1.76", (byte)2, 77.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("0b544d3e-59fc-4ce4-9bbf-2417a5892875"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1160), "192.168.1.48", (byte)2, 51.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("0b6346d0-38c7-473e-9582-3a9361b3dcbf"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(899), "192.168.1.25", (byte)2, 90.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("0b8422dc-6d07-4abe-92c8-04ba047ca500"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9112), "192.168.1.83", (byte)1, 82.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("0ba2e791-8b31-4941-bc93-8bbfbe12d3f7"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(698), "192.168.1.13", (byte)2, 14.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0bb5d439-a0e0-45ef-927b-8f139a0fa361"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2252), "192.168.1.92", (byte)3, 91.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("0bd6ce54-3630-4fae-b530-05a8d372a910"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1514), "192.168.1.62", (byte)3, 22.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("0ce9a7f2-c6d4-4f5b-93b4-059068e62a40"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(264), "192.168.1.48", (byte)2, 60.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("0db19ba8-f6c2-4129-908d-1962515f9ecf"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9577), "192.168.1.80", (byte)1, 36.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("0dd36471-3999-4af4-967f-cca59dcfa5bf"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1662), "192.168.1.5", (byte)3, 79.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("0e6b2ab1-7007-428b-b602-c0448a090455"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9085), "192.168.1.84", (byte)1, 55.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("0e9a42f4-c8c0-4026-b374-a65f2213dcd4"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1650), "192.168.1.60", (byte)3, 26.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("0edb12dd-1c7f-437a-a0bd-5da4b31d8237"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(786), "192.168.1.68", (byte)2, 38.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("0f75d4f6-288f-4d6d-9d84-3d9d414ff4ce"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1149), "192.168.1.97", (byte)2, 19.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("10a283b3-f800-4864-8585-ec7da25b8b53"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1153), "192.168.1.37", (byte)2, 62.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("10ad6764-31c2-4430-92d9-3493ad733538"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9358), "192.168.1.35", (byte)1, 25.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("110c1a93-ff0e-483f-ab16-4e620d776d3f"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(576), "192.168.1.58", (byte)2, 78.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("11722b6a-6940-4420-ae8e-7d58a630b926"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9473), "192.168.1.62", (byte)1, 89.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("11a0ed33-f7f6-4f74-ad8e-cfe82a8391aa"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9801), "192.168.1.80", (byte)1, 88.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("11e2b6af-ca47-4fca-8ca1-9dbc7325649c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9445), "192.168.1.29", (byte)1, 37.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("11ed29bd-e9dc-467a-83f1-8a5839618a7d"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(134), "192.168.1.45", (byte)2, 41.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("11fe6c18-b6a9-457d-9b23-69e5eefe2992"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9592), "192.168.1.31", (byte)1, 10.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("12854460-2a64-4792-9477-431a484b2628"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(727), "192.168.1.71", (byte)2, 93.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("12fdaaee-eed8-458c-96c4-c75d3047b82e"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1252), "192.168.1.70", (byte)3, 72.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("136a2b04-736c-41f5-82a0-74301a140fca"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9760), "192.168.1.16", (byte)1, 66.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("13a36623-5bc4-4844-9950-01eaf8532c44"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1456), "192.168.1.55", (byte)3, 95.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("13be2f75-d748-4b16-891f-926e1fe3ac1d"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2123), "192.168.1.31", (byte)3, 80.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("14492fcd-c8ff-4ab2-9adf-17b78193bccc"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(59), "192.168.1.97", (byte)1, 86.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("15007490-1aeb-4009-8a8c-7852a33aada6"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(584), "192.168.1.80", (byte)2, 71.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("1532631d-8dc8-4b8d-9679-ed3bc54b287f"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(457), "192.168.1.49", (byte)2, 60.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("15bfc223-271b-4a9a-b52d-a2412d71fb58"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9466), "192.168.1.89", (byte)1, 97.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("163ce895-10c9-4f70-893b-45b953b7c364"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2116), "192.168.1.66", (byte)3, 10.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("16f02a7a-415d-4d5a-ad80-eca93c83098b"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2256), "192.168.1.42", (byte)3, 83.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("170f0d5a-4f9d-452b-9249-c7e1b03eb1a7"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1985), "192.168.1.97", (byte)3, 64.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("1725cd26-984f-402d-91fa-f218feee2c1c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9485), "192.168.1.24", (byte)1, 79.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("17801ee5-1bdb-459b-a33c-2368d4c8a370"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1730), "192.168.1.75", (byte)3, 68.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("179a0abd-6d31-4cfd-8745-4278333b00ce"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1746), "192.168.1.51", (byte)3, 23.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("18072ee5-3e27-4577-b3b7-25b0ae186da4"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1041), "192.168.1.87", (byte)2, 23.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("1855b228-bdbd-4408-8acd-198efad50f63"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9957), "192.168.1.65", (byte)1, 46.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("18fcae90-95ab-45dc-8740-ceedf8b4542c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9748), "192.168.1.19", (byte)1, 66.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("1a3430f9-8487-41b7-9579-a7a7ee7b871d"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(992), "192.168.1.93", (byte)2, 50.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("1a7f042d-3b03-414d-a0f0-242cb85c1d4c"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(605), "192.168.1.22", (byte)2, 29.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("1b5dfecb-8c2d-4c45-97e3-57d3aa70a05d"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9894), "192.168.1.42", (byte)1, 43.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("1b8d85dc-23b0-49d3-8800-609a65c496b4"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(30), "192.168.1.60", (byte)1, 44.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("1bb88c64-c7d1-4ed6-ad79-72f9da5c2323"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1285), "192.168.1.78", (byte)3, 0.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("1bc19b3a-7c85-4566-8fe5-b8317dc3509e"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1989), "192.168.1.9", (byte)3, 75.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("1c77a360-9081-4d4f-8395-94df39de0c75"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(212), "192.168.1.55", (byte)2, 77.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("1d805204-2e23-4c53-8a81-aafc36babe7e"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1186), "192.168.1.22", (byte)2, 74.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("1e2934c7-a1d4-4404-81b5-f915c446a38f"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2062), "192.168.1.26", (byte)3, 22.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("1e2d1cdd-c4db-432c-b7bd-b65242c2a880"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9089), "192.168.1.20", (byte)1, 39.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("1e4713a8-8d21-4e81-85b6-fbc45eee44bf"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9513), "192.168.1.19", (byte)1, 66.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("1e515a5a-c853-435a-9796-06944d390ab8"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1683), "192.168.1.49", (byte)3, 93.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("1edc5295-ec41-4021-9f53-13054519e48b"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2083), "192.168.1.38", (byte)3, 55.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("1f9b93b5-dd47-40b4-b543-e42596213dac"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1305), "192.168.1.78", (byte)3, 50.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("1f9e8128-aba7-44d3-8ea2-da8ef50db5c4"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9567), "192.168.1.92", (byte)1, 26.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("207c1c0a-879a-40fc-9566-e2a75bc8f922"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1371), "192.168.1.99", (byte)3, 73.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("20a2cdad-88c3-4a66-877c-4df89638044c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9180), "192.168.1.7", (byte)1, 55.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("20f76045-d0b0-40d0-992e-a9b8cc37b26c"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1489), "192.168.1.47", (byte)3, 61.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("2116d94b-c5e2-4aca-9c9e-4a9c409a2ad4"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(13), "192.168.1.59", (byte)1, 75.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("21e00179-d994-452f-9ea6-5aeb6eead463"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2139), "192.168.1.75", (byte)3, 83.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("21ea89cd-f2cf-423a-b3c2-8cc4d61ad6f3"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(224), "192.168.1.30", (byte)2, 69.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("22644c9d-4ed9-4158-9785-240ff8f81e7e"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9220), "192.168.1.48", (byte)1, 48.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("22bff107-138e-40cf-9870-cd5c08add3ec"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2264), "192.168.1.9", (byte)3, 82.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("22fbee39-7fd8-4927-ba2a-005fbaafaed9"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(149), "192.168.1.78", (byte)2, 30.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("23b3c7f7-78fa-417c-8e43-7b6c01b9419a"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9609), "192.168.1.71", (byte)1, 97.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("242cd591-474b-40d4-8834-11bf658839b4"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9510), "192.168.1.1", (byte)1, 36.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("243407b2-1bbc-4329-9911-50d838c257fb"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(837), "192.168.1.35", (byte)2, 7.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("24e6c8fe-afba-4076-9c1f-5bfe64e9e37b"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9273), "192.168.1.69", (byte)1, 73.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("2512d0f7-6d5a-456a-9d34-5646901c694f"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1539), "192.168.1.58", (byte)3, 22.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("2524a3da-8d61-4583-82f4-2942b9b3353b"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9711), "192.168.1.98", (byte)1, 3.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("2556c3bb-723e-420c-ba06-f3ad6e47f321"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1364), "192.168.1.16", (byte)3, 47.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("2561beaf-1af0-49da-9957-5c3198562478"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1637), "192.168.1.80", (byte)3, 51.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("259a6aca-22cf-47b0-8050-66527d16d89e"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9764), "192.168.1.17", (byte)1, 77.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("25b0944a-09ce-49a3-9aa3-4d5df9b6afe1"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1272), "192.168.1.73", (byte)3, 72.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("25bb3310-ada4-447c-8b9c-94befa8671f9"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(510), "192.168.1.46", (byte)2, 66.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("2641b055-c6ff-4834-9087-6cafc7926627"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(695), "192.168.1.90", (byte)2, 39.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("26623e76-9e71-4ba8-83d3-25452cece3e0"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(589), "192.168.1.53", (byte)2, 66.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("26bdcd08-8fe4-439f-bb8a-1bf016dc6240"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9961), "192.168.1.20", (byte)1, 8.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("26d9517e-2929-437e-afa9-09348d3c4931"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1904), "192.168.1.27", (byte)3, 61.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("26e06b4d-acf0-434e-abbf-bb31e81b086f"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2177), "192.168.1.11", (byte)3, 70.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("2739f25b-e1a1-472e-936e-663332f4e6f5"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2120), "192.168.1.90", (byte)3, 9.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("2745cfd0-e580-4dab-94fb-82f027a41bfc"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2247), "192.168.1.26", (byte)3, 29.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("27723f9d-8479-4f34-9467-4ec7cf1ed123"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1695), "192.168.1.81", (byte)3, 26.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("27973316-afc6-4a57-a517-be958b42a825"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2181), "192.168.1.7", (byte)3, 89.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("27ccfcdb-2a2c-41b8-9344-353ba25a2174"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9203), "192.168.1.31", (byte)1, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("27fddfdc-8c40-4d3d-9afa-2f19c9b7eb6f"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1969), "192.168.1.99", (byte)3, 10.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("284ffaa6-fa38-4895-8576-65434f003973"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2102), "192.168.1.24", (byte)3, 76.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("289f4778-e0b3-4335-9d29-c936b737eaf5"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1588), "192.168.1.13", (byte)3, 10.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("299444fc-d74b-419e-ae48-b919e685b218"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1145), "192.168.1.56", (byte)2, 73.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("29b2d42b-4c7f-4fff-98be-955c8c66986c"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1580), "192.168.1.60", (byte)3, 26.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("29b3b1e8-5321-46ea-b14a-39012163c91c"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(822), "192.168.1.82", (byte)2, 3.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("2aef3efd-7522-4e24-8374-416cfd2cdc5d"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(879), "192.168.1.35", (byte)2, 30.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("2af30392-b5e2-4c6c-82f5-6045b60bcc4e"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9154), "192.168.1.84", (byte)1, 91.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("2afabea2-acb9-408b-91d0-9a3a339f024f"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1033), "192.168.1.43", (byte)2, 90.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("2aff3394-ce8d-4e82-a60c-98a5aaeefc3f"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1738), "192.168.1.35", (byte)3, 92.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("2bc9bf8c-7197-44c8-a15b-d069d7893bfa"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(924), "192.168.1.84", (byte)2, 63.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("2bd8a682-a62b-45e1-8b84-b63278f69999"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1470), "192.168.1.19", (byte)3, 78.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("2c6b05f5-fd8c-4264-8e68-4926d356b101"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9629), "192.168.1.31", (byte)1, 35.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("2c6be4bb-9b77-42c4-956a-514ed9785091"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(518), "192.168.1.27", (byte)2, 98.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("2c72283c-b8bb-4199-96a3-216dcf41bb16"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1108), "192.168.1.43", (byte)2, 97.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("2cae5f54-9c55-417d-bf62-4269440e3842"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1025), "192.168.1.88", (byte)2, 44.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("2d23da44-0240-4c6a-82f8-abeea31e949f"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1858), "192.168.1.83", (byte)3, 42.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("2d4c9a7e-867a-45f5-948a-7fa70c6ee758"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1264), "192.168.1.66", (byte)3, 19.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("2dfaf1f5-b3fb-4980-818f-558a9c148d02"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1670), "192.168.1.34", (byte)3, 47.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("2e508afe-06e4-4472-8f11-87d57ab96955"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9314), "192.168.1.93", (byte)1, 95.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("2f24c375-fa18-4495-b65e-e073142370fd"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9490), "192.168.1.9", (byte)1, 78.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("2f89503d-bb04-4a2f-9ae4-168908d13911"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2210), "192.168.1.58", (byte)3, 89.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("2fd02708-6b45-4e1a-86f3-137bce838781"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2006), "192.168.1.92", (byte)3, 90.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("3013440e-5659-46bc-b3c0-5125a2641a08"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9581), "192.168.1.25", (byte)1, 15.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("30635471-fa05-4584-91cb-f2f13d20ce3d"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9250), "192.168.1.59", (byte)1, 54.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("30b8d610-e13d-46f3-b039-ad081e26535a"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9093), "192.168.1.99", (byte)1, 90.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("3138ae24-9d06-487f-9fdd-f5290f11c38c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(108), "192.168.1.68", (byte)1, 82.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("31861c54-7507-4d8e-82a7-899091875a5a"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1596), "192.168.1.24", (byte)3, 58.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("319b5bb2-e963-4558-a9ca-97820419604a"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9386), "192.168.1.42", (byte)1, 97.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("31bc9d92-086e-4df5-88a2-8d5eb154e302"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1956), "192.168.1.80", (byte)3, 53.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("324b5fc1-06d8-4b52-8364-0152c8cb6bd0"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9210), "192.168.1.76", (byte)1, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("328f1b15-b1eb-4aea-952c-7dcab683b64e"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9176), "192.168.1.26", (byte)1, 27.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("3297e6e6-22aa-4cc9-b0d3-2e73a7579aa3"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1058), "192.168.1.39", (byte)2, 88.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("32e60d10-2ca0-4e42-8e6e-618d4e4d9d28"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2206), "192.168.1.78", (byte)3, 29.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("3301a906-b60a-482b-92b5-28571a8e4e0f"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1789), "192.168.1.18", (byte)3, 77.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("33f7e680-4ec4-4781-a8b9-93cae18dfa2d"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9076), "192.168.1.37", (byte)1, 60.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3444d267-6241-4b68-b42c-8fcbf9e9bce7"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(495), "192.168.1.27", (byte)2, 46.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("346c6679-9c67-460b-980e-56ccb60119da"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9643), "192.168.1.95", (byte)1, 1.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("34de0774-2c57-41b2-bef6-ef9a208cf732"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9104), "192.168.1.95", (byte)1, 22.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("34edf299-d4b4-461e-ae9e-ce2a47ecf3d7"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(736), "192.168.1.99", (byte)2, 81.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("351e1853-5a83-4a3a-8b8f-e0566eab2f79"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(392), "192.168.1.48", (byte)2, 53.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("35825abc-e573-48cc-91f7-7ee60ae1cda1"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2161), "192.168.1.73", (byte)3, 0.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("360ac790-f08d-4c1f-a969-6e5970434bdc"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1054), "192.168.1.37", (byte)2, 59.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("36fffe0f-afdf-4bd0-9c70-777130c92b99"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(142), "192.168.1.63", (byte)2, 39.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("37ab2ea2-1ed0-4706-b22e-9e66edb6db5b"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1016), "192.168.1.69", (byte)2, 95.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("3829ce3c-9864-420d-90a2-2e0e2a32564c"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1433), "192.168.1.62", (byte)3, 8.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("385bae8c-55b9-4ed1-80ce-dcf7e4b26bbb"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(850), "192.168.1.11", (byte)2, 74.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("3872209a-eadf-4c3f-81d4-e8723943e881"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(712), "192.168.1.4", (byte)2, 28.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("3883b504-6c83-4510-83a3-61263525b45f"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9605), "192.168.1.95", (byte)1, 9.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("395dda6f-c91b-4048-965d-cb1d772322fd"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(675), "192.168.1.91", (byte)2, 97.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("39712b16-1cd5-4542-a0c6-43c69b8df6ca"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(285), "192.168.1.40", (byte)2, 98.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("39dca3af-6c2e-49e2-856d-c32a06efb597"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9517), "192.168.1.78", (byte)1, 22.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3a132c43-cb70-4c79-888b-9447f7c25d3a"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9828), "192.168.1.76", (byte)1, 64.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("3b5c8265-2bb0-408d-ad7a-3a88af643d9a"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9437), "192.168.1.44", (byte)1, 93.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("3c5311f4-423c-4abd-8523-1ee428258f07"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(773), "192.168.1.39", (byte)2, 46.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("3cecd69b-d2af-41a5-bc44-6d15478df826"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1081), "192.168.1.23", (byte)2, 39.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("3e730221-f367-4b73-b257-59e8b5435c0c"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1723), "192.168.1.62", (byte)3, 45.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("3e8b6e05-5d71-4181-b1bd-85a80220415c"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1912), "192.168.1.94", (byte)3, 65.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("3ebbbee8-24a3-423f-bd19-eb0d5d667ba9"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1004), "192.168.1.33", (byte)2, 94.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("3f672ae7-d0c3-41c4-a040-3e12f37429eb"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9559), "192.168.1.38", (byte)1, 12.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("3fee756b-79bd-4d5e-b328-fb1852db9a76"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2219), "192.168.1.50", (byte)3, 96.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("400bef04-683e-4980-a9db-3849bfe184b1"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1314), "192.168.1.86", (byte)3, 19.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("40151205-e2bd-408b-af45-c2fc1505f94b"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9771), "192.168.1.11", (byte)1, 48.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("4060e4f6-59c7-4b40-9472-b2804e72cc08"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(527), "192.168.1.8", (byte)2, 44.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("408e9783-6ef8-4689-a3a1-ce91efcea378"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9785), "192.168.1.94", (byte)1, 51.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("40901225-5787-4272-abbd-42eeea76c5c1"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9166), "192.168.1.46", (byte)1, 35.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("40a87a93-4aec-4892-b07b-7d5ea944fed3"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(895), "192.168.1.36", (byte)2, 52.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("41ac26c5-4d45-4f3c-965e-1a69cd9d1d19"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(409), "192.168.1.16", (byte)2, 40.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("41e60b46-a0c7-45f3-aebc-1bd6d216f404"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2010), "192.168.1.33", (byte)3, 29.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("41f75b34-2902-4e0c-b482-4a004b5893fe"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1021), "192.168.1.22", (byte)2, 65.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("4266c6bf-9220-4f86-8569-1829df6dfc75"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2239), "192.168.1.51", (byte)3, 7.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("4286d2e8-2986-48e2-9749-5a10660e9498"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2046), "192.168.1.5", (byte)3, 58.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("431afbff-8b37-4dcd-9aa1-a883f80b8dbe"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2079), "192.168.1.84", (byte)3, 40.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("4330b5a6-3536-4e5f-ba25-7c84e1b1deeb"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9669), "192.168.1.57", (byte)1, 4.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("433d626d-922e-4dd7-aa09-c9e75aa38952"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2036), "192.168.1.13", (byte)3, 51.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("43424da8-36bd-4a8c-b6d9-71e5d28909b3"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1157), "192.168.1.89", (byte)2, 95.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("4348c6d7-776a-4377-a7f6-5179c2887d28"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(55), "192.168.1.53", (byte)1, 97.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("43546557-56c5-4e86-95bd-f515eb079256"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2087), "192.168.1.48", (byte)3, 22.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("4362af8c-9186-47d4-a80b-58c5cd4ae0d7"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1112), "192.168.1.40", (byte)2, 3.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("440e4617-c8bd-4093-a18c-8f81c0a6db67"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9930), "192.168.1.98", (byte)1, 2.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("440e7b41-ada9-4d84-98ec-f30101200810"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(916), "192.168.1.35", (byte)2, 98.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4423bf2d-749b-402d-acd8-aff93c0fefd0"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1800), "192.168.1.52", (byte)3, 12.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("463d0a19-ec7d-4a93-9af4-0d1a4ee90d0a"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9339), "192.168.1.51", (byte)1, 75.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("46599de8-80d7-426c-aa85-3e9250dc50b9"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9965), "192.168.1.81", (byte)1, 29.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("46b216fa-9db8-439f-a68d-3971fa02b123"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1887), "192.168.1.17", (byte)3, 76.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("46f29322-2f69-4b5a-b036-c99d4e4a7dd7"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1974), "192.168.1.24", (byte)3, 86.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("47208d40-993d-4eef-b675-f6a235992386"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1779), "192.168.1.72", (byte)3, 95.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("473f3ccf-8685-40cc-a52b-f84da9419765"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(227), "192.168.1.3", (byte)2, 28.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("478936a4-46bb-4476-abae-284d7648098f"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1941), "192.168.1.7", (byte)3, 31.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("47a76a83-7b03-444e-ae12-7dc8af1d20e4"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1816), "192.168.1.95", (byte)3, 54.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("47ac4387-cf84-4718-96a3-12274fd0e436"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(654), "192.168.1.11", (byte)2, 46.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("47cd0be5-0e6c-488e-b54f-9aab346ec81d"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2002), "192.168.1.85", (byte)3, 9.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("47d85c99-f6c5-48a7-9ae9-e3a1fc4bc66b"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9840), "192.168.1.19", (byte)1, 56.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("48a88126-fbe1-4e6b-87ae-3295fcc2a278"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(182), "192.168.1.85", (byte)2, 56.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("48b09496-cab9-42ff-9a25-6a098865ef45"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9462), "192.168.1.90", (byte)1, 98.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("49195fba-7a21-4383-a8e5-309b4f4df871"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1849), "192.168.1.96", (byte)3, 88.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("49acaf06-4fc4-414b-9392-ae10767b43c0"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1613), "192.168.1.47", (byte)3, 57.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("4a018465-05af-4c47-a938-661823f47af9"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2095), "192.168.1.22", (byte)3, 98.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("4a569c5d-dac5-43b9-b0b9-1df5855db35d"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9673), "192.168.1.41", (byte)1, 0.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("4b0e638f-34fe-4b50-b505-aa1de400c998"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9756), "192.168.1.72", (byte)1, 57.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("4b25b414-d05f-407d-bca9-f8ae0a67e0bf"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1070), "192.168.1.95", (byte)2, 35.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("4ba12563-8b16-419a-a7a8-0695f68329e7"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(260), "192.168.1.1", (byte)2, 75.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("4be5bbbf-b405-4c3f-a8ff-6a57ba52cc1f"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9412), "192.168.1.66", (byte)1, 39.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("4bf50f58-9f89-48df-96a8-05dbe2936fb4"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2187), "192.168.1.43", (byte)3, 7.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("4bfd65d9-6c9d-4d11-9df9-013729efd58c"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2202), "192.168.1.9", (byte)3, 13.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("4cb3a705-0129-453c-84b8-ff34cb975ec8"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1908), "192.168.1.52", (byte)3, 28.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("4d84dc73-483a-48fe-aaf7-c523279ee019"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(723), "192.168.1.62", (byte)2, 54.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("4e56cf19-87ca-471d-81ea-e720e2c3a71d"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1318), "192.168.1.34", (byte)3, 34.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("4ec8c6c1-0947-4fe6-99b6-f74b1c385527"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9678), "192.168.1.24", (byte)1, 94.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("4f9004b0-d81f-407e-b8a6-ae2a4d6764aa"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9563), "192.168.1.21", (byte)1, 81.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("4f9e151d-6608-40bc-8a2a-e6adecf822e8"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9162), "192.168.1.6", (byte)1, 57.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("4fb4868a-1343-41eb-8db5-3ad25b9ee47c"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2168), "192.168.1.67", (byte)3, 65.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("4fd42488-95a9-41ed-abd0-7bdddfaf6e57"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1855), "192.168.1.61", (byte)3, 55.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("4ff59add-6bc4-4d05-8c49-db775a8dda09"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1543), "192.168.1.10", (byte)3, 13.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("50d662d4-5949-4103-8324-81a32bec070d"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1687), "192.168.1.94", (byte)3, 67.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("51563b9e-7372-4f85-949f-2f59da45082d"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(163), "192.168.1.72", (byte)2, 54.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("517e384e-2744-441f-912c-84ba05571a57"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(289), "192.168.1.71", (byte)2, 34.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("51ab58e1-351c-46ad-ad49-36ef6d7dcd6f"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(846), "192.168.1.96", (byte)2, 5.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("52004c84-0576-4e5c-b993-e0c448279b7a"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9425), "192.168.1.48", (byte)1, 38.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("527c7a0c-e166-4260-ac16-8831198c7db4"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(325), "192.168.1.87", (byte)2, 45.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("52fb7306-5c62-483b-907f-e87f3820cd3c"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1949), "192.168.1.1", (byte)3, 6.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("53172085-13ae-443f-af37-25d03b0dbb92"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(45), "192.168.1.65", (byte)1, 47.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("537dc058-ff0d-49f6-a395-c9d4f211372c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(34), "192.168.1.23", (byte)1, 47.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("539597e6-7922-4f50-b033-5bbec39ad0a7"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(719), "192.168.1.12", (byte)2, 72.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("53fe11b7-01f5-4edf-a91e-9f51cf49d977"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1916), "192.168.1.46", (byte)3, 45.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("54065c95-2e55-492a-bb3c-629b6cb39618"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1679), "192.168.1.96", (byte)3, 73.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("544e638e-f885-4ce1-b88c-85fd7f6f4fd3"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1460), "192.168.1.86", (byte)3, 16.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("5530e517-ce51-4fc8-b271-ae08f4c61800"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(62), "192.168.1.31", (byte)1, 90.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("55c9a18e-1a89-42f5-a9d7-16e25e53acfb"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9254), "192.168.1.51", (byte)1, 83.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("5651644c-7e10-4274-8b22-4642b23d7048"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9844), "192.168.1.87", (byte)1, 70.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("566bbb1f-d5d0-48d2-a63c-d624f4a8d076"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1522), "192.168.1.95", (byte)3, 26.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("56b3135f-6320-467e-960b-ed59e30a38cd"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1367), "192.168.1.96", (byte)3, 31.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("56cf6179-fab3-4d9d-ac95-6790271b2e78"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9994), "192.168.1.50", (byte)1, 65.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("56f3075b-346b-48e8-8606-01631bf4c73b"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9850), "192.168.1.25", (byte)1, 30.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("578b200c-e5f1-4d40-913f-45cc0a58fffa"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1237), "192.168.1.95", (byte)3, 58.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("579e3ceb-8336-4009-b861-07ab18a71070"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(797), "192.168.1.55", (byte)2, 17.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("5910dcd5-2128-46a1-b5d6-744976fb2f2b"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1775), "192.168.1.69", (byte)3, 0.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("593a130f-67d9-4dbd-98d2-95e29ea02176"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2099), "192.168.1.76", (byte)3, 55.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("59bd72dc-b305-4296-89b3-13dba90ce0d7"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1890), "192.168.1.18", (byte)3, 34.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("5a21f07f-8646-462c-8fda-69a15d04ecb2"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9698), "192.168.1.60", (byte)1, 61.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5a5d0aa6-b9d5-492d-b3e0-d0587fa370f8"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9331), "192.168.1.36", (byte)1, 96.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("5a7bf652-da2a-416c-b5f2-91248190b62e"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2091), "192.168.1.69", (byte)3, 45.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("5a92e202-7547-4627-bdc1-e7d3b9d27f34"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(281), "192.168.1.39", (byte)2, 90.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("5a988eb8-98f5-4c24-8f8d-7ad49e3c11a6"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1977), "192.168.1.48", (byte)3, 73.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("5aa1a8e7-767b-4884-8a85-2e74a9d81f19"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(306), "192.168.1.44", (byte)2, 11.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("5afa38d3-19f8-42ad-94e4-f1acf85235a3"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2040), "192.168.1.80", (byte)3, 98.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("5b4de5a9-456b-4f90-bfa7-d9a2a7ae41bb"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(424), "192.168.1.4", (byte)2, 32.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("5b7b5af2-6e01-441a-9db6-e67c56ae4798"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(498), "192.168.1.2", (byte)2, 13.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("5c118660-6c8a-4e9a-9193-664db65108e0"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2135), "192.168.1.22", (byte)3, 28.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("5c17debd-001d-4007-8a24-98e6f8b09f15"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1841), "192.168.1.17", (byte)3, 26.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("5c394296-30a1-45b7-8779-486817b24749"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9981), "192.168.1.75", (byte)1, 33.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("5cf79895-191e-44e0-9876-81ae6281721a"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(420), "192.168.1.46", (byte)2, 72.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("5e00f3ec-f57c-4196-b0d8-100f395cadb5"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9694), "192.168.1.47", (byte)1, 88.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("5e982ff8-4e68-4f7e-ab29-fb18e0a7169c"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(691), "192.168.1.57", (byte)2, 90.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("5ea3eec7-fca9-43d0-9067-77552e223fbd"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9890), "192.168.1.5", (byte)1, 36.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("5ef2c1cf-9d21-48b4-bb85-5f5ea2ed7bc9"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(207), "192.168.1.22", (byte)2, 12.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("5ef57d6d-3262-47d3-9e26-d381302db8fb"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1133), "192.168.1.57", (byte)2, 85.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("5f0248a8-aec6-441d-bfe5-d96e6bf81114"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(887), "192.168.1.14", (byte)2, 84.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("5f2de718-23cd-4b78-a910-b356886ef286"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1277), "192.168.1.60", (byte)3, 58.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("5fb0438a-ee90-49f0-9304-278f039c2aa0"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9498), "192.168.1.94", (byte)1, 32.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("5fc7c7bc-9aad-4df0-991a-22cad036d180"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(687), "192.168.1.6", (byte)2, 71.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("5fd18039-ffad-4fcc-baee-df0e93a2c9e3"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1012), "192.168.1.22", (byte)2, 29.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("5ff5cd2d-6364-419f-bc5b-2d7b35e00375"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9235), "192.168.1.45", (byte)1, 88.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("60dbdc82-397b-4bea-a6e7-8cafe6defd6d"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2243), "192.168.1.63", (byte)3, 43.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("612e5759-6f1b-402c-8673-d83d642cf7a9"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2069), "192.168.1.76", (byte)3, 42.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("6282efc6-5077-4503-9824-e2e9cefad726"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1526), "192.168.1.64", (byte)3, 63.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("62d472f2-9c2f-4c5a-b47f-f508dc577124"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1207), "192.168.1.30", (byte)3, 49.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("63026ed2-0692-46b2-8959-cf2149e221ba"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(461), "192.168.1.16", (byte)2, 39.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("634b21f3-9350-4437-acee-5d2c22634742"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9170), "192.168.1.73", (byte)1, 62.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("63520e32-1dbf-40f6-9cd4-ad8f7c1739b4"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1044), "192.168.1.16", (byte)2, 62.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("6443bb9a-cae3-4f4e-bed9-76688ac33b62"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(748), "192.168.1.88", (byte)2, 24.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("64b6ce6d-4fb7-42d9-bd1b-989b2dec8814"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(731), "192.168.1.40", (byte)2, 84.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("65a1be02-e74c-4a8e-b6fb-7d5669f5e0cb"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(51), "192.168.1.42", (byte)1, 45.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("661f52e0-c139-44e0-920f-153a77bb979a"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1223), "192.168.1.74", (byte)3, 95.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("664e7f22-31d7-48b2-ab72-0fdca5862147"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(167), "192.168.1.49", (byte)2, 53.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("66b9e75f-3044-4304-8e2f-e87ada5f8c82"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9596), "192.168.1.68", (byte)1, 63.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("66f53c0d-317f-4e9c-a64b-1e3c9526e01e"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(186), "192.168.1.29", (byte)2, 97.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("674eefb5-634e-4f82-a574-996362b767ac"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(129), "192.168.1.5", (byte)2, 91.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("678ab866-ffc9-4589-b85e-0f2fdded8cd3"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9127), "192.168.1.46", (byte)1, 69.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("68006ec8-89b0-41bb-bf0f-ec467c2ceeb0"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1793), "192.168.1.15", (byte)3, 29.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("68b67bf7-294a-4012-8eef-e69530d5bccc"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1379), "192.168.1.32", (byte)3, 18.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("68c39147-d3ba-4f0d-ace5-2d15875d5aa1"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1260), "192.168.1.39", (byte)3, 42.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("69194754-7f46-461a-b585-bb23b41aa181"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9131), "192.168.1.90", (byte)1, 11.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("691d14d5-5312-45f1-82e1-d7bf36be7c0b"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(245), "192.168.1.43", (byte)2, 86.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("69202a18-5cac-4053-9a8d-714d825bb87c"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(622), "192.168.1.67", (byte)2, 37.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("69356cf1-85d2-4d04-b6f7-261d539bbdb2"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1894), "192.168.1.68", (byte)3, 34.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("6990c9c3-dd68-4e30-aab4-ba63db71219d"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(216), "192.168.1.96", (byte)2, 62.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("69cb6f93-9df0-49fa-92ff-f2091e15d798"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(296), "192.168.1.90", (byte)2, 85.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("6a0cf504-b267-45ae-a86f-8f660fc4dad2"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1923), "192.168.1.48", (byte)3, 4.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("6c023c7d-a071-4edd-9b73-2b7bffbfc010"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1531), "192.168.1.13", (byte)3, 14.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("6c0fbd06-5e81-4b66-8928-89d19ebc5c73"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1178), "192.168.1.59", (byte)2, 64.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("6c2204d8-e058-4b58-9f64-f7998f836fb6"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(356), "192.168.1.76", (byte)2, 63.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("6c25f9fc-8541-452a-a654-9363e49bac34"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2058), "192.168.1.96", (byte)3, 96.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("6d01c0fa-3e08-4be3-aea3-71c4f1ea92c3"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9926), "192.168.1.13", (byte)1, 53.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("6d367063-b0f8-4cb3-a68a-87a5fe70bf28"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1066), "192.168.1.60", (byte)2, 2.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("6d59e6f1-c1c3-4fe4-9ac1-1520f74227de"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(363), "192.168.1.50", (byte)2, 91.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6d618819-faad-4c05-b555-6d076dec73f1"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(826), "192.168.1.61", (byte)2, 18.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("6d628c7e-aea7-45bf-be95-53e769359ef0"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1796), "192.168.1.81", (byte)3, 64.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("6dbcc591-8358-4ad7-9c81-8761b979a481"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9585), "192.168.1.34", (byte)1, 94.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("6e308ae5-38e1-4980-906f-d676f8c207ed"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1691), "192.168.1.31", (byte)3, 14.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("6e45c4b2-2150-4ba7-b883-b1adac6b675b"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9240), "192.168.1.49", (byte)1, 44.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("6ed2e405-1541-436c-af41-2dceab4d6ddf"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(445), "192.168.1.55", (byte)2, 87.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("6f337fe5-14e0-4a27-a288-142a2ca105c1"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(413), "192.168.1.32", (byte)2, 38.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("6f33aac4-39f4-4efc-8f19-4c04a0f9f19a"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(568), "192.168.1.78", (byte)2, 28.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("6f7c830c-dd60-4263-ba88-c701dfbbe8a7"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1485), "192.168.1.12", (byte)3, 90.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("6fda2103-cd8b-47ea-95a9-9ce258d208a9"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(317), "192.168.1.52", (byte)2, 80.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("70950bd2-d19e-48fe-aadd-b8e66dd632fb"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(313), "192.168.1.44", (byte)2, 61.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("70a88f55-5f8c-4149-bf26-bbc93063df9e"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9191), "192.168.1.21", (byte)1, 53.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("7146fa04-8e72-4d7f-8962-ae4adc6d2e1b"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1845), "192.168.1.4", (byte)3, 28.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("714c794a-cbff-4b2a-b5a0-91c6866e432a"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(580), "192.168.1.86", (byte)2, 76.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("7158c453-6143-4c6d-9c7b-f13359866f9b"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1551), "192.168.1.37", (byte)3, 39.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("72a4b3a6-015b-4f8c-a2e8-8c07831142e8"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1), "192.168.1.43", (byte)1, 42.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("72afdd46-6d17-429a-a67e-451948e969f6"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9825), "192.168.1.46", (byte)1, 5.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("72d6ee81-87f2-4d9a-8fca-ba260a747e80"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1499), "192.168.1.33", (byte)3, 5.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("7316f8a4-db25-44e9-b7d2-085723de6cbf"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2276), "192.168.1.49", (byte)3, 11.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("738df3b6-0c4f-49c7-963a-1058bb10ff05"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(854), "192.168.1.98", (byte)2, 55.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("73bd8279-5bf9-47dd-bb57-6e5712d92998"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(782), "192.168.1.59", (byte)2, 96.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("73ffd232-a2a8-4236-b3ba-ddfa66782c44"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(891), "192.168.1.61", (byte)2, 85.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7400e5f2-ca5b-4def-9bcc-4e34b1d933c6"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9706), "192.168.1.76", (byte)1, 41.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("741a7fcd-1e5e-448d-81f5-8131d2bb6247"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1293), "192.168.1.14", (byte)3, 70.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("743e4467-c93c-4b96-9da0-4650d437d5d0"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(829), "192.168.1.73", (byte)2, 73.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("74a09441-2729-4545-bfcc-58f0e217198e"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1760), "192.168.1.66", (byte)3, 6.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("751df41c-a4cf-40a1-914a-6779053f4754"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(560), "192.168.1.3", (byte)2, 37.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("75834d1d-12ab-4a6d-b20e-f3174dd5be13"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(26), "192.168.1.75", (byte)1, 6.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("75b0f03c-1bd0-4b97-9da8-66c72604e9d4"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1256), "192.168.1.15", (byte)3, 82.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("75e3a9ed-8b23-48d8-9612-d67ba1b579bd"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(268), "192.168.1.85", (byte)2, 5.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("7715aa41-f976-4e8e-afaf-4c089b014134"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1510), "192.168.1.48", (byte)3, 88.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("772d2200-3327-43d5-98c8-bf4cb045eaa1"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9135), "192.168.1.20", (byte)1, 91.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("778f92a7-763f-45fe-b929-aae9d99948c2"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9923), "192.168.1.66", (byte)1, 12.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("781a3542-6269-42c1-bd76-84eeb12fedb2"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9865), "192.168.1.40", (byte)1, 81.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("7831c351-5093-47b4-824e-667119b74ffe"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1919), "192.168.1.48", (byte)3, 29.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("78a51247-f557-4411-9fb1-164c66d72a1c"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(449), "192.168.1.81", (byte)2, 47.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("78bfe333-4da2-43c1-b0d1-7c4f5186c5ea"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9320), "192.168.1.92", (byte)1, 20.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("78d53f6a-65c5-4df7-9d82-57649fa3ba2f"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9942), "192.168.1.56", (byte)1, 50.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("79c36f94-4adf-4b8d-8b92-a895c37bc375"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9116), "192.168.1.94", (byte)1, 26.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("79c89c41-4acb-43da-8226-603a704d0ef7"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9150), "192.168.1.30", (byte)1, 49.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("7a362e57-f9da-471c-92cc-1638e35aecd8"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9081), "192.168.1.83", (byte)1, 46.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("7a89299f-0500-4812-bbd2-9496b9304f15"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9938), "192.168.1.36", (byte)1, 50.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("7adfd527-157b-4f16-8ae9-a3495c8d2d4d"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(564), "192.168.1.4", (byte)2, 25.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("7ae31677-284b-4f96-b387-2f4be99b3328"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(91), "192.168.1.41", (byte)1, 81.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("7bb8e37f-bbd1-47fa-86a9-8f0c99c8613f"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1227), "192.168.1.14", (byte)3, 79.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("7d1b2d9f-19ef-4299-aa37-e65c6fa76d25"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(752), "192.168.1.42", (byte)2, 3.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("7d238387-8528-41a3-a84e-d5939f930d25"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(428), "192.168.1.60", (byte)2, 7.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7e62722a-332a-4d35-a66a-561e2705d9d0"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1629), "192.168.1.21", (byte)3, 33.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("7e86c605-b3c5-4342-8ade-f5722f504cb9"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9777), "192.168.1.56", (byte)1, 8.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("7e95da21-f351-4562-b136-5416c0ee213d"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1604), "192.168.1.43", (byte)3, 69.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("7ebc1249-2d1d-41c1-a1ee-09549fa2f7db"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2112), "192.168.1.36", (byte)3, 86.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("7f3962c6-f58c-46f0-ba39-7bdeb58b983e"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9990), "192.168.1.22", (byte)1, 36.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("7f79e6dd-bb5a-49b0-82a2-c4cc85a51978"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(116), "192.168.1.89", (byte)1, 63.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("7f9a538c-6908-4605-b297-207f67a9af55"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(963), "192.168.1.16", (byte)2, 26.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("7fcbc0de-533f-45c1-afde-e4821a2baf95"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(514), "192.168.1.47", (byte)2, 22.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("80735c47-f1eb-4fb8-87fb-9ba26b79c5ab"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9902), "192.168.1.81", (byte)1, 10.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("80fbafa7-1615-4afc-b878-c1291c24770f"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(760), "192.168.1.85", (byte)2, 75.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("816c5788-4d2a-4881-9e97-f29826715710"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1000), "192.168.1.85", (byte)2, 59.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("81bfd7cc-6347-424e-bfec-0739cb664c2d"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9228), "192.168.1.96", (byte)1, 49.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("81c2a04d-a440-45d8-8ad0-b5186a6c9021"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9731), "192.168.1.6", (byte)1, 64.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("81dbb7e0-22f1-44a1-ab2e-2f927f535a63"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1073), "192.168.1.26", (byte)2, 16.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("8207fe17-dbb5-418a-b10d-5f6d6c7b1be6"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2231), "192.168.1.14", (byte)3, 14.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("82ceeb61-2f11-44f9-a6a3-9127425d37f5"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1833), "192.168.1.2", (byte)3, 49.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("83caae63-bfda-4752-8028-f43139508caa"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1535), "192.168.1.5", (byte)3, 61.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("8436dca3-3277-440c-b9b1-b67a7c91095f"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1764), "192.168.1.64", (byte)3, 32.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("84b5084e-27f0-4328-8ad5-0e79181e9a8c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9362), "192.168.1.45", (byte)1, 25.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("84def9ee-4123-4f24-8665-b16bcec9050f"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1375), "192.168.1.48", (byte)3, 29.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("8524e45c-eaa8-4042-b70f-8dac2dc92960"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9044), "192.168.1.18", (byte)1, 36.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("852cdfb5-a414-4780-9c98-dcd5e5e6b035"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(679), "192.168.1.68", (byte)2, 86.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("8580d347-0035-452f-af3b-d1951f617bca"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9416), "192.168.1.55", (byte)1, 71.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("8581f2ac-4519-4ba6-99d2-59387362d710"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1415), "192.168.1.52", (byte)3, 71.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("85cedae5-1423-43fb-b2a6-cd596379609e"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1503), "192.168.1.37", (byte)3, 99.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("85e9ee76-45e2-4ef9-a266-0c2146f04a3d"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(841), "192.168.1.7", (byte)2, 61.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("85fb2f42-db97-42b2-b06e-53aba882f144"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9727), "192.168.1.13", (byte)1, 10.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("87080206-4306-4055-aa73-5aa328f3d70d"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1518), "192.168.1.61", (byte)3, 33.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("870ea109-9983-49a8-8300-5e1a5d3b0406"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9832), "192.168.1.51", (byte)1, 82.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("875bfb41-5576-4c0f-a18b-352fc0e66bbf"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1547), "192.168.1.37", (byte)3, 97.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("8792d87a-52f7-4107-9fd4-6066066cfa8e"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9588), "192.168.1.47", (byte)1, 14.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("87dd7cac-8d57-49d9-99a8-be6deef82a72"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1625), "192.168.1.1", (byte)3, 47.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("87df6740-0a48-43ed-aebe-46fd49770105"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1953), "192.168.1.10", (byte)3, 71.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8807404f-8ed5-4444-afc6-1a0436cefee3"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1783), "192.168.1.2", (byte)3, 68.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8871990d-6482-4e69-ba46-784cc54dc142"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1329), "192.168.1.19", (byte)3, 5.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("887ecd38-9cf0-4946-9a04-13795498e927"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(396), "192.168.1.74", (byte)2, 32.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("887f7c0a-1b9b-443d-93d6-07c34c0eec2d"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(344), "192.168.1.52", (byte)2, 6.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("8887148c-31cb-4b12-8510-201fe2d0b168"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1997), "192.168.1.64", (byte)3, 91.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("8958df42-ad38-405a-88e3-d227bc664c6a"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(535), "192.168.1.26", (byte)2, 13.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("8b6e1d2c-445a-4ad3-aa05-06696f70b725"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(502), "192.168.1.68", (byte)2, 87.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("8b72453b-1e27-43ba-b98b-382d1609026b"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(377), "192.168.1.38", (byte)2, 63.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("8d2c8919-e981-4b7b-9ea2-0971bdc5d9e8"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(417), "192.168.1.99", (byte)2, 91.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("8d7d364a-1c90-44e3-801d-54811eb8462b"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9294), "192.168.1.24", (byte)1, 29.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("8d806a67-b53f-4ab8-ac8c-a440b045a776"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(988), "192.168.1.48", (byte)2, 41.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("8daa3e51-be83-4b69-9d71-862c91579069"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(338), "192.168.1.49", (byte)2, 39.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("8dce34f7-2c91-41d9-83e3-892dd1e33e0b"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1734), "192.168.1.77", (byte)3, 54.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("8dec0c03-a2a5-4a1e-be41-436449983247"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9797), "192.168.1.47", (byte)1, 56.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("8e03f26f-f2e3-4ba7-8132-3850d88e1bfa"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1393), "192.168.1.30", (byte)3, 20.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("8e75e1c3-4a3f-4c87-bc65-134d01d3265b"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1215), "192.168.1.38", (byte)3, 37.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("8eea2bdd-568e-4071-b3c8-0d706dcdf828"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(441), "192.168.1.58", (byte)2, 34.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("8f2609de-230e-4c22-b179-2f5b52c5f2c4"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9373), "192.168.1.58", (byte)1, 27.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("8fd1c0e4-503f-439b-b10c-398040f14d35"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1437), "192.168.1.16", (byte)3, 17.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("905e6c8f-9e39-4a4a-99b2-9314b2816d97"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1993), "192.168.1.12", (byte)3, 82.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("90771014-5991-4d2c-9ff5-23bc6588d60d"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(170), "192.168.1.94", (byte)2, 29.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("90a81b95-4d41-494b-a9e1-794d20fd58e5"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9441), "192.168.1.18", (byte)1, 21.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("91d7a656-46d8-423d-8f99-8f1afb2e01e1"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9429), "192.168.1.54", (byte)1, 31.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("9236834d-f148-4a5e-87e8-a2ab61044aad"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(465), "192.168.1.30", (byte)2, 83.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("92961c42-63af-4669-a8e0-795638e90823"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(9), "192.168.1.7", (byte)1, 85.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("92e0a787-5e2e-47a4-9fed-35fb6fd0ddd3"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2223), "192.168.1.49", (byte)3, 48.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("92f6f6b5-a3bf-4338-a79e-87a08fd4989a"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1981), "192.168.1.51", (byte)3, 46.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("92fa785d-d02c-4aa6-a524-4cc208807034"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(666), "192.168.1.5", (byte)2, 44.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("9312baa6-9cb6-4f55-a2ed-993202a45d0e"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9404), "192.168.1.21", (byte)1, 41.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("937d8951-1a77-41b0-8d5b-26beb98413ed"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9396), "192.168.1.97", (byte)1, 60.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("948f4221-0348-48fc-a940-70132db16306"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(436), "192.168.1.94", (byte)2, 11.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("94e7ee94-d757-4674-8358-e5615fb51574"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(874), "192.168.1.54", (byte)2, 43.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("952491e5-369a-4012-bd54-62ca00b6bb81"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(506), "192.168.1.95", (byte)2, 11.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("960655cb-467e-4de7-ac51-028374851401"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1771), "192.168.1.86", (byte)3, 83.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("96641166-87de-4415-af16-681d6836d857"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(248), "192.168.1.19", (byte)2, 7.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9676a7e5-a84c-4c1e-bd35-7ad1f574fcca"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(78), "192.168.1.56", (byte)1, 31.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("96c0bc15-a62e-4089-a8ad-5a53ee808889"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9857), "192.168.1.28", (byte)1, 94.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("96ce4dcf-2b79-4b3d-925e-fb15000ee050"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9873), "192.168.1.34", (byte)1, 87.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("96de3e69-29e8-40fa-b848-a35f1749f38c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9655), "192.168.1.81", (byte)1, 1.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("97f424c1-66a3-4794-acf3-b54cd286d7a3"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(531), "192.168.1.67", (byte)2, 47.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("9817b6d1-b1e6-486b-95c7-8206a1ae48f7"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1427), "192.168.1.48", (byte)3, 99.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("985092b0-3831-4faf-9e6f-1e5eeb54d0a1"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(388), "192.168.1.77", (byte)2, 93.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("988e6982-b725-4bf8-a83c-3262ea5dffdb"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(348), "192.168.1.31", (byte)2, 89.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("98a0c139-4425-43de-bfc3-b7775ed82d75"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2157), "192.168.1.51", (byte)3, 2.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("98b061d5-01e6-45dd-9ebc-6640c9d62805"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(804), "192.168.1.9", (byte)2, 76.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("995e667c-246b-4488-939c-cd4b1cbdca66"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9433), "192.168.1.9", (byte)1, 75.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("9976ce91-1d93-4025-9a19-21497607c167"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1466), "192.168.1.49", (byte)3, 80.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("99b636dc-7b12-455b-835d-7c5fd93daa7c"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1233), "192.168.1.96", (byte)3, 64.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("99dc47e5-6fca-43db-9996-5aefa64d4dda"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9686), "192.168.1.55", (byte)1, 97.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("9a3a52c9-da5e-4e1b-9f13-0db89857675b"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1879), "192.168.1.3", (byte)3, 52.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9a942306-b201-4619-a637-38004ab14e5b"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(979), "192.168.1.86", (byte)2, 8.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("9acd2097-4120-40fe-a0f0-c8558ec71154"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1633), "192.168.1.34", (byte)3, 75.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("9b06a05a-e78d-453f-8a26-85ead9790ff7"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2131), "192.168.1.56", (byte)3, 81.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("9b498c7a-f8ef-44ac-9b5f-5d4513164119"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1654), "192.168.1.83", (byte)3, 27.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("9b53166e-6a90-4793-ad56-fecce12a69de"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9310), "192.168.1.54", (byte)1, 18.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("9b6c2845-176e-46d4-8efe-630675b67d0a"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9977), "192.168.1.19", (byte)1, 78.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9bd9d384-b61f-4f42-90e1-dfa5c04cf35e"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2268), "192.168.1.44", (byte)3, 77.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("9bf24539-1988-4953-b998-52ad66633739"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9573), "192.168.1.78", (byte)1, 99.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("9c01bbba-eb61-40e9-8897-6db4e3b76f93"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2235), "192.168.1.66", (byte)3, 12.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("9c2eb07c-af3e-4817-8cdc-0ae168797fe0"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(334), "192.168.1.75", (byte)2, 93.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("9cc2c01e-abb1-44c7-aedb-1f72344b3aef"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1441), "192.168.1.48", (byte)3, 24.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("9d28ca2f-7396-4e74-8252-4ed393ffbb2c"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1400), "192.168.1.47", (byte)3, 7.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("9d52a155-2be9-47bf-bd07-bfcdb9d2a9fb"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(983), "192.168.1.61", (byte)2, 85.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("9d88255c-3e98-40f3-bd7e-c3a41db8cd77"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9715), "192.168.1.7", (byte)1, 69.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("9dac547e-2956-4563-9680-c76cd6f22f62"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2191), "192.168.1.61", (byte)3, 98.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("9dda1292-68c2-42e8-9c4b-5da8068de764"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1964), "192.168.1.21", (byte)3, 95.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("9e044104-dd1a-45d1-a58d-0ad5adf8360f"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9639), "192.168.1.86", (byte)1, 56.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("9e3ddd0e-c3ac-4600-93e2-652a23aafee8"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(814), "192.168.1.90", (byte)2, 40.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("9ec148b5-a2e7-4f9f-998e-4eb199bc22b5"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(352), "192.168.1.48", (byte)2, 40.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("9ed1105e-e6e2-41e0-90a6-73a68b89bf3c"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(764), "192.168.1.32", (byte)2, 25.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("9f49a781-00cd-490f-8470-d2b2fbeca2e8"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(190), "192.168.1.17", (byte)2, 37.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("9f66b8b7-212f-4cbb-9557-7ab4d758fda9"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1297), "192.168.1.58", (byte)3, 73.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("9fe2fe47-9d70-4019-8057-77d290ab4aed"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(235), "192.168.1.55", (byte)2, 94.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a04bef56-c34a-4ecc-b975-cc0d30a3d389"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9969), "192.168.1.71", (byte)1, 68.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("a0e13e3a-80a7-491b-9dae-c43e86065027"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9264), "192.168.1.49", (byte)1, 6.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("a17da4e5-a96b-446b-9d7d-173ccb4fef63"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(883), "192.168.1.22", (byte)2, 34.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("a1ab12bb-6dc8-4557-8968-68a2a0421dc6"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9647), "192.168.1.24", (byte)1, 44.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("a1bda2f3-b31d-48ce-9b5a-c6397870d2f9"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9365), "192.168.1.37", (byte)1, 24.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("a1ed5eed-fd49-4986-aa5d-04bdf6d6bc27"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9281), "192.168.1.11", (byte)1, 48.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("a286036f-a284-4846-8d8b-8da475064299"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1199), "192.168.1.52", (byte)3, 88.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a2ba249b-e4ba-4f1f-9c7f-c61812f53f01"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9353), "192.168.1.88", (byte)1, 63.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("a38bbb53-fac4-4bca-a074-9773c7c99720"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1808), "192.168.1.18", (byte)3, 94.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a3963db0-cfcd-4906-8e83-1d2a51497e79"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(174), "192.168.1.65", (byte)2, 24.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("a3eeb1b7-9153-476c-9fb1-7f5042abf37c"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1077), "192.168.1.5", (byte)2, 56.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("a3f02183-4786-4968-b5af-b8abee990b1b"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9817), "192.168.1.98", (byte)1, 44.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("a41f3125-1f90-4f00-89a8-b943e4fc447a"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1268), "192.168.1.77", (byte)3, 94.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("a43382af-1cc8-4ada-95d0-8672b11f8e87"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(321), "192.168.1.76", (byte)2, 16.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("a4479451-5bf9-4fff-83e8-c417f2b5cc57"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1621), "192.168.1.57", (byte)3, 40.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("a468ebe0-3011-419e-851e-859261d5eba2"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(22), "192.168.1.47", (byte)1, 36.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("a49f9442-0986-4424-b10e-6e6caaa78135"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9633), "192.168.1.59", (byte)1, 60.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("a5428b6c-e246-4d7b-a896-fc9bc43e9965"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1812), "192.168.1.88", (byte)3, 57.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("a57d6c45-917a-4304-b412-002aece184cb"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9919), "192.168.1.51", (byte)1, 21.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("a5f0105a-c624-4cf0-9640-d79a02cced71"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9452), "192.168.1.50", (byte)1, 35.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("a78226e8-4c7d-4056-a456-bae564e77a41"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(967), "192.168.1.71", (byte)2, 0.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("a7e97920-3790-4ddc-8f84-7174834a52e4"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1756), "192.168.1.31", (byte)3, 79.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a851364e-7ab3-4f94-b63d-2cfa2a622e6e"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9246), "192.168.1.57", (byte)1, 47.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("a8f7fd9f-34f4-4cf8-a1d7-e51f10830dc1"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1301), "192.168.1.12", (byte)3, 2.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("a92d97a4-4d09-40b2-81ff-682d6c834c5f"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9898), "192.168.1.36", (byte)1, 11.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("a94dfca0-58b6-40c0-89d4-fc2cb33fe5d8"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(491), "192.168.1.44", (byte)2, 11.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("aa0fe854-c68d-418b-add4-f3454e8d9679"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9719), "192.168.1.29", (byte)1, 98.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ab588490-4ea8-4f2c-80c4-f14cc04a917a"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2014), "192.168.1.42", (byte)3, 72.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("ac791c85-9fc4-48bd-8342-98a78459526a"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1104), "192.168.1.24", (byte)2, 38.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("acaa3de5-e7e8-49ff-a3ad-891704efcae0"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(800), "192.168.1.69", (byte)2, 79.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("acbe21f3-4a38-4c8a-9096-b2c0d58d58cf"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(367), "192.168.1.40", (byte)2, 48.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("adaba41d-b1c2-48ef-81c3-1f03fd183d66"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(178), "192.168.1.60", (byte)2, 14.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("ae13ad76-0932-480b-9354-7c86acf22b53"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2227), "192.168.1.50", (byte)3, 60.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ae7b86d9-137e-4832-9f99-f265367145a5"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9767), "192.168.1.15", (byte)1, 39.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("aec72c86-4c9d-4d83-a7e4-7a07bc28a32e"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(572), "192.168.1.18", (byte)2, 82.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("aef29431-04df-457d-91bb-e1e259b0dfc3"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1383), "192.168.1.67", (byte)3, 12.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("aef49681-aa2c-4477-91e0-c91079844bdf"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1960), "192.168.1.68", (byte)3, 85.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("af5ee5e7-debf-4cfd-9243-2ef609267b34"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1837), "192.168.1.53", (byte)3, 83.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("afcf8dd9-09c4-417f-800a-00d2d1810a31"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(380), "192.168.1.86", (byte)2, 88.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b0662b0b-11d1-4c9b-bc78-3dbd5e94adeb"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9651), "192.168.1.91", (byte)1, 35.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("b0a2e09a-4027-40ef-9849-0efb7a6af5fb"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9973), "192.168.1.98", (byte)1, 50.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("b0ffa2b1-85d1-48a1-90d1-2b419c9d7110"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2033), "192.168.1.66", (byte)3, 32.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b125ecea-074f-49d6-ac69-62c23ce2ff65"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2214), "192.168.1.31", (byte)3, 4.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("b15d6397-925f-46cd-a3de-bdbad81aa2ef"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1219), "192.168.1.86", (byte)3, 71.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("b17f729d-b15b-490d-9947-945e50582f15"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(756), "192.168.1.39", (byte)2, 95.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b1b4718b-419e-4c9b-a8e1-5b541953b2a7"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9948), "192.168.1.58", (byte)1, 74.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("b251f624-6133-42c7-8148-29710f328569"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(996), "192.168.1.60", (byte)2, 8.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("b2a8a340-9a5a-4e04-9a13-9a29d87c2483"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1008), "192.168.1.60", (byte)2, 37.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b30a910c-4091-4349-aa32-978ae82a34c2"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1674), "192.168.1.57", (byte)3, 11.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("b387785b-f2a1-49ba-93c4-58bb2fafc416"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1478), "192.168.1.23", (byte)3, 94.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("b46d7986-740e-4336-a7c6-8e296be06d96"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1190), "192.168.1.86", (byte)2, 41.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("b49d65fa-bc65-4e1f-be31-29e8e154270f"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(256), "192.168.1.26", (byte)2, 36.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("b4ae3921-4f44-4cc4-bd4a-7b457e20eca6"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(359), "192.168.1.56", (byte)2, 88.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("b52192fe-1990-4317-a055-3d21aacf922b"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9377), "192.168.1.14", (byte)1, 74.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("b55f5b98-ec93-422b-923b-e6d597a09ba2"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1750), "192.168.1.82", (byte)3, 29.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("b56c2446-ce0f-41f1-bc91-61e3a842d476"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9298), "192.168.1.43", (byte)1, 39.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("b58ccfd3-ea1b-4c36-b823-dcf679c8bf9d"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(300), "192.168.1.61", (byte)2, 33.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("b5d8bf0c-d48b-4ab9-a151-13f80209dc92"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(231), "192.168.1.86", (byte)2, 21.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b610d877-9ace-41cb-94fd-80e5c5e2e501"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(708), "192.168.1.13", (byte)2, 81.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b67dfb68-a900-4f11-a51f-dcaf48490b8a"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(626), "192.168.1.87", (byte)2, 41.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("b6809ccd-f916-4906-aa56-023487067217"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1825), "192.168.1.29", (byte)3, 23.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b6b2c819-e8de-414b-a92e-3461561a7516"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9781), "192.168.1.71", (byte)1, 0.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b77d0b90-cc10-447d-ac99-54dde99417d3"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1211), "192.168.1.17", (byte)3, 69.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("b7dce9b0-3554-473b-ac43-1890f44bb1ba"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1281), "192.168.1.34", (byte)3, 37.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b83fe884-af20-4964-a284-9beb247f37be"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1452), "192.168.1.66", (byte)3, 16.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("b8913b55-0df0-4108-9d76-1e02c7404e2e"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(862), "192.168.1.68", (byte)2, 88.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("b8b604e1-80b3-453f-8f38-4ca81b9091a3"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1804), "192.168.1.78", (byte)3, 91.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("b8f38750-8933-45f1-af12-d02d300e80a9"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9146), "192.168.1.45", (byte)1, 52.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("b915a4e6-8a0a-441c-8f8a-c474d0776038"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9343), "192.168.1.38", (byte)1, 65.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("b924aa00-33f6-48fa-a41f-bc18b1b1d335"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1120), "192.168.1.2", (byte)2, 36.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("b948d5e1-f969-47eb-bccf-a79bf147dbbc"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1617), "192.168.1.66", (byte)3, 36.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("b96b5c9b-2ab3-4faa-b4f9-26424f45e741"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2074), "192.168.1.60", (byte)3, 57.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("b994248e-ce2d-4476-a3f9-506273b788fb"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(469), "192.168.1.59", (byte)2, 92.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("bb12752e-5011-4ef6-a8d4-fe4d83883504"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(658), "192.168.1.90", (byte)2, 71.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("bcb5fca4-4817-48d5-b284-520349b4587c"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(946), "192.168.1.19", (byte)2, 88.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("bcdc76de-496c-4cc8-8331-32f34f6e0a25"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9613), "192.168.1.30", (byte)1, 47.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("bd8960c9-98c5-4954-96fc-f9eb3903738b"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9690), "192.168.1.87", (byte)1, 84.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("bd9dc88a-a735-428f-9336-5c88420a2fbf"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(241), "192.168.1.2", (byte)2, 97.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("bdc8f846-e000-4d25-b188-ff6e05244b24"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1448), "192.168.1.96", (byte)3, 75.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("be82efb6-467d-4758-977c-cf4f26b95076"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(119), "192.168.1.71", (byte)1, 52.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("bebd61d7-9535-4e2b-9c55-693df42796c2"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1600), "192.168.1.72", (byte)3, 18.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("c07a27cc-0663-483d-9e97-1621d0eb5877"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9836), "192.168.1.93", (byte)1, 77.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("c0cf3f1a-c3c3-4337-a1b6-f9fd40dcb804"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9811), "192.168.1.15", (byte)1, 33.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c1b00ed2-df00-45d6-947d-5603aaf3096f"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9184), "192.168.1.94", (byte)1, 22.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("c1b37e36-ad1f-48eb-8933-438bfe123f44"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(858), "192.168.1.76", (byte)2, 10.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("c21c9a0b-b53a-4835-a974-2574e0ff10de"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1703), "192.168.1.48", (byte)3, 64.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c21f538d-32bf-4671-9b86-b632fb4258ed"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(912), "192.168.1.49", (byte)2, 52.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("c2263dc0-8514-4a4f-840d-19ce34798dfd"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9327), "192.168.1.49", (byte)1, 52.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("c261b355-89a2-4a2a-af44-a52001919f5e"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(453), "192.168.1.41", (byte)2, 15.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("c26631f2-e126-4a6e-a5b5-d92c965b3c8b"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1310), "192.168.1.33", (byte)3, 30.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("c2fc2acb-0403-48a6-a303-9b9cb893f536"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9682), "192.168.1.70", (byte)1, 35.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("c3a54338-309a-4cc2-99dd-c489bbeb8779"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1571), "192.168.1.24", (byte)3, 29.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("c4496c4b-f29a-41d4-a227-d525f5f901bd"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2066), "192.168.1.54", (byte)3, 12.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c486e582-8353-4ac9-b287-a2b54f2a8045"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(41), "192.168.1.64", (byte)1, 15.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("c4ebf3c2-9a6d-4d3f-9212-392a0f9537bf"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1170), "192.168.1.37", (byte)2, 45.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("c505c1e6-e531-4414-9f1b-7e90ea4d9bc4"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9477), "192.168.1.49", (byte)1, 6.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("c5f868c5-3725-416c-8732-76dfeda0c5f7"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9790), "192.168.1.96", (byte)1, 39.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("c6575789-f105-4d8b-bba2-ea3178e0ae44"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9187), "192.168.1.74", (byte)1, 35.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c67c1c33-7b24-4c50-91ec-20caede1a8cd"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(5), "192.168.1.44", (byte)1, 95.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("c6aaf264-4c31-4bc4-8190-0255204bf8d7"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9142), "192.168.1.48", (byte)1, 22.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("c6acf9ac-c044-461c-ad36-1dd39730de22"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1641), "192.168.1.83", (byte)3, 26.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("c6cae6b9-28d6-40f0-879d-67fb21650806"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1742), "192.168.1.44", (byte)3, 29.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("c8236fce-f5c3-4833-8e9a-2c721769df5c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9821), "192.168.1.2", (byte)1, 2.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("c85a6e2a-da79-429a-9640-36ff43e27eae"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1322), "192.168.1.26", (byte)3, 60.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("c87b92d4-3cc1-4a19-9c44-fd5910dedb57"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2272), "192.168.1.75", (byte)3, 30.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("c887094b-f1b8-4b51-a9e5-338e2707abfa"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1333), "192.168.1.37", (byte)3, 11.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("c9b55100-160a-4541-a11f-89e6470f111a"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1326), "192.168.1.58", (byte)3, 0.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ca54facc-66e6-4c16-9b95-97035cd491dd"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9481), "192.168.1.36", (byte)1, 43.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("ca98aab1-d642-424f-a7e5-adfcf70b0c7a"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(959), "192.168.1.11", (byte)2, 29.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("cad4ff2a-a600-4cd7-bc1e-9f7e1c7b4e07"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9723), "192.168.1.57", (byte)1, 67.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("cb90dde0-10d8-4bee-a243-8f9f91d284a6"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(671), "192.168.1.17", (byte)2, 21.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("cb9893e0-04bb-45e5-96bd-2a0f5363b6f0"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1289), "192.168.1.95", (byte)3, 2.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("cc27138e-0da8-422a-91c7-372516a1f46d"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9224), "192.168.1.21", (byte)1, 64.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("cc4991e6-31a6-4da3-8c40-10bdd21a161c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9621), "192.168.1.99", (byte)1, 4.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("ccf0007e-68fe-4aaa-98ff-48dcec776c52"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1699), "192.168.1.31", (byte)3, 38.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("cd2bef95-fd8d-4360-9f9d-a6ac46f1c7ed"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9381), "192.168.1.84", (byte)1, 57.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("cd639469-3174-4c2d-a464-d817813ee24d"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(277), "192.168.1.90", (byte)2, 31.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("cd850baf-89ac-451d-889a-11dc8cd04a5f"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9882), "192.168.1.43", (byte)1, 21.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("cdc5fb89-d576-4b13-af4d-bff065fb0ae8"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9794), "192.168.1.86", (byte)1, 84.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("cde520b7-43e7-437d-964d-b2997b370175"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(716), "192.168.1.23", (byte)2, 32.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ce0bcaa9-6170-46a5-95ec-9cf9609d4d31"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1029), "192.168.1.64", (byte)2, 36.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("ce1cdbca-fbf8-4e43-ab73-320c57d3e5dc"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9458), "192.168.1.55", (byte)1, 59.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("cf0cd3c7-4129-47cb-8cb9-4af23a066112"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(220), "192.168.1.57", (byte)2, 83.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("cf8f2cf2-792e-4236-bfd7-565d916b1e9d"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9523), "192.168.1.44", (byte)1, 8.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("cfe40d12-04b1-4447-8feb-aba08b9585a4"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1397), "192.168.1.23", (byte)3, 96.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("d0b0c57c-f986-43e1-972a-15ef89680e09"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9735), "192.168.1.11", (byte)1, 58.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("d0f41935-3c4a-4b11-a65f-1925b6633c8b"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2029), "192.168.1.36", (byte)3, 76.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("d0fe40f4-2d9a-4481-8b68-09f52dc27038"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9853), "192.168.1.82", (byte)1, 22.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("d112e5af-99ac-4471-bf9c-d4656e150683"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9302), "192.168.1.47", (byte)1, 56.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("d1a7779b-97e2-4fa7-b3ee-e41f1c4a07b9"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9877), "192.168.1.20", (byte)1, 62.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d1b4d1d3-66ac-4ff2-8875-30e936957ca6"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2050), "192.168.1.31", (byte)3, 97.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("d1babf86-a653-4932-890a-763a69864aa6"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1062), "192.168.1.43", (byte)2, 43.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("d1fdf238-0d09-4240-a205-42609a1f2f6c"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(556), "192.168.1.86", (byte)2, 17.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("d241436f-9ecc-4277-a4ef-257ab864cc67"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(870), "192.168.1.21", (byte)2, 42.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("d2bfb31a-06c2-449d-9e5a-fb073b274f4c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(87), "192.168.1.59", (byte)1, 82.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("d33ef014-aa0f-4b42-9cb3-7f43c1ad60da"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9269), "192.168.1.62", (byte)1, 76.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("d3c1e419-80bb-4dbb-906e-5c17efaeec90"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(137), "192.168.1.43", (byte)2, 60.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("d3ff3fab-21bb-4717-935b-41acc601e099"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1099), "192.168.1.33", (byte)2, 13.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("d429c045-9dd8-4b39-a726-feea08e6e8d0"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1124), "192.168.1.34", (byte)2, 49.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("d449862f-dddf-4777-b396-c848585c4530"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1419), "192.168.1.98", (byte)3, 9.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("d48c5d11-25da-4250-b3ee-f84aca46dcd6"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(935), "192.168.1.54", (byte)2, 61.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d49c0940-4289-4b7a-b3d3-b13f86905c16"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(906), "192.168.1.66", (byte)2, 7.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("d544278a-9a70-46ea-9445-2f1c98ba022d"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1493), "192.168.1.75", (byte)3, 17.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d58823a9-a0f1-44b1-8d5b-eed0afa58217"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(83), "192.168.1.4", (byte)1, 26.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("d5f47e04-7181-4b05-a2bd-adff76fa2f7a"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1768), "192.168.1.90", (byte)3, 23.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d5f9c539-7bfe-4bab-8ca9-f1bbff499fb3"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1360), "192.168.1.58", (byte)3, 68.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("d6090c8a-0cc9-4f05-90f7-485528dde487"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(524), "192.168.1.87", (byte)2, 79.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("d6675f8b-980a-4a77-825c-42180da56272"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9287), "192.168.1.12", (byte)1, 26.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("d773a6dc-784d-4274-abdd-ad0581952e6a"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9617), "192.168.1.48", (byte)1, 5.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("d7a2e482-93df-466e-8075-9dc684ea7743"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1473), "192.168.1.27", (byte)3, 46.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("d7a3a2b2-c807-4d18-996b-04d34887f7a7"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2260), "192.168.1.38", (byte)3, 53.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("d7e85984-d11c-4ee8-a439-9549ca5063e1"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9555), "192.168.1.29", (byte)1, 77.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("d83f735d-e0d7-431c-92f6-79214a3499b3"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1608), "192.168.1.12", (byte)3, 28.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("d8c976c6-38bb-48e1-8b20-b1a7a9f630f2"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1182), "192.168.1.39", (byte)2, 57.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("d8e83f2a-9ae7-4eb1-9713-5bcf672c403d"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9068), "192.168.1.97", (byte)1, 96.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("d90c0d38-9059-4fc8-b686-a68febb15cb1"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2106), "192.168.1.54", (byte)3, 44.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("d9221416-12b0-4074-bf39-c7085c558291"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2127), "192.168.1.67", (byte)3, 26.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("d92d4b95-89e4-4577-9dea-7d9518ce4a1b"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9625), "192.168.1.1", (byte)1, 7.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("d9a99939-a95d-4369-aed2-b7d82e2e8036"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9231), "192.168.1.39", (byte)1, 48.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("dad5afb3-3c86-45b0-96ab-f0cb3bff08fa"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(683), "192.168.1.51", (byte)2, 89.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("db49e09e-b1f5-49ae-94e0-78d54b656b3c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9199), "192.168.1.17", (byte)1, 93.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("db4b4307-b8f1-49c5-9125-98aa20d10727"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9072), "192.168.1.44", (byte)1, 22.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("db7864d7-68ac-47d2-8b19-217d31e08547"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(252), "192.168.1.13", (byte)2, 75.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("db98ea53-e80b-4bd3-9cbf-12719b66b5e1"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9702), "192.168.1.54", (byte)1, 55.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("dbe36a90-4807-4072-b568-5b71c6778f4f"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9530), "192.168.1.92", (byte)1, 46.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("dc11ce98-3d2d-4ec4-bbc7-8e491536795e"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(833), "192.168.1.63", (byte)2, 9.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("dc5a8393-855a-4b85-90c1-52d043dd4c6c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9408), "192.168.1.59", (byte)1, 35.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("dccd8446-e0d4-4ee8-be0c-36c4ec4e7fe1"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(601), "192.168.1.43", (byte)2, 47.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("dd52e5d4-b033-4880-a708-8aac42bd4869"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(769), "192.168.1.30", (byte)2, 79.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("dd77d662-8d12-4963-80c5-e7da575ae153"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9290), "192.168.1.97", (byte)1, 29.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("ddb97cb6-753d-4707-93db-3dc6d9266747"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1937), "192.168.1.73", (byte)3, 8.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("de646939-5c45-4769-a898-ed2b3ea81678"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1048), "192.168.1.42", (byte)2, 28.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("de7ea6cd-e3df-4842-898f-244d6c70d85f"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1141), "192.168.1.43", (byte)2, 67.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("de8de8f1-a80b-437f-a941-5169f8a57eb8"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1821), "192.168.1.56", (byte)3, 84.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("df09ac85-5506-4104-b013-9fdf748a5e1e"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2194), "192.168.1.88", (byte)3, 60.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("df1a20fc-b0da-4187-a738-6ad8f25df221"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9909), "192.168.1.2", (byte)1, 71.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("df79ded0-5ee2-4da4-acfd-1e5641d07794"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(617), "192.168.1.35", (byte)2, 84.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("df8b348a-b718-414a-8b76-5b943799452e"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1646), "192.168.1.7", (byte)3, 75.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("dfb92919-1849-4a10-8ec9-df09de763bc6"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1945), "192.168.1.79", (byte)3, 47.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"), null, null, null },
                    { new Guid("e05ab139-9a11-45a8-aee3-7c0e4638704c"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(153), "192.168.1.83", (byte)2, 52.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e067c003-afe0-4f14-aac4-b2fe2daa6b06"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2054), "192.168.1.55", (byte)3, 73.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e07f5771-b690-4141-9cf3-582db08489f6"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9998), "192.168.1.56", (byte)1, 83.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("e0e2257c-2d61-4ed8-940c-9bf01ac27ae3"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(66), "192.168.1.79", (byte)1, 28.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e1d9b746-b7b0-4212-bca7-2c4bfc8ec1b4"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9739), "192.168.1.1", (byte)1, 96.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("e205d5c9-0fdd-487c-a715-03306ada7ce1"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(597), "192.168.1.4", (byte)2, 82.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("e31f2f58-49e6-4dd3-abc0-e2cc81678b2e"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(650), "192.168.1.68", (byte)2, 96.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("e363ef7c-1298-4d13-821f-99acf237ec80"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9216), "192.168.1.44", (byte)1, 74.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e3ac0e68-9371-4884-b4d0-92e8f761abb3"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9506), "192.168.1.59", (byte)1, 90.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("e3cbc796-361c-4000-b8ff-425cb508ae1a"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(613), "192.168.1.83", (byte)2, 83.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("e3fac5db-987a-4094-8847-4714ff6a991b"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9420), "192.168.1.40", (byte)1, 20.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("e43365ff-64da-4b14-8f8d-e6999663e894"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9099), "192.168.1.92", (byte)1, 80.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("e5141f46-bd83-4228-b26f-fe9fa47ea004"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(808), "192.168.1.43", (byte)2, 29.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("e5c6b4ff-b7f9-465c-a9f8-2ea487d0b030"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1137), "192.168.1.20", (byte)2, 30.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("e700189b-b5a9-4244-b9f8-d52d36ece388"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(593), "192.168.1.25", (byte)2, 43.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("e7bbfb7a-79c2-4316-96c5-98653aa32b59"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(112), "192.168.1.37", (byte)1, 63.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("e7de927e-6494-48f5-8dde-0909284d7aa6"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(818), "192.168.1.65", (byte)2, 79.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("e84e2577-4595-4563-a832-e6f68f30d856"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(18), "192.168.1.78", (byte)1, 56.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"), null, null, null },
                    { new Guid("e90da1ed-e4aa-4ce6-991e-87d0f5d8d5e8"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1356), "192.168.1.88", (byte)3, 49.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("e95df58a-30ee-4e5e-a3b7-b1e446295036"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(975), "192.168.1.1", (byte)2, 75.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("ea8e147e-7557-46c5-87ec-7adcf9a0514c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9986), "192.168.1.54", (byte)1, 41.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("ea90275a-dd72-4ffd-9143-8dfc6581dac6"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9324), "192.168.1.79", (byte)1, 94.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("eae9285b-8c9a-4d53-809e-ab2bb6a75ed5"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1927), "192.168.1.58", (byte)3, 98.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("eaefd550-4f12-409d-a160-93de504666b6"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9862), "192.168.1.7", (byte)1, 67.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("eb3618bf-1c2a-4380-af2f-03bca44537cd"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1666), "192.168.1.26", (byte)3, 30.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("eb7810bb-f48f-42f2-bd44-a29304bf3c9e"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(371), "192.168.1.40", (byte)2, 5.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("ec470ceb-59c4-4699-9dfa-f39a02a7f897"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(920), "192.168.1.30", (byte)2, 68.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("ec7df910-e183-403e-8dca-3bd7d4970ff7"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9277), "192.168.1.32", (byte)1, 33.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("ecd21430-e55c-4286-81f0-bc364ee1a781"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9934), "192.168.1.94", (byte)1, 6.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("ed2e0c3d-1f70-43fb-a87a-554673aadba0"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(866), "192.168.1.40", (byte)2, 84.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ed6899fa-477e-4fa8-aff5-c5ddf95dd653"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9527), "192.168.1.63", (byte)1, 28.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ed77f8ca-f6cc-44bf-bca2-57dd9f3ef598"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(74), "192.168.1.40", (byte)1, 14.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("edcb1b51-b294-47d2-adb8-c879098db649"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9886), "192.168.1.11", (byte)1, 22.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"), null, null, null },
                    { new Guid("ee0580f1-4a0e-4371-b60c-a9714af9a67f"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9869), "192.168.1.72", (byte)1, 37.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("ee28f804-5e2f-49ca-9b2a-a546a011a682"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(551), "192.168.1.93", (byte)2, 25.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"), null, null, null },
                    { new Guid("ef03aba3-fea6-4e0c-97f4-ce84bbf34e2e"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1898), "192.168.1.24", (byte)3, 92.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ef6d9684-46d7-4626-9cd9-07424da831dc"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9906), "192.168.1.88", (byte)1, 74.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("f002227e-f534-4ed7-bdad-c3bbaeccad3e"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1194), "192.168.1.17", (byte)3, 16.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f01e3945-2da0-4311-a257-7bab3c80963d"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1726), "192.168.1.58", (byte)3, 54.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f19306dd-ee65-485b-a6cf-d8cd79d89cd0"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9665), "192.168.1.58", (byte)1, 61.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f1b49a05-5e63-43c4-8d67-27a013d3d5c4"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(124), "192.168.1.41", (byte)2, 48.0, new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f1cf53a5-c0f9-435d-9d7a-8546a035d38a"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1931), "192.168.1.82", (byte)3, 47.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f1e543fa-a17e-4be5-80b8-e7e22db945b3"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(404), "192.168.1.52", (byte)2, 60.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f1ebd939-d422-415a-a32d-5d63f0fc426c"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1584), "192.168.1.40", (byte)3, 28.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"), null, null, null },
                    { new Guid("f25745bf-5190-48a6-8b73-3503caf039b7"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(931), "192.168.1.14", (byte)2, 13.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("f27f8ddd-ea12-4c9a-af89-41b30da0acea"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(70), "192.168.1.40", (byte)1, 54.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("f2e267df-c45a-4185-b4f0-b79bdd5fef8d"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1592), "192.168.1.38", (byte)3, 21.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"), null, null, null },
                    { new Guid("f3558729-9520-41c3-8edd-330286c51087"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9369), "192.168.1.67", (byte)1, 40.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f36891f9-ad1f-4703-97e7-4af8644a6f96"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9600), "192.168.1.30", (byte)1, 86.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f38c6246-6eb9-42e8-b52c-f440fb35e8d0"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(547), "192.168.1.86", (byte)2, 71.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("f408ad95-27da-4420-aeb3-9953a65b61d0"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9306), "192.168.1.34", (byte)1, 68.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f4795ab9-7f49-4baf-9200-62dbda101735"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(646), "192.168.1.97", (byte)2, 96.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("f4b7235f-1144-44cd-b6e5-484c06f68034"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1658), "192.168.1.64", (byte)3, 31.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("f4b9ddc2-610f-492d-8954-05f6662f0cc5"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9335), "192.168.1.78", (byte)1, 78.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"), null, null, null },
                    { new Guid("f4cccf74-fec4-4dc0-a50a-c8e8d33fe334"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(955), "192.168.1.12", (byte)2, 10.0, new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"), new Guid("c0340c3c-9153-4951-969d-1b0136758af7"), null, null, null },
                    { new Guid("f56389de-a46e-4906-aea7-cef69fd5822c"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1423), "192.168.1.69", (byte)3, 71.0, new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"), new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"), null, null, null },
                    { new Guid("f58fe554-31d7-4d4a-a7a9-d91eeeaf6a19"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1707), "192.168.1.43", (byte)3, 71.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f6002a39-aeb0-444c-9249-bcc06123b38c"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9744), "192.168.1.7", (byte)1, 80.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("f67b6380-7dae-4e34-b33c-5d05979ff66d"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2153), "192.168.1.18", (byte)3, 86.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("f6c85353-3d70-4de0-a45e-0504fbbedc51"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(704), "192.168.1.17", (byte)2, 54.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("f759c6be-b03c-4abd-963c-53758804d264"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2149), "192.168.1.27", (byte)3, 16.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("f792b47c-b5a6-4621-8fc2-7a213dbffc51"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1337), "192.168.1.54", (byte)3, 99.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("f802948d-7685-4343-b2db-5ee462398664"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9752), "192.168.1.65", (byte)1, 16.0, new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("f804ed0d-f913-4c0e-9f84-3c3172ff4d68"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(609), "192.168.1.65", (byte)2, 51.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("f8454504-b584-4d99-a73b-0c49355d29e9"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(543), "192.168.1.65", (byte)2, 2.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"), null, null, null },
                    { new Guid("f8aac98f-26d2-497a-9e24-cd045114d27d"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1829), "192.168.1.17", (byte)3, 25.0, new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"), new Guid("fb221081-45cd-42be-abd4-45976e996233"), null, null, null },
                    { new Guid("f99f5181-606f-4a51-9972-e483bcc3fa43"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9551), "192.168.1.46", (byte)1, 75.0, new Guid("15b6a548-4045-4892-904a-aeeba517960d"), new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"), null, null, null },
                    { new Guid("f9aff653-7ce3-4b54-9887-4eed188f6647"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(432), "192.168.1.4", (byte)2, 83.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"), null, null, null },
                    { new Guid("fa1b26b3-2d11-4aef-bb20-ef6ff4dff31c"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(292), "192.168.1.23", (byte)2, 98.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"), null, null, null },
                    { new Guid("fb50bab9-d9ad-449a-b3e4-81bb2351159f"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9195), "192.168.1.59", (byte)1, 8.0, new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"), new Guid("bd914d22-1482-497d-a552-6926b915f669"), null, null, null },
                    { new Guid("fbb1f207-a46c-4ac5-949e-dd932e547fad"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9400), "192.168.1.79", (byte)1, 87.0, new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null },
                    { new Guid("fc5dc847-d5d8-4243-a963-805a589ee923"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(1166), "192.168.1.98", (byte)2, 10.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"), null, null, null },
                    { new Guid("fd9347b9-82e6-45f0-82b9-856bb1fdfdfe"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2198), "192.168.1.92", (byte)3, 8.0, new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"), new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"), null, null, null },
                    { new Guid("fe2bd1af-db4c-47a1-9040-7ca7dbb1c054"), "Computer2", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(2145), "192.168.1.1", (byte)3, 60.0, new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"), new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"), null, null, null },
                    { new Guid("feb9cf67-7ecf-490f-8a7d-d3f6659e11e7"), "Computer0", new DateTime(2024, 2, 9, 18, 30, 5, 184, DateTimeKind.Utc).AddTicks(9469), "192.168.1.64", (byte)1, 28.0, new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"), new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"), null, null, null },
                    { new Guid("ff966114-6fbc-4643-ab83-310db8531328"), "Computer1", new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(903), "192.168.1.83", (byte)2, 46.0, new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"), new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"), null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "MainCourses",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3136));

            migrationBuilder.InsertData(
                table: "ParentStudents",
                columns: new[] { "ParentId", "StudentId" },
                values: new object[,]
                {
                    { new Guid("0b28a8c9-b390-485d-815d-82977278f08d"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") },
                    { new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"), new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36") },
                    { new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4") },
                    { new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1") },
                    { new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") },
                    { new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"), new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2") },
                    { new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") },
                    { new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"), new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4") },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("15b6a548-4045-4892-904a-aeeba517960d") },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1") },
                    { new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"), new Guid("84e959f6-d8b7-45e7-972b-f943292667e6") }
                });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("0b28a8c9-b390-485d-815d-82977278f08d"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("1c9b13ae-e98c-4c1e-95c4-3b315670c61c"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("1f607b4f-3157-490d-9ce2-85883aa55c70"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("304a46c6-a4cb-4fed-8b44-0f40b510e881"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("45e137c7-0927-4931-bbf3-2b42a90f66d3"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("47d6a0ea-8050-420e-9500-2c9eb265a678"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("4bafb160-f5a6-4dae-9a80-bc8c47ae0bdc"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("5ddce5a3-d715-46f8-8ca3-4fca5f75b139"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("8cd19ad1-e4e2-4f70-a154-cfb42b49d52b"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: new Guid("f6b10f49-d859-47bd-99b3-2d5e52f3ba25"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("851ed332-2317-4dd5-9076-63a9a46172c6"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("8929bfa5-e201-447a-a013-808a1672bbd5"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("ac317057-dc54-44bc-a43c-e85c8f414044"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("afdfe876-3b49-4d60-9e1b-ddf2961bce56"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("bd6dfea8-ef24-438e-90df-aaeb10bb24f2"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0fe058ba-160a-43e8-9bdd-7c35124dd6d2"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("15b6a548-4045-4892-904a-aeeba517960d"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("42c58e42-bbbf-4304-a553-11ba20522f20"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4b90e195-c72c-400a-a19c-0828ce7d12e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("70ee831b-0e8e-4324-b7e8-cc26f32ac84c"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("798f421b-3bb6-4d77-bfa4-292a0f11b46a"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7e5ae383-0067-4af0-94f3-43d725bef5d1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("84e959f6-d8b7-45e7-972b-f943292667e6"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("96e2572b-819d-4094-83f9-e9e06fd9fca1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a30b57b4-7d3e-4a7b-8cb9-da33e4246fa4"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c1a02c1a-7f16-4262-a795-3d866a399a36"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d9d28310-a5a6-4c31-87f2-7849f926d9fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("02bfcbb1-4f1a-487f-ab48-cd9322e7b4df"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("1e3845ac-b77e-42ab-b5bf-e12b03e8b9d2"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("36400de0-3b8c-4c08-ab07-628e17b9fc56"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("4e8f036d-6181-4c1f-a349-4ffcc3447ba7"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("4ee32722-4aca-42f9-9fd6-060b9a3066c1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("5cd9fdcc-b62b-4481-b63c-b5681d48d31e"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("6b36a63c-a7c0-495c-9247-082ab342d65a"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("722fa150-b091-4ef8-a2ea-c2b782f42c73"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("8c9f4082-6b71-4b52-8e96-01b3933e5797"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("8eeda5b3-20f9-4d98-8b94-8e42e49f6b0b"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("9aceddeb-6886-4535-9f45-989fee247cb9"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("9c7df23d-8358-45b5-94e1-fe907e573723"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("a5f980a8-71c0-45a1-a360-8caff5e174ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("b1760af3-a642-4c3d-9c29-7364f4607a48"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("b8be083e-1748-47cc-aab8-754f8a7434f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("bd914d22-1482-497d-a552-6926b915f669"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("c0340c3c-9153-4951-969d-1b0136758af7"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("c3caf58e-75b9-4e07-bac9-fe809da8ac54"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("e02cceb0-48bf-41c3-98e3-73c9c0c69b1c"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "SubCourses",
                keyColumn: "Id",
                keyValue: new Guid("fb221081-45cd-42be-abd4-45976e996233"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("2e032c26-8554-4ab9-8e06-77cfd8f9652d"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("35cced10-9fc1-4413-9e09-080b408b23c3"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("3ca93105-bfff-4791-9cc4-82a7a97ad756"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("4eca2d83-365e-4926-b42c-2415618b5e19"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a444db40-a494-4e3d-91d1-eea2779bf147"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a82047bd-f57e-4c34-928c-8b8d2c3fa636"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("b1cf8e9f-c6a9-4070-9304-b9602ce9ef76"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("dd82ca7c-38ca-4a8c-989b-a47d44d9b132"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("f12dbbce-5d81-4f38-8eab-b267b2263556"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("f6563118-b1bf-4d43-ab6d-c427a9f13f7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("fa70cb23-9c69-4548-8f15-77e93139ab41"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 9, 18, 30, 5, 185, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.CreateIndex(
                name: "IX_StudentTeachers_TeacherId",
                table: "StudentTeachers",
                column: "TeacherId");
        }
    }
}
