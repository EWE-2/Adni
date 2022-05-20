using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adni.Application.CompanyLists.Queries.ExportCompanies;
using Adni.Application.EmployeesLists.Queries.ExportEmployees;

namespace Adni.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildCompaniesFile(IEnumerable<CompanyItemRecord> records);
        byte[] BuildEmployeesFile(IEnumerable<EmployeeItemRecord> records);
    }
}
