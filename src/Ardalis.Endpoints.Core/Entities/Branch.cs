using System;
using Ardalis.Endpoints.SharedKernel.Interfaces;

namespace Ardalis.Endpoints.Core.Entities
{
    public class Branch : IAggregateRoot
    {
        private Branch()
        {
            // EF required
        }

        public Branch(Guid branchId, Guid companyId, string name)
        {
            BranchId = branchId;
            CompanyId = companyId;
            Name = name;
        }

        public Guid BranchId { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
    }
}
