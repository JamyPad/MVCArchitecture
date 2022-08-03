using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebApp.Models
{
    public class EmployeeDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? Type { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public DateTime? EmploymentDate { get; set; }
    }
}
