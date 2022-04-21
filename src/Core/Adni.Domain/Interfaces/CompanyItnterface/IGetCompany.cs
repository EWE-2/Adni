using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Interfaces
{
    public interface IGetCompany
    {
        public string GetCompanyName();
        public string GetCompanyDescription();
        public string GetCompanyCigle();
        public string GetCompanyPhoneNumber();
        public string GetCompanyEmail();
        public string GetCompanyLocation();
        public string GetCompanyFocal();
    }
}
