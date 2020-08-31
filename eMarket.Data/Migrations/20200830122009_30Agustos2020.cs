using Microsoft.EntityFrameworkCore.Migrations;

namespace eMarket.Data.Migrations
{
    public partial class _30Agustos2020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageToID",
                table: "Messages",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageToID",
                table: "Messages");
        }
    }
}
