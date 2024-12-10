using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessDL.Migrations
{
    /// <inheritdoc />
    public partial class Gym : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    EquipmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InRepair = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.EquipmentID);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Interests = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberID);
                });

            migrationBuilder.CreateTable(
                name: "Programma",
                columns: table => new
                {
                    ProgramCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaxMembers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programma", x => x.ProgramCode);
                });

            migrationBuilder.CreateTable(
                name: "Time_Slot",
                columns: table => new
                {
                    TimeSlotID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    PartOfDay = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time_Slot", x => x.TimeSlotID);
                });

            migrationBuilder.CreateTable(
                name: "CyclingSession",
                columns: table => new
                {
                    CyclingSessionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    AvgWatt = table.Column<int>(type: "int", nullable: false),
                    MaxWatt = table.Column<int>(type: "int", nullable: false),
                    AvgCadence = table.Column<int>(type: "int", nullable: false),
                    MaxCadence = table.Column<int>(type: "int", nullable: false),
                    TrainingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CyclingSession", x => x.CyclingSessionID);
                    table.ForeignKey(
                        name: "FK_CyclingSession_Members_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Members",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Runningsession_Main",
                columns: table => new
                {
                    RunningSessionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    AvgSpeed = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runningsession_Main", x => x.RunningSessionID);
                    table.ForeignKey(
                        name: "FK_Runningsession_Main_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberEFProgrammaEF",
                columns: table => new
                {
                    MembersMemberID = table.Column<int>(type: "int", nullable: false),
                    ProgrammasProgramCode = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberEFProgrammaEF", x => new { x.MembersMemberID, x.ProgrammasProgramCode });
                    table.ForeignKey(
                        name: "FK_MemberEFProgrammaEF_Members_MembersMemberID",
                        column: x => x.MembersMemberID,
                        principalTable: "Members",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberEFProgrammaEF_Programma_ProgrammasProgramCode",
                        column: x => x.ProgrammasProgramCode,
                        principalTable: "Programma",
                        principalColumn: "ProgramCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentID = table.Column<int>(type: "int", nullable: false),
                    TimeSlotID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MemberID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationID);
                    table.ForeignKey(
                        name: "FK_Reservations_Equipment_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Members_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Members",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Time_Slot_TimeSlotID",
                        column: x => x.TimeSlotID,
                        principalTable: "Time_Slot",
                        principalColumn: "TimeSlotID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Runningsession_Detail",
                columns: table => new
                {
                    RunningSessionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeqNr = table.Column<int>(type: "int", nullable: false),
                    IntervalTime = table.Column<int>(type: "int", nullable: false),
                    IntervalSpeed = table.Column<float>(type: "real", nullable: false),
                    RunningSession_MainRunningSessionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runningsession_Detail", x => x.RunningSessionID);
                    table.ForeignKey(
                        name: "FK_Runningsession_Detail_Runningsession_Main_RunningSession_MainRunningSessionID",
                        column: x => x.RunningSession_MainRunningSessionID,
                        principalTable: "Runningsession_Main",
                        principalColumn: "RunningSessionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CyclingSession_MemberID",
                table: "CyclingSession",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_MemberEFProgrammaEF_ProgrammasProgramCode",
                table: "MemberEFProgrammaEF",
                column: "ProgrammasProgramCode");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_EquipmentID",
                table: "Reservations",
                column: "EquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_MemberID",
                table: "Reservations",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_TimeSlotID",
                table: "Reservations",
                column: "TimeSlotID");

            migrationBuilder.CreateIndex(
                name: "IX_Runningsession_Detail_RunningSession_MainRunningSessionID",
                table: "Runningsession_Detail",
                column: "RunningSession_MainRunningSessionID");

            migrationBuilder.CreateIndex(
                name: "IX_Runningsession_Main_MemberId",
                table: "Runningsession_Main",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CyclingSession");

            migrationBuilder.DropTable(
                name: "MemberEFProgrammaEF");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Runningsession_Detail");

            migrationBuilder.DropTable(
                name: "Programma");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Time_Slot");

            migrationBuilder.DropTable(
                name: "Runningsession_Main");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
