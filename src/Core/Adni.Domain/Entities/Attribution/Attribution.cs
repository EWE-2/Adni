using System;

namespace Adni.Domain.Entities
{
    public class Attribution
    {
        public Guid AttributionId {get;set;}
        /// <summary>
        /// Identifiant du moniteur ayant effecte l'attribution de stage
        /// </summary>
        public Guid EmployeeId { get; set; }
        /// <summary>
        /// Annee academique de la session de stage
        /// </summary>
        public string AcademicYear { get; set; }
        /// <summary>
        /// type du stage
        /// </summary>
        public string? InternType { get; set; }
        ///// <summary>
        ///// Entreprise attribue 
        ///// </summary>
        //public Guid CompanyId { get; set; }
        /// <summary>
        /// Etudiant beneficiaire
        /// </summary>
        public Guid Student { get; set; }
        /// <summary>
        /// Identifiant de la prospection
        /// </summary>
        public Guid ProspectionId { get; set; }

    }
}
