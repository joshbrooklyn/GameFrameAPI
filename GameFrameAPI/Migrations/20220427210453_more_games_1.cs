using Microsoft.EntityFrameworkCore.Migrations;

namespace GameFrameAPI.Migrations
{
    public partial class more_games_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CopiesSold",
                table: "Games",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "CopiesSold", "GameName", "PlatformId", "Year" },
                values: new object[,]
                {
                    { 21001, 6000000, "Sonic 2", 21, 21001 },
                    { 17024, null, "Top Gun", 17, 17024 },
                    { 17026, null, "Contra", 17, 17026 },
                    { 21002, null, "Aladdin", 21, 21002 },
                    { 17025, null, "Bad Dudes", 17, 17025 },
                    { 17013, null, "Duck Tales", 17, 17013 },
                    { 17012, null, "Mega Man 2", 17, 17012 },
                    { 23004, null, "F-Zero", 23, 23004 },
                    { 17009, null, "RC Pro Am", 17, 17009 },
                    { 17007, null, "Dragon Warrior 3", 17, 17007 },
                    { 23003, null, "Chrono Trigger", 23, 23003 },
                    { 17006, 8000000, "Tetris", 17, 17006 },
                    { 23001, 4610000, "Legend of Zelda - Link to the Past", 23, 23001 },
                    { 17005, 1570000, "Excitebike", 17, 17005 },
                    { 17004, 2730000, "Metroid", 17, 17004 },
                    { 17008, null, "Legend of Zelda", 17, 17008 },
                    { 17027, null, "TMNT 2", 17, 17027 }
                });

            migrationBuilder.InsertData(
                table: "Screenshots",
                columns: new[] { "ScreenshotId", "GameId", "ImageURL", "SequenceNo" },
                values: new object[,]
                {
                    { 19, 21001, "https://drive.google.com/thumbnail?id=1nf7NOmlSejuavIwQ19fLG_ebxLtpVcKF", 1 },
                    { 92, 21002, "https://drive.google.com/thumbnail?id=1IoEE2EZkGgMky6LAFXsMxAppD2qLAOQE", 2 },
                    { 91, 21002, "https://drive.google.com/thumbnail?id=15CR3b7JjoSYvtQTLioGWMTk2L4ByMduO", 1 },
                    { 90, 17025, "https://drive.google.com/thumbnail?id=1yz3nuNb5diV5XVD2dQsRqm21_5llyGPi", 6 },
                    { 89, 17025, "https://drive.google.com/thumbnail?id=1zNkThOahcYeBR7e4cf-xEdKKm5DdhUik", 5 },
                    { 88, 17025, "https://drive.google.com/thumbnail?id=1GfI9uiz8fJWl_1fW_LmcaNViHndy7cM5", 4 },
                    { 87, 17025, "https://drive.google.com/thumbnail?id=1MoyJE0_DAVTM-xZD3XjOOUf8h0nXslgZ", 3 },
                    { 86, 17025, "https://drive.google.com/thumbnail?id=1MEPlWUIijRFbkhSrYKlydBueQlzo40uz", 2 },
                    { 85, 17025, "https://drive.google.com/thumbnail?id=1ZuDzVxN6yCxa7LDJ5nnoHrCxXFxNbwN8", 1 },
                    { 84, 17013, "https://drive.google.com/thumbnail?id=1coFqbhj3s5os8P6TqOelEbwPfGR67h0a", 6 },
                    { 83, 17013, "https://drive.google.com/thumbnail?id=16YZlsxdEWtwQk3FHqUK1OZVqD7lak7W3", 5 },
                    { 82, 17013, "https://drive.google.com/thumbnail?id=1nyKQIk5V65RpPrgYfGStJL2Y1YVLrKCO", 4 },
                    { 81, 17013, "https://drive.google.com/thumbnail?id=1udeM8a3STyYgycw85VHxvw3hl9h8XZIn", 3 },
                    { 80, 17013, "https://drive.google.com/thumbnail?id=1b5HMf-WD7DIUkXC3faznVpygAAB_bwq-", 2 },
                    { 79, 17013, "https://drive.google.com/thumbnail?id=1FVlX8A3zYNmkGXCDPuTo4prR5P8OBsnD", 1 },
                    { 78, 17012, "https://drive.google.com/thumbnail?id=1-vcfebKCY9eX0k4ratAiaQB88diz7twM", 6 },
                    { 77, 17012, "https://drive.google.com/thumbnail?id=1Mo50nLom5ya1GSGocX6aXuzen_ABRDuC", 5 },
                    { 76, 17012, "https://drive.google.com/thumbnail?id=1frBQgJvpCNq-0V61Ch9nU1ctv9z2wEAe", 4 },
                    { 75, 17012, "https://drive.google.com/thumbnail?id=1ciBVNbW5cPsfw8ef_NQg8E6PzaZl7w81", 3 },
                    { 74, 17012, "https://drive.google.com/thumbnail?id=1s1GM3pov97zyf7YALfz009OXTEoa8UDw", 2 },
                    { 73, 17012, "https://drive.google.com/thumbnail?id=1mSXLvmihh7cFkgLwtuufIaFlrod9Q3FN", 1 },
                    { 72, 17009, "https://drive.google.com/thumbnail?id=1bzZysKu8mzxZA9vOplhzMqL6XGAgDn5v", 6 },
                    { 93, 21002, "https://drive.google.com/thumbnail?id=1ZCWsE1F22whXq9WkZGxgIeZRNl-z5Jiq", 3 },
                    { 94, 21002, "https://drive.google.com/thumbnail?id=1uRY1up4wT_LLIJvSR7ZI2ymeF0x2bWxZ", 4 },
                    { 95, 21002, "https://drive.google.com/thumbnail?id=1vY7Gb2eH_chA3v2NUoHQO3iESXhprVxh", 5 },
                    { 96, 21002, "https://drive.google.com/thumbnail?id=1MC7LmVBfMseai5Jnu7qqK0QTHLPwXFc7", 6 },
                    { 118, 17027, "https://drive.google.com/thumbnail?id=1t9kj3WG2b3wcXoCEM3fWk2EMBvIigdd3", 4 },
                    { 117, 17027, "https://drive.google.com/thumbnail?id=1CRMvfsxqr0T5qr_ebXtm6s9_xHlM3rDv", 3 },
                    { 116, 17027, "https://drive.google.com/thumbnail?id=1jE9gs95qj8Ho-76qNUofNfHLRMxbejn4", 2 },
                    { 115, 17027, "https://drive.google.com/thumbnail?id=1d2o3gq9S0o6P92e6aB52FYbjsqDHBS1O", 1 },
                    { 114, 23004, "https://drive.google.com/thumbnail?id=1_EfAugpNxEWHOnOborszcF_QzVX9RkfY", 6 },
                    { 113, 23004, "https://drive.google.com/thumbnail?id=1iH605Si81b5Ogl8K3nc8SySPs_fLNUfo", 5 },
                    { 112, 23004, "https://drive.google.com/thumbnail?id=1rHh0JvdxJpspb6mKpOFaRZ-at_CuUdxF", 4 },
                    { 111, 23004, "https://drive.google.com/thumbnail?id=1SeH29uVbh8g-gRjM-8X3qU169Khed2Vz", 3 },
                    { 110, 23004, "https://drive.google.com/thumbnail?id=18Se-19YtJgSaPCdeSKRbhr_ONvIIVxm5", 2 },
                    { 109, 23004, "https://drive.google.com/thumbnail?id=1fFRpg-1PFCFmcBpkRW-RH16xPWTDp_5X", 1 },
                    { 71, 17009, "https://drive.google.com/thumbnail?id=1LNhTLNwEmw3203iI-OLDCLb-ixdW-zlO", 5 },
                    { 108, 17024, "https://drive.google.com/thumbnail?id=1gX83P8OsOUyMZ2tFPGDDLxyNvWQziu40", 6 },
                    { 106, 17024, "https://drive.google.com/thumbnail?id=1WVxRBh4pxRjxhmsNuaPlLXK6uLiVjqpA", 4 },
                    { 105, 17024, "https://drive.google.com/thumbnail?id=12M05v3Ct1BTA8XZMKwYBFB0O5BcS6pby", 3 },
                    { 104, 17024, "https://drive.google.com/thumbnail?id=1vPC83EBH8FT8tOA7JWZKBfJfpdarW89g", 2 },
                    { 103, 17024, "https://drive.google.com/thumbnail?id=1Ixx0Q4cNysS1zmNfFaAeX7_EE4PURGdY", 1 },
                    { 102, 17026, "https://drive.google.com/thumbnail?id=1-WmHhwyn30dk8-z2YagfjoBrl69ZuQpW", 6 },
                    { 101, 17026, "https://drive.google.com/thumbnail?id=120GRImiHoHn7vNgi4RbecCQ9TH-07AwY", 5 },
                    { 100, 17026, "https://drive.google.com/thumbnail?id=17z0B4lHJ_9bT5FC3ShnNEC40z_MJmw3l", 4 },
                    { 99, 17026, "https://drive.google.com/thumbnail?id=1S9Jjb9p-DsoiuwQrrlL2-pii4ATYnHI3", 3 },
                    { 98, 17026, "https://drive.google.com/thumbnail?id=1HO8m6uqC7C6aGDqUOf8QIOwJVEdGYpdj", 2 },
                    { 97, 17026, "https://drive.google.com/thumbnail?id=1GPETDYzN--iZDl4iPdw3AO-tHT57NKbc", 1 },
                    { 107, 17024, "https://drive.google.com/thumbnail?id=1Ah64N6hfwLcxlrcubopxb9tYcJvYoQgk", 5 },
                    { 70, 17009, "https://drive.google.com/thumbnail?id=16r7b88M55g0kCGEIjZVkOCEMUG0J9GgM", 4 },
                    { 69, 17009, "https://drive.google.com/thumbnail?id=1iSnNn1Ev9fSr90TpuO953do6AXP-8WIi", 3 },
                    { 68, 17009, "https://drive.google.com/thumbnail?id=1PQrc3T6fkfA7OaLQ_7yoayg-yoYIBKRA", 2 },
                    { 41, 23001, "https://drive.google.com/thumbnail?id=174ChzOfNY7HMnbJqz0GU_XVww9mo5Dnr", 5 },
                    { 40, 23001, "https://drive.google.com/thumbnail?id=19DWIbOrtIBwXmJ9f4oK53YI98j0iiLO1", 4 },
                    { 39, 23001, "https://drive.google.com/thumbnail?id=1N8MHXPHxfVAKOSS1rqEvD9ohahUHL6aF", 3 },
                    { 38, 23001, "https://drive.google.com/thumbnail?id=1No9SvpnBJswgYit9F35NnI6Gm0RtM6rR", 2 },
                    { 37, 23001, "https://drive.google.com/thumbnail?id=1GEtNogEzH8hU2YrLJegbiGSBd8hK8uqO", 1 },
                    { 36, 17005, "https://drive.google.com/thumbnail?id=1ra7bO94jnCrrHsFP8FppEeQWUekPncc7", 6 },
                    { 35, 17005, "https://drive.google.com/thumbnail?id=15F5m47vg-x6945E70GXIfB6pxUg_c7fW", 5 },
                    { 34, 17005, "https://drive.google.com/thumbnail?id=1wkXgS0gOECrUxxXKVahEn5ZxHIrk-WlT", 4 },
                    { 33, 17005, "https://drive.google.com/thumbnail?id=1FfSsJuyD9VfIT0B-CloA5kgf1nG-tVcv", 3 },
                    { 32, 17005, "https://drive.google.com/thumbnail?id=1153NWxy8MPDbfW4oPdKObVza11JCsp4d", 2 },
                    { 42, 23001, "https://drive.google.com/thumbnail?id=1q88TCI0nb9aiW_je0d5SEaXGSC0Udbxs", 6 },
                    { 31, 17005, "https://drive.google.com/thumbnail?id=1B7T_GvOxmSt3P0ygcIPTAawCcddOjfDM", 1 },
                    { 29, 17004, "https://drive.google.com/thumbnail?id=1_XBR6xRR7bMUHQUGCsOm-MXjSQOQX5qb", 5 },
                    { 28, 17004, "https://drive.google.com/thumbnail?id=1ekPT6hts0XleUxQapCM7XFgMuFP4uo02", 4 },
                    { 27, 17004, "https://drive.google.com/thumbnail?id=11zw_UotjOIDrVdn0rSW9ZNHUsgP7Ws-H", 3 },
                    { 26, 17004, "https://drive.google.com/thumbnail?id=1t0vDMtE2IHwdaQfO12FsoX2nrgWBZ7mu", 2 },
                    { 25, 17004, "https://drive.google.com/thumbnail?id=1a3auKkdGovUSdg9WhkMXa5ip8ztA8jfZ", 1 },
                    { 24, 21001, "https://drive.google.com/thumbnail?id=18YWNKL02BHXXRIh90WcZd6s6izZ_WnUy", 6 },
                    { 23, 21001, "https://drive.google.com/thumbnail?id=1jm10NfvMG7B_aPjvAswR9LmRSXzlpr6T", 5 },
                    { 22, 21001, "https://drive.google.com/thumbnail?id=1P7ykfTpOI5OueiEZms-dInN54arkxfwa", 4 },
                    { 21, 21001, "https://drive.google.com/thumbnail?id=184zYWXEWTrDACgKq1wDNoXR_tbrabvfb", 3 },
                    { 20, 21001, "https://drive.google.com/thumbnail?id=1gNC99vzAIXb2NC8iLNBA2gMAgGeIoqGo", 2 },
                    { 30, 17004, "https://drive.google.com/thumbnail?id=1E7zud3uWtAx9PG9daFe8HkwIdHzpm-1_", 6 },
                    { 119, 17027, "https://drive.google.com/thumbnail?id=1Erh2ltJf4V63xZvOze3oWZ3GCdz5RWbN", 5 },
                    { 43, 17006, "https://drive.google.com/thumbnail?id=1Ab-oGcvTGB5iTaE-lmqlSxSnTvfG6icW", 1 },
                    { 45, 17006, "https://drive.google.com/thumbnail?id=1DA8sZcAsjV7uUqoCR31bNXxl3uThanHU", 3 },
                    { 67, 17009, "https://drive.google.com/thumbnail?id=1zPE-6WK4i2WT_RFPdM5oM0XzBPrxuJrB", 1 },
                    { 66, 17008, "https://drive.google.com/thumbnail?id=1tpyAOvmvgA1Y849oDrpwhTk-FwiqmcnS", 6 },
                    { 65, 17008, "https://drive.google.com/thumbnail?id=1G4c9_bLrVvplN7fzDraJCOXhzXDzIzD6", 5 },
                    { 64, 17008, "https://drive.google.com/thumbnail?id=1iQYp9ffhw7qax1vFAVVG9jK5dzfX_6gJ", 4 },
                    { 63, 17008, "https://drive.google.com/thumbnail?id=12mGgAFfpeiDEHn9WWQHzjDHQ47ifrliD", 3 },
                    { 62, 17008, "https://drive.google.com/thumbnail?id=1y0VKlse2q3cRp0h0OzV_IIz_dLnz0oad", 2 },
                    { 61, 17008, "https://drive.google.com/thumbnail?id=1lHs8IIV2DHUglF-S6p0FPJSOl8zQl_1J", 1 },
                    { 60, 17007, "https://drive.google.com/thumbnail?id=1B5XDhq6i1t_XYlwRi3Zxdy6TQxhA_vZd", 6 },
                    { 59, 17007, "https://drive.google.com/thumbnail?id=1e64bYUgzIMTGR74qCVlSTXWhOSmZZElr", 5 },
                    { 58, 17007, "https://drive.google.com/thumbnail?id=1_H0NoE0DDpzwZQHnjqfDhACgFHxDrwYC", 4 },
                    { 44, 17006, "https://drive.google.com/thumbnail?id=1kafqyKB52SvwJgQ5vzDnvpJ5H4l7glrC", 2 },
                    { 57, 17007, "https://drive.google.com/thumbnail?id=1oek_1jooE1oVliJE3vaTeVK1V4pEXlCL", 3 },
                    { 55, 17007, "https://drive.google.com/thumbnail?id=1MzWwRoH8lpsVjwI8HeSgbyuN02wt_IR_", 1 },
                    { 54, 23003, "https://drive.google.com/thumbnail?id=1QAdA43V_AHN_Gh7nyR4rgXKEvtLM2EkS", 6 },
                    { 53, 23003, "https://drive.google.com/thumbnail?id=1H0gpPAC5vcU6HBB785rdGEWpZ-84erqj", 5 },
                    { 52, 23003, "https://drive.google.com/thumbnail?id=1iykD4B7tzJ9FMFScJsHmsvW9wI5Radq_", 4 },
                    { 51, 23003, "https://drive.google.com/thumbnail?id=1ct2zd02oMlSGV05s2iWq6ad7TKsgHwdt", 3 },
                    { 50, 23003, "https://drive.google.com/thumbnail?id=1ZJV1OA1mWR-uMD7Lk87pBC4HuHLHO3IR", 2 },
                    { 49, 23003, "https://drive.google.com/thumbnail?id=1neUcrBd5SFB0HfsnhPvJAGlNFYcWv3gd", 1 },
                    { 48, 17006, "https://drive.google.com/thumbnail?id=1x2556ctthuHYoDbvbSrv0xXzYGMW1SEn", 6 },
                    { 47, 17006, "https://drive.google.com/thumbnail?id=1R3meyuq6rsKXLA__PbpHbHt8lWLZ8Zpd", 5 },
                    { 46, 17006, "https://drive.google.com/thumbnail?id=1ST9XL0AiwZt6cGFVV07L0tuZhw9T1S7H", 4 },
                    { 56, 17007, "https://drive.google.com/thumbnail?id=1v-2JaqdxtkOXl_ZydVWI1uzs7iwLcdT0", 2 },
                    { 120, 17027, "https://drive.google.com/thumbnail?id=1cRD1M90DiATJVmZT5rwltNF7M0F9Q-3I", 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Screenshots",
                keyColumn: "ScreenshotId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17004);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17005);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17006);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17007);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17008);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17009);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17012);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17013);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17024);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17025);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17026);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17027);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 21001);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 21002);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 23001);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 23003);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 23004);

            migrationBuilder.AlterColumn<int>(
                name: "CopiesSold",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
