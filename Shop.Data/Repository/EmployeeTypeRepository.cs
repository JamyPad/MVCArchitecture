using Microsoft.EntityFrameworkCore;
using Shop.BL.IRepositories;
using Shop.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class EmployeeTypeRepository : Repository<EmployeeType>, IEmployeeTypeRepository
    {
        public EmployeeTypeRepository(codeContext context)
           : base(context)
        {
        }

        public new IQueryable<EmployeeType> All()
        {

            return _context.EmployeeTypes.IgnoreQueryFilters();
        }
    }
}
