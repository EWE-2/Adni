using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adni.Domain.Entities;
using Adni.Application.Common.Mappings;

namespace Adni.Application.Dtos.Company
{
    public class CompanyListDto : IMapFrom<CompaniesList>
    {
        public CompanyListDto()
        {
            Items = new List<CompanyDto>();
        }

        public IList<CompanyDto> Items { get; set; }
        public Guid Id { get; set; }
        public string City { get; set; }
    }
}
