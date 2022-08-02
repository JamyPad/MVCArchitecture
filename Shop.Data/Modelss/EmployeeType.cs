using System;
using System.Collections.Generic;

#nullable disable

namespace Shop.Data.Modelss
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            Employees = new HashSet<Employee>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public decimal? Salary { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
