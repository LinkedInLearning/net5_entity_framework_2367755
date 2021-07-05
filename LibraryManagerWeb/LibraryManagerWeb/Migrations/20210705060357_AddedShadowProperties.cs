﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagerWeb.Migrations
{
    public partial class AddedShadowProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "AuditEntries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResearchTicketId",
                table: "AuditEntries",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuditEntries_BookId",
                table: "AuditEntries",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditEntries_Books_BookId",
                table: "AuditEntries",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditEntries_Books_BookId",
                table: "AuditEntries");

            migrationBuilder.DropIndex(
                name: "IX_AuditEntries_BookId",
                table: "AuditEntries");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "AuditEntries");

            migrationBuilder.DropColumn(
                name: "ResearchTicketId",
                table: "AuditEntries");
        }
    }
}
