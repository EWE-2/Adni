using System;

namespace Adni.Domain.Entities
{
    public class AnnualSession
    {
        public Guid SessionId { get; set; }
        public string? SessionName { get; set; }
        public Guid EmployeeId { get; set; } // Personnel ayant lance la session de stage
        public DateTime AcademicSession { get; set; } //Annee academique exemple 2021-2022
    }
}
