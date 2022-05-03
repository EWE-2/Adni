using System;
using System.Collections.Generic;
using System.Text;
using Adni.Domain.Entities;

namespace Adni.Domain.Interfaces
{
    public interface ISetCompany
    {
        Company Company { get; set; }
        public string SetCompanyName(string name);
        public string SetCompanyDescription(string description);
        public string SetCompanyCigle(string cigle);
        public string SetCompanyPhoneNumber(string phoneNumber);
        public string SetCompanyEmail(string email);
        public string SetCompanyLocation(string location);
        public string SetCompanyFocal(string focal);
        public bool SetIsConfirmed(bool isConfirmed);
    }
}
