namespace OTBIS.Web.Data
{
    public class SummarySalesChannel
    {
        public int SummarySalesChannelId { get; set; }
        public string SummarySalesChannelName { get; set; }

        public int TotalTickets { get; set; }

        public decimal TotalFaceValue { get; set; }

        public decimal NetCapacityPercentage { get; set; }
    }
}
