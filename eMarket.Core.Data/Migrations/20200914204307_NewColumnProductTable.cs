using Microsoft.EntityFrameworkCore.Migrations;

namespace eMarket.Core.Data.Migrations
{
    public partial class NewColumnProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHome",
                table: "ProductImages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ApplicationForms",
                columns: table => new
                {
                    ApplicationFormId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: true),
                    InstagramAddress = table.Column<string>(nullable: true),
                    FacebookAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationForms", x => x.ApplicationFormId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "IsHome",
                table: "ProductImages");
        }
    }
}
