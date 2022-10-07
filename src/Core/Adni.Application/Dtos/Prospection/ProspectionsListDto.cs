using System;
using System.Collections.Generic;
using Adni.Domain.Entities;
using Adni.Application.Common.Mappings;

namespace Adni.Application.Dtos.Prospection;

public record ProspectionsListDto : IMapFrom<ProspectionsList>
{
    public ProspectionsListDto()
    {
        ProspectionRecap = new List<ProspectionDto>();
    }

    public Guid ProspectionsListId { get; set; }
    public IList<ProspectionDto> ProspectionRecap { get; set; }
    public string Observation { get; set; }

}
