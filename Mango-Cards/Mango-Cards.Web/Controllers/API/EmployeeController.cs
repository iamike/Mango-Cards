using AutoMapper;
using Mango_Cards.Library.Models;
using Mango_Cards.Library.Services;
using Mango_Cards.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mango_Cards.Web.Controllers.API
{
    public class EmployeeController : BaseApiController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public object Get()
        {
            Mapper.Reset();
            Mapper.CreateMap<Employee, EmployeeModel>();
            return _employeeService.GetEmployees().Select(Mapper.Map<Employee, EmployeeModel>);
        }
    }
}
