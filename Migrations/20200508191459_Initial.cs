using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace read_my_brain_api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    TermID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 10, nullable: false),
                    Definition = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.TermID);
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "TermID", "Definition", "Name" },
                values: new object[,]
                {
                    { 1, "Male", "M" },
                    { 2, "Female", "F" },
                    { 3, "History of", "Hx" },
                    { 4, "history of", "hx" },
                    { 5, "Allergy of", "Ax" },
                    { 6, "Do Not Resuscitate", "DNR" },
                    { 7, "Do Not Resuscitate", "dnr" },
                    { 8, "patient", "pt" },
                    { 9, "patient", "Pt" },
                    { 10, "Physical Therapist", "PT" },
                    { 11, "with", "c̅" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Terms");
        }
    }
}
