using EmployeeManagement.Models;

namespace EmployeeManagement.Api.Repository
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);
    }
}
