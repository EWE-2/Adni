using Adni.Application.Common.Mappings;
using Adni.Domain.Entities;

namespace Adni.Application.CompanyLists.Queries.ExportCompanies;

public class CompanyItemRecord: IMapFrom<Company>
{
    public string Name { get; set; }
    public string MapLocation { get; set; }
}
