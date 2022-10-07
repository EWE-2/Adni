using System;
using System.Collections.Generic;
using Adni.Domain.Entities;
using Adni.Application.Common.Mappings;

namespace Adni.Application.Dtos;

public record CompanyListDto : IMapFrom<CompaniesList>
{
    public CompanyListDto()
    {
        Items = new List<CompanyDto>();
    }

    public IList<CompanyDto> Items { get; set; }
    public Guid Id { get; set; }
    public string City { get; set; }
}
