using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adni.Application.Dtos.Company;


namespace Adni.Application.CompanyLists.GetCompanies
{
    public class EmployeesVm
    {
        public IList<CompanyDto> Lists { get; set; }
    }
}
