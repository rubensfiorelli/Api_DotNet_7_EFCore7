using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProSummit.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationshipSpeakersandEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpeakerSummitEvent");

            migrationBuilder.AddColumn<Guid>(
                name: "SummitEventId",
                table: "Speakers",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_SummitEventId",
                table: "Speakers",
                column: "SummitEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Speakers_Events_SummitEventId",
                table: "Speakers",
                column: "SummitEventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Speakers_Events_SummitEventId",
                table: "Speakers");

            migrationBuilder.DropIndex(
                name: "IX_Speakers_SummitEventId",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "SummitEventId",
                table: "Speakers");

            migrationBuilder.CreateTable(
                name: "SpeakerSummitEvent",
                columns: table => new
                {
                    EventsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SpeakersId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeakerSummitEvent", x => new { x.EventsId, x.SpeakersId });
                    table.ForeignKey(
                        name: "FK_SpeakerSummitEvent_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpeakerSummitEvent_Speakers_SpeakersId",
                        column: x => x.SpeakersId,
                        principalTable: "Speakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_SpeakerSummitEvent_SpeakersId",
                table: "SpeakerSummitEvent",
                column: "SpeakersId");
        }
    }
}
