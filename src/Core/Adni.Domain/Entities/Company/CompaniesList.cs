using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    internal class CompaniesList
    {
        public CompaniesList()
        {
            _companies = new List<Company>();
        }

        private IList<Company> _companies { get; set; }
        private Guid _companiesListId { get; set; }
    }
}
