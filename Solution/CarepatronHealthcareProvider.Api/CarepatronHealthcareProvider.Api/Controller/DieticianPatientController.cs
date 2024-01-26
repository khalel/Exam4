using CarepatronHealthcareProvider.Contract.Request;
using CarepatronHealthcareProvider.Domain.Service;
using Microsoft.AspNetCore.Mvc;

namespace CarepatronHealthcareProvider.Api.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class DieticianPatientController : ControllerBase
    {
        private readonly ILogger<DieticianPatientController> _logger;
        private readonly IDieticianPatientService _dieticianPatientService;

        public DieticianPatientController(ILogger<DieticianPatientController> logger, IDieticianPatientService dieticianPatientService)
        {
            _logger = logger;
            _dieticianPatientService = dieticianPatientService;
        }

        [HttpGet("GetPatient")]
        public ActionResult<object> GetPatient(int id)
        {
            return Ok(_dieticianPatientService.GetPatientDocuments(id));
        }

        [HttpPost("CreatePatient")]
        public ActionResult<object> CreatePatient(CreatePatientRequest dieticianPatientRequest)
        {
            return Ok(_dieticianPatientService.CreatePatient(dieticianPatientRequest));
        }
    }
}
