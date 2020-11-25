using Microsoft.AspNetCore.Mvc;
using Permission.Business.Entities.DTO;
using Permission.Contracts.Repositories;
using System;
using System.Threading.Tasks;

namespace Permission.Api.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PermissionController: ControllerBase
    {
        private readonly IPermissionRequestRepository _permissionRequestRepository;
        public PermissionController(IPermissionRequestRepository permissionRequestRepository)
        {
            _permissionRequestRepository = permissionRequestRepository;
        }
        [HttpPost]
        public async Task<object> SavePermission([FromBody] PermissionRequest entity)
        {
            return new { Id = await _permissionRequestRepository.AddAsync(entity) };
        }

        [HttpPatch]
        public async Task UpdateEntity([FromBody] PermissionRequest entity)
        {
            await _permissionRequestRepository.UpdateAsync(entity);
        }

        [HttpDelete("{id}")]
        public async Task DeletePermission(Guid id)
        {
            await _permissionRequestRepository.DeleteByIdAsync(id);
        }


        [HttpGet]
        public async Task<object> GetPermission(Guid id)
        {
            return new { Id = await _permissionRequestRepository.GetByIdAsync(id) };
        }

        [HttpGet("all")]
        public async Task<object> GetAll()
        {
            return await _permissionRequestRepository.GetAllAsync();
        }

    }
}
