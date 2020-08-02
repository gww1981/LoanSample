using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanSample.EntityFrameworkCore.Migration.Migrations
{
    public partial class addTenancy : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "Customer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Customer");
        }
    }
}
