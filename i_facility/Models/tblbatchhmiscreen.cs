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
    
    public partial class tblbatchhmiscreen
    {
        public int BHMIID { get; set; }
        public int MachineID { get; set; }
        public string OperatiorID { get; set; }
        public string Shift { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public string Project { get; set; }
        public string PartNo { get; set; }
        public string OperationNo { get; set; }
        public Nullable<int> Rej_Qty { get; set; }
        public string Work_Order_No { get; set; }
        public Nullable<int> Target_Qty { get; set; }
        public Nullable<int> Delivered_Qty { get; set; }
        public Nullable<int> Status { get; set; }
        public string CorrectedDate { get; set; }
        public string Prod_FAI { get; set; }
        public int isUpdate { get; set; }
        public int DoneWithRow { get; set; }
        public int isWorkInProgress { get; set; }
        public int isWorkOrder { get; set; }
        public Nullable<System.DateTime> PEStartTime { get; set; }
        public int ProcessQty { get; set; }
        public string DDLWokrCentre { get; set; }
        public int IsHold { get; set; }
        public string SplitWO { get; set; }
        public string autoBatchNumber { get; set; }
        public Nullable<int> ActivityId { get; set; }
        public int IsBatchStart { get; set; }
        public Nullable<int> IsActivityFinish { get; set; }
        public Nullable<int> IsBatchFinish { get; set; }
        public int IsChecked { get; set; }
        public Nullable<int> ProcessId { get; set; }
        public string PrevBatchNo { get; set; }
        public Nullable<int> IsPatialFinish { get; set; }
        public Nullable<int> IsGenericClicked { get; set; }
    }
}
