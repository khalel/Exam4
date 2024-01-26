using CarepatronHealthcareProvider.Domain.Service;
using Microsoft.AspNetCore.Mvc;

namespace CarepatronHealthcareProvider.Api.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class Company1PatientController : ControllerBase
    {
        private readonly ILogger<Company1PatientController> _logger;
        private readonly ICompany1PatientService _patientService;

        public Company1PatientController(ILogger<Company1PatientController> logger, ICompany1PatientService patientService)
        {
            _logger = logger;
            _patientService = patientService;
        }

        [HttpGet("GetPatientDocuments")]
        public ActionResult<object> GetPatientDocuments(string patientHealthcareProviderNumber)
        {
            return Ok(_patientService.GetPatientDocuments(patientHealthcareProviderNumber));
        }
    }
}
