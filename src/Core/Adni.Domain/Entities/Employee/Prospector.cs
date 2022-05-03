using System;
using System.Collections.Generic;
using Adni.Domain;


namespace Adni.Domain.Entities.Employies
{
    public class Prospector : Employee
    {
        public Guid EmployeeId { get; set; }
        public bool IsOnline { get; set; }
        public string Position { get; private set; }

        public Prospector()
        {
            this.Position = "Prospect";
        }
        public Prospector(Guid idValue)
        {
            if (idValue == default)
                throw new ArgumentNullException("L'identifiant ne peut etre vide ", nameof(idValue));
            EmployeeId = idValue;
            this.Position = "Prospect";
        }

    }
}