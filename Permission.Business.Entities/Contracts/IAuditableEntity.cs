using System;

namespace Permission.Business.Entities.Contracts
{
    public interface IAuditableEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
