namespace SOAP_API_Conversion.Builders;

public class SoapRequestBuilderFactory
{
    public ISoapRequestBuilder GetBuilder(string requestType)
    {
        return requestType switch
        {
            _ => throw new InvalidOperationException("Unknown SOAP request type")
        };
    }
}
