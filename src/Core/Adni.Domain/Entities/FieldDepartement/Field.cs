using System;

namespace Adni.Domain.Entities
{
    public class Field
    {
        public Guid FieldId { get; set; }
        public Guid DepartmentId { get; set; }
        public string FieldName { get; set; }
        public string? FieldDescription { get; set; }
        public string FieldCigle { get; set; }
    }
}
