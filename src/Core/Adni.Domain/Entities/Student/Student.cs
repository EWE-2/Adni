using System;
using System.Collections.Generic;
using System.Text;
using Adni.Domain.Enums;
namespace Adni.Domain.Entities
{
    public class Student : User
    {

        public string Matricule { get; set; }
        public List<int> AcademicYear { get; set; }
        public AcademicLevel AcademicLevel { get; set; }
        
        public Guid FieldId { get; set; }
        public Guid CurrentHiringCompanyId { get; set; }
    }
}
