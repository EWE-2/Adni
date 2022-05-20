using System;
using System.Collections.Generic;
using System.Text;
using Adni.Domain;
using Adni.Domain.ValueObjects;

namespace Adni.Domain.Entities
{
    public class ChefDivScolarite : Employee
    {
        public Guid EmployeeId { get; set; }
        public bool IsOnline { get; set; }
        public string Position { get; private set; }

        //contruction of CDS
        public ChefDivScolarite(Guid idValue)
        {
            if (idValue == default)
                throw new ArgumentNullException("L'identifiant ne peut etre vide", nameof(idValue));

            EmployeeId = idValue ;
            this.Position = "CDD";
        }
    }
}