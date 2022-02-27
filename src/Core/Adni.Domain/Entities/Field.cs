using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    internal class Field
    {
        public Guid Id { get; private set; }

        public Field (Guid id)
        {
            if(id == default)
                throw new ArgumentNullException();
            Id = id;
        }

        public void SetFieldName(string name) => _name = name;
        public void SetFieldDescription(string description) => _description = description;
        public void SetFieldCigle(string cigle) => _cigle = cigle;

        /// <summary>
        /// Field's informations
        /// </summary>
        private string _name;
        private string _description;
        private string _cigle;
    }
}
