using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalCertificatesSite.Migrations
{
    public partial class Fix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("62c7a24d-75ab-4185-add6-9a7107d3745a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("76100ac2-e6a5-46af-a5d1-248b8dfee73a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("9870052a-8d52-4caa-a31a-13f8b327378a"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { new Guid("c85b5a7e-6bc6-4720-839e-1477aadbdd29"), "Иван Петрович" },
                    { new Guid("deab3e4f-5051-4ac4-9f80-8b6b1c73d547"), "Петр Иванович" },
                    { new Guid("b8e06318-c2f4-48b1-a97f-565bb9f66b1a"), "Григорий Григорьевич" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b8e06318-c2f4-48b1-a97f-565bb9f66b1a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("c85b5a7e-6bc6-4720-839e-1477aadbdd29"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("deab3e4f-5051-4ac4-9f80-8b6b1c73d547"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { new Guid("76100ac2-e6a5-46af-a5d1-248b8dfee73a"), "Иван Петрович" },
                    { new Guid("9870052a-8d52-4caa-a31a-13f8b327378a"), "Петр Иванович" },
                    { new Guid("62c7a24d-75ab-4185-add6-9a7107d3745a"), "Григорий Григорьевич" }
                });
        }
    }
}
