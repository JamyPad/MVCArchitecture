using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.BL.DTO;
using Shop.BL.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        protected IServiceBase<EmployeeDTO> _employeeService;
        protected IServiceBase<EmployeeTypeDTO> _employeeTypeService;
        public EmployeeController(IServiceBase<EmployeeDTO> employeeService, IServiceBase<EmployeeTypeDTO> employeeTypeService)
        {
            _employeeService = employeeService;
            _employeeTypeService = employeeTypeService;
        }

        public IActionResult Index()
        {
           var results=  _employeeService.GetAll();

            return View("../Employee/Employee",results);
        }
        public IActionResult Add(CreateEmployeeDTO createEmployeeDTO,EmployeeDTO employee)
        {
            if (employee != null)
            {

                var results = _employeeService.Add(employee);
            }

            var employeeTypes = _employeeTypeService.GetAll();
            if (employeeTypes != null)

            {
                ViewBag.Employees = new List<SelectListItem>();
                foreach (var item in employeeTypes)
                {
                    var iddd = new SelectListItem { Text = item.Name, Value = item.Id.ToString() };
                    ViewBag.Employees.Add(iddd);

                }
            }
            
                
        
               
            //}
            //var entty = new EmployeeDTO() { Address = "Add2", Name = "NameTest", Telephone = "tel" };
            //var copy = employee;
          

            return View("../Employee/Add");
        }


        public ActionResult ShowResult(string msg)
        {
            TempData["alertMessage"] = msg;
            return View();
        }
    }
}
