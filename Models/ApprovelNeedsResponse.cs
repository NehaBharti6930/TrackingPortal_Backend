namespace CoreAPI_Tracking.Models
{
    public class ApprovelNeedsResponse
    {
        public Int64 APPROVER_ID { get; set; }
        public String? APPROVER_NAME { get; set; }
        public String? APPROVER_DESIGNATION { get; set; }
        public char STATUS { get; set; }
        public bool ISACTIVE { get; set; }
        public String? REVIEWBY { get; set; }
        public DateTime? REVIEWON { get; set; }
        public String? UPDATEDBY { get; set; }

        public DateTime UPDATEDON { get; set; }
    }
}
