using CarepatronHealthcareProvider.Domain.Service;
using Microsoft.AspNetCore.Mvc;

namespace CarepatronHealthcareProvider.Api.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class Company2PatientController : ControllerBase
    {
        private readonly ILogger<Company2PatientController> _logger;
        private readonly ICompany2PatientService _patientService;

        public Company2PatientController(ILogger<Company2PatientController> logger, ICompany2PatientService patientService)
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
