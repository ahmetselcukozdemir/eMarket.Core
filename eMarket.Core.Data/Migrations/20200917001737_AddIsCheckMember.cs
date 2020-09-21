using Microsoft.EntityFrameworkCore.Migrations;

namespace eMarket.Core.Data.Migrations
{
    public partial class AddIsCheckMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCheck",
                table: "Members",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCheck",
                table: "Members");
        }
    }
}
