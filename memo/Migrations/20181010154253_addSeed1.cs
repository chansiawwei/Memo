using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace memo.Migrations
{
    public partial class addSeed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Memo",
                columns: new[] { "memoId", "Date", "Details", "OwnerId", "Title" },
                values: new object[,]
                {
                    { 2000, new DateTime(2018, 10, 11, 5, 42, 53, 136, DateTimeKind.Local), "Details 0", "5f185fd1-bf19-4f1a-a13b-e9c908714d96", "Memo 0" },
                    { 2001, new DateTime(2018, 10, 11, 6, 42, 53, 138, DateTimeKind.Local), "Details 1", "5f185fd1-bf19-4f1a-a13b-e9c908714d96", "Memo 1" },
                    { 2002, new DateTime(2018, 10, 11, 7, 42, 53, 138, DateTimeKind.Local), "Details 2", "5f185fd1-bf19-4f1a-a13b-e9c908714d96", "Memo 2" },
                    { 2003, new DateTime(2018, 10, 11, 8, 42, 53, 138, DateTimeKind.Local), "Details 3", "5f185fd1-bf19-4f1a-a13b-e9c908714d96", "Memo 3" },
                    { 2004, new DateTime(2018, 10, 11, 9, 42, 53, 138, DateTimeKind.Local), "Details 4", "5f185fd1-bf19-4f1a-a13b-e9c908714d96", "Memo 4" },
                    { 2005, new DateTime(2018, 10, 11, 10, 42, 53, 138, DateTimeKind.Local), "Details 5", "5f185fd1-bf19-4f1a-a13b-e9c908714d96", "Memo 5" },
                    { 2006, new DateTime(2018, 10, 11, 11, 42, 53, 138, DateTimeKind.Local), "Details 6", "5f185fd1-bf19-4f1a-a13b-e9c908714d96", "Memo 6" },
                    { 2007, new DateTime(2018, 10, 11, 12, 42, 53, 138, DateTimeKind.Local), "Details 7", "5f185fd1-bf19-4f1a-a13b-e9c908714d96", "Memo 7" },
                    { 2008, new DateTime(2018, 10, 11, 13, 42, 53, 138, DateTimeKind.Local), "Details 8", "5f185fd1-bf19-4f1a-a13b-e9c908714d96", "Memo 8" },
                    { 2009, new DateTime(2018, 10, 11, 14, 42, 53, 138, DateTimeKind.Local), "Details 9", "5f185fd1-bf19-4f1a-a13b-e9c908714d96", "Memo 9" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2009);
        }
    }
}
