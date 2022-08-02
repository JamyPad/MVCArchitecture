using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.DTO
{
    public class CreateEmployeeDTO
    {
        public EmployeeDTO employee;
        public List<SelectListItem> employeeTypes;



    }
}
