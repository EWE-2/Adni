using System;

namespace Adni.Domain.Interfaces
{
    internal interface IQueryEmployee
    {
        public void GetAllEmployees();
        public void GetEmployee(Guid idValue);
    }
}