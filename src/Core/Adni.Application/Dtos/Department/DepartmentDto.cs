using Adni.Application.Common.Mappings;
using System;
using System.Collections.Generic;

namespace Adni.Application.Dtos
{
    public class DepartmentDto : IMapFrom<Domain.Entities.Department>
    {
        public Guid DepartmentId { get; set; }
        public Guid HeadDepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public IList<FieldDto> Fields { get; set; }

        public DepartmentDto()
        {
            Fields = new List<FieldDto>();
        }
    }
}
