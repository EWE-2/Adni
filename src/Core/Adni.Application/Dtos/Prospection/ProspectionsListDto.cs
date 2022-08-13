using System;
using System.Collections.Generic;
using Adni.Domain.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adni.Application.Common.Mappings;
using AutoMapper;

namespace Adni.Application.Dtos.Prospection
{
    public class ProspectionsListDto : IMapFrom<ProspectionsList>
    {
        public ProspectionsListDto()
        {
            ProspectionRecap = new List<ProspectionDto>();
        }

        public Guid ProspectionsListId { get; set; }
        public IList<ProspectionDto> ProspectionRecap { get; set; }
        public string Observation { get; set; }

    }
}
