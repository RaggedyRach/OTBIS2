namespace OTBIS.Web.Data
{
    public class SummaryTicketType
    {
        public int SummaryTicketTypeId { get; set; }

        public string SummaryTicketName { get; set; }

        public int TotalTickets { get; set; }

        public decimal TotalFaceValue { get; set; }

        public decimal NetCapacityPercentage { get; set; }
    }
}
