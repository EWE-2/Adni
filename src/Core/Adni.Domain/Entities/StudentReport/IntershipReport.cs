using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    /// <summary>
    /// Classe de rapport de stage des etudiants
    /// </summary>
    public class InternshipReport
    {
        public Guid InternshipReportId { get; set; }
        /// <summary>
        /// <c>True</c> si le rapport de stage a ete depose
        /// </summary>
        public bool IsDeposed { get; set; }
        /// <summary>
        /// Identidiant du stage concerte
        /// </summary>
        public Guid InternshipId { get; set; }
        /// <summary>
        /// Identifiant de l'etudiant concerne
        /// </summary>
        public Guid Student { get; set; }
        /// <summary>
        /// Note de l'etudiant pour cette session de stage
        /// </summary>
        public int Note { get; set; }
    }
}
