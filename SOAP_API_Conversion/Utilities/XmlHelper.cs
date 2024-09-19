using SOAP_API_Conversion.Models;

namespace SOAP_API_Conversion.Utilities;

public class XmlHelper
{
    public string SegmentBaseAvailableSpecialXml(SegmentBaseAvailableSpecialRequestModel requestModel)
    {
        var xmlRequest = "";
        foreach (var flightSegment in requestModel.BookFlightSegments)
        {
            xmlRequest = $@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:impl=""http://impl.soap.ws.crane.hititcs.com/"">
                   <soapenv:Header/>
                   <soapenv:Body>
                      <impl:SegmentBaseAvailableSpecialServices>
                         <SegmentBaseAvailableSpecialServicesRequest>k
                            <clientInformation>
                               <clientIP>{requestModel.ClientInformations.ClientIP}</clientIP>
                               <member>{requestModel.ClientInformations.Member}</member>
                               <password>{requestModel.ClientInformations.Password}</password>
                               <userName>{requestModel.ClientInformations.UserName}</userName>
                               <preferredCurrency>{requestModel.ClientInformations.PreferredCurrency}</preferredCurrency>
                            </clientInformation>
                            <bookFlightSegmentList>
                               <addOnSegment/>
                               <bookingClass>
                                  <cabin>{flightSegment.BookingClass.Cabin}</cabin>
                                  <resBookDesigCode>{flightSegment.BookingClass.ResBookDesigCode}</resBookDesigCode>
                                  <resBookDesigQuantity>{flightSegment.BookingClass.ResBookDesigQuantity}</resBookDesigQuantity>
                                  <resBookDesigStatusCode>{flightSegment.BookingClass.ResBookDesigStatusCode}</resBookDesigStatusCode>
                               </bookingClass>
                               <fareInfo>
                                  <cabin>{flightSegment.FareInfo.Cabin}</cabin>
                                  <cabinClassCode>{flightSegment.FareInfo.CabinClassCode}</cabinClassCode>
                                  <fareBaggageAllowance>
                                     <allowanceType>{flightSegment.FareInfo.FareBaggageAllowance.AllowanceType}</allowanceType>
                                     <maxAllowedPieces>{flightSegment.FareInfo.FareBaggageAllowance.MaxAllowedPieces}</maxAllowedPieces>
                                     <maxAllowedWeight>
                                        <unitOfMeasureCode>{flightSegment.FareInfo.FareBaggageAllowance.MaxAllowedWeight.UnitOfMeasureCode}</unitOfMeasureCode>
                                        <weight>{flightSegment.FareInfo.FareBaggageAllowance.MaxAllowedWeight.Weight}</weight>
                                     </maxAllowedWeight>
                                  </fareBaggageAllowance>
                                  <fareGroupName>{flightSegment.FareInfo.FareGroupName}</fareGroupName>
                                  <fareReferenceCode>{flightSegment.FareInfo.FareReferenceCode}</fareReferenceCode>
                                  <fareReferenceID>{flightSegment.FareInfo.FareReferenceID}</fareReferenceID>
                                  <fareReferenceName>{flightSegment.FareInfo.FareReferenceName}</fareReferenceName>
                                  <flightSegmentSequence>{flightSegment.FareInfo.FlightSegmentSequence}</flightSegmentSequence>
                                  <portTax>{flightSegment.FareInfo.PortTax}</portTax>
                                  <resBookDesigCode>{flightSegment.BookingClass.ResBookDesigCode}</resBookDesigCode>
                               </fareInfo>
                               <flightSegment>
                                  <airline>
                                     <code>{flightSegment.FlightSegment.Airline.Code}</code>
                                     <companyFullName>{flightSegment.FlightSegment.Airline.CompanyFullName}</companyFullName>
                                  </airline>
                                  <arrivalAirport>
                                     <cityInfo>
                                        <city>
                                           <locationCode>{flightSegment.FlightSegment.CityInfo.City.LocationCode}</locationCode>
                                           <locationName>{flightSegment.FlightSegment.CityInfo.City.LocationName}</locationName>
                                           <locationNameLanguage>{flightSegment.FlightSegment.CityInfo.City.LocationNameLanguage}</locationNameLanguage>
                                        </city>
                                        <country>
                                           <locationCode>{flightSegment.FlightSegment.CityInfo.Country.LocationCode}</locationCode>
                                           <locationName>{flightSegment.FlightSegment.CityInfo.Country.LocationName}</locationName>
                                           <locationNameLanguage>{flightSegment.FlightSegment.CityInfo.Country.LocationNameLanguage}</locationNameLanguage>
                                           <currency>
                                              <code>{flightSegment.FlightSegment.CityInfo.Country.Currency.Code}</code>
                                           </currency>
                                        </country>
                                     </cityInfo>
                                     <language>{flightSegment.FlightSegment.ArrivalAirport.Language}</language>
                                     <locationCode>{flightSegment.FlightSegment.ArrivalAirport.LocationCode}</locationCode>
                                     <locationName>{flightSegment.FlightSegment.ArrivalAirport.LocationName}</locationName>
                                     <timeZoneInfo>{flightSegment.FlightSegment.ArrivalAirport.TimeZoneInfo}</timeZoneInfo>
                                  </arrivalAirport>
                                  <arrivalDateTime>{flightSegment.FlightSegment.ArrivalDateTime}</arrivalDateTime>
                                  <arrivalDateTimeUTC>{flightSegment.FlightSegment.ArrivalDateTimeUTC}</arrivalDateTimeUTC>
                                  <departureAirport>
                                     <cityInfo>
                                        <city>
                                        <city>
                                           <locationCode>{flightSegment.FlightSegment.CityInfo.City.LocationCode}</locationCode>
                                           <locationName>{flightSegment.FlightSegment.CityInfo.City.LocationName}</locationName>
                                           <locationNameLanguage>{flightSegment.FlightSegment.CityInfo.City.LocationNameLanguage}</locationNameLanguage>
                                        </city>
                                        <country>
                                           <locationCode>{flightSegment.FlightSegment.CityInfo.Country.LocationCode}</locationCode>
                                           <locationName>{flightSegment.FlightSegment.CityInfo.Country.LocationName}</locationName>
                                           <locationNameLanguage>{flightSegment.FlightSegment.CityInfo.Country.LocationNameLanguage}</locationNameLanguage>
                                           <currency>
                                              <code>{flightSegment.FlightSegment.CityInfo.Country.Currency.Code}</code>
                                           </currency>
                                        </country>
                                     </cityInfo>    
                                     <codeContext>{flightSegment.FlightSegment.DepartureAirport.CodeContext}</codeContext>
                                     <language>{flightSegment.FlightSegment.DepartureAirport.Language}</language>
                                     <locationCode>{flightSegment.FlightSegment.DepartureAirport.LocationCode}</locationCode>
                                     <locationName>{flightSegment.FlightSegment.DepartureAirport.LocationName}</locationName>
                                     <timeZoneInfo>{flightSegment.FlightSegment.DepartureAirport.TimeZoneInfo}</timeZoneInfo>
                                  </departureAirport>
                                  <departureDateTime>{flightSegment.FlightSegment.DepartureDateTime}</departureDateTime>
                                  <departureDateTimeUTC>{flightSegment.FlightSegment.DepartureDateTimeUTC}</departureDateTimeUTC>
                                  <flightNumber>{flightSegment.FlightSegment.FlightNumber}</flightNumber>
                                  <flightSegmentID>{flightSegment.FlightSegment.FlightSegmentID}</flightSegmentID>
                                  <ondControlled>{flightSegment.FlightSegment.OndControlled}</ondControlled>
                                  <sector>{flightSegment.FlightSegment.Sector}</sector>
                                  <codeshare>{flightSegment.FlightSegment.Codeshare}</codeshare>
                                  <distance>{flightSegment.FlightSegment.Distance}</distance>
                                  <equipment>
                                     <airEquipType>{flightSegment.FlightSegment.Equipment.AirEquipType}</airEquipType>
                                     <changeofGauge>{flightSegment.FlightSegment.Equipment.ChangeOfGauge}</changeofGauge>
                                  </equipment>";

            foreach (var segment in flightSegment.FlightSegment.FlightNotes)
            {
                xmlRequest += $@"
                                  <flightNotes>
                                     <deiCode>{segment.DeiCode}</deiCode>
                                     <explanation>{segment.Explanation}</explanation>
                                     <note>{segment.Note}</note>
                                  </flightNotes>";
            }
            xmlRequest += $@"< flownMileageQty >{flightSegment.FlightSegment.FlownMileageQty}</ flownMileageQty >
                                  < iatciFlight >{flightSegment.FlightSegment.IatciFlight}</ iatciFlight >
                                  < journeyDuration >{flightSegment.FlightSegment.JourneyDuration}</ journeyDuration >
                                  < onTimeRate >{flightSegment.FlightSegment.OnTimeRate}</ onTimeRate >
                                  < secureFlightDataRequired >{flightSegment.FlightSegment.SecureFlightDataRequired}</ secureFlightDataRequired >
                                  < stopQuantity >{flightSegment.FlightSegment.StopQuantity}</ stopQuantity >
                                  < ticketType >{flightSegment.FlightSegment.TicketType}</ ticketType >
                               </ flightSegment >
                            </ bookFlightSegmentList >
                         </ SegmentBaseAvailableSpecialServicesRequest >
                      </ impl:SegmentBaseAvailableSpecialServices >
                   </ soapenv:Body >
                </ soapenv:Envelope >";
        };

        return xmlRequest;
    }
}
