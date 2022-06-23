using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryAPI.Migrations
{
    public partial class newBookandFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Name", "Price", "Type", "pageSize" },
                values: new object[] { 7, "Hakan Günday", "Kinyas ve Kayra", 60, "Roman", 652 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
