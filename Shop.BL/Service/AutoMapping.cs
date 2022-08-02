using AutoMapper;
using Shop.BL.DTO;
using Shop.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.Service
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            CreateMap<string, string>().ConvertUsing(s => s ?? string.Empty);
     
            CreateMap<EmployeeDTO, Employee>();
            CreateMap<Employee, EmployeeDTO>();


        }
    }
}
