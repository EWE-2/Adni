using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class ProspectionsList
    {
        public ProspectionsList()
        {
            ProspectionRecap = new List<Prospection>();
        }
        public Guid ProspectionsListId { get; set; }
        public IList<Prospection> ProspectionRecap { get; set; }
        public string? Observation { get; set; }
    }
}
