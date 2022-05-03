using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class CompaniesList
    {
        public CompaniesList()
        {
            _companies = new List<Company>();
        }

        public IList<Company> _companies { get;set; }
        public Guid _companiesListId { get;set; }
        public string City { get;set; }
    }
}
