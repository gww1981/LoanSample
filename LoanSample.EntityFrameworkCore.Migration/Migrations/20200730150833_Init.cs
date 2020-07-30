using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanSample.EntityFrameworkCore.Migration.Migrations
{
    public partial class Init : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(maxLength: 40, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinkMan",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    IdNo = table.Column<string>(nullable: true),
                    CustomerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkMan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LinkMan_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LinkMan_CustomerId",
                table: "LinkMan",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinkMan");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
