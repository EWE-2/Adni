using System;
using System.Collections.Generic;
using Adni.Domain;


namespace Adni.Domain.Entities.Employies
{
    public class ChefServStage : Employee
    {
        public Guid EmployeeId { get; set; }
        public bool IsOnline { get; set; }
        public string Position { get; private set; }

        public ChefServStage(Guid idValue)
        {
            if (idValue == default)
                throw new ArgumentNullException("L'identifiant ne peut etre vide ", nameof(idValue));
            EmployeeId = idValue;
            this.Position = "CSS";
        }

    }
}