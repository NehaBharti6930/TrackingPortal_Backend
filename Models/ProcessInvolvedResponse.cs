namespace CoreAPI_Tracking.Models
{
    public class ProcessInvolvedResponse
    {
        public Int64 PROCESSINVOLVED_ID { get; set; }
        public String? PROCESSINVOLVEDNAME { get; set; }
        public Int64 DISPLAYORDER { get; set; }
        public bool ISACTIVE { get; set; }
        public String? CREATEDBY { get; set; }
        public DateTime? CREATEDON { get; set; }
        public String? UPDATEDBY { get; set; }

        public DateTime UPDATEDON { get; set; }
    }
}
