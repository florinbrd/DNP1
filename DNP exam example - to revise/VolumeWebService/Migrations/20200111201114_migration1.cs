using Microsoft.EntityFrameworkCore.Migrations;

namespace VolumeWebService.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "results",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    type = table.Column<string>(nullable: true),
                    Height = table.Column<double>(nullable: false),
                    Radius = table.Column<double>(nullable: false),
                    Volume = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_results", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "results");
        }
    }
}
