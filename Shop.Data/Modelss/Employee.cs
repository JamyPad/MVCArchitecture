using System;
using System.Collections.Generic;

#nullable disable

namespace Shop.Data.Modelss
{
    public partial class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? Type { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public DateTime? EmploymentDate { get; set; }

        public virtual EmployeeType EmployeeType { get; set; }
    }
}
