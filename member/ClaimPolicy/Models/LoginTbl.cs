﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ClaimPolicy.Models
{
    public partial class LoginTbl
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string Email { get; set; }
    }
}
