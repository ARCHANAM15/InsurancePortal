using System;
using System.Collections.Generic;

#nullable disable

namespace member.Models
{
    public partial class PolicyTable
    {
        public int PolicyId { get; set; }
        public string PolicyType { get; set; }
        public long? PolicyNumber { get; set; }
        public decimal? PremiumAmount { get; set; }
        public string Remarks { get; set; }
        public int? StatusId { get; set; }
        public int? MemberId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
    }
}
