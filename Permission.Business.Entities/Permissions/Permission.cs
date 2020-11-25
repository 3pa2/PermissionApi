using Permission.Business.Entities.Contracts;
using Permission.Business.Entities.Employees;
using System;

namespace Permission.Business.Entities.Permissions
{
    public class Permission : EntityBase, IAuditableEntity
    {
        public DateTime RequestDate { get; set; }
        public Employee Employees { get; set; }
        public Guid EmployeeId { get; set; }
        public PermissionType PermissionTypes { get; set; }
        public Guid PermissionTypeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }

}
