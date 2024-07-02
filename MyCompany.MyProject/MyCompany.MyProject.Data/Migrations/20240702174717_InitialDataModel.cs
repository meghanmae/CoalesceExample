using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCompany.MyProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Widgets");

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "TriviaTags",
                columns: table => new
                {
                    TriviaTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TriviaTags", x => x.TriviaTagId);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.ApplicationUserId);
                    table.ForeignKey(
                        name: "FK_ApplicationUsers_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    End = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    OrganizationId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TriviaQuestions",
                columns: table => new
                {
                    TriviaQuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TriviaQuestions", x => x.TriviaQuestionId);
                    table.ForeignKey(
                        name: "FK_TriviaQuestions_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TriviaAnswers",
                columns: table => new
                {
                    TriviaAnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    TriviaQuestionId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TriviaAnswers", x => x.TriviaAnswerId);
                    table.ForeignKey(
                        name: "FK_TriviaAnswers_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TriviaAnswers_TriviaQuestions_TriviaQuestionId",
                        column: x => x.TriviaQuestionId,
                        principalTable: "TriviaQuestions",
                        principalColumn: "TriviaQuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TriviaQuestionTags",
                columns: table => new
                {
                    TriviaQuestionTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TriviaQuestionId = table.Column<int>(type: "int", nullable: false),
                    TriviaTagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TriviaQuestionTags", x => x.TriviaQuestionTagId);
                    table.ForeignKey(
                        name: "FK_TriviaQuestionTags_TriviaQuestions_TriviaQuestionId",
                        column: x => x.TriviaQuestionId,
                        principalTable: "TriviaQuestions",
                        principalColumn: "TriviaQuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TriviaQuestionTags_TriviaTags_TriviaTagId",
                        column: x => x.TriviaTagId,
                        principalTable: "TriviaTags",
                        principalColumn: "TriviaTagId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TriviaGuess",
                columns: table => new
                {
                    TriviaGuessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TriviaAnswerId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TriviaGuess", x => x.TriviaGuessId);
                    table.ForeignKey(
                        name: "FK_TriviaGuess_ApplicationUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "ApplicationUserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TriviaGuess_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TriviaGuess_TriviaAnswers_TriviaAnswerId",
                        column: x => x.TriviaAnswerId,
                        principalTable: "TriviaAnswers",
                        principalColumn: "TriviaAnswerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_OrganizationId",
                table: "ApplicationUsers",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_OrganizationId",
                table: "Events",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_TriviaAnswers_EventId",
                table: "TriviaAnswers",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_TriviaAnswers_TriviaQuestionId",
                table: "TriviaAnswers",
                column: "TriviaQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TriviaGuess_ApplicationUserId",
                table: "TriviaGuess",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TriviaGuess_EventId",
                table: "TriviaGuess",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_TriviaGuess_TriviaAnswerId",
                table: "TriviaGuess",
                column: "TriviaAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_TriviaQuestions_EventId",
                table: "TriviaQuestions",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_TriviaQuestionTags_TriviaQuestionId",
                table: "TriviaQuestionTags",
                column: "TriviaQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TriviaQuestionTags_TriviaTagId",
                table: "TriviaQuestionTags",
                column: "TriviaTagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TriviaGuess");

            migrationBuilder.DropTable(
                name: "TriviaQuestionTags");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "TriviaAnswers");

            migrationBuilder.DropTable(
                name: "TriviaTags");

            migrationBuilder.DropTable(
                name: "TriviaQuestions");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.CreateTable(
                name: "Widgets",
                columns: table => new
                {
                    WidgetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(type: "int", nullable: false),
                    InventedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widgets", x => x.WidgetId);
                });
        }
    }
}
