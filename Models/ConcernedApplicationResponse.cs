namespace CoreAPI_Tracking.Models
{
    public class ConcernedApplicationResponse
    {
        public Int64 CONCERNED_APPLICATION_ID { get; set; }
        public string? APPLICATION_NAME { get; set; }
        public bool ISACTIVE { get; set; }
        public string? CREATEDBY { get; set; }
        public DateTime? CREATEDON { get; set; }
        public string? UPDATEDBY { get; set; }
        public DateTime? UPDATEDON { get; set; }
    }
}
