using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class Employee
    {
        public string Firstname { get; set; }
        public string Lastname {get; set;}
        public string Location {get; set;}
        public string Phonenumber {get; set;}
        public string WhatsappNumber {get; set;}
        public DateTime DoB {get; set;}
        public Guid EmployeeId { get; set; }
        public bool IsOnline { get; set; }
        public string Position { get; set; }

        //methods to modify personnal informations
        //public SetFirstname(string firstname) => Firstname = firstname;
        //public SetLastname(string lastname) => Lastname = lastname;
        //public SetLocation(string location) => Location = location;
        //public SetPhonenumber(string phoneNumber) => Phonenumber = phoneNumber;
        //public SetWhatsapp(string whatsapp) => WhatsappNumber = whatsapp;
        //public SetDoB(DateTime dob) => DoB = dob;
    }
}