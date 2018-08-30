using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class Ca
    {
        public int Id { get; set; }
        public string Cano { get; set; }
        public DateTime? Cadate { get; set; }
        public string FundSap { get; set; }
        public string Iosap { get; set; }
        public string ComCode { get; set; }
        public string CostCenter { get; set; }
        public string ReserveBudget { get; set; }
        public string InternalMemoNo { get; set; }
        public string Objective { get; set; }
        public string ObjectiveDesc { get; set; }
        public decimal? Amount { get; set; }
        public string Currency { get; set; }
        public DateTime? RequireDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string ReceiveId { get; set; }
        public string BusinessPlace { get; set; }
        public string PaymentPlace { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
        public string PrepareBy { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestFor { get; set; }
        public string RequestPos { get; set; }
        public string RequestOrg { get; set; }
        public string CreateBy { get; set; }
        public string CreatePos { get; set; }
        public string CreateOrg { get; set; }
        public DateTime? CreateDate { get; set; }
        public string LastModifyBy { get; set; }
        public DateTime? LastModifyDate { get; set; }
        public string Sapmessage { get; set; }
        public string ReceiveType { get; set; }
        public bool? Executive { get; set; }
        public string ReceiveRemark { get; set; }
    }
}
