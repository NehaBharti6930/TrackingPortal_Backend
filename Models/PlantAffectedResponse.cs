namespace CoreAPI_Tracking.Models
{
    public class PlantAffectedResponse
    {
        public Int64 PLANT_ID { get; set; }
        public Int64 PLANT_CODE { get; set; }
        public string? PLANTNAME { get; set; }
        public Int32 DISPLAYORDER { get; set; }
        public bool ISACTIVE { get; set; }
        public string? CREATEDBY { get; set; }
        public DateTime? CREATEDON { get; set; }
        public string? UPDATEDBY { get; set; }
        public DateTime? UPDATEDON { get; set; }
    }
}
