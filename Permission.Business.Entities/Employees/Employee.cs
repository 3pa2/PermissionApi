

using Permission.Business.Entities.Contracts;
using System;
using System.Collections.Generic;

namespace Permission.Business.Entities.Employees
{
    public class Employee : EntityBase, IAuditableEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set ; }
        public DateTime? UpdatedAt { get; set; }
        public IEnumerable<Permissions.Permission> Permissions { get; set; }

    }
}
