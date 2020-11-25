using Permission.Business.Entities.Employees;
using Permission.Contracts.Repositories;
using Permission.Database;

namespace Permission.Repositories.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee,PermissionContext>, IEmployeeRepository
    {
        public EmployeeRepository(PermissionContext context) : base(context)
        {
        }
    }
}
