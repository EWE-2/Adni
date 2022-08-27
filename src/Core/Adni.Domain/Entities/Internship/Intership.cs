using System;
using System.Collections.Generic;

namespace Adni.Domain.Entities //A REVOIR ENTIEREMENT
{
    /**
     * <summary> Classe <c>Intership</c> est une classe de mise en stage ayant
     * </summary>
     */
    public class Intership
    {
        public Guid InternshipId { get; set; }
        public Guid StartingGuid { get; set; } //Employee ayant lance la nouvelle session de stage
        public DateTime StartingDate { get; set; }
        public DateTime _endingDate { get; set; }
        public Guid CompanyId { get; set; }
        // public IList<Department> DesiredDepartmentsList { get; set; }
        public IList<Field> DesiredFields { get; set; }
        public IList<int> PlacesDisponibles { get; set; }
        public IList<Student> SelectedStudentsList { get; set; }

        // Creation d'une session annuelle de stage
        public Intership()
        {
            SelectedStudentsList = new List<Student>();
            // DesiredDepartmentsList = new List<Department>();
            DesiredFields = new List<Field>();
            PlacesDisponibles = new List<int>();
        }
    }
}
