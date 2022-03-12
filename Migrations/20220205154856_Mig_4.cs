using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenSourceEnity.Migrations
{
    public partial class Mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_participant_AUDs_AspNetUsers_UserId",
                table: "participant_AUDs");

            migrationBuilder.DropForeignKey(
                name: "FK_participant_AUDs_Countries_CountryId",
                table: "participant_AUDs");

            migrationBuilder.DropForeignKey(
                name: "FK_participant_AUDs_Participants_ParticipantId",
                table: "participant_AUDs");

            migrationBuilder.DropForeignKey(
                name: "FK_participant_AUDs_Pols_PolId",
                table: "participant_AUDs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_participant_AUDs",
                table: "participant_AUDs");

            migrationBuilder.RenameTable(
                name: "participant_AUDs",
                newName: "Participant_AUDs");

            migrationBuilder.RenameIndex(
                name: "IX_participant_AUDs_UserId",
                table: "Participant_AUDs",
                newName: "IX_Participant_AUDs_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_participant_AUDs_PolId",
                table: "Participant_AUDs",
                newName: "IX_Participant_AUDs_PolId");

            migrationBuilder.RenameIndex(
                name: "IX_participant_AUDs_ParticipantId",
                table: "Participant_AUDs",
                newName: "IX_Participant_AUDs_ParticipantId");

            migrationBuilder.RenameIndex(
                name: "IX_participant_AUDs_CountryId",
                table: "Participant_AUDs",
                newName: "IX_Participant_AUDs_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Participant_AUDs",
                table: "Participant_AUDs",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Participant_AUDs_AspNetUsers_UserId",
                table: "Participant_AUDs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participant_AUDs_Countries_CountryId",
                table: "Participant_AUDs",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participant_AUDs_Participants_ParticipantId",
                table: "Participant_AUDs",
                column: "ParticipantId",
                principalTable: "Participants",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participant_AUDs_Pols_PolId",
                table: "Participant_AUDs",
                column: "PolId",
                principalTable: "Pols",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participant_AUDs_AspNetUsers_UserId",
                table: "Participant_AUDs");

            migrationBuilder.DropForeignKey(
                name: "FK_Participant_AUDs_Countries_CountryId",
                table: "Participant_AUDs");

            migrationBuilder.DropForeignKey(
                name: "FK_Participant_AUDs_Participants_ParticipantId",
                table: "Participant_AUDs");

            migrationBuilder.DropForeignKey(
                name: "FK_Participant_AUDs_Pols_PolId",
                table: "Participant_AUDs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Participant_AUDs",
                table: "Participant_AUDs");

            migrationBuilder.RenameTable(
                name: "Participant_AUDs",
                newName: "participant_AUDs");

            migrationBuilder.RenameIndex(
                name: "IX_Participant_AUDs_UserId",
                table: "participant_AUDs",
                newName: "IX_participant_AUDs_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Participant_AUDs_PolId",
                table: "participant_AUDs",
                newName: "IX_participant_AUDs_PolId");

            migrationBuilder.RenameIndex(
                name: "IX_Participant_AUDs_ParticipantId",
                table: "participant_AUDs",
                newName: "IX_participant_AUDs_ParticipantId");

            migrationBuilder.RenameIndex(
                name: "IX_Participant_AUDs_CountryId",
                table: "participant_AUDs",
                newName: "IX_participant_AUDs_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_participant_AUDs",
                table: "participant_AUDs",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_participant_AUDs_AspNetUsers_UserId",
                table: "participant_AUDs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_participant_AUDs_Countries_CountryId",
                table: "participant_AUDs",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_participant_AUDs_Participants_ParticipantId",
                table: "participant_AUDs",
                column: "ParticipantId",
                principalTable: "Participants",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_participant_AUDs_Pols_PolId",
                table: "participant_AUDs",
                column: "PolId",
                principalTable: "Pols",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
