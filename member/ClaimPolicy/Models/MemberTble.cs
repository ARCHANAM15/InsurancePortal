using System;
using System.Collections.Generic;

#nullable disable

namespace ClaimPolicy.Models
{
    public partial class MemberTble
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? LoginId { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string DateOfBirth { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Email { get; set; }
    }
}
