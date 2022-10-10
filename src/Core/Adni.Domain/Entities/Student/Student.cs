using System;
using System.Collections.Generic;
using System.ComponentModel;
using Adni.Domain.Enums;

namespace Adni.Domain.Entities
{
    public class Student
    {
        //Identity user informations
        public Guid StudentId { get; set; }

        //User self information
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public char Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserLocation { get; set; }
        public string Dob { get; set; }

        public string? ImageDirectory { get; set; }

        public string? Matricule { get; set; }
        public string AcademicYear { get; set; }
        public int AcademicLevel { get; set; }
        public Guid FieldId { get; set; }
    }
}
