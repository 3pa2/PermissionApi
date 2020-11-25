using Permission.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permission.Repositories.Repositories
{
    public class PermissionRepositoryData<TEntity> :RepositoryBase<TEntity,PermissionContext> where TEntity: class, new ()
    {
        public PermissionRepositoryData(PermissionContext context): base(context)
        {

        }
    }
}
