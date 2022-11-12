using Microsoft.EntityFrameworkCore.Migrations;

namespace DataGridView_Adm_Com.Migrations
{
    public partial class AddUselessProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UselessProperty",
                table: "AdmComDB",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UselessProperty",
                table: "AdmComDB");
        }
    }
}
