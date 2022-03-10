using AutoMapper;
using AutomapperEx.Models;
using AutomapperEx.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomapperEx.Controllers
{
    [ApiController]
    [Route("getUser")]
    public class TestController : ControllerBase
    {
        private readonly IMapper mapper;
        public TestController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpGet]
        public UserViewModel MappedUser()
        {
            User user = GetUser();

            return mapper.Map<UserViewModel>(user);
        }
        private static User GetUser()
        {
            List<Employee> employeeList = new() { new Employee {Id =1, Adress="EmployeeAdres", Name="Ali",Surname="ali",Salary = 451254.55 } };
            List<Firm> firmList = new()
            {
                new Firm { Id = 1, Adress = "frmAdress", FirmName = "tazılım Firması", PersonCount = 500, TaxNumber = "00221122554" ,  Employee = employeeList}
            };
            return new User {
                Id = 1,
                FirstName = "Mikail",
                LastName = "Torun",
                Email = "ttest@test.com",
                Adress = "Bilinmiyor",
                JobExpression = "Computer Engineer",
                University = "Test University",
                Password = "password",
                UserName = "USername",
                WorkedFirms = firmList
            };
        }
    }
}
