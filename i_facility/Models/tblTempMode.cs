//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace i_facility.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTempMode
    {
        public int tempModeID { get; set; }
        public int modeId { get; set; }
        public int machineId { get; set; }
        public string mode { get; set; }
        public System.DateTime insertedOn { get; set; }
        public int insertedBy { get; set; }
        public Nullable<System.DateTime> modifiedOn { get; set; }
        public Nullable<int> modifiedBy { get; set; }
        public string correctedDate { get; set; }
        public int isDeleted { get; set; }
        public Nullable<System.DateTime> startTime { get; set; }
        public Nullable<System.DateTime> endTime { get; set; }
        public string colorCode { get; set; }
        public int isCompleted { get; set; }
        public Nullable<int> durationInSec { get; set; }
        public Nullable<int> modeMonth { get; set; }
        public Nullable<int> modeYear { get; set; }
        public Nullable<int> modeWeekNumber { get; set; }
        public Nullable<int> modeQuarter { get; set; }
        public Nullable<int> isSaved { get; set; }
        public Nullable<int> isApproved { get; set; }
        public Nullable<int> rejectReasonId { get; set; }
        public Nullable<int> IsSendToApproveOrRej { get; set; }
        public Nullable<System.DateTime> approvedDate { get; set; }
        public Nullable<System.DateTime> mailSendDate { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<int> approveLevel { get; set; }
        public Nullable<int> overAllSaved { get; set; }
        public Nullable<int> rejectLevel { get; set; }
        public Nullable<int> isUpdated { get; set; }
        public Nullable<int> isApproved1 { get; set; }
        public Nullable<int> isUpdateFinal { get; set; }
        public Nullable<int> isHold { get; set; }
    }
}
