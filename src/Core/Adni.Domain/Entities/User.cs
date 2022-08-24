using Adni.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public abstract class User
    {
        public Guid EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Username { get;set; }
        public string Password { get; set; }   
        public string Location { get; set; }
        public string Phonenumber { get; set; }
        public string WhatsappNumber { get; set; }
        public string DoB { get; set; }
    }
}
