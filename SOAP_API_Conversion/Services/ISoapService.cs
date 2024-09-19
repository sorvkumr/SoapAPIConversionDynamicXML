using SOAP_API_Conversion.Models;

namespace SOAP_API_Conversion.Services;

public interface ISoapService
{
    Task<string> SegmentBaseAvailableSpecialRequestModel(SegmentBaseAvailableSpecialRequestModel segmentBaseAvailableSpecialModel);
}
