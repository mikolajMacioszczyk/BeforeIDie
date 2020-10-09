using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BeforeIDie.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoalItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Localization = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ImgUrl = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoalItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GoalItems",
                columns: new[] { "Id", "Description", "ImgUrl", "Localization", "Title" },
                values: new object[,]
                {
                    { 1, "Wielki Kanion Kolorado", "https://goryiludzie.pl/sites/default/files/atoms/image/2016/12/15/1280px-grand_canyon_march_2013.jpg", "Arizona USA", "Wielki Kanion Kolorado" },
                    { 2, "Zorza Polarna", "https://cdn.pixabay.com/photo/2018/10/14/20/17/aurora-3747376_1280.jpg", "Biegun Północny", "Zorza Polarna" },
                    { 3, "Koloseum", "https://upload.wikimedia.org/wikipedia/commons/d/d8/Colosseum_in_Rome-April_2007-1-_copie_2B.jpg", "Rzym, Włochy", "Koloseum" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoalItems");
        }
    }
}
