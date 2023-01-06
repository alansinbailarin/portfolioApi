using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace portWebApi.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Posts_PostsId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Users_UserId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Posts_PostsId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Users_UserId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Users_UserId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Ocupations_Users_UserId",
                table: "Ocupations");

            migrationBuilder.DropForeignKey(
                name: "FK_Socials_Users_UserId",
                table: "Socials");

            migrationBuilder.DropForeignKey(
                name: "FK_SoftSkills_Users_UserId",
                table: "SoftSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_TechnicalSkills_Users_UserId",
                table: "TechnicalSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_Trajectories_Users_UserId",
                table: "Trajectories");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkHistories_Users_UserId",
                table: "WorkHistories");

            migrationBuilder.DropIndex(
                name: "IX_TechnicalSkills_UserId",
                table: "TechnicalSkills");

            migrationBuilder.DropIndex(
                name: "IX_SoftSkills_UserId",
                table: "SoftSkills");

            migrationBuilder.DropIndex(
                name: "IX_Socials_UserId",
                table: "Socials");

            migrationBuilder.DropIndex(
                name: "IX_Ocupations_UserId",
                table: "Ocupations");

            migrationBuilder.DropIndex(
                name: "IX_Languages_UserId",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Educations_UserId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LanguagesId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OcupationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PostsId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SocialId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SoftSkillsId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TechnicalSkillsId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TrajectoryId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WorkHistoryId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TechnicalSkills");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SoftSkills");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Socials");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Ocupations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Educations");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "WorkHistories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Trajectories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Locations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PostsId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PostsId",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "EducationUser",
                columns: table => new
                {
                    EducationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationUser", x => new { x.EducationId, x.UserId });
                    table.ForeignKey(
                        name: "FK_EducationUser_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguagesUser",
                columns: table => new
                {
                    LanguagesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguagesUser", x => new { x.LanguagesId, x.UserId });
                    table.ForeignKey(
                        name: "FK_LanguagesUser_Languages_LanguagesId",
                        column: x => x.LanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguagesUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OcupationUser",
                columns: table => new
                {
                    OcupationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcupationUser", x => new { x.OcupationId, x.UserId });
                    table.ForeignKey(
                        name: "FK_OcupationUser_Ocupations_OcupationId",
                        column: x => x.OcupationId,
                        principalTable: "Ocupations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OcupationUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialUser",
                columns: table => new
                {
                    SocialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialUser", x => new { x.SocialId, x.UserId });
                    table.ForeignKey(
                        name: "FK_SocialUser_Socials_SocialId",
                        column: x => x.SocialId,
                        principalTable: "Socials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SocialUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoftSkillsUser",
                columns: table => new
                {
                    SoftSkillsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftSkillsUser", x => new { x.SoftSkillsId, x.UserId });
                    table.ForeignKey(
                        name: "FK_SoftSkillsUser_SoftSkills_SoftSkillsId",
                        column: x => x.SoftSkillsId,
                        principalTable: "SoftSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoftSkillsUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalSkillsUser",
                columns: table => new
                {
                    TechnicalSkillsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalSkillsUser", x => new { x.TechnicalSkillsId, x.UserId });
                    table.ForeignKey(
                        name: "FK_TechnicalSkillsUser_TechnicalSkills_TechnicalSkillsId",
                        column: x => x.TechnicalSkillsId,
                        principalTable: "TechnicalSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TechnicalSkillsUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EducationUser_UserId",
                table: "EducationUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguagesUser_UserId",
                table: "LanguagesUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OcupationUser_UserId",
                table: "OcupationUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialUser_UserId",
                table: "SocialUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SoftSkillsUser_UserId",
                table: "SoftSkillsUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalSkillsUser_UserId",
                table: "TechnicalSkillsUser",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Posts_PostsId",
                table: "Categories",
                column: "PostsId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Posts_PostsId",
                table: "Images",
                column: "PostsId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Users_UserId",
                table: "Locations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trajectories_Users_UserId",
                table: "Trajectories",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkHistories_Users_UserId",
                table: "WorkHistories",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Posts_PostsId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Posts_PostsId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Users_UserId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Trajectories_Users_UserId",
                table: "Trajectories");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkHistories_Users_UserId",
                table: "WorkHistories");

            migrationBuilder.DropTable(
                name: "EducationUser");

            migrationBuilder.DropTable(
                name: "LanguagesUser");

            migrationBuilder.DropTable(
                name: "OcupationUser");

            migrationBuilder.DropTable(
                name: "SocialUser");

            migrationBuilder.DropTable(
                name: "SoftSkillsUser");

            migrationBuilder.DropTable(
                name: "TechnicalSkillsUser");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "WorkHistories",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "EducationId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LanguagesId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OcupationId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PostsId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SocialId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SoftSkillsId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TechnicalSkillsId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TrajectoryId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "WorkHistoryId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Trajectories",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "TechnicalSkills",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "SoftSkills",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Socials",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Posts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "Posts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Ocupations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Locations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Languages",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PostsId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Educations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PostsId",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalSkills_UserId",
                table: "TechnicalSkills",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SoftSkills_UserId",
                table: "SoftSkills",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Socials_UserId",
                table: "Socials",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocupations_UserId",
                table: "Ocupations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_UserId",
                table: "Languages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_UserId",
                table: "Educations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Posts_PostsId",
                table: "Categories",
                column: "PostsId",
                principalTable: "Posts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Users_UserId",
                table: "Educations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Posts_PostsId",
                table: "Images",
                column: "PostsId",
                principalTable: "Posts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Users_UserId",
                table: "Languages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Users_UserId",
                table: "Locations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocupations_Users_UserId",
                table: "Ocupations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Socials_Users_UserId",
                table: "Socials",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SoftSkills_Users_UserId",
                table: "SoftSkills",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TechnicalSkills_Users_UserId",
                table: "TechnicalSkills",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trajectories_Users_UserId",
                table: "Trajectories",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkHistories_Users_UserId",
                table: "WorkHistories",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
