using System;
using System.Collections.Generic;
using Adni.Domain.Enums;

namespace Adni.Domain.Entities
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Email { get; set; }
        public string? Location { get; set; }
        public string? Phonenumber { get; set; }
        public string? WhatsappNumber { get; set; }
        public string? DoB { get; set; }
        public string? Matricule { get; set; }
        public string AcademicYear { get; set; }
        public int AcademicLevel { get; set; }
        public Guid FieldId { get; set; }
    }
}
