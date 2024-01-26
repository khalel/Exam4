using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarepatronHealthcareProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO Patient(RecordNumber,FirstName,LastName) VALUES ('CHP001','Ramon','Magsaysay')");
            migrationBuilder.Sql($"INSERT INTO Patient(RecordNumber,FirstName,LastName) VALUES ('CHP002','Fidel','Ramos')");

            migrationBuilder.Sql($"INSERT INTO PhysicalAssessment(PatientId,Assessment) VALUES (1,'CHP001 First Assessment')");
            migrationBuilder.Sql($"INSERT INTO PhysicalAssessment(PatientId,Assessment) VALUES (1,'CHP001 Second Assessment')");
            migrationBuilder.Sql($"INSERT INTO PhysicalAssessment(PatientId,Assessment) VALUES (2,'CHP002 First Assessment')");
            migrationBuilder.Sql($"INSERT INTO PhysicalAssessment(PatientId,Assessment) VALUES (2,'CHP003 Second Assessment')");

            migrationBuilder.Sql($"INSERT INTO ProgressNotes(PatientId,Notes) VALUES (1,'CHP001 First Notes')");
            migrationBuilder.Sql($"INSERT INTO ProgressNotes(PatientId,Notes) VALUES (1,'CHP001 Second Notes')");
            migrationBuilder.Sql($"INSERT INTO ProgressNotes(PatientId,Notes) VALUES (2,'CHP002 First Notes')");
            migrationBuilder.Sql($"INSERT INTO ProgressNotes(PatientId,Notes) VALUES (2,'CHP002 Second Notes')");

            migrationBuilder.Sql($"INSERT INTO Company1Patient(RecordNumber,FirstName,LastName) VALUES ('Company1HP001','Jose','Magsaysay')");
            migrationBuilder.Sql($"INSERT INTO Company1Patient(RecordNumber,FirstName,LastName) VALUES ('Company1HP002','Mickey','Ramos')");

            migrationBuilder.Sql($"INSERT INTO Company1PhysicalAssessment(Company1PatientId,Assessment) VALUES (1,'Company1HP001 First Assessment')");
            migrationBuilder.Sql($"INSERT INTO Company1PhysicalAssessment(Company1PatientId,Assessment) VALUES (1,'Company1HP001 Second Assessment')");
            migrationBuilder.Sql($"INSERT INTO Company1PhysicalAssessment(Company1PatientId,Assessment) VALUES (2,'Company1HP002 First Assessment')");
            migrationBuilder.Sql($"INSERT INTO Company1PhysicalAssessment(Company1PatientId,Assessment) VALUES (2,'Company1HP002 Second Assessment')");

            migrationBuilder.Sql($"INSERT INTO Company1ProgressNotes(Company1PatientId,Notes) VALUES (1,'Company1HP001 First Notes')");
            migrationBuilder.Sql($"INSERT INTO Company1ProgressNotes(Company1PatientId,Notes) VALUES (1,'Company1HP001 Second Notes')");
            migrationBuilder.Sql($"INSERT INTO Company1ProgressNotes(Company1PatientId,Notes) VALUES (2,'Company1HP002 First Notes')");
            migrationBuilder.Sql($"INSERT INTO Company1ProgressNotes(Company1PatientId,Notes) VALUES (2,'Company1HP002 Second Notes')");

            migrationBuilder.Sql($"INSERT INTO Company2Patient(RecordNumber,FirstName,LastName) VALUES ('Company2HP001','Jaime','Magsaysay')");
            migrationBuilder.Sql($"INSERT INTO Company2Patient(RecordNumber,FirstName,LastName) VALUES ('Company2HP002','Jimmy','Ramos')");

            migrationBuilder.Sql($"INSERT INTO Company2PhysicalAssessment(Company2PatientId,Assessment) VALUES (1,'Company2HP001 First Assessment')");
            migrationBuilder.Sql($"INSERT INTO Company2PhysicalAssessment(Company2PatientId,Assessment) VALUES (1,'Company2HP001 Second Assessment')");
            migrationBuilder.Sql($"INSERT INTO Company2PhysicalAssessment(Company2PatientId,Assessment) VALUES (2,'Company2HP002 First Assessment')");
            migrationBuilder.Sql($"INSERT INTO Company2PhysicalAssessment(Company2PatientId,Assessment) VALUES (2,'Company2HP002 Second Assessment')");

            migrationBuilder.Sql($"INSERT INTO Company2ProgressNotes(Company2PatientId,Notes) VALUES (1,'Company2HP001 First Notes')");
            migrationBuilder.Sql($"INSERT INTO Company2ProgressNotes(Company2PatientId,Notes) VALUES (1,'Company2HP001 Second Notes')");
            migrationBuilder.Sql($"INSERT INTO Company2ProgressNotes(Company2PatientId,Notes) VALUES (2,'Company2HP002 First Notes')");
            migrationBuilder.Sql($"INSERT INTO Company2ProgressNotes(Company2PatientId,Notes) VALUES (2,'Company2HP002 Second Notes')");

            migrationBuilder.Sql($"INSERT INTO HealthcareProvider(HealthcareProviderName) VALUES ('Carepatron')");
            migrationBuilder.Sql($"INSERT INTO HealthcareProvider(HealthcareProviderName) VALUES ('Company1')");
            migrationBuilder.Sql($"INSERT INTO HealthcareProvider(HealthcareProviderName) VALUES ('Company2')");

            migrationBuilder.Sql($"INSERT INTO DieticianPatient(FirstName,LastName,Email,Address,HealthcareProviderNumber,HealthcareProviderId) VALUES ('Ramon','Magsaysay','rm@rm.com','Philippines','CHP001',1)");

            migrationBuilder.Sql($"INSERT INTO PrimaryHealthcareProviderPhysicalAssessment(DieticianPatientId,Assessment) VALUES (1,'CHP001 First Assessment')");
            migrationBuilder.Sql($"INSERT INTO PrimaryHealthcareProviderPhysicalAssessment(DieticianPatientId,Assessment) VALUES (1,'CHP001 Second Assessment')");

            migrationBuilder.Sql($"INSERT INTO PrimaryHealthcareProviderProgressNotes(DieticianPatientId,Notes) VALUES (1,'CHP001 First Notes')");
            migrationBuilder.Sql($"INSERT INTO PrimaryHealthcareProviderProgressNotes(DieticianPatientId,Notes) VALUES (1,'CHP001 Second Notes')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
