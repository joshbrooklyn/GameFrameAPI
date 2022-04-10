using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace GameFrameAPI.Migrations
{
    public partial class initial_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    PlatformId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    PlatformAcronym = table.Column<string>(type: "text", nullable: false),
                    PlatformName = table.Column<string>(type: "text", nullable: false),
                    PlatformCompany = table.Column<string>(type: "text", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UnitsSold = table.Column<int>(type: "int", nullable: false),
                    ConsoleGeneration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.PlatformId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    GameName = table.Column<string>(type: "text", nullable: false),
                    PlatformId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CopiesSold = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "PlatformId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DailyGames",
                columns: table => new
                {
                    DailyGameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    GameDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyGames", x => x.DailyGameID);
                    table.ForeignKey(
                        name: "FK_DailyGames_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Screenshots",
                columns: table => new
                {
                    ScreenshotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SequenceNo = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "text", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenshots", x => x.ScreenshotId);
                    table.ForeignKey(
                        name: "FK_Screenshots_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "PlatformId", "ConsoleGeneration", "PlatformAcronym", "PlatformCompany", "PlatformName", "UnitsSold", "Year" },
                values: new object[,]
                {
                    { 10, 1, "Odyssey 1", "Magnavox", "Magnavox Odyssey", 350000, 1972 },
                    { 39, 8, "Xbox One", "Microsoft", "Xbox One", 51000000, 2013 },
                    { 38, 8, "PS4", "Sony", "Play Station 4", 116900000, 2013 },
                    { 37, 8, "Nintendo Switch", "Nintendo", "Nintendo Switch", 103540000, 2017 },
                    { 36, 8, "Wii U", "Nintendo", "Wii U", 13560000, 2012 },
                    { 35, 7, "Wii", "Nintendo", "Wii", 101630000, 2006 },
                    { 34, 7, "PS3", "Sony", "Play Station 3", 87400000, 2006 },
                    { 33, 7, "Xbox 360", "Microsoft", "Xbox 360", 84700000, 2005 },
                    { 32, 6, "Xbox", "Microsoft", "Xbox", 24000000, 2002 },
                    { 31, 6, "GameCube", "Nintendo", "GameCube", 21740000, 2001 },
                    { 30, 6, "PS2", "Sony", "Play Station 2", 155000000, 2000 },
                    { 29, 6, "Dreamcast", "Sega", "Sega Dreamcast", 9130000, 1998 },
                    { 28, 5, "N64", "Nintendo", "Nintendo 64", 329360000, 1996 },
                    { 27, 5, "PS1", "Sony", "Play Station", 102490000, 1994 },
                    { 26, 5, "Sega Saturn", "Sega", "Sega Saturn", 9260000, 1994 },
                    { 25, 5, "3D0", "3DO Company", "3DO", 2000000, 1993 },
                    { 24, 5, "Jaguar", "Atari", "Jaguar", 250000, 1993 },
                    { 23, 4, "SNES", "Nintendo", "Super Nintendo Entertainment System", 49100000, 1990 },
                    { 22, 4, "Neo Geo", "SNK Corporation", "Neo Geo", 980000, 1990 },
                    { 21, 4, "Genesis", "Sega", "Sega Genesis", 30750000, 1988 },
                    { 20, 4, "TurboGrafx-16", "NEC Home Electronics", "TurboGrafx-16", 5800000, 1987 },
                    { 19, 3, "Atari 7800", "Atari", "Atari 7800 Pro System", 3770000, 1986 },
                    { 18, 3, "Sega Master System", "Sega", "Sega Master System", 13000000, 1985 },
                    { 17, 3, "NES", "Nintendo", "Nintendo Entertainment System", 61910000, 1983 },
                    { 16, 2, "Atari 5200", "Atari", "Atari 5200 Supersystem", 1400000, 1982 },
                    { 15, 2, "Colecovision", "CBS Electronics", "Colecovision", 2000000, 1982 },
                    { 14, 2, "Intellivision", "Mattel", "Intellivision", 3000000, 1980 },
                    { 13, 2, "Odyssey 2", "Magnavox", "Magnavox Odyssey 2", 2000000, 1979 },
                    { 12, 2, "Atari 2600", "Atari", "Atari Video Computer System", 30000000, 1977 },
                    { 11, 1, "Pong", "Atari", "Home Pong", 200000, 1975 },
                    { 40, 9, "PS5", "Sony", "Play Station 5", 17300000, 2020 },
                    { 41, 9, "Xbox X-S", "Microsoft", "Xbox Series X and Series S", 12000000, 2020 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "CopiesSold", "GameName", "PlatformId", "Year" },
                values: new object[] { 17001, 18000000, "Super Mario Bros. 3", 17, 17001 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "CopiesSold", "GameName", "PlatformId", "Year" },
                values: new object[] { 17002, 3500000, "Kung Fu", 17, 17002 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "CopiesSold", "GameName", "PlatformId", "Year" },
                values: new object[] { 17003, 2000000, "Punch Out", 17, 17003 });

            migrationBuilder.InsertData(
                table: "Screenshots",
                columns: new[] { "ScreenshotId", "GameId", "ImageURL", "SequenceNo" },
                values: new object[,]
                {
                    { 1, 17001, "https://drive.google.com/file/d/1t9Fe-WybuXJCuXMKgSL-wU22ByckeUXs/view", 1 },
                    { 16, 17003, "https://drive.google.com/file/d/1CSqljvIoWkqp5DVi9eCGtfd5vrattFoL/view", 4 },
                    { 15, 17003, "https://drive.google.com/file/d/1JPzRM9Fn-VVa1pmTEl6QLwmCyvcJ1e5Q/view", 3 },
                    { 14, 17003, "https://drive.google.com/file/d/1-sDefBKVf0CP8XxtL2q_fwTwHdYnw0UL/view", 2 },
                    { 13, 17003, "https://drive.google.com/file/d/13UroXdqyu0ac0ZElXpxaO3ijIwioMKvs/view", 1 },
                    { 12, 17002, "https://drive.google.com/file/d/1Xx1LLL2JevBqogSv7VC-WJJjpSizmUpw/view", 6 },
                    { 11, 17002, "https://drive.google.com/file/d/1yN-wD3gUhM3L0UWGv5Pcm3Xg98xvrd4A/view", 5 },
                    { 10, 17002, "https://drive.google.com/file/d/1SmgWwN-CG0gcv2Pzz71MBuXPCPPwqZxN/view", 4 },
                    { 9, 17002, "https://drive.google.com/file/d/1LO88VtMtmLU0ukfAPgFAVWocU0K8yO_n/view", 3 },
                    { 8, 17002, "https://drive.google.com/file/d/1qnwyFLkJtn5jyEvzck3NebpdTXxONjiS/view", 2 },
                    { 7, 17002, "https://drive.google.com/file/d/1OxfT0N7v-V4gA3Mtq7x6MsoK6M_ZH3cQ/view", 1 },
                    { 6, 17001, "https://drive.google.com/file/d/11ld7S6JEVEmrF5XsxJISUu5T3tuRgW5h/view", 6 },
                    { 5, 17001, "https://drive.google.com/file/d/1A4xbZwOSPyehQX0NOvC3RIt-6mJAyMlC/view", 5 },
                    { 4, 17001, "https://drive.google.com/file/d/1OBQRFhFdQG_X89sJca3tqNIA955xQW4Z/view", 4 },
                    { 3, 17001, "https://drive.google.com/file/d/1_qdkOzG2Oq80V0iwIgpn09vkD4aU2fHr/view", 3 },
                    { 2, 17001, "https://drive.google.com/file/d/1Xqw6vvoDkeWrdcGo0R-45_BAz_jTh8Fy/view", 2 },
                    { 17, 17003, "https://drive.google.com/file/d/13sG4hr7Mln4A_j8opP987-j7NdEnsn2j/view", 5 },
                    { 18, 17003, "https://drive.google.com/file/d/162_hSiWlMuWu6aZ9sj3waiiiIQruzPx_/view", 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DailyGames_GameId",
                table: "DailyGames",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_PlatformId",
                table: "Games",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenshots_GameId",
                table: "Screenshots",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyGames");

            migrationBuilder.DropTable(
                name: "Screenshots");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Platforms");
        }
    }
}
