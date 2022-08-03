using NUnit.Framework;
using Shop.BL.DTO;
using Shop.BL.IRepositories;
using Shop.BL.IService;
using Shop.BL.Models;
using Shop.BL.Service;
using Shop.Data.Repository;
using System;
using System.Linq;

namespace ShopApp.UnitTests
{
    public class EmployeeServiceTest
    {
        static codeContext _context;

        private IEmployeeRepository _employeeRepository;  
        public EmployeeServiceTest()
        {
            _context = new codeContext(); ;
            _employeeRepository = new EmployeeRepository(_context);
        }



        [Test]
        public void EmployeeServicetest_get_works()
        {
            //Arrange


            //Act
            var employees = _employeeRepository.All();
            //Assert
            Assert.That(employees, Is.Not.EqualTo(null));
        }
        [Test]
        public void EmployeeServicetest_add_works()
        {
            //Arrange
            var employee = new Employee() { Name = "NameTest", Address = "AddressTest", Telephone = "45465" };

            //Act
            var result = _employeeRepository.Add(employee);
            //Assert
            Assert.That(employee, Is.EqualTo(result));
        }





    }
}
