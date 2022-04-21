using System;
using System.Collections.Generic;
using Adni.Domain;


namespace Adni.Domain.Entities
{
    public class ChefServStage : Employee, Interfaces.IQueryEmployee
    {
        private Guid Id { get; set; }
        private bool IsOnline = false;

        public ChefServStage(Guid idValue)
        {
            if (idValue == default)
                throw new ArgumentNullException("L'identifiant ne peut etre vide ", nameof(idValue));
            Id = idValue;
        }

        //Behavior to get informations of employees
        public void GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public void GetEmployee(Guid idValue)
        {
            throw new NotImplementedException();
        }
    }
}