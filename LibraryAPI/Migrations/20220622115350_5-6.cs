using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryAPI.Migrations
{
    public partial class _56 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Name", "Price", "Type", "pageSize" },
                values: new object[] { 6, "Aldous Huxley", "Cesur Yeni Dunya", 60, "Felsefe", 490 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
