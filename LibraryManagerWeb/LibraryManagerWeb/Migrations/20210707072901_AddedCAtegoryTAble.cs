using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagerWeb.Migrations
{
    public partial class AddedCAtegoryTAble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Category_Category_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Level", "Name", "ParentCategoryId" },
                values: new object[] { 1, 1, "Disciplinas", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Level", "Name", "ParentCategoryId" },
                values: new object[] { 6, 1, "Ensayos", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Level", "Name", "ParentCategoryId" },
                values: new object[] { 11, 1, "Literatura", null });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Level", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 2, 2, "Animales, hogar y plantas", 1 },
                    { 3, 2, "Antropología", 1 },
                    { 4, 2, "Arte", 1 },
                    { 5, 2, "Ciencias naturales y biología", 1 },
                    { 7, 2, "Autoayuda y desarrollo personal", 6 },
                    { 8, 2, "Ciencias", 6 },
                    { 9, 2, "Historia y ciencias sociales", 6 },
                    { 10, 2, "Filosofía y religión", 6 },
                    { 12, 2, "Biografías, viajes y testimonios", 11 },
                    { 13, 2, "Ciencia ficción y fantasía", 11 },
                    { 14, 2, "Cuentos y relatos", 11 },
                    { 15, 2, "Fábulas y leyendas", 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentCategoryId",
                table: "Category",
                column: "ParentCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
