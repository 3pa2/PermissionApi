using Permission.Business.Entities.Permissions;
using Permission.Contracts.Repositories;
using Permission.Database;

namespace Permission.Repositories.Repositories
{
    public class PermissionTypeRepository : RepositoryBase<PermissionType, PermissionContext>, IPermissionTypeRepository
    {
        public PermissionTypeRepository(PermissionContext context) : base(context)
        {
        }
    }
}
