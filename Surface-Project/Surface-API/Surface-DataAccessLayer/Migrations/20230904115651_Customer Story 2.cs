using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class CustomerStory2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Statuses_StatusId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_User_CreatedBy",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_User_ModifiedBy",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_User_LoginProviders_LoginProviderId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Statuses_StatusId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_Name",
                table: "UserRoles",
                newName: "IX_UserRoles_Name");

            migrationBuilder.RenameIndex(
                name: "IX_User_StatusId",
                table: "Users",
                newName: "IX_Users_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_User_LoginProviderId",
                table: "Users",
                newName: "IX_Users_LoginProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_User_Email",
                table: "Users",
                newName: "IX_Users_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Project_StatusId",
                table: "Projects",
                newName: "IX_Projects_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Project_ModifiedBy",
                table: "Projects",
                newName: "IX_Projects_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Project_CreatedBy",
                table: "Projects",
                newName: "IX_Projects_CreatedBy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CustomerStories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Story = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Index = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<long>(type: "bigint", nullable: false),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerStories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerStories_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerStories_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerStories_Users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CustomerStories",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Index", "ModifiedBy", "ModifiedOn", "Name", "ProjectId", "StatusId", "Story" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 9, 4, 17, 26, 51, 449, DateTimeKind.Local).AddTicks(6262), 1, 1L, new DateTime(2023, 9, 4, 17, 26, 51, 449, DateTimeKind.Local).AddTicks(6277), "Surface Story 1", 1L, (byte)26, "<h1>Story:</h1>\r\n<p>As a project manager or team member, I want the ability to customize my user profile to provide more context about myself and my role within the organization. This customization will enhance collaboration within the project management system.</p>\r\n\r\n<h2>Acceptance Criteria:</h2>\r\n\r\n<ol>\r\n    <li>\r\n        <h3>Profile Photo:</h3>\r\n        <ul>\r\n            <li>I can upload a profile photo to personalize my user account.</li>\r\n            <li>The profile photo should be displayed next to my name throughout the application.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Personal Information:</h3>\r\n        <ul>\r\n            <li>I can edit my name, job title, and contact information in my profile.</li>\r\n            <li>Changes to my personal information should be reflected in the user interface.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Bio and Description:</h3>\r\n        <ul>\r\n            <li>I can write a brief bio or description about myself, highlighting my skills, responsibilities, or any relevant information.</li>\r\n            <li>The bio/description should be displayed on my profile page and in project team member lists.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Time Zone Setting:</h3>\r\n        <ul>\r\n            <li>I can set my preferred time zone to ensure that all project-related dates and times are displayed correctly for my location.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Privacy Settings:</h3>\r\n        <ul>\r\n            <li>I can choose who can view my profile information:</li>\r\n            <ul>\r\n                <li>[ ] Only me</li>\r\n                <li>[ ] My team members</li>\r\n                <li>[ ] Everyone in the organization</li>\r\n            </ul>\r\n            <li>Profile information should be visible only to those I've granted access to.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Save Changes:</h3>\r\n        <ul>\r\n            <li>After making any updates to my profile, I can save the changes, and they should persist across sessions.</li>\r\n        </ul>\r\n    </li>\r\n</ol>\r\n\r\n<h2>Definition of Done:</h2>\r\n<ul>\r\n    <li>The user profile customization feature has been thoroughly tested and is free of bugs.</li>\r\n    <li>The changes made to the user profile are stored securely and persist in the database.</li>\r\n    <li>User data privacy and access controls are enforced according to the selected privacy settings.</li>\r\n    <li>The user interface provides clear and user-friendly options for customizing the profile.</li>\r\n    <li>Documentation and user guides have been updated to explain how to use the new profile customization feature.</li>\r\n</ul>" },
                    { 2L, 1L, new DateTime(2023, 9, 4, 17, 26, 51, 449, DateTimeKind.Local).AddTicks(6283), 2, 1L, new DateTime(2023, 9, 4, 17, 26, 51, 449, DateTimeKind.Local).AddTicks(6284), "Surface Story 1", 1L, (byte)26, "<h1>Story:</h1>\r\n<p>As a project manager or team member, I want the ability to customize my user profile to provide more context about myself and my role within the organization. This customization will enhance collaboration within the project management system.</p>\r\n\r\n<h2>Acceptance Criteria:</h2>\r\n\r\n<ol>\r\n    <li>\r\n        <h3>Profile Photo:</h3>\r\n        <ul>\r\n            <li>I can upload a profile photo to personalize my user account.</li>\r\n            <li>The profile photo should be displayed next to my name throughout the application.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Personal Information:</h3>\r\n        <ul>\r\n            <li>I can edit my name, job title, and contact information in my profile.</li>\r\n            <li>Changes to my personal information should be reflected in the user interface.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Bio and Description:</h3>\r\n        <ul>\r\n            <li>I can write a brief bio or description about myself, highlighting my skills, responsibilities, or any relevant information.</li>\r\n            <li>The bio/description should be displayed on my profile page and in project team member lists.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Time Zone Setting:</h3>\r\n        <ul>\r\n            <li>I can set my preferred time zone to ensure that all project-related dates and times are displayed correctly for my location.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Privacy Settings:</h3>\r\n        <ul>\r\n            <li>I can choose who can view my profile information:</li>\r\n            <ul>\r\n                <li>[ ] Only me</li>\r\n                <li>[ ] My team members</li>\r\n                <li>[ ] Everyone in the organization</li>\r\n            </ul>\r\n            <li>Profile information should be visible only to those I've granted access to.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Save Changes:</h3>\r\n        <ul>\r\n            <li>After making any updates to my profile, I can save the changes, and they should persist across sessions.</li>\r\n        </ul>\r\n    </li>\r\n</ol>\r\n\r\n<h2>Definition of Done:</h2>\r\n<ul>\r\n    <li>The user profile customization feature has been thoroughly tested and is free of bugs.</li>\r\n    <li>The changes made to the user profile are stored securely and persist in the database.</li>\r\n    <li>User data privacy and access controls are enforced according to the selected privacy settings.</li>\r\n    <li>The user interface provides clear and user-friendly options for customizing the profile.</li>\r\n    <li>Documentation and user guides have been updated to explain how to use the new profile customization feature.</li>\r\n</ul>" },
                    { 3L, 1L, new DateTime(2023, 9, 4, 17, 26, 51, 449, DateTimeKind.Local).AddTicks(6289), 3, 1L, new DateTime(2023, 9, 4, 17, 26, 51, 449, DateTimeKind.Local).AddTicks(6290), "Surface Story 1", 1L, (byte)26, "<h1>Story:</h1>\r\n<p>As a project manager or team member, I want the ability to customize my user profile to provide more context about myself and my role within the organization. This customization will enhance collaboration within the project management system.</p>\r\n\r\n<h2>Acceptance Criteria:</h2>\r\n\r\n<ol>\r\n    <li>\r\n        <h3>Profile Photo:</h3>\r\n        <ul>\r\n            <li>I can upload a profile photo to personalize my user account.</li>\r\n            <li>The profile photo should be displayed next to my name throughout the application.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Personal Information:</h3>\r\n        <ul>\r\n            <li>I can edit my name, job title, and contact information in my profile.</li>\r\n            <li>Changes to my personal information should be reflected in the user interface.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Bio and Description:</h3>\r\n        <ul>\r\n            <li>I can write a brief bio or description about myself, highlighting my skills, responsibilities, or any relevant information.</li>\r\n            <li>The bio/description should be displayed on my profile page and in project team member lists.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Time Zone Setting:</h3>\r\n        <ul>\r\n            <li>I can set my preferred time zone to ensure that all project-related dates and times are displayed correctly for my location.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Privacy Settings:</h3>\r\n        <ul>\r\n            <li>I can choose who can view my profile information:</li>\r\n            <ul>\r\n                <li>[ ] Only me</li>\r\n                <li>[ ] My team members</li>\r\n                <li>[ ] Everyone in the organization</li>\r\n            </ul>\r\n            <li>Profile information should be visible only to those I've granted access to.</li>\r\n        </ul>\r\n    </li>\r\n    \r\n    <li>\r\n        <h3>Save Changes:</h3>\r\n        <ul>\r\n            <li>After making any updates to my profile, I can save the changes, and they should persist across sessions.</li>\r\n        </ul>\r\n    </li>\r\n</ol>\r\n\r\n<h2>Definition of Done:</h2>\r\n<ul>\r\n    <li>The user profile customization feature has been thoroughly tested and is free of bugs.</li>\r\n    <li>The changes made to the user profile are stored securely and persist in the database.</li>\r\n    <li>User data privacy and access controls are enforced according to the selected privacy settings.</li>\r\n    <li>The user interface provides clear and user-friendly options for customizing the profile.</li>\r\n    <li>Documentation and user guides have been updated to explain how to use the new profile customization feature.</li>\r\n</ul>" }
                });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 440, DateTimeKind.Utc).AddTicks(2145), new DateTime(2023, 9, 4, 11, 56, 51, 440, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 440, DateTimeKind.Utc).AddTicks(2151), new DateTime(2023, 9, 4, 11, 56, 51, 440, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1441), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1460), new DateTime(2024, 2, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1449), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1463), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1470), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1475), new DateTime(2023, 12, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1472), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1477), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1482), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1486), new DateTime(2023, 11, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1483), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1487), new DateTime(2023, 9, 4, 17, 26, 51, 447, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3483), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3510), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3514), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3519), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3523), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3527), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7687), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7703), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7707), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7714), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7717), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7720), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7724), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7727), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7730), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7733), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7743), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7746), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7750), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7753), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7756), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7759), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7762), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7765), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7768), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7772), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7775), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7778), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)27,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7781), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)28,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7784), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)29,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7787), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)30,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7791), new DateTime(2023, 9, 4, 17, 26, 51, 439, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4751), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4760), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4764), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4768), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4772), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4776), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4780), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4784), new DateTime(2023, 9, 4, 11, 56, 51, 444, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 26, 51, 444, DateTimeKind.Local).AddTicks(1439), new DateTime(2023, 9, 4, 17, 26, 51, 444, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerStories_CreatedBy",
                table: "CustomerStories",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerStories_ModifiedBy",
                table: "CustomerStories",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerStories_StatusId",
                table: "CustomerStories",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Statuses_StatusId",
                table: "Projects",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_CreatedBy",
                table: "Projects",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_ModifiedBy",
                table: "Projects",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_LoginProviders_LoginProviderId",
                table: "Users",
                column: "LoginProviderId",
                principalTable: "LoginProviders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Statuses_StatusId",
                table: "Users",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Statuses_StatusId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_CreatedBy",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_ModifiedBy",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_LoginProviders_LoginProviderId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Statuses_StatusId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "CustomerStories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameIndex(
                name: "IX_Users_StatusId",
                table: "User",
                newName: "IX_User_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_LoginProviderId",
                table: "User",
                newName: "IX_User_LoginProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email",
                table: "User",
                newName: "IX_User_Email");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_Name",
                table: "UserRole",
                newName: "IX_UserRole_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_StatusId",
                table: "Project",
                newName: "IX_Project_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_ModifiedBy",
                table: "Project",
                newName: "IX_Project_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_CreatedBy",
                table: "Project",
                newName: "IX_Project_CreatedBy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 963, DateTimeKind.Utc).AddTicks(8451), new DateTime(2023, 9, 4, 11, 52, 16, 963, DateTimeKind.Utc).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "LoginProviders",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 963, DateTimeKind.Utc).AddTicks(8455), new DateTime(2023, 9, 4, 11, 52, 16, 963, DateTimeKind.Utc).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3713), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3727), new DateTime(2024, 2, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3717), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3730), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3734), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3738), new DateTime(2023, 12, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3736), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3739), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "ActualStartDate", "CreatedOn", "EndDate", "ModifiedOn", "StartDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3744), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3747), new DateTime(2023, 11, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3745), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3748), new DateTime(2023, 9, 4, 17, 22, 16, 968, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1826), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1850), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1854), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1857), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1861), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "StatusGroups",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1864), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4756), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4765), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4769), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4773), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4776), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4780), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4783), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4787), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4790), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4794), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4797), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4801), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4804), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4807), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4811), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4814), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4818), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4821), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4825), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4828), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4832), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4835), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4838), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4842), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4845), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4849), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)27,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4852), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)28,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4856), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)29,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4859), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: (byte)30,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4862), new DateTime(2023, 9, 4, 17, 22, 16, 963, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 22, 16, 966, DateTimeKind.Local).AddTicks(517), new DateTime(2023, 9, 4, 17, 22, 16, 966, DateTimeKind.Local).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2666), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2670), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2673), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2676), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2679), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2682), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2685), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: (byte)8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2688), new DateTime(2023, 9, 4, 11, 52, 16, 966, DateTimeKind.Utc).AddTicks(2688) });

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Statuses_StatusId",
                table: "Project",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_User_CreatedBy",
                table: "Project",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_User_ModifiedBy",
                table: "Project",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_LoginProviders_LoginProviderId",
                table: "User",
                column: "LoginProviderId",
                principalTable: "LoginProviders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Statuses_StatusId",
                table: "User",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id");
        }
    }
}
