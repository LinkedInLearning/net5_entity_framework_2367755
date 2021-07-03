using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagerWeb.Migrations
{
    public partial class RenamedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditEntries_Country_CountryId",
                table: "AuditEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_BookFile_BookFormat_BookFormatId",
                table: "BookFile");

            migrationBuilder.DropForeignKey(
                name: "FK_BookFile_Books_BookId",
                table: "BookFile");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publisher_PublisherId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publisher",
                table: "Publisher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookFormat",
                table: "BookFormat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookFile",
                table: "BookFile");

            migrationBuilder.RenameTable(
                name: "Publisher",
                newName: "Publishers");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "BookFormat",
                newName: "BookFormats");

            migrationBuilder.RenameTable(
                name: "BookFile",
                newName: "BookFiles");

            migrationBuilder.RenameIndex(
                name: "IX_BookFile_BookId",
                table: "BookFiles",
                newName: "IX_BookFiles_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookFile_BookFormatId",
                table: "BookFiles",
                newName: "IX_BookFiles_BookFormatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers",
                column: "PublisherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookFormats",
                table: "BookFormats",
                column: "BookformatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookFiles",
                table: "BookFiles",
                column: "BookFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditEntries_Countries_CountryId",
                table: "AuditEntries",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookFiles_BookFormats_BookFormatId",
                table: "BookFiles",
                column: "BookFormatId",
                principalTable: "BookFormats",
                principalColumn: "BookformatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookFiles_Books_BookId",
                table: "BookFiles",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditEntries_Countries_CountryId",
                table: "AuditEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_BookFiles_BookFormats_BookFormatId",
                table: "BookFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_BookFiles_Books_BookId",
                table: "BookFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookFormats",
                table: "BookFormats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookFiles",
                table: "BookFiles");

            migrationBuilder.RenameTable(
                name: "Publishers",
                newName: "Publisher");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "BookFormats",
                newName: "BookFormat");

            migrationBuilder.RenameTable(
                name: "BookFiles",
                newName: "BookFile");

            migrationBuilder.RenameIndex(
                name: "IX_BookFiles_BookId",
                table: "BookFile",
                newName: "IX_BookFile_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookFiles_BookFormatId",
                table: "BookFile",
                newName: "IX_BookFile_BookFormatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publisher",
                table: "Publisher",
                column: "PublisherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookFormat",
                table: "BookFormat",
                column: "BookformatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookFile",
                table: "BookFile",
                column: "BookFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditEntries_Country_CountryId",
                table: "AuditEntries",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookFile_BookFormat_BookFormatId",
                table: "BookFile",
                column: "BookFormatId",
                principalTable: "BookFormat",
                principalColumn: "BookformatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookFile_Books_BookId",
                table: "BookFile",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publisher_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
