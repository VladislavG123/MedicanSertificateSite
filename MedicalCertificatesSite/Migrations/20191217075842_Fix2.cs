using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalCertificatesSite.Migrations
{
    public partial class Fix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1276ae60-d97e-4aa1-bec3-c64dc1822478"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("20cf31a8-837f-4392-be59-a0812db6e8ed"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("87fbe11d-8148-4961-be50-6bfdd89d81d5"));

            migrationBuilder.DropColumn(
                name: "PatientsPhoneNumber",
                table: "MedicanCertificates");

            migrationBuilder.AddColumn<string>(
                name: "PatientId",
                table: "MedicanCertificates",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { new Guid("76100ac2-e6a5-46af-a5d1-248b8dfee73a"), "Иван Петрович" },
                    { new Guid("9870052a-8d52-4caa-a31a-13f8b327378a"), "Петр Иванович" },
                    { new Guid("62c7a24d-75ab-4185-add6-9a7107d3745a"), "Григорий Григорьевич" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicanCertificates_PatientId",
                table: "MedicanCertificates",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicanCertificates_AspNetUsers_PatientId",
                table: "MedicanCertificates",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicanCertificates_AspNetUsers_PatientId",
                table: "MedicanCertificates");

            migrationBuilder.DropIndex(
                name: "IX_MedicanCertificates_PatientId",
                table: "MedicanCertificates");

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

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "MedicanCertificates");

            migrationBuilder.AddColumn<string>(
                name: "PatientsPhoneNumber",
                table: "MedicanCertificates",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { new Guid("1276ae60-d97e-4aa1-bec3-c64dc1822478"), "Иван Петрович" },
                    { new Guid("20cf31a8-837f-4392-be59-a0812db6e8ed"), "Петр Иванович" },
                    { new Guid("87fbe11d-8148-4961-be50-6bfdd89d81d5"), "Григорий Григорьевич" }
                });
        }
    }
}
