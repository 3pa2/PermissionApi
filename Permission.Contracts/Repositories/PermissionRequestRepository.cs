using Permission.Business.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Contracts.Repositories
{
    public interface IPermissionRequestRepository
    {
        public Task<Guid> AddAsync(PermissionRequest permissionRequest);
        public Task UpdateAsync(PermissionRequest permissionRequest);
        public Task DeleteByIdAsync(Guid Id);
        public Task<PermissionView> GetByIdAsync(Guid Id);
        public Task<IEnumerable<PermissionView>> GetAllAsync();

    }
}
