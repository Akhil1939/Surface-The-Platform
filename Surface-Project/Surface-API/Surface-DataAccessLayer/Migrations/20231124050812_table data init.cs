using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Surface_DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class tabledatainit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StatusGroups",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusGroupId = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statuses_StatusGroups_StatusGroupId",
                        column: x => x.StatusGroupId,
                        principalTable: "StatusGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LoginProviders",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginProviders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoginProviders_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginProviderId = table.Column<byte>(type: "tinyint", nullable: false),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    AccessFailedCount = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)0),
                    LockedOutEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getutcdate())"),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getutcdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_LoginProviders_LoginProviderId",
                        column: x => x.LoginProviderId,
                        principalTable: "LoginProviders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RepoLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budget = table.Column<double>(type: "float", nullable: false),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Projects_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Projects_Users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

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
                        name: "FK_CustomerStories_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
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

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teams_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teams_Users_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    UserRoleId = table.Column<byte>(type: "tinyint", nullable: false),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamMembers_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TeamMembers_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamMembers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "StatusGroups",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1524), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1533), "User" },
                    { (byte)2, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1535), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1536), "Project" },
                    { (byte)3, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1537), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1538), "Task" },
                    { (byte)4, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1540), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1540), "Feature" },
                    { (byte)5, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1542), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1542), "Bug" },
                    { (byte)6, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1544), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1544), "Customer Story" },
                    { (byte)7, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1545), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(1546), "TeamMember" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5136), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5136), "ProjectManager" },
                    { (byte)2, new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5138), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5139), "ProjectMember" },
                    { (byte)3, new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5140), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5141), "ProjectViewer" },
                    { (byte)4, new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5142), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5142), "ProjectAdmin" },
                    { (byte)5, new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5144), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5144), "TeamLeader" },
                    { (byte)6, new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5145), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5146), "Developer" },
                    { (byte)7, new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5147), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5148), "QAEngineer" },
                    { (byte)8, new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5149), new DateTime(2023, 11, 24, 5, 8, 12, 98, DateTimeKind.Utc).AddTicks(5149), "BusinessAnalyst" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name", "StatusGroupId" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3445), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3448), "Active", (byte)1 },
                    { (byte)2, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3450), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3451), "Inactive", (byte)1 },
                    { (byte)3, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3453), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3453), "Reported", (byte)1 },
                    { (byte)4, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3455), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3455), "Blocked", (byte)1 },
                    { (byte)5, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3457), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3458), "Deleted", (byte)1 },
                    { (byte)6, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3459), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3460), "Locked", (byte)1 },
                    { (byte)7, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3461), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3462), "Planning", (byte)2 },
                    { (byte)8, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3464), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3464), "Active", (byte)2 },
                    { (byte)9, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3466), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3466), "On Hold", (byte)2 },
                    { (byte)10, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3467), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3468), "Completed", (byte)2 },
                    { (byte)11, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3470), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3470), "Cancelled", (byte)2 },
                    { (byte)12, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3472), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3472), "To Do", (byte)3 },
                    { (byte)13, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3474), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3474), "In Progress", (byte)3 },
                    { (byte)14, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3476), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3476), "Blocked", (byte)3 },
                    { (byte)15, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3478), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3478), "Completed", (byte)3 },
                    { (byte)16, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3480), "Deferred", (byte)3 },
                    { (byte)17, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3482), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3483), "Idea", (byte)4 },
                    { (byte)18, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3484), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3485), "Backlog", (byte)4 },
                    { (byte)19, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3486), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3486), "In Progress", (byte)4 },
                    { (byte)20, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3488), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3489), "Testing", (byte)4 },
                    { (byte)21, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3490), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3491), "Released", (byte)4 },
                    { (byte)22, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3492), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3493), "Reported", (byte)5 },
                    { (byte)23, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3494), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3495), "In Progress", (byte)5 },
                    { (byte)24, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3496), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3497), "Reproduced", (byte)5 },
                    { (byte)25, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3498), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3499), "Fixed", (byte)5 },
                    { (byte)26, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3500), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3501), "Verified", (byte)5 },
                    { (byte)27, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3502), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3503), "Pending", (byte)6 },
                    { (byte)28, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3505), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3505), "Reviewed", (byte)6 },
                    { (byte)29, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3506), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3507), "In Progress", (byte)6 },
                    { (byte)30, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3508), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3509), "Closed", (byte)6 },
                    { (byte)31, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3511), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3511), "Active", (byte)7 },
                    { (byte)32, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3513), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3513), "On Leave", (byte)7 },
                    { (byte)33, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3515), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3515), "Pending", (byte)7 },
                    { (byte)34, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3517), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3517), "Completed", (byte)7 },
                    { (byte)35, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3519), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3519), "Resigned/Left", (byte)7 },
                    { (byte)36, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3521), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3521), "Suspended", (byte)7 },
                    { (byte)37, new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3523), new DateTime(2023, 11, 24, 10, 38, 12, 96, DateTimeKind.Local).AddTicks(3523), "Not Assigned", (byte)7 }
                });

            migrationBuilder.InsertData(
                table: "LoginProviders",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name", "StatusId" },
                values: new object[,]
                {
                    { (byte)1, new DateTime(2023, 11, 24, 5, 8, 12, 96, DateTimeKind.Utc).AddTicks(5143), new DateTime(2023, 11, 24, 5, 8, 12, 96, DateTimeKind.Utc).AddTicks(5143), "Custom", (byte)1 },
                    { (byte)2, new DateTime(2023, 11, 24, 5, 8, 12, 96, DateTimeKind.Utc).AddTicks(5145), new DateTime(2023, 11, 24, 5, 8, 12, 96, DateTimeKind.Utc).AddTicks(5146), "Google", (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CreatedOn", "Email", "FirstName", "LastName", "LockedOutEndDate", "LoginProviderId", "ModifiedOn", "Password", "Salt", "StatusId", "Token" },
                values: new object[] { 1L, "", new DateTime(2023, 11, 24, 10, 38, 12, 98, DateTimeKind.Local).AddTicks(441), "admin@gmail.com", "admin", null, null, (byte)1, new DateTime(2023, 11, 24, 10, 38, 12, 98, DateTimeKind.Local).AddTicks(445), "5652DDF6EA419A920A948A4BBA99A1B48B434D1237218FCF8D2DA2DA41E7C0F4046BC10C12ABDA86D09022B2AD1D6F566F82F3DF72CDFAEE40AB154537DFB8FD", "+QA9bkBDYMlaPDTRzIYMoPeMDd9oa9k/Ay4Lg==", (byte)1, null });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ActualEndDate", "ActualStartDate", "Budget", "CreatedBy", "CreatedOn", "Description", "EndDate", "ModifiedBy", "ModifiedOn", "Name", "RepoLink", "StartDate", "StatusId" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4918), 5000.0, 1L, new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4928), "This is a demo project that all users are in this project", new DateTime(2024, 4, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4921), 1L, new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4929), "Surface", null, new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4910), (byte)8 },
                    { 2L, null, new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4932), 10000.0, 1L, new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4934), "A new development project", new DateTime(2024, 2, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4933), 1L, new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4935), "Project A", "https://github.com/projecta", new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4931), (byte)8 },
                    { 3L, null, new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4937), 7500.0, 1L, new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4939), "Another project for testing", new DateTime(2024, 1, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4938), 1L, new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4939), "Project B", "https://github.com/projectb", new DateTime(2023, 11, 24, 10, 38, 12, 99, DateTimeKind.Local).AddTicks(4937), (byte)8 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "ModifiedBy", "ModifiedOn", "Name", "ProjectId" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 11, 24, 10, 38, 12, 101, DateTimeKind.Local).AddTicks(8284), 1L, new DateTime(2023, 11, 24, 10, 38, 12, 101, DateTimeKind.Local).AddTicks(8289), "Design", 1L },
                    { 2L, 1L, new DateTime(2023, 11, 24, 10, 38, 12, 101, DateTimeKind.Local).AddTicks(8291), 1L, new DateTime(2023, 11, 24, 10, 38, 12, 101, DateTimeKind.Local).AddTicks(8292), "Development", 1L },
                    { 3L, 1L, new DateTime(2023, 11, 24, 10, 38, 12, 101, DateTimeKind.Local).AddTicks(8293), 1L, new DateTime(2023, 11, 24, 10, 38, 12, 101, DateTimeKind.Local).AddTicks(8294), "Testing", 1L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerStories_CreatedBy",
                table: "CustomerStories",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerStories_ModifiedBy",
                table: "CustomerStories",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerStories_ProjectId",
                table: "CustomerStories",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerStories_StatusId",
                table: "CustomerStories",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginProviders_Name",
                table: "LoginProviders",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoginProviders_StatusId",
                table: "LoginProviders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CreatedBy",
                table: "Projects",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ModifiedBy",
                table: "Projects",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_StatusId",
                table: "Projects",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_StatusGroupId",
                table: "Statuses",
                column: "StatusGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_StatusId",
                table: "TeamMembers",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_TeamId",
                table: "TeamMembers",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_UserId",
                table: "TeamMembers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CreatedBy",
                table: "Teams",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ModifiedBy",
                table: "Teams",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ProjectId",
                table: "Teams",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_Name",
                table: "UserRoles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_LoginProviderId",
                table: "Users",
                column: "LoginProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StatusId",
                table: "Users",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerStories");

            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "LoginProviders");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "StatusGroups");
        }
    }
}
