namespace SOAP_API_Conversion.Models;


public class SegmentBaseAvailableSpecialRequestModel
{
    public ClientInformation ClientInformations { get; set; }
    public List<BookFlightSegmentList> BookFlightSegments { get; set; }
}

public class ClientInformation
{
    public string ClientIP { get; set; }
    public bool Member { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }
    public string PreferredCurrency { get; set; }
}

public class BookFlightSegmentList
{
    public BookingClass BookingClass { get; set; }
    public FareInfo FareInfo { get; set; }
    public FlightSegment FlightSegment { get; set; }
}

public class BookingClass
{
    public string Cabin { get; set; }
    public string ResBookDesigCode { get; set; }
    public int ResBookDesigQuantity { get; set; }
    public string ResBookDesigStatusCode { get; set; }
}

public class FareInfo
{
    public string Cabin { get; set; }
    public string CabinClassCode { get; set; }
    public FareBaggageAllowance FareBaggageAllowance { get; set; }
    public string FareGroupName { get; set; }
    public string FareReferenceCode { get; set; }
    public string FareReferenceID { get; set; }
    public string FareReferenceName { get; set; }
    public int FlightSegmentSequence { get; set; }
    public string PortTax { get; set; }
    public string ResBookDesigCode { get; set; }
}

public class FareBaggageAllowance
{
    public string AllowanceType { get; set; }
    public int MaxAllowedPieces { get; set; }
    public MaxAllowedWeight MaxAllowedWeight { get; set; }
}

public class MaxAllowedWeight
{
    public string UnitOfMeasureCode { get; set; }
    public int Weight { get; set; }
}

public class FlightSegment
{
    public Airline Airline { get; set; }
    //public CityInfo CityInfo { get; set; }
    public ArrivalAirport ArrivalAirport { get; set; }
    public DateTime ArrivalDateTime { get; set; }
    public DateTime ArrivalDateTimeUTC { get; set; }
    public DepartureAirport DepartureAirport { get; set; }
    public DateTime DepartureDateTime { get; set; }
    public DateTime DepartureDateTimeUTC { get; set; }
    public string FlightNumber { get; set; }
    public int FlightSegmentID { get; set; }
    public bool OndControlled { get; set; }
    public string Sector { get; set; }
    public bool Codeshare { get; set; }
    public int Distance { get; set; }
    public Equipment Equipment { get; set; }
    public List<FlightNotes> FlightNotes { get; set; }
    public int FlownMileageQty { get; set; }
    public bool IatciFlight { get; set; }
    public string JourneyDuration { get; set; }
    public int OnTimeRate { get; set; }
    public string Remark { get; set; }
    public bool SecureFlightDataRequired { get; set; }
    public int StopQuantity { get; set; }
    public string TicketType { get; set; }
}

public class Airline
{
    public string Code { get; set; }
    public string CompanyFullName { get; set; }
}

public class CityInfo
{
    public City City { get; set; }
    public Country Country { get; set; }
    public string Language { get; set; }
    public string LocationCode { get; set; }
    public string LocationName { get; set; }
    public string TimeZoneInfo { get; set; }
    public string CodeContext { get; set; }
}

public class ArrivalAirport
{
    public CityInfo CityInfo { get; set; }
    public string CodeContext { get; set; }
    public string Language { get; set; }
    public string LocationCode { get; set; }
    public string LocationName { get; set; }
    public string TimeZoneInfo { get; set; }
}

public class DepartureAirport : ArrivalAirport
{
}

public class City
{
    public string LocationCode { get; set; }
    public string LocationName { get; set; }
    public string LocationNameLanguage { get; set; }
}

public class Country
{
    public string LocationCode { get; set; }
    public string LocationName { get; set; }
    public string LocationNameLanguage { get; set; }
    public Currency Currency { get; set; }
}

public class Currency
{
    public string Code { get; set; }
}

public class Equipment
{
    public string AirEquipType { get; set; }
    public bool ChangeOfGauge { get; set; }
}

public class FlightNotes
{
    public string DeiCode { get; set; }
    public string Explanation { get; set; }
    public string Note { get; set; }
}

