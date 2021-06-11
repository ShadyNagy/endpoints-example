using Ardalis.Endpoints.Core.Entities;
using Ardalis.Specification;

namespace Ardalis.Endpoints.Core.Specifications
{
    public class CompanyByNameSpec : Specification<Company>, ISingleResultSpecification
    {
        public CompanyByNameSpec(string name)
        {
            Query.Where(x => x.Name == name)
                .OrderBy(x => x.Name);
        }
    }
}
