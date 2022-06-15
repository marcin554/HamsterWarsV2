using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hamsters",
                columns: table => new
                {
                    HamsterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HamsterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HamsterAge = table.Column<int>(type: "int", nullable: false),
                    FavFood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loves = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Losses = table.Column<int>(type: "int", nullable: false),
                    Games = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamsters", x => x.HamsterId);
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "HamsterId", "FavFood", "Games", "HamsterAge", "HamsterName", "ImgName", "Losses", "Loves", "Wins" },
                values: new object[,]
                {
                    { 1, "Seeds", 0, 2, "Pinokio", "hamster-1.jpg", 0, "Running", 0 },
                    { 2, "Carrot", 0, 2, "Chrome", "hamster-2.jpg", 0, "Jumping", 0 },
                    { 3, "Cucumber", 0, 1, "Firefox", "hamster-3.jpg", 0, "Eating", 0 },
                    { 4, "Tomato", 0, 3, "Safari", "hamster-4.jpg", 0, "Wheel", 0 },
                    { 5, "Seed sticks", 0, 2, "Opera", "hamster-5.jpg", 0, "Running Away", 0 },
                    { 6, "Honey", 0, 2, "Zebra", "hamster-6.jpg", 0, "Sleep", 0 },
                    { 7, "Dirt", 0, 2, "Rabbit", "hamster-7.jpg", 0, "Dreaming", 0 },
                    { 8, "Kefir", 0, 4, "Elephant", "hamster-8.jpg", 0, "Pats", 0 },
                    { 9, "Milk", 0, 3, "Fly", "hamster-9.jpg", 0, "Walking", 0 },
                    { 10, "Spaghetti", 0, 1, "Horse", "hamster-10.jpg", 0, "Laying", 0 },
                    { 11, "Seeds", 0, 2, "Pinokio", "hamster-11.jpg", 0, "Running", 0 },
                    { 12, "Carrot", 0, 2, "Chrome", "hamster-12.jpg", 0, "Jumping", 0 },
                    { 13, "Cucumber", 0, 1, "Firefox", "hamster-13.jpg", 0, "Eating", 0 },
                    { 14, "Tomato", 0, 3, "Safari", "hamster-14.jpg", 0, "Wheel", 0 },
                    { 15, "Seed sticks", 0, 2, "Opera", "hamster-15.jpg", 0, "Running Away", 0 },
                    { 16, "Honey", 0, 2, "Zebra", "hamster-16.jpg", 0, "Sleep", 0 },
                    { 17, "Dirt", 0, 2, "Rabbit", "hamster-17.jpg", 0, "Dreaming", 0 },
                    { 18, "Kefir", 0, 4, "Elephant", "hamster-18.jpg", 0, "Pats", 0 },
                    { 19, "Milk", 0, 3, "Fly", "hamster-19.jpg", 0, "Walking", 0 },
                    { 20, "Spaghetti", 0, 1, "Horse", "hamster-20.jpg", 0, "Laying", 0 },
                    { 21, "Seeds", 0, 2, "Pinokio", "hamster-21.jpg", 0, "Running", 0 },
                    { 22, "Carrot", 0, 2, "Chrome", "hamster-22.jpg", 0, "Jumping", 0 },
                    { 23, "Cucumber", 0, 1, "Firefox", "hamster-23.jpg", 0, "Eating", 0 },
                    { 24, "Tomato", 0, 3, "Safari", "hamster-24.jpg", 0, "Wheel", 0 },
                    { 25, "Seed sticks", 0, 2, "Opera", "hamster-25.jpg", 0, "Running Away", 0 },
                    { 26, "Honey", 0, 2, "Zebra", "hamster-26.jpg", 0, "Sleep", 0 },
                    { 27, "Dirt", 0, 2, "Rabbit", "hamster-27.jpg", 0, "Dreaming", 0 },
                    { 28, "Kefir", 0, 4, "Elephant", "hamster-28.jpg", 0, "Pats", 0 },
                    { 29, "Milk", 0, 3, "Fly", "hamster-29.jpg", 0, "Walking", 0 },
                    { 30, "Spaghetti", 0, 1, "Horse", "hamster-30.jpg", 0, "Laying", 0 },
                    { 31, "Seeds", 0, 2, "Pinokio", "hamster-31.jpg", 0, "Running", 0 },
                    { 32, "Carrot", 0, 2, "Chrome", "hamster-32.jpg", 0, "Jumping", 0 },
                    { 33, "Cucumber", 0, 1, "Firefox", "hamster-33.jpg", 0, "Eating", 0 },
                    { 34, "Tomato", 0, 3, "Safari", "hamster-34.jpg", 0, "Wheel", 0 },
                    { 35, "Seed sticks", 0, 2, "Opera", "hamster-35.jpg", 0, "Running Away", 0 },
                    { 36, "Honey", 0, 2, "Zebra", "hamster-36.jpg", 0, "Sleep", 0 },
                    { 37, "Dirt", 0, 2, "Rabbit", "hamster-37.jpg", 0, "Dreaming", 0 },
                    { 38, "Kefir", 0, 4, "Elephant", "hamster-38.jpg", 0, "Pats", 0 },
                    { 39, "Milk", 0, 3, "Fly", "hamster-39.jpg", 0, "Walking", 0 },
                    { 40, "Spaghetti", 0, 1, "Abaddo", "hamster-40.jpg", 0, "Laying", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hamsters");
        }
    }
}
