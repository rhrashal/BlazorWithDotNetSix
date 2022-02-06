using EmployeeManagement.Models;

namespace EmployeeManagement.Api.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int employeeId);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
    }

}
