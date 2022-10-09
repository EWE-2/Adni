using Adni.Domain.Interfaces;
using Adni.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Adni.Domain.Entities
{
    public abstract class User : IUser
    {

        //Identity user informations
        public string? UserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public string PasswordHash { get; set; }

        //User self information
        public string Firstname { get; set; }
        public string? Lastname { get; set; }
        public char Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public string? WhatsappNumber { get; set; }
        public string? Dob { get; set; }
        public string? UserLocation { get; set; }

        public string? ImageDirectory { get; set; }
    }
}
