using AutoMapper;
using frontorigins.Application.services;
using frontorigins.Domain.entities;
using frontorigins.webapi.routing;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace frontorigins.webapi.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route(Routing.Employee)]
    [ApiController]
    public class EmployeeController : Controller
    {
        private IEmployeeService EmployeeService;
        private IMapper mapper;
        private readonly DbContext context;
        public EmployeeController(DbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet()]
        public IEnumerable<Employee> Index()
        {
            return null;

        }
    }
}
