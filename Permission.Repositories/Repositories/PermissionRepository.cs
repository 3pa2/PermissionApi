using Permission.Business.Entities.Employees;
using Permission.Contracts.Repositories;
using Permission.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permission.Repositories.Repositories
{
    public class PermissionRepository : RepositoryBase<Business.Entities.Permissions.Permission,PermissionContext>, IPermissionRepository
    {
        public PermissionRepository(PermissionContext context) : base(context)
        {
        }
    }
}
