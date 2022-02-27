using System;
using System.Collections.Generic;
using System.Text;
using Adni.Domain.ValueObjects;

namespace Adni.Domain.Entities
{
    internal class Company
    {
        public Guid Id { get; private set; }
        private ActorId _prospectorId;

        public Company(Guid id, ActorId prospId)
        {
            if (id == default)
                throw new ArgumentNullException("Identifiant de l'entreprise incorrect",nameof(id));
            Id = id;
            _prospectorId = prospId;
        }

        public void SetCompanyName( string name) => _name = name;
        public void SetCompanyDescription( string description) => _description = description;
        public void SetCompanyCigle(string cigle) => _cigle = cigle;
        public void SetCompanyPhoneNumber(string phoneNumber) => _phoneNumber = phoneNumber;
        public void SetCompanyEmail(string email) => _email = email;
        public void SetCompanyLocation(string location) => _location = location;
        public void SetCompanyFocal(string focal) => _focal = focal;

        /// <summary>
        /// Company's informations
        /// </summary>
        private string _name;
        private string _description;
        private string _cigle;
        private string _phoneNumber;
        private string _email;
        private string _location;
        private string _focal;
    }
}
