using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class Prospection
    {
        public Guid ProspectionId { get; set; }
        /// <summary>
        /// Identifiant de la session de stage
        /// </summary>
        public string AcademicYear { get; set; } //Id de la session de stage
        /// <summary>
        /// Identifiant du personnel ayant effectue la prospection
        /// </summary>
        public Guid EmployeeProspectorId { get;set; }
        /// <summary>
        ///Identifiant de l'entreprise prospectee
        /// </summary>
        public Guid CompanyId { get; set; }
        // public IList<Department> DesiredDepartmentsList { get; set; }

        /// <summary>
        /// propriete de navigation sur les filieres. <c>Fields</c> est la liste des filieres desirees
        /// </summary>
        public IList<Field>? DesiredFields { get; set; }
        /// <summary>
        /// <c>PlacesDisponibles</c> est la liste des places disponible pour chaque filiere de la liste/collection
        /// <c>DesiredFields</c>.
        /// </summary>
        public IList<PlacesDisponibles>? PlacesDisponibles { get; set; }

    }
}
