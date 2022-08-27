using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adni.Application.Dtos;


namespace Adni.Application.CompanyLists.GetCompanies
{
    public class CompaniesVm
    {
        public IList<CompanyDto> Lists { get; set; }
    }
}
