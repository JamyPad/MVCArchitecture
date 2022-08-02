using Shop.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.BL.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Shop.Data.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(codeContext context)
           : base(context)
        {
        }

        public new IQueryable<Employee> All()
        {

             return _context.Employees.IgnoreQueryFilters();
        }
    }
}
