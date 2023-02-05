using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTBIS.Web.Data.Production
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime? BookingDate { get; set; }

        public decimal? BookingValue { get; set; }

        public int TicketTypeId { get; set; }

        public int DomainId { get; set; }

        public int BookingRef { get; set; }

        public int ResTypeId { get; set; }

        public string ResourceNameId { get; set; }

        public string EventName { get; set; }

        public DateTime? First_Payment_Received { get; set; }
        public DateTime? Actual_Visit_Date { get; set; }
        public DateTime? Booking_Visit_Date { get; set; }

        public DateTime? Booking_ETA { get; set; }

        public decimal? ActualValue { get; set; }

        public int? Booked_Child { get; set; }

        public int? Actual_Child { get; set; }

        public int? Booked_Adult { get; set; }

        public int? Actual_Adult { get; set; }

        public string StatusId { get; set; }

        public int? tillId { get; set; } 
    }
}
