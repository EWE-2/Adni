﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class Prospection
    {
        public Guid ProspectionId { get; set; }
        public Guid SessionId { get; set; } //Id de la session de stage
        public Guid EmployeeProspectorId { get;set; }
        public Guid CompanyId { get; set; }
        public IList<Guid> DesiredDepartmentsList { get; set; }
        public IList<Guid> DesiredFields { get; set; }
        public IList<int> PlacesDisponibles { get; set; }

    }
}