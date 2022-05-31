using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rehber.API.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GirisDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CikisDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilindiDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rehberrs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rehberİsim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyisim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdID = table.Column<int>(type: "int", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GirisDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CikisDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilindiDatetime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rehberrs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rehberrs_Users_UserIdID",
                        column: x => x.UserIdID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rehberrs_UserIdID",
                table: "Rehberrs",
                column: "UserIdID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rehberrs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
