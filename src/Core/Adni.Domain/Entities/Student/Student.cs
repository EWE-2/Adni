using System;
using System.Collections.Generic;
using System.Text;
using Adni.Domain.Enums;
namespace Adni.Domain.Entities
{
    public class Student : Employee
    {
        public string Matricule { get; set; }
        public List<int> AcademicYear { get; set; }
        public AcademicLevel AcademicLevel { get; set; }
        
        public Student()
        {
            this.Position = "STD";
            this.IsOnline = false;
        }
    }
}
