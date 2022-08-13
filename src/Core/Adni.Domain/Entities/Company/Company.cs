using System;
using System.Collections.Generic;
using System.Text;
using Adni.Domain.ValueObjects;

namespace Adni.Domain.Entities
{
    //[BindProperty]
    public class Company
    {
        public Guid Id { get; /*private*/ set; }
        public Guid ProspectorId { get; /*private*/ set; }
        //public Guid CompanyListId { get; /*private*/ set; }
        public string CompanyName { get; /*private*/ set; }
        public string? CompanyDescription { get; /*private*/ set; }
        public string? CompanyCigle { get; /*private*/ set; }
        public string CompanyPhonenumber { get; /*private*/ set; }
        public string? CompanyEmail { get; /*private*/ set; }
        public string CompanyLocation { get; /*private*/ set; }
        public string CompanyFocal { get;/*private*/ set; }
        public bool IsConfirmed { get; set; }

        public Company(Guid id, Guid prospId)
        {
            //Constructor for companies objects
            //Change Guid to Guid to 
            if (id == default)
                throw new ArgumentNullException("Identifiant de l'entreprise incorrect", nameof(id));
            Id = id;
            ProspectorId = prospId;
        }
        public Company()
        {

        }

        public void SetCompanyName(string? name) => CompanyName = name;
        public void SetCompanyDescription(string? description) => CompanyDescription = description;
        public void SetCompanyCigle(string? cigle) => CompanyCigle = cigle;
        public void SetCompanyPhoneNumber(string? phoneNumber) => CompanyPhonenumber = phoneNumber;
        public void SetCompanyEmail(string? email) => CompanyEmail = email;
        public void SetCompanyLocation(string? location) => CompanyLocation = location;
        public void SetCompanyFocal(string focal) => CompanyFocal = focal;
        
    }
}
