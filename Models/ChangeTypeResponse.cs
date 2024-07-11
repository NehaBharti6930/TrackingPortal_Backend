namespace CoreAPI_Tracking.Models
{
    public class ChangeTypeResponse
    {
        public Int64 CHANGETYPEID { get; set; }
        public string? CHANGETYPENAME { get; set; }
        public bool ISACTIVE { get; set; }
        public string? CREATEDBY { get; set; }
        public DateTime? CREATEDON { get; set; }
        public string? UPDATEDBY { get; set; }
        public DateTime? UPDATEDON { get; set; }
    }
}
