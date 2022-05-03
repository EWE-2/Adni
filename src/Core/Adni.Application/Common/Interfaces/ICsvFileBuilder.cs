using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adni.Application.CompanyLists.Queries.ExportCompanies;

namespace Adni.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildCompaniesFile(IEnumerable<CompanyItemRecord> records);
    }
}
