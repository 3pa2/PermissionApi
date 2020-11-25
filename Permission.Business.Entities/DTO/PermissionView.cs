using System;

namespace Permission.Business.Entities.DTO
{
    public class PermissionView
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Guid PermissionTypeId { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
