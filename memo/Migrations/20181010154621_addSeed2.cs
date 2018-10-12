using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace memo.Migrations
{
    public partial class addSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2000,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 5, 46, 21, 283, DateTimeKind.Local), "2eeff8de-6716-4c8a-81ae-8140a02957ab" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2001,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 6, 46, 21, 285, DateTimeKind.Local), "2eeff8de-6716-4c8a-81ae-8140a02957ab" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2002,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 7, 46, 21, 285, DateTimeKind.Local), "2eeff8de-6716-4c8a-81ae-8140a02957ab" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2003,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 8, 46, 21, 285, DateTimeKind.Local), "2eeff8de-6716-4c8a-81ae-8140a02957ab" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2004,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 9, 46, 21, 285, DateTimeKind.Local), "2eeff8de-6716-4c8a-81ae-8140a02957ab" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2005,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 10, 46, 21, 285, DateTimeKind.Local), "2eeff8de-6716-4c8a-81ae-8140a02957ab" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2006,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 11, 46, 21, 285, DateTimeKind.Local), "2eeff8de-6716-4c8a-81ae-8140a02957ab" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2007,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 12, 46, 21, 285, DateTimeKind.Local), "2eeff8de-6716-4c8a-81ae-8140a02957ab" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2008,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 13, 46, 21, 285, DateTimeKind.Local), "2eeff8de-6716-4c8a-81ae-8140a02957ab" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2009,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 14, 46, 21, 285, DateTimeKind.Local), "2eeff8de-6716-4c8a-81ae-8140a02957ab" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2000,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 5, 42, 53, 136, DateTimeKind.Local), "5f185fd1-bf19-4f1a-a13b-e9c908714d96" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2001,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 6, 42, 53, 138, DateTimeKind.Local), "5f185fd1-bf19-4f1a-a13b-e9c908714d96" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2002,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 7, 42, 53, 138, DateTimeKind.Local), "5f185fd1-bf19-4f1a-a13b-e9c908714d96" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2003,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 8, 42, 53, 138, DateTimeKind.Local), "5f185fd1-bf19-4f1a-a13b-e9c908714d96" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2004,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 9, 42, 53, 138, DateTimeKind.Local), "5f185fd1-bf19-4f1a-a13b-e9c908714d96" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2005,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 10, 42, 53, 138, DateTimeKind.Local), "5f185fd1-bf19-4f1a-a13b-e9c908714d96" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2006,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 11, 42, 53, 138, DateTimeKind.Local), "5f185fd1-bf19-4f1a-a13b-e9c908714d96" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2007,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 12, 42, 53, 138, DateTimeKind.Local), "5f185fd1-bf19-4f1a-a13b-e9c908714d96" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2008,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 13, 42, 53, 138, DateTimeKind.Local), "5f185fd1-bf19-4f1a-a13b-e9c908714d96" });

            migrationBuilder.UpdateData(
                table: "Memo",
                keyColumn: "memoId",
                keyValue: 2009,
                columns: new[] { "Date", "OwnerId" },
                values: new object[] { new DateTime(2018, 10, 11, 14, 42, 53, 138, DateTimeKind.Local), "5f185fd1-bf19-4f1a-a13b-e9c908714d96" });
        }
    }
}
