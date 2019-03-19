using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aj_blog.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    IsRegistered = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 255, nullable: false),
                    Subtitle = table.Column<string>(maxLength: 255, nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "IsRegistered", "Name" },
                values: new object[] { 1, false, "Amir Jhanem" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Body", "CreationDate", "ImageUrl", "Subtitle", "Title" },
                values: new object[] { 1, 1, "<p class=\" style=\"box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\">Data seeding is the process of populating a database with an initial set of data.</p><p style=\"box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\">There are several ways this can be accomplished in EF Core:</p><ul style=\"margin: 16px 0px 16px 38px; padding: 0px; box-sizing: inherit; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\"><li style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Model seed data</li><li style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Manual migration customization</li><li class=\" style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Custom initialization logic</li></ul>", new DateTime(2019, 3, 19, 3, 27, 5, 993, DateTimeKind.Local).AddTicks(4309), "https://csharpdotchristiannageldotcom.files.wordpress.com/2018/08/farmerwithtractorseeding.jpg?w=672", "Model seed data", "Data Seeding" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Body", "CreationDate", "ImageUrl", "Subtitle", "Title" },
                values: new object[] { 2, 1, "<p class=\" style=\"box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\">Data seeding is the process of populating a database with an initial set of data.</p><p style=\"box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\">There are several ways this can be accomplished in EF Core:</p><ul style=\"margin: 16px 0px 16px 38px; padding: 0px; box-sizing: inherit; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\"><li style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Model seed data</li><li style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Manual migration customization</li><li class=\" style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Custom initialization logic</li></ul>", new DateTime(2019, 3, 19, 3, 27, 5, 994, DateTimeKind.Local).AddTicks(9796), "https://csharpdotchristiannageldotcom.files.wordpress.com/2018/08/farmerwithtractorseeding.jpg?w=672", "Model seed data", "Data Seeding 2" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Body", "CreationDate", "ImageUrl", "Subtitle", "Title" },
                values: new object[] { 3, 1, "<p class=\" style=\"box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\">Data seeding is the process of populating a database with an initial set of data.</p><p style=\"box-sizing: inherit; margin-top: 1rem; margin-bottom: 0px; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\">There are several ways this can be accomplished in EF Core:</p><ul style=\"margin: 16px 0px 16px 38px; padding: 0px; box-sizing: inherit; font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Segoe WP&quot;, &quot;Helvetica Neue&quot;, Helvetica, Tahoma, Arial, sans-serif; font-size: 16px;\"><li style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Model seed data</li><li style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Manual migration customization</li><li class=\" style=\"outline: 0px; box-sizing: inherit; list-style: disc outside none;\">Custom initialization logic</li></ul>", new DateTime(2019, 3, 19, 3, 27, 5, 994, DateTimeKind.Local).AddTicks(9816), "https://csharpdotchristiannageldotcom.files.wordpress.com/2018/08/farmerwithtractorseeding.jpg?w=672", "Model seed data", "Data Seeding 3" });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
