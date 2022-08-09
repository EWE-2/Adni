using System;
using System.Collections.Generic;
using System.Text;
using Adni.Domain.ValueObjects;
using Adni.Domain.Interfaces.Date_Time;

namespace Adni.Domain.Entities
{
    public class Intership
    {
        public Guid InternId { get; set; }
        public Guid StartingGuid { get; set; } //Employee ayant lance la nouvelle session de stage
        public DateTime StartingDate { get; set; }
        public DateTime _endingDate { get; set; }
        public Guid CompanyId { get; set; }
        public IList<Department> DesiredDepartmentsList { get; set; }
        public IList<Field> DesiredFields { get; set; }
        public IList<int> PlacesDisponibles { get; set; }
        public IList<Student> SelectedStudentsList { get; set; }

        // Creation d'une session annuelle de stage
        public Intership()
        {
            SelectedStudentsList = new List<Student>();
            DesiredDepartmentsList = new List<Department>();
            DesiredFields = new List<Field>();
            PlacesDisponibles = new List<int>();
        }
    }
}
