using frontorigins.Application.services;
using frontorigins.Infrastructure.database;
using frontorigins.Infrastructure.repositories;
using frontorigins.Infrastructure.unitofwork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Application.configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServiceConnector(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
            return services;

           

        }
    }
}
