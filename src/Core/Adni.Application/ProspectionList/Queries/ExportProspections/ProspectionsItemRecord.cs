using Adni.Application.Common.Mappings;
using Adni.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adni.Application.ProspectionList.Queries.ExportProspections
{
    public class ProspectionsItemRecord : IMapFrom<Prospection>
    {
        public string Name { get; set; }
        public string EmployeeName { get; set; }
    }
}
