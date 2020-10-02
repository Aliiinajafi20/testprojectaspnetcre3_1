﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace testprojectaspnetcre3_1.Data.Migrations
{
    public partial class Creat_Kala_OrderApp_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kalas",
                columns: table => new
                {
                    KalaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KalaName = table.Column<string>(nullable: false),
                    KalaPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kalas", x => x.KalaId);
                });

            migrationBuilder.CreateTable(
                name: "OrderApps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(nullable: true),
                    KalaId = table.Column<int>(nullable: false),
                    Tadad = table.Column<int>(nullable: false),
                    KalaPrice = table.Column<int>(nullable: false),
                    KalaAll = table.Column<int>(nullable: false),
                    DataSabt = table.Column<string>(nullable: true),
                    DataTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderApps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderApps_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderApps_Kalas_KalaId",
                        column: x => x.KalaId,
                        principalTable: "Kalas",
                        principalColumn: "KalaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderApps_CustomerId",
                table: "OrderApps",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderApps_KalaId",
                table: "OrderApps",
                column: "KalaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderApps");

            migrationBuilder.DropTable(
                name: "Kalas");
        }
    }
}
