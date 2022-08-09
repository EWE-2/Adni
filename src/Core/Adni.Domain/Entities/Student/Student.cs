using System;
using System.Collections.Generic;
using System.Text;
using Adni.Domain.Enums;
using Adni.Domain.ValueObjects;

namespace Adni.Domain.Entities
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public string Phonenumber { get; set; }
        public string WhatsappNumber { get; set; }
        public DateTime DoB { get; set; }
        public string Matricule { get; set; }
        public List<int> AcademicYear { get; set; }
        public AcademicLevel AcademicLevel { get; set; }
        
        public Guid FieldId { get; set; }
    }
}
