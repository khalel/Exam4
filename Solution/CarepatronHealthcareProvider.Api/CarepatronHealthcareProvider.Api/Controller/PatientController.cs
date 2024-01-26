using CarepatronHealthcareProvider.Domain.Service;
using Microsoft.AspNetCore.Mvc;

namespace CarepatronHealthcareProvider.Api.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly ILogger<PatientController> _logger;
        private readonly IPatientService _patientService;

        public PatientController(ILogger<PatientController> logger, IPatientService patientService)
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
