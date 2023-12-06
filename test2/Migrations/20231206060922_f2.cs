using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test2.Migrations
{
    /// <inheritdoc />
    public partial class f2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee_Tbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rank = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Tbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department_Tbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number_of = table.Column<double>(type: "float", nullable: false),
                    Personals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_TblId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department_Tbl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_Tbl_Employee_Tbl_Employee_TblId",
                        column: x => x.Employee_TblId,
                        principalTable: "Employee_Tbl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Department_Tbl_Employee_TblId",
                table: "Department_Tbl",
                column: "Employee_TblId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Department_Tbl");

            migrationBuilder.DropTable(
                name: "Employee_Tbl");
        }
    }
}
