using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class Pv
    {
        public int Id { get; set; }
        public string Pvno { get; set; }
        public string Pvtype { get; set; }
        public string Cano { get; set; }
        public string ComCode { get; set; }
        public string PayId { get; set; }
        public string Section { get; set; }
        public string PvcostCenter { get; set; }
        public string PayOrg { get; set; }
        public string PayAddress { get; set; }
        public DateTime? PayDate { get; set; }
        public DateTime? PrintDate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Wht { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? Caamount { get; set; }
        public decimal? NetAmount { get; set; }
        public string ClearCano { get; set; }
        public string Note { get; set; }
        public decimal? TotalInvoice { get; set; }
        public decimal? TotalVat { get; set; }
        public decimal? TotalPay { get; set; }
        public decimal? TotalWht1 { get; set; }
        public decimal? TotalWht2 { get; set; }
        public decimal? TotalWht3 { get; set; }
        public string Status { get; set; }
        public string Special { get; set; }
        public string CreateBy { get; set; }
        public string CreatePos { get; set; }
        public string CreateOrg { get; set; }
        public DateTime? CreateDate { get; set; }
        public string LastModifyBy { get; set; }
        public DateTime? LastModifyDate { get; set; }
        public string AttachedFile { get; set; }
        public string PayName { get; set; }
        public string PrepareByDept { get; set; }
        public string Sapmessage { get; set; }
        public string Currency { get; set; }
        public string ExchangeRate { get; set; }
        public string DocStatus { get; set; }
    }
}
