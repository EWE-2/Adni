using System;

namespace Adni.Domain.Entities
{
    public class PlacesDisponibles
    {
        public Guid PlacesDisponiblesId { get;set; }
        public int NbrPlace { get; set; }

        public Guid ProspectionId { get; set; }
        public Prospection Prospection { get; set; }
    }
}