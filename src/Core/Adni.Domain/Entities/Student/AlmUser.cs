using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class AlmUser : User
    {
        //Academic Informations
        public Guid FieldId { get; set; }
        public string? GraduateYear { get; set; }

        //Professionnal informations
        public string? ProStatus { get; set; }
        public Guid CompanyId { get; set; }
        public string? Position { get; set; }
        public string? Contrat { get; set; }
        public string? CompanyLocalisation { get; set; }
    }
}
