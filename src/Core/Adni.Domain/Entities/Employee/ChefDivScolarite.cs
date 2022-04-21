using System;
using System.Collections.Generic;
using System.Text;
using Adni.Domain;
using Adni.Domain.ValueObjects;

namespace Adni.Domain.Entities
{
    public class ChefDivScolarite : Employee, Interfaces.ICommandEmployee, Interfaces.IQueryEmployee , Interfaces.IDelEmployee
    {
        private Guid Id { get; set; }
        private bool IsOnline = false;

        //contruction of CDS
        public ChefDivScolarite(Guid idValue)
        {
            if (idValue == default)
                throw new ArgumentNullException("L'identifiant ne peut etre vide", nameof(idValue));

            Id = idValue ;
        }


        //Behavior refering to make command or query to an employee
        public void AddEmployee()
        {

        }
        public void UpdateEmployee(Guid idValue)
        {

        }
        public void GetEmployee(Guid idValue)
        {

        }
        public void GetAllEmployees()
        {

        }
        public bool DeleEmployee(Guid idValue)
        {
            if (idValue == default)
                throw new ArgumentNullException("L'identifiant ne peut etre vide", nameof(idValue));

            return true;
            
        }
    }
}