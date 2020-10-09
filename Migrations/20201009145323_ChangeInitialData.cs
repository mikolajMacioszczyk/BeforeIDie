using Microsoft.EntityFrameworkCore.Migrations;

namespace BeforeIDie.Migrations
{
    public partial class ChangeInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GoalItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "przełom rzeki Kolorado w stanie Arizona w USA przez Płaskowyż Kolorado. Za początek kanionu uznaje się Lee's Ferry (niewielka stacja z motelem i przystanią dla łodzi leżąca około 12 km od miejscowości Page), natomiast koniec kanionu leży w rejonie Grand Wash Cliff leżącym około 20 km od początku jeziora Mead[1]. Odległość pomiędzy tymi punktami mierzona nurtem rzeki Kolorado wynosi 446 km[1]. Najgłębszym rejonem Wielkiego Kanionu jest Granite Gorge (Wąwóz Granitowy)[2], w którym najgłębsze miejsce leży poniżej krawędzi o 1857 m (6093 stóp)[3]. Szerokość kanionu waha się od ok. 800 m (pod punktem widokowym Toroweap na North Rim – Północnej Krawędzi) do 29 km w najszerszym miejscu. Jest to największy przełom rzeki na świecie (jednak nie najgłębszy).");

            migrationBuilder.UpdateData(
                table: "GoalItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Na Ziemi zorze występują na wysokich szerokościach geograficznych, głównie za kołami podbiegunowymi, chociaż w sprzyjających warunkach bywają widoczne nawet w okolicach 50. równoleżnika. Zdarza się, że zorze polarne obserwowane są nawet w krajach śródziemnomorskich. Na półkuli północnej zorza jest określana łacińską nazwą Aurora borealis, a południowa zorza polarna nosi nazwę Aurora australis.");

            migrationBuilder.UpdateData(
                table: "GoalItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Amfiteatr Flawiuszów jest najbardziej znanym symbolem Wiecznego Miasta i zarazem jedną z najwspanialszych budowli antycznych, które dotrwały do naszych czasów. Jest on doskonałym świadectwem wielkiego poziomu architektury i budownictwa Imperium Rzymskiego.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GoalItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Wielki Kanion Kolorado");

            migrationBuilder.UpdateData(
                table: "GoalItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Zorza Polarna");

            migrationBuilder.UpdateData(
                table: "GoalItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Koloseum");
        }
    }
}
