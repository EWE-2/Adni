using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public abstract class Employee
    {
        public string Firstname { get; private set; }
        public string Lastname {get; private set;}
        public string Location {get; private set;}
        public string Phonenumber {get; private set;}
        public string WhatsappNumber {get; private set;}
        public DateTime DoB {get; private set;}

        //methods to modify personnal informations
        //public SetFirstname(string firstname) => Firstname = firstname;
        //public SetLastname(string lastname) => Lastname = lastname;
        //public SetLocation(string location) => Location = location;
        //public SetPhonenumber(string phoneNumber) => Phonenumber = phoneNumber;
        //public SetWhatsapp(string whatsapp) => WhatsappNumber = whatsapp;
        //public SetDoB(DateTime dob) => DoB = dob;
    }
}