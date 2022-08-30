using Adni.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities.Attribution
{
    public class Attribution
    {
        public Guid AttributionId {get;set;}
        public string AcademicYear { get; set; }
        public InternType InternType { get; set; }
        public Guid CompanyId { get; set; }
        public IList<Guid> StudentsListId { get; set; }
        
    }
}
