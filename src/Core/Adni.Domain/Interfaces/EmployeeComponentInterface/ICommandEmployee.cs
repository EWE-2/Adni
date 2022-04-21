using System;

namespace Adni.Domain.Interfaces
{
    internal interface ICommandEmployee
    {
        public void AddEmployee();
        public void UpdateEmployee(Guid idValue);
    }
}