using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class Field
    {
        public Guid FieldId { get; set; }
        public Guid DepartmentId { get; set; }
        public string FieldName { get; set; }
        public string FieldDescription { get; set; }
        public string FieldCigle { get; set; }
    }
}
