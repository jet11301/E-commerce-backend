using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Databasev1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StaffAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Profile_img = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slideshows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image_url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: true),
                    StaffAccountsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slideshows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slideshows_StaffAccounts_StaffAccountsId",
                        column: x => x.StaffAccountsId,
                        principalTable: "StaffAccounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Slideshows_StaffAccountsId",
                table: "Slideshows",
                column: "StaffAccountsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slideshows");

            migrationBuilder.DropTable(
                name: "StaffAccounts");
        }
    }
}
