using System;
using System.Collections.Generic;

#nullable disable

namespace Company.Models
{
    public partial class UserEntity
    {
        public decimal Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string Email { get; set; }
        public decimal MobileNumber { get; set; }
        public string Confirmed { get; set; }
    }
}
