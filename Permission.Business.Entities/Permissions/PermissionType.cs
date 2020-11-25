using Permission.Business.Entities.Contracts;
using System;
using System.Collections.Generic;

namespace Permission.Business.Entities.Permissions
{
    public  class PermissionType : EntityBase, IAuditableEntity
    {
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public IEnumerable<Permission> Permissions { get; set; }

    }
}
