using Microsoft.AspNetCore.Mvc;
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
        protected IServiceBase<EmployeeDTO> _service;
        public EmployeeController(IServiceBase<EmployeeDTO> service)
        {
            _service = service;
        }

        //public EmployeeController()
        //{
        //}
        public IActionResult Index()
        {
           var results=  _service.GetAll();
            ShowResult(results.ToString());
            return View();
        }

        public ActionResult ShowResult(string msg)
        {
            TempData["alertMessage"] = msg;
            return View();
        }
    }
}
