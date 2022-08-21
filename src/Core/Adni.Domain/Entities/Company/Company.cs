using System;

namespace Adni.Domain.Entities
{
    public class Company
    {
        public Guid Id { get; set; }
        public Guid ProspectorId { get; set; }
        //public Guid CompanyListId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyDescription { get; set; }
        public string? CompanyCigle { get; set; }
        public string? CompanyPhonenumber { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanyLocation { get; set; }
        public string? CompanyFocal { get; set; }
        public bool IsConfirmed { get; set; }

    }
}
