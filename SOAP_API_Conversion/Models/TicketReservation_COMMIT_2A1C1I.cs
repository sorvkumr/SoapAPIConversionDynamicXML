namespace SOAP_API_Conversion.Models;

public class TicketReservation_COMMIT_2A1C1I
{
    public class TicketReservation
    {
        public ClientInformation ClientInformation { get; set; }
        public BookingReferenceID BookingReferenceID { get; set; }
        public Fulfillment Fulfillment { get; set; }
        public string RequestPurpose { get; set; }
    }

    public class ClientInformation
    {
        public string ClientIP { get; set; }
        public bool Member { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string PreferredCurrency { get; set; }
    }

    public class BookingReferenceID
    {
        public CompanyName CompanyName { get; set; }
        public string ID { get; set; }
        public string ReferenceID { get; set; }
    }

    public class CompanyName
    {
        public string CityCode { get; set; }
        public string Code { get; set; }
        public string CodeContext { get; set; }
        public string CompanyFullName { get; set; }
        public string CompanyShortName { get; set; }
        public string CountryCode { get; set; }
    }

    public class Fulfillment
    {
        public PaymentDetails PaymentDetails { get; set; }
    }

    public class PaymentDetails
    {
        public List<PaymentDetail> PaymentDetailList { get; set; }
    }

    public class PaymentDetail
    {
        public MiscChargeOrder MiscChargeOrder { get; set; }
        public bool? PayLater { get; set; } // Optional
        public PaymentAmount PaymentAmount { get; set; }
        public string PaymentType { get; set; }
        public bool PrimaryPayment { get; set; }
    }

    public class MiscChargeOrder
    {
        public bool? AVSEnabled { get; set; } // Optional
        public bool CapturePaymentToolNumber { get; set; }
        public string PaymentCode { get; set; }
        public bool ThreeDomainSecurityEligible { get; set; }
        public string MCONumber { get; set; }
    }

    public class PaymentAmount
    {
        public Currency Currency { get; set; }
        public decimal MileAmount { get; set; } // Optional
        public decimal Value { get; set; }
    }

    public class Currency
    {
        public string Code { get; set; }
    }

}
