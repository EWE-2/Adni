using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class CompaniesList
    {
        public CompaniesList()
        {
            Companies = new List<Company>();
        }

        public Guid CompaniesListId { get;set; }
        public IList<Company> Companies { get;set; }
        public string City { get;set; }
    }
}
