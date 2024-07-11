namespace CoreAPI_Tracking.Models
{
    public class RFCResponse
    {
        public string? Message { get; set; }
        public bool status { get; set; }

        public List<RFCResponseNew>? lstRFC{ get; set; }
        
    }

    public class RFCResponseNew
    {
        public Int64 RFCID { get; set; }
        public string? REQUIREMENT_DESC_BACKGROUND { get; set; }
        public Int32 CHANGETYPEID { get; set; }
        public string? CHANGE_OTHERS_DESC { get; set; }
        public string? FUNCTIONAL_APPROVAL_REMARKS { get; set; }
        public DateTime FUNCTIONAL_APPROVAL_DATE { get; set; }
        public Int32 FUCTIONAL_APPROVAL_REFRENCE_NO { get; set; }
        public char REQUIREMENT_ATTACH_FLAG { get; set; }
        public string? REQUIREMENT_ATTACH_FILE { get; set; }
        public string? PERSON_RESPONSIBLE_NAME { get; set; }
        public string? PERSON_RESPONSIBLE_USERID { get; set; }
        public string? PERSON_RESPONSIBLE_DESIGNATION { get; set; }
        public string? REQUESTEDBY { get; set; }
        public DateTime REQUESTEDON { get; set; }
        public string? APPROVEDBY { get; set; }
        public DateTime APPROVEDON { get; set; }
        public Int32 CONCERNED_APPLICATION_ID { get; set; }
        public string? APPLICATION_OTHER_DESC { get; set; }

        public Int32 PROCESSINVOLVED_ID { get; set; }
        public string? PROCESS_OTHER_DESC { get; set; }
        public string? PLANT_CODE { get; set; }
        public Int32 APPROVER_ID { get; set; }

        public Int32 STATUSID { get; set; }
        public bool ISACTIVE { get; set; }



    }
}
