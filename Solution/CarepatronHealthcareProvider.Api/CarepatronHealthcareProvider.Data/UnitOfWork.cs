using CarepatronHealthcareProvider.Data.Repository;
using CarepatronHealthcareProvider.Domain;
using CarepatronHealthcareProvider.Domain.Repository;

namespace CarepatronHealthcareProvider.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public IPatientRepository Patients { get; private set; }
        public ICompany1PatientRepository Company1Patients { get; private set; }
        public ICompany2PatientRepository Company2Patients { get; private set; }
        public IDieticianPatientRepository DieticianPatients { get; private set; }
        public IPrimaryHealthcareProviderPhysicalAssessmentRepository PrimaryHealthcareProviderPhysicalAssessment { get; private set; }

        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            Patients = new PatientRepository(_context);
            Company1Patients = new Company1PatientRepository(_context);
            Company2Patients = new Company2PatientRepository(_context);
            DieticianPatients = new DieticianPatientRepository(_context);
            PrimaryHealthcareProviderPhysicalAssessment = new PrimaryHealthcareProviderPhysicalAssessmentRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
