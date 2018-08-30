using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class Pvitem
    {
        public int Id { get; set; }
        public string Pvno { get; set; }
        public int? Seq { get; set; }
        public string DocNo { get; set; }
        public string Ref { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string DocHt { get; set; }
        public string St { get; set; }
        public DateTime? EntryDate { get; set; }
        public string At1 { get; set; }
        public decimal? Invoice { get; set; }
        public string At2 { get; set; }
        public decimal? Vat { get; set; }
        public string At3 { get; set; }
        public decimal? Pay { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string PayeeId { get; set; }
        public string PayeeName { get; set; }
        public string Rt { get; set; }
        public decimal? Percent1 { get; set; }
        public decimal? Wht1 { get; set; }
        public decimal? Percent2 { get; set; }
        public decimal? Wht2 { get; set; }
        public decimal? Percent3 { get; set; }
        public decimal? Wht3 { get; set; }
        public int? Pvid { get; set; }
    }
}
