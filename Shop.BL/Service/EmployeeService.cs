
using AutoMapper;
using Shop.BL.DTO;
using Shop.BL.IRepositories;
using Shop.BL.IService;
using Shop.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.Service
{
   public class EmployeeService : ServiceBase<Employee, EmployeeDTO>, IEmployeeService
    {
        public EmployeeService(IMapper mapper,IRepository<Employee> repository)
            : base(mapper, repository)
        {
          
        }

        public new List<EmployeeDTO> All()
        {
            var result= _repository.All();
            var model = _mapper.Map<List<EmployeeDTO>>(result);
            return model;
        }
    }
}
