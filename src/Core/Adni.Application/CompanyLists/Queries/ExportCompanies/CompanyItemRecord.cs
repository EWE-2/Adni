using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adni.Application.Common.Mappings;
using Adni.Domain.Entities;

namespace Adni.Application.CompanyLists.Queries.ExportCompanies
{
    public class CompanyItemRecord: IMapFrom<Company>
    {
        public string Name { get; set; }
        public string MapLocation { get; set; }
    }
}
