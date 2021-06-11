using System;
using Ardalis.Endpoints.SharedKernel.Interfaces;

namespace Ardalis.Endpoints.Core.Entities
{
    public class Company : IAggregateRoot
    {
        private Company()
        {
            // EF required
        }

        public Company(Guid companyId, string name)
        {
            CompanyId = companyId;
            Name = name;
        }

        public Guid CompanyId { get; private set; }
        public string Name { get; private set; }
    }
}
