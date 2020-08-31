using Microsoft.EntityFrameworkCore.Migrations;

namespace eMarket.Data.Migrations
{
    public partial class _30Agustos2020Updt1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "Messages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_MemberID",
                table: "Messages",
                column: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Members_MemberID",
                table: "Messages",
                column: "MemberID",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Members_MemberID",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_MemberID",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "Messages");
        }
    }
}
