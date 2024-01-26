using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarepatronHealthcareProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company1Patient",
                columns: table => new
                {
                    Company1PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordNumber = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company1Patient", x => x.Company1PatientId);
                });

            migrationBuilder.CreateTable(
                name: "Company2Patient",
                columns: table => new
                {
                    Company1PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordNumber = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company2Patient", x => x.Company1PatientId);
                });

            migrationBuilder.CreateTable(
                name: "HealthcareProvider",
                columns: table => new
                {
                    HealthcareProviderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthcareProviderName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthcareProvider", x => x.HealthcareProviderId);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordNumber = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "Company1PhysicalAssessment",
                columns: table => new
                {
                    PhysicalAssessmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company1PatientId = table.Column<int>(type: "int", nullable: false),
                    Assessment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company1PhysicalAssessment", x => x.PhysicalAssessmentId);
                    table.ForeignKey(
                        name: "FK_Company1PhysicalAssessment_Company1Patient_Company1PatientId",
                        column: x => x.Company1PatientId,
                        principalTable: "Company1Patient",
                        principalColumn: "Company1PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Company1ProgressNotes",
                columns: table => new
                {
                    ProgressNotesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company1PatientId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company1ProgressNotes", x => x.ProgressNotesId);
                    table.ForeignKey(
                        name: "FK_Company1ProgressNotes_Company1Patient_Company1PatientId",
                        column: x => x.Company1PatientId,
                        principalTable: "Company1Patient",
                        principalColumn: "Company1PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Company2PhysicalAssessment",
                columns: table => new
                {
                    PhysicalAssessmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company2PatientId = table.Column<int>(type: "int", nullable: false),
                    Assessment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company2PhysicalAssessment", x => x.PhysicalAssessmentId);
                    table.ForeignKey(
                        name: "FK_Company2PhysicalAssessment_Company2Patient_Company2PatientId",
                        column: x => x.Company2PatientId,
                        principalTable: "Company2Patient",
                        principalColumn: "Company1PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Company2ProgressNotes",
                columns: table => new
                {
                    ProgressNotesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company2PatientId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company2ProgressNotes", x => x.ProgressNotesId);
                    table.ForeignKey(
                        name: "FK_Company2ProgressNotes_Company2Patient_Company2PatientId",
                        column: x => x.Company2PatientId,
                        principalTable: "Company2Patient",
                        principalColumn: "Company1PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DieticianPatient",
                columns: table => new
                {
                    DieticianPatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    HealthcareProviderNumber = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    HealthcareProviderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DieticianPatient", x => x.DieticianPatientId);
                    table.ForeignKey(
                        name: "FK_DieticianPatient_HealthcareProvider_HealthcareProviderId",
                        column: x => x.HealthcareProviderId,
                        principalTable: "HealthcareProvider",
                        principalColumn: "HealthcareProviderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssessment",
                columns: table => new
                {
                    PhysicalAssessmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    Assessment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssessment", x => x.PhysicalAssessmentId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssessment_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgressNotes",
                columns: table => new
                {
                    ProgressNotesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressNotes", x => x.ProgressNotesId);
                    table.ForeignKey(
                        name: "FK_ProgressNotes_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryHealthcareProviderPhysicalAssessment",
                columns: table => new
                {
                    PhysicalAssessmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DieticianPatientId = table.Column<int>(type: "int", nullable: false),
                    Assessment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryHealthcareProviderPhysicalAssessment", x => x.PhysicalAssessmentId);
                    table.ForeignKey(
                        name: "FK_PrimaryHealthcareProviderPhysicalAssessment_DieticianPatient_DieticianPatientId",
                        column: x => x.DieticianPatientId,
                        principalTable: "DieticianPatient",
                        principalColumn: "DieticianPatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryHealthcareProviderProgressNotes",
                columns: table => new
                {
                    ProgressNotesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DieticianPatientId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryHealthcareProviderProgressNotes", x => x.ProgressNotesId);
                    table.ForeignKey(
                        name: "FK_PrimaryHealthcareProviderProgressNotes_DieticianPatient_DieticianPatientId",
                        column: x => x.DieticianPatientId,
                        principalTable: "DieticianPatient",
                        principalColumn: "DieticianPatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company1PhysicalAssessment_Company1PatientId",
                table: "Company1PhysicalAssessment",
                column: "Company1PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Company1ProgressNotes_Company1PatientId",
                table: "Company1ProgressNotes",
                column: "Company1PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Company2PhysicalAssessment_Company2PatientId",
                table: "Company2PhysicalAssessment",
                column: "Company2PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Company2ProgressNotes_Company2PatientId",
                table: "Company2ProgressNotes",
                column: "Company2PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DieticianPatient_HealthcareProviderId",
                table: "DieticianPatient",
                column: "HealthcareProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssessment_PatientId",
                table: "PhysicalAssessment",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PrimaryHealthcareProviderPhysicalAssessment_DieticianPatientId",
                table: "PrimaryHealthcareProviderPhysicalAssessment",
                column: "DieticianPatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PrimaryHealthcareProviderProgressNotes_DieticianPatientId",
                table: "PrimaryHealthcareProviderProgressNotes",
                column: "DieticianPatientId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressNotes_PatientId",
                table: "ProgressNotes",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company1PhysicalAssessment");

            migrationBuilder.DropTable(
                name: "Company1ProgressNotes");

            migrationBuilder.DropTable(
                name: "Company2PhysicalAssessment");

            migrationBuilder.DropTable(
                name: "Company2ProgressNotes");

            migrationBuilder.DropTable(
                name: "PhysicalAssessment");

            migrationBuilder.DropTable(
                name: "PrimaryHealthcareProviderPhysicalAssessment");

            migrationBuilder.DropTable(
                name: "PrimaryHealthcareProviderProgressNotes");

            migrationBuilder.DropTable(
                name: "ProgressNotes");

            migrationBuilder.DropTable(
                name: "Company1Patient");

            migrationBuilder.DropTable(
                name: "Company2Patient");

            migrationBuilder.DropTable(
                name: "DieticianPatient");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "HealthcareProvider");
        }
    }
}
