using System;

namespace Adni.Domain.Entities
{
    public class PlacesDisponibles
    {
        public Guid PlacesDisponiblesId { get;set; }
        /// <summary>
        /// Nombre de place disponibles pour une prospections
        /// </summary>
        public int NbrPlace { get; set; }
        /// <summary>
        /// Identifiant de la prospection parent
        /// </summary>
        public Guid ProspectionId { get; set; }
        /// <summary>
        /// Filiere ayant ce nombre de places.
        /// </summary>
        public Guid FieldId { get; set; }

        public Prospection? Prospection { get; set; }
    }
}