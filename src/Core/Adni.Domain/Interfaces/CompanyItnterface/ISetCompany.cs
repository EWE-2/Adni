using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Interfaces
{
    public interface ISetCompany
    {
        public void SetCompanyName(string name);
        public void SetCompanyDescription(string description);
        public void SetCompanyCigle(string cigle);
        public void SetCompanyPhoneNumber(string phoneNumber);
        public void SetCompanyEmail(string email);
        public void SetCompanyLocation(string location);
        public void SetCompanyFocal(string focal);
    }
}
