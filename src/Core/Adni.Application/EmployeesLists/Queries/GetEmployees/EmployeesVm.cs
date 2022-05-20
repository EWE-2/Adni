using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adni.Application.Dtos.Employee;


namespace Adni.Application.EmployeesLists.GetEmployees
{
    public class EmployeesVm
    {
        public IList<EmployeeDto> Lists { get; set; }
    }
}
