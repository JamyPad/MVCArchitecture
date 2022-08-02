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
    public class EmployeeTypeService : ServiceBase<EmployeeType, EmployeeTypeDTO>, IEmployeeTypeService
    {
        public EmployeeTypeService(IMapper mapper, IRepository<EmployeeType> repository)
            : base(mapper, repository)
        {

        }

        public new List<EmployeeTypeDTO> All()
        {
            var result = _repository.All();
            var model = _mapper.Map<List<EmployeeTypeDTO>>(result);
            return model;
        }
    }
}
