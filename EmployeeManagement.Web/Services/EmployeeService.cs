﻿namespace EmployeeManagement.Web.Services
{
    using global::EmployeeManagement.Models;
    using Microsoft.AspNetCore.Components;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    namespace EmployeeManagement.Web.Services
    {
        public class EmployeeService : IEmployeeService
        {
            private readonly HttpClient httpClient;

            public EmployeeService(HttpClient httpClient)
            {
                this.httpClient = httpClient;
            }

            public async Task<IEnumerable<Employee>> GetEmployees() => await httpClient.GetFromJsonAsync<Employee[]>("api/employees");
        }
    }
}