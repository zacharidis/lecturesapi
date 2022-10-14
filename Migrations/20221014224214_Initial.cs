using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lecturesapi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isOpenSource = table.Column<bool>(type: "bit", nullable: false),
                    LearningCurve = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "areas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_areas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_areas_languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "frameworks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isOpenSource = table.Column<bool>(type: "bit", nullable: false),
                    Language = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AreaOfDevelopment = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    languageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    areaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_frameworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_frameworks_areas_areaId",
                        column: x => x.areaId,
                        principalTable: "areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_frameworks_languages_languageId",
                        column: x => x.languageId,
                        principalTable: "languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_areas_LanguageId",
                table: "areas",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_frameworks_areaId",
                table: "frameworks",
                column: "areaId");

            migrationBuilder.CreateIndex(
                name: "IX_frameworks_languageId",
                table: "frameworks",
                column: "languageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "frameworks");

            migrationBuilder.DropTable(
                name: "areas");

            migrationBuilder.DropTable(
                name: "languages");
        }
    }
}
