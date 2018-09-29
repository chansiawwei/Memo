using Microsoft.EntityFrameworkCore.Migrations;

namespace memo.Data.Migrations
{
    public partial class memoownerchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Memo",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Memo",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
