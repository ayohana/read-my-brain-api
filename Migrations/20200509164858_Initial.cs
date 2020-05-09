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
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    { 27, "alert and oriented x 3", "A&Ox3" },
                    { 26, "alert and oriented x 2", "A&Ox2" },
                    { 25, "alert and oriented x 1", "A&Ox1" },
                    { 24, "alert and oriented", "A&O" },
                    { 23, "Emergency Department", "ED" },
                    { 22, "chest x-ray", "CXR" },
                    { 21, "left total knee arthroplasty", "LTKA" },
                    { 20, "right total knee arthroplasty", "RTKA" },
                    { 19, "diabetes mellitus", "DM" },
                    { 18, "hypertension", "HTN" },
                    { 17, "surgery", "sx" },
                    { 16, "Surgery", "Sx" },
                    { 28, "alert and oriented x 4", "A&Ox4" },
                    { 15, "Registered Nurse", "RN" },
                    { 13, "after", "p̄" },
                    { 12, "before", "ā" },
                    { 11, "with", "c̅" },
                    { 10, "Physical Therapist", "PT" },
                    { 9, "patient", "Pt" },
                    { 8, "patient", "pt" },
                    { 7, "immediately", "STAT" },
                    { 6, "Do Not Resuscitate", "DNR" },
                    { 5, "Allergy of", "Ax" },
                    { 4, "history of", "hx" },
                    { 3, "History of", "Hx" },
                    { 2, "Female", "F" },
                    { 14, "Medical Doctor", "MD" },
                    { 29, "penicillin", "pnc" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Terms");
        }
    }
}
