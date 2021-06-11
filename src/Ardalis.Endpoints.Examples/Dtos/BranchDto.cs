using System;

namespace Ardalis.Endpoints.Examples.Dtos
{
    public class BranchDto
    {
        public Guid BranchId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
    }
}
