using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get;set; }
        public string Password { get; set; }   
        public string Location { get; set; }
        public string Phonenumber { get; set; }
        public string WhatsappNumber { get; set; }
        public DateTime DoB { get; set; }
    }
}
