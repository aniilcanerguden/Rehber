using Microsoft.EntityFrameworkCore.Migrations;

namespace Rehber.API.Migrations
{
    public partial class mg2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rehberrs_Users_UserIdID",
                table: "Rehberrs");

            migrationBuilder.DropIndex(
                name: "IX_Rehberrs_UserIdID",
                table: "Rehberrs");

            migrationBuilder.DropColumn(
                name: "UserIdID",
                table: "Rehberrs");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Rehberrs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rehberrs_UserID",
                table: "Rehberrs",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rehberrs_Users_UserID",
                table: "Rehberrs",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rehberrs_Users_UserID",
                table: "Rehberrs");

            migrationBuilder.DropIndex(
                name: "IX_Rehberrs_UserID",
                table: "Rehberrs");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Rehberrs");

            migrationBuilder.AddColumn<int>(
                name: "UserIdID",
                table: "Rehberrs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rehberrs_UserIdID",
                table: "Rehberrs",
                column: "UserIdID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rehberrs_Users_UserIdID",
                table: "Rehberrs",
                column: "UserIdID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
