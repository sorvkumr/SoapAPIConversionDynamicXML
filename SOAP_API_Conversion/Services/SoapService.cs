using SOAP_API_Conversion.Models;
using SOAP_API_Conversion.Utilities;
using System.Text;

namespace SOAP_API_Conversion.Services;

public class SoapService : ISoapService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IConfiguration _configuration;
    public SoapService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
    {
        _httpClientFactory = httpClientFactory;
        _configuration = configuration;
    }

    public async Task<string> SegmentBaseAvailableSpecialRequestModel(SegmentBaseAvailableSpecialRequestModel requestModel)
    {
        string? soapServiceUrl = _configuration.GetValue<string>("ApiSettings:SoapServiceUrl");
        HttpClient? client = new HttpClient();
        XmlHelper xmlHelper = new XmlHelper();
        HttpRequestMessage? request = new HttpRequestMessage(HttpMethod.Post, soapServiceUrl);
        string requestBody = xmlHelper.SegmentBaseAvailableSpecialXml(requestModel);

        StringContent? content = new StringContent(requestBody, Encoding.UTF8, "text/xml");
        request.Content = content;

        HttpResponseMessage? response = await client.SendAsync(request);
        string responseBody = await response.Content.ReadAsStringAsync();
        string? json = ConvertXmlToJsonFormat.ConvertXmlToJson(responseBody);
        return json;
    }
}
