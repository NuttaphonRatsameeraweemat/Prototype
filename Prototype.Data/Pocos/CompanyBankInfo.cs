using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class CompanyBankInfo
    {
        public int Id { get; set; }
        public string ComCode { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankBranchCode { get; set; }
        public string BankBranchName { get; set; }
        public string AccountType { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
    }
}
