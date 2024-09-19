using Microsoft.AspNetCore.Mvc;
using SOAP_API_Conversion.Models;
using SOAP_API_Conversion.Services;

namespace SOAP_API_Conversion.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SoapAPIController : ControllerBase
{
    private readonly ISoapService _soapService;
    public SoapAPIController(ISoapService soapService)
    {
        _soapService = soapService;
    }

    [HttpPost("SegmentBaseAvailableSpecial")]
    public async Task<IActionResult> SegmentBaseAvailableSpecialPostAsync(SegmentBaseAvailableSpecialRequestModel requestModel)
    {
        var request = await _soapService.SegmentBaseAvailableSpecialRequestModel(requestModel);
        return Ok(request);
    }
}
