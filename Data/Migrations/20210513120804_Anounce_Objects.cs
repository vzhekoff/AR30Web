using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AR30Web.Data.Migrations
{
    public partial class Anounce_Objects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbAnnounce",
                columns: table => new
                {
                    cId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cAnnounceId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    cSource = table.Column<byte>(type: "tinyint", nullable: false),
                    cMailerType = table.Column<byte>(type: "tinyint", nullable: false),
                    cPhone1 = table.Column<int>(type: "int", nullable: true),
                    cPhone2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbAnnounces", x => x.cId);
                });

            migrationBuilder.CreateTable(
                name: "tbIssuer",
                columns: table => new
                {
                    cId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cMailerType = table.Column<byte>(type: "tinyint", nullable: false),
                    cPhone1 = table.Column<int>(type: "int", nullable: false),
                    cPhone2 = table.Column<int>(type: "int", nullable: false),
                    cPhone3 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbIssuer", x => x.cId);
                });

            migrationBuilder.CreateTable(
                name: "tbPhoneExt",
                columns: table => new
                {
                    cId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cType = table.Column<byte>(type: "tinyint", nullable: false),
                    cOwner = table.Column<int>(type: "int", nullable: false),
                    cPhone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPhoneExt", x => x.cId);
                });

            migrationBuilder.CreateTable(
                name: "tbPhoneNumber",
                columns: table => new
                {
                    cId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cPrefix = table.Column<short>(type: "smallint", nullable: false),
                    cNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPhoneNumber", x => x.cId);
                });

            migrationBuilder.CreateTable(
                name: "tbPrefix",
                columns: table => new
                {
                    cId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cPrefixL = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    cPrefixS = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPrefixes", x => x.cId);
                });

            migrationBuilder.CreateTable(
                name: "tbSession",
                columns: table => new
                {
                    cId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cDT = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    cB = table.Column<int>(type: "int", nullable: true),
                    cE = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbSession", x => x.cId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbAnnounce");

            migrationBuilder.DropTable(
                name: "tbIssuer");

            migrationBuilder.DropTable(
                name: "tbPhoneExt");

            migrationBuilder.DropTable(
                name: "tbPhoneNumber");

            migrationBuilder.DropTable(
                name: "tbPrefix");

            migrationBuilder.DropTable(
                name: "tbSession");
        }
    }
}
